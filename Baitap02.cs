namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Baitap01();
            //Baitap02();
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
        }
        
        }
    


