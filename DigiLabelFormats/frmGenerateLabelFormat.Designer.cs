namespace DigiLabelFormats
{
    partial class FrmGenerateLabelFormat
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLabelFormatCode = new System.Windows.Forms.TextBox();
            this.cmbTargetFormat = new System.Windows.Forms.ComboBox();
            this.pctWeight = new System.Windows.Forms.PictureBox();
            this.pctPieces = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAfmetingen = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTypeToestel = new System.Windows.Forms.ListBox();
            this.btnToCreate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lstBasicFields = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lstExtendedFields = new System.Windows.Forms.ListBox();
            this.Traceability = new System.Windows.Forms.GroupBox();
            this.lstTraceability = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstShoplogos = new System.Windows.Forms.ListBox();
            this.grpTemperatures = new System.Windows.Forms.GroupBox();
            this.lstTemperatures = new System.Windows.Forms.ListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lstTextFields = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstInfotag = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.Traceability.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTemperatures.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(308, 480);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 50);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtLabelFormatCode
            // 
            this.txtLabelFormatCode.Enabled = false;
            this.txtLabelFormatCode.Location = new System.Drawing.Point(6, 14);
            this.txtLabelFormatCode.Name = "txtLabelFormatCode";
            this.txtLabelFormatCode.Size = new System.Drawing.Size(493, 22);
            this.txtLabelFormatCode.TabIndex = 6;
            // 
            // cmbTargetFormat
            // 
            this.cmbTargetFormat.FormattingEnabled = true;
            this.cmbTargetFormat.Location = new System.Drawing.Point(20, 16);
            this.cmbTargetFormat.Name = "cmbTargetFormat";
            this.cmbTargetFormat.Size = new System.Drawing.Size(99, 22);
            this.cmbTargetFormat.TabIndex = 8;
            this.cmbTargetFormat.SelectedIndexChanged += new System.EventHandler(this.cmbTargetFormat_SelectedIndexChanged);
            // 
            // pctWeight
            // 
            this.pctWeight.BackColor = System.Drawing.SystemColors.Control;
            this.pctWeight.Location = new System.Drawing.Point(664, 16);
            this.pctWeight.Name = "pctWeight";
            this.pctWeight.Size = new System.Drawing.Size(336, 483);
            this.pctWeight.TabIndex = 10;
            this.pctWeight.TabStop = false;
            this.pctWeight.Click += new System.EventHandler(this.pctWeight_Click);
            // 
            // pctPieces
            // 
            this.pctPieces.BackColor = System.Drawing.SystemColors.Control;
            this.pctPieces.Location = new System.Drawing.Point(1006, 16);
            this.pctPieces.Name = "pctPieces";
            this.pctPieces.Size = new System.Drawing.Size(363, 483);
            this.pctPieces.TabIndex = 11;
            this.pctPieces.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAfmetingen);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 285);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select size";
            // 
            // lstAfmetingen
            // 
            this.lstAfmetingen.FormattingEnabled = true;
            this.lstAfmetingen.ItemHeight = 14;
            this.lstAfmetingen.Location = new System.Drawing.Point(6, 19);
            this.lstAfmetingen.Name = "lstAfmetingen";
            this.lstAfmetingen.Size = new System.Drawing.Size(123, 256);
            this.lstAfmetingen.TabIndex = 0;
            this.lstAfmetingen.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            this.lstAfmetingen.DoubleClick += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(153, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 50);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTargetFormat);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 44);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select target format";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabelFormatCode);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(153, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 44);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Format Code";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(12, 480);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(137, 50);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Select from list";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTypeToestel);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 106);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select device";
            // 
            // lstTypeToestel
            // 
            this.lstTypeToestel.FormattingEnabled = true;
            this.lstTypeToestel.ItemHeight = 14;
            this.lstTypeToestel.Location = new System.Drawing.Point(6, 21);
            this.lstTypeToestel.Name = "lstTypeToestel";
            this.lstTypeToestel.Size = new System.Drawing.Size(123, 74);
            this.lstTypeToestel.TabIndex = 0;
            this.lstTypeToestel.SelectedIndexChanged += new System.EventHandler(this.ChangeDevice);
            // 
            // btnToCreate
            // 
            this.btnToCreate.BackColor = System.Drawing.Color.LightGreen;
            this.btnToCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnToCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCreate.Location = new System.Drawing.Point(493, 480);
            this.btnToCreate.Name = "btnToCreate";
            this.btnToCreate.Size = new System.Drawing.Size(165, 50);
            this.btnToCreate.TabIndex = 31;
            this.btnToCreate.Text = "To Create";
            this.btnToCreate.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(592, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(22, 31);
            this.lblError.TabIndex = 32;
            this.lblError.Text = " ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lstBasicFields);
            this.groupBox11.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(155, 8);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(250, 123);
            this.groupBox11.TabIndex = 25;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Basic fields";
            // 
            // lstBasicFields
            // 
            this.lstBasicFields.FormattingEnabled = true;
            this.lstBasicFields.ItemHeight = 14;
            this.lstBasicFields.Location = new System.Drawing.Point(6, 17);
            this.lstBasicFields.Name = "lstBasicFields";
            this.lstBasicFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBasicFields.Size = new System.Drawing.Size(238, 102);
            this.lstBasicFields.TabIndex = 0;
            this.lstBasicFields.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lstExtendedFields);
            this.groupBox12.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(408, 8);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(250, 141);
            this.groupBox12.TabIndex = 26;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Extended fields";
            // 
            // lstExtendedFields
            // 
            this.lstExtendedFields.FormattingEnabled = true;
            this.lstExtendedFields.ItemHeight = 14;
            this.lstExtendedFields.Location = new System.Drawing.Point(6, 17);
            this.lstExtendedFields.Name = "lstExtendedFields";
            this.lstExtendedFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstExtendedFields.Size = new System.Drawing.Size(238, 116);
            this.lstExtendedFields.TabIndex = 0;
            this.lstExtendedFields.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // Traceability
            // 
            this.Traceability.Controls.Add(this.lstTraceability);
            this.Traceability.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traceability.Location = new System.Drawing.Point(155, 137);
            this.Traceability.Name = "Traceability";
            this.Traceability.Size = new System.Drawing.Size(250, 118);
            this.Traceability.TabIndex = 27;
            this.Traceability.TabStop = false;
            this.Traceability.Text = "Traceability";
            // 
            // lstTraceability
            // 
            this.lstTraceability.FormattingEnabled = true;
            this.lstTraceability.ItemHeight = 14;
            this.lstTraceability.Location = new System.Drawing.Point(6, 21);
            this.lstTraceability.Name = "lstTraceability";
            this.lstTraceability.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTraceability.Size = new System.Drawing.Size(238, 88);
            this.lstTraceability.TabIndex = 0;
            this.lstTraceability.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstShoplogos);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 83);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop logos";
            // 
            // lstShoplogos
            // 
            this.lstShoplogos.FormattingEnabled = true;
            this.lstShoplogos.ItemHeight = 14;
            this.lstShoplogos.Location = new System.Drawing.Point(6, 21);
            this.lstShoplogos.Name = "lstShoplogos";
            this.lstShoplogos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstShoplogos.Size = new System.Drawing.Size(238, 46);
            this.lstShoplogos.TabIndex = 0;
            this.lstShoplogos.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // grpTemperatures
            // 
            this.grpTemperatures.Controls.Add(this.lstTemperatures);
            this.grpTemperatures.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTemperatures.Location = new System.Drawing.Point(408, 155);
            this.grpTemperatures.Name = "grpTemperatures";
            this.grpTemperatures.Size = new System.Drawing.Size(250, 110);
            this.grpTemperatures.TabIndex = 26;
            this.grpTemperatures.TabStop = false;
            this.grpTemperatures.Text = "Temperatures";
            // 
            // lstTemperatures
            // 
            this.lstTemperatures.FormattingEnabled = true;
            this.lstTemperatures.ItemHeight = 14;
            this.lstTemperatures.Location = new System.Drawing.Point(6, 21);
            this.lstTemperatures.Name = "lstTemperatures";
            this.lstTemperatures.Size = new System.Drawing.Size(238, 74);
            this.lstTemperatures.TabIndex = 0;
            this.lstTemperatures.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lstTextFields);
            this.groupBox9.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(408, 268);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(250, 142);
            this.groupBox9.TabIndex = 27;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Text fields";
            // 
            // lstTextFields
            // 
            this.lstTextFields.FormattingEnabled = true;
            this.lstTextFields.ItemHeight = 14;
            this.lstTextFields.Location = new System.Drawing.Point(6, 21);
            this.lstTextFields.Name = "lstTextFields";
            this.lstTextFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTextFields.Size = new System.Drawing.Size(238, 102);
            this.lstTextFields.TabIndex = 0;
            this.lstTextFields.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstInfotag);
            this.groupBox6.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(155, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 78);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Infotag fields";
            // 
            // lstInfotag
            // 
            this.lstInfotag.FormattingEnabled = true;
            this.lstInfotag.ItemHeight = 14;
            this.lstInfotag.Location = new System.Drawing.Point(6, 21);
            this.lstInfotag.Name = "lstInfotag";
            this.lstInfotag.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstInfotag.Size = new System.Drawing.Size(240, 46);
            this.lstInfotag.TabIndex = 0;
            this.lstInfotag.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // FrmGenerateLabelFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 553);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.grpTemperatures);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Traceability);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnToCreate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pctPieces);
            this.Controls.Add(this.pctWeight);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Name = "FrmGenerateLabelFormat";
            this.Text = "Select a labelformat";
            this.Load += new System.EventHandler(this.frmGenerateLabelFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.Traceability.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpTemperatures.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLabelFormatCode;
        private System.Windows.Forms.ComboBox cmbTargetFormat;
        private System.Windows.Forms.PictureBox pctWeight;
        private System.Windows.Forms.PictureBox pctPieces;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAfmetingen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstTypeToestel;
        private System.Windows.Forms.Button btnToCreate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lstBasicFields;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ListBox lstExtendedFields;
        private System.Windows.Forms.GroupBox Traceability;
        private System.Windows.Forms.ListBox lstTraceability;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstShoplogos;
        private System.Windows.Forms.GroupBox grpTemperatures;
        private System.Windows.Forms.ListBox lstTemperatures;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox lstTextFields;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstInfotag;
    }
}