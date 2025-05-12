using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Read_Image
    {

        public void Read_Img() 
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Pictures\Temp_Img");
            FileInfo[] imageFiles = dir.GetFiles("*.jpg");
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
                Console.WriteLine("\n");

                
            }
        }

        public void save() 
        {

            DirectoryInfo dir = new DirectoryInfo(@"D:\Temp_Img");
            FileInfo[] imageFiles = dir.GetFiles("*.jpg");
            string saveDirectory = @"D:\Code\ADO.NET\Images";

            foreach (FileInfo f in imageFiles) 
            {
                string filename=f.Name;
                string fileSavePath = Path.Combine(saveDirectory,filename);
                f.CopyTo(fileSavePath);
               // File.Copy(f., fileSavePath, true);

            }

















            //string dir = @"D:\Temp_Img\Tumblr_l_425661892906421.jpg";
            //string saveDirectory = @"D:\Code\ADO.NET\Images";
            //string fileName = Path.GetFileName(@"D:\Temp_Img");
            //string[] fls= Directory.GetFiles(@"D:\Temp_Img","*.jpg");
            //string fileSavePath = Path.Combine(saveDirectory, fls[0]);
            //File.Copy(dir, fileSavePath, true);

        }
    }
}
