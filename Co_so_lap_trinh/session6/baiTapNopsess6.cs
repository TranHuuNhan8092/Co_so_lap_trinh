using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Co_so_lap_trinh.session6
{
    internal class baiTapNopsess6
    {
        public static void Mainbt6(string[] args)
        {
            //Console.Write("Input n: ");
            //string n = Console.ReadLine();
            int[] arr = { 10,45,2,3,7,6,9,10};
            SapXepMang(arr);
            
        }

      



        /*Bài 1: Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.*/
        static int TinhTong(int a, int b)
        {
            
            return a + b;
        }



        /*Bài 2: Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.*/
        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0) { return true; }
            else { return false; }
        }


        /*Bài 3: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được truyền vào*/
        static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > a) { max = b; }
            if (c > max) { max = c; }
            return max;

        }


        /*Bài 4: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n (n!)*/
        static long TinhGiaiThua(int n)
        {
            int tich = 1;
            for (int i = 1; i <= n; i++)
            {
                tich = tich * i;
            }
            return tich;
        }


        /*Bài 5: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị đảo ngược.*/
        static string DaoNguocChuoi(string s)
        {
            char[] tu = s.ToCharArray();
            Array.Reverse(tu);
            string chuoiDaoNguoc = string.Join('\0', tu);
            return chuoiDaoNguoc;
        }


        /*Bài 6: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.*/
        static bool KiemTraNguyenTo(int n)
        {
            if (1 >= n) { return false; }
            else if (3 >= n) { return true; }
            else
            {
                for (int i = 2; i <= Math.Sqrt((double)n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;


                    }


                }
                return true;
            }
        }


        /*Bài 7: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci*/
        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1) { Console.Write($"{a} "); }
                else
                {
                    Console.Write(a);
                }
                int c = a + b;
                b = a;
                a = c;

            }

        }


        /*Bài 8: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm (a, e, i, o, u) trong chuỗi.*/
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            s = s.Replace(" ", "").ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    dem++;
                }
            }
            return dem;

        }


        /*Bài 9: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y (không dùng Math.Pow).*/
        static double TinhLuyThua(double x, int y)
        {
            double k = x;
            for (int i=1;i<y;i++)
            {
                
                x = x * k;
            }
            return x;
        }


        /*Bài 10: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên*/
        static double TinhTrungBinh(int[] arr)
        {
            double avg = 0;
            for (int i=0; i< arr.Length; i++)
            {
                avg+= arr[i];
            }

            avg = avg / arr.Length;
            return avg;
        }


        /*Bài 11: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.*/
        static bool KiemTraDoiXung(string s)
        {
            s = s.ToLower();
            for (int i=0; i<s.Length/2;i++)
            {
                if (s[i] != s[(s.Length)-1 -i])
                { return false; }
                
            }
            return true;
        }


        /*Bài 12: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.*/
        static double CelsiusToFahrenheit(double c)
        {
            double f = (c * 1.8) + 32;
            return f;
        }


        /*Bài 13: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.*/
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for(int i=1; i< arr.Length;i++)
            { if (min > arr[i]) 
                {
                    min = arr[i]; 
                } 
            }
            return min;
        }


        /*Bài 14: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n*/
        static int TongCacChuSo(int n)
        {
            int tong = 0;

            
            foreach( char c in Convert.ToString(n))
            {
                
                tong += c-'0';
                
            } 

            return tong;
        }


        /*Bài 15: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần.*/
        static void SapXepMang(int[] arr)
        {
            Console.WriteLine(string.Join(' ', QuickSort(arr, 0, arr.Length - 1)));
        }

        static int[] QuickSort(int[] arr, int left, int right)
        {

            if (left >= right) { return arr; }


            int pivot = arr[left];
            int i = left;
            for (int j = left + 1; j <= right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }


            arr[left] = arr[i];
            arr[i] = pivot;


            QuickSort(arr, left, i - 1);
            QuickSort(arr, i + 1, right);


            return arr;
        }



        /*Bài 16: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.*/
        static string XoaTrungLap(string s)
        {
            
            bool[] check = new bool[26];
            char[] chu= s.ToCharArray();

            for(int i=0; i< chu.Length; i++)
            {
                
                if (check[char.ToLower(chu[i]) -'a']!= true) { check[char.ToLower(chu[i]) - 'a'] = true; }
                else { chu[i] = '\0'; }
           
            }
                s = string.Join("", chu);

           
            return s;
        }


        /*Bài 17: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.*/
        static int UCLN(int a, int b)
        {
            while(a%b!=0)
            {
                int temp =b;
                b = a % b;
                a = temp;
            }
            return b;
        }


        /*Bài 18: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân*/
        static string DecimalToBinary(int n)
        {
            string s = "";
            do
            {
                s = Convert.ToString(n % 2) + s;
                n = n / 2;
            }
            while (n != 0);

            return s;
        }


        /*Bài 19: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không*/
        static bool KiemTraNamNhuan(int year)
        {
            if(year%4 != 0) { return false; }
            else
            {
                if (year%100 ==0 && year %400 != 0) { return false; }
                else { return true; }
            }
        }


        /*Bài 20: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu*/
        static int DemSoTu(string sentence)
        {
            string[] arr = sentence.Split(" ");
            int sotu = arr.Length;
            return sotu;
        }

    }

}
