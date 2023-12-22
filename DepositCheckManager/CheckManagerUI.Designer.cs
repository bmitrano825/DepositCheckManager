using System.Windows.Forms;

namespace DepositCheckManager
{
    partial class DepositCheckManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositCheckManagerForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            setPathToolStripMenuItem = new ToolStripMenuItem();
            setFolderPathToolStripMenuItem = new ToolStripMenuItem();
            editBuildingsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            comboBuildingName = new ComboBox();
            dateTimeMonth = new DateTimePicker();
            dateTimeYear = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            btnScan = new Button();
            btnOpenFolder = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtFolderLocation = new TextBox();
            label3 = new Label();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(867, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setPathToolStripMenuItem, quitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // setPathToolStripMenuItem
            // 
            setPathToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setFolderPathToolStripMenuItem, editBuildingsToolStripMenuItem });
            setPathToolStripMenuItem.Name = "setPathToolStripMenuItem";
            setPathToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            setPathToolStripMenuItem.Text = "Options";
            // 
            // setFolderPathToolStripMenuItem
            // 
            setFolderPathToolStripMenuItem.Name = "setFolderPathToolStripMenuItem";
            setFolderPathToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            setFolderPathToolStripMenuItem.Text = "Set Folder Path";
            setFolderPathToolStripMenuItem.Click += setFolderPathToolStripMenuItem_Click;
            // 
            // editBuildingsToolStripMenuItem
            // 
            editBuildingsToolStripMenuItem.Name = "editBuildingsToolStripMenuItem";
            editBuildingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            editBuildingsToolStripMenuItem.Text = "Edit Buildings";
            editBuildingsToolStripMenuItem.Click += editBuildingsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            quitToolStripMenuItem1.Text = "Quit";
            quitToolStripMenuItem1.Click += quitToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBuildingName);
            panel1.Controls.Add(dateTimeMonth);
            panel1.Controls.Add(dateTimeYear);
            panel1.Location = new System.Drawing.Point(43, 65);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(323, 133);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 8;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Building:";
            // 
            // comboBuildingName
            // 
            comboBuildingName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBuildingName.FormattingEnabled = true;
            comboBuildingName.Location = new System.Drawing.Point(110, 32);
            comboBuildingName.Margin = new Padding(4, 3, 4, 3);
            comboBuildingName.Name = "comboBuildingName";
            comboBuildingName.Size = new System.Drawing.Size(200, 24);
            comboBuildingName.TabIndex = 5;
            // 
            // dateTimeMonth
            // 
            dateTimeMonth.AllowDrop = true;
            dateTimeMonth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimeMonth.CustomFormat = "MMMM";
            dateTimeMonth.Format = DateTimePickerFormat.Custom;
            dateTimeMonth.Location = new System.Drawing.Point(75, 72);
            dateTimeMonth.Margin = new Padding(4, 3, 4, 3);
            dateTimeMonth.Name = "dateTimeMonth";
            dateTimeMonth.ShowUpDown = true;
            dateTimeMonth.Size = new System.Drawing.Size(142, 22);
            dateTimeMonth.TabIndex = 4;
            // 
            // dateTimeYear
            // 
            dateTimeYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimeYear.CustomFormat = "yyyy";
            dateTimeYear.Format = DateTimePickerFormat.Custom;
            dateTimeYear.Location = new System.Drawing.Point(224, 72);
            dateTimeYear.Margin = new Padding(4, 3, 4, 3);
            dateTimeYear.Name = "dateTimeYear";
            dateTimeYear.ShowUpDown = true;
            dateTimeYear.Size = new System.Drawing.Size(86, 22);
            dateTimeYear.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(13, 43);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(420, 263);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "1";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(panel3);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(440, 43);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(414, 263);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "2";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(btnScan);
            panel3.Location = new System.Drawing.Point(74, 63);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(262, 134);
            panel3.TabIndex = 15;
            // 
            // btnScan
            // 
            btnScan.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnScan.Dock = DockStyle.Fill;
            btnScan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnScan.Location = new System.Drawing.Point(0, 0);
            btnScan.Margin = new Padding(4, 3, 4, 3);
            btnScan.Name = "btnScan";
            btnScan.Size = new System.Drawing.Size(262, 134);
            btnScan.TabIndex = 10;
            btnScan.Text = "Scan/Save";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Location = new System.Drawing.Point(766, 316);
            btnOpenFolder.Margin = new Padding(4, 3, 4, 3);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new System.Drawing.Size(88, 27);
            btnOpenFolder.TabIndex = 13;
            btnOpenFolder.Text = "Open Folder";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // txtFolderLocation
            // 
            txtFolderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFolderLocation.Location = new System.Drawing.Point(155, 314);
            txtFolderLocation.Margin = new Padding(4, 3, 4, 3);
            txtFolderLocation.Name = "txtFolderLocation";
            txtFolderLocation.ReadOnly = true;
            txtFolderLocation.Size = new System.Drawing.Size(590, 29);
            txtFolderLocation.TabIndex = 21;
            txtFolderLocation.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 327);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 15);
            label3.TabIndex = 22;
            label3.Text = "Check Folder Location";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // DepositCheckManagerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(867, 355);
            Controls.Add(btnOpenFolder);
            Controls.Add(label3);
            Controls.Add(txtFolderLocation);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "DepositCheckManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckManager";
            Load += DepositCheckManagerForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem setPathToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox comboBuildingName;
        private DateTimePicker dateTimeMonth;
        private DateTimePicker dateTimeYear;
        private ToolStripMenuItem quitToolStripMenuItem1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel3;
        private Button btnScan;
        private Button btnOpenFolder;
        private ToolStripMenuItem setFolderPathToolStripMenuItem;
        private ToolStripMenuItem editBuildingsToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtFolderLocation;
        private Label label3;
        private PrintDialog printDialog1;
    }
}

