using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryLabelFormats;
using DigiLabelFormats.Properties;
using OfficeOpenXml;


namespace DigiLabelFormats
{

    public partial class FrmLabelFormats : Form
    {

        public List<LabelFormat> LabelFormats;

        public List<string> DoelFormaten;

        public List<string> RestDoelFormaten;

        public bool sm5500labeltexts;




        public FrmLabelFormats()
        {
            InitializeComponent();
            CenterToScreen();
            LabelFormats = new List<LabelFormat>();
            DoelFormaten = new List<string>();
            RestDoelFormaten = new List<string>();
            InitializeRestFormaten();



            Folders.rootMap = Directory.GetCurrentDirectory() + @"\LblFrmts";

            Folders.ServerDrive = Folders.rootMap + @"\Database";

            Folders.StartDatServer = Folders.rootMap + @"\DataFiles\Start.dat";

            Folders.Sm5500NederlandseTeksten = Folders.rootMap + @"\DataFiles\Label teksten\Sm5500\NL_Standaard Label Teksten.txt";
            Folders.Sm5500FranseTeksten = Folders.rootMap + @"\DataFiles\Label teksten\Sm5500\FR_Standaard Label Teksten.txt";


            Folders.Sm5100NederlandseTeksten = Folders.rootMap + @"\DataFiles\Label teksten\Sm5100\NL_Standaard Label Teksten.txt";


            Folders.Sm5100FranseTeksten = Folders.rootMap + @"\DataFiles\Label teksten\Sm5100\FR_Standaard Label Teksten.txt";



            Folders.DigiDriver = @"C:\DEC\DIGIDRV\DIGIDRV.EXE";
            Folders.DigiDriverConfiguration = @"C:\DEC\DIGIDRV\DigiDriverConfiguration.EXE";
            Folders.SendDat = @"C:\DEC\Digidrv\In\send.dat";
            Folders.StartDat = @"C:\DEC\Digidrv\In\start.dat";

            Folders.LabelDesignerFormatFile = @"C:\DEC\Digidrv\Data\freeformats.dat";
            Folders.LabelDesigner = @"c:\dec\label designer\label designer.exe";


            Folders.CustomerLabels = Folders.rootMap + @"\Customer";




            Folders.SalesMenLabels = Folders.rootMap + @"\Salesmen";










            lstLanguage.Items.Add("No label texts");
            lstLanguage.Items.Add("Nederlands");
            lstLanguage.Items.Add("Français");
            lstLanguage.SelectedIndex = 1;
        }



        private void btnToevoegen_Click(object sender, EventArgs e)
        {



            if (Directory.Exists(Folders.ServerDrive) == false)
            {
                MessageBox.Show(Resources.FrmLabelFormats_btnToevoegen_Click_Geen_database_gevonden);
            }
            else
            {
                RefreshRestFormaten();

                if (RestDoelFormaten.Count == 0)
                {
                    MessageBox.Show("Error : 9 formats is the maximum number you can select !");
                }
                else
                {




                    var generateLabelFormat = new FrmGenerateLabelFormat(RestDoelFormaten);
                    DialogResult result = generateLabelFormat.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:
                            {

                                if (generateLabelFormat.NewFormat.FormaatCode != null)
                                {

                                    LabelFormats.Add(generateLabelFormat.NewFormat);
                                    DoelFormaten.Add(generateLabelFormat.NewFormat.DoelFormaat);
                                    RefreshRestFormaten();
                                    RefreshLabelFormats();
                                    sm5500labeltexts = generateLabelFormat.sm5500LabelTexts;

                                }



                                break;
                            }
                    }




                }






            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            if (lstLabelFormats.Items.Count == 0)
            {
                MessageBox.Show("Error : There are no labelformats in your selection !");
            }
            else
            {
                if (lstLabelFormats.SelectedIndex != -1)
                {
                    LabelFormats.Remove((LabelFormat)lstLabelFormats.SelectedItem);
                    DoelFormaten.RemoveAt(lstLabelFormats.SelectedIndex);
                    RefreshRestFormaten();
                    RefreshLabelFormats();
                }
                else
                {
                    MessageBox.Show("Error : Select the labelformat you want to delete !");
                }
            }

        }


        private void RefreshLabelFormats()
        {
            lstLabelFormats.Items.Clear();
            foreach (LabelFormat item in LabelFormats)
            {
                lstLabelFormats.Items.Add(item);
            }
        }

        private void InitializeRestFormaten()
        {
            for (int i = 1; i < 10; i++)
            {
                RestDoelFormaten.Add("F" + i);
            }
        }

        private void RefreshRestFormaten()
        {
            RestDoelFormaten.Clear();
            InitializeRestFormaten();
            foreach (string item in DoelFormaten)
            {
                RestDoelFormaten.Remove(item);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstLabelFormats.Items.Count == 0)
            {
                MessageBox.Show("Error : There are no labelformats in your selection !");
            }
            else
            {
                ClearLabelFormats();
            }
        }


        private void ClearLabelFormats()
        {
            LabelFormats.Clear();
            lstLabelFormats.Items.Clear();
            DoelFormaten.Clear();
            RestDoelFormaten.Clear();
            InitializeRestFormaten();
        }




        private string WriteFormatFile()
        {

            string combinedFormats = "";

            foreach (var item in LabelFormats)
            {
                if (item.DigiDriverText.Substring(0, 4) == "0103")
                {
                    item.DigiDriverText = "01" + item.DigiDriverText.Trim('\r', '\n');
                }
                combinedFormats = combinedFormats + item.DigiDriverText + Environment.NewLine;
            }

            return combinedFormats;
        }


        private void frmLabelFormats_Load(object sender, EventArgs e)
        {

        }











        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            //if (LabelFormats.Count == 0)
            //{
            //    MessageBox.Show(Resources.FrmLabelFormats_btnOverzicht_Click_Voeg_eerst_een_of_meerdere_formaten_toe);
            //}
            //else
            //{
            //    string combinedDescriptions = LabelFormats.Aggregate("", (current, item) => current + item + Environment.NewLine + item.Omschrijving + Environment.NewLine + Environment.NewLine);

            //    var overzicht = new FrmOverzicht(combinedDescriptions);

            //    overzicht.Show();

            //}


            using (SaveFileDialog ofd = new SaveFileDialog())
            {

                ofd.FileName = "Etiketformaten.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    ExcelSummary InvulLijst = new ExcelSummary(ofd.FileName, this.LabelFormats);

                    MessageBox.Show("Excel summary succesfully created, you can find the file here : " + Environment.NewLine + ofd.FileName);

                    // Application.Exit();



                }

            }

        }



        private void btnOpenFormatFile_Click(object sender, EventArgs e)
        {
            openFormatsDialog.InitialDirectory = Path.GetFullPath(@Folders.ServerDrive + @"\FreeFormats\");
            DialogResult result = openFormatsDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFormatsDialog.FileName;
                if (file != null)
                {

                    string line;
                    ClearLabelFormats();

                    var readfile = new StreamReader(file);

                    while ((line = readfile.ReadLine()) != null)
                    {
                        if (line == "") continue;
                        if ((line.Substring(0, 4) != "0103") && (line.Substring(0, 6) != "010103")) continue;
                        string formaatCode;

                        int findCode = line.IndexOf("AA", StringComparison.Ordinal);
                        string doelFormaat = line.Substring(findCode + 2, 4);
                        int parseFormaat = int.Parse(doelFormaat);
                        parseFormaat = parseFormaat - 69;
                        doelFormaat = "F" + parseFormaat;
                        //MessageBox.Show(doelFormaat);
                        if (line.Substring(12, 2) != "AB")
                        {
                            formaatCode = "Undefined";
                        }
                        else
                        {


                            formaatCode = line.Substring(22, line.Length - 22);
                            formaatCode = formaatCode.Substring(0, formaatCode.IndexOf((char)31));

                        }

                        //MessageBox.Show(formaatCode);
                        string digiDriverText = line;
                        var newLabelFormat = new LabelFormat(doelFormaat, formaatCode, digiDriverText);

                        LabelFormats.Add(newLabelFormat);
                        DoelFormaten.Add(newLabelFormat.DoelFormaat);
                    }

                    readfile.Close();
                    RefreshRestFormaten();
                    RefreshLabelFormats();




                    //File.Copy(file, @"C:\DEC\Digidrv\Data\freeformats.dat", true);
                }
            }
            //code om labeldesigner te openen
            //string labelDesignerPath = @"c:\dec\label designer\label designer.exe";
            //if (File.Exists(labelDesignerPath))
            //{
            //    Process.Start(labelDesignerPath);
            //}
            //else
            //{
            //    MessageBox.Show(labelDesignerPath + " niet gevonden.");
            //}

        }

        private void btnSaveFormatFile_Click(object sender, EventArgs e)
        {
            if (CheckToCreate())
            {
                MessageBox.Show("Error : You can only export labelformats that already exist in the database !");
            }
            else
            {

                if (lstLabelFormats.Items.Count == 0)
                {
                    MessageBox.Show("Error : You need to add at least one labelformat !");
                }
                else
                {
                    string combinedFormats = WriteFormatFile();
                    string nlTexts;
                    string frTexts;

                    saveFormatsDialog.Filter = Resources.FrmLabelFormats_btnSaveFormatFile_Click_dat_bestanden_____dat;
                    saveFormatsDialog.Title = Resources.FrmLabelFormats_btnSaveFormatFile_Click_Bewaar_het_formaatbestand_dat_je_hebt_samengesteld;
                    saveFormatsDialog.FileName = "freeformats.dat";
                    saveFormatsDialog.InitialDirectory = @Folders.ServerDrive + @"\FreeFormats\";
                    DialogResult result = saveFormatsDialog.ShowDialog();
                    if (result != DialogResult.OK) return;

                    switch (lstLanguage.SelectedIndex)
                    {
                        default:
                            File.WriteAllText(saveFormatsDialog.FileName, combinedFormats);
                            break;
                        case 1:
                            if (sm5500labeltexts)
                            {
                                nlTexts = @Folders.Sm5500NederlandseTeksten;
                            }
                            else
                            {
                                nlTexts = @Folders.Sm5100NederlandseTeksten;
                            }

                            File.Copy(nlTexts, saveFormatsDialog.FileName, true);
                            File.AppendAllText(saveFormatsDialog.FileName, combinedFormats);
                            break;
                        case 2:
                            if (sm5500labeltexts)
                            {
                                frTexts = @Folders.Sm5500FranseTeksten;
                            }
                            else
                            {
                                frTexts = @Folders.Sm5100FranseTeksten;
                            }
                            File.Copy(frTexts, saveFormatsDialog.FileName, true);
                            File.AppendAllText(saveFormatsDialog.FileName, combinedFormats);
                            break;

                    }

                }

            }


        }




        private void saveLabelDesignerFormatsDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.Copy(@"c:\dec\digidrv\data\freeformats.dat", saveLabelDesignerFormatsDialog.FileName, true);
        }




        private void btnDoelFormaatWijzigen_Click(object sender, EventArgs e)
        {
            if (lstLabelFormats.Items.Count == 0)
            {
                MessageBox.Show("Error : There are no labelformats in your selection !");
            }
            else
            {

                if (lstLabelFormats.SelectedIndex != -1)
                {
                    RefreshRestFormaten();


                    var doelformaatWijzigen = new FrmDoelformaatWijzigen(RestDoelFormaten);
                    var result = doelformaatWijzigen.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        DoelFormaten.Remove(LabelFormats[lstLabelFormats.SelectedIndex].DoelFormaat);
                        LabelFormats[lstLabelFormats.SelectedIndex].ChangeDigidriverTextTargetFormat(doelformaatWijzigen.DoelFormaat);
                        LabelFormats[lstLabelFormats.SelectedIndex].DoelFormaat = doelformaatWijzigen.DoelFormaat;

                        DoelFormaten.Add(doelformaatWijzigen.DoelFormaat);
                        RefreshRestFormaten();
                        RefreshLabelFormats();

                    }


                }
                else
                {
                    MessageBox.Show("Error : Select the labelformat you want to change the target number from !");
                }

            }
        }













        private void btnTotalLabel_Click(object sender, EventArgs e)
        {



            if (Directory.Exists(Folders.ServerDrive) == false)
            {
                MessageBox.Show(Resources.FrmLabelFormats_btnToevoegen_Click_Geen_database_gevonden);
            }
            else
            {
                RefreshRestFormaten();

                if (RestDoelFormaten.Count == 0)
                {
                    MessageBox.Show("Error : 9 formats is the maximum number you can select !");
                }
                else
                {




                    var generateTotalLabelFormat = new FrmGenerateTotalLabelFormat(RestDoelFormaten);
                    var result = generateTotalLabelFormat.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:
                            {

                                if (generateTotalLabelFormat.NewFormat.FormaatCode != null)
                                {

                                    LabelFormats.Add(generateTotalLabelFormat.NewFormat);
                                    DoelFormaten.Add(generateTotalLabelFormat.NewFormat.DoelFormaat);
                                    RefreshRestFormaten();
                                    RefreshLabelFormats();
                                    sm5500labeltexts = generateTotalLabelFormat.sm5500LabelTexts;

                                }



                                break;
                            }
                    }


                }
            }
        }

        private void btnOpenInLabelDesigner_Click(object sender, EventArgs e)
        {
            if (lstLabelFormats.Items.Count == 0)
            {
                MessageBox.Show("Error : You need to add at least one labelformat !");
            }
            else
            {


                if (!File.Exists(Folders.LabelDesigner))
                {
                    MessageBox.Show("Error : Label Designer not found in " + Folders.LabelDesigner + " !");
                }
                else
                {


                    string combinedFormats = WriteFormatFile();

                    File.WriteAllText(Folders.LabelDesignerFormatFile, combinedFormats);

                    //code om labeldesigner te openen
                    //const string labelDesignerPath = @"c:\dec\label designer\label designer.exe";
                    if (File.Exists(Folders.LabelDesigner))
                    {
                        Process.Start(Folders.LabelDesigner);
                    }



                }
            }



        }

        private void btnImportFromLabelDesigner_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Folders.LabelDesignerFormatFile))
            {
                MessageBox.Show("Error : freeformats.dat not found in " + Folders.LabelDesignerFormatFile + " !");
            }
            else
            {


                string line;
                ClearLabelFormats();

                var readfile = new StreamReader(Folders.LabelDesignerFormatFile);
                while ((line = readfile.ReadLine()) != null)
                {

                    if (line != "")
                    {
                        string formaatCode;

                        int findCode = line.IndexOf("AA", StringComparison.Ordinal);
                        string doelFormaat = line.Substring(findCode + 2, 4);
                        int parseFormaat = int.Parse(doelFormaat);
                        parseFormaat = parseFormaat - 69;
                        doelFormaat = "F" + parseFormaat;
                        //MessageBox.Show(doelFormaat);
                        if (line.Substring(12, 2) != "AB")
                        {
                            formaatCode = "Undefined";
                        }
                        else
                        {


                            formaatCode = line.Substring(22, line.Length - 22);
                            formaatCode = formaatCode.Substring(0, formaatCode.IndexOf((char)31));
                        }
                        //MessageBox.Show(formaatCode);
                        string digiDriverText = line;
                        var newLabelFormat = new LabelFormat(doelFormaat, formaatCode, digiDriverText);

                        LabelFormats.Add(newLabelFormat);
                        DoelFormaten.Add(newLabelFormat.DoelFormaat);


                    }


                    readfile.Close();
                    RefreshRestFormaten();
                    RefreshLabelFormats();

                }
            }

        }

        private bool CheckToCreate()
        {
            bool toCreate;
            toCreate = false;
            foreach (LabelFormat item in LabelFormats)
            {
                if (item.ToString().Contains("_ToCreate"))
                {
                    toCreate = true;
                }

            }
            return toCreate;

        }

        private void btnSendWithDigiDriver_Click(object sender, EventArgs e)
        {
            if (CheckToCreate())
            {
                MessageBox.Show("Error : You can only export labelformats that already exist in the database !");
            }
            else
            {



                if (lstLabelFormats.Items.Count == 0)
                {
                    MessageBox.Show("Error : You need to add at least one labelformat !");
                }
                else
                {


                    if (!File.Exists(Folders.DigiDriver))
                    {
                        MessageBox.Show("Error : Digidriver not found in " + Folders.DigiDriver + " !");
                    }
                    else
                    {
                        string nlTexts;
                        string frTexts;
                        switch (lstLanguage.SelectedIndex)
                        {
                            case 0:
                                File.WriteAllText(Folders.SendDat, WriteFormatFile());
                                //File.Copy(WriteFormatFile(), Folders.SendDat, true);
                                break;
                            case 1:
                                if (sm5500labeltexts)
                                {
                                    nlTexts = @Folders.Sm5500NederlandseTeksten;
                                }
                                else
                                {
                                    nlTexts = @Folders.Sm5100NederlandseTeksten;
                                }

                                File.Copy(nlTexts, Folders.SendDat, true);
                                File.AppendAllText(Folders.SendDat, WriteFormatFile());
                                break;
                            case 2:
                                if (sm5500labeltexts)
                                {
                                    frTexts = @Folders.Sm5500FranseTeksten;
                                }
                                else
                                {
                                    frTexts = @Folders.Sm5100FranseTeksten;
                                }

                                File.Copy(frTexts, Folders.SendDat, true);
                                File.AppendAllText(Folders.SendDat, WriteFormatFile());
                                break;

                        }


                        // string startfile = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @"\freeformats.dat";
                        File.Copy(Folders.StartDatServer, Folders.StartDat, true);

                    }




                }




            }


        }

        private void btnConfigureDigiDriver_Click(object sender, EventArgs e)
        {
            //code om digidriver te starten
            if (File.Exists(Folders.DigiDriverConfiguration))
            {
                Process.Start(Folders.DigiDriverConfiguration);
            }
            else
            {
                MessageBox.Show("Error: " + Folders.DigiDriverConfiguration + " not found !");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Customer_Order(true);
        }

        private void Customer_Order(bool customer)
        {
            if (Directory.Exists(Folders.ServerDrive) == false)
            {
                MessageBox.Show(Resources.FrmLabelFormats_btnToevoegen_Click_Geen_database_gevonden);
            }
            else
            {
                RefreshRestFormaten();

                if (RestDoelFormaten.Count == 0)
                {
                    MessageBox.Show("Error : 9 formats is the maximum number you can select !");
                }
                else
                {




                    var customerLabelFormat = new frmCustomerLabels(RestDoelFormaten, customer);
                    var result = customerLabelFormat.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:
                            {

                                if (customerLabelFormat.NewFormat.FormaatCode != null)
                                {

                                    LabelFormats.Add(customerLabelFormat.NewFormat);
                                    DoelFormaten.Add(customerLabelFormat.NewFormat.DoelFormaat);
                                    RefreshRestFormaten();
                                    RefreshLabelFormats();
                                    sm5500labeltexts = customerLabelFormat.sm5500LabelTexts;

                                }



                                break;
                            }
                    }


                }
            }
        }

        //private void btnSendDefaultData_Click(object sender, EventArgs e)
        //{






        //    List<string> devices = new List<string>();
        //    devices.Add("Sm5500");
        //    devices.Add("Sm5100");
        //    frmSelectDevice selectDevice = new frmSelectDevice(devices);
        //    var result = selectDevice.ShowDialog();
        //    switch (result)
        //    {
        //        case DialogResult.OK:
        //            {

        //                if (selectDevice.Sm5500)
        //                {
        //                    if (File.Exists(Folders.Sm5500DefaultData))
        //                    {
        //                        if (File.Exists(Folders.SendDat))
        //                        {
        //                            File.Copy(Folders.Sm5500DefaultData, Folders.SendDat, true);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.SendDat + " kan niet worden aangemaakt.");
        //                        }

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Fout: " + Folders.Sm5500DefaultData + " niet gevonden");
        //                    }


        //                }
        //                else
        //                {
        //                    if (File.Exists(Folders.Sm5100DefaultData))
        //                    {
        //                        if (File.Exists(Folders.SendDat))
        //                        {
        //                            File.Copy(Folders.Sm5100DefaultData, Folders.SendDat, true);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.SendDat + " kan niet worden aangemaakt.");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Fout: " + Folders.Sm5100DefaultData + " niet gevonden");
        //                    }
        //                }
        //                if (File.Exists(Folders.StartDatServer))
        //                { // string startfile = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @"\freeformats.dat";
        //                    File.Copy(Folders.StartDatServer, Folders.StartDat, true);
        //                    //code om digidriver te starten

        //                    Process.Start(Folders.DigiDriver);
        //                }
        //                else
        //                {
        //                    MessageBox.Show(Folders.DigiDriver + Resources.FrmLabelFormats_btnOpenInLabelDesigner_Click__niet_gevonden_);
        //                }




        //                break;
        //            }
        //    }








        //}

        //private void btnPrintScanSheet_Click(object sender, EventArgs e)
        //{
        //    frmScanSheets scanSheets = new frmScanSheets();
        //    var result = scanSheets.ShowDialog();

        //    switch (result)
        //    {
        //        case DialogResult.OK:
        //            {
        //                //code om de juiste sheet af te drukken
        //                switch (scanSheets.Afmeting)
        //                {
        //                    case "40x46":
        //                        if (File.Exists(Folders.ScanSheet40x46))
        //                        {
        //                            Process.Start(Folders.ScanSheet40x46);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet40x46 + " niet gevonden");
        //                        }

        //                        break;
        //                    case "40x62":
        //                        if (File.Exists(Folders.ScanSheet40x62))
        //                        {
        //                            Process.Start(Folders.ScanSheet40x62);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet40x62 + " niet gevonden");
        //                        }

        //                        break;
        //                    case "60x49":
        //                        if (File.Exists(Folders.ScanSheet60x49))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x49);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x49 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x60":
        //                        if (File.Exists(Folders.ScanSheet60x60))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x60);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x60 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x62":
        //                        if (File.Exists(Folders.ScanSheet60x62))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x62);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x62 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x70":
        //                        if (File.Exists(Folders.ScanSheet60x70))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x70);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x70 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x73":
        //                        if (File.Exists(Folders.ScanSheet60x73))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x73);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x73 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x80":
        //                        if (File.Exists(Folders.ScanSheet60x80))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x80);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x80 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x90":
        //                        if (File.Exists(Folders.ScanSheet60x90))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x90);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x90 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x100":
        //                        if (File.Exists(Folders.ScanSheet60x100))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x100);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x100 + " niet gevonden");
        //                        }
        //                        break;
        //                    case "60x120":
        //                        if (File.Exists(Folders.ScanSheet60x120))
        //                        {
        //                            Process.Start(Folders.ScanSheet60x120);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Fout: " + Folders.ScanSheet60x120 + " niet gevonden");
        //                        }
        //                        break;
        //                    default:
        //                        break;
        //                }

        //            }
        //            break;
        //    }
        //}

        private void btnOpenExcelList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");

            //DialogResult result = openExcelList.ShowDialog();
            //if (result == DialogResult.OK) // Test result.
            //{


            //    // Get the file we are going to process

            //    var existingFile = new FileInfo(openExcelList.FileName);

            //    // Open and read the XlSX file.

            //    using (var package = new ExcelPackage(existingFile))
            //    {

            //        // Get the work book in the file

            //        ExcelWorkbook workBook = package.Workbook;

            //        if (workBook != null)
            //        {

            //            if (workBook.Worksheets.Count > 0)
            //            {
            //                ClearLabelFormats();

            //                // Get the first worksheet

            //                ExcelWorksheet currentWorksheet = workBook.Worksheets.First();



            //                // read some data
            //                string unfoundFormats = "Formaten die je nog moet aanmaken :";

            //                string labelF1 = currentWorksheet.Cells[1, 21].Value.ToString();
            //                LabelFormat F1label = new LabelFormat("F1", labelF1);
            //                if (F1label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F1label);
            //                    DoelFormaten.Add("F1");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F1 : " + labelF1;
            //                }
            //                string labelF2 = currentWorksheet.Cells[2, 21].Value.ToString();
            //                LabelFormat F2label = new LabelFormat("F2", labelF2);
            //                if (F2label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F2label);
            //                    DoelFormaten.Add("F2");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F2 : " + labelF2;
            //                }
            //                string labelF3 = currentWorksheet.Cells[3, 21].Value.ToString();
            //                LabelFormat F3label = new LabelFormat("F3", labelF3);
            //                if (F3label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F3label);
            //                    DoelFormaten.Add("F3");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F3 : " + labelF3;
            //                }
            //                string labelF4 = currentWorksheet.Cells[4, 21].Value.ToString();
            //                LabelFormat F4label = new LabelFormat("F4", labelF4);
            //                if (F4label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F4label);
            //                    DoelFormaten.Add("F4");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F4 : " + labelF4;
            //                }
            //                string labelF5 = currentWorksheet.Cells[5, 21].Value.ToString();
            //                LabelFormat F5label = new LabelFormat("F5", labelF5);
            //                if (F5label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F5label);
            //                    DoelFormaten.Add("F5");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F5 : " + labelF5;
            //                }
            //                string labelF6 = currentWorksheet.Cells[6, 21].Value.ToString();
            //                LabelFormat F6label = new LabelFormat("F6", labelF6);
            //                if (F6label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F6label);
            //                    DoelFormaten.Add("F6");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F6 : " + labelF6;
            //                }
            //                string labelF7 = currentWorksheet.Cells[7, 21].Value.ToString();
            //                LabelFormat F7label = new LabelFormat("F7", labelF7);
            //                if (F7label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F7label);
            //                    DoelFormaten.Add("F7");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F7 : " + labelF7;
            //                }
            //                string labelF8 = currentWorksheet.Cells[8, 21].Value.ToString();
            //                LabelFormat F8label = new LabelFormat("F8", labelF8);
            //                if (F8label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F8label);
            //                    DoelFormaten.Add("F8");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F8 : " + labelF8;
            //                }
            //                string labelF9 = currentWorksheet.Cells[9, 21].Value.ToString();
            //                LabelFormat F9label = new LabelFormat("F9", labelF9);
            //                if (F9label.DigiDriverText != "")
            //                {
            //                    LabelFormats.Add(F9label);
            //                    DoelFormaten.Add("F9");
            //                    RefreshRestFormaten();
            //                    RefreshLabelFormats();

            //                }
            //                else
            //                {
            //                    unfoundFormats = unfoundFormats + Environment.NewLine + "F9 : " + labelF9;
            //                }





            //                MessageBox.Show(unfoundFormats);


            //                if (labelF1.Substring(6) == "Sm5500")
            //                {
            //                    sm5500labeltexts = true;
            //                }
            //                else
            //                {
            //                    sm5500labeltexts = false;
            //                }



            //            }
            //        }
            //    }


            //}
        }

        private void btnSalesMenLabel_Click(object sender, EventArgs e)
        {
            this.Customer_Order(false);
        }
    }






}
