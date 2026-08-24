using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sess2
{
    internal class exersise1
    {
        public static void Main2(string[] args)
        {
            //            1.to Add / Sum Two Numbers.

            int num1 = 3;
            int num2 = 4;
            int sum = num1 + num2;
            Console.WriteLine($"{num1}+{num2}={sum}");
            Console.WriteLine();

            //2.to Swap Values of Two Variables.

            Console.WriteLine($"Truoc khi doi: So thu nhat {num1}, So thu hai {num2}");
            int num3 = num2;
            num2 = num1;
            num1 = num3;
            Console.WriteLine($"Sau khi doi: So thu nhat {num1}, So thu hai {num2}");
            Console.WriteLine();
            //3.to Multiply two Floating Point Numbers

            float n1 = 1.45f;
            float n2 = 2.65f;
            float tich = n1 * n2;
            Console.WriteLine($"{n1}*{n2}={tich}");

            //4.to convert feet to meter
            float feet = 3.6f;
            const float rate = 0.3408f;
            float meter = feet * rate;
            Console.WriteLine($"{feet} feet={meter} meter");
            Console.WriteLine();
            //5.to convert Celsius to Fahrenheit and vice versa
            //6.to find the Size of data types
            //7.to Print ASCII Value(tip: read character, print number of this char)
            char c = 'N';
            int asciivl = (int)c;
            Console.WriteLine($"The ASCII value of {c}: {asciivl}");
            Console.WriteLine();
            //            8.to Calculate Area of Circle
            float r = 1.75f;
            const float pi = 3.14f;
            float s = r * r * pi;
            Console.WriteLine($"Dien tich hinh tron co ban kinh {r}:{s}");
            Console.WriteLine();
            //9.to Calculate Area of Square

            Console.WriteLine("bai 2");
            float a = 2f;
            float s2 = a * a;
            Console.WriteLine($"Dien tich hinh vuong co canh {a}:{s2}");
            Console.WriteLine();

            //10.to convert days to years, weeks and days
            int days = 1836;
            int years = days / 365;
            int ngaydu = days % 365;
            int weeks = ngaydu / 7;
            int day = ngaydu % 7;
            Console.WriteLine($"{days} ngay bang {years} nam, {weeks} tuan va {day} ngay ");
        }
    }
}