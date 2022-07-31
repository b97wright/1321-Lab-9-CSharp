using System;

namespace Lab9
{
    class Lab9A
    {
        static void Main(string[] args)
        {
            string uI;
            int size = 11;
            int[] arrNums = new int[size];
            int target = 0, low = 0, mid = 0, high = arrNums.Length - 1;
            bool isfound = false;


            Console.WriteLine("Please enter 11 numbers:");

            // for loop to get array of numbers
            for (int i = 0; i < size; i++)
            {
                Console.Write("Integer " + (i + 1) + ": ");
                uI = Console.ReadLine();

                arrNums[i] = Convert.ToInt32(uI);
            }

            Array.Sort(arrNums);

            Console.Write("What is the target number: ");
            uI = Console.ReadLine();

            target = Convert.ToInt32(uI);


            Console.Write("The sorted set is: ");

            for (int i = 0; i < size; i++)
            {
                Console.Write(arrNums[i] + " ");
            }

            Console.Write("\n");

            // while loop to loop throught array binary style to find number 
            while (low <= high)
            {
                mid = (low + high) / 2;
                Console.WriteLine("Low is " + low);
                Console.WriteLine(" ");
                Console.WriteLine("High is " + high);
                Console.WriteLine(" ");
                Console.WriteLine("Mid is " + mid);
                Console.WriteLine(" ");
                Console.WriteLine("Searching");
                Console.WriteLine(" ");


                // see if current mid is target 
                if (target == arrNums[mid])
                {
                    isfound = true;
                    break;
                }
                else if (target < arrNums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (isfound)
            {
                Console.Write("The target is in the set. ");
            }
            else
            {
                Console.Write("The target is not in the set. ");
            }
        }
    }
}
