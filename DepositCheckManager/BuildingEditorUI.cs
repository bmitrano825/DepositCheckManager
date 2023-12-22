using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void PopulateBuildingList()
        {
            listBoxBuildings.Items.Clear();
            foreach (var building in SqliteDataAccess.LoadBuildings())
            {
                listBoxBuildings.Items.Add(building.BuildingName);
            }
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            if(txtBuildingName.Text.Length > 0)
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
    }
}
