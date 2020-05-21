namespace LoadDataApp
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCalibers = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbLoadData = new System.Windows.Forms.GroupBox();
            this.PrimerType = new System.Windows.Forms.Label();
            this.Caliber = new System.Windows.Forms.Label();
            this.PowderWeight = new System.Windows.Forms.Label();
            this.CostOf1000 = new System.Windows.Forms.Label();
            this.BulletType = new System.Windows.Forms.Label();
            this.BulletWeight = new System.Windows.Forms.Label();
            this.PowderType = new System.Windows.Forms.Label();
            this.SavingsPer1000 = new System.Windows.Forms.Label();
            this.lblSavingsPer1000 = new System.Windows.Forms.Label();
            this.lblCostOf1000 = new System.Windows.Forms.Label();
            this.lblPrimerType = new System.Windows.Forms.Label();
            this.lblPowderWeight = new System.Windows.Forms.Label();
            this.lblPowderType = new System.Windows.Forms.Label();
            this.lblBulletWeight = new System.Windows.Forms.Label();
            this.lblBulletType = new System.Windows.Forms.Label();
            this.lblCaliber = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblHeader2Information = new System.Windows.Forms.Label();
            this.lblRifle = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.lblBarrelLength = new System.Windows.Forms.Label();
            this.lblTwistRate = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblCaseLength = new System.Windows.Forms.Label();
            this.lblOverallLength = new System.Windows.Forms.Label();
            this.lblZeroDistance = new System.Windows.Forms.Label();
            this.lbl200ADJ = new System.Windows.Forms.Label();
            this.lbl300ADJ = new System.Windows.Forms.Label();
            this.lbl600ADJ = new System.Windows.Forms.Label();
            this.lbl1000ADJ = new System.Windows.Forms.Label();
            this.Elevation200 = new System.Windows.Forms.Label();
            this.Windage200 = new System.Windows.Forms.Label();
            this.Elevation300 = new System.Windows.Forms.Label();
            this.Windage300 = new System.Windows.Forms.Label();
            this.Elevation600 = new System.Windows.Forms.Label();
            this.Windage600 = new System.Windows.Forms.Label();
            this.gbRifleInformation = new System.Windows.Forms.GroupBox();
            this.ZeroDistance = new System.Windows.Forms.Label();
            this.OverallLength = new System.Windows.Forms.Label();
            this.CaseLength = new System.Windows.Forms.Label();
            this.Velocity = new System.Windows.Forms.Label();
            this.TwistRate = new System.Windows.Forms.Label();
            this.Scope = new System.Windows.Forms.Label();
            this.Rifle = new System.Windows.Forms.Label();
            this.BarrelLength = new System.Windows.Forms.Label();
            this.Windage1000 = new System.Windows.Forms.Label();
            this.Elevation1000 = new System.Windows.Forms.Label();
            this.loadDataDatabaseDataSet = new LoadDataApp.LoadDataDatabaseDataSet();
            this.loadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadsTableAdapter = new LoadDataApp.LoadDataDatabaseDataSetTableAdapters.LoadsTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbLoadData.SuspendLayout();
            this.gbRifleInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(180, 22);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // cbCalibers
            // 
            this.cbCalibers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalibers.FormattingEnabled = true;
            this.cbCalibers.Location = new System.Drawing.Point(12, 96);
            this.cbCalibers.Name = "cbCalibers";
            this.cbCalibers.Size = new System.Drawing.Size(240, 24);
            this.cbCalibers.TabIndex = 1;
            this.cbCalibers.SelectedIndexChanged += new System.EventHandler(this.cbCalibers_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 28);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(480, 65);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Saved Load Data";
            // 
            // gbLoadData
            // 
            this.gbLoadData.Controls.Add(this.PrimerType);
            this.gbLoadData.Controls.Add(this.Caliber);
            this.gbLoadData.Controls.Add(this.PowderWeight);
            this.gbLoadData.Controls.Add(this.CostOf1000);
            this.gbLoadData.Controls.Add(this.BulletType);
            this.gbLoadData.Controls.Add(this.BulletWeight);
            this.gbLoadData.Controls.Add(this.PowderType);
            this.gbLoadData.Controls.Add(this.SavingsPer1000);
            this.gbLoadData.Controls.Add(this.lblSavingsPer1000);
            this.gbLoadData.Controls.Add(this.lblCostOf1000);
            this.gbLoadData.Controls.Add(this.lblPrimerType);
            this.gbLoadData.Controls.Add(this.lblPowderWeight);
            this.gbLoadData.Controls.Add(this.lblPowderType);
            this.gbLoadData.Controls.Add(this.lblBulletWeight);
            this.gbLoadData.Controls.Add(this.lblBulletType);
            this.gbLoadData.Controls.Add(this.lblCaliber);
            this.gbLoadData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoadData.Location = new System.Drawing.Point(258, 97);
            this.gbLoadData.Name = "gbLoadData";
            this.gbLoadData.Size = new System.Drawing.Size(222, 388);
            this.gbLoadData.TabIndex = 3;
            this.gbLoadData.TabStop = false;
            this.gbLoadData.Text = "Load Data";
            // 
            // PrimerType
            // 
            this.PrimerType.AutoSize = true;
            this.PrimerType.Location = new System.Drawing.Point(125, 263);
            this.PrimerType.Name = "PrimerType";
            this.PrimerType.Size = new System.Drawing.Size(42, 16);
            this.PrimerType.TabIndex = 15;
            this.PrimerType.Text = "label8";
            this.PrimerType.Visible = false;
            // 
            // Caliber
            // 
            this.Caliber.AutoSize = true;
            this.Caliber.Location = new System.Drawing.Point(125, 23);
            this.Caliber.Name = "Caliber";
            this.Caliber.Size = new System.Drawing.Size(42, 16);
            this.Caliber.TabIndex = 14;
            this.Caliber.Text = "label7";
            this.Caliber.Visible = false;
            // 
            // PowderWeight
            // 
            this.PowderWeight.AutoSize = true;
            this.PowderWeight.Location = new System.Drawing.Point(125, 215);
            this.PowderWeight.Name = "PowderWeight";
            this.PowderWeight.Size = new System.Drawing.Size(42, 16);
            this.PowderWeight.TabIndex = 13;
            this.PowderWeight.Text = "label6";
            this.PowderWeight.Visible = false;
            // 
            // CostOf1000
            // 
            this.CostOf1000.AutoSize = true;
            this.CostOf1000.Location = new System.Drawing.Point(125, 311);
            this.CostOf1000.Name = "CostOf1000";
            this.CostOf1000.Size = new System.Drawing.Size(42, 16);
            this.CostOf1000.TabIndex = 12;
            this.CostOf1000.Text = "label5";
            this.CostOf1000.Visible = false;
            // 
            // BulletType
            // 
            this.BulletType.AutoSize = true;
            this.BulletType.Location = new System.Drawing.Point(125, 71);
            this.BulletType.Name = "BulletType";
            this.BulletType.Size = new System.Drawing.Size(42, 16);
            this.BulletType.TabIndex = 11;
            this.BulletType.Text = "label4";
            this.BulletType.Visible = false;
            // 
            // BulletWeight
            // 
            this.BulletWeight.AutoSize = true;
            this.BulletWeight.Location = new System.Drawing.Point(125, 119);
            this.BulletWeight.Name = "BulletWeight";
            this.BulletWeight.Size = new System.Drawing.Size(42, 16);
            this.BulletWeight.TabIndex = 10;
            this.BulletWeight.Text = "label3";
            this.BulletWeight.Visible = false;
            // 
            // PowderType
            // 
            this.PowderType.AutoSize = true;
            this.PowderType.Location = new System.Drawing.Point(125, 167);
            this.PowderType.Name = "PowderType";
            this.PowderType.Size = new System.Drawing.Size(42, 16);
            this.PowderType.TabIndex = 9;
            this.PowderType.Text = "label2";
            this.PowderType.Visible = false;
            // 
            // SavingsPer1000
            // 
            this.SavingsPer1000.AutoSize = true;
            this.SavingsPer1000.Location = new System.Drawing.Point(125, 359);
            this.SavingsPer1000.Name = "SavingsPer1000";
            this.SavingsPer1000.Size = new System.Drawing.Size(42, 16);
            this.SavingsPer1000.TabIndex = 8;
            this.SavingsPer1000.Text = "label1";
            this.SavingsPer1000.Visible = false;
            // 
            // lblSavingsPer1000
            // 
            this.lblSavingsPer1000.AutoSize = true;
            this.lblSavingsPer1000.Location = new System.Drawing.Point(7, 359);
            this.lblSavingsPer1000.Name = "lblSavingsPer1000";
            this.lblSavingsPer1000.Size = new System.Drawing.Size(112, 16);
            this.lblSavingsPer1000.TabIndex = 7;
            this.lblSavingsPer1000.Text = "Savings Per 1000:";
            // 
            // lblCostOf1000
            // 
            this.lblCostOf1000.AutoSize = true;
            this.lblCostOf1000.Location = new System.Drawing.Point(7, 311);
            this.lblCostOf1000.Name = "lblCostOf1000";
            this.lblCostOf1000.Size = new System.Drawing.Size(85, 16);
            this.lblCostOf1000.TabIndex = 6;
            this.lblCostOf1000.Text = "Cost of 1000:";
            // 
            // lblPrimerType
            // 
            this.lblPrimerType.AutoSize = true;
            this.lblPrimerType.Location = new System.Drawing.Point(7, 263);
            this.lblPrimerType.Name = "lblPrimerType";
            this.lblPrimerType.Size = new System.Drawing.Size(83, 16);
            this.lblPrimerType.TabIndex = 5;
            this.lblPrimerType.Text = "Primer Type:";
            // 
            // lblPowderWeight
            // 
            this.lblPowderWeight.AutoSize = true;
            this.lblPowderWeight.Location = new System.Drawing.Point(7, 215);
            this.lblPowderWeight.Name = "lblPowderWeight";
            this.lblPowderWeight.Size = new System.Drawing.Size(101, 16);
            this.lblPowderWeight.TabIndex = 4;
            this.lblPowderWeight.Text = "Powder Charge:";
            // 
            // lblPowderType
            // 
            this.lblPowderType.AutoSize = true;
            this.lblPowderType.Location = new System.Drawing.Point(7, 167);
            this.lblPowderType.Name = "lblPowderType";
            this.lblPowderType.Size = new System.Drawing.Size(88, 16);
            this.lblPowderType.TabIndex = 3;
            this.lblPowderType.Text = "Powder Type:";
            // 
            // lblBulletWeight
            // 
            this.lblBulletWeight.AutoSize = true;
            this.lblBulletWeight.Location = new System.Drawing.Point(7, 119);
            this.lblBulletWeight.Name = "lblBulletWeight";
            this.lblBulletWeight.Size = new System.Drawing.Size(88, 16);
            this.lblBulletWeight.TabIndex = 2;
            this.lblBulletWeight.Text = "Bullet Weight:";
            // 
            // lblBulletType
            // 
            this.lblBulletType.AutoSize = true;
            this.lblBulletType.Location = new System.Drawing.Point(7, 71);
            this.lblBulletType.Name = "lblBulletType";
            this.lblBulletType.Size = new System.Drawing.Size(76, 16);
            this.lblBulletType.TabIndex = 1;
            this.lblBulletType.Text = "Bullet Type:";
            // 
            // lblCaliber
            // 
            this.lblCaliber.AutoSize = true;
            this.lblCaliber.Location = new System.Drawing.Point(7, 23);
            this.lblCaliber.Name = "lblCaliber";
            this.lblCaliber.Size = new System.Drawing.Size(53, 16);
            this.lblCaliber.TabIndex = 0;
            this.lblCaliber.Text = "Caliber:";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(526, 56);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(114, 31);
            this.lblHeader2.TabIndex = 8;
            this.lblHeader2.Text = "Caliber:";
            this.lblHeader2.Visible = false;
            // 
            // lblHeader2Information
            // 
            this.lblHeader2Information.AutoSize = true;
            this.lblHeader2Information.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2Information.Location = new System.Drawing.Point(646, 56);
            this.lblHeader2Information.Name = "lblHeader2Information";
            this.lblHeader2Information.Size = new System.Drawing.Size(99, 31);
            this.lblHeader2Information.TabIndex = 9;
            this.lblHeader2Information.Text = "12345";
            this.lblHeader2Information.Visible = false;
            // 
            // lblRifle
            // 
            this.lblRifle.AutoSize = true;
            this.lblRifle.Location = new System.Drawing.Point(6, 23);
            this.lblRifle.Name = "lblRifle";
            this.lblRifle.Size = new System.Drawing.Size(38, 16);
            this.lblRifle.TabIndex = 8;
            this.lblRifle.Text = "Rifle:";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(6, 71);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(48, 16);
            this.lblScope.TabIndex = 9;
            this.lblScope.Text = "Scope:";
            // 
            // lblBarrelLength
            // 
            this.lblBarrelLength.AutoSize = true;
            this.lblBarrelLength.Location = new System.Drawing.Point(6, 119);
            this.lblBarrelLength.Name = "lblBarrelLength";
            this.lblBarrelLength.Size = new System.Drawing.Size(89, 16);
            this.lblBarrelLength.TabIndex = 10;
            this.lblBarrelLength.Text = "Barrel Length:";
            // 
            // lblTwistRate
            // 
            this.lblTwistRate.AutoSize = true;
            this.lblTwistRate.Location = new System.Drawing.Point(6, 167);
            this.lblTwistRate.Name = "lblTwistRate";
            this.lblTwistRate.Size = new System.Drawing.Size(74, 16);
            this.lblTwistRate.TabIndex = 11;
            this.lblTwistRate.Text = "Twist Rate:";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(6, 215);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(57, 16);
            this.lblVelocity.TabIndex = 12;
            this.lblVelocity.Text = "Velocity:";
            // 
            // lblCaseLength
            // 
            this.lblCaseLength.AutoSize = true;
            this.lblCaseLength.Location = new System.Drawing.Point(6, 263);
            this.lblCaseLength.Name = "lblCaseLength";
            this.lblCaseLength.Size = new System.Drawing.Size(83, 16);
            this.lblCaseLength.TabIndex = 13;
            this.lblCaseLength.Text = "Case Length:";
            // 
            // lblOverallLength
            // 
            this.lblOverallLength.AutoSize = true;
            this.lblOverallLength.Location = new System.Drawing.Point(6, 311);
            this.lblOverallLength.Name = "lblOverallLength";
            this.lblOverallLength.Size = new System.Drawing.Size(95, 16);
            this.lblOverallLength.TabIndex = 14;
            this.lblOverallLength.Text = "Overall Length:";
            // 
            // lblZeroDistance
            // 
            this.lblZeroDistance.AutoSize = true;
            this.lblZeroDistance.Location = new System.Drawing.Point(6, 359);
            this.lblZeroDistance.Name = "lblZeroDistance";
            this.lblZeroDistance.Size = new System.Drawing.Size(91, 16);
            this.lblZeroDistance.TabIndex = 15;
            this.lblZeroDistance.Text = "Zero Distance:";
            // 
            // lbl200ADJ
            // 
            this.lbl200ADJ.AutoSize = true;
            this.lbl200ADJ.Location = new System.Drawing.Point(238, 23);
            this.lbl200ADJ.Name = "lbl200ADJ";
            this.lbl200ADJ.Size = new System.Drawing.Size(139, 16);
            this.lbl200ADJ.TabIndex = 16;
            this.lbl200ADJ.Text = "200 Yard Adjustments:";
            // 
            // lbl300ADJ
            // 
            this.lbl300ADJ.AutoSize = true;
            this.lbl300ADJ.Location = new System.Drawing.Point(238, 119);
            this.lbl300ADJ.Name = "lbl300ADJ";
            this.lbl300ADJ.Size = new System.Drawing.Size(139, 16);
            this.lbl300ADJ.TabIndex = 18;
            this.lbl300ADJ.Text = "300 Yard Adjustments:";
            // 
            // lbl600ADJ
            // 
            this.lbl600ADJ.AutoSize = true;
            this.lbl600ADJ.Location = new System.Drawing.Point(238, 215);
            this.lbl600ADJ.Name = "lbl600ADJ";
            this.lbl600ADJ.Size = new System.Drawing.Size(139, 16);
            this.lbl600ADJ.TabIndex = 20;
            this.lbl600ADJ.Text = "600 Yard Adjustments:";
            // 
            // lbl1000ADJ
            // 
            this.lbl1000ADJ.AutoSize = true;
            this.lbl1000ADJ.Location = new System.Drawing.Point(238, 311);
            this.lbl1000ADJ.Name = "lbl1000ADJ";
            this.lbl1000ADJ.Size = new System.Drawing.Size(146, 16);
            this.lbl1000ADJ.TabIndex = 22;
            this.lbl1000ADJ.Text = "1000 Yard Adjustments:";
            // 
            // Elevation200
            // 
            this.Elevation200.AutoSize = true;
            this.Elevation200.Location = new System.Drawing.Point(286, 48);
            this.Elevation200.Name = "Elevation200";
            this.Elevation200.Size = new System.Drawing.Size(42, 16);
            this.Elevation200.TabIndex = 25;
            this.Elevation200.Text = "label3";
            this.Elevation200.Visible = false;
            // 
            // Windage200
            // 
            this.Windage200.AutoSize = true;
            this.Windage200.Location = new System.Drawing.Point(286, 71);
            this.Windage200.Name = "Windage200";
            this.Windage200.Size = new System.Drawing.Size(42, 16);
            this.Windage200.TabIndex = 26;
            this.Windage200.Text = "label4";
            this.Windage200.Visible = false;
            // 
            // Elevation300
            // 
            this.Elevation300.AutoSize = true;
            this.Elevation300.Location = new System.Drawing.Point(286, 144);
            this.Elevation300.Name = "Elevation300";
            this.Elevation300.Size = new System.Drawing.Size(42, 16);
            this.Elevation300.TabIndex = 29;
            this.Elevation300.Text = "label6";
            this.Elevation300.Visible = false;
            // 
            // Windage300
            // 
            this.Windage300.AutoSize = true;
            this.Windage300.Location = new System.Drawing.Point(286, 167);
            this.Windage300.Name = "Windage300";
            this.Windage300.Size = new System.Drawing.Size(42, 16);
            this.Windage300.TabIndex = 30;
            this.Windage300.Text = "label5";
            this.Windage300.Visible = false;
            // 
            // Elevation600
            // 
            this.Elevation600.AutoSize = true;
            this.Elevation600.Location = new System.Drawing.Point(286, 240);
            this.Elevation600.Name = "Elevation600";
            this.Elevation600.Size = new System.Drawing.Size(49, 16);
            this.Elevation600.TabIndex = 33;
            this.Elevation600.Text = "label10";
            this.Elevation600.Visible = false;
            // 
            // Windage600
            // 
            this.Windage600.AutoSize = true;
            this.Windage600.Location = new System.Drawing.Point(286, 263);
            this.Windage600.Name = "Windage600";
            this.Windage600.Size = new System.Drawing.Size(42, 16);
            this.Windage600.TabIndex = 34;
            this.Windage600.Text = "label9";
            this.Windage600.Visible = false;
            // 
            // gbRifleInformation
            // 
            this.gbRifleInformation.Controls.Add(this.ZeroDistance);
            this.gbRifleInformation.Controls.Add(this.OverallLength);
            this.gbRifleInformation.Controls.Add(this.CaseLength);
            this.gbRifleInformation.Controls.Add(this.Velocity);
            this.gbRifleInformation.Controls.Add(this.TwistRate);
            this.gbRifleInformation.Controls.Add(this.Scope);
            this.gbRifleInformation.Controls.Add(this.Rifle);
            this.gbRifleInformation.Controls.Add(this.BarrelLength);
            this.gbRifleInformation.Controls.Add(this.Windage1000);
            this.gbRifleInformation.Controls.Add(this.Elevation1000);
            this.gbRifleInformation.Controls.Add(this.Windage600);
            this.gbRifleInformation.Controls.Add(this.Elevation600);
            this.gbRifleInformation.Controls.Add(this.Windage300);
            this.gbRifleInformation.Controls.Add(this.Elevation300);
            this.gbRifleInformation.Controls.Add(this.Windage200);
            this.gbRifleInformation.Controls.Add(this.Elevation200);
            this.gbRifleInformation.Controls.Add(this.lbl1000ADJ);
            this.gbRifleInformation.Controls.Add(this.lbl600ADJ);
            this.gbRifleInformation.Controls.Add(this.lbl300ADJ);
            this.gbRifleInformation.Controls.Add(this.lbl200ADJ);
            this.gbRifleInformation.Controls.Add(this.lblZeroDistance);
            this.gbRifleInformation.Controls.Add(this.lblOverallLength);
            this.gbRifleInformation.Controls.Add(this.lblCaseLength);
            this.gbRifleInformation.Controls.Add(this.lblVelocity);
            this.gbRifleInformation.Controls.Add(this.lblTwistRate);
            this.gbRifleInformation.Controls.Add(this.lblBarrelLength);
            this.gbRifleInformation.Controls.Add(this.lblScope);
            this.gbRifleInformation.Controls.Add(this.lblRifle);
            this.gbRifleInformation.Location = new System.Drawing.Point(486, 97);
            this.gbRifleInformation.Name = "gbRifleInformation";
            this.gbRifleInformation.Size = new System.Drawing.Size(386, 388);
            this.gbRifleInformation.TabIndex = 4;
            this.gbRifleInformation.TabStop = false;
            this.gbRifleInformation.Text = "Rifle Information";
            // 
            // ZeroDistance
            // 
            this.ZeroDistance.AutoSize = true;
            this.ZeroDistance.Location = new System.Drawing.Point(101, 359);
            this.ZeroDistance.Name = "ZeroDistance";
            this.ZeroDistance.Size = new System.Drawing.Size(49, 16);
            this.ZeroDistance.TabIndex = 46;
            this.ZeroDistance.Text = "label24";
            this.ZeroDistance.Visible = false;
            // 
            // OverallLength
            // 
            this.OverallLength.AutoSize = true;
            this.OverallLength.Location = new System.Drawing.Point(101, 311);
            this.OverallLength.Name = "OverallLength";
            this.OverallLength.Size = new System.Drawing.Size(49, 16);
            this.OverallLength.TabIndex = 45;
            this.OverallLength.Text = "label23";
            this.OverallLength.Visible = false;
            // 
            // CaseLength
            // 
            this.CaseLength.AutoSize = true;
            this.CaseLength.Location = new System.Drawing.Point(101, 263);
            this.CaseLength.Name = "CaseLength";
            this.CaseLength.Size = new System.Drawing.Size(49, 16);
            this.CaseLength.TabIndex = 44;
            this.CaseLength.Text = "label22";
            this.CaseLength.Visible = false;
            // 
            // Velocity
            // 
            this.Velocity.AutoSize = true;
            this.Velocity.Location = new System.Drawing.Point(101, 215);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(49, 16);
            this.Velocity.TabIndex = 43;
            this.Velocity.Text = "label21";
            this.Velocity.Visible = false;
            // 
            // TwistRate
            // 
            this.TwistRate.AutoSize = true;
            this.TwistRate.Location = new System.Drawing.Point(101, 167);
            this.TwistRate.Name = "TwistRate";
            this.TwistRate.Size = new System.Drawing.Size(49, 16);
            this.TwistRate.TabIndex = 42;
            this.TwistRate.Text = "label20";
            this.TwistRate.Visible = false;
            // 
            // Scope
            // 
            this.Scope.AutoSize = true;
            this.Scope.Location = new System.Drawing.Point(101, 71);
            this.Scope.Name = "Scope";
            this.Scope.Size = new System.Drawing.Size(49, 16);
            this.Scope.TabIndex = 41;
            this.Scope.Text = "label19";
            this.Scope.Visible = false;
            // 
            // Rifle
            // 
            this.Rifle.AutoSize = true;
            this.Rifle.Location = new System.Drawing.Point(101, 23);
            this.Rifle.Name = "Rifle";
            this.Rifle.Size = new System.Drawing.Size(49, 16);
            this.Rifle.TabIndex = 40;
            this.Rifle.Text = "label18";
            this.Rifle.Visible = false;
            // 
            // BarrelLength
            // 
            this.BarrelLength.AutoSize = true;
            this.BarrelLength.Location = new System.Drawing.Point(101, 119);
            this.BarrelLength.Name = "BarrelLength";
            this.BarrelLength.Size = new System.Drawing.Size(49, 16);
            this.BarrelLength.TabIndex = 39;
            this.BarrelLength.Text = "label17";
            this.BarrelLength.Visible = false;
            // 
            // Windage1000
            // 
            this.Windage1000.AutoSize = true;
            this.Windage1000.Location = new System.Drawing.Point(286, 359);
            this.Windage1000.Name = "Windage1000";
            this.Windage1000.Size = new System.Drawing.Size(49, 16);
            this.Windage1000.TabIndex = 38;
            this.Windage1000.Text = "label13";
            this.Windage1000.Visible = false;
            // 
            // Elevation1000
            // 
            this.Elevation1000.AutoSize = true;
            this.Elevation1000.Location = new System.Drawing.Point(286, 336);
            this.Elevation1000.Name = "Elevation1000";
            this.Elevation1000.Size = new System.Drawing.Size(49, 16);
            this.Elevation1000.TabIndex = 37;
            this.Elevation1000.Text = "label14";
            this.Elevation1000.Visible = false;
            // 
            // loadDataDatabaseDataSet
            // 
            this.loadDataDatabaseDataSet.DataSetName = "LoadDataDatabaseDataSet";
            this.loadDataDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadsBindingSource
            // 
            this.loadsBindingSource.DataMember = "Loads";
            this.loadsBindingSource.DataSource = this.loadDataDatabaseDataSet;
            // 
            // loadsTableAdapter
            // 
            this.loadsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(76, 459);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 26);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete This Load";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblHeader2Information);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.gbRifleInformation);
            this.Controls.Add(this.gbLoadData);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cbCalibers);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLoadData.ResumeLayout(false);
            this.gbLoadData.PerformLayout();
            this.gbRifleInformation.ResumeLayout(false);
            this.gbRifleInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cbCalibers;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbLoadData;
        private System.Windows.Forms.Label lblSavingsPer1000;
        private System.Windows.Forms.Label lblCostOf1000;
        private System.Windows.Forms.Label lblPrimerType;
        private System.Windows.Forms.Label lblPowderWeight;
        private System.Windows.Forms.Label lblPowderType;
        private System.Windows.Forms.Label lblBulletWeight;
        private System.Windows.Forms.Label lblBulletType;
        private System.Windows.Forms.Label lblCaliber;
        private System.Windows.Forms.Label PrimerType;
        private System.Windows.Forms.Label Caliber;
        private System.Windows.Forms.Label PowderWeight;
        private System.Windows.Forms.Label CostOf1000;
        private System.Windows.Forms.Label BulletType;
        private System.Windows.Forms.Label BulletWeight;
        private System.Windows.Forms.Label PowderType;
        private System.Windows.Forms.Label SavingsPer1000;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblHeader2Information;
        private System.Windows.Forms.Label lblRifle;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.Label lblBarrelLength;
        private System.Windows.Forms.Label lblTwistRate;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblCaseLength;
        private System.Windows.Forms.Label lblOverallLength;
        private System.Windows.Forms.Label lblZeroDistance;
        private System.Windows.Forms.Label lbl200ADJ;
        private System.Windows.Forms.Label lbl300ADJ;
        private System.Windows.Forms.Label lbl600ADJ;
        private System.Windows.Forms.Label lbl1000ADJ;
        private System.Windows.Forms.Label Elevation200;
        private System.Windows.Forms.Label Windage200;
        private System.Windows.Forms.Label Elevation300;
        private System.Windows.Forms.Label Windage300;
        private System.Windows.Forms.Label Elevation600;
        private System.Windows.Forms.Label Windage600;
        private System.Windows.Forms.GroupBox gbRifleInformation;
        private System.Windows.Forms.Label ZeroDistance;
        private System.Windows.Forms.Label OverallLength;
        private System.Windows.Forms.Label CaseLength;
        private System.Windows.Forms.Label Velocity;
        private System.Windows.Forms.Label TwistRate;
        private System.Windows.Forms.Label Scope;
        private System.Windows.Forms.Label Rifle;
        private System.Windows.Forms.Label BarrelLength;
        private System.Windows.Forms.Label Windage1000;
        private System.Windows.Forms.Label Elevation1000;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private LoadDataDatabaseDataSet loadDataDatabaseDataSet;
        private System.Windows.Forms.BindingSource loadsBindingSource;
        private LoadDataDatabaseDataSetTableAdapters.LoadsTableAdapter loadsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}