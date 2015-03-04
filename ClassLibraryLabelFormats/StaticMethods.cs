using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ClassLibraryLabelFormats
{
    public static class StaticMethods
    {
        public static List<string> GetExistingFormats(string sourceDir, bool totaal)
        {
            var folderNames = new List<string>();
            string[] dirEntries = Directory.GetDirectories(sourceDir);
           
                foreach (string dir in dirEntries)
                {
                    if (totaal)
                    {
                        if (dir.Contains("Totaal"))
                        {
                            if (File.Exists(dir + @"\freeformats.dat"))
                            {
                                string filepath = dir + @"\freeformats.dat";
                                var dinfo = new DirectoryInfo(filepath);

                                if (dinfo.Parent != null)
                                {
                                    string folderName = dinfo.Parent.Name;

                                    folderNames.Add(folderName);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!dir.Contains("Totaal"))
                        {
                            if (File.Exists(dir + @"\freeformats.dat"))
                            {
                                string filepath = dir + @"\freeformats.dat";
                                var dinfo = new DirectoryInfo(filepath);

                                if (dinfo.Parent != null)
                                {
                                    string folderName = dinfo.Parent.Name;

                                    folderNames.Add(folderName);
                                }
                            }
                        }
                    }
                  
                  


                }
            

            return folderNames;

        }

        public static List<LabelFormat> GetExistingLabelFormats(string sourceDir, bool totaal)
        {
            var folderNames = new List<LabelFormat>();
            string[] dirEntries = Directory.GetDirectories(sourceDir);

            foreach (string dir in dirEntries)
            {
                if (totaal)
                {
                    if (dir.Contains("Totaal"))
                    {
                        if (File.Exists(dir + @"\freeformats.dat"))
                        {
                            string filepath = dir + @"\freeformats.dat";
                            var dinfo = new DirectoryInfo(filepath);

                            if (dinfo.Parent != null)
                            {
                                string folderName = dinfo.Parent.Name;

                                folderNames.Add(new LabelFormat(folderName));
                            }
                        }
                    }
                }
                else
                {
                    if (!dir.Contains("Totaal"))
                    {
                        if (File.Exists(dir + @"\freeformats.dat"))
                        {
                            string filepath = dir + @"\freeformats.dat";
                            var dinfo = new DirectoryInfo(filepath);

                            if (dinfo.Parent != null)
                            {
                                string folderName = dinfo.Parent.Name;

                                folderNames.Add(new LabelFormat(folderName));
                            }
                        }
                    }
                }




            }


            return folderNames;

        }

        public static List<string> GetExistingFormatsKlanten(string sourceDir)
        {
            string[] dirEntries = Directory.GetDirectories(sourceDir);

            return (from dir in dirEntries where File.Exists(dir + @"\freeformats.dat") select dir + @"\freeformats.dat" into filepath select new DirectoryInfo(filepath) into dinfo let directoryInfo = dinfo.Parent where directoryInfo != null where directoryInfo != null select directoryInfo.Name).ToList();

        }

        //public static List<LabelFormat> GetExistingLabelFormats(string sourceDir)
        //{
        //    List<LabelFormat> ExistingLabelFormats = new List<LabelFormat>();
        //    string[] dirEntries = Directory.GetDirectories(sourceDir);
        //    foreach (string dir in dirEntries)
        //    {
        //        string[] subdirEntries = Directory.GetDirectories(dir);
        //        foreach (string subdir in subdirEntries)
        //        {
        //            if (File.Exists(subdir + @"\freeformats.dat"))
        //            {
        //                string filepath = subdir + @"\freeformats.dat";
        //                LabelFormat lbl = new LabelFormat();

        //                ExistingLabelFormats.Add(lbl);
        //                //DirectoryInfo dinfo = new DirectoryInfo(filepath);

        //                //string folderName = dinfo.Parent.Name;

        //                //folderNames.Add(folderName);
        //            }


        //        }
        //    }

        //    return ExistingLabelFormats;

        //}

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
