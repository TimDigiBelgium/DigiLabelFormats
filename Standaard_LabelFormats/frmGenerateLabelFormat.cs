using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryLabelFormats;

namespace Standaard_LabelFormats
{
    public partial class frmGenerateLabelFormat : Form
    {
        
        
        public LabelFormat newFormat
        {
            get
            {
                
                return new LabelFormat(cmbTargetFormat.Text,txtLabelFormatCode.Text,"Database");

                
            }
        }
      

        //public string TargetFormat { get; set; }
        


        public frmGenerateLabelFormat(List<string> doelformaten)
        {
            InitializeComponent();
            foreach (string item in doelformaten)
            {
                cmbTargetFormat.Items.Add(item);
            }
           
            cmbTargetFormat.SelectedIndex = 0;
            lstAfmetingen.Items.Add("60x49");
            lstAfmetingen.Items.Add("60x62");
            lstAfmetingen.Items.Add("60x73");
            lstAfmetingen.SelectedIndex = 0;
            radioGeenTemp.Checked = true;
            radioGeenVlees.Checked = true;
            
         
        }

        private void frmGenerateLabelFormat_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
       


        private string GenerateFormat()
        {
            bool somethingChecked;
            somethingChecked = false;
            string formatCode = string.Empty;
            formatCode = lstAfmetingen.Text + "_";
               
                if (chkBarcode.Checked)
                {
                    formatCode = formatCode + "A";
                    somethingChecked = true;
                }
                if (chkInpakDatum.Checked)
                {
                    formatCode = formatCode + "B";
                    somethingChecked = true;
                 }
                if (chkTGT.Checked)
                {
                    formatCode = formatCode + "C";
                    somethingChecked = true;
                 }
                if (chkBewaarAdvies.Checked)
                {
                    formatCode = formatCode + "D";
                    somethingChecked = true;
                }
                                      
           


            if (radioTrace.Checked)
            {
                formatCode = formatCode + "1";
                somethingChecked = true;
            }

            if (radioKip.Checked)
            {
                formatCode = formatCode + "2";
                somethingChecked = true;
            }

            if (radioTempVast.Checked)
            {
                formatCode = formatCode + "3";
                somethingChecked = true;
            }

            if (radioTempVar.Checked)
            {
                formatCode = formatCode + "4";
                somethingChecked = true;
             }


            if (somethingChecked==false)
            {
                formatCode = formatCode + "0";
            }
          
            return formatCode;
        }

        private void ChangeFormatCode(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
            txtLabelFormatCode.Text = GenerateFormat();
            GenerateImages();
        }


        private void AdjustControls()
        {
            string labelformatCode;
            labelformatCode = txtLabelFormatCode.Text;
            if (labelformatCode.Contains("60x49"))
            {
                lstAfmetingen.SelectedIndex = 0;
            }
            if (labelformatCode.Contains("60x62"))
            {
                lstAfmetingen.SelectedIndex = 1;
            }
            if (labelformatCode.Contains("60x73"))
            {
                lstAfmetingen.SelectedIndex = 2;
            }
            
            
            
            
            
            if (labelformatCode.Contains("A"))
            {
                chkBarcode.Checked = true;
            }
            else
            {
                chkBarcode.Checked = false;
            }
            if (labelformatCode.Contains("B"))
            {
                chkInpakDatum.Checked = true;
            }
            else
            {
                chkInpakDatum.Checked = false;
            }
            if (labelformatCode.Contains("C"))
            {
                chkTGT.Checked = true;
            }
            else
            {
                chkTGT.Checked = false;
            }
            if (labelformatCode.Contains("D"))
            {
                chkBewaarAdvies.Checked = true;
            }
            else
            {
                chkBewaarAdvies.Checked = false;
            }
            if (labelformatCode.Substring(6).Contains("1"))
            {
                radioTrace.Checked = true;
            }
            if (labelformatCode.Substring(6).Contains("2"))
            {
                radioKip.Checked = true;
            }
            if (labelformatCode.Substring(6).Contains("1") == false & labelformatCode.Substring(6).Contains("2") == false)
            {
                radioGeenVlees.Checked = true;
            }

            if (labelformatCode.Substring(6).Contains("3"))
            {
                radioTempVast.Checked = true;
            }
            if (labelformatCode.Substring(6).Contains("4"))
            {
                radioTempVar.Checked = true;
            }
            if (labelformatCode.Substring(6).Contains("3") == false & labelformatCode.Substring(6).Contains("4") == false)
            {
                radioGeenTemp.Checked = true;
            }

        }


        private void GenerateImages()
        {
            string labelformatCode;
            labelformatCode = txtLabelFormatCode.Text;
            string ImageFolder;
            ImageFolder =  @"c:\digilabelformats\Database\" + @newFormat.FormaatCode.Substring(0, 5)+ @"\" + @newFormat.FormaatCode;

            //MessageBox.Show(ImageFolder);

            string strImageKg;
            string strImageStk;
            string strImageNotFound;

            

            strImageKg = ImageFolder + @"\" + "kg.png";
            strImageStk = ImageFolder + @"\" + "stk.png";
            strImageNotFound = @"c:\digilabelformats\Database\" + @newFormat.FormaatCode.Substring(0, 5) + @"\NotFound.png";


            int breedte = 244;
            int hoogte = 200;

            if (lstAfmetingen.SelectedIndex==0)
            {
                breedte = 244;
                hoogte = 200;
            }

            if (lstAfmetingen.SelectedIndex == 1)
            {
                breedte = 244;
                hoogte = 250;

            }

            if (lstAfmetingen.SelectedIndex == 2)
            {
                breedte = 244;
                hoogte = 290;

            }
            pctPieces.Width = breedte;
            pctWeight.Width = breedte;
            pctPieces.Height = hoogte;
            pctWeight.Height = hoogte;

            
            if (File.Exists(strImageKg))
            {
                var imageKg = Image.FromFile(strImageKg);
                pctWeight.Image = ScaleImage(imageKg, breedte, hoogte);
            }
            else
            {
                if (File.Exists(strImageNotFound))
                {
                    var imageNotFound = Image.FromFile(strImageNotFound);
                    pctWeight.Image = ScaleImage(imageNotFound, breedte, hoogte);
                }
                else
                {
                    pctWeight.Image = null;
                }
                btnOK.Enabled = false;
            }
            if (File.Exists(strImageStk))
            {
                var imageStk = Image.FromFile(strImageStk);
                pctPieces.Image = ScaleImage(imageStk, breedte, hoogte);
            }
            else
            {
                if (File.Exists(strImageNotFound))
                {
                    var imageNotFound = Image.FromFile(strImageNotFound);
                    pctPieces.Image = ScaleImage(imageNotFound, breedte, hoogte);
                }
                else
                {
                    pctPieces.Image = null;
                }
                btnOK.Enabled = false;
            }
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmBrowse Browse = new frmBrowse(@"c:\DigiLabelFormats\Database\");
            DialogResult result = Browse.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    {

                        if (Browse.newFormat != null)
                        {

                            txtLabelFormatCode.Text = Browse.newFormat;
                            GenerateImages();
                            AdjustControls();

                        }



                        break;
                    }
            }
        }


       

    }
}
