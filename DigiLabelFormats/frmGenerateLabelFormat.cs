using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryLabelFormats;
using DigiLabelFormats.Properties;
using System.Xml.Linq;
using DigiLabelFormats.Classes;
using System.Data;

namespace DigiLabelFormats
{
    public partial class FrmGenerateLabelFormat : Form
    {



        public LabelFormat NewFormat
        {
            get
            {

                return new LabelFormat(cmbTargetFormat.Text, txtLabelFormatCode.Text, Omschrijving());


            }
        }

        public IEnumerable<string> doelformaten { get; set; }

        public bool sm5500LabelTexts
        {
            get;
            private set;
        }




        public List<clsLabelField> basicfields
        {
            get
            {
                return ListFactory(@"\XML\basicfields.xml");
            }
        }

        public List<clsLabelField> extendedfields
        {
            get
            {
                return ListFactory(@"\XML\extendedfields.xml");
            }
        }

        public List<clsLabelField> tracefields
        {
            get
            {
                return ListFactory(@"\XML\tracefields.xml");
            }

        }

        public List<clsLabelField> temperaturefields
        {
            get
            {
                return ListFactory(@"\XML\temperaturefields.xml");
            }
        }

        public List<clsLabelField> textfields
        {
            get
            {
                return ListFactory(@"\XML\textfields.xml");
            }
        }

        public List<clsLabelField> imagefields
        {
            get
            {
                return ListFactory(@"\XML\imagefields.xml");
            }
        }

        public List<clsLabelField> infotagfields
        {
            get
            {
                return ListFactory(@"\XML\infotagfields.xml");
            }
        }

        public void refreshDoelFormaten()
        {
            cmbTargetFormat.Items.Clear();
            foreach (string item in this.doelformaten)
            {
                cmbTargetFormat.Items.Add(item);
            }

        }






        public FrmGenerateLabelFormat(IEnumerable<string> doelformaten)
        {
            this.doelformaten = doelformaten;
            InitializeComponent();

            refreshDoelFormaten();

            cmbTargetFormat.SelectedIndex = 0;

            lstTypeToestel.Items.Add("Sm5500");
            lstTypeToestel.Items.Add("Sm5100");
            lstTypeToestel.Items.Add("Infotag");
            lstTypeToestel.SelectedIndex = 0;



            lstBasicFields.DataSource = basicfields;
            lstBasicFields.DisplayMember = "Name";
            lstBasicFields.ValueMember = "Code";





            lstExtendedFields.DataSource = extendedfields;
            lstExtendedFields.DisplayMember = "Name";
            lstExtendedFields.ValueMember = "Code";


            lstTraceability.DataSource = tracefields;
            lstTraceability.DisplayMember = "Name";
            lstTraceability.ValueMember = "Code";

            lstTemperatures.DataSource = temperaturefields;
            lstTemperatures.DisplayMember = "Name";
            lstTemperatures.ValueMember = "Code";

            lstShoplogos.DataSource = imagefields;
            lstShoplogos.DisplayMember = "Name";
            lstShoplogos.ValueMember = "Code";


            lstTextFields.DataSource = textfields;
            lstTextFields.DisplayMember = "Name";
            lstTextFields.ValueMember = "Code";

            lstInfotag.DataSource = infotagfields;
            lstInfotag.DisplayMember = "Name";
            lstInfotag.ValueMember = "Code";


            this.btnToCreate.Enabled = false;





        }

        public string Omschrijving()
        {

            string omschrijving = "";


            foreach (clsLabelField element in this.lstExtendedFields.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }

            foreach (clsLabelField element in this.lstShoplogos.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }


            foreach (clsLabelField element in this.lstTraceability.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;

            }

            //formatCode = formatCode.Replace("T1T2T3T4T6", "Tr");

            foreach (clsLabelField element in this.lstTemperatures.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }

            foreach (clsLabelField element in this.lstTextFields.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }



            foreach (clsLabelField element in this.lstInfotag.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }

            foreach (clsLabelField element in lstBasicFields.SelectedItems)
            {
                omschrijving += element.Name + Environment.NewLine;
            }







            return omschrijving;
        }

        private void defaultselections()
        {

            for (int i = 0; i < lstBasicFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstBasicFields.Items[i];
                lstBasicFields.SetSelected(i, LF.defaultSelected);
            }

            for (int i = 0; i < lstExtendedFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstExtendedFields.Items[i];
                lstExtendedFields.SetSelected(i, LF.defaultSelected);
            }

            for (int i = 0; i < this.lstTemperatures.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTemperatures.Items[i];
                if (LF.defaultSelected)
                {
                    lstTemperatures.SetSelected(i, true);
                }

            }

            for (int i = 0; i < lstTraceability.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTraceability.Items[i];
                lstTraceability.SetSelected(i, LF.defaultSelected);
            }

            for (int i = 0; i < lstTextFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTextFields.Items[i];
                lstTextFields.SetSelected(i, LF.defaultSelected);
            }

            for (int i = 0; i < lstShoplogos.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstShoplogos.Items[i];
                lstShoplogos.SetSelected(i, LF.defaultSelected);
            }


            for (int i = 0; i < lstInfotag.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstInfotag.Items[i];
                lstInfotag.SetSelected(i, LF.defaultSelected);
            }

        }

        private void frmGenerateLabelFormat_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            defaultselections();
        }


        public List<clsLabelField> ListFactory(string xmlfilename)
        {
            XElement xelement = XElement.Load(Directory.GetCurrentDirectory() + xmlfilename);

            List<clsLabelField> _lbList = new List<clsLabelField>();

            foreach (XElement item in xelement.Descendants("field"))
            {
                _lbList.Add(new clsLabelField
                {
                    Name = item.Element("name").Value,
                    Code = item.Element("code").Value,
                    ID = int.Parse(item.Element("index").Value),
                    defaultSelected = (bool)item.Element("defaultselected")
                });
            }

            return _lbList;
        }




        private string GenerateFormat()
        {
            string basicformatCode = lstTypeToestel.Text + "_";
            if (lstAfmetingen.Text == "")
            {
                lstAfmetingen.Text = Resources.FrmGenerateLabelFormat_GenerateFormat__60x49;
            }
            basicformatCode = basicformatCode + lstAfmetingen.Text + "_";

            if (lstBasicFields.Items.Count > 0)
            {

                string formatCode;
                formatCode = "";








                foreach (clsLabelField element in this.lstExtendedFields.SelectedItems)
                {
                    formatCode += element.Code;
                }

                foreach (clsLabelField element in this.lstShoplogos.SelectedItems)
                {
                    formatCode += element.Code;
                }


                foreach (clsLabelField element in this.lstTraceability.SelectedItems)
                {
                    formatCode += element.Code;

                }

                formatCode = formatCode.Replace("T1T2T3T4T6", "Tr");

                foreach (clsLabelField element in this.lstTemperatures.SelectedItems)
                {
                    formatCode += element.Code;
                }

                foreach (clsLabelField element in this.lstTextFields.SelectedItems)
                {
                    formatCode += element.Code;
                }



                foreach (clsLabelField element in this.lstInfotag.SelectedItems)
                {
                    formatCode += element.Code;
                }

                foreach (clsLabelField element in lstBasicFields.Items)
                {
                    if (!lstBasicFields.GetSelected(element.ID))
                        formatCode += element.Code;
                }




                if (formatCode == "")
                {
                    formatCode = "0";
                }
                basicformatCode += formatCode;
            }
            else
            {
                basicformatCode += "0";
            }

            return basicformatCode;

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
                case "Infotag":
                    lstAfmetingen.Items.Add("1.44 inch normal");
                    lstAfmetingen.Items.Add("1.44 inch promo");
                    lstAfmetingen.Items.Add("2 inch normal");
                    lstAfmetingen.Items.Add("2 inch promo");
                    lstAfmetingen.Items.Add("2.7 inch normal");
                    lstAfmetingen.Items.Add("2.7 inch norm.100g");
                    lstAfmetingen.Items.Add("2.7 inch promo");
                    lstAfmetingen.Items.Add("2.7 inch prom.100g");
                    lstAfmetingen.Items.Add("2.9 inch normal");
                    lstAfmetingen.Items.Add("2.9 inch norm.color");
                    lstAfmetingen.Items.Add("2.9 inch promo");
                    lstAfmetingen.Items.Add("2.9 inch prom.color");
                    lstAfmetingen.Items.Add("4.41 inch normal");
                    lstAfmetingen.Items.Add("4.41 inch promo");
                    lstAfmetingen.Items.Add("6 inch normal");
                    lstAfmetingen.Items.Add("6 inch norm.color");
                    lstAfmetingen.Items.Add("6 inch promo");
                    lstAfmetingen.Items.Add("6 inch prom.color");


                    break;
            }
            lstAfmetingen.SelectedIndex = 3;
            ChangeFormatCode(sender, e);
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
                    cmbTargetFormat.Enabled = true;
                    refreshDoelFormaten();
                    cmbTargetFormat.SelectedIndex = 0;
                    break;
                case 1:
                    sm5500LabelTexts = false;
                    cmbTargetFormat.Enabled = true;
                    refreshDoelFormaten();
                    cmbTargetFormat.SelectedIndex = 0;
                    break;
                case 2:
                    sm5500LabelTexts = true;
                    cmbTargetFormat.Text = assignInfotagNr();
                    cmbTargetFormat.Enabled = false;

                    break;
            }

            btnOK.Enabled = true;
            txtLabelFormatCode.Text = GenerateFormat();
            GenerateImages();
            AdjustButtons();
            ErrorMessage();
        }

        private string assignInfotagNr()
        {
            string infotagnr = "";
            switch (this.lstAfmetingen.SelectedIndex)
            {
                case 0:
                    infotagnr = "1001";
                    break;
                case 1:
                    infotagnr = "1021";
                    break;
                case 2:
                    infotagnr = "1002";
                    break;
                case 3:
                    infotagnr = "1022";
                    break;
                case 4:
                    infotagnr = "1003";
                    break;
                case 5:
                    infotagnr = "1007";
                    break;
                case 6:
                    infotagnr = "1023";
                    break;
                case 7:
                    infotagnr = "1027";
                    break;
                case 8:
                    infotagnr = "1005";
                    break;
                case 9:
                    infotagnr = "1015";
                    break;
                case 10:
                    infotagnr = "1025";
                    break;
                case 11:
                    infotagnr = "1035";
                    break;
                case 12:
                    infotagnr = "1004";
                    break;
                case 13:
                    infotagnr = "1024";
                    break;
                case 14:
                    infotagnr = "1008";
                    break;
                case 15:
                    infotagnr = "1018";
                    break;
                case 16:
                    infotagnr = "1028";
                    break;
                case 17:
                    infotagnr = "1038";
                    break;
            }
            return infotagnr;

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
            if (labelformatCode.Contains("Infotag"))
            {
                lstTypeToestel.SelectedIndex = 2;
            }
            int sizeIndex = 0;
            string formatSize = labelformatCode.Substring(7, 5);
            if (labelformatCode.Contains("Infotag"))
            {
                string part = labelformatCode.Substring(8, labelformatCode.Length - 8);
                int split = part.IndexOf("_");

                //codedevice = FormaatCode.IndexOf("_");
                //codesize = 7;
                //codesizestart = 8;
                //infotag = true;
                formatSize = labelformatCode.Substring(8, split);
            }

            foreach (var item in lstAfmetingen.Items.Cast<object>().Where(item => item.ToString().Contains(formatSize)))
            {
                sizeIndex = lstAfmetingen.Items.IndexOf(item);
            }
            lstAfmetingen.SelectedIndex = sizeIndex;






            for (int i = 0; i < lstExtendedFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstExtendedFields.Items[i];
                lstExtendedFields.SetSelected(LF.ID, labelformatCode.Substring(13).Contains(LF.Code));
            }

            labelformatCode = labelformatCode.Replace("Tr", "T1T2T3T4T6");

            for (int i = 0; i < this.lstTraceability.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTraceability.Items[i];
                lstTraceability.SetSelected(LF.ID, labelformatCode.Substring(13).Contains(LF.Code));
            }


            lstTemperatures.ClearSelected();

            for (int i = 0; i < this.lstTemperatures.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTemperatures.Items[i];
                if (labelformatCode.Substring(13).Contains(LF.Code))
                {
                    lstTemperatures.SetSelected(i, true);
                }

            }



            for (int i = 0; i < this.lstTextFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstTextFields.Items[i];
                lstTextFields.SetSelected(LF.ID, labelformatCode.Substring(13).Contains(LF.Code));
            }

            for (int i = 0; i < this.lstShoplogos.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstShoplogos.Items[i];
                lstShoplogos.SetSelected(LF.ID, labelformatCode.Substring(13).Contains(LF.Code));
            }

            for (int i = 0; i < this.lstInfotag.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstInfotag.Items[i];
                lstInfotag.SetSelected(LF.ID, labelformatCode.Substring(13).Contains(LF.Code));
            }

            for (int i = 0; i < lstBasicFields.Items.Count; i++)
            {
                clsLabelField LF = (clsLabelField)lstBasicFields.Items[i];
                lstBasicFields.SetSelected(LF.ID, !labelformatCode.Substring(13).Contains(LF.Code));
            }

            //  labelformatCode = labelformatCode.Replace("T1T2T3T4T6","Tr");


            //chkBarcode.Checked = labelformatCode.Substring(13).Contains("Bc");
            //chkInpakDatum.Checked = labelformatCode.Substring(13).Contains("Pd");
            //chkTGT.Checked = labelformatCode.Substring(13).Contains("Ud");
            //chkBewaarAdvies.Checked = labelformatCode.Substring(13).Contains("Sm");
            //chkUVD.Checked = labelformatCode.Substring(13).Contains("Sd");
            //chkOperator.Checked = labelformatCode.Substring(13).Contains("Op");
            //this.chkPluNumber.Checked = labelformatCode.Substring(13).Contains("Pn");
            //this.chkShopLogo.Checked = labelformatCode.Substring(13).Contains("Sl");
            //this.chkShopLarge.Checked = labelformatCode.Substring(13).Contains("Ll");

            //radioTrace.Checked = labelformatCode.Substring(13).Contains("Tr");


            //radioKip.Checked = labelformatCode.Substring(13).Contains("Cw");

            //if (labelformatCode.Substring(13).Contains("Tr") == false & labelformatCode.Substring(13).Contains("Cw") == false)
            //{
            //    radioGeenVlees.Checked = true;
            //}


            //radioTempVast.Checked = labelformatCode.Substring(13).Contains("Tf");


            //radioTempVar.Checked = labelformatCode.Substring(13).Contains("Tv");

            //if (labelformatCode.Substring(13).Contains("Tf") == false & labelformatCode.Substring(13).Contains("Tv") == false)
            //{
            //    radioGeenTemp.Checked = true;
            //}

            //chkMinMax.Checked = labelformatCode.Substring(13).Contains("Tt");


            //this.chkHeating.Checked = labelformatCode.Substring(13).Contains("Ht");



            //this.chkBeef.Checked = labelformatCode.Substring(13).Contains("Bi");



            //this.chkNuts.Checked = labelformatCode.Substring(13).Contains("Ni");

            //this.chkCooling.Checked = labelformatCode.Substring(13).Contains("Ci");

            //this.chkFreezing.Checked = labelformatCode.Substring(13).Contains("Cf");

            //this.chkPromo.Checked = labelformatCode.Substring(13).Contains("Pr");

            //this.chkInfoTagVanaf.Checked = labelformatCode.Substring(13).Contains("Iv");

            //this.chkArticleName.Checked = !labelformatCode.Substring(13).Contains("A0");

            //  XElement xelement = XElement.Load(Directory.GetCurrentDirectory() + @"XML\basicfields.xml");
            // IEnumerable<XElement> basicFields = xelement.Elements();

            /////  List<string> basicFieldNames = new List<string>();

            //   foreach (XElement xEle in basicFields)
            //      this.lstBasicFields.SetSelected(Int16.Parse(xEle.Element("Index").ToString()),!labelformatCode.Substring(13).Contains(xEle.Element("Code").ToString())) ;


            //foreach(var item in )

            //basicFieldNames.Add(xEle.Element("name").ToString());

            //lstBasicFields.DataSource = basicFields;





            //this.chkWeight.Checked = !labelformatCode.Substring(13).Contains("W0");

            //this.chkQuantity.Checked = !labelformatCode.Substring(13).Contains("Q0");

            //this.chkUnitPrice.Checked = !labelformatCode.Substring(13).Contains("U0");

            //this.chkTotalPrice.Checked = !labelformatCode.Substring(13).Contains("T0");

            //this.chkShopName.Checked = !labelformatCode.Substring(13).Contains("S0");

            //this.chkIngredients.Checked = !labelformatCode.Substring(13).Contains("I0");



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
            if (NewFormat.Error != null)
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

        private void lstTextFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}
