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


        //Create a random integer values array
        static int[] ranArr(int[] arr)
        {
            Random rdm = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rdm.Next(1, 100);
            }
            return arr;
        }


        //calculate the average value of array elements.
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

        //to test if an array contains a specific value.
        static bool findSpecific(int[] arr, int spe)
        {
            for (int i = 0; i < arr.Length; i++)
            { if (arr[i] == spe) { return true; }
            }
            return false;
        }

        //to find the index of an array element
        static int returnIndex(int[] arr, int spe)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == spe) { return i; }
            } { return -1; }
        }

        //to remove a specific element from an array.
        static string[] removeSpec(int[] arr, int spe)
            {
            string[] mang = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!= spe) { mang[i] = Convert.ToString(arr[i]); }
            }
            return mang;}

        //to find the maximum and minimum value of an array.
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

        //to reverse an array of integer values.
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

        //to find duplicate values in an array of values.
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

        //to remove duplicate elements from an array.
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

        //requests 10 integers from the user 
        static int[] NhapMang(int[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap phan tu thu {i+1}");
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            return arr;
        }

        //the bubble sort algorithm
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

        //Request a sentence from the user,
        static string NhapCau(string sen)
        {
            Console.Write("Input sen: ");
            sen = Console.ReadLine();
            return sen;

        }
        //then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
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


        //Create an integer matrix N x M
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

        //Print the matrix.
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

        //Print the ith row/column. (i was prompted from user)
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


        //Find the max value of the matrix
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

        //Find the min value of ith row / col of the matrix.
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

        //Transpose the matrix
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


        //Print the main/secondary diagonal values of the matrix.(square maxtrix)
        static void printDiaValue(int[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                Console.WriteLine("Not a square matrix");
            }
            else
            {
                Console.WriteLine("Phan tu nam tren duong cheo chinh: ");
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.WriteLine($"\t({i},{i}): {arr[i, i]}");
                }
                Console.WriteLine("Phan tu nam tren duong cheo phu: ");
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.WriteLine($"\t({i},{arr.GetLength(0) - 1 - i}): {arr[i, arr.GetLength(0) - 1 - i]}");
                }
            }
        }
    }
}
