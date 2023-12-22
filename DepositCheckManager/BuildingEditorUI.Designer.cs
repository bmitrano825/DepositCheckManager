namespace DepositCheckManager
{
    partial class BuildingEditorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingEditorUI));
            listBoxBuildings = new System.Windows.Forms.ListBox();
            txtBuildingName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnDeleteBuilding = new System.Windows.Forms.Button();
            btnAddBuilding = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxBuildings
            // 
            listBoxBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listBoxBuildings.FormattingEnabled = true;
            listBoxBuildings.ItemHeight = 24;
            listBoxBuildings.Location = new System.Drawing.Point(14, 14);
            listBoxBuildings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxBuildings.Name = "listBoxBuildings";
            listBoxBuildings.Size = new System.Drawing.Size(262, 292);
            listBoxBuildings.TabIndex = 0;
            // 
            // txtBuildingName
            // 
            txtBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtBuildingName.Location = new System.Drawing.Point(286, 48);
            txtBuildingName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBuildingName.Name = "txtBuildingName";
            txtBuildingName.Size = new System.Drawing.Size(355, 31);
            txtBuildingName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(282, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 24);
            label1.TabIndex = 2;
            label1.Text = "Building Name";
            // 
            // btnDeleteBuilding
            // 
            btnDeleteBuilding.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnDeleteBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteBuilding.Location = new System.Drawing.Point(284, 259);
            btnDeleteBuilding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteBuilding.Name = "btnDeleteBuilding";
            btnDeleteBuilding.Size = new System.Drawing.Size(146, 50);
            btnDeleteBuilding.TabIndex = 4;
            btnDeleteBuilding.Text = "Delete";
            btnDeleteBuilding.UseVisualStyleBackColor = false;
            btnDeleteBuilding.Click += btnDeleteBuilding_Click;
            // 
            // btnAddBuilding
            // 
            btnAddBuilding.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnAddBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddBuilding.Location = new System.Drawing.Point(284, 202);
            btnAddBuilding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new System.Drawing.Size(146, 50);
            btnAddBuilding.TabIndex = 5;
            btnAddBuilding.Text = "Add";
            btnAddBuilding.UseVisualStyleBackColor = false;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // BuildingEditorUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(680, 319);
            Controls.Add(btnAddBuilding);
            Controls.Add(btnDeleteBuilding);
            Controls.Add(label1);
            Controls.Add(txtBuildingName);
            Controls.Add(listBoxBuildings);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "BuildingEditorUI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Building Editor";
            Load += BuildingEditorUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBuildings;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
    }
}