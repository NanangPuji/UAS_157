using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_157
{
    class program
    {
        int[] nanang = new int[15];
        int n, temp;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 15)
                    break;
                else
                    Console.WriteLine("\nArray can only have a maximum of 15 elements \n");
            }
            Console.WriteLine("\n===================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n===================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                nanang[i] = Int32.Parse(s1);

            }
        }
    }

    public void InsertionSort()
    {
        for (int i = 0; i < n; i ++)
        {
            temp = nanang[i];
            int pass = 0;
            for (int np = i- 1; np >= 0 && pass != 1;)
            {
                if (temp < nanang[np])
                {
                    nanang[np + 1] = nanang[np];
                    np--;
                    nanang[np + 1] = temp;
                }
                else pass = 1;
            }
        }

    }

     public void SortMerge(int[] array, int low, int high, int mid)
        {
            // Create temporary arrays to hold the subarrays
            // that we will merge
            int[] left = new int[mid - low + 1];
            int[] right = new int[high - mid];

            // Copy the data into the temporary arrays
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[low + i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = array[mid + 1 + i];
            }

            // Merge the temporary arrays back into the original array
            int leftIndex = 0;
            int rightIndex = 0;
            int currentIndex = low;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    array[currentIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[currentIndex] = right[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
            }

            // Copy the remaining elements from the left array, if any
            while (leftIndex < left.Length)
            {
                array[currentIndex] = left[leftIndex];
                leftIndex++;
                currentIndex++;
            }

            // Copy the remaining elements from the right array, if any
            while (rightIndex < right.Length)
            {
                array[currentIndex] = right[rightIndex];
                rightIndex++;
                currentIndex++;
            }
        }

    public void display()
    {
        Console.WriteLine("\n-----------------------");
        Console.WriteLine(" Sorted array elements ");
        Console.WriteLine("-------------------------");

        for (int np = 0; np < np; np++)
        {
            Console.WriteLine(nanang[np]);
        }
    }

    static void Main(string[] args)
    {
        Program myApp = new Program();
        int pilihan;
        char ch;
        do
        {
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("=============");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Merge Sort");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice (1,2,3) : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Insertion Sort");
                        Console.WriteLine("................");
                        myApp.input();
                        myApp.InsertionSort();
                        myApp.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Merge Sort");
                        Console.WriteLine("................");
                        myApp.input();
                        myApp.SortMerge();
                        myApp.display();

                        break;
                    case 3:
                        Console.WriteLine("exit.");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("\nPilih menu lagi? (y/n) : ");
                ch = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();


            }
            while (ch == 'y');
            //to exit from the console
            Console.WriteLine("\n\nPress return to exit. ");
            Console.ReadLine();
        } while (pilihan != 3);

    }

    private void SortMerge() => new NotImplementedException();
}
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
