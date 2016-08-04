using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFormats
{
    class Program
    {

        public int originalformat { get; set; }



        static void Main(string[] args)
        {
            FileInfo originalFile = new FileInfo(@"C:\LabelTest\input\freeformats.dat");

            Console.WriteLine("Read original file ---- ok");


            string text = File.ReadAllText(originalFile.ToString());

            string device = "Sm5500";

            GenerateNewFormat(device,text, "60");
            GenerateNewFormat(device,text, "62");
            GenerateNewFormat(device,text, "70");
            GenerateNewFormat(device,text, "73");
            GenerateNewFormat(device,text, "80");
            GenerateNewFormat(device,text, "90");
            GenerateNewFormat(device,text, "100");
            GenerateNewFormat(device,text, "120");

           

        }

        public static void GenerateNewFormat(string device,string text,string height)
    {
        var textArray = text.Split((char)31);


        //change height of format in name
        textArray[2] = textArray[2].Replace("49", height);

        //change height of format
        textArray[3] = textArray[3].Replace("049", height.PadLeft(3, '0'));

        //change height of format
        textArray[6] = textArray[6].Replace("049", height.PadLeft(3, '0'));



        var labelFieldsArray = textArray[7].Split('~');

        var targetShopName = "0340";
        var targetArticleName = "0001";
        var targetIng = "0341";
        // var results = Array.IndexOf(labelFieldsArray, .Contains(target));

        int augment = (int.Parse(height) - 49) * 100;

        for (int i = 0; i < labelFieldsArray.Count(); i++)
        {
            if (labelFieldsArray[i].Substring(0, 4) == targetShopName | labelFieldsArray[i].Substring(0, 4) == targetArticleName)
            {
                string toreplace = labelFieldsArray[i].Substring(10, 5);
               
                labelFieldsArray[i] = labelFieldsArray[i].Replace(toreplace, (int.Parse(toreplace) + augment).ToString().PadLeft(5,'0'));
            }
            if (labelFieldsArray[i].Substring(0, 4) == targetIng)
            {
                string toreplace = labelFieldsArray[i].Substring(22, 5);
               
                labelFieldsArray[i] = labelFieldsArray[i].Replace(toreplace, (int.Parse(toreplace) + augment).ToString().PadLeft(5,'0'));
            }
        }

        //change y axis of articlename
        // restOfArray = string.Join(" ", array.Skip(1));

        textArray[7] = string.Join("~", labelFieldsArray);

        string folder = "60x" + height;
        string name = textArray[2].Substring(10);

        Directory.CreateDirectory(@"C:\LabelTest\"  + folder + @"\" +  device + "_" + name);

        char c = (char)31;

        string newtext = string.Join(c.ToString(), textArray);

        File.WriteAllText(@"C:\LabelTest\" + folder + @"\" + device + "_" + name + @"\freeformats.dat", newtext);

        Console.WriteLine(folder + " created....ok");
        Console.ReadKey();

        
    }


    }
}
