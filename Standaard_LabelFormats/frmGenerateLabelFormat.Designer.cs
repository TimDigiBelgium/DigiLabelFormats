namespace Standaard_LabelFormats
{
    partial class frmGenerateLabelFormat
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioTrace = new System.Windows.Forms.RadioButton();
            this.radioKip = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLabelFormatCode = new System.Windows.Forms.TextBox();
            this.cmbTargetFormat = new System.Windows.Forms.ComboBox();
            this.pctWeight = new System.Windows.Forms.PictureBox();
            this.pctPieces = new System.Windows.Forms.PictureBox();
            this.grpVlees = new System.Windows.Forms.GroupBox();
            this.radioGeenVlees = new System.Windows.Forms.RadioButton();
            this.grpBewTemp = new System.Windows.Forms.GroupBox();
            this.radioGeenTemp = new System.Windows.Forms.RadioButton();
            this.radioTempVast = new System.Windows.Forms.RadioButton();
            this.radioTempVar = new System.Windows.Forms.RadioButton();
            this.chkBarcode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBewaarAdvies = new System.Windows.Forms.CheckBox();
            this.chkTGT = new System.Windows.Forms.CheckBox();
            this.chkInpakDatum = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAfmetingen = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).BeginInit();
            this.grpVlees.SuspendLayout();
            this.grpBewTemp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecteer eventueel een of meerdere van volgende variaties :";
            // 
            // radioTrace
            // 
            this.radioTrace.AutoSize = true;
            this.radioTrace.Location = new System.Drawing.Point(85, 19);
            this.radioTrace.Name = "radioTrace";
            this.radioTrace.Size = new System.Drawing.Size(103, 17);
            this.radioTrace.TabIndex = 3;
            this.radioTrace.TabStop = true;
            this.radioTrace.Text = "Traceerbaarheid";
            this.radioTrace.UseVisualStyleBackColor = true;
            this.radioTrace.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // radioKip
            // 
            this.radioKip.AutoSize = true;
            this.radioKip.Location = new System.Drawing.Point(212, 19);
            this.radioKip.Name = "radioKip";
            this.radioKip.Size = new System.Drawing.Size(60, 17);
            this.radioKip.TabIndex = 4;
            this.radioKip.TabStop = true;
            this.radioKip.Text = "Kiplogo";
            this.radioKip.UseVisualStyleBackColor = true;
            this.radioKip.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(437, 252);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 49);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLabelFormatCode
            // 
            this.txtLabelFormatCode.Enabled = false;
            this.txtLabelFormatCode.Location = new System.Drawing.Point(97, 15);
            this.txtLabelFormatCode.Name = "txtLabelFormatCode";
            this.txtLabelFormatCode.Size = new System.Drawing.Size(117, 20);
            this.txtLabelFormatCode.TabIndex = 6;
            // 
            // cmbTargetFormat
            // 
            this.cmbTargetFormat.FormattingEnabled = true;
            this.cmbTargetFormat.Location = new System.Drawing.Point(97, 17);
            this.cmbTargetFormat.Name = "cmbTargetFormat";
            this.cmbTargetFormat.Size = new System.Drawing.Size(117, 21);
            this.cmbTargetFormat.TabIndex = 8;
            // 
            // pctWeight
            // 
            this.pctWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctWeight.Location = new System.Drawing.Point(19, 330);
            this.pctWeight.Name = "pctWeight";
            this.pctWeight.Size = new System.Drawing.Size(244, 200);
            this.pctWeight.TabIndex = 10;
            this.pctWeight.TabStop = false;
            // 
            // pctPieces
            // 
            this.pctPieces.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctPieces.Location = new System.Drawing.Point(308, 330);
            this.pctPieces.Name = "pctPieces";
            this.pctPieces.Size = new System.Drawing.Size(244, 200);
            this.pctPieces.TabIndex = 11;
            this.pctPieces.TabStop = false;
            // 
            // grpVlees
            // 
            this.grpVlees.Controls.Add(this.radioGeenVlees);
            this.grpVlees.Controls.Add(this.radioTrace);
            this.grpVlees.Controls.Add(this.radioKip);
            this.grpVlees.Location = new System.Drawing.Point(273, 41);
            this.grpVlees.Name = "grpVlees";
            this.grpVlees.Size = new System.Drawing.Size(295, 48);
            this.grpVlees.TabIndex = 12;
            this.grpVlees.TabStop = false;
            this.grpVlees.Text = "Vlees Info";
            // 
            // radioGeenVlees
            // 
            this.radioGeenVlees.AutoSize = true;
            this.radioGeenVlees.Location = new System.Drawing.Point(13, 19);
            this.radioGeenVlees.Name = "radioGeenVlees";
            this.radioGeenVlees.Size = new System.Drawing.Size(51, 17);
            this.radioGeenVlees.TabIndex = 5;
            this.radioGeenVlees.TabStop = true;
            this.radioGeenVlees.Text = "Geen";
            this.radioGeenVlees.UseVisualStyleBackColor = true;
            this.radioGeenVlees.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // grpBewTemp
            // 
            this.grpBewTemp.Controls.Add(this.radioGeenTemp);
            this.grpBewTemp.Controls.Add(this.radioTempVast);
            this.grpBewTemp.Controls.Add(this.radioTempVar);
            this.grpBewTemp.Location = new System.Drawing.Point(273, 95);
            this.grpBewTemp.Name = "grpBewTemp";
            this.grpBewTemp.Size = new System.Drawing.Size(295, 48);
            this.grpBewTemp.TabIndex = 13;
            this.grpBewTemp.TabStop = false;
            this.grpBewTemp.Text = "Bewaartemperatuur";
            // 
            // radioGeenTemp
            // 
            this.radioGeenTemp.AutoSize = true;
            this.radioGeenTemp.Location = new System.Drawing.Point(13, 19);
            this.radioGeenTemp.Name = "radioGeenTemp";
            this.radioGeenTemp.Size = new System.Drawing.Size(51, 17);
            this.radioGeenTemp.TabIndex = 6;
            this.radioGeenTemp.TabStop = true;
            this.radioGeenTemp.Text = "Geen";
            this.radioGeenTemp.UseVisualStyleBackColor = true;
            this.radioGeenTemp.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // radioTempVast
            // 
            this.radioTempVast.AutoSize = true;
            this.radioTempVast.Location = new System.Drawing.Point(85, 19);
            this.radioTempVast.Name = "radioTempVast";
            this.radioTempVast.Size = new System.Drawing.Size(46, 17);
            this.radioTempVast.TabIndex = 3;
            this.radioTempVast.TabStop = true;
            this.radioTempVast.Text = "Vast";
            this.radioTempVast.UseVisualStyleBackColor = true;
            this.radioTempVast.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // radioTempVar
            // 
            this.radioTempVar.AutoSize = true;
            this.radioTempVar.Location = new System.Drawing.Point(212, 19);
            this.radioTempVar.Name = "radioTempVar";
            this.radioTempVar.Size = new System.Drawing.Size(63, 17);
            this.radioTempVar.TabIndex = 4;
            this.radioTempVar.TabStop = true;
            this.radioTempVar.Text = "Variabel";
            this.radioTempVar.UseVisualStyleBackColor = true;
            this.radioTempVar.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkBarcode
            // 
            this.chkBarcode.AutoSize = true;
            this.chkBarcode.Location = new System.Drawing.Point(20, 28);
            this.chkBarcode.Name = "chkBarcode";
            this.chkBarcode.Size = new System.Drawing.Size(66, 17);
            this.chkBarcode.TabIndex = 16;
            this.chkBarcode.Text = "Barcode";
            this.chkBarcode.UseVisualStyleBackColor = true;
            this.chkBarcode.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBewaarAdvies);
            this.groupBox1.Controls.Add(this.chkTGT);
            this.groupBox1.Controls.Add(this.chkInpakDatum);
            this.groupBox1.Controls.Add(this.chkBarcode);
            this.groupBox1.Location = new System.Drawing.Point(19, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecteer de basisvelden";
            // 
            // chkBewaarAdvies
            // 
            this.chkBewaarAdvies.AutoSize = true;
            this.chkBewaarAdvies.Location = new System.Drawing.Point(20, 97);
            this.chkBewaarAdvies.Name = "chkBewaarAdvies";
            this.chkBewaarAdvies.Size = new System.Drawing.Size(93, 17);
            this.chkBewaarAdvies.TabIndex = 20;
            this.chkBewaarAdvies.Text = "Bewaaradvies";
            this.chkBewaarAdvies.UseVisualStyleBackColor = true;
            this.chkBewaarAdvies.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkTGT
            // 
            this.chkTGT.AutoSize = true;
            this.chkTGT.Location = new System.Drawing.Point(20, 74);
            this.chkTGT.Name = "chkTGT";
            this.chkTGT.Size = new System.Drawing.Size(80, 17);
            this.chkTGT.TabIndex = 18;
            this.chkTGT.Text = "TGT datum";
            this.chkTGT.UseVisualStyleBackColor = true;
            this.chkTGT.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkInpakDatum
            // 
            this.chkInpakDatum.AutoSize = true;
            this.chkInpakDatum.Location = new System.Drawing.Point(20, 51);
            this.chkInpakDatum.Name = "chkInpakDatum";
            this.chkInpakDatum.Size = new System.Drawing.Size(82, 17);
            this.chkInpakDatum.TabIndex = 17;
            this.chkInpakDatum.Text = "Inpakdatum";
            this.chkInpakDatum.UseVisualStyleBackColor = true;
            this.chkInpakDatum.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAfmetingen);
            this.groupBox2.Location = new System.Drawing.Point(19, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 97);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecteer de afmetingen";
            // 
            // lstAfmetingen
            // 
            this.lstAfmetingen.FormattingEnabled = true;
            this.lstAfmetingen.Location = new System.Drawing.Point(20, 20);
            this.lstAfmetingen.Name = "lstAfmetingen";
            this.lstAfmetingen.Size = new System.Drawing.Size(160, 69);
            this.lstAfmetingen.TabIndex = 0;
            this.lstAfmetingen.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 49);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTargetFormat);
            this.groupBox3.Location = new System.Drawing.Point(273, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 44);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doel Formaat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabelFormatCode);
            this.groupBox4.Location = new System.Drawing.Point(273, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 41);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formaat Code";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(19, 252);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(244, 49);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Selecteer uit lijst";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmGenerateLabelFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 635);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBewTemp);
            this.Controls.Add(this.grpVlees);
            this.Controls.Add(this.pctPieces);
            this.Controls.Add(this.pctWeight);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Name = "frmGenerateLabelFormat";
            this.Text = "Selecteer een formaat";
            this.Load += new System.EventHandler(this.frmGenerateLabelFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).EndInit();
            this.grpVlees.ResumeLayout(false);
            this.grpVlees.PerformLayout();
            this.grpBewTemp.ResumeLayout(false);
            this.grpBewTemp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioTrace;
        private System.Windows.Forms.RadioButton radioKip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLabelFormatCode;
        private System.Windows.Forms.ComboBox cmbTargetFormat;
        private System.Windows.Forms.PictureBox pctWeight;
        private System.Windows.Forms.PictureBox pctPieces;
        private System.Windows.Forms.GroupBox grpVlees;
        private System.Windows.Forms.GroupBox grpBewTemp;
        private System.Windows.Forms.RadioButton radioTempVast;
        private System.Windows.Forms.RadioButton radioTempVar;
        private System.Windows.Forms.RadioButton radioGeenVlees;
        private System.Windows.Forms.RadioButton radioGeenTemp;
        private System.Windows.Forms.CheckBox chkBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBewaarAdvies;
        private System.Windows.Forms.CheckBox chkTGT;
        private System.Windows.Forms.CheckBox chkInpakDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAfmetingen;
        private System.Windows.Forms.Button btnBrowse;
    }
}