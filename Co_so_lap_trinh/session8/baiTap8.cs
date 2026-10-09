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
        static void Main()
        {
          
           

            
        }
        //1.to create a blank file on the disk.
        static void createBlankFile(string filePath)
        {
            //string filePath = @"D:\Temp\Blank.txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    if (!string.IsNullOrEmpty(Path.GetDirectoryName(filePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                        
                    }
                    File.Create(filePath).Close();
                }

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //2.to remove a file from the disk.
        static void removeFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("the file has been deleted");
            }
            else { Console.WriteLine("File not found"); }
        }

        //3.to create a file and add some text.
        static void createAndAdd(string filePath)
        {
            createBlankFile(filePath);

           
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("This is my 1st line");
                    sw.WriteLine("Hello world");
                    sw.WriteLine(35634);
                    sw.WriteLine("Bye bye");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            

        }

        //4.create a text file and read it.
        static void createAndRead(string filePath)
        {
            

            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
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


        //5.to create a file and write an array of strings to the file.

        static void creatAndWrtArr(string filePath, string[] arr)
        {
            
            try
            {
                createBlankFile(filePath);
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



        //6.to append some text to an existing file.

        static void appendText(string filePath)
        {
            
           
            

            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                using (StreamWriter sw =new StreamWriter(filePath, true))
                {
                    sw.WriteLine("New Line");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //7.to create and copy the file to another name and display the content.
        static void copyFile(string filePath, string tempFilePath)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                File.Copy(filePath, tempFilePath,true);
                string cont = File.ReadAllText(tempFilePath);
                Console.WriteLine(cont);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //8.create a file and move it into the same directory with another name.
        static void moveFile(string filePath, string tempFilePath)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                File.Move(filePath, tempFilePath, true);
                string cont = File.ReadAllText(tempFilePath);
                Console.WriteLine(cont);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //9.read the first line of a file
        static void readFirstLine(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    Console.WriteLine(lines[0]);
                }
                else { Console.WriteLine("File has no lines;"); }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //10.to create and read the last line of a file.

        static void readLastLine(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    Console.WriteLine(lines[lines.Length - 1]);
                }
                else { Console.WriteLine("File has no lines;"); }
                
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        //11.create and read the last n lines of a file.

        static void readNLastLines(string filePath, int n)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length == 0) { Console.WriteLine("No lines"); }
                else if(  n > lines.Length) { Console.WriteLine(-1); }
                else
                {
                    for (int i = lines.Length - n; i < lines.Length; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //12.to read a specific line from a file.

        static void readSpecLine(string filePath, int n)
        {
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length == 0) { Console.WriteLine("No lines"); }
                else if (n > lines.Length) { Console.WriteLine(-1); }
                else { Console.WriteLine(lines[n-1]); }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        //13.to count the number of lines in a file.


        static void countingLines(string filePath)
        {
            int count = 0;
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Number of lines: {count}");
                
                
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
        }

        //14.To print the structure of specific folder (include files)

        static void printStructureFile(string folderPath, string space = "")
        {
            try
            {
                if (space == "")
                {
                    Console.WriteLine(folderPath);
                }
                else { Console.WriteLine(space + Path.GetFileName(folderPath)); }
                
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    Console.WriteLine(space+" " + Path.GetFileName(file));
                }

                foreach (string dir in Directory.GetDirectories(folderPath))
                {

                    printStructureFile(dir, space+ " ");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }


        //15.Read a text file, then calculate the statistics of the appearance of characters and numbers. (Hint: dùng mảng chữ nhật để xử lý. 
        //Trường hợp yêu cầu thêm ký tự xuất hiện ở các vị trí nào của file(dòng, cột) à dùng  jagged array)
        static int returnIndex( char c)
        {

           
                if (char.ToLower(c) >= 'a' && char.ToLower(c) <= 'z') { return char.ToLower(c) - 'a'; }
                else if (c >= '0' && c <= '9') { return 26 + c - '0'; }
               
            

            return -1;
        }
        
        static int[][] creatJArr(int[,] arr)
        {
            int[][] jArr = new int[36][];
            for(int i = 0; i < jArr.Length; i++)
            {
                jArr[i] = new int[arr[i, 1]];
            }
            return jArr;
        }
       
        static void calStatistics(string filePath)
        {
            
                

            
            try
            {
                if (!File.Exists(filePath)){ createAndAdd(filePath); }
                int[,] arr = new int[36, 2];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (i < 26) { arr[i, 0] = 'a' + i; }
                    else { arr[i, 0] = '0' + i - 26; }
                }
                string[] lines = File.ReadAllLines(filePath);
                foreach(string str in lines)
                {
                    for(int i=0; i< str.Length;i++)
                    {
                        if (returnIndex(str[i]) >= 0) { arr[returnIndex(str[i]), 1]++; }
                     
                    }
                }

                int[][] rows = creatJArr(arr);
                int[][] cols = creatJArr(arr);
                int[] pointCol= new int[36];
                for (int r=0; r < lines.Length; r++)
                {
                    string sen = lines[r];
                    for(int c=0; c < sen.Length; c++)
                    {
                        int ind = returnIndex(sen[c]);
                        if (ind >= 0)
                        {
                            rows[ind][pointCol[ind]] = r + 1;
                            cols[ind][pointCol[ind]] = c + 1;
                            pointCol[ind]++;
                        }
                    }
                }



                for(int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, 1] > 0) { Console.Write($"{(char)(arr[i,0])}: {arr[i,1]} "); }
                    for (int j=0; j< rows[i].Length; j++)
                    {
                        Console.Write($"({rows[i][j]};{cols[i][j]}) ");
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception e) { Console.WriteLine(e.Message); }

        }


    }
}
