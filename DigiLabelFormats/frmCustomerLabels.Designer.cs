namespace DigiLabelFormats
{
    partial class frmCustomerLabels
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTypeToestel = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTargetFormat = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKlanten = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAantal = new System.Windows.Forms.CheckBox();
            this.chkGewicht = new System.Windows.Forms.CheckBox();
            this.chkVerkoper = new System.Windows.Forms.CheckBox();
            this.chkInpakDatum = new System.Windows.Forms.CheckBox();
            this.chkBarcode = new System.Windows.Forms.CheckBox();
            this.pctWeight = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstDevice = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lstDepartment = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lstSize = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLabelFormatCode = new System.Windows.Forms.TextBox();
            this.pctPieces = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTypeToestel);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(27, -138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 60);
            this.groupBox5.TabIndex = 33;
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTargetFormat);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(304, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 46);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Targetformat";
            // 
            // cmbTargetFormat
            // 
            this.cmbTargetFormat.FormattingEnabled = true;
            this.cmbTargetFormat.Location = new System.Drawing.Point(6, 18);
            this.cmbTargetFormat.Name = "cmbTargetFormat";
            this.cmbTargetFormat.Size = new System.Drawing.Size(219, 22);
            this.cmbTargetFormat.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(25, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 67);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKlanten);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 363);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select customer";
            // 
            // lstKlanten
            // 
            this.lstKlanten.FormattingEnabled = true;
            this.lstKlanten.ItemHeight = 14;
            this.lstKlanten.Location = new System.Drawing.Point(20, 19);
            this.lstKlanten.Name = "lstKlanten";
            this.lstKlanten.Size = new System.Drawing.Size(212, 326);
            this.lstKlanten.TabIndex = 0;
            this.lstKlanten.SelectedIndexChanged += new System.EventHandler(this.lstKlanten_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAantal);
            this.groupBox1.Controls.Add(this.chkGewicht);
            this.groupBox1.Controls.Add(this.chkVerkoper);
            this.groupBox1.Controls.Add(this.chkInpakDatum);
            this.groupBox1.Controls.Add(this.chkBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(304, -138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 96);
            this.groupBox1.TabIndex = 27;
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
            // 
            // pctWeight
            // 
            this.pctWeight.BackColor = System.Drawing.SystemColors.Control;
            this.pctWeight.Location = new System.Drawing.Point(573, 22);
            this.pctWeight.Name = "pctWeight";
            this.pctWeight.Size = new System.Drawing.Size(244, 484);
            this.pctWeight.TabIndex = 26;
            this.pctWeight.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(298, 439);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(250, 67);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstDevice);
            this.groupBox6.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(300, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 102);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select device";
            // 
            // lstDevice
            // 
            this.lstDevice.FormattingEnabled = true;
            this.lstDevice.ItemHeight = 14;
            this.lstDevice.Location = new System.Drawing.Point(17, 21);
            this.lstDevice.Name = "lstDevice";
            this.lstDevice.Size = new System.Drawing.Size(212, 60);
            this.lstDevice.TabIndex = 0;
            this.lstDevice.SelectedIndexChanged += new System.EventHandler(this.lstDevice_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lstDepartment);
            this.groupBox7.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(300, 120);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(248, 91);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select department";
            // 
            // lstDepartment
            // 
            this.lstDepartment.FormattingEnabled = true;
            this.lstDepartment.ItemHeight = 14;
            this.lstDepartment.Location = new System.Drawing.Point(17, 21);
            this.lstDepartment.Name = "lstDepartment";
            this.lstDepartment.Size = new System.Drawing.Size(212, 60);
            this.lstDepartment.TabIndex = 0;
            this.lstDepartment.SelectedIndexChanged += new System.EventHandler(this.lstDepartment_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lstSize);
            this.groupBox8.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(300, 217);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(248, 106);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select size";
            // 
            // lstSize
            // 
            this.lstSize.FormattingEnabled = true;
            this.lstSize.ItemHeight = 14;
            this.lstSize.Location = new System.Drawing.Point(17, 21);
            this.lstSize.Name = "lstSize";
            this.lstSize.Size = new System.Drawing.Size(212, 74);
            this.lstSize.TabIndex = 0;
            this.lstSize.SelectedIndexChanged += new System.EventHandler(this.lstSize_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabelFormatCode);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 46);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formatcode";
            // 
            // txtLabelFormatCode
            // 
            this.txtLabelFormatCode.Enabled = false;
            this.txtLabelFormatCode.Location = new System.Drawing.Point(6, 18);
            this.txtLabelFormatCode.Name = "txtLabelFormatCode";
            this.txtLabelFormatCode.Size = new System.Drawing.Size(498, 22);
            this.txtLabelFormatCode.TabIndex = 6;
            // 
            // pctPieces
            // 
            this.pctPieces.BackColor = System.Drawing.SystemColors.Control;
            this.pctPieces.Location = new System.Drawing.Point(835, 22);
            this.pctPieces.Name = "pctPieces";
            this.pctPieces.Size = new System.Drawing.Size(244, 484);
            this.pctPieces.TabIndex = 37;
            this.pctPieces.TabStop = false;
            // 
            // frmCustomerLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 518);
            this.Controls.Add(this.pctPieces);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctWeight);
            this.Controls.Add(this.btnOK);
            this.Name = "frmCustomerLabels";
            this.Text = "Add Customer Label";
            this.Load += new System.EventHandler(this.frmCustomerLabels_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstTypeToestel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTargetFormat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKlanten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAantal;
        private System.Windows.Forms.CheckBox chkGewicht;
        private System.Windows.Forms.CheckBox chkVerkoper;
        private System.Windows.Forms.CheckBox chkInpakDatum;
        private System.Windows.Forms.CheckBox chkBarcode;
        private System.Windows.Forms.PictureBox pctWeight;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstDevice;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lstDepartment;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox lstSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLabelFormatCode;
        private System.Windows.Forms.PictureBox pctPieces;

    }
}