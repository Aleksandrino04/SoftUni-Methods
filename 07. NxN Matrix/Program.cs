using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MatrixCreator(number);
        }

        private static void MatrixCreator(int number)
        {
            for (int rows = 0; rows < number; rows++)
            {
                for (int col = 0; col < number; col++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
