using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Co_so_lap_trinh.session6
{
    internal class exercisese
    {
        public static void Main(string[] args) 
        {
            Console.Write("Input: ");
            string s= Console.ReadLine();
            ex_6_6(s);
        }


        public static void ex_6_1(double a=0, double b=0,double c=0)
        {
            double max = a;
            if (b>a) { max = b; }
            if (c > max) { max = c; }
            Console.WriteLine($"So lon nhat trong 3 so ({a},{b},{c}): {max}");
        }
        public static void ex_6_2(int n)
        {
            int s = 1;
            for (int i = 2; i <= n; i++) { s = s * i; }
            Console.WriteLine($"{n}!={s}");
        }
        static void ex_6_3(int n) 
        { 
            if (primeNumCheck(n) == true) { Console.WriteLine($"{n} is a prime number"); }
            else { Console.WriteLine($"{n} is not a prime number"); }
        }

        static void ex_6_4_1(int n) 
        {
            Console.WriteLine($"Prime number that less than {n}");
            for (int i =2; i<n;i++)
            {
                if (primeNumCheck(i) == true) Console.WriteLine(i);
            }
        }

        static void ex_6_4_2(int n)
        {
            Console.WriteLine($"the first {n} prime numbers");
            int dem = 0;
            int i = 2;
            while (dem < n)
            {
                if (primeNumCheck(i)==true)
                { Console.WriteLine(i);
                    dem++;
                }
                i++;
            }
        }

        static void ex_6_5(int n)
        {
            if (perfectNumCheck(n) == true) { Console.WriteLine($"{n} is a perfect number"); }
            else { Console.WriteLine($"{n} is not a perfect number"); }
        }

        static void ex_6_5_1()
        {
            Console.WriteLine("all perfect number that less than 1000");
            for (int i = 4; i < 1000; i++)
            {
                if (perfectNumCheck(i)== true)
                {
                    Console.WriteLine(i);
                }
            }
        }


        static void ex_6_6(string s)
        {

            if (pangramStringCheck(s))
            {
                Console.WriteLine($"This is a pangram string");


            }
            else { Console.WriteLine($"This is not a pangram string"); }
        }





        public static bool primeNumCheck(int n)
        {
            bool check = true;
            if (1>=n){
                check = false;

            }
            else if (n >= 4) 
            
            { for (int i=2; i<= Math.Sqrt((double)n); i++)
                {
                    if (n% i ==0) 
                    { check =false ;
                        break;
                   }
                    
                }
               
            }
            return check;
            
        }
       
    
        public static bool perfectNumCheck(int n)
        {
            bool check = true;
            int tong = 1;
            for (int i = 2; i <= Math.Sqrt((double)n); i++)
            {
                if (n % i == 0)
                {
                    if (i!= Math.Sqrt((double)n))
                        { tong = tong+i + (n / i); }
                    else { tong += i; }
                }
            }
            if (tong != n) { check = false; }
            return check;
        }

        static bool pangramStringCheck(string s)
        {
            bool check = true;
             s = s.ToLower().Replace(" ","");
            bool[] bangChuCai = new bool[26];
            for (int i=0; i< s.Length; i++)
            {
                bangChuCai[s[i] - 'a'] = true;
            }
            for (int i = 0; i < 26; i++)
            {
                if (!bangChuCai[i])
                {
                    check = false;
                    break;
                }
            }

            return check;
        }
    }
}
