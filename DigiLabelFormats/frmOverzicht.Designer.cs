namespace DigiLabelFormats
{
    partial class FrmOverzicht
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
            this.txtOverzicht = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtOverzicht
            // 
            this.txtOverzicht.Location = new System.Drawing.Point(16, 7);
            this.txtOverzicht.Margin = new System.Windows.Forms.Padding(4);
            this.txtOverzicht.Name = "txtOverzicht";
            this.txtOverzicht.Size = new System.Drawing.Size(681, 403);
            this.txtOverzicht.TabIndex = 0;
            this.txtOverzicht.Text = "";
            // 
            // FrmOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 426);
            this.Controls.Add(this.txtOverzicht);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOverzicht";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.frmOverzicht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOverzicht;
    }
}