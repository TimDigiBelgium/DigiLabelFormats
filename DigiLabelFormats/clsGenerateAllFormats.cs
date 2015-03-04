using System.Collections.Generic;
using System.IO;
using ClassLibraryLabelFormats;

namespace DigiLabelFormats
{
    public class ClsGenerateAllFormats
    {
        public List<LabelFormat> AllFormats
        {
            get
            {
                return GetExistingFormats();
            }
            
        }

        private List<LabelFormat> GetExistingFormats()
        {
            var retrievedFormats = new List<LabelFormat>();
            const string sourceDir = @"c:\DigiLabelFormats\Database\";
            string[] dirEntries = Directory.GetDirectories(sourceDir);
            int counter = 10;
            foreach (string dir in dirEntries)
            {
                string[] subdirEntries = Directory.GetDirectories(dir);
                foreach (string subdir in subdirEntries)
                {
                    if (File.Exists(subdir + @"\freeformats.dat"))
                    {
                        string filepath = subdir + @"\freeformats.dat";
                        var dinfo = new DirectoryInfo(filepath);

                        if (dinfo.Parent != null)
                        {
                            string folderName = dinfo.Parent.Name;
                            string doelFormaat = "F" + counter;
                            retrievedFormats.Add(new LabelFormat(doelFormaat,folderName));
                        }
                        counter +=1;
                    }


                }
            }
            return retrievedFormats;

        }
    }
}
