using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DepositCheckManager
{
    public partial class DepositCheckManagerForm : Form
    {
        string folderPath = string.Empty;

        public DepositCheckManagerForm()
        {
            InitializeComponent();
        }

        private void DepositCheckManagerForm_Load(object sender, EventArgs e)
        {
            SqliteDataAccess.CreateDBs();
            SqliteDataAccess.CreateSettings();
            folderPath = LoadSetting("FolderLocation");
            txtFolderLocation.Text = folderPath;
            LoadBuildingList();
            dateTimeMonth.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0, 0);
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (comboBuildingName.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a building first.");
            }
            else
            {
                ScanImages();
            }
        }

        private async void ScanImages()
        {
            if (folderPath == null)
            {
                MessageBox.Show("You must select a folder path under File > Set Folder Path");
            }
            else
            {
                btnScan.Enabled = false;
                btnScan.Text = "Scanning...";
                await Scanner.ScanAndSave(folderPath, comboBuildingName.SelectedItem.ToString(), dateTimeYear.Value.ToString("yyyy"), dateTimeMonth.Value.ToString("MMMM"));
                btnScan.Enabled = true;
                btnScan.Text = "Scan/Save";
            }

        }

        private void LoadBuildingList()
        {
            comboBuildingName.Items.Clear();
            foreach (var building in SqliteDataAccess.LoadBuildings())
            {
                comboBuildingName.Items.Add(building.BuildingName);
            }
        }

        private string LoadSetting(string settingName)
        {
            foreach (var setting in SqliteDataAccess.LoadSettings(settingName))
            {
                if (setting.SettingsValue != null)
                {
                    return setting.SettingsValue;
                }

            }
            return null;
        }

        private void setFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            SettingsModel folderLocation = new SettingsModel();
            folderLocation.SettingsName = "FolderLocation";
            folderLocation.SettingsValue = folderPath;

            SqliteDataAccess.UpdateFolderLocation(folderLocation);

            txtFolderLocation.Text = folderPath;
        }



        private void editBuildingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingEditorUI buildingEditorUI = new BuildingEditorUI();
            buildingEditorUI.ShowDialog();
            LoadBuildingList();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", folderPath);
        }

    }
}
