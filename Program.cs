using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Baitap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baitap01();
            Baitap02();
            Baitap03();
            Baitap04();
           

        }
        static void Baitap01()
        {
            Console.WriteLine("Nhap so a: ");
        byte a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
        byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Tong cua hai so a+b = " + (a+b) );
        
                     
        }
        static void Baitap02()
        {
            Console.Write("Nhap so a: ");
            byte a = Convert.ToByte(Console.ReadLine());
            Console.Write("Nhap so b: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"So a truoc khi hoan doi la : {a}");
            Console.WriteLine($"So b truoc khi hoan doi la: {b}");
            a = (byte)(a + b);
            b = (byte)(a - b);
            a = (byte)(a - b);
            Console.WriteLine($" So a sau khi hoan doi la: {a}");
            Console.WriteLine($"So b sau khi hoan doi la: {b}");
        }
        static void Baitap03()
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Tich cua a va b = " + a * b);
        }
        static void Baitap04()
            {
            int x = Datetime;
            Console.WriteLine(x);
           
            }

          
        }    
            

        
    }

