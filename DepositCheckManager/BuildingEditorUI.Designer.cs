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
            btnAddAccount = new System.Windows.Forms.Button();
            btnDeleteAccount = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtAccountName = new System.Windows.Forms.TextBox();
            listBoxAccounts = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxBuildings
            // 
            listBoxBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listBoxBuildings.FormattingEnabled = true;
            listBoxBuildings.ItemHeight = 24;
            listBoxBuildings.Location = new System.Drawing.Point(11, 20);
            listBoxBuildings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxBuildings.Name = "listBoxBuildings";
            listBoxBuildings.Size = new System.Drawing.Size(262, 292);
            listBoxBuildings.TabIndex = 0;
            // 
            // txtBuildingName
            // 
            txtBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtBuildingName.Location = new System.Drawing.Point(283, 54);
            txtBuildingName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBuildingName.Name = "txtBuildingName";
            txtBuildingName.Size = new System.Drawing.Size(355, 31);
            txtBuildingName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(279, 23);
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
            btnDeleteBuilding.Location = new System.Drawing.Point(281, 265);
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
            btnAddBuilding.Location = new System.Drawing.Point(281, 208);
            btnAddBuilding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new System.Drawing.Size(146, 50);
            btnAddBuilding.TabIndex = 5;
            btnAddBuilding.Text = "Add";
            btnAddBuilding.UseVisualStyleBackColor = false;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddAccount.Location = new System.Drawing.Point(276, 207);
            btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new System.Drawing.Size(146, 50);
            btnAddAccount.TabIndex = 10;
            btnAddAccount.Text = "Add";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteAccount.Location = new System.Drawing.Point(276, 264);
            btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new System.Drawing.Size(146, 50);
            btnDeleteAccount.TabIndex = 9;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(274, 22);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 24);
            label2.TabIndex = 8;
            label2.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAccountName.Location = new System.Drawing.Point(278, 53);
            txtAccountName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new System.Drawing.Size(355, 31);
            txtAccountName.TabIndex = 7;
            // 
            // listBoxAccounts
            // 
            listBoxAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listBoxAccounts.FormattingEnabled = true;
            listBoxAccounts.ItemHeight = 24;
            listBoxAccounts.Location = new System.Drawing.Point(6, 19);
            listBoxAccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxAccounts.Name = "listBoxAccounts";
            listBoxAccounts.Size = new System.Drawing.Size(262, 292);
            listBoxAccounts.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(btnAddBuilding);
            groupBox1.Controls.Add(btnDeleteBuilding);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBuildingName);
            groupBox1.Controls.Add(listBoxBuildings);
            groupBox1.Location = new System.Drawing.Point(3, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(651, 328);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buildings";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            groupBox2.Controls.Add(btnAddAccount);
            groupBox2.Controls.Add(btnDeleteAccount);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtAccountName);
            groupBox2.Controls.Add(listBoxAccounts);
            groupBox2.Location = new System.Drawing.Point(660, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(636, 328);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Accounts:";
            // 
            // BuildingEditorUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1296, 351);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "BuildingEditorUI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Building Editor";
            Load += BuildingEditorUI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBuildings;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}