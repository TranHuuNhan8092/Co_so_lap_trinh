using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Channels;
using System.Data;




namespace Co_so_lap_trinh.session8
{
    internal class baiTap8
    {

        static void createBlankFile(string filePath)
        {
            //string filePath = @"D:\Temp\Blank.txt";
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                File.Create(filePath).Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void removeFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("the file has been deleted");
            }
            else { Console.WriteLine("File not found"); }
        }

        static void createAndAdd(string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            File.Create(filePath).Close();

           
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("hello world!");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            

        }

        static void creaeAndRead(string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            File.Create(filePath).Close();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

        }

        static void creatAndWrtArr(string filePath, string[] arr)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            File.Create(filePath).Close();
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string str in arr)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
