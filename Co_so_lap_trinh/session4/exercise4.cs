using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Co_so_lap_trinh.session4
{
    internal class exercise4
    {
        public static void Main_ex4(string[] args)
        {
            
            Console.ReadKey();

        }
        static void Bai1_4()
            {
                /*Write a program to check whether a triangle is Equilateral, Isosceles or
Scalene.*/


                Console.Write("Nhap canh dau tien: ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("Nhap canh thu hai: ");
                float b = float.Parse(Console.ReadLine());

                Console.Write("Nhap canh thu ba: ");
                float c = float.Parse(Console.ReadLine());

                if (a == b && b == c && c == a) { Console.WriteLine("Equilateral"); }
                else if (a == b && b != c || a == c && b != c || c == b && a != c) { Console.WriteLine("Isosceles"); }
                else { Console.WriteLine("Scalene"); }
            }
        static void Bai2_4() { 
            /*Write a program to read 10 numbers and find their average and sum*/
            float sum = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                float n = float.Parse(Console.ReadLine());
                sum += n;
            }
            float avg = sum / 10;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");
        }

        static void Bai3_4()
        {
            /*Write a program to display the multiplication table of a given integer.
*/
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }

            Console.ReadKey();
        }

        static void Bai6_4() {
            /*Write a program to display the n terms of harmonic series and their
sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
*/
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            double tong = 0;

            for (int i = 1; i <= n; i++)
            {
                tong += 1.0 / i;
                Console.Write($"1/{i / 1}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine($" = {tong}");
            Console.ReadKey();
        }



        static void Bai8_4() {
            /*Write a program to determine whether a given number is prime or not.*/
            Console.Write(" Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            int uoc = 0;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { uoc++; }
            }

            if (uoc == 0) { Console.WriteLine("Prime number"); }
            else { Console.WriteLine("Not prime number"); }

            Console.ReadKey();
        }

        static void ptbh() {
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so c: ");
            float c = float.Parse(Console.ReadLine());


            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Vo so nghiem");

                    }
                    else { Console.WriteLine("Vo nghiem"); }
                }
                else { Console.WriteLine($"Nghiem duy nhat: {-c / b}"); }
            }
            else
            {
                float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0) { Console.WriteLine("Vo nghiem"); }
                else if (delta == 0) { Console.WriteLine($"Nghiem duy nhat: {-b / (2 * a)}"); }
                else
                {
                    float sqrtDt = (float)Math.Sqrt(delta);
                    Console.WriteLine("Phuong trinh co 2 nghiem: ");
                    Console.WriteLine($"x1= {(-b + sqrtDt) / (2 * a)}");
                    Console.WriteLine($"x2= {(-b - sqrtDt) / (2 * a)}");
                }
            }
        }
        
    }
}
