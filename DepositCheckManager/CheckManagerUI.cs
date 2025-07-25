using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DepositCheckManager.Enums;

namespace DepositCheckManager
{
    public partial class DepositCheckManagerForm : Form
    {
        string folderPath = string.Empty;
        int selectedScan = 1;
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
            rbScanOption_1.Checked = true;
            LoadBuildingList();

        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (comboBuildingName.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a building/account first.");
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
                if(selectedScan == (int)scanType.Deposit)
                {
                    await Scanner.ScanAndSaveDeposit(folderPath, comboBuildingName.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy"), dateTimePicker1.Value.ToString("MMMM"), dateTimePicker1.Value.ToString("dd"));
                }
                else
                {
                    await Scanner.ScanAndSaveBuildingChecks(folderPath, comboBuildingName.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy"), dateTimePicker1.Value.ToString("MMMM"), dateTimePicker1.Value.ToString("dd"));
                }
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

        private void LoadAccountList()
        {
            comboBuildingName.Items.Clear();
            foreach (var account in SqliteDataAccess.LoadAccounts())
            {
                comboBuildingName.Items.Add(account.AccountName);
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

        private void rbScanOption_2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Account:";
            LoadAccountList();
            selectedScan = (int)scanType.Deposit;
            panel1.BackColor = Color.YellowGreen;
        }

        private void rbScanOption_1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Building:";
            LoadBuildingList();
            selectedScan = (int)scanType.BuildingCheck;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
