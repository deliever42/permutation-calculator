using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Permutation_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _n, _r;
            int n, r;

            Console.Write("Please enter number of employees: ");

            _n = Console.ReadLine();
            Console.Clear();

            if (!IsNumeric(_n))
            {
                Console.WriteLine("Invalid employees was provided.");
                HandleClose();
            }

            n = Int32.Parse(_n);

            if (n < 1)
            {
                Console.WriteLine("Employees must be greater than 0!");
                HandleClose();
            }

            Console.Write("Please enter number of selections: ");

            _r = Console.ReadLine();
            Console.Clear();

            if (!IsNumeric(_r))
            {
                Console.WriteLine("Invalid selections was provided.");
                HandleClose();
            }

            r = Int32.Parse(_r);

            if (r < 1)
            {
                Console.WriteLine("Selections must be greater than 0!");
                HandleClose();
            }

            Console.WriteLine($"Permutation result: {Calculate(n, r)}");
            HandleClose();
        }

        private static bool IsNumeric(string value)
        {
            try
            {
                return Convert.ToBoolean(Int32.Parse(value));
            }
            catch
            {
                return false;
            }
        }

        private static void HandleClose()
        {
            Console.WriteLine("\nThe program will be automatically closed after 5 seconds.");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }

        private static int Calculate(int n, int r)
        {
            return Factor(n) / Factor(n - r);
        }

        private static int Factor(int n)
        {
            int factor = n;

            for (int i = 1; i <= n - 1; i++)
            {
                factor *= i;
            }

            return factor;
        }
    }
}
