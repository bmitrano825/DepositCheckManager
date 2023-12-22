using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NAPS2.Images;
using NAPS2.Images.Gdi;
using NAPS2.Scan;
using System.Windows.Forms;

public class Scanner
{
    public static async Task ScanAndSave(string filepath, string buildingName, string year, string month)
    {
        string fullFolderPathMonthYear = Path.Combine(filepath, buildingName, year, month);
        Directory.CreateDirectory(fullFolderPathMonthYear);

        using (ScanningContext scanningContext = new ScanningContext(new GdiImageContext()))
        {
            scanningContext.SetUpWin32Worker();

            var controller = new ScanController(scanningContext);
            var devices = await controller.GetDeviceList(Driver.Twain);
            var neatScanner = devices.FirstOrDefault(d => d.Name.Contains("Neat"));

            var options = new ScanOptions
            {
                Device = neatScanner,
                Dpi = 150
            };

            if (devices.Any())
            {
                try
                {
                    await foreach (var image in controller.Scan(options))
                    {
                        var imageGUID = Guid.NewGuid();

                        var originalImagePath = fullFolderPathMonthYear + "\\" + imageGUID + ".jpg";

                        image.Save(originalImagePath);

                        CompressImage(originalImagePath, originalImagePath + "_compressed.jpg", 10);

                        if (File.Exists(originalImagePath))
                        {
                            File.Delete(originalImagePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle specific TwainException error messages
                    if (ex.Message.Contains("Feeder is empty"))
                    {
                        Console.WriteLine("Feeder is empty. Please load documents before scanning.");
                    }
                    else
                    {
                        Console.WriteLine($"Scanning error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No scanning devices found.");
            }
        }
    }

    public static void CompressImage(string SoucePath, string DestPath, int quality)
    {

        using (Bitmap bmp1 = new Bitmap(SoucePath))
        {
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder QualityEncoder = System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(QualityEncoder, quality);

            myEncoderParameters.Param[0] = myEncoderParameter;
            bmp1.Save(DestPath, jpgEncoder, myEncoderParameters);

        }
    }

    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}