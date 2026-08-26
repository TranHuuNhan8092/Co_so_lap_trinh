using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_session3
{
    internal class exercise3
    {
        public static void Main_ex2(string[] args)
        {
            /*The Celsius scale is centigrade, 100 divisions separate the freezing point
from the boiling point of water. On the Fahrenheit scale of Anglo-Saxons,
these two points are 180 degrees apart. The Kelvin scale is an absolute
scale used in science.
▸Create a C# program to convert from degrees Celsius to Kelvin and
Fahrenheit. Request the user the number of degrees celsius to convert
them using the following conversion tables:
- kelvin = celsius + 273
- fahrenheit = celsius x 18 / 10 + 32
- Input
• 33
- Output
• kelvin= 306
• fahrenheit= 91
*/
            float celsius = float.Parse(Console.ReadLine());
            float Kelvin = celsius + 273;
            float Farenheit = celsius * 1.8f + 32;

            Console.WriteLine($"kelvin = {Kelvin}");
            Console.WriteLine($"farenheit = {Farenheit}");



            /*Create a program in C# for calculate the surface and volume of a sphere, given its 
radius*/
            double r = double.Parse(Console.ReadLine());
            const double hamPi = Math.PI;
            double surface = 4 * Math.Pow(r, 2) * hamPi;
            double volume = 4 / 3 * hamPi * Math.Pow(r, 3);
            Console.WriteLine($"surface: {surface}");
            Console.WriteLine($"volume: {volume}");



            /*Write a program in C# that calculates the result of adding, subtracting,
multiplying and dividing two numbers entered by the use*/
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            /*int sum = a + b;
            int subtract = a - b;
            int multiply = a * b;
            int divide = a / b;
            int mod = a % b;*/
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            Console.WriteLine($"{a}/{b}={a / b}");
            Console.WriteLine($"{a}%{b}={a % b}");


        }
    }
}