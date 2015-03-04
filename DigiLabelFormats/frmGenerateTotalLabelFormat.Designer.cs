namespace DigiLabelFormats
{
    partial class FrmGenerateTotalLabelFormat
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLabelFormatCode = new System.Windows.Forms.TextBox();
            this.cmbTargetFormat = new System.Windows.Forms.ComboBox();
            this.pctWeight = new System.Windows.Forms.PictureBox();
            this.chkBarcode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAantal = new System.Windows.Forms.CheckBox();
            this.chkGewicht = new System.Windows.Forms.CheckBox();
            this.chkVerkoper = new System.Windows.Forms.CheckBox();
            this.chkInpakDatum = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAfmetingen = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTypeToestel = new System.Windows.Forms.ListBox();
            this.btnToCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(296, 653);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 49);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLabelFormatCode
            // 
            this.txtLabelFormatCode.Enabled = false;
            this.txtLabelFormatCode.Location = new System.Drawing.Point(6, 18);
            this.txtLabelFormatCode.Name = "txtLabelFormatCode";
            this.txtLabelFormatCode.Size = new System.Drawing.Size(212, 22);
            this.txtLabelFormatCode.TabIndex = 6;
            // 
            // cmbTargetFormat
            // 
            this.cmbTargetFormat.FormattingEnabled = true;
            this.cmbTargetFormat.Location = new System.Drawing.Point(7, 17);
            this.cmbTargetFormat.Name = "cmbTargetFormat";
            this.cmbTargetFormat.Size = new System.Drawing.Size(212, 22);
            this.cmbTargetFormat.TabIndex = 8;
            // 
            // pctWeight
            // 
            this.pctWeight.BackColor = System.Drawing.SystemColors.Control;
            this.pctWeight.Location = new System.Drawing.Point(296, 114);
            this.pctWeight.Name = "pctWeight";
            this.pctWeight.Size = new System.Drawing.Size(244, 533);
            this.pctWeight.TabIndex = 10;
            this.pctWeight.TabStop = false;
            // 
            // chkBarcode
            // 
            this.chkBarcode.AutoSize = true;
            this.chkBarcode.Location = new System.Drawing.Point(18, 20);
            this.chkBarcode.Name = "chkBarcode";
            this.chkBarcode.Size = new System.Drawing.Size(70, 18);
            this.chkBarcode.TabIndex = 16;
            this.chkBarcode.Text = "Barcode";
            this.chkBarcode.UseVisualStyleBackColor = true;
            this.chkBarcode.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAantal);
            this.groupBox1.Controls.Add(this.chkGewicht);
            this.groupBox1.Controls.Add(this.chkVerkoper);
            this.groupBox1.Controls.Add(this.chkInpakDatum);
            this.groupBox1.Controls.Add(this.chkBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 96);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select label fields";
            // 
            // chkAantal
            // 
            this.chkAantal.AutoSize = true;
            this.chkAantal.Location = new System.Drawing.Point(163, 43);
            this.chkAantal.Name = "chkAantal";
            this.chkAantal.Size = new System.Drawing.Size(73, 18);
            this.chkAantal.TabIndex = 21;
            this.chkAantal.Text = "Quantity";
            this.chkAantal.UseVisualStyleBackColor = true;
            this.chkAantal.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkGewicht
            // 
            this.chkGewicht.AutoSize = true;
            this.chkGewicht.Location = new System.Drawing.Point(18, 66);
            this.chkGewicht.Name = "chkGewicht";
            this.chkGewicht.Size = new System.Drawing.Size(64, 18);
            this.chkGewicht.TabIndex = 20;
            this.chkGewicht.Text = "Weight";
            this.chkGewicht.UseVisualStyleBackColor = true;
            this.chkGewicht.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkVerkoper
            // 
            this.chkVerkoper.AutoSize = true;
            this.chkVerkoper.Location = new System.Drawing.Point(163, 66);
            this.chkVerkoper.Name = "chkVerkoper";
            this.chkVerkoper.Size = new System.Drawing.Size(74, 18);
            this.chkVerkoper.TabIndex = 18;
            this.chkVerkoper.Text = "Operator";
            this.chkVerkoper.UseVisualStyleBackColor = true;
            this.chkVerkoper.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkInpakDatum
            // 
            this.chkInpakDatum.AutoSize = true;
            this.chkInpakDatum.Location = new System.Drawing.Point(18, 43);
            this.chkInpakDatum.Name = "chkInpakDatum";
            this.chkInpakDatum.Size = new System.Drawing.Size(91, 18);
            this.chkInpakDatum.TabIndex = 17;
            this.chkInpakDatum.Text = "Packed date";
            this.chkInpakDatum.UseVisualStyleBackColor = true;
            this.chkInpakDatum.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAfmetingen);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 292);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select size";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstAfmetingen
            // 
            this.lstAfmetingen.FormattingEnabled = true;
            this.lstAfmetingen.ItemHeight = 14;
            this.lstAfmetingen.Location = new System.Drawing.Point(20, 19);
            this.lstAfmetingen.Name = "lstAfmetingen";
            this.lstAfmetingen.Size = new System.Drawing.Size(212, 256);
            this.lstAfmetingen.TabIndex = 0;
            this.lstAfmetingen.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            this.lstAfmetingen.DoubleClick += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 653);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(244, 49);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTargetFormat);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 46);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Targetformat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabelFormatCode);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(32, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 46);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formatcode";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(32, 480);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(244, 49);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Select from list";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTypeToestel);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(19, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 60);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Device";
            // 
            // lstTypeToestel
            // 
            this.lstTypeToestel.FormattingEnabled = true;
            this.lstTypeToestel.ItemHeight = 14;
            this.lstTypeToestel.Location = new System.Drawing.Point(20, 19);
            this.lstTypeToestel.Name = "lstTypeToestel";
            this.lstTypeToestel.Size = new System.Drawing.Size(212, 32);
            this.lstTypeToestel.TabIndex = 0;
            this.lstTypeToestel.SelectedIndexChanged += new System.EventHandler(this.ChangeDevice);
            // 
            // btnToCreate
            // 
            this.btnToCreate.BackColor = System.Drawing.Color.LightGreen;
            this.btnToCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnToCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCreate.Location = new System.Drawing.Point(425, 653);
            this.btnToCreate.Name = "btnToCreate";
            this.btnToCreate.Size = new System.Drawing.Size(115, 49);
            this.btnToCreate.TabIndex = 25;
            this.btnToCreate.Text = "To Create";
            this.btnToCreate.UseVisualStyleBackColor = false;
            // 
            // FrmGenerateTotalLabelFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 714);
            this.Controls.Add(this.btnToCreate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctWeight);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmGenerateTotalLabelFormat";
            this.Text = "Selecteer een formaat";
            this.Load += new System.EventHandler(this.frmGenerateLabelFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLabelFormatCode;
        private System.Windows.Forms.ComboBox cmbTargetFormat;
        private System.Windows.Forms.PictureBox pctWeight;
        private System.Windows.Forms.CheckBox chkBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGewicht;
        private System.Windows.Forms.CheckBox chkVerkoper;
        private System.Windows.Forms.CheckBox chkInpakDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAfmetingen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkAantal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstTypeToestel;
        private System.Windows.Forms.Button btnToCreate;
    }
}