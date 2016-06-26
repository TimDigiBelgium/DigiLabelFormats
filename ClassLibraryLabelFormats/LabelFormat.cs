using System;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;


namespace ClassLibraryLabelFormats
{
    public class LabelFormat
    {
        public string FormaatCode { get; set; }

        public string DoelFormaat { get; set; }

        public string ServerDrive { get; set; }

        public string DigiDriverText { get; set; }

        public string Omschrijving { get; set; }

        public bool Sm5500LabelTexts { get; set; }

        public string strToCreate { get; set; }

        public Image LabelImageKg { get; set; }

        public Image LabelImageStk { get; set; }

        public string Device { get; set; }

        public bool OK { get; set; }

        public bool  ToCreate { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Size { get; set; }

        public string Error { get; set; }



        public LabelFormat()
        {
            FormaatCode = string.Empty;
            DoelFormaat = string.Empty;
            DigiDriverText = string.Empty;
            Omschrijving = string.Empty;
            ToCreate = false;
        }

        //constructor bij standaard formaten
        public LabelFormat(string formaatCode)
        {
            //DoelFormaat = doelFormaat;
            FormaatCode = formaatCode;
           // DigiDriverText = AssignDigidriverText(formaatCode);
            Omschrijving = MaakOmschrijving(formaatCode);

            if (formaatCode.Contains("Infotag"))
            {
                this.Size = formaatCode.Substring(7, 6).Replace("_", "");
                // this.Width = Convert.ToInt32(Size.Substring(0, 2));
                //this.Height = Convert.ToInt32(Size.Substring(3));
            }
            else if (!formaatCode.Contains("Linerless"))
            {
                this.Size = formaatCode.Substring(7, 6).Replace("_", "");
                this.Width = Convert.ToInt32(Size.Substring(0, 2));
                this.Height = Convert.ToInt32(Size.Substring(3));
            }
            AssignImages();
        }

        //constructor bij standaard formaten
        public LabelFormat(string doelFormaat, string formaatCode)
        {   
            if(formaatCode!=""){
            DoelFormaat = doelFormaat;
            FormaatCode = formaatCode;
            DigiDriverText = AssignDigidriverText(formaatCode);
            Omschrijving = MaakOmschrijving(formaatCode);
            if (formaatCode.Contains("Infotag"))
            {
                this.Size = formaatCode.Substring(7, 6).Replace("_", "");
               // this.Width = Convert.ToInt32(Size.Substring(0, 2));
                //this.Height = Convert.ToInt32(Size.Substring(3));
            }
            else if (!formaatCode.Contains("Linerless"))
            {
                this.Size = formaatCode.Substring(7, 6).Replace("_", "");
                this.Width = Convert.ToInt32(Size.Substring(0, 2));
                this.Height = Convert.ToInt32(Size.Substring(3));
            }
           
            AssignImages();
        }
        }

        //constructor bij standaard formaten
        public LabelFormat(string doelFormaat, string formaatCode, string omschrijving)
        {
            if (formaatCode != "")
            {
                DoelFormaat = doelFormaat;
                FormaatCode = formaatCode;
                DigiDriverText = AssignDigidriverText(formaatCode);
                Omschrijving = omschrijving;
                if (formaatCode.Contains("Infotag"))
                {
                    this.Size = formaatCode.Substring(7, 6).Replace("_", "");
                    // this.Width = Convert.ToInt32(Size.Substring(0, 2));
                    //this.Height = Convert.ToInt32(Size.Substring(3));
                }
                else if (!formaatCode.Contains("Linerless"))
                {
                    this.Size = formaatCode.Substring(7, 6).Replace("_", "");
                    this.Width = Convert.ToInt32(Size.Substring(0, 2));
                    this.Height = Convert.ToInt32(Size.Substring(3));
                }

                AssignImages();
            }
        }

        //constructor bij standaard formaten
        public LabelFormat(string doelFormaat, string formaatCode, Image image)
        {
            DoelFormaat = doelFormaat;
            FormaatCode = formaatCode;
            this.LabelImageKg = image; 
            DigiDriverText = AssignDigidriverText(formaatCode);
            Omschrijving = MaakOmschrijving(formaatCode);
        }

        //constructor bij standaard formaten
        public LabelFormat(string doelFormaat, string formaatCode, bool tocreate, Image image)
        {
            DoelFormaat = doelFormaat;
            FormaatCode = formaatCode;
            this.LabelImageKg = image;

            Omschrijving = MaakOmschrijving(formaatCode); 
            if (tocreate)
            {
                this.strToCreate = "_ToCreate";

                DigiDriverText = AssignDigidriverText("Sm5500_60x49_0");
            }
            else
            {
                this.strToCreate = "";
                DigiDriverText = AssignDigidriverText(formaatCode);
               
               
               
            }
          
         
        }

        ////constructor bij externe formaten
        //public LabelFormat(string doelFormaat, string formaatCode, string digiDriverText)
        //{
        //    DoelFormaat = doelFormaat;
        //    FormaatCode = formaatCode;
        //    DigiDriverText = digiDriverText;
        //    Omschrijving = "";
        //}

        public LabelFormat(string doelFormaat, string formaatCode, string omschrijving, string digiDriverText)
        {
            DoelFormaat = doelFormaat;
            FormaatCode = formaatCode;
            DigiDriverText = digiDriverText;
            Omschrijving = omschrijving;
        }

        public override string ToString()
        {

            string assemble = "";
            if (DoelFormaat!=null)
            {
                return DoelFormaat + ": " + FormaatCode + this.strToCreate;
            }
            else
            {
                return FormaatCode;
            }
            return assemble;
            
        }

        public string ToStringShort()
        {
            return FormaatCode;
        }

       
        private string AssignDigidriverText(string formaatCode)
        {
            string digiDriverFilePath = "";
            string digidriverText = "";

            //bool linerless = false;


            if (formaatCode!="")
            {
                
           

            if (formaatCode.Substring(0, 8) == "Customer"|| formaatCode.Substring(0, 8) == "Salesmen")
            {
                string customerfolders = formaatCode.Replace("_", @"\");

              
                    digiDriverFilePath = @Folders.rootMap;
             
           
                
                

             
                    digiDriverFilePath = digiDriverFilePath + @"\" + customerfolders;
                

                //digiDriverFilePath = digiDriverFilePath + @"\" + formaatCode + @"\freeformats.dat"; ;

                digiDriverFilePath = digiDriverFilePath + @"\freeformats.dat"; 
                }
            else
            {
                int codeLength = 5;
                int codesize = 7;
                int codedevice = 6;
                int codesizestart = 7;


               

                if (formaatCode.Substring(13, 1).Contains("_"))
                {
                    codeLength = 6;
                }

                if (formaatCode.Substring(7).Contains("Linerless"))
                {
                    codeLength = 9;
                   // linerless = true;
                }

                if (this.FormaatCode.Substring(0).Contains("Infotag"))
                {
                    string part = FormaatCode.Substring(8, FormaatCode.Length - 8);
                    int split = part.IndexOf("_");
                    codeLength = split;
                    codedevice = FormaatCode.IndexOf("_");
                    codesize = 7;
                    codesizestart = 8;
                    //infotag = true;
                }



                digiDriverFilePath = @Folders.ServerDrive + @"\" + @FormaatCode.Substring(0, codedevice) + @"\" + @FormaatCode.Substring(codesizestart, codeLength) + @"\" + @FormaatCode + @"\freeformats.dat"; ;


        
                //digiDriverFilePath = @Folders.ServerDrive + @"\" + @formaatCode.Substring(0, 6) + @"\" + @formaatCode.Substring(7, codeLength) + @"\" + @formaatCode + @"\freeformats.dat";


            }



           
            if (File.Exists(digiDriverFilePath))
            {

                digidriverText = File.ReadAllText(digiDriverFilePath);
                digidriverText = digidriverText.Replace("AA0070", changeTargetFormat(DoelFormaat));

            }
            }

            return digidriverText;
        }

        public void ChangeDigidriverTextTargetFormat(string doelFormaat)
        {
            DigiDriverText = DigiDriverText.Replace(DigiDriverText.Substring(DigiDriverText.IndexOf("AA00"), 6), changeTargetFormat(doelFormaat));
        }

        public void ChangeDigidriverTextFormaatCode(string formaatCode)
        {
            DigiDriverText = DigiDriverText.Replace(FormaatCode, formaatCode);
        }


        private string changeTargetFormat(string targetFormat)
        {


           targetFormat = targetFormat.Substring(1);
         

            int targetNumber = 69 + int.Parse(targetFormat);

            string targetFormatCode = "AA" + targetNumber.ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');
            return targetFormatCode;
        }

        private static string MaakOmschrijving(string labelformatCode)
        {
            string omschrijving = "";
            if (labelformatCode!="")
            {
                
            
            if (labelformatCode.Substring(0, 8) != "Customer" && labelformatCode.Substring(0, 8) != "Salesmen")
            {

                labelformatCode = labelformatCode.Replace("_ToCreate", "");

                if (!labelformatCode.Contains("Totaal"))
                {


                    
                    if (!labelformatCode.Substring(13).Contains("A0"))
                    {
                        omschrijving = omschrijving + "Artikelnaam" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("W0"))
                    {
                        omschrijving = omschrijving + "Gewicht" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("Q0"))
                    {
                        omschrijving = omschrijving + "Aantal" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("U0"))
                    {
                        omschrijving = omschrijving + "Eenheidsprijs" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("T0"))
                    {
                        omschrijving = omschrijving + "Totaalprijs" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("S0"))
                    {
                        omschrijving = omschrijving + "Winkelnaam" + Environment.NewLine;
                    }

                    if (!labelformatCode.Substring(13).Contains("I0"))
                    {
                        omschrijving = omschrijving + "Ingrediënten" + Environment.NewLine;
                    }



                    if (labelformatCode.Substring(13).Contains("Bc"))
                    {
                        omschrijving = omschrijving + "Barcode" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Pd"))
                    {
                        omschrijving = omschrijving + "Inpakdatum" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Sm"))
                    {
                        omschrijving = omschrijving + "Speciale boodschap" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Ud"))
                    {
                        omschrijving = omschrijving + "TGT datum" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Sd"))
                    {
                        omschrijving = omschrijving + "UVD datum" + Environment.NewLine;
                    }
                    
                    if (labelformatCode.Substring(13).Contains("Op"))
                    {
                        omschrijving = omschrijving + "Bediende" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Pn"))
                    {
                        omschrijving = omschrijving + "Plu nummer" + Environment.NewLine;
                    }

                    if (labelformatCode.Substring(13).Contains("Sl"))
                    {
                        omschrijving = omschrijving + "Winkel logo klein (naast winkelnaam)" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Ll"))
                    {
                        omschrijving = omschrijving + "Winkel logo groot" + Environment.NewLine;
                    }

                  
                    if (labelformatCode.Substring(13).Contains("Tr"))
                    {
                        omschrijving = omschrijving + "Traceerbaarheid" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Cw"))
                    {
                        omschrijving = omschrijving + "Kipwaarschuwing" + Environment.NewLine;
                    }
                   

                    if (labelformatCode.Substring(13).Contains("Tf"))
                    {
                        omschrijving = omschrijving + "Vaste bewaartemperatuur" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Tv"))
                    {
                        omschrijving = omschrijving + "Variabele bewaartemperatuur" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Tt"))
                    {
                        omschrijving = omschrijving + "(min. en max.)" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Ht"))
                    {
                        omschrijving = omschrijving + "Tekstveld : 'Verhitten tot in de kern.'" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Bi"))
                    {
                        omschrijving = omschrijving + "Tekstveld : 'Kalfsvlees jonger dan 8 maanden.'" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Ni"))

                        omschrijving = omschrijving + "Tekstveld : 'DIT PRODUCT KAN SPOREN BEVATTEN'" + Environment.NewLine;
                     //   omschrijving = omschrijving + " VAN NOTEN EN SESAM.'" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Ci"))
                    {
                        omschrijving = omschrijving + "Tekstveld : 'Mits gekoeld bewaard bij -18°C'" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Cf"))
                    {
                        omschrijving = omschrijving + "Tekstveld : 'Een ontdooid product niet opnieuw invriezen.'" + Environment.NewLine;
                    }
                    if (labelformatCode.Substring(13).Contains("Pr"))
                    {
                        omschrijving = omschrijving + "Tekstveld : 'Aanbieding'" + Environment.NewLine;
                    }


            }
            if (labelformatCode.Contains("Totaal"))
            {


                if (labelformatCode.Substring(20).Contains("Bc"))
                {
                    omschrijving = omschrijving + "Barcode" + Environment.NewLine;
                }
                if (labelformatCode.Substring(20).Contains("Pd"))
                {
                    omschrijving = omschrijving + "Inpakdatum" + Environment.NewLine;
                }
                if (labelformatCode.Substring(20).Contains("Qu"))
                {
                    omschrijving = omschrijving + "Aantal" + Environment.NewLine;
                }
                if (labelformatCode.Substring(20).Contains("Wt"))
                {
                    omschrijving = omschrijving + "Gewicht" + Environment.NewLine;
                }
                if (labelformatCode.Substring(20).Contains("Op"))
                {
                    omschrijving = omschrijving + "Verkoper" + Environment.NewLine;
                }
            }
            }
            

            return omschrijving;

        }

        private void AssignImages()
        {
            int codeLength = 5;
            int codesize = 7;
            int codedevice = 6;
            int codesizestart = 7;

            bool linerless = false;
            bool infotag = false;

            if (this.FormaatCode.Substring(13,1).Contains("_"))
            {
                codeLength = 6;
            }

            //if (this.FormaatCode.Substring(21).Contains("_"))
            //{
            //    codeLength = 6;
            //}


            if (this.FormaatCode.Substring(7).Contains("Linerless"))
            {
                codeLength = 9;
                linerless = true;
            }

            if (this.FormaatCode.Substring(0).Contains("Infotag"))
            {
                string part = FormaatCode.Substring(8, FormaatCode.Length - 8);
                int split = part.IndexOf("_");
                codeLength = split;
                codedevice = FormaatCode.IndexOf("_");
                codesize = 7;
                codesizestart = 8;
                infotag = true;
            }



            string imageFolder = @Folders.ServerDrive + @"\" + @FormaatCode.Substring(0, codedevice) + @"\" + @FormaatCode.Substring(codesizestart, codeLength) + @"\" + @FormaatCode ;

        
            string strImageKg = imageFolder + @"\" + "kg.png";
            string strImageStk = imageFolder + @"\" + "stk.png";
            string strImageNotFound = imageFolder + @"\" + "error.txt";

            //int maxBreedte = 300;
            //int maxHoogte = 300;

            int imageWidth;
            int imageHeight;


            //pctPieces.Width = breedte;
            //pctWeight.Width = breedte;
            //pctPieces.Height = hoogte;
            //pctWeight.Height = hoogte;


            if (File.Exists(strImageKg))
            {
                var imageKg = Image.FromFile(strImageKg);
                if (infotag == true)
                {
                    //imageWidth = this.Width * 4;
                    //imageHeight = this.Height * 4;
                    this.LabelImageKg = imageKg;

                }
                else
                { 
                if (linerless == false)
                {
                    imageWidth = this.Width * 4;
                    imageHeight = this.Height * 4;
                    this.LabelImageKg = StaticMethods.ScaleImage(imageKg, imageWidth, imageHeight);

                }
                else
                {
                    imageWidth = Convert.ToInt32(60 * 4);
                    imageHeight = Convert.ToInt32(120 * 4); ;
                    this.LabelImageKg = StaticMethods.ScaleImage(imageKg, imageWidth, imageHeight);

                }
            }
               

               

               
                this.OK = true;
                this.ToCreate = false;
                this.strToCreate = "";
            }
            else
            {
                if (File.Exists(strImageNotFound))
                {
                    this.Error = File.ReadAllText(strImageNotFound);
                    this.LabelImageKg = null;
                    this.ToCreate = false;
                    this.strToCreate = "";
                }
                else
                {
                    this.LabelImageKg = null;
                    this.ToCreate = true;
                    this.strToCreate = "_ToCreate";
                }
                this.OK = false;



            }
            if (File.Exists(strImageStk))
            {


                var imageStk = Image.FromFile(strImageStk);


                if (linerless == false)
                {
                    imageWidth = this.Width * 4;
                    imageHeight = this.Height * 4;

                }
                else
                {
                    imageWidth = Convert.ToInt32(60 * 4);
                    imageHeight = Convert.ToInt32(120 * 4); ;

                }

               this.LabelImageStk = StaticMethods.ScaleImage(imageStk, imageWidth, imageHeight);
            }
            else
            {

                this.LabelImageStk = null;


            }
        }
       



    }
}
