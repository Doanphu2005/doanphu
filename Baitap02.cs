namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baitap01();
            Baitap02();
            Baitap03();
        }
            static void Baitap01()
            {
                Console.Write("Input value Celsius: ");
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine($" {c} Celsius = " + (c + 273) + "Kelvin");
                Console.WriteLine($" {c} Celsius = " + (c * 18 / 10 + 32) + "fahrenheit");

            }
            static void Baitap02()
            { 
                Console.Write(" Input value radius: ");
                float radius = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine(" The surface of a sphere =" + (4 * Math.PI * Math.Pow(radius,2)));
            Console.WriteLine(" The volume of a sphere =" + (4 / 3 * Math.PI * Math.Pow(radius, 3)));
            }
            static void Baitap03()
        {
            Console.Write("Input value a: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input value b: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{a} + {b} =" + (a + b));
            Console.WriteLine($"{a} - {b} =" + (a - b));
            Console.WriteLine($"{a} * {b} =" + (a * b));
            Console.WriteLine($"{a} / {b} =" + (a / b));
            Console.WriteLine($"{a} mod {b} =" + (a % b));

        }

        //Console.WriteLine("Mama said : "Life was chocolate") thi no se chui
        //Cach viet dung Console.WriteLine("""Mama said : " Life was chocolate" """); cach 1
        // CAch viet 2 Console.WriteLine("Mama said: \'Life was chocolate\"");
        // void la duoc hieu theo kieu tra ve cai bai tap do de no thuc hien bai tap do, vd : void Baitap  nhu tren thi no se thuc hienj bai tap  co nghia no se lam baitap 03 de tra ve du lieu bai tap3
        // Phep eo kieu vd : int a = 11; long b = a thi oke vi kieu long > kieu int va vi vay khi ma gan b = a co nghia b se bao du gia tri ma a co the co 
        // nhung ma neu nguoc lai la int c = b thi khong duoc vi b la kieu long ma kieu long> kieu int cua c thi c se khong bao quat dc tat ca cac gia tri cua b VD: gia tri cua c chi toi 100 ma b toi 1000 v ma cho c = b thi int c =1000 thi khog hop le vi max value c chi toi 100, con nguoc lai long b = c bao quat duoc c ( c can have value 100 vi 100 van thuoc trong vung gia tri cua c ) nen nhan ok

    }

}
    


