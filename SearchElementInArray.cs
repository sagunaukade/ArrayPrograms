using System;

namespace ArrayPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[55];
            int i, n1, flag = 0, n;

            Console.WriteLine("Enter the size of array elements===>");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements===>");

            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the search element==>");
            n1 = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (arr[i] == n1)
                {
                    flag = 1;
                    Console.WriteLine("Number " + n1 + "found at position" + (i + 1));
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is not found in array==>" + n1);
                Console.ReadLine();
            }

        }
    }
}
