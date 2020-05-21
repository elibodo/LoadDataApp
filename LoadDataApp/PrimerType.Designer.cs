namespace LoadDataApp
{
    partial class PrimerType
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbPrimer = new System.Windows.Forms.GroupBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbAddPrimer = new System.Windows.Forms.TextBox();
            this.cbPrimerTypes = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.loadDataDatabaseDataSet = new LoadDataApp.LoadDataDatabaseDataSet();
            this.primersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primersTableAdapter = new LoadDataApp.LoadDataDatabaseDataSetTableAdapters.PrimersTableAdapter();
            this.gbPrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(36, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(263, 48);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Primer Type";
            // 
            // gbPrimer
            // 
            this.gbPrimer.Controls.Add(this.lblDelete);
            this.gbPrimer.Controls.Add(this.lblAdd);
            this.gbPrimer.Controls.Add(this.btnAdd);
            this.gbPrimer.Controls.Add(this.btnDelete);
            this.gbPrimer.Controls.Add(this.tbAddPrimer);
            this.gbPrimer.Controls.Add(this.cbPrimerTypes);
            this.gbPrimer.Location = new System.Drawing.Point(16, 60);
            this.gbPrimer.Name = "gbPrimer";
            this.gbPrimer.Size = new System.Drawing.Size(303, 289);
            this.gbPrimer.TabIndex = 1;
            this.gbPrimer.TabStop = false;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(6, 81);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(123, 16);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "Delete Primer Type:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(6, 24);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(109, 16);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Add Primer Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbAddPrimer
            // 
            this.tbAddPrimer.Location = new System.Drawing.Point(135, 21);
            this.tbAddPrimer.Name = "tbAddPrimer";
            this.tbAddPrimer.Size = new System.Drawing.Size(162, 23);
            this.tbAddPrimer.TabIndex = 3;
            this.tbAddPrimer.TextChanged += new System.EventHandler(this.tbAddPrimer_TextChanged);
            // 
            // cbPrimerTypes
            // 
            this.cbPrimerTypes.FormattingEnabled = true;
            this.cbPrimerTypes.ItemHeight = 16;
            this.cbPrimerTypes.Location = new System.Drawing.Point(135, 81);
            this.cbPrimerTypes.Name = "cbPrimerTypes";
            this.cbPrimerTypes.Size = new System.Drawing.Size(162, 196);
            this.cbPrimerTypes.TabIndex = 2;
            this.cbPrimerTypes.SelectedIndexChanged += new System.EventHandler(this.cbPrimerTypes_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(122, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // loadDataDatabaseDataSet
            // 
            this.loadDataDatabaseDataSet.DataSetName = "LoadDataDatabaseDataSet";
            this.loadDataDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // primersBindingSource
            // 
            this.primersBindingSource.DataMember = "Primers";
            this.primersBindingSource.DataSource = this.loadDataDatabaseDataSet;
            // 
            // primersTableAdapter
            // 
            this.primersTableAdapter.ClearBeforeFill = true;
            // 
            // PrimerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbPrimer);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrimerType";
            this.Text = "PrimerType";
            this.Load += new System.EventHandler(this.PrimerType_Load);
            this.gbPrimer.ResumeLayout(false);
            this.gbPrimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbPrimer;
        private System.Windows.Forms.TextBox tbAddPrimer;
        private System.Windows.Forms.ListBox cbPrimerTypes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private LoadDataDatabaseDataSet loadDataDatabaseDataSet;
        private System.Windows.Forms.BindingSource primersBindingSource;
        private LoadDataDatabaseDataSetTableAdapters.PrimersTableAdapter primersTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblAdd;
    }
}