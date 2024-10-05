using System;
using System.Runtime.CompilerServices;

namespace B06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = Printarray();
            Console.Write(" Print array : ");
            foreach ( int item in  array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int sel = Menu();
            switch (sel) 
            {
                case 0: Console.WriteLine("Bye Bye, see you again ");
                    break;
                case 1:
                    Console.WriteLine("The average of array : " + Average(array));
                    break;
                case 2: Console.Write(" Starting initiate a specific number "); 
                        int value = int.Parse(Console.ReadLine());
                    if (Iscontain(array, value))
                    {
                        Console.Write($"The number {value} is exsiting in array");
                    }
                    else
                    {
                        Console.Write($"The number {value} isn't exsiting in array");
                    }
                      break;
                case 3:
                    Console.Write(" Starting initiate a specific number ");
                    int number = int.Parse(Console.ReadLine());
                    Location(array, number);
                    break;
                case 4:
                    Console.Write(" Starting initiate a specific number ");
                    int spc = int.Parse(Console.ReadLine());
                    Console.Write(" The array before removing specific element: " );
                    foreach ( int item in array )
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.Write("The array after removing specific element ");
                    foreach( int item in Remove(array,spc))
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 5: Max_Min(array); break;
                case 6:
                    Console.Write(" The array before reversing specific element: ");
                    foreach (int item in array)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.Write(" The array after reversing specific element: ");
                    foreach (int item in Reverse(array))
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 7: Duplicate_value(array); break;
                case 8: Console.Write(" The array before removing ");
                    foreach ( int item in array)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();
                    Console.Write(" The array after removing ");
                    Remove_duplicate(array); break;
                  
            }


        }
        #region Printarray
        static int[] Printarray()
        { Console.Write("Input the length of array : ");
            int size = int.Parse(Console.ReadLine());
           
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10);

            }
            return array;
        }
        #endregion
        #region Average
        static double Average (int[] array)
        { double sum = 0d;
            foreach ( int item in array)
            {
                sum += item; 
            }
            
            return sum / array.Length; 
        }
        #endregion
        #region IScontain
        static bool Iscontain(int[] array, int number)
        {
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i] )
                {
                     check = true;
                    break;
                }
             }
            return check;
        }
        #endregion
        #region Location
        static void Location (int[] array, int value)
        {
            if (Iscontain(array, value))
            {
                Console.Write(" This specific number is located at ");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        Console.Write(i + " ");
                    }
                }
            } else { Console.WriteLine(" This number don't exsit in array "); }
        }
        #endregion
        #region Remove
        static int[] Remove(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    int temp = array[array.Length - 1];
                    array[array.Length - 1] = array[i];
                    array[i] = temp;
                    Array.Resize(ref array, array.Length - 1);
                    i--;
                }
            }
            return array;
        }
        #endregion
        #region Max_Min
        static void Max_Min(int[] array)
        {
            int Max = array[0];
            int Min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max) { Max = array[i]; }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < Min)) { Min = array[i]; }
            }
            Console.WriteLine("The Max value in array : " + Max);
            Console.WriteLine("The Min value in array: " + Min);
        }
        #endregion
        #region reverse
        static int[] Reverse (int[] array)
        {
            for (int i = 0; i<array.Length/2; i++)
            {   int temp = array[i];
                array[i]= array[array.Length-1-i];
                array[array.Length-1-i] = temp;
            }
            return array;
        }
        #endregion
        #region Find_duplicate
        static void Duplicate_value(int[] array)
        {
            Console.Write(" Number has a duplicate : ");
            for ( int i = 0;i<array.Length;i++)
            {
                int count = 0;
                for ( int j = i; j < array.Length; j++)
                {
                    if ( (array[i] == array[j]) && i != j)
                    {
                        count ++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(array[i] + " ");
                }
                
            }
        }
        #endregion
        #region Remove_duplicate
        static void Remove_duplicate(int[] array)
        {
            for ( int i = 0; i<array.Length;i++)
            {
                for ( int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i!=j)
                    {
                        int temp = array[j];
                        array[j] = array[array.Length-1];
                        array[array.Length-1] = temp;
                        Array.Resize(ref array, array.Length-1);
                        j--;
                    }
                }
            }
            foreach ( int i in array)
            {
                Console.Write(i+ " ");
            }

            
        }
        #endregion
        #region Menu
        static int Menu ()
        {
            string menu = @" selection 0: EXIT 
                            1: to calculate the average value of array elements.
                            2 : initiate a specific number before conducting the excercise 3,4,5.
                            3. to test if an array contains a specific value.
                            4. to find the index of an array element.
                            5. to remove a specific element from an array.
                            6. to find the maximum and minimum value of an array.
                            7. to reverse an array of integer values.
                            8. to find duplicate values in an array of values.
                            9. to remove duplicate elements from an array";
            Console.WriteLine(menu);
            int sel = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if ((c && sel >= 0) && (sel <= 9))
                {
                     break;
                }
                else
                {
                    Console.WriteLine("Please enter again: ");
                }
            }
                return sel;
            
        }
        #endregion
    }
}
