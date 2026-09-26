using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Co_so_lap_trinh.session7
{
    internal class baiTapNopsess7
    {
        public static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Input m: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Input i: ");
            int i=int.Parse(Console.ReadLine());

            int[,] arr = new int[row,col];
         
            

        }

        static int[] ranArr(int[] arr)
        {
            Random rdm = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rdm.Next(1, 100);
            }
            return arr;
        }

        static int avg(int[] arr)
        {
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += i;
            }
            avg = avg / arr.Length;
            return avg;

        }

        static bool findSpecific(int[] arr, int spe)
        {
            for (int i = 0; i < arr.Length; i++)
            { if (arr[i] == spe) { return true; }
            }
            return false;
        }

        static int returnIndex(int[] arr, int spe)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == spe) { return i; }
            } { return -1; }
        }

        static string[] removeSpec(int[] arr, int spe)
            {
            string[] mang = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!= spe) { mang[i] = Convert.ToString(arr[i]); }
            }
            return mang;}

        static int findMax(int[] arr)
        {
            int max = arr[0];
            for (int i=1; i< arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        static int findMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;

        }

        static int[] reverseArr(int[] arr)
        {
            for( int i=0; i< arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            return arr;
        }
        static void findDup(int[] arr)
        {
            
            bool[] check = new bool[arr.Length];
            for (int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i]== arr[j] && !check[i])
                    {
                        Console.WriteLine(arr[i]);
                        check[i] = true;
                        check[j] = true;
                    }
                }
            }

        }

        static string[] removeDup(int[] arr)
        {
            string[] mang=new string[arr.Length];
            bool[] check = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !check[i])
                    {
                        if (mang[i] == null)
                        {
                            mang[i] = Convert.ToString(arr[i]);
                            check[i] = true;
                            check[j] = true;
                        }
                        else {
                            check[i] = true;
                            check[j] = true;
                        }
                    }
                    else if(arr[i] != arr[j] && !check[i])
                    {
                        mang[i] = Convert.ToString(arr[i]);
                    }
                }
            }
            return mang;

        }


        static int[] NhapMang(int[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap phan tu thu {i+1}");
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            return arr;
        }
        static int[] bubbleSort(int[] arr) 
        { for (int i=0; i<arr.Length; i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }            
            }
            return arr;
        }

        static bool checkWord(string sen, string word)
        {
            string[] arr = sen.Split(" ");
            foreach (string c in arr)
            {
                if (c== word) {
                    
                    return true; }
            }
            return false;

        }

        static int[,] multiArr(int[,] arr)
        {
            for(int i=0; i < arr.GetLength(0); i++)
            {
                for (int j=0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Nhap phan tu ({i},{ j}): ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
        static void inMultiArr(int[,] arr)
        {
            for(int i =0; i< arr.GetLength(0); i++)
            {
                for (int j =0; j< arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }

        static void printValue(int[,] arr, int i)
        {
            Console.Write($"{i}th row: ");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+ " ");
            }
            Console.WriteLine();
            Console.Write($"{i}th col: ");
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                Console.Write(arr[j,i] + " ");
            }
        }

        static int maxValue(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j=0; j < arr.GetLength(1); j++)
                {
                    if (max< arr[i,j]) { max= arr[i,j]; }
                }
            }
            return max;
        }

        static void findMaxValue(int[,] arr, int i) 
        {
            int maxr = arr[i,0];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] >maxr) { maxr = arr[i,j];} 
            }
            Console.WriteLine($"Max value of {i}th row: {maxr}");
            int maxc = arr[0,i];
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (arr[j, i] > maxc) { maxc = arr[j,i]; }
            }
            Console.WriteLine($"Max value of {i}th collum: {maxc}");
        }

        static void findMinValue(int[,] arr, int i)
        {
            int minr = arr[i,0];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < minr) { minr = arr[i, j]; }
            }
            Console.WriteLine($"Min value of {i}th row: {minr}");
            int minc = arr[0, i];
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (arr[j, i] < minc) { minc = arr[j, i]; }
            }
            Console.WriteLine($"Min value of {i}th collum: {minc}");
        }

        static int[,] tranposeMatrix(int[,] arr)
        {
            for(int i=0; i< arr.GetLength(0); i++)
            {
                for(int j = i + 1; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i,j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
            return arr;
        }

        static void printDiaValue(int[,] arr)
        {
            Console.WriteLine("Phan tu nam tren duong cheo chinh: ");
            for (int i=0; i < arr.GetLength(1); i++)
            {
                Console.WriteLine($"\t({i},{i}): {arr[i,i]}");
            }
            Console.WriteLine("Phan tu nam tren duong cheo phu: ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                Console.WriteLine($"\t({i},{arr.GetLength(0)-1-i}): {arr[i, arr.GetLength(0) - 1 - i]}");
            }
        }
    }
}
