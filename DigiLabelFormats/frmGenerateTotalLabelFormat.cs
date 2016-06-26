using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClassLibraryLabelFormats;
using DigiLabelFormats.Properties;

namespace DigiLabelFormats
{
    public partial class FrmGenerateTotalLabelFormat : Form
    {
       
        public LabelFormat NewFormat
        {
            get
            {

                return new LabelFormat(cmbTargetFormat.Text, txtLabelFormatCode.Text);

                
            }
        }

        public bool sm5500LabelTexts
        {
            get;
            private set;
        }




        public FrmGenerateTotalLabelFormat(IEnumerable<string> doelformaten)
        {
            InitializeComponent();
            foreach (string item in doelformaten)
            {
                cmbTargetFormat.Items.Add(item);
            }
           
            cmbTargetFormat.SelectedIndex = 0;
            lstTypeToestel.Items.Add("Sm5500");
            lstTypeToestel.Items.Add("Sm5100");
            lstTypeToestel.SelectedIndex = 0;
           
          
         
        }

        private void frmGenerateLabelFormat_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }


        private string GenerateFormat()
        {
            bool somethingChecked = false;
            string formatCode = lstTypeToestel.Text + "_";
            if (lstAfmetingen.Text == "")
            {
                lstAfmetingen.Text = Resources.FrmGenerateLabelFormat_GenerateFormat__60x49;
            }
            formatCode = formatCode + lstAfmetingen.Text + "_Totaal_";



            if (chkBarcode.Checked)
            {
                formatCode = formatCode + "Bc";
                somethingChecked = true;
            }
            if (chkInpakDatum.Checked)
            {
                formatCode = formatCode + "Pd";
                somethingChecked = true;
            }          
              
                if (chkGewicht.Checked)
                {
                    formatCode = formatCode + "Wt";
                    somethingChecked = true;
                }
                if (chkAantal.Checked)
                {
                    formatCode = formatCode + "Qu";
                    somethingChecked = true;
                }
              
                if (chkVerkoper.Checked)
                {
                    formatCode = formatCode + "Op";
                    somethingChecked = true;
                }
              
               
                                      
           


           



            if (somethingChecked==false)
            {
                formatCode = formatCode + "0";
            }
          
            return formatCode;
        }

        private void ChangeDevice(object sender, EventArgs e)
        {
            lstAfmetingen.Items.Clear();
            switch (lstTypeToestel.SelectedItem.ToString())
            {

                case "Sm5500":
                    lstAfmetingen.Items.Add("40x46");
                    lstAfmetingen.Items.Add("40x62");
                    lstAfmetingen.Items.Add("40x92");
                    lstAfmetingen.Items.Add("60x49");
                    lstAfmetingen.Items.Add("60x60");
                    lstAfmetingen.Items.Add("60x62");
                    lstAfmetingen.Items.Add("60x70");
                    lstAfmetingen.Items.Add("60x73");
                    lstAfmetingen.Items.Add("60x80");
                    lstAfmetingen.Items.Add("60x90");
                    lstAfmetingen.Items.Add("60x100");
                    lstAfmetingen.Items.Add("60x120");
                    lstAfmetingen.Items.Add("80x80");
                    lstAfmetingen.Items.Add("80x100");
                    break;
                case "Sm5100":
                    lstAfmetingen.Items.Add("40x46");
                    lstAfmetingen.Items.Add("40x62");
                    lstAfmetingen.Items.Add("40x92");
                    lstAfmetingen.Items.Add("60x49");
                    lstAfmetingen.Items.Add("60x60");
                    lstAfmetingen.Items.Add("60x62");
                    lstAfmetingen.Items.Add("60x70");
                    lstAfmetingen.Items.Add("60x73");
                    lstAfmetingen.Items.Add("60x80");
                    lstAfmetingen.Items.Add("60x90");
                    lstAfmetingen.Items.Add("60x100");
                    lstAfmetingen.Items.Add("60x120");

                    break;
            }
            lstAfmetingen.SelectedIndex = 3;
            
            ChangeFormatCode(sender, e);
        }


        private void ChangeFormatCode(object sender, EventArgs e)
        {
            switch (lstTypeToestel.SelectedIndex)
            {
                case 0:
                    sm5500LabelTexts = true;
                    break;
                case 1:
                    sm5500LabelTexts = false;
                    break;
            }
            btnOK.Enabled = true;
            txtLabelFormatCode.Text = GenerateFormat();
            GenerateImages();
            AdjustButtons();
        }


        private void AdjustControls()
        {
            string labelformatCode = txtLabelFormatCode.Text;
            if (labelformatCode.Contains("Sm5500"))
            {
                lstTypeToestel.SelectedIndex = 0;
            }
            if (labelformatCode.Contains("Sm5100"))
            {
                lstTypeToestel.SelectedIndex = 1;
            }
            int sizeIndex = 0;
            string formatSize = labelformatCode.Substring(7, 5);
            foreach (var item in lstAfmetingen.Items)
            {
                if (item.ToString().Contains(formatSize))
                {
                    sizeIndex = lstAfmetingen.Items.IndexOf(item);
                }
            }
            lstAfmetingen.SelectedIndex = sizeIndex;
            
            
            
            
            
            chkBarcode.Checked = labelformatCode.Contains("Bc");
            chkInpakDatum.Checked = labelformatCode.Contains("Pd");
            chkAantal.Checked = labelformatCode.Contains("Qu");
            chkGewicht.Checked = labelformatCode.Contains("Wt");
            chkVerkoper.Checked = labelformatCode.Contains("Op");


        }

        private void GenerateImages()
        {
            pctWeight.Image = this.NewFormat.LabelImageKg;
            //pctPieces.Image = this.NewFormat.LabelImageStk;
        }
        private void AdjustButtons()
        {
            btnOK.Enabled = NewFormat.OK;
            btnToCreate.Enabled = NewFormat.ToCreate;
        }
       


        //private void GenerateImages()
        //{
        //    int codeLength = 5;

        //    if (@NewFormat.FormaatCode.Substring(21).Contains("_"))
        //    {
        //        codeLength = 6;
        //    }
        //    // ImageFolder = @Folders.ServerDrive + @"\" + @newFormat.FormaatCode.Substring(0, 5) + @"\" + @newFormat.FormaatCode;
        //    string imageFolder = @Folders.ServerDrive + @"\" + lstTypeToestel.SelectedItem + @"\" + NewFormat.FormaatCode.Substring(7, codeLength) + @"\" + NewFormat.FormaatCode;

        //    //MessageBox.Show(ImageFolder);


        //    string strImageKg = imageFolder + @"\" + "kg.png";
        //    string strImageNotFound = @Folders.ServerDrive + @"\" + NewFormat.FormaatCode.Substring(0, 5) + @"\NotFound.png";


        //    int breedte = 244;
        //    int hoogte = 480;

        //    //if (lstAfmetingen.SelectedIndex == 0)
        //    //{
        //    //    breedte = 200;
        //    //    hoogte = 160;
        //    //}

        //    //if (lstAfmetingen.SelectedIndex == 1)
        //    //{
        //    //    breedte = 200;
        //    //    hoogte = 250;

        //    //}

        //    //if (lstAfmetingen.SelectedIndex== 2)
        //    //{
        //    //    breedte = 244;
        //    //    hoogte = 250;
        //    //}

        //    //if (lstAfmetingen.SelectedIndex == 3)
        //    //{
        //    //    breedte = 244;
        //    //    hoogte = 250;

        //    //}

        //    //if (lstAfmetingen.SelectedIndex == 4)
        //    //{
        //    //    breedte = 244;
        //    //    hoogte = 290;

        //    //}
           
        //    pctWeight.Width = breedte;
          
        //    pctWeight.Height = hoogte;

            
        //    if (File.Exists(strImageKg))
        //    {
        //        var imageKg = Image.FromFile(strImageKg);
        //        pctWeight.Image = ScaleImage(imageKg, breedte, hoogte);
        //    }
        //    else
        //    {
        //        if (File.Exists(strImageNotFound))
        //        {
        //            var imageNotFound = Image.FromFile(strImageNotFound);
        //            pctWeight.Image = ScaleImage(imageNotFound, breedte, hoogte);
        //        }
        //        else
        //        {
        //            pctWeight.Image = null;
        //        }
        //        btnOK.Enabled = false;
        //    }
          
        //}
        //public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        //{
        //    var ratioX = (double)maxWidth / image.Width;
        //    var ratioY = (double)maxHeight / image.Height;
        //    var ratio = Math.Min(ratioX, ratioY);

        //    var newWidth = (int)(image.Width * ratio);
        //    var newHeight = (int)(image.Height * ratio);

        //    var newImage = new Bitmap(newWidth, newHeight);
        //    Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
        //    return newImage;
        //}

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var browse = new FrmBrowse(@Folders.ServerDrive + @"\" + lstTypeToestel.Text + @"\" + lstAfmetingen.Text, true);
            DialogResult result = browse.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    {

                        if (browse.NewFormat != null)
                        {

                            txtLabelFormatCode.Text = browse.NewFormat;
                           // GenerateImages();
                            AdjustControls();

                        }



                        break;
                    }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


       

    }
}
