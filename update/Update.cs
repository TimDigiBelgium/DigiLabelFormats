using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace update
{
    class Update
    {
        static void Main(string[] args)
        {

            string ServerDrive;

            if (Directory.Exists(@"Y:\production\converters\DigiLabelFormats\"))
            {
                ServerDrive = @"Y:\production\converters\DigiLabelFormats\";
            }
            else
            {
                ServerDrive = @"c:\production\converters\DigiLabelFormats\";
            }
            //Console.WriteLine("Voer uw paswoord in:");
            //string password = Console.ReadLine();
            //bool passWordOk = false;
            //switch (password)
            //{
            //    case "test":
            //        passWordOk = true;
            //        break;
            //    default:
            //        break;
            //}

            //if (passWordOk==false)
            //{
            //    Console.WriteLine("Paswoord incorrect. Stuur een mail naar t.quirynen@digi.eu om een paswoord aan te vragen.");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}

            if (KillProcess("DigiLabelFormats"))
            {
                Console.WriteLine("DigiLabelFormats sluiten...");
            }
            //else
            //{
            //    Console.WriteLine("Sluiten DigiLabelFormats is mislukt");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}
            string sourceDirectory = @ServerDrive + @"\Program";
            string targetDirectory = @"c:\DigiLabelFormats\";

            if (update_DigiLabelFormats(sourceDirectory,targetDirectory))
            {
                Console.WriteLine("DigiLabelFormats applicatie is bijgewerkt.");   
            }
            else
            {
                Console.WriteLine("Update DigiLabelFormats is mislukt");
                Console.ReadLine();
                Environment.Exit(0);
            }
            sourceDirectory = @ServerDrive + @"\Docs";
            targetDirectory = @"c:\DigiLabelFormats\Docs";

            if (update_DigiLabelFormats(sourceDirectory, targetDirectory))
            {
                Console.WriteLine("Documentatie is bijgewerkt.");
            }
            else
            {
                Console.WriteLine("Update Documentatie is mislukt");
                Console.ReadLine();
                Environment.Exit(0);
            }
            sourceDirectory = @ServerDrive + @"\Database";
            targetDirectory = @"c:\DigiLabelFormats\Database\";

            if (update_DigiLabelFormats(sourceDirectory, targetDirectory))
            {
                Console.WriteLine("Database labelformaten is bijgewerkt.");
            }
            else
            {
                Console.WriteLine("Update database is mislukt");
                Console.ReadLine();
                Environment.Exit(0);
            }
            sourceDirectory = @ServerDrive + @"\Klanten";
            targetDirectory = @"c:\DigiLabelFormats\Klanten\";

            if (update_DigiLabelFormats(sourceDirectory, targetDirectory))
            {
                Console.WriteLine("Database klanten labelformaten is bijgewerkt.");
            }
            else
            {
                Console.WriteLine("Update database klanten is mislukt");
                Console.ReadLine();
                Environment.Exit(0);
            }
            sourceDirectory = @ServerDrive + @"\Diversen";
            targetDirectory = @"c:\DigiLabelFormats\Diversen\";

            if (update_DigiLabelFormats(sourceDirectory, targetDirectory))
            {
                Console.WriteLine("Database diversen labelformaten is bijgewerkt.");
            }
            else
            {
                Console.WriteLine("Update database diversen is mislukt");
                Console.ReadLine();
                Environment.Exit(0);
            }



            Console.WriteLine("");
            Console.WriteLine("DigiLabelFormats is bijgewerkt. Druk een toets om verder te gaan...");
            Console.ReadLine();
            Process.Start(@"C:\DigiLabelFormats\DigiLabelFormats.application");


        }


        public static bool KillProcess(string processName)
        {
            Process[] prs = Process.GetProcesses();
            bool processKilled = false;

            foreach (Process pr in prs)
            {
                if (pr.ProcessName == processName)
                {

                    pr.Kill();
                    processKilled = true;

                }

            }
            return processKilled;
        }


          

        public static bool update_DigiLabelFormats(string sourceDirectory,string targetDirectory)
        {
           

            bool updateOk;
            updateOk = false;

            if (Directory.Exists(sourceDirectory) == false)
            {
                Console.WriteLine("De map " + sourceDirectory + " werd niet gevonden");
                


            }
            else
            {
                if (Directory.Exists(targetDirectory) == false)
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                Copy(sourceDirectory, targetDirectory);
                
                updateOk = true; 
            }

            return updateOk;
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
