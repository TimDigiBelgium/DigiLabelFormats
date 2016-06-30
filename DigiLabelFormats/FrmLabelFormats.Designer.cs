namespace DigiLabelFormats
{
    partial class FrmLabelFormats
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
            this.lstLabelFormats = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.saveFormatsDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFormatsDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenExcelList = new System.Windows.Forms.Button();
            this.btnSalesMenLabel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLanguage = new System.Windows.Forms.ListBox();
            this.btnTotalLabel = new System.Windows.Forms.Button();
            this.btnDoelFormaatWijzigen = new System.Windows.Forms.Button();
            this.saveLabelDesignerFormatsDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnImportFromLabelDesigner = new System.Windows.Forms.Button();
            this.btnOpenInLabelDesigner = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSaveFormatFile = new System.Windows.Forms.Button();
            this.btnOpenFormatFile = new System.Windows.Forms.Button();
            this.btnSendWithDigiDriver = new System.Windows.Forms.Button();
            this.btnConfigureDigiDriver = new System.Windows.Forms.Button();
            this.openExcelList = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLabelFormats
            // 
            this.lstLabelFormats.FormattingEnabled = true;
            this.lstLabelFormats.ItemHeight = 14;
            this.lstLabelFormats.Location = new System.Drawing.Point(12, 19);
            this.lstLabelFormats.Name = "lstLabelFormats";
            this.lstLabelFormats.Size = new System.Drawing.Size(413, 270);
            this.lstLabelFormats.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.LightGreen;
            this.btnToevoegen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(443, 19);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(164, 34);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "ADD ARTICLE LABEL";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.BackColor = System.Drawing.Color.LightSalmon;
            this.btnWissen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWissen.Location = new System.Drawing.Point(442, 218);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(164, 34);
            this.btnWissen.TabIndex = 4;
            this.btnWissen.Text = "DELETE FORMAT";
            this.btnWissen.UseVisualStyleBackColor = false;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "DELETE ALL FORMATS";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFormatsDialog
            // 
            this.openFormatsDialog.FileName = "freeformats.dat";
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.BackColor = System.Drawing.Color.Beige;
            this.btnOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverzicht.Location = new System.Drawing.Point(624, 19);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(160, 94);
            this.btnOverzicht.TabIndex = 9;
            this.btnOverzicht.Text = "Export Summary";
            this.btnOverzicht.UseVisualStyleBackColor = false;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenExcelList);
            this.groupBox1.Controls.Add(this.btnSalesMenLabel);
            this.groupBox1.Controls.Add(this.btnOverzicht);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnTotalLabel);
            this.groupBox1.Controls.Add(this.btnDoelFormaatWijzigen);
            this.groupBox1.Controls.Add(this.lstLabelFormats);
            this.groupBox1.Controls.Add(this.btnToevoegen);
            this.groupBox1.Controls.Add(this.btnWissen);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 309);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composition format file";
            // 
            // btnOpenExcelList
            // 
            this.btnOpenExcelList.BackColor = System.Drawing.Color.Beige;
            this.btnOpenExcelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenExcelList.Location = new System.Drawing.Point(624, 121);
            this.btnOpenExcelList.Name = "btnOpenExcelList";
            this.btnOpenExcelList.Size = new System.Drawing.Size(160, 89);
            this.btnOpenExcelList.TabIndex = 17;
            this.btnOpenExcelList.Text = "Import Summary";
            this.btnOpenExcelList.UseVisualStyleBackColor = false;
            this.btnOpenExcelList.Click += new System.EventHandler(this.btnOpenExcelList_Click);
            // 
            // btnSalesMenLabel
            // 
            this.btnSalesMenLabel.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalesMenLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesMenLabel.Location = new System.Drawing.Point(442, 139);
            this.btnSalesMenLabel.Name = "btnSalesMenLabel";
            this.btnSalesMenLabel.Size = new System.Drawing.Size(164, 34);
            this.btnSalesMenLabel.TabIndex = 13;
            this.btnSalesMenLabel.Text = "ADD SALESMEN LABEL";
            this.btnSalesMenLabel.UseVisualStyleBackColor = false;
            this.btnSalesMenLabel.Click += new System.EventHandler(this.btnSalesMenLabel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD CUSTOMER LABEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLanguage);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(624, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 88);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text language";
            // 
            // lstLanguage
            // 
            this.lstLanguage.FormattingEnabled = true;
            this.lstLanguage.ItemHeight = 14;
            this.lstLanguage.Location = new System.Drawing.Point(10, 21);
            this.lstLanguage.Name = "lstLanguage";
            this.lstLanguage.Size = new System.Drawing.Size(144, 60);
            this.lstLanguage.TabIndex = 0;
            // 
            // btnTotalLabel
            // 
            this.btnTotalLabel.BackColor = System.Drawing.Color.LightGreen;
            this.btnTotalLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalLabel.Location = new System.Drawing.Point(443, 59);
            this.btnTotalLabel.Name = "btnTotalLabel";
            this.btnTotalLabel.Size = new System.Drawing.Size(164, 34);
            this.btnTotalLabel.TabIndex = 11;
            this.btnTotalLabel.Text = "ADD TOTAL LABEL";
            this.btnTotalLabel.UseVisualStyleBackColor = false;
            this.btnTotalLabel.Click += new System.EventHandler(this.btnTotalLabel_Click);
            // 
            // btnDoelFormaatWijzigen
            // 
            this.btnDoelFormaatWijzigen.BackColor = System.Drawing.Color.LightBlue;
            this.btnDoelFormaatWijzigen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoelFormaatWijzigen.Location = new System.Drawing.Point(442, 178);
            this.btnDoelFormaatWijzigen.Name = "btnDoelFormaatWijzigen";
            this.btnDoelFormaatWijzigen.Size = new System.Drawing.Size(164, 34);
            this.btnDoelFormaatWijzigen.TabIndex = 10;
            this.btnDoelFormaatWijzigen.Text = "CHANGE FORMAT#";
            this.btnDoelFormaatWijzigen.UseVisualStyleBackColor = false;
            this.btnDoelFormaatWijzigen.Click += new System.EventHandler(this.btnDoelFormaatWijzigen_Click);
            // 
            // saveLabelDesignerFormatsDialog
            // 
            this.saveLabelDesignerFormatsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveLabelDesignerFormatsDialog_FileOk);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnImportFromLabelDesigner);
            this.groupBox4.Controls.Add(this.btnOpenInLabelDesigner);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 108);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LabelDesigner";
            // 
            // btnImportFromLabelDesigner
            // 
            this.btnImportFromLabelDesigner.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnImportFromLabelDesigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFromLabelDesigner.Location = new System.Drawing.Point(136, 19);
            this.btnImportFromLabelDesigner.Name = "btnImportFromLabelDesigner";
            this.btnImportFromLabelDesigner.Size = new System.Drawing.Size(124, 75);
            this.btnImportFromLabelDesigner.TabIndex = 18;
            this.btnImportFromLabelDesigner.Text = "Import From LabelDesigner";
            this.btnImportFromLabelDesigner.UseVisualStyleBackColor = false;
            this.btnImportFromLabelDesigner.Click += new System.EventHandler(this.btnImportFromLabelDesigner_Click);
            // 
            // btnOpenInLabelDesigner
            // 
            this.btnOpenInLabelDesigner.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOpenInLabelDesigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInLabelDesigner.Location = new System.Drawing.Point(6, 19);
            this.btnOpenInLabelDesigner.Name = "btnOpenInLabelDesigner";
            this.btnOpenInLabelDesigner.Size = new System.Drawing.Size(124, 75);
            this.btnOpenInLabelDesigner.TabIndex = 17;
            this.btnOpenInLabelDesigner.Text = "Open formats in LabelDesigner";
            this.btnOpenInLabelDesigner.UseVisualStyleBackColor = false;
            this.btnOpenInLabelDesigner.Click += new System.EventHandler(this.btnOpenInLabelDesigner_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSaveFormatFile);
            this.groupBox5.Controls.Add(this.btnOpenFormatFile);
            this.groupBox5.Controls.Add(this.btnSendWithDigiDriver);
            this.groupBox5.Controls.Add(this.btnConfigureDigiDriver);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(280, 327);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 108);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Digidriver/Windigi";
            // 
            // btnSaveFormatFile
            // 
            this.btnSaveFormatFile.BackColor = System.Drawing.Color.Peru;
            this.btnSaveFormatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFormatFile.Location = new System.Drawing.Point(396, 19);
            this.btnSaveFormatFile.Name = "btnSaveFormatFile";
            this.btnSaveFormatFile.Size = new System.Drawing.Size(124, 75);
            this.btnSaveFormatFile.TabIndex = 20;
            this.btnSaveFormatFile.Text = "Save format file";
            this.btnSaveFormatFile.UseVisualStyleBackColor = false;
            this.btnSaveFormatFile.Click += new System.EventHandler(this.btnSaveFormatFile_Click);
            // 
            // btnOpenFormatFile
            // 
            this.btnOpenFormatFile.BackColor = System.Drawing.Color.Peru;
            this.btnOpenFormatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormatFile.Location = new System.Drawing.Point(266, 19);
            this.btnOpenFormatFile.Name = "btnOpenFormatFile";
            this.btnOpenFormatFile.Size = new System.Drawing.Size(124, 75);
            this.btnOpenFormatFile.TabIndex = 19;
            this.btnOpenFormatFile.Text = "Open format file";
            this.btnOpenFormatFile.UseVisualStyleBackColor = false;
            this.btnOpenFormatFile.Click += new System.EventHandler(this.btnOpenFormatFile_Click);
            // 
            // btnSendWithDigiDriver
            // 
            this.btnSendWithDigiDriver.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSendWithDigiDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendWithDigiDriver.Location = new System.Drawing.Point(136, 19);
            this.btnSendWithDigiDriver.Name = "btnSendWithDigiDriver";
            this.btnSendWithDigiDriver.Size = new System.Drawing.Size(124, 75);
            this.btnSendWithDigiDriver.TabIndex = 18;
            this.btnSendWithDigiDriver.Text = "Send with DigiDriver";
            this.btnSendWithDigiDriver.UseVisualStyleBackColor = false;
            this.btnSendWithDigiDriver.Click += new System.EventHandler(this.btnSendWithDigiDriver_Click);
            // 
            // btnConfigureDigiDriver
            // 
            this.btnConfigureDigiDriver.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConfigureDigiDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureDigiDriver.Location = new System.Drawing.Point(6, 19);
            this.btnConfigureDigiDriver.Name = "btnConfigureDigiDriver";
            this.btnConfigureDigiDriver.Size = new System.Drawing.Size(124, 75);
            this.btnConfigureDigiDriver.TabIndex = 17;
            this.btnConfigureDigiDriver.Text = "Configure DigiDriver";
            this.btnConfigureDigiDriver.UseVisualStyleBackColor = false;
            this.btnConfigureDigiDriver.Click += new System.EventHandler(this.btnConfigureDigiDriver_Click);
            // 
            // openExcelList
            // 
            this.openExcelList.FileName = "openFileDialog1";
            // 
            // FrmLabelFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 445);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLabelFormats";
            this.Text = "DigiLabelFormats by Tim Quirynen - version 30-06-2016";
            this.Load += new System.EventHandler(this.frmLabelFormats_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLabelFormats;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SaveFileDialog saveFormatsDialog;
        private System.Windows.Forms.OpenFileDialog openFormatsDialog;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveLabelDesignerFormatsDialog;
        private System.Windows.Forms.Button btnDoelFormaatWijzigen;
        private System.Windows.Forms.Button btnTotalLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOpenInLabelDesigner;
        private System.Windows.Forms.Button btnImportFromLabelDesigner;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSendWithDigiDriver;
        private System.Windows.Forms.Button btnConfigureDigiDriver;
        private System.Windows.Forms.ListBox lstLanguage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenExcelList;
        private System.Windows.Forms.OpenFileDialog openExcelList;
        private System.Windows.Forms.Button btnSalesMenLabel;
        private System.Windows.Forms.Button btnSaveFormatFile;
        private System.Windows.Forms.Button btnOpenFormatFile;

    }
}

