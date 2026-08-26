using System;
using System.Collections.Generic;
using System.Text;

namespace Co_so_lap_trinh.session4
{
    internal class baiTap3
    {
        public static void Main(string[] args)
        {
            Bai1_bt3();
            
        }
        static void Bai1_bt3()
        {
            Console.Write("Nhap he so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Nhap he so c: ");
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
                if (delta < 0) {
                    Console.WriteLine($"Delta ={delta}.");
                     Console.WriteLine("Delta < 0. Phuong trinh vo nghiem");   }
                else if (delta == 0) { Console.WriteLine($"Delta ={delta} .Nghiem duy nhat: {-b / (2 * a)}"); }
                else
                {
                    float sqrtDt = (float)Math.Sqrt(delta);
                    Console.WriteLine($"Delta ={delta}");
                    Console.WriteLine("Delta > 0. Phương trình có 2 nghiệm.");
                    Console.WriteLine($"x1= {(-b + sqrtDt) / (2 * a)}");
                    Console.WriteLine($"x2= {(-b - sqrtDt) / (2 * a)}");
                }
            }
            
        }

        static void Bai2_1_bt3() 
        {
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) { Console.WriteLine("Even number"); }
            else { Console.WriteLine("Odd number"); }
        }

        static void Bai2_2_bt3() 
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Nhap so c: ");
            float c = float.Parse(Console.ReadLine());

            float maxNum = a;

            if (a < b) {  maxNum = b; }
            if (maxNum < c) {  maxNum = c; }

            Console.WriteLine($"So lon nhat trong 3 so ( {a}; {b}; {c}): {maxNum} ");
        }

        static void Bai2_3_bt3()
        {
            Console.Write("Nhap canh dau tien: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu hai: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh thu ba: ");
            float c = float.Parse(Console.ReadLine());

            if (a == b && b == c ) { Console.WriteLine("Equilateral"); }
            else if ((a == b && b != c) || (a == c && b != c )||( c == b && a != c)) { Console.WriteLine("Isosceles"); }
            else { Console.WriteLine("Scalene"); }
        }

        static void Bai2_4_bt3()
        {
            Console.Write("Input the value for X coordinate: ");
            float x= float.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            float y = float.Parse(Console.ReadLine());

            if (x>0&& y>0)
            {
                { Console.WriteLine($"The coordinate point ({x},{y}) lies on the First quadrant"); }

            }
            else if (x>0 && y < 0) {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Fourth Quadrant"); }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Third Quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Second Quadrant");
            }
            else if( x==0 && y !=0) { Console.WriteLine($"The coordinate point ({x},{y}) lies on the y-axis "); }
            else if (y == 0 && x != 0) { Console.WriteLine($"The coordinate point ({x},{y}) lies on the x-axis "); }
            else { Console.WriteLine($"The coordinate point ({x},{y}) is the origin "); }

        }
    }
}
