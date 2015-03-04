using ClassLibraryLabelFormats;
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

namespace DigiLabelFormats
{
    public partial class frmCustomerLabels : Form
    {

        public bool customer { get; set; }


        public LabelFormat NewFormat
        {
            get
            {

                return new LabelFormat(cmbTargetFormat.Text, txtLabelFormatCode.Text,this.pctWeight.Image);


            }
        }
        public bool sm5500LabelTexts
        {
            get;
            private set;
        }
        
        
        
        public frmCustomerLabels(IEnumerable<string> doelformaten,bool customer)
        {
            InitializeComponent();
            string[] dirs;
            this.customer = customer;
            foreach (string item in doelformaten)
            {
                cmbTargetFormat.Items.Add(item);
            }

            cmbTargetFormat.SelectedIndex = 0;
            if (customer)
            {
                dirs = Directory.GetDirectories(Folders.CustomerLabels);
            }
            else
            {
                dirs = Directory.GetDirectories(Folders.SalesMenLabels);
            }
        

        // For folders in the directory
        foreach(string dir in dirs)
            lstKlanten.Items.Add(new DirectoryInfo(dir).Name);
           
           
        }

        private void lstKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDevice.Items.Clear();
            lstDepartment.Items.Clear();
            lstSize.Items.Clear();
            string[] dirs;

            if (this.customer)
            {
                dirs = Directory.GetDirectories(Folders.CustomerLabels + @"\" + @lstKlanten.Text);
            }
            else
            {
                dirs = Directory.GetDirectories(Folders.SalesMenLabels + @"\" + @lstKlanten.Text);
            }
            
           

            // For folders in the directory
            foreach (string dir in dirs)
                lstDevice.Items.Add(new DirectoryInfo(dir).Name);

           


        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDepartment.Items.Clear();
            lstSize.Items.Clear();
             string[] dirs;

             if (this.customer)
             {

                 dirs = Directory.GetDirectories(Folders.CustomerLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text);
             }
             else
             {
                 dirs = Directory.GetDirectories(Folders.SalesMenLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text);
             }

            // For folders in the directory
            foreach (string dir in dirs)
                lstDepartment.Items.Add(new DirectoryInfo(dir).Name);

            switch (lstDevice.SelectedItem.ToString())
            {
                case "Sm5500":
                    sm5500LabelTexts = true;
                    break;
                case "Sm5100":
                    sm5500LabelTexts = false;
                    break;
            }



        }

        private void lstDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSize.Items.Clear();

             string[] dirs;

             if (this.customer)
             {

                 dirs = Directory.GetDirectories(Folders.CustomerLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text + @"\" + @lstDepartment.Text);
             }
             else
             {
                 dirs = Directory.GetDirectories(Folders.SalesMenLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text + @"\" + @lstDepartment.Text);
             }

            // For folders in the directory
            foreach (string dir in dirs)
                lstSize.Items.Add(new DirectoryInfo(dir).Name);

        }

        private void lstSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.customer)
            {
                //txtLabelFormatCode.Text = new DirectoryInfo(Directory.GetDirectories(Folders.CustomerLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text + @"\" + @lstDepartment.Text + @"\" + @lstSize.Text).First()).Name;

                txtLabelFormatCode.Text = @"Customer_" + @lstKlanten.Text + @"_" + @lstDevice.Text + @"_" + @lstDepartment.Text + @"_" + @lstSize.Text;
            }
            else
            {
                //txtLabelFormatCode.Text = new DirectoryInfo(Directory.GetDirectories(Folders.SalesMenLabels + @"\" + @lstKlanten.Text + @"\" + @lstDevice.Text + @"\" + @lstDepartment.Text + @"\" + @lstSize.Text).First()).Name;

                txtLabelFormatCode.Text = @"Salesmen_" + @lstKlanten.Text + @"_" + @lstDevice.Text + @"_" + @lstDepartment.Text + @"_" + @lstSize.Text;
     
            }
                  GenerateImages();
        }

        private void frmCustomerLabels_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void GenerateImages()
        {
            string imageFolder;

          

         
                imageFolder = Folders.rootMap + @"\" + this.txtLabelFormatCode.Text.Replace("_", @"\");

         

         



            string strImageKg = imageFolder + @"\" + "kg.png";
            string strImageStk = imageFolder + @"\" + "stk.png";
            string strImageNotFound = @Folders.ServerDrive + @NewFormat.FormaatCode.Substring(0, 5) + @"\NotFound.png";


            int breedte = 244;
            int hoogte = 480;


            pctPieces.Width = breedte;
            pctWeight.Width = breedte;
            pctPieces.Height = hoogte;
            pctWeight.Height = hoogte;


            if (File.Exists(strImageKg))
            {
                var imageKg = Image.FromFile(strImageKg);
                pctWeight.Image = ScaleImage(imageKg, breedte, hoogte);
                btnOK.Enabled = true;
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
                //btnOK.Enabled = false;
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
               // btnOK.Enabled = false;
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






        
    }
}
