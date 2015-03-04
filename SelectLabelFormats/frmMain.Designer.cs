namespace SelectLabelFormats
{
    partial class frmMain
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
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lstLabelFormats = new System.Windows.Forms.ListBox();
            this.btnOpenInLabelDesigner = new System.Windows.Forms.Button();
            this.btnSaveAsWindigi = new System.Windows.Forms.Button();
            this.saveAsBackOffice = new System.Windows.Forms.SaveFileDialog();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.lstSizes = new System.Windows.Forms.ListBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lstMain = new System.Windows.Forms.ListBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.lstTheme = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveConverter = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(301, 9);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(70, 13);
            this.lblDeviceType.TabIndex = 0;
            this.lblDeviceType.Text = "Device type :";
            // 
            // lstLabelFormats
            // 
            this.lstLabelFormats.FormattingEnabled = true;
            this.lstLabelFormats.Location = new System.Drawing.Point(12, 152);
            this.lstLabelFormats.Name = "lstLabelFormats";
            this.lstLabelFormats.Size = new System.Drawing.Size(395, 134);
            this.lstLabelFormats.TabIndex = 2;
            this.lstLabelFormats.SelectedIndexChanged += new System.EventHandler(this.lstLabelFormats_SelectedIndexChanged);
            // 
            // btnOpenInLabelDesigner
            // 
            this.btnOpenInLabelDesigner.Location = new System.Drawing.Point(413, 152);
            this.btnOpenInLabelDesigner.Name = "btnOpenInLabelDesigner";
            this.btnOpenInLabelDesigner.Size = new System.Drawing.Size(177, 61);
            this.btnOpenInLabelDesigner.TabIndex = 3;
            this.btnOpenInLabelDesigner.Text = "Open in LabelDesigner";
            this.btnOpenInLabelDesigner.UseVisualStyleBackColor = true;
            this.btnOpenInLabelDesigner.Click += new System.EventHandler(this.btnOpenInLabelDesigner_Click);
            // 
            // btnSaveAsWindigi
            // 
            this.btnSaveAsWindigi.Location = new System.Drawing.Point(413, 225);
            this.btnSaveAsWindigi.Name = "btnSaveAsWindigi";
            this.btnSaveAsWindigi.Size = new System.Drawing.Size(177, 61);
            this.btnSaveAsWindigi.TabIndex = 4;
            this.btnSaveAsWindigi.Text = "Save as backoffice file";
            this.btnSaveAsWindigi.UseVisualStyleBackColor = true;
            this.btnSaveAsWindigi.Click += new System.EventHandler(this.btnSaveAsWindigi_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(304, 25);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(140, 95);
            this.lstDevices.TabIndex = 5;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // lstSizes
            // 
            this.lstSizes.FormattingEnabled = true;
            this.lstSizes.Location = new System.Drawing.Point(450, 25);
            this.lstSizes.Name = "lstSizes";
            this.lstSizes.Size = new System.Drawing.Size(140, 95);
            this.lstSizes.TabIndex = 6;
            this.lstSizes.SelectedIndexChanged += new System.EventHandler(this.lstSizes_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(447, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(62, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Label Size :";
            // 
            // lstMain
            // 
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Location = new System.Drawing.Point(158, 25);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(140, 95);
            this.lstMain.TabIndex = 8;
            this.lstMain.SelectedIndexChanged += new System.EventHandler(this.lstMain_SelectedIndexChanged);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(155, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(69, 13);
            this.lblFolder.TabIndex = 9;
            this.lblFolder.Text = "Select folder:";
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(12, 134);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(94, 13);
            this.lblSelectItem.TabIndex = 10;
            this.lblSelectItem.Text = "Select labelformat:";
            // 
            // lstTheme
            // 
            this.lstTheme.FormattingEnabled = true;
            this.lstTheme.Location = new System.Drawing.Point(12, 25);
            this.lstTheme.Name = "lstTheme";
            this.lstTheme.Size = new System.Drawing.Size(140, 95);
            this.lstTheme.TabIndex = 11;
            this.lstTheme.SelectedIndexChanged += new System.EventHandler(this.lstTheme_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select theme:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTheme);
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lstSizes);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnSaveAsWindigi);
            this.Controls.Add(this.btnOpenInLabelDesigner);
            this.Controls.Add(this.lstLabelFormats);
            this.Controls.Add(this.lblDeviceType);
            this.Name = "frmMain";
            this.Text = "Digi Production Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ListBox lstLabelFormats;
        private System.Windows.Forms.Button btnOpenInLabelDesigner;
        private System.Windows.Forms.Button btnSaveAsWindigi;
        private System.Windows.Forms.SaveFileDialog saveAsBackOffice;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.ListBox lstSizes;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.ListBox lstTheme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveConverter;
    }
}

