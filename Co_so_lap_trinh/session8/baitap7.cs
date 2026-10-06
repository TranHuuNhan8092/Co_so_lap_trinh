using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Channels;

namespace Co_so_lap_trinh.session_8
{
    internal class baitap7
    {
        static void Main()
        {
          
        }
        
        //to input a string and print it.
        static string inputString()
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            return s;
           
        }
        static void outputString(string s) {
            Console.WriteLine("--Print string--");
            Console.WriteLine(s);
        }

        //to find the length of a string without using a library function.
        static int findLength(string s)
        {
            int length = 0;
            foreach (char c in s)
            {
                length++;
            }
            return length;
        }

        //to separate individual characters from a string
        static char[] seperateString(string s)
        {
            int dem = 0;
            for(int j=0; j< findLength(s); j++)
            {
                if (s[j]!=' ') { dem++; }
            }
            char[] arr = new char[dem];
            
            
          for (int i =0; i< findLength(s); i++)
            {
                if (s[i]!=' ')
                {
                    arr[i] = s[i];
                }
            }
            return arr;
           
        }

        static void outputCh(char[] arr)
        {
            foreach (char c in arr)
            {
                Console.WriteLine(c);
            }

        }

        //to print individual characters of the string in reverse order.
        static void printReverse(string s)
        {
            char[] arr= seperateString(s);
            for (int i = arr.Length - 1; i >= 0; i--) {
                Console.WriteLine(arr[i]);
            }
        }

        //to count the total number of words in a string
        static int countWords(string s)
        {
            int count = 1;
            if (s=="") { return 0; }
            for (int c =0; c<findLength(s)-1; c++)
            {
                if (s[c] ==' ' && s[c+1]!=' ') { count++; }
            }
            return count;
        }


        //to compare two strings without using a string library functions.
        static bool compareString(string s1, string s2)
        {
            if (findLength(s1) != findLength(s2)) { return false; }
            for (int i=0; i< findLength(s1) / 2; i++)
            {
                if (s1[i]!= s2[i] || s1[findLength(s1)-1-i]!= s2[findLength(s1)-1-i]) {  return false; }
            }
            return true;
        }
        //to count the number of alphabets, digits, and special characters in a string
        static void counting(string s)
        {
            int alp = 0;
            int dig = 0;
            int spe = 0;

            foreach (char c in s) {
                if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') { alp++; }
                else if (c >= '0' && c <= '9') { dig++; }
                else if(c!= ' ') { spe++; }
            }
            Console.WriteLine($"Number of alphabets: {alp}");
            Console.WriteLine($"Number of digits: {dig}");
            Console.WriteLine($"Number of special characters: {spe}");
        }

        //to count the number of vowels or consonants in a string
        static void countVowelConsonant(string s)
        {
            int vowel = 0;
            int con = 0;
            foreach(char c in s)
            {
                if (char.ToLower(c) == 'a'|| char.ToLower(c) == 'e'|| char.ToLower(c) == 'i'|| char.ToLower(c) == 'o'|| char.ToLower(c) == 'u') {
                    vowel++;
                }
                else {  con++; }
            }

            Console.WriteLine($"Number of vowels: {vowel}");
            Console.WriteLine($"Number of consonants: {con}");
        }

        //to check whether a given substring is present in the given string.
        static bool checkSubString(string s, string sub)
        {
            if (findLength(s) < findLength(sub)) {  return false; }
            for (int i = 0; i <= findLength(s) - findLength(sub);i++) 
            {
                bool check = compareString(s.Substring(i, findLength(sub)), sub);
                if (check) { return check; }
            }
            return false;

        }
        //to search for the position of a substring within a string.
        static int returnIndex(string s, string sub)
        {
            if (findLength(s) < findLength(sub)) { return -1; }
            for (int i=0;  i <= findLength(s) - findLength(sub); i++)
            {
                if (checkSubString(s.Substring(i, findLength(sub)),sub))
                    {
                return i;
            }
            }
            return -1;
        }

        //to check whether a character is an alphabet and not and if so, check for the case.
        static void checkAlphabet(string s)
        {
            foreach (char c in s)
            {
                bool upper= c>= 'A'&& c<='Z';
                bool lower= c >= 'a' && c <= 'z';
                if (upper) { Console.WriteLine($"{c} is an uppercase letter"); }
                else if (lower) { Console.WriteLine($"{c} is an lowercase letter"); }
                else { Console.WriteLine($"{c} is not an alphabet"); }
            }
        }
        //to find the number of times a substring appears in a given string
        static int calSubstring(string s, string sub)
        {
            if (findLength(s) < findLength(sub)) { return 0; }
            int dem = 0;
            for (int i = 0; i <= findLength(s) - findLength(sub); i++)
            {
                if (checkSubString(s.Substring(i, sub.Length), sub))
                {
                    dem++;
                    i += findLength(sub)-1;
                }
            }
            return dem;

        }


        //to insert a substring before the first occurrence of a string.
        static void insertString(string s, string sub, string ins)
        {
            string[] arr = new string[countWords(s)+1];
            bool check = true;
            string ts = "";
            int id = 0;
            for (int i=0; i<findLength(s);i++)
            {
                if (s[i]!=' ')
                {
                    ts = ts + s[i];
                }
                else
                {
                    if (compareString(ts, sub) && (check)) 
                    {
                        check = false;
                        arr[id] = ins;
                        arr[id + 1] = ts;
                        
                        id+=2;
                    }
                    else { arr[id] = ts;
                        ts = "";
                        id++;
                    }
                    ts = "";
                }


            }
            if ((compareString(ts, sub) == true) && (check == true))
            {
               
                arr[id] = ins;
                arr[id + 1] = ts;

               
            }
            else
            {
                arr[id] = ts;
                
            }

            for (int i=0; i < arr.Length; i++)
            {
                if(i== arr.Length - 1)
                {
                    Console.WriteLine(arr[i]);
                }
                else Console.Write(arr[i]+ " ");
            }
            
        }





    }
}
