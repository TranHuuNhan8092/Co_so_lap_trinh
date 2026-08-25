using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Co_so_lap_trinh.session4
{
    internal class exercise4
    {
        public static void Mainsess4(string[] args)
        {
            Console.WriteLine("Nhap he so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so c: ");
            float c = float.Parse(Console.ReadLine());


            if (a == 0)
            {
                if (b == 0)
                {
                    if(c==0)
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
                else if(delta == 0) { Console.WriteLine($"Nghiem duy nhat: {-b/(2*a)}"); }
                else 
                {
                    float sqrtDt = (float)Math.Sqrt(delta);
                    Console.WriteLine("Phuong trinh co 2 nghiem: ");
                    Console.WriteLine($"x1= {(-b + sqrtDt) / (2 * a)}");
                    Console.WriteLine($"x2= {(-b - sqrtDt) / (2 * a)}");
                }
            }

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
