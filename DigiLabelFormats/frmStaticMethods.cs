using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiLabelFormats
{
    public static class StaticMethods
    {
        public static List<string> GetExistingFormats(string sourceDir)
        {
            List<string> folderNames = new List<string>();
            string[] dirEntries = Directory.GetDirectories(sourceDir);
            foreach (string dir in dirEntries)
            {
                string[] subdirEntries = Directory.GetDirectories(dir);
                foreach (string subdir in subdirEntries)
                {
                    if (File.Exists(subdir + @"\freeformats.dat"))
                    {
                        string filepath = subdir + @"\freeformats.dat";
                        DirectoryInfo dinfo = new DirectoryInfo(filepath);

                        string folderName = dinfo.Parent.Name;

                        folderNames.Add(folderName);
                    }


                }
            }

            return folderNames;

        }

        public static List<string> GetExistingFormatsKlanten(string sourceDir)
        {
            List<string> folderNames = new List<string>();
            string[] dirEntries = Directory.GetDirectories(sourceDir);
            foreach (string dir in dirEntries)
            {
                  if (File.Exists(dir + @"\freeformats.dat"))
                    {
                        string filepath = dir + @"\freeformats.dat";
                        DirectoryInfo dinfo = new DirectoryInfo(filepath);

                        string folderName = dinfo.Parent.Name;

                        folderNames.Add(folderName);
                    }


               
            }

            return folderNames;

        }

    }
}
