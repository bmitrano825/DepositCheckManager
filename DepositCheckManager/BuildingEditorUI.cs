using System;
using System.Windows.Forms;

namespace DepositCheckManager
{
    public partial class BuildingEditorUI : Form
    {
        public BuildingEditorUI()
        {
            InitializeComponent();
        }


        private void BuildingEditorUI_Load(object sender, EventArgs e)
        {
            PopulateBuildingList();
            PopulateAccountList();
        }

        private void PopulateBuildingList()
        {
            listBoxBuildings.Items.Clear();
            foreach (var building in SqliteDataAccess.LoadBuildings())
            {
                listBoxBuildings.Items.Add(building.BuildingName);
            }
        }
        private void PopulateAccountList()
        {
            listBoxAccounts.Items.Clear();
            foreach (var account in SqliteDataAccess.LoadAccounts())
            {
                listBoxAccounts.Items.Add(account.AccountName);
            }
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            if (txtBuildingName.Text.Length > 0)
            {
                BuildingModel b = new BuildingModel();
                b.BuildingName = txtBuildingName.Text;
                SqliteDataAccess.SaveBuilding(b);
                PopulateBuildingList();
                txtBuildingName.Text = "";
            }
            else
            {
                MessageBox.Show("Building name not entered.");
            }

        }

        private void btnDeleteBuilding_Click(object sender, EventArgs e)
        {
            if (listBoxBuildings.SelectedIndex != -1)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BuildingModel b = new BuildingModel();
                    b.BuildingName = listBoxBuildings.SelectedItem.ToString();
                    SqliteDataAccess.DeleteBuilding(b);
                    PopulateBuildingList();
                }
            }
            else
            {
                MessageBox.Show("No building selected from list.");
            }

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Length > 0)
            {
                AccountModel a = new AccountModel();
                a.AccountName = txtAccountName.Text;
                SqliteDataAccess.SaveAccount(a);
                PopulateAccountList();
                txtAccountName.Text = "";
            }
            else
            {
                MessageBox.Show("Account name not entered.");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedIndex != -1)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    AccountModel a = new AccountModel();
                    a.AccountName = listBoxAccounts.SelectedItem.ToString();
                    SqliteDataAccess.DeleteAccount(a);
                    PopulateAccountList();
                }
            }
            else
            {
                MessageBox.Show("No account selected from list.");
            }
        }
    }
}
