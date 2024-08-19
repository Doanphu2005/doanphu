namespace Baitap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Baitap01();
             Baitap02();
            Baitap03();
             Baitap04();
            Baitap05();
            Baitap06();
            Baitap08();
            Baitap09();*/
            Baitap10();

        }
        static void Baitap01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ket qua phep toan a + b = " + (a + b));
        }
        static void Baitap02()
        {
            Console.Write(" Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ket qua truoc khi hoan doi a:{a} b:{b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Ket qua sau khi doi a:{a} b:{b}");
        }
        static void Baitap03()
        {

            Console.Write("Nhap so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ket qua phep toan a * b = " + (a * b));
        }
        static void Baitap04()
        {
            double value = 0.305;
            float i = 0.026f;

            Console.Write(" Nhap so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap so inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            float met;
            Console.WriteLine($"{feet} feet {inches} inches = " + (feet * value + i * inches) + "met");

        }
        static void Baitap05()
        {
            double f = 32;
            Console.Write(" Nhap do c :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a}do c = " + (a * 9 / 5 + f) + " do F", Math.Round(a, 10));
            Console.Write("Nhap do F: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{b}do F = " + ((b - f) * 5 / 9) + " do C", Math.Round(b, 10));
        }
        static void Baitap06()
        {
            Console.WriteLine("sizeofint : {0}", sizeof(int));
            Console.WriteLine("sizeofchar : {0}", sizeof(char));
            Console.WriteLine("sizeofdouble : {0}", sizeof(double));
            Console.WriteLine("sizeofulong : {0}", sizeof(ulong));
            Console.WriteLine("sizeofbyte : {0}", sizeof(byte));
            Console.WriteLine("sizeofsbyte : {0}", sizeof(sbyte));
            Console.WriteLine("sizeofshort : {0}", sizeof(short));
            Console.WriteLine("sizeoffloat : {0}", sizeof(float));
            Console.WriteLine("sizeofbool : {0}", sizeof(bool));
            Console.WriteLine("sizeofuint : {0}", sizeof(uint));

        }
        static void Baitap08()
        {
            const double pi = 3.14;
            Console.WriteLine("Nhap ban kinh : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Chu vi hinh tron C:" + (r * 2 * pi));
        }
        static void Baitap09()
        {
            Console.WriteLine("Nhap canh : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi hinh vuong:" + (a * 4));


        }
        static void Baitap10()
        {
            Console.WriteLine(" Nhap so ngay vao: ");
            int songay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So nam : " + songay/365 + " so thang: " + (songay % 365)/30 + " so ngay: " + (songay % 365) % 30);
            
            
        }
    }
}

