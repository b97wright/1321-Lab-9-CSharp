using System;

namespace Lab9
{
    class Lab9A
    {
        static void Main(string[] args)
        {
            string uI;
            int target = 0;
            bool isfound = false;

            int[] arrNums = new int[10];

            Console.WriteLine("Please enter 10 numbers:");

            // for loop to get array of numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Integer " + (i + 1) + ": ");
                uI = Console.ReadLine();

                arrNums[i] = Convert.ToInt32(uI);
            }

            Console.Write("What is the target number: ");
            uI = Console.ReadLine();

            target = Convert.ToInt32(uI);

            // for loop to loop through and find the target
            for (int i = 0; i < 10; i++)
            {
                if (arrNums[i] == target)
                {
                    isfound = true;
                    break;
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
