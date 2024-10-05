using System.ComponentModel.Design;

namespace Manglomcho_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sel = Menu();
            if ( sel ==0)
            {
                Console.WriteLine("Bye Bye hahah");
            }
            if (sel == 1)
            {
                int[][] array = bai1();

                for (int i = 0; i < array.Length; i++) 
                {
                    Console.Write($"Rows {i} : ");
                    for ( int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j]+" ");
                    }
                    Console.WriteLine();
                }
            }
            if (sel == 2)
            {
                int[][] jagged = bai2();
                for (int i = 0; i < jagged.Length; i++)
                {
                    Console.Write($"Row {i} :");
                    for (int j = 0;j < jagged[i].Length; j++)
                    {
                        Console.Write($"{jagged[i][j]}"+ " ");
                    }
                    Console.WriteLine() ;
                    
                }
                int chose = menu2();
                switch (chose)
                {
                    case 1:
                        Max(jagged);
                        break;
                    case 2:
                        int[][] sort = Sort(jagged);

                        for (int i = 0; i < sort.Length; i++)
                        {
                            Console.Write($"Row {i} :");
                            for (int j = 0; j < sort[i].Length; j++)
                            {
                                Console.Write($"{jagged[i][j]}" + " ");
                            }
                            Console.WriteLine();
                        }
                        break; 
                        case 3:
                        Primenumber(jagged);
                        break;
                    case 4: Console.Write("Input the value that is found: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        Positions(jagged, value);
                        break;

                }
            }
           
        } static int[][] bai1()
        {
            int[][] array = new int[4][];
            array[0] = new int[4] { 1, 1, 1, 1 };
            array[1] = new int[2] { 2, 2 };
            array[2] = new int[4] { 3, 3, 3, 3 };
            array[3] = new int[2] { 4, 4 };
            return array;
        }
        static int[][] bai2()
        {   Random r = new Random();
            int[][] array = new int[4][];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" Input the variable in row {i} : ");
                int a = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[a];
                for (int j = 0;j < array[i].Length; j++)
                {
                    array[i][j] = r.Next(0, 20);
                }
            }
            return array;
        } static void Max(int[][] array)
        {
            int Max_whole = array[0][0];
            for (int i = 0;i < array.Length; i++)
            {
                int max = array[i][0];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (max < array[i][j])
                    {
                        max = array[i][j];
                    }
                }
                if(max > Max_whole)
                {
                    Max_whole = max;
                }
                Console.WriteLine($"The biggest number in row {i} : {max}");
            }
            Console.WriteLine("The biggest number in whole array " + Max_whole );
        }
        static int[][] Sort(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for ( int k = j; k< array[i].Length; k++)
                    {
                        if (array[i][j] > array[i][k])
                        {
                            int temp = array[i][j];
                            array[i][j] = array[i][k];
                            array[i][k] = temp;
                        }
                    }
                }

            }
            return array;
        } static void Primenumber(int[][] array)
        {

            Console.WriteLine(" Prime numbers : ");
            for (int i = 0; i < array.Length; i++)
            {
                bool key = true;
                Console.Write($"Row{i}: ");
                for (int j = 0; j < array[i].Length; j++)
                {
                    key = true;
                    for (int k = 2; k <= array[i][j] / 2; k++)
                    {
                        if (array[i][j] % k == 0)
                        {
                            key = false;
                            break;
                        }
                    }
                    if (array[i][j] == 0)
                    {
                        key = false;
                    }
                    if (key)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Positions(int[][] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                Console.Write($" Position of {value} in row " + i + " : ");
                for (int j = 0;j < array[i].Length; j++)
                {
                    if ( value == array[i][j])
                    {
                        count++;
                        Console.Write(j + " ");
                        
                    }
                }
                if ( count == 0)
                {
                    Console.Write("No exsiting ");
                }
                Console.WriteLine();
            }
        }

        static int Menu()
        {
            int sel = 0;

            string abc = @" Create a jagged array and initialize it using the following values for its rows and columns;
        Then, display it.
        1 1 1 1 1
        2 2
        3 3 3 3
        4 4
        2. Create a Jagged Array with random integer numbers (or by user input) by getting the
        number of rows and columns from the user and printing the data in the array to the user.
        Then, create functions to implement following tasks:
        1. Print the biggest number of each row and the largest number of the whole array.
        2. Sort values ascending of each row.
        3. Print items of the array that are prime.
        4. Search and print all positions of a number (enter from the user).";
            Console.WriteLine(abc);
            while (true)
            { 
                bool c = int.TryParse(Console.ReadLine(),out sel);
                if (( sel >=0 && c) && (sel <= 2))
                {
                    break;
                }
                else
                {
                    Console.Write("Please enter again: ");
                }
            }
         return sel;
        } 
        static int menu2 ()
        {
            int chose = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out chose);
                if ((chose >= 0 && c) && (chose <= 4))
                {
                    break;
                }
                else
                {
                    Console.Write("Please enter again: ");
                }
            }
            return chose;
        }
    }
}
