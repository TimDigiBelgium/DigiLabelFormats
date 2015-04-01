namespace DigidriverSend
{
    partial class frmDigidriverSend
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
            this.btnConfigureDigiDriver = new System.Windows.Forms.Button();
            this.btnSendWithDigiDriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openSendFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnConfigureDigiDriver
            // 
            this.btnConfigureDigiDriver.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConfigureDigiDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureDigiDriver.Location = new System.Drawing.Point(142, 12);
            this.btnConfigureDigiDriver.Name = "btnConfigureDigiDriver";
            this.btnConfigureDigiDriver.Size = new System.Drawing.Size(124, 75);
            this.btnConfigureDigiDriver.TabIndex = 18;
            this.btnConfigureDigiDriver.Text = "Configure DigiDriver";
            this.btnConfigureDigiDriver.UseVisualStyleBackColor = false;
            this.btnConfigureDigiDriver.Click += new System.EventHandler(this.btnConfigureDigiDriver_Click);
            // 
            // btnSendWithDigiDriver
            // 
            this.btnSendWithDigiDriver.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSendWithDigiDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendWithDigiDriver.Location = new System.Drawing.Point(272, 12);
            this.btnSendWithDigiDriver.Name = "btnSendWithDigiDriver";
            this.btnSendWithDigiDriver.Size = new System.Drawing.Size(124, 75);
            this.btnSendWithDigiDriver.TabIndex = 19;
            this.btnSendWithDigiDriver.Text = "Send with DigiDriver";
            this.btnSendWithDigiDriver.UseVisualStyleBackColor = false;
            this.btnSendWithDigiDriver.Click += new System.EventHandler(this.btnSendWithDigiDriver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 75);
            this.button1.TabIndex = 20;
            this.button1.Text = "Open digidriver file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openSendFile
            // 
            this.openSendFile.FileName = "openFileDialog1";
            // 
            // frmDigidriverSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 103);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendWithDigiDriver);
            this.Controls.Add(this.btnConfigureDigiDriver);
            this.Name = "frmDigidriverSend";
            this.Text = "Send a file with Digidriver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigureDigiDriver;
        private System.Windows.Forms.Button btnSendWithDigiDriver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openSendFile;
    }
}

