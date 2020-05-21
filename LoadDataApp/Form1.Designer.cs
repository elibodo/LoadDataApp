namespace LoadDataApp
{
    partial class Form1
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
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDeleteCaliber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDeletePrimer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLoadType = new System.Windows.Forms.GroupBox();
            this.rbRifle = new System.Windows.Forms.RadioButton();
            this.rbHandgun = new System.Windows.Forms.RadioButton();
            this.lblLoadType = new System.Windows.Forms.Label();
            this.lblCaliber = new System.Windows.Forms.Label();
            this.cbCaliber = new System.Windows.Forms.ComboBox();
            this.calibersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadDataDatabaseDataSet = new LoadDataApp.LoadDataDatabaseDataSet();
            this.lblBulletType = new System.Windows.Forms.Label();
            this.tbBulletType = new System.Windows.Forms.TextBox();
            this.lblBulletWeight = new System.Windows.Forms.Label();
            this.tbBulletWeight = new System.Windows.Forms.TextBox();
            this.lblPowder = new System.Windows.Forms.Label();
            this.tbPowderType = new System.Windows.Forms.TextBox();
            this.lblPowderWeight = new System.Windows.Forms.Label();
            this.tbPowderWeight = new System.Windows.Forms.TextBox();
            this.lblPrimerType = new System.Windows.Forms.Label();
            this.cbPrimerType = new System.Windows.Forms.ComboBox();
            this.primersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbPriceRifleInfo = new System.Windows.Forms.GroupBox();
            this.cbRifleInformation = new System.Windows.Forms.CheckBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.lblPriceRifleInfo = new System.Windows.Forms.Label();
            this.gbStoreBoughtAmmo = new System.Windows.Forms.GroupBox();
            this.tbStoreBoughtQuantity = new System.Windows.Forms.TextBox();
            this.tbStoreBoughtPrice = new System.Windows.Forms.TextBox();
            this.lblStoreBoughtQuantity = new System.Windows.Forms.Label();
            this.lblStoreBoughtPrice = new System.Windows.Forms.Label();
            this.lblStoreBoughtAmmo = new System.Windows.Forms.Label();
            this.gbPowder = new System.Windows.Forms.GroupBox();
            this.tbPowderQuantity = new System.Windows.Forms.TextBox();
            this.tbPowderPrice = new System.Windows.Forms.TextBox();
            this.lblPowderQuantity = new System.Windows.Forms.Label();
            this.lblPowderPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbBullet = new System.Windows.Forms.GroupBox();
            this.tbBulletQuantity = new System.Windows.Forms.TextBox();
            this.tbBulletPrice = new System.Windows.Forms.TextBox();
            this.lblBulletQuantity = new System.Windows.Forms.Label();
            this.lblBulletPrice = new System.Windows.Forms.Label();
            this.lblBullet = new System.Windows.Forms.Label();
            this.gbPrimer = new System.Windows.Forms.GroupBox();
            this.tbPrimerQuanity = new System.Windows.Forms.TextBox();
            this.tbPrimerPrice = new System.Windows.Forms.TextBox();
            this.lblPrimerQuantity = new System.Windows.Forms.Label();
            this.lblPrimerPrice = new System.Windows.Forms.Label();
            this.lblPrimer = new System.Windows.Forms.Label();
            this.gbRifleInformation = new System.Windows.Forms.GroupBox();
            this.lbl1000W = new System.Windows.Forms.Label();
            this.lbl1000E = new System.Windows.Forms.Label();
            this.lbl300W = new System.Windows.Forms.Label();
            this.lbl300E = new System.Windows.Forms.Label();
            this.lbl600W = new System.Windows.Forms.Label();
            this.lbl600E = new System.Windows.Forms.Label();
            this.lbl200W = new System.Windows.Forms.Label();
            this.lbl200E = new System.Windows.Forms.Label();
            this.tb1000LeftRight = new System.Windows.Forms.TextBox();
            this.tb1000UpDown = new System.Windows.Forms.TextBox();
            this.tb300LeftRight = new System.Windows.Forms.TextBox();
            this.tb300UpDown = new System.Windows.Forms.TextBox();
            this.tb600LeftRight = new System.Windows.Forms.TextBox();
            this.tb600UpDown = new System.Windows.Forms.TextBox();
            this.tb200LeftRight = new System.Windows.Forms.TextBox();
            this.tb200UpDown = new System.Windows.Forms.TextBox();
            this.lbl1000ADJ = new System.Windows.Forms.Label();
            this.lbl600ADJ = new System.Windows.Forms.Label();
            this.tbScope = new System.Windows.Forms.TextBox();
            this.tbRifle = new System.Windows.Forms.TextBox();
            this.lbl300ADJ = new System.Windows.Forms.Label();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.tbOverallLength = new System.Windows.Forms.TextBox();
            this.lblOverallLength = new System.Windows.Forms.Label();
            this.tbBarrelLength = new System.Windows.Forms.TextBox();
            this.lblBarrelLength = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.lbl200ADJ = new System.Windows.Forms.Label();
            this.tbZeroDistance = new System.Windows.Forms.TextBox();
            this.lblZeroDistance = new System.Windows.Forms.Label();
            this.tbCaseLength = new System.Windows.Forms.TextBox();
            this.lblCaseLength = new System.Windows.Forms.Label();
            this.tbTwistRate = new System.Windows.Forms.TextBox();
            this.lblTwistRate = new System.Windows.Forms.Label();
            this.lblRifle = new System.Windows.Forms.Label();
            this.btnAddLoad = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.lblLoad1000Cost = new System.Windows.Forms.Label();
            this.lblSaved1000Money = new System.Windows.Forms.Label();
            this.lblSaved100Money = new System.Windows.Forms.Label();
            this.lblSavedUnitMoney = new System.Windows.Forms.Label();
            this.lblStore1000Cost = new System.Windows.Forms.Label();
            this.lblStore100Cost = new System.Windows.Forms.Label();
            this.lblStoreUnitCost = new System.Windows.Forms.Label();
            this.lblLoad100Cost = new System.Windows.Forms.Label();
            this.lblLoadUnitCost = new System.Windows.Forms.Label();
            this.lblSaved1000 = new System.Windows.Forms.Label();
            this.lblSaved100 = new System.Windows.Forms.Label();
            this.lblSavedUnit = new System.Windows.Forms.Label();
            this.lblMoneySaved = new System.Windows.Forms.Label();
            this.lblStore1000 = new System.Windows.Forms.Label();
            this.lblStore100 = new System.Windows.Forms.Label();
            this.lblStoreUnit = new System.Windows.Forms.Label();
            this.lblStoreCost = new System.Windows.Forms.Label();
            this.lblLoad100 = new System.Windows.Forms.Label();
            this.lblLoad1000 = new System.Windows.Forms.Label();
            this.lblLoadUnit = new System.Windows.Forms.Label();
            this.lblLoadCost = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.calibersTableAdapter = new LoadDataApp.LoadDataDatabaseDataSetTableAdapters.CalibersTableAdapter();
            this.primersTableAdapter = new LoadDataApp.LoadDataDatabaseDataSetTableAdapters.PrimersTableAdapter();
            this.primersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbLoadType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource)).BeginInit();
            this.gbPriceRifleInfo.SuspendLayout();
            this.gbStoreBoughtAmmo.SuspendLayout();
            this.gbPowder.SuspendLayout();
            this.gbBullet.SuspendLayout();
            this.gbPrimer.SuspendLayout();
            this.gbRifleInformation.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
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
            this.mnuMainMenu.Size = new System.Drawing.Size(135, 22);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(135, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDeleteCaliber,
            this.mnuAddDeletePrimer});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuAddDeleteCaliber
            // 
            this.mnuAddDeleteCaliber.Name = "mnuAddDeleteCaliber";
            this.mnuAddDeleteCaliber.Size = new System.Drawing.Size(199, 22);
            this.mnuAddDeleteCaliber.Text = "Add/Delete Caliber";
            this.mnuAddDeleteCaliber.Click += new System.EventHandler(this.mnuAddDeleteCaliber_Click);
            // 
            // mnuAddDeletePrimer
            // 
            this.mnuAddDeletePrimer.Name = "mnuAddDeletePrimer";
            this.mnuAddDeletePrimer.Size = new System.Drawing.Size(199, 22);
            this.mnuAddDeletePrimer.Text = "Add/Delete Primer Type";
            this.mnuAddDeletePrimer.Click += new System.EventHandler(this.mnuAddDeletePrimer_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // gbLoadType
            // 
            this.gbLoadType.Controls.Add(this.rbRifle);
            this.gbLoadType.Controls.Add(this.rbHandgun);
            this.gbLoadType.Controls.Add(this.lblLoadType);
            this.gbLoadType.Location = new System.Drawing.Point(12, 27);
            this.gbLoadType.Name = "gbLoadType";
            this.gbLoadType.Size = new System.Drawing.Size(100, 86);
            this.gbLoadType.TabIndex = 0;
            this.gbLoadType.TabStop = false;
            // 
            // rbRifle
            // 
            this.rbRifle.AutoSize = true;
            this.rbRifle.Location = new System.Drawing.Point(10, 56);
            this.rbRifle.Name = "rbRifle";
            this.rbRifle.Size = new System.Drawing.Size(51, 20);
            this.rbRifle.TabIndex = 2;
            this.rbRifle.Text = "Rifle";
            this.rbRifle.UseVisualStyleBackColor = true;
            this.rbRifle.CheckedChanged += new System.EventHandler(this.rbRifle_CheckedChanged);
            // 
            // rbHandgun
            // 
            this.rbHandgun.AutoSize = true;
            this.rbHandgun.Checked = true;
            this.rbHandgun.Location = new System.Drawing.Point(10, 30);
            this.rbHandgun.Name = "rbHandgun";
            this.rbHandgun.Size = new System.Drawing.Size(76, 20);
            this.rbHandgun.TabIndex = 1;
            this.rbHandgun.TabStop = true;
            this.rbHandgun.Text = "Handgun";
            this.rbHandgun.UseVisualStyleBackColor = true;
            this.rbHandgun.CheckedChanged += new System.EventHandler(this.rbHandgun_CheckedChanged);
            // 
            // lblLoadType
            // 
            this.lblLoadType.AutoSize = true;
            this.lblLoadType.Location = new System.Drawing.Point(7, 9);
            this.lblLoadType.Name = "lblLoadType";
            this.lblLoadType.Size = new System.Drawing.Size(67, 16);
            this.lblLoadType.TabIndex = 0;
            this.lblLoadType.Text = "Load Type";
            // 
            // lblCaliber
            // 
            this.lblCaliber.AutoSize = true;
            this.lblCaliber.Location = new System.Drawing.Point(12, 129);
            this.lblCaliber.Name = "lblCaliber";
            this.lblCaliber.Size = new System.Drawing.Size(48, 16);
            this.lblCaliber.TabIndex = 2;
            this.lblCaliber.Text = "Caliber";
            // 
            // cbCaliber
            // 
            this.cbCaliber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaliber.FormattingEnabled = true;
            this.cbCaliber.Location = new System.Drawing.Point(12, 149);
            this.cbCaliber.Name = "cbCaliber";
            this.cbCaliber.Size = new System.Drawing.Size(100, 24);
            this.cbCaliber.TabIndex = 1;
            this.cbCaliber.SelectedIndexChanged += new System.EventHandler(this.cbCaliber_SelectedIndexChanged);
            // 
            // calibersBindingSource
            // 
            this.calibersBindingSource.DataMember = "Calibers";
            this.calibersBindingSource.DataSource = this.loadDataDatabaseDataSet;
            // 
            // loadDataDatabaseDataSet
            // 
            this.loadDataDatabaseDataSet.DataSetName = "LoadDataDatabaseDataSet";
            this.loadDataDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBulletType
            // 
            this.lblBulletType.AutoSize = true;
            this.lblBulletType.Location = new System.Drawing.Point(12, 190);
            this.lblBulletType.Name = "lblBulletType";
            this.lblBulletType.Size = new System.Drawing.Size(71, 16);
            this.lblBulletType.TabIndex = 4;
            this.lblBulletType.Text = "Bullet Type";
            // 
            // tbBulletType
            // 
            this.tbBulletType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbBulletType.Location = new System.Drawing.Point(12, 209);
            this.tbBulletType.Name = "tbBulletType";
            this.tbBulletType.Size = new System.Drawing.Size(100, 23);
            this.tbBulletType.TabIndex = 2;
            // 
            // lblBulletWeight
            // 
            this.lblBulletWeight.AutoSize = true;
            this.lblBulletWeight.Location = new System.Drawing.Point(12, 250);
            this.lblBulletWeight.Name = "lblBulletWeight";
            this.lblBulletWeight.Size = new System.Drawing.Size(109, 16);
            this.lblBulletWeight.TabIndex = 6;
            this.lblBulletWeight.Text = "Bullet Weight (gr)";
            // 
            // tbBulletWeight
            // 
            this.tbBulletWeight.Location = new System.Drawing.Point(12, 269);
            this.tbBulletWeight.Name = "tbBulletWeight";
            this.tbBulletWeight.Size = new System.Drawing.Size(100, 23);
            this.tbBulletWeight.TabIndex = 3;
            // 
            // lblPowder
            // 
            this.lblPowder.AutoSize = true;
            this.lblPowder.Location = new System.Drawing.Point(12, 310);
            this.lblPowder.Name = "lblPowder";
            this.lblPowder.Size = new System.Drawing.Size(83, 16);
            this.lblPowder.TabIndex = 8;
            this.lblPowder.Text = "Powder Type";
            // 
            // tbPowderType
            // 
            this.tbPowderType.Location = new System.Drawing.Point(12, 329);
            this.tbPowderType.Name = "tbPowderType";
            this.tbPowderType.Size = new System.Drawing.Size(100, 23);
            this.tbPowderType.TabIndex = 4;
            // 
            // lblPowderWeight
            // 
            this.lblPowderWeight.AutoSize = true;
            this.lblPowderWeight.Location = new System.Drawing.Point(12, 370);
            this.lblPowderWeight.Name = "lblPowderWeight";
            this.lblPowderWeight.Size = new System.Drawing.Size(122, 16);
            this.lblPowderWeight.TabIndex = 10;
            this.lblPowderWeight.Text = "Powder Charge (gr)";
            // 
            // tbPowderWeight
            // 
            this.tbPowderWeight.Location = new System.Drawing.Point(12, 389);
            this.tbPowderWeight.Name = "tbPowderWeight";
            this.tbPowderWeight.Size = new System.Drawing.Size(100, 23);
            this.tbPowderWeight.TabIndex = 5;
            // 
            // lblPrimerType
            // 
            this.lblPrimerType.AutoSize = true;
            this.lblPrimerType.Location = new System.Drawing.Point(12, 430);
            this.lblPrimerType.Name = "lblPrimerType";
            this.lblPrimerType.Size = new System.Drawing.Size(78, 16);
            this.lblPrimerType.TabIndex = 12;
            this.lblPrimerType.Text = "Primer Type";
            // 
            // cbPrimerType
            // 
            this.cbPrimerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrimerType.FormattingEnabled = true;
            this.cbPrimerType.Location = new System.Drawing.Point(12, 450);
            this.cbPrimerType.Name = "cbPrimerType";
            this.cbPrimerType.Size = new System.Drawing.Size(100, 24);
            this.cbPrimerType.TabIndex = 6;
            // 
            // primersBindingSource
            // 
            this.primersBindingSource.DataMember = "Primers";
            this.primersBindingSource.DataSource = this.loadDataDatabaseDataSet;
            // 
            // gbPriceRifleInfo
            // 
            this.gbPriceRifleInfo.Controls.Add(this.cbRifleInformation);
            this.gbPriceRifleInfo.Controls.Add(this.cbPrice);
            this.gbPriceRifleInfo.Controls.Add(this.lblPriceRifleInfo);
            this.gbPriceRifleInfo.Location = new System.Drawing.Point(148, 27);
            this.gbPriceRifleInfo.Name = "gbPriceRifleInfo";
            this.gbPriceRifleInfo.Size = new System.Drawing.Size(180, 86);
            this.gbPriceRifleInfo.TabIndex = 0;
            this.gbPriceRifleInfo.TabStop = false;
            // 
            // cbRifleInformation
            // 
            this.cbRifleInformation.AutoSize = true;
            this.cbRifleInformation.Location = new System.Drawing.Point(10, 57);
            this.cbRifleInformation.Name = "cbRifleInformation";
            this.cbRifleInformation.Size = new System.Drawing.Size(82, 20);
            this.cbRifleInformation.TabIndex = 2;
            this.cbRifleInformation.TabStop = false;
            this.cbRifleInformation.Text = "Rifle Data";
            this.cbRifleInformation.UseVisualStyleBackColor = true;
            this.cbRifleInformation.CheckedChanged += new System.EventHandler(this.cbRifleInformation_CheckedChanged);
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.Location = new System.Drawing.Point(10, 31);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(61, 20);
            this.cbPrice.TabIndex = 1;
            this.cbPrice.TabStop = false;
            this.cbPrice.Text = "Prices";
            this.cbPrice.UseVisualStyleBackColor = true;
            this.cbPrice.CheckedChanged += new System.EventHandler(this.cbPrice_CheckedChanged);
            // 
            // lblPriceRifleInfo
            // 
            this.lblPriceRifleInfo.AutoSize = true;
            this.lblPriceRifleInfo.Location = new System.Drawing.Point(7, 9);
            this.lblPriceRifleInfo.Name = "lblPriceRifleInfo";
            this.lblPriceRifleInfo.Size = new System.Drawing.Size(166, 16);
            this.lblPriceRifleInfo.TabIndex = 0;
            this.lblPriceRifleInfo.Text = "Prices and Rifle Information";
            // 
            // gbStoreBoughtAmmo
            // 
            this.gbStoreBoughtAmmo.Controls.Add(this.tbStoreBoughtQuantity);
            this.gbStoreBoughtAmmo.Controls.Add(this.tbStoreBoughtPrice);
            this.gbStoreBoughtAmmo.Controls.Add(this.lblStoreBoughtQuantity);
            this.gbStoreBoughtAmmo.Controls.Add(this.lblStoreBoughtPrice);
            this.gbStoreBoughtAmmo.Controls.Add(this.lblStoreBoughtAmmo);
            this.gbStoreBoughtAmmo.Location = new System.Drawing.Point(148, 120);
            this.gbStoreBoughtAmmo.Name = "gbStoreBoughtAmmo";
            this.gbStoreBoughtAmmo.Size = new System.Drawing.Size(180, 86);
            this.gbStoreBoughtAmmo.TabIndex = 7;
            this.gbStoreBoughtAmmo.TabStop = false;
            // 
            // tbStoreBoughtQuantity
            // 
            this.tbStoreBoughtQuantity.Location = new System.Drawing.Point(82, 28);
            this.tbStoreBoughtQuantity.Name = "tbStoreBoughtQuantity";
            this.tbStoreBoughtQuantity.Size = new System.Drawing.Size(79, 23);
            this.tbStoreBoughtQuantity.TabIndex = 7;
            // 
            // tbStoreBoughtPrice
            // 
            this.tbStoreBoughtPrice.Location = new System.Drawing.Point(82, 54);
            this.tbStoreBoughtPrice.Name = "tbStoreBoughtPrice";
            this.tbStoreBoughtPrice.Size = new System.Drawing.Size(79, 23);
            this.tbStoreBoughtPrice.TabIndex = 8;
            // 
            // lblStoreBoughtQuantity
            // 
            this.lblStoreBoughtQuantity.AutoSize = true;
            this.lblStoreBoughtQuantity.Location = new System.Drawing.Point(10, 31);
            this.lblStoreBoughtQuantity.Name = "lblStoreBoughtQuantity";
            this.lblStoreBoughtQuantity.Size = new System.Drawing.Size(60, 16);
            this.lblStoreBoughtQuantity.TabIndex = 3;
            this.lblStoreBoughtQuantity.Text = "Quantity:";
            // 
            // lblStoreBoughtPrice
            // 
            this.lblStoreBoughtPrice.AutoSize = true;
            this.lblStoreBoughtPrice.Location = new System.Drawing.Point(10, 57);
            this.lblStoreBoughtPrice.Name = "lblStoreBoughtPrice";
            this.lblStoreBoughtPrice.Size = new System.Drawing.Size(41, 16);
            this.lblStoreBoughtPrice.TabIndex = 2;
            this.lblStoreBoughtPrice.Text = "Price:";
            // 
            // lblStoreBoughtAmmo
            // 
            this.lblStoreBoughtAmmo.AutoSize = true;
            this.lblStoreBoughtAmmo.Location = new System.Drawing.Point(7, 9);
            this.lblStoreBoughtAmmo.Name = "lblStoreBoughtAmmo";
            this.lblStoreBoughtAmmo.Size = new System.Drawing.Size(154, 16);
            this.lblStoreBoughtAmmo.TabIndex = 0;
            this.lblStoreBoughtAmmo.Text = "Store Bought Ammunition";
            // 
            // gbPowder
            // 
            this.gbPowder.Controls.Add(this.tbPowderQuantity);
            this.gbPowder.Controls.Add(this.tbPowderPrice);
            this.gbPowder.Controls.Add(this.lblPowderQuantity);
            this.gbPowder.Controls.Add(this.lblPowderPrice);
            this.gbPowder.Controls.Add(this.label8);
            this.gbPowder.Location = new System.Drawing.Point(148, 306);
            this.gbPowder.Name = "gbPowder";
            this.gbPowder.Size = new System.Drawing.Size(180, 86);
            this.gbPowder.TabIndex = 9;
            this.gbPowder.TabStop = false;
            // 
            // tbPowderQuantity
            // 
            this.tbPowderQuantity.Location = new System.Drawing.Point(82, 28);
            this.tbPowderQuantity.Name = "tbPowderQuantity";
            this.tbPowderQuantity.Size = new System.Drawing.Size(79, 23);
            this.tbPowderQuantity.TabIndex = 11;
            // 
            // tbPowderPrice
            // 
            this.tbPowderPrice.Location = new System.Drawing.Point(82, 54);
            this.tbPowderPrice.Name = "tbPowderPrice";
            this.tbPowderPrice.Size = new System.Drawing.Size(79, 23);
            this.tbPowderPrice.TabIndex = 12;
            // 
            // lblPowderQuantity
            // 
            this.lblPowderQuantity.AutoSize = true;
            this.lblPowderQuantity.Location = new System.Drawing.Point(10, 31);
            this.lblPowderQuantity.Name = "lblPowderQuantity";
            this.lblPowderQuantity.Size = new System.Drawing.Size(60, 16);
            this.lblPowderQuantity.TabIndex = 3;
            this.lblPowderQuantity.Text = "Quantity:";
            // 
            // lblPowderPrice
            // 
            this.lblPowderPrice.AutoSize = true;
            this.lblPowderPrice.Location = new System.Drawing.Point(10, 57);
            this.lblPowderPrice.Name = "lblPowderPrice";
            this.lblPowderPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPowderPrice.TabIndex = 2;
            this.lblPowderPrice.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Powder (lbs)";
            // 
            // gbBullet
            // 
            this.gbBullet.Controls.Add(this.tbBulletQuantity);
            this.gbBullet.Controls.Add(this.tbBulletPrice);
            this.gbBullet.Controls.Add(this.lblBulletQuantity);
            this.gbBullet.Controls.Add(this.lblBulletPrice);
            this.gbBullet.Controls.Add(this.lblBullet);
            this.gbBullet.Location = new System.Drawing.Point(148, 213);
            this.gbBullet.Name = "gbBullet";
            this.gbBullet.Size = new System.Drawing.Size(180, 86);
            this.gbBullet.TabIndex = 8;
            this.gbBullet.TabStop = false;
            // 
            // tbBulletQuantity
            // 
            this.tbBulletQuantity.Location = new System.Drawing.Point(82, 28);
            this.tbBulletQuantity.Name = "tbBulletQuantity";
            this.tbBulletQuantity.Size = new System.Drawing.Size(79, 23);
            this.tbBulletQuantity.TabIndex = 9;
            // 
            // tbBulletPrice
            // 
            this.tbBulletPrice.Location = new System.Drawing.Point(82, 54);
            this.tbBulletPrice.Name = "tbBulletPrice";
            this.tbBulletPrice.Size = new System.Drawing.Size(79, 23);
            this.tbBulletPrice.TabIndex = 10;
            // 
            // lblBulletQuantity
            // 
            this.lblBulletQuantity.AutoSize = true;
            this.lblBulletQuantity.Location = new System.Drawing.Point(10, 31);
            this.lblBulletQuantity.Name = "lblBulletQuantity";
            this.lblBulletQuantity.Size = new System.Drawing.Size(60, 16);
            this.lblBulletQuantity.TabIndex = 3;
            this.lblBulletQuantity.Text = "Quantity:";
            // 
            // lblBulletPrice
            // 
            this.lblBulletPrice.AutoSize = true;
            this.lblBulletPrice.Location = new System.Drawing.Point(10, 57);
            this.lblBulletPrice.Name = "lblBulletPrice";
            this.lblBulletPrice.Size = new System.Drawing.Size(41, 16);
            this.lblBulletPrice.TabIndex = 2;
            this.lblBulletPrice.Text = "Price:";
            // 
            // lblBullet
            // 
            this.lblBullet.AutoSize = true;
            this.lblBullet.Location = new System.Drawing.Point(7, 9);
            this.lblBullet.Name = "lblBullet";
            this.lblBullet.Size = new System.Drawing.Size(39, 16);
            this.lblBullet.TabIndex = 0;
            this.lblBullet.Text = "Bullet";
            // 
            // gbPrimer
            // 
            this.gbPrimer.Controls.Add(this.tbPrimerQuanity);
            this.gbPrimer.Controls.Add(this.tbPrimerPrice);
            this.gbPrimer.Controls.Add(this.lblPrimerQuantity);
            this.gbPrimer.Controls.Add(this.lblPrimerPrice);
            this.gbPrimer.Controls.Add(this.lblPrimer);
            this.gbPrimer.Location = new System.Drawing.Point(148, 399);
            this.gbPrimer.Name = "gbPrimer";
            this.gbPrimer.Size = new System.Drawing.Size(180, 86);
            this.gbPrimer.TabIndex = 10;
            this.gbPrimer.TabStop = false;
            // 
            // tbPrimerQuanity
            // 
            this.tbPrimerQuanity.Location = new System.Drawing.Point(82, 28);
            this.tbPrimerQuanity.Name = "tbPrimerQuanity";
            this.tbPrimerQuanity.Size = new System.Drawing.Size(79, 23);
            this.tbPrimerQuanity.TabIndex = 13;
            // 
            // tbPrimerPrice
            // 
            this.tbPrimerPrice.Location = new System.Drawing.Point(82, 54);
            this.tbPrimerPrice.Name = "tbPrimerPrice";
            this.tbPrimerPrice.Size = new System.Drawing.Size(79, 23);
            this.tbPrimerPrice.TabIndex = 14;
            // 
            // lblPrimerQuantity
            // 
            this.lblPrimerQuantity.AutoSize = true;
            this.lblPrimerQuantity.Location = new System.Drawing.Point(10, 31);
            this.lblPrimerQuantity.Name = "lblPrimerQuantity";
            this.lblPrimerQuantity.Size = new System.Drawing.Size(60, 16);
            this.lblPrimerQuantity.TabIndex = 3;
            this.lblPrimerQuantity.Text = "Quantity:";
            // 
            // lblPrimerPrice
            // 
            this.lblPrimerPrice.AutoSize = true;
            this.lblPrimerPrice.Location = new System.Drawing.Point(10, 57);
            this.lblPrimerPrice.Name = "lblPrimerPrice";
            this.lblPrimerPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrimerPrice.TabIndex = 2;
            this.lblPrimerPrice.Text = "Price:";
            // 
            // lblPrimer
            // 
            this.lblPrimer.AutoSize = true;
            this.lblPrimer.Location = new System.Drawing.Point(7, 9);
            this.lblPrimer.Name = "lblPrimer";
            this.lblPrimer.Size = new System.Drawing.Size(46, 16);
            this.lblPrimer.TabIndex = 0;
            this.lblPrimer.Text = "Primer";
            // 
            // gbRifleInformation
            // 
            this.gbRifleInformation.Controls.Add(this.lbl1000W);
            this.gbRifleInformation.Controls.Add(this.lbl1000E);
            this.gbRifleInformation.Controls.Add(this.lbl300W);
            this.gbRifleInformation.Controls.Add(this.lbl300E);
            this.gbRifleInformation.Controls.Add(this.lbl600W);
            this.gbRifleInformation.Controls.Add(this.lbl600E);
            this.gbRifleInformation.Controls.Add(this.lbl200W);
            this.gbRifleInformation.Controls.Add(this.lbl200E);
            this.gbRifleInformation.Controls.Add(this.tb1000LeftRight);
            this.gbRifleInformation.Controls.Add(this.tb1000UpDown);
            this.gbRifleInformation.Controls.Add(this.tb300LeftRight);
            this.gbRifleInformation.Controls.Add(this.tb300UpDown);
            this.gbRifleInformation.Controls.Add(this.tb600LeftRight);
            this.gbRifleInformation.Controls.Add(this.tb600UpDown);
            this.gbRifleInformation.Controls.Add(this.tb200LeftRight);
            this.gbRifleInformation.Controls.Add(this.tb200UpDown);
            this.gbRifleInformation.Controls.Add(this.lbl1000ADJ);
            this.gbRifleInformation.Controls.Add(this.lbl600ADJ);
            this.gbRifleInformation.Controls.Add(this.tbScope);
            this.gbRifleInformation.Controls.Add(this.tbRifle);
            this.gbRifleInformation.Controls.Add(this.lbl300ADJ);
            this.gbRifleInformation.Controls.Add(this.tbVelocity);
            this.gbRifleInformation.Controls.Add(this.lblVelocity);
            this.gbRifleInformation.Controls.Add(this.tbOverallLength);
            this.gbRifleInformation.Controls.Add(this.lblOverallLength);
            this.gbRifleInformation.Controls.Add(this.tbBarrelLength);
            this.gbRifleInformation.Controls.Add(this.lblBarrelLength);
            this.gbRifleInformation.Controls.Add(this.lblScope);
            this.gbRifleInformation.Controls.Add(this.lbl200ADJ);
            this.gbRifleInformation.Controls.Add(this.tbZeroDistance);
            this.gbRifleInformation.Controls.Add(this.lblZeroDistance);
            this.gbRifleInformation.Controls.Add(this.tbCaseLength);
            this.gbRifleInformation.Controls.Add(this.lblCaseLength);
            this.gbRifleInformation.Controls.Add(this.tbTwistRate);
            this.gbRifleInformation.Controls.Add(this.lblTwistRate);
            this.gbRifleInformation.Controls.Add(this.lblRifle);
            this.gbRifleInformation.Location = new System.Drawing.Point(352, 62);
            this.gbRifleInformation.Name = "gbRifleInformation";
            this.gbRifleInformation.Size = new System.Drawing.Size(299, 423);
            this.gbRifleInformation.TabIndex = 11;
            this.gbRifleInformation.TabStop = false;
            // 
            // lbl1000W
            // 
            this.lbl1000W.AutoSize = true;
            this.lbl1000W.Location = new System.Drawing.Point(157, 395);
            this.lbl1000W.Name = "lbl1000W";
            this.lbl1000W.Size = new System.Drawing.Size(63, 16);
            this.lbl1000W.TabIndex = 68;
            this.lbl1000W.Text = "Windage:";
            // 
            // lbl1000E
            // 
            this.lbl1000E.AutoSize = true;
            this.lbl1000E.Location = new System.Drawing.Point(157, 364);
            this.lbl1000E.Name = "lbl1000E";
            this.lbl1000E.Size = new System.Drawing.Size(64, 16);
            this.lbl1000E.TabIndex = 67;
            this.lbl1000E.Text = "Elevation:";
            // 
            // lbl300W
            // 
            this.lbl300W.AutoSize = true;
            this.lbl300W.Location = new System.Drawing.Point(157, 304);
            this.lbl300W.Name = "lbl300W";
            this.lbl300W.Size = new System.Drawing.Size(63, 16);
            this.lbl300W.TabIndex = 66;
            this.lbl300W.Text = "Windage:";
            // 
            // lbl300E
            // 
            this.lbl300E.AutoSize = true;
            this.lbl300E.Location = new System.Drawing.Point(157, 273);
            this.lbl300E.Name = "lbl300E";
            this.lbl300E.Size = new System.Drawing.Size(64, 16);
            this.lbl300E.TabIndex = 65;
            this.lbl300E.Text = "Elevation:";
            // 
            // lbl600W
            // 
            this.lbl600W.AutoSize = true;
            this.lbl600W.Location = new System.Drawing.Point(9, 395);
            this.lbl600W.Name = "lbl600W";
            this.lbl600W.Size = new System.Drawing.Size(63, 16);
            this.lbl600W.TabIndex = 64;
            this.lbl600W.Text = "Windage:";
            // 
            // lbl600E
            // 
            this.lbl600E.AutoSize = true;
            this.lbl600E.Location = new System.Drawing.Point(9, 364);
            this.lbl600E.Name = "lbl600E";
            this.lbl600E.Size = new System.Drawing.Size(64, 16);
            this.lbl600E.TabIndex = 63;
            this.lbl600E.Text = "Elevation:";
            // 
            // lbl200W
            // 
            this.lbl200W.AutoSize = true;
            this.lbl200W.Location = new System.Drawing.Point(9, 304);
            this.lbl200W.Name = "lbl200W";
            this.lbl200W.Size = new System.Drawing.Size(63, 16);
            this.lbl200W.TabIndex = 62;
            this.lbl200W.Text = "Windage:";
            // 
            // lbl200E
            // 
            this.lbl200E.AutoSize = true;
            this.lbl200E.Location = new System.Drawing.Point(9, 273);
            this.lbl200E.Name = "lbl200E";
            this.lbl200E.Size = new System.Drawing.Size(64, 16);
            this.lbl200E.TabIndex = 61;
            this.lbl200E.Text = "Elevation:";
            // 
            // tb1000LeftRight
            // 
            this.tb1000LeftRight.Location = new System.Drawing.Point(222, 392);
            this.tb1000LeftRight.Name = "tb1000LeftRight";
            this.tb1000LeftRight.Size = new System.Drawing.Size(55, 23);
            this.tb1000LeftRight.TabIndex = 30;
            // 
            // tb1000UpDown
            // 
            this.tb1000UpDown.Location = new System.Drawing.Point(222, 361);
            this.tb1000UpDown.Name = "tb1000UpDown";
            this.tb1000UpDown.Size = new System.Drawing.Size(55, 23);
            this.tb1000UpDown.TabIndex = 29;
            // 
            // tb300LeftRight
            // 
            this.tb300LeftRight.Location = new System.Drawing.Point(222, 301);
            this.tb300LeftRight.Name = "tb300LeftRight";
            this.tb300LeftRight.Size = new System.Drawing.Size(55, 23);
            this.tb300LeftRight.TabIndex = 26;
            // 
            // tb300UpDown
            // 
            this.tb300UpDown.Location = new System.Drawing.Point(222, 270);
            this.tb300UpDown.Name = "tb300UpDown";
            this.tb300UpDown.Size = new System.Drawing.Size(55, 23);
            this.tb300UpDown.TabIndex = 25;
            // 
            // tb600LeftRight
            // 
            this.tb600LeftRight.Location = new System.Drawing.Point(74, 392);
            this.tb600LeftRight.Name = "tb600LeftRight";
            this.tb600LeftRight.Size = new System.Drawing.Size(55, 23);
            this.tb600LeftRight.TabIndex = 28;
            // 
            // tb600UpDown
            // 
            this.tb600UpDown.Location = new System.Drawing.Point(74, 361);
            this.tb600UpDown.Name = "tb600UpDown";
            this.tb600UpDown.Size = new System.Drawing.Size(55, 23);
            this.tb600UpDown.TabIndex = 27;
            // 
            // tb200LeftRight
            // 
            this.tb200LeftRight.Location = new System.Drawing.Point(74, 301);
            this.tb200LeftRight.Name = "tb200LeftRight";
            this.tb200LeftRight.Size = new System.Drawing.Size(55, 23);
            this.tb200LeftRight.TabIndex = 24;
            // 
            // tb200UpDown
            // 
            this.tb200UpDown.Location = new System.Drawing.Point(74, 270);
            this.tb200UpDown.Name = "tb200UpDown";
            this.tb200UpDown.Size = new System.Drawing.Size(55, 23);
            this.tb200UpDown.TabIndex = 23;
            // 
            // lbl1000ADJ
            // 
            this.lbl1000ADJ.AutoSize = true;
            this.lbl1000ADJ.Location = new System.Drawing.Point(155, 342);
            this.lbl1000ADJ.Name = "lbl1000ADJ";
            this.lbl1000ADJ.Size = new System.Drawing.Size(122, 16);
            this.lbl1000ADJ.TabIndex = 40;
            this.lbl1000ADJ.Text = "Adjustment 1000 yd";
            // 
            // lbl600ADJ
            // 
            this.lbl600ADJ.AutoSize = true;
            this.lbl600ADJ.Location = new System.Drawing.Point(7, 342);
            this.lbl600ADJ.Name = "lbl600ADJ";
            this.lbl600ADJ.Size = new System.Drawing.Size(115, 16);
            this.lbl600ADJ.TabIndex = 39;
            this.lbl600ADJ.Text = "Adjustment 600 yd";
            // 
            // tbScope
            // 
            this.tbScope.Location = new System.Drawing.Point(158, 28);
            this.tbScope.Name = "tbScope";
            this.tbScope.Size = new System.Drawing.Size(119, 23);
            this.tbScope.TabIndex = 16;
            // 
            // tbRifle
            // 
            this.tbRifle.Location = new System.Drawing.Point(10, 28);
            this.tbRifle.Name = "tbRifle";
            this.tbRifle.Size = new System.Drawing.Size(119, 23);
            this.tbRifle.TabIndex = 15;
            // 
            // lbl300ADJ
            // 
            this.lbl300ADJ.AutoSize = true;
            this.lbl300ADJ.Location = new System.Drawing.Point(155, 250);
            this.lbl300ADJ.Name = "lbl300ADJ";
            this.lbl300ADJ.Size = new System.Drawing.Size(115, 16);
            this.lbl300ADJ.TabIndex = 34;
            this.lbl300ADJ.Text = "Adjustment 300 yd";
            // 
            // tbVelocity
            // 
            this.tbVelocity.Location = new System.Drawing.Point(158, 209);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(119, 23);
            this.tbVelocity.TabIndex = 22;
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(155, 190);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(85, 16);
            this.lblVelocity.TabIndex = 32;
            this.lblVelocity.Text = "Velocity (ft/s)";
            // 
            // tbOverallLength
            // 
            this.tbOverallLength.Location = new System.Drawing.Point(158, 149);
            this.tbOverallLength.Name = "tbOverallLength";
            this.tbOverallLength.Size = new System.Drawing.Size(119, 23);
            this.tbOverallLength.TabIndex = 20;
            // 
            // lblOverallLength
            // 
            this.lblOverallLength.AutoSize = true;
            this.lblOverallLength.Location = new System.Drawing.Point(155, 130);
            this.lblOverallLength.Name = "lblOverallLength";
            this.lblOverallLength.Size = new System.Drawing.Size(141, 16);
            this.lblOverallLength.TabIndex = 30;
            this.lblOverallLength.Text = "Overall Length (Inches)";
            // 
            // tbBarrelLength
            // 
            this.tbBarrelLength.Location = new System.Drawing.Point(158, 89);
            this.tbBarrelLength.Name = "tbBarrelLength";
            this.tbBarrelLength.Size = new System.Drawing.Size(119, 23);
            this.tbBarrelLength.TabIndex = 18;
            // 
            // lblBarrelLength
            // 
            this.lblBarrelLength.AutoSize = true;
            this.lblBarrelLength.Location = new System.Drawing.Point(155, 70);
            this.lblBarrelLength.Name = "lblBarrelLength";
            this.lblBarrelLength.Size = new System.Drawing.Size(135, 16);
            this.lblBarrelLength.TabIndex = 28;
            this.lblBarrelLength.Text = "Barrel Length (Inches)";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(155, 9);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(43, 16);
            this.lblScope.TabIndex = 26;
            this.lblScope.Text = "Scope";
            // 
            // lbl200ADJ
            // 
            this.lbl200ADJ.AutoSize = true;
            this.lbl200ADJ.Location = new System.Drawing.Point(7, 250);
            this.lbl200ADJ.Name = "lbl200ADJ";
            this.lbl200ADJ.Size = new System.Drawing.Size(115, 16);
            this.lbl200ADJ.TabIndex = 22;
            this.lbl200ADJ.Text = "Adjustment 200 yd";
            // 
            // tbZeroDistance
            // 
            this.tbZeroDistance.Location = new System.Drawing.Point(10, 209);
            this.tbZeroDistance.Name = "tbZeroDistance";
            this.tbZeroDistance.Size = new System.Drawing.Size(119, 23);
            this.tbZeroDistance.TabIndex = 21;
            // 
            // lblZeroDistance
            // 
            this.lblZeroDistance.AutoSize = true;
            this.lblZeroDistance.Location = new System.Drawing.Point(7, 190);
            this.lblZeroDistance.Name = "lblZeroDistance";
            this.lblZeroDistance.Size = new System.Drawing.Size(132, 16);
            this.lblZeroDistance.TabIndex = 20;
            this.lblZeroDistance.Text = "Zero Distance (Yards)";
            // 
            // tbCaseLength
            // 
            this.tbCaseLength.Location = new System.Drawing.Point(10, 149);
            this.tbCaseLength.Name = "tbCaseLength";
            this.tbCaseLength.Size = new System.Drawing.Size(119, 23);
            this.tbCaseLength.TabIndex = 19;
            // 
            // lblCaseLength
            // 
            this.lblCaseLength.AutoSize = true;
            this.lblCaseLength.Location = new System.Drawing.Point(7, 130);
            this.lblCaseLength.Name = "lblCaseLength";
            this.lblCaseLength.Size = new System.Drawing.Size(129, 16);
            this.lblCaseLength.TabIndex = 18;
            this.lblCaseLength.Text = "Case Length (Inches)";
            // 
            // tbTwistRate
            // 
            this.tbTwistRate.Location = new System.Drawing.Point(10, 89);
            this.tbTwistRate.Name = "tbTwistRate";
            this.tbTwistRate.Size = new System.Drawing.Size(119, 23);
            this.tbTwistRate.TabIndex = 17;
            // 
            // lblTwistRate
            // 
            this.lblTwistRate.AutoSize = true;
            this.lblTwistRate.Location = new System.Drawing.Point(7, 70);
            this.lblTwistRate.Name = "lblTwistRate";
            this.lblTwistRate.Size = new System.Drawing.Size(69, 16);
            this.lblTwistRate.TabIndex = 16;
            this.lblTwistRate.Text = "Twist Rate";
            // 
            // lblRifle
            // 
            this.lblRifle.AutoSize = true;
            this.lblRifle.Location = new System.Drawing.Point(7, 9);
            this.lblRifle.Name = "lblRifle";
            this.lblRifle.Size = new System.Drawing.Size(33, 16);
            this.lblRifle.TabIndex = 14;
            this.lblRifle.Text = "Rifle";
            // 
            // btnAddLoad
            // 
            this.btnAddLoad.AutoSize = true;
            this.btnAddLoad.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoad.Location = new System.Drawing.Point(668, 36);
            this.btnAddLoad.Name = "btnAddLoad";
            this.btnAddLoad.Size = new System.Drawing.Size(204, 49);
            this.btnAddLoad.TabIndex = 31;
            this.btnAddLoad.Text = "Add Load";
            this.btnAddLoad.UseVisualStyleBackColor = true;
            this.btnAddLoad.Click += new System.EventHandler(this.btnAddLoad_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.lblLoad1000Cost);
            this.gbOutput.Controls.Add(this.lblSaved1000Money);
            this.gbOutput.Controls.Add(this.lblSaved100Money);
            this.gbOutput.Controls.Add(this.lblSavedUnitMoney);
            this.gbOutput.Controls.Add(this.lblStore1000Cost);
            this.gbOutput.Controls.Add(this.lblStore100Cost);
            this.gbOutput.Controls.Add(this.lblStoreUnitCost);
            this.gbOutput.Controls.Add(this.lblLoad100Cost);
            this.gbOutput.Controls.Add(this.lblLoadUnitCost);
            this.gbOutput.Controls.Add(this.lblSaved1000);
            this.gbOutput.Controls.Add(this.lblSaved100);
            this.gbOutput.Controls.Add(this.lblSavedUnit);
            this.gbOutput.Controls.Add(this.lblMoneySaved);
            this.gbOutput.Controls.Add(this.lblStore1000);
            this.gbOutput.Controls.Add(this.lblStore100);
            this.gbOutput.Controls.Add(this.lblStoreUnit);
            this.gbOutput.Controls.Add(this.lblStoreCost);
            this.gbOutput.Controls.Add(this.lblLoad100);
            this.gbOutput.Controls.Add(this.lblLoad1000);
            this.gbOutput.Controls.Add(this.lblLoadUnit);
            this.gbOutput.Controls.Add(this.lblLoadCost);
            this.gbOutput.Location = new System.Drawing.Point(668, 132);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(204, 353);
            this.gbOutput.TabIndex = 0;
            this.gbOutput.TabStop = false;
            // 
            // lblLoad1000Cost
            // 
            this.lblLoad1000Cost.AutoSize = true;
            this.lblLoad1000Cost.Location = new System.Drawing.Point(140, 83);
            this.lblLoad1000Cost.Name = "lblLoad1000Cost";
            this.lblLoad1000Cost.Size = new System.Drawing.Size(49, 16);
            this.lblLoad1000Cost.TabIndex = 21;
            this.lblLoad1000Cost.Text = "label22";
            this.lblLoad1000Cost.Visible = false;
            // 
            // lblSaved1000Money
            // 
            this.lblSaved1000Money.AutoSize = true;
            this.lblSaved1000Money.Location = new System.Drawing.Point(140, 321);
            this.lblSaved1000Money.Name = "lblSaved1000Money";
            this.lblSaved1000Money.Size = new System.Drawing.Size(49, 16);
            this.lblSaved1000Money.TabIndex = 20;
            this.lblSaved1000Money.Text = "label21";
            this.lblSaved1000Money.Visible = false;
            // 
            // lblSaved100Money
            // 
            this.lblSaved100Money.AutoSize = true;
            this.lblSaved100Money.Location = new System.Drawing.Point(140, 299);
            this.lblSaved100Money.Name = "lblSaved100Money";
            this.lblSaved100Money.Size = new System.Drawing.Size(49, 16);
            this.lblSaved100Money.TabIndex = 19;
            this.lblSaved100Money.Text = "label20";
            this.lblSaved100Money.Visible = false;
            // 
            // lblSavedUnitMoney
            // 
            this.lblSavedUnitMoney.AutoSize = true;
            this.lblSavedUnitMoney.Location = new System.Drawing.Point(140, 277);
            this.lblSavedUnitMoney.Name = "lblSavedUnitMoney";
            this.lblSavedUnitMoney.Size = new System.Drawing.Size(49, 16);
            this.lblSavedUnitMoney.TabIndex = 18;
            this.lblSavedUnitMoney.Text = "label19";
            this.lblSavedUnitMoney.Visible = false;
            // 
            // lblStore1000Cost
            // 
            this.lblStore1000Cost.AutoSize = true;
            this.lblStore1000Cost.Location = new System.Drawing.Point(140, 206);
            this.lblStore1000Cost.Name = "lblStore1000Cost";
            this.lblStore1000Cost.Size = new System.Drawing.Size(49, 16);
            this.lblStore1000Cost.TabIndex = 17;
            this.lblStore1000Cost.Text = "label18";
            this.lblStore1000Cost.Visible = false;
            // 
            // lblStore100Cost
            // 
            this.lblStore100Cost.AutoSize = true;
            this.lblStore100Cost.Location = new System.Drawing.Point(140, 180);
            this.lblStore100Cost.Name = "lblStore100Cost";
            this.lblStore100Cost.Size = new System.Drawing.Size(49, 16);
            this.lblStore100Cost.TabIndex = 16;
            this.lblStore100Cost.Text = "label17";
            this.lblStore100Cost.Visible = false;
            // 
            // lblStoreUnitCost
            // 
            this.lblStoreUnitCost.AutoSize = true;
            this.lblStoreUnitCost.Location = new System.Drawing.Point(140, 154);
            this.lblStoreUnitCost.Name = "lblStoreUnitCost";
            this.lblStoreUnitCost.Size = new System.Drawing.Size(49, 16);
            this.lblStoreUnitCost.TabIndex = 15;
            this.lblStoreUnitCost.Text = "label16";
            this.lblStoreUnitCost.Visible = false;
            // 
            // lblLoad100Cost
            // 
            this.lblLoad100Cost.AutoSize = true;
            this.lblLoad100Cost.Location = new System.Drawing.Point(140, 57);
            this.lblLoad100Cost.Name = "lblLoad100Cost";
            this.lblLoad100Cost.Size = new System.Drawing.Size(49, 16);
            this.lblLoad100Cost.TabIndex = 14;
            this.lblLoad100Cost.Text = "label15";
            this.lblLoad100Cost.Visible = false;
            // 
            // lblLoadUnitCost
            // 
            this.lblLoadUnitCost.AutoSize = true;
            this.lblLoadUnitCost.Location = new System.Drawing.Point(140, 31);
            this.lblLoadUnitCost.Name = "lblLoadUnitCost";
            this.lblLoadUnitCost.Size = new System.Drawing.Size(49, 16);
            this.lblLoadUnitCost.TabIndex = 13;
            this.lblLoadUnitCost.Text = "label14";
            this.lblLoadUnitCost.Visible = false;
            // 
            // lblSaved1000
            // 
            this.lblSaved1000.AutoSize = true;
            this.lblSaved1000.Location = new System.Drawing.Point(10, 321);
            this.lblSaved1000.Name = "lblSaved1000";
            this.lblSaved1000.Size = new System.Drawing.Size(95, 16);
            this.lblSaved1000.TabIndex = 12;
            this.lblSaved1000.Text = "For Each 1000:";
            // 
            // lblSaved100
            // 
            this.lblSaved100.AutoSize = true;
            this.lblSaved100.Location = new System.Drawing.Point(10, 299);
            this.lblSaved100.Name = "lblSaved100";
            this.lblSaved100.Size = new System.Drawing.Size(88, 16);
            this.lblSaved100.TabIndex = 11;
            this.lblSaved100.Text = "For Each 100:";
            // 
            // lblSavedUnit
            // 
            this.lblSavedUnit.AutoSize = true;
            this.lblSavedUnit.Location = new System.Drawing.Point(10, 277);
            this.lblSavedUnit.Name = "lblSavedUnit";
            this.lblSavedUnit.Size = new System.Drawing.Size(89, 16);
            this.lblSavedUnit.TabIndex = 10;
            this.lblSavedUnit.Text = "For Each Unit:";
            // 
            // lblMoneySaved
            // 
            this.lblMoneySaved.AutoSize = true;
            this.lblMoneySaved.Location = new System.Drawing.Point(7, 255);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(84, 16);
            this.lblMoneySaved.TabIndex = 9;
            this.lblMoneySaved.Text = "Money Saved";
            // 
            // lblStore1000
            // 
            this.lblStore1000.AutoSize = true;
            this.lblStore1000.Location = new System.Drawing.Point(10, 206);
            this.lblStore1000.Name = "lblStore1000";
            this.lblStore1000.Size = new System.Drawing.Size(95, 16);
            this.lblStore1000.TabIndex = 8;
            this.lblStore1000.Text = "For Each 1000:";
            // 
            // lblStore100
            // 
            this.lblStore100.AutoSize = true;
            this.lblStore100.Location = new System.Drawing.Point(10, 180);
            this.lblStore100.Name = "lblStore100";
            this.lblStore100.Size = new System.Drawing.Size(88, 16);
            this.lblStore100.TabIndex = 7;
            this.lblStore100.Text = "For Each 100:";
            // 
            // lblStoreUnit
            // 
            this.lblStoreUnit.AutoSize = true;
            this.lblStoreUnit.Location = new System.Drawing.Point(10, 154);
            this.lblStoreUnit.Name = "lblStoreUnit";
            this.lblStoreUnit.Size = new System.Drawing.Size(89, 16);
            this.lblStoreUnit.TabIndex = 6;
            this.lblStoreUnit.Text = "For Each Unit:";
            // 
            // lblStoreCost
            // 
            this.lblStoreCost.AutoSize = true;
            this.lblStoreCost.Location = new System.Drawing.Point(7, 132);
            this.lblStoreCost.Name = "lblStoreCost";
            this.lblStoreCost.Size = new System.Drawing.Size(126, 16);
            this.lblStoreCost.TabIndex = 5;
            this.lblStoreCost.Text = "Cost of Store Bought";
            // 
            // lblLoad100
            // 
            this.lblLoad100.AutoSize = true;
            this.lblLoad100.Location = new System.Drawing.Point(10, 57);
            this.lblLoad100.Name = "lblLoad100";
            this.lblLoad100.Size = new System.Drawing.Size(92, 16);
            this.lblLoad100.TabIndex = 4;
            this.lblLoad100.Text = "For Each 100: ";
            // 
            // lblLoad1000
            // 
            this.lblLoad1000.AutoSize = true;
            this.lblLoad1000.Location = new System.Drawing.Point(10, 83);
            this.lblLoad1000.Name = "lblLoad1000";
            this.lblLoad1000.Size = new System.Drawing.Size(99, 16);
            this.lblLoad1000.TabIndex = 3;
            this.lblLoad1000.Text = "For Each 1000: ";
            // 
            // lblLoadUnit
            // 
            this.lblLoadUnit.AutoSize = true;
            this.lblLoadUnit.Location = new System.Drawing.Point(10, 31);
            this.lblLoadUnit.Name = "lblLoadUnit";
            this.lblLoadUnit.Size = new System.Drawing.Size(93, 16);
            this.lblLoadUnit.TabIndex = 1;
            this.lblLoadUnit.Text = "For Each Unit: ";
            // 
            // lblLoadCost
            // 
            this.lblLoadCost.AutoSize = true;
            this.lblLoadCost.Location = new System.Drawing.Point(7, 9);
            this.lblLoadCost.Name = "lblLoadCost";
            this.lblLoadCost.Size = new System.Drawing.Size(107, 16);
            this.lblLoadCost.TabIndex = 0;
            this.lblLoadCost.Text = "Cost of This Load";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblConfirmation.Location = new System.Drawing.Point(670, 99);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(200, 19);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "New Load Has Been Added";
            this.lblConfirmation.Visible = false;
            // 
            // calibersTableAdapter
            // 
            this.calibersTableAdapter.ClearBeforeFill = true;
            // 
            // primersTableAdapter
            // 
            this.primersTableAdapter.ClearBeforeFill = true;
            // 
            // primersBindingSource1
            // 
            this.primersBindingSource1.DataMember = "Primers";
            this.primersBindingSource1.DataSource = this.loadDataDatabaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.btnAddLoad);
            this.Controls.Add(this.gbRifleInformation);
            this.Controls.Add(this.gbPrimer);
            this.Controls.Add(this.gbBullet);
            this.Controls.Add(this.gbPowder);
            this.Controls.Add(this.gbStoreBoughtAmmo);
            this.Controls.Add(this.gbPriceRifleInfo);
            this.Controls.Add(this.cbPrimerType);
            this.Controls.Add(this.lblPrimerType);
            this.Controls.Add(this.tbPowderWeight);
            this.Controls.Add(this.lblPowderWeight);
            this.Controls.Add(this.tbPowderType);
            this.Controls.Add(this.lblPowder);
            this.Controls.Add(this.tbBulletWeight);
            this.Controls.Add(this.lblBulletWeight);
            this.Controls.Add(this.tbBulletType);
            this.Controls.Add(this.lblBulletType);
            this.Controls.Add(this.cbCaliber);
            this.Controls.Add(this.lblCaliber);
            this.Controls.Add(this.gbLoadType);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Load Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLoadType.ResumeLayout(false);
            this.gbLoadType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource)).EndInit();
            this.gbPriceRifleInfo.ResumeLayout(false);
            this.gbPriceRifleInfo.PerformLayout();
            this.gbStoreBoughtAmmo.ResumeLayout(false);
            this.gbStoreBoughtAmmo.PerformLayout();
            this.gbPowder.ResumeLayout(false);
            this.gbPowder.PerformLayout();
            this.gbBullet.ResumeLayout(false);
            this.gbBullet.PerformLayout();
            this.gbPrimer.ResumeLayout(false);
            this.gbPrimer.PerformLayout();
            this.gbRifleInformation.ResumeLayout(false);
            this.gbRifleInformation.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.GroupBox gbLoadType;
        private System.Windows.Forms.RadioButton rbRifle;
        private System.Windows.Forms.RadioButton rbHandgun;
        private System.Windows.Forms.Label lblLoadType;
        private System.Windows.Forms.Label lblCaliber;
        private System.Windows.Forms.ComboBox cbCaliber;
        private System.Windows.Forms.Label lblBulletType;
        private System.Windows.Forms.Label lblBulletWeight;
        private System.Windows.Forms.TextBox tbBulletWeight;
        private System.Windows.Forms.Label lblPowder;
        private System.Windows.Forms.TextBox tbPowderType;
        private System.Windows.Forms.Label lblPowderWeight;
        private System.Windows.Forms.TextBox tbPowderWeight;
        private System.Windows.Forms.Label lblPrimerType;
        private System.Windows.Forms.ComboBox cbPrimerType;
        private System.Windows.Forms.GroupBox gbPriceRifleInfo;
        private System.Windows.Forms.Label lblPriceRifleInfo;
        private System.Windows.Forms.CheckBox cbRifleInformation;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.GroupBox gbStoreBoughtAmmo;
        private System.Windows.Forms.TextBox tbStoreBoughtPrice;
        private System.Windows.Forms.Label lblStoreBoughtQuantity;
        private System.Windows.Forms.Label lblStoreBoughtPrice;
        private System.Windows.Forms.Label lblStoreBoughtAmmo;
        private System.Windows.Forms.GroupBox gbPowder;
        private System.Windows.Forms.TextBox tbPowderPrice;
        private System.Windows.Forms.Label lblPowderQuantity;
        private System.Windows.Forms.Label lblPowderPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbBullet;
        private System.Windows.Forms.TextBox tbBulletPrice;
        private System.Windows.Forms.Label lblBulletQuantity;
        private System.Windows.Forms.Label lblBulletPrice;
        private System.Windows.Forms.Label lblBullet;
        private System.Windows.Forms.GroupBox gbPrimer;
        private System.Windows.Forms.TextBox tbPrimerPrice;
        private System.Windows.Forms.Label lblPrimerQuantity;
        private System.Windows.Forms.Label lblPrimerPrice;
        private System.Windows.Forms.Label lblPrimer;
        private System.Windows.Forms.TextBox tbStoreBoughtQuantity;
        private System.Windows.Forms.TextBox tbPowderQuantity;
        private System.Windows.Forms.TextBox tbBulletQuantity;
        private System.Windows.Forms.TextBox tbPrimerQuanity;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDeleteCaliber;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDeletePrimer;
        private System.Windows.Forms.GroupBox gbRifleInformation;
        private System.Windows.Forms.Label lbl300ADJ;
        private System.Windows.Forms.TextBox tbVelocity;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.TextBox tbOverallLength;
        private System.Windows.Forms.Label lblOverallLength;
        private System.Windows.Forms.TextBox tbBarrelLength;
        private System.Windows.Forms.Label lblBarrelLength;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.Label lbl200ADJ;
        private System.Windows.Forms.TextBox tbZeroDistance;
        private System.Windows.Forms.Label lblZeroDistance;
        private System.Windows.Forms.TextBox tbCaseLength;
        private System.Windows.Forms.Label lblCaseLength;
        private System.Windows.Forms.TextBox tbTwistRate;
        private System.Windows.Forms.Label lblTwistRate;
        private System.Windows.Forms.Label lblRifle;
        private System.Windows.Forms.Label lbl1000ADJ;
        private System.Windows.Forms.Label lbl600ADJ;
        private System.Windows.Forms.TextBox tbScope;
        private System.Windows.Forms.TextBox tbRifle;
        private System.Windows.Forms.TextBox tb200LeftRight;
        private System.Windows.Forms.TextBox tb200UpDown;
        private System.Windows.Forms.TextBox tb600LeftRight;
        private System.Windows.Forms.TextBox tb600UpDown;
        private System.Windows.Forms.TextBox tb1000LeftRight;
        private System.Windows.Forms.TextBox tb1000UpDown;
        private System.Windows.Forms.TextBox tb300LeftRight;
        private System.Windows.Forms.TextBox tb300UpDown;
        private System.Windows.Forms.Button btnAddLoad;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label lblLoad100;
        private System.Windows.Forms.Label lblLoad1000;
        private System.Windows.Forms.Label lblLoadUnit;
        private System.Windows.Forms.Label lblLoadCost;
        private System.Windows.Forms.Label lblStoreCost;
        private System.Windows.Forms.Label lblStore1000;
        private System.Windows.Forms.Label lblStore100;
        private System.Windows.Forms.Label lblStoreUnit;
        private System.Windows.Forms.Label lblLoad1000Cost;
        private System.Windows.Forms.Label lblSaved1000Money;
        private System.Windows.Forms.Label lblSaved100Money;
        private System.Windows.Forms.Label lblSavedUnitMoney;
        private System.Windows.Forms.Label lblStore1000Cost;
        private System.Windows.Forms.Label lblStore100Cost;
        private System.Windows.Forms.Label lblStoreUnitCost;
        private System.Windows.Forms.Label lblLoad100Cost;
        private System.Windows.Forms.Label lblLoadUnitCost;
        private System.Windows.Forms.Label lblSaved1000;
        private System.Windows.Forms.Label lblSaved100;
        private System.Windows.Forms.Label lblSavedUnit;
        private System.Windows.Forms.Label lblMoneySaved;
        private System.Windows.Forms.Label lblConfirmation;
        private LoadDataDatabaseDataSet loadDataDatabaseDataSet;
        private System.Windows.Forms.BindingSource calibersBindingSource;
        private LoadDataDatabaseDataSetTableAdapters.CalibersTableAdapter calibersTableAdapter;
        private System.Windows.Forms.BindingSource primersBindingSource;
        private LoadDataDatabaseDataSetTableAdapters.PrimersTableAdapter primersTableAdapter;
        private System.Windows.Forms.TextBox tbBulletType;
        private System.Windows.Forms.Label lbl1000W;
        private System.Windows.Forms.Label lbl1000E;
        private System.Windows.Forms.Label lbl300W;
        private System.Windows.Forms.Label lbl300E;
        private System.Windows.Forms.Label lbl600W;
        private System.Windows.Forms.Label lbl600E;
        private System.Windows.Forms.Label lbl200W;
        private System.Windows.Forms.Label lbl200E;
        private System.Windows.Forms.BindingSource primersBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

