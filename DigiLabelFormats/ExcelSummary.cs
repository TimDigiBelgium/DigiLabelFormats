using ClassLibraryLabelFormats;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiLabelFormats
{
    class ExcelSummary
    {
        public ExcelPackage Pck { get; set; }

        public List<LabelFormat> LabelFormats { get; set; }


        public ExcelSummary(string fileName, List<LabelFormat> labelFormats)
        {
            this.LabelFormats = labelFormats;
            FileInfo newFile = new FileInfo(fileName);
            if (newFile.Exists)
            {
                
                newFile.Delete();
            }
            Pck = new ExcelPackage(newFile);
            
           
         
            addSheets();

           
            Pck.Save();
          
            
        }

       




        private void addSheets()
        {
          //ExcelWorksheet ws = Pck.Workbook.Worksheets.Add("Algemene Info");

          //ws.Column(1).Width = 65;
          //ws.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
          //ws.Cells[1, 1].Style.WrapText = true;
          //ws.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
          //ws.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender);
          //ws.Cells[1, 1].Value = "OVERZICHT GEWENSTE ETIKETFORMATEN";

          //for (int i = 0; i < LabelFormats.Count(); i++)
          //{
          
          //ws.Cells[i + 2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
          //ws.Cells[i + 2, 1].Style.WrapText = true;
          //ws.Cells[i + 2, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
          //ws.Cells[i + 2, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.White);
          //ws.Cells[i + 2, 1].Value = LabelFormats[i].ToString();
          //}

          //int teller;
          //  teller = LabelFormats.Count + 2;

          //ws.Cells[teller, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
          //ws.Cells[teller, 1].Style.WrapText = true;
          //ws.Cells[teller, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
          //ws.Cells[teller, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender);
          //ws.Cells[teller, 1].Value = "EXTRA OPMERKINGEN :";

          foreach (LabelFormat item in LabelFormats)
          {
              ExcelWorksheet wslbl = Pck.Workbook.Worksheets.Add("Etiketformaat " + item.DoelFormaat.ToString());
              wslbl.Column(1).Width = 66;
              wslbl.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
              wslbl.Cells[1, 1].Style.WrapText = true;
              wslbl.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
              wslbl.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender);
              wslbl.Cells[1, 1].Value = item.ToString();
              wslbl.Cells[2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
              wslbl.Cells[2, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
              wslbl.Cells[2, 1].Style.WrapText = true;
              //wslbl.Cells[2, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
              //wslbl.Cells[2, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.White);
              wslbl.Cells[2, 1].Value = item.Omschrijving;
              wslbl.Cells[1, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
              wslbl.Cells[1, 3].Style.WrapText = true;
              wslbl.Cells[1, 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
              wslbl.Cells[1, 3].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender);
              wslbl.Cells[1, 3].Value = "EXTRA OPMERKINGEN :";
              wslbl.Cells[1, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
              wslbl.Cells[1, 2].Style.WrapText = true;
              wslbl.Cells[1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
              wslbl.Cells[1, 2].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender);
              wslbl.Cells[1, 2].Value = "VOORBEELD AFBEELDING:";
              wslbl.Column(3).Width = 50;
              wslbl.Column(2).Width = 44.86 ;
              wslbl.Row(2).Height = 356.25;
              wslbl.Cells[2, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
              wslbl.Cells[2, 2].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);


              //picture.SetPosition(a * 5, 0, 2, 0);
              ExcelPicture excelImage = null;
              if (item.LabelImageKg != null)
              {
                  
                  excelImage = wslbl.Drawings.AddPicture(item.DoelFormaat.ToString() + "Image", item.LabelImageKg);
                  excelImage.From.Column = 1;
                  excelImage.From.Row = 1;
                  excelImage.SetSize(100);
                 // excelImage.SetSize(item.LabelImage.Height,item.LabelImage.Width);
                  // 2x2 px space for better alignment
                 // excelImage.From.ColumnOff = Pixel2MTU(2);
                 // excelImage.From.RowOff = Pixel2MTU(2);
              }
              else
              {
                  wslbl.Cells[2, 2].Style.Font.Size = 25;
                  wslbl.Cells[2, 2].Style.Font.Color.SetColor(System.Drawing.Color.White);
                  wslbl.Cells[2, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                  wslbl.Cells[2, 2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                  wslbl.Cells[2, 2].Style.WrapText = true;
                  wslbl.Cells[2, 2].Value = "GEEN AFBEELDING" + Environment.NewLine + "BESCHIKBAAR";
              }



              

          }
            
            
          
            

        }

     


    }
}
