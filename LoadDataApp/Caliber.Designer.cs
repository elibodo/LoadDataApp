namespace LoadDataApp
{
    partial class Caliber
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
            this.gbCaliber = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbCalibers = new System.Windows.Forms.ListBox();
            this.tbAddCaliber = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCaliber.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCaliber
            // 
            this.gbCaliber.Controls.Add(this.label1);
            this.gbCaliber.Controls.Add(this.lblAdd);
            this.gbCaliber.Controls.Add(this.btnAdd);
            this.gbCaliber.Controls.Add(this.btnDelete);
            this.gbCaliber.Controls.Add(this.cbCalibers);
            this.gbCaliber.Controls.Add(this.tbAddCaliber);
            this.gbCaliber.Location = new System.Drawing.Point(16, 60);
            this.gbCaliber.Name = "gbCaliber";
            this.gbCaliber.Size = new System.Drawing.Size(303, 289);
            this.gbCaliber.TabIndex = 0;
            this.gbCaliber.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete Caliber:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(6, 24);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(79, 16);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Add Caliber:";
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
            // cbCalibers
            // 
            this.cbCalibers.FormattingEnabled = true;
            this.cbCalibers.ItemHeight = 16;
            this.cbCalibers.Location = new System.Drawing.Point(135, 81);
            this.cbCalibers.Name = "cbCalibers";
            this.cbCalibers.Size = new System.Drawing.Size(162, 196);
            this.cbCalibers.TabIndex = 3;
            this.cbCalibers.SelectedIndexChanged += new System.EventHandler(this.cbCalibers_SelectedIndexChanged);
            // 
            // tbAddCaliber
            // 
            this.tbAddCaliber.Location = new System.Drawing.Point(135, 21);
            this.tbAddCaliber.Name = "tbAddCaliber";
            this.tbAddCaliber.Size = new System.Drawing.Size(162, 23);
            this.tbAddCaliber.TabIndex = 2;
            this.tbAddCaliber.TextChanged += new System.EventHandler(this.tbAddCaliber_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(87, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(161, 48);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Caliber";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(122, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Caliber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbCaliber);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Caliber";
            this.Text = "Caliber";
            this.Load += new System.EventHandler(this.Caliber_Load);
            this.gbCaliber.ResumeLayout(false);
            this.gbCaliber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCaliber;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbAddCaliber;
        private System.Windows.Forms.ListBox cbCalibers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdd;
    }
}