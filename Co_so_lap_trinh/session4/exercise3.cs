using System;
using System.Collections.Generic;
using System.Text;

namespace Co_so_lap_trinh.session4
{
    internal class exercise3
    {
        public static void Main_ex3(string[] args)
        {
           




        }
        static void bai1_3() {
            /*Write a C# Sharp program that takes two numbers as input and
performs an operation (+,-,*,x,/) on them and displays the result of that
operation.*/
            Console.Write("Nhap x: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        static void bai2_3() {
            /*Write a C# Sharp program to display certain values of the function x = y2
+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
*/
            Console.WriteLine($"y=-5, x=y2+ 2y+1 ={(-5) * (-5) + 2 * (-5) + 1}");
            Console.WriteLine($"y=-4, x=y2+ 2y+1 ={(-4) * (-4) + 2 * (-4) + 1}");
            Console.WriteLine($"y=-3, x=y2+ 2y+1 ={(-3) * (-3) + 2 * (-3) + 1}");
            Console.WriteLine($"y=-2, x=y2+ 2y+1 ={(-2) * (-2) + 2 * (-2) + 1}");
            Console.WriteLine($"y=-1, x=y2+ 2y+1 ={(-1) * (-1) + 2 * (-1) + 1}");
            Console.WriteLine($"y=0, x=y2+ 2y+1 ={(0) * (0) + 2 * (0) + 1}");
            Console.WriteLine($"y=1, x=y2+ 2y+1 ={(1) * (1) + 2 * (1) + 1}");
            Console.WriteLine($"y=2, x=y2+ 2y+1 ={(2) * (2) + 2 * (2) + 1}");
            Console.WriteLine($"y=3, x=y2+ 2y+1 ={(3) * (3) + 2 * (3) + 1}");
            Console.WriteLine($"y=4, x=y2+ 2y+1 ={(4) * (4) + 2 * (4) + 1}");
            Console.WriteLine($"y=5, x=y2+ 2y+1 ={(5) * (5) + 2 * (5) + 1}");

            for (int y = -5; y <= 5; y++) {
            
            }
        }
        static void bai3_3()
        {
            /*Write a C# Sharp program that takes distance and time (hours, minutes,
seconds) as input and displays speed in kilometers per hour (km/h) and
miles per hour (miles/h).*/
            Console.Write("Nhap khoang cach: ");
            float distance = float.Parse(Console.ReadLine());
            Console.Write("Nhap gio: ");
            float hours = float.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            float seconds = float.Parse(Console.ReadLine());

            float miles = distance * 0.62f;

            float times = hours + (minutes / 60) + (seconds / 3600);

            float velocityKm = distance / times;
            float velocityMiles = miles / times;

            Console.WriteLine($"Km/h: {velocityKm:N2}");
            Console.WriteLine($"miles/h: {velocityMiles:N2}");

        }
        static void bai4_3() {
            /*Write a C# Sharp program that takes the radius of a sphere as input and
calculates and displays the surface and volume of the sphere. V =
4/3*π*r
3
*/
            Console.Write("Input radius: ");
            float radius = float.Parse(Console.ReadLine());
            float hamPi = (float)Math.PI;
            float surface = 4 * hamPi * radius * radius;
            float volume = (4 / 3f) * hamPi * radius * radius * radius;
            Console.WriteLine($"Surface: {surface:N2}");
            Console.WriteLine($"Volume:{volume:N2}");
        }

        static void bai5_3() {
            /*Write a C# Sharp program that takes a character as input and checks if it
is a vowel, a digit, or any other symbol*/
            Console.Write("Input character: ");
            char ra = char.Parse(Console.ReadLine());
            if (ra == 'a' || ra == 'e' || ra == 'i' || ra == 'u' || ra == 'o' ||
                ra == 'A' || ra == 'E' || ra == 'I' || ra == 'U' || ra == 'O') { Console.WriteLine("Vowel"); }
            else if (ra == '0' || ra == '2' || ra == '3' || ra == '4' || ra == '5' ||
                ra == '6' || ra == '7' || ra == '8' || ra == '9') { Console.WriteLine("Number"); }
            else { Console.WriteLine("Other symbol"); }
        }
    }
}
