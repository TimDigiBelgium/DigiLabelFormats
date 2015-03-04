using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryLabelFormats;
using DigiLabelFormats.Properties;

namespace DigiLabelFormats
{
    public partial class FrmGenerateLabelFormat : Form
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


      



        public FrmGenerateLabelFormat(IEnumerable<string> doelformaten)
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

            this.chkArticleName.Checked = true;
            this.chkWeight.Checked = true;
            this.chkQuantity.Checked = true;
            this.chkUnitPrice.Checked = true;
            this.chkTotalPrice.Checked = true;
            this.chkShopName.Checked = true;
            this.chkIngredients.Checked = true;

            radioGeenTemp.Checked = true;
            radioGeenVlees.Checked = true;

            this.btnToCreate.Enabled = false;
           


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
            formatCode = formatCode + lstAfmetingen.Text + "_";

          
            
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
            if (chkBewaarAdvies.Checked)
            {
                formatCode = formatCode + "Sm";
                somethingChecked = true;
            }
            if (chkTGT.Checked)
            {
                formatCode = formatCode + "Ud";
                somethingChecked = true;
            }
            if (chkUVD.Checked)
            {
                formatCode = formatCode + "Sd";
                somethingChecked = true;
            }

            if (chkOperator.Checked)
            {
                formatCode = formatCode + "Op";
                somethingChecked = true;
            }

            if (chkPluNumber.Checked)
            {
                formatCode = formatCode + "Pn";
                somethingChecked = true;
            }

            if (chkShopLogo.Checked)
            {
                formatCode = formatCode + "Sl";
                somethingChecked = true;
            }

            if (this.chkShopLarge.Checked)
            {
                formatCode = formatCode + "Ll";
                somethingChecked = true;
            }

           



            if (radioTrace.Checked)
            {
                formatCode = formatCode + "Tr";
                somethingChecked = true;
            }

            if (radioKip.Checked)
            {
                formatCode = formatCode + "Cw";
                somethingChecked = true;
            }

            if (radioTempVast.Checked)
            {
                formatCode = formatCode + "Tf";
                somethingChecked = true;
            }

            if (radioTempVar.Checked)
            {
                formatCode = formatCode + "Tv";
                somethingChecked = true;
            }

            if (chkMinMax.Checked)
            {
                formatCode = formatCode + "Tt";
                somethingChecked = true;
            }

            if (this.chkHeating.Checked)
            {
                formatCode = formatCode + "Ht";
                somethingChecked = true;
            }

        

            if (this.chkBeef.Checked)
            {
                formatCode = formatCode + "Bi";
                somethingChecked = true;
            }


            if (this.chkNuts.Checked)
            {
                formatCode = formatCode + "Ni";
                somethingChecked = true;
            }

            if (this.chkCooling.Checked)
            {
                formatCode = formatCode + "Ci";
                somethingChecked = true;
            }

            if (this.chkFreezing.Checked)
            {
                formatCode = formatCode + "Cf";
                somethingChecked = true;
            }


            if (!this.chkArticleName.Checked)
            {
                formatCode = formatCode + "A0";
                somethingChecked = true;
            }


            if (!this.chkWeight.Checked)
            {
                formatCode = formatCode + "W0";
                somethingChecked = true;
            }

            if (!this.chkQuantity.Checked)
            {
                formatCode = formatCode + "Q0";
                somethingChecked = true;
            }

            if (!this.chkUnitPrice.Checked)
            {
                formatCode = formatCode + "U0";
                somethingChecked = true;
            }

            if (!this.chkTotalPrice.Checked)
            {
                formatCode = formatCode + "T0";
                somethingChecked = true;
            }

            if (!this.chkShopName.Checked)
            {
                formatCode = formatCode + "S0";
                somethingChecked = true;
            }
            
            if (!this.chkIngredients.Checked)
            {
                formatCode = formatCode + "I0";
                somethingChecked = true;
            }

    

            


            if (somethingChecked == false)
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
                    lstAfmetingen.Items.Add("80x120");
                    lstAfmetingen.Items.Add("Linerless");
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

        private void TempQuantity(object sender, EventArgs e)
        {
            if (sender.Equals(radioGeenTemp))
            {
                chkMinMax.Checked = false;
                grpTempQuantity.Enabled = false;

            }
            else
            {
                grpTempQuantity.Enabled = true;
            }
           
            CheckRadioButton(sender, e);
        }


        private void CheckRadioButton(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    ChangeFormatCode(sender, e);
                }
            }
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
           ErrorMessage();
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
            foreach (var item in lstAfmetingen.Items.Cast<object>().Where(item => item.ToString().Contains(formatSize)))
            {
                sizeIndex = lstAfmetingen.Items.IndexOf(item);
            }
            lstAfmetingen.SelectedIndex = sizeIndex;






            chkBarcode.Checked = labelformatCode.Substring(13).Contains("Bc");
            chkInpakDatum.Checked = labelformatCode.Substring(13).Contains("Pd");
            chkTGT.Checked = labelformatCode.Substring(13).Contains("Ud");
            chkBewaarAdvies.Checked = labelformatCode.Substring(13).Contains("Sm");
            chkUVD.Checked = labelformatCode.Substring(13).Contains("Sd");
            chkOperator.Checked = labelformatCode.Substring(13).Contains("Op");
            this.chkPluNumber.Checked = labelformatCode.Substring(13).Contains("Pn");
            this.chkShopLogo.Checked = labelformatCode.Substring(13).Contains("Sl");
            this.chkShopLarge.Checked = labelformatCode.Substring(13).Contains("Ll");

            radioTrace.Checked = labelformatCode.Substring(13).Contains("Tr");


            radioKip.Checked = labelformatCode.Substring(13).Contains("Cw");

            if (labelformatCode.Substring(13).Contains("Tr") == false & labelformatCode.Substring(13).Contains("Cw") == false)
            {
                radioGeenVlees.Checked = true;
            }


            radioTempVast.Checked = labelformatCode.Substring(13).Contains("Tf");


            radioTempVar.Checked = labelformatCode.Substring(13).Contains("Tv");

            if (labelformatCode.Substring(13).Contains("Tf") == false & labelformatCode.Substring(13).Contains("Tv") == false)
            {
                radioGeenTemp.Checked = true;
            }

            chkMinMax.Checked = labelformatCode.Substring(13).Contains("Tt");


            this.chkHeating.Checked = labelformatCode.Substring(13).Contains("Ht");

           

            this.chkBeef.Checked = labelformatCode.Substring(13).Contains("Bi");

            

            this.chkNuts.Checked = labelformatCode.Substring(13).Contains("Ni");

            this.chkCooling.Checked = labelformatCode.Substring(13).Contains("Ci");

            this.chkFreezing.Checked = labelformatCode.Substring(13).Contains("Cf");

            this.chkArticleName.Checked = !labelformatCode.Substring(13).Contains("A0");

            this.chkWeight.Checked = !labelformatCode.Substring(13).Contains("W0");

            this.chkQuantity.Checked = !labelformatCode.Substring(13).Contains("Q0");

            this.chkUnitPrice.Checked = !labelformatCode.Substring(13).Contains("U0");

            this.chkTotalPrice.Checked = !labelformatCode.Substring(13).Contains("T0");

            this.chkShopName.Checked = !labelformatCode.Substring(13).Contains("S0");

            this.chkIngredients.Checked = !labelformatCode.Substring(13).Contains("I0");

           

        }


        private void GenerateImages()
        {
            pctWeight.Image = this.NewFormat.LabelImageKg;
            pctPieces.Image = this.NewFormat.LabelImageStk;
        }

        private void AdjustButtons()
        {
            btnOK.Enabled = NewFormat.OK;
            btnToCreate.Enabled = NewFormat.ToCreate;
        }
        private void ErrorMessage()
        {
            if (NewFormat.Error!=null)
            {
                lblError.Text = NewFormat.Error;
            }
            else
            {
                lblError.Text = "";
            }

        }
       

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var browse = new FrmBrowse(@Folders.ServerDrive + @"\" + lstTypeToestel.Text + @"\" + lstAfmetingen.Text, false);
            DialogResult result = browse.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    {

                        if (browse.NewFormat != null)
                        {

                            txtLabelFormatCode.Text = browse.NewFormat;
                            //GenerateImages();
                            AdjustControls();

                        }



                        break;
                    }
            }
        }

        private void cmbTargetFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pctWeight_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

       




    }
}
