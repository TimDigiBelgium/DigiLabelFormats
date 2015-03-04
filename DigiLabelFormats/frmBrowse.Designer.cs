namespace DigiLabelFormats
{
    partial class FrmBrowse
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
            this.lstBrowse = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctExample = new System.Windows.Forms.PictureBox();
            this.lblSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctExample)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBrowse
            // 
            this.lstBrowse.FormattingEnabled = true;
            this.lstBrowse.ItemHeight = 16;
            this.lstBrowse.Location = new System.Drawing.Point(16, 15);
            this.lstBrowse.Name = "lstBrowse";
            this.lstBrowse.Size = new System.Drawing.Size(382, 420);
            this.lstBrowse.TabIndex = 0;
            this.lstBrowse.SelectedIndexChanged += new System.EventHandler(this.lstBrowse_SelectedIndexChanged);
            this.lstBrowse.DoubleClick += new System.EventHandler(this.doubleclick);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightGreen;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(208, 437);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(192, 61);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(16, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 61);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pctExample
            // 
            this.pctExample.Location = new System.Drawing.Point(776, 15);
            this.pctExample.Name = "pctExample";
            this.pctExample.Size = new System.Drawing.Size(349, 483);
            this.pctExample.TabIndex = 3;
            this.pctExample.TabStop = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(400, 15);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 16);
            this.lblSummary.TabIndex = 4;
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 499);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.pctExample);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstBrowse);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmBrowse";
            this.Text = "List with existing formats";
            this.Load += new System.EventHandler(this.frmBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBrowse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pctExample;
        private System.Windows.Forms.Label lblSummary;
    }
}