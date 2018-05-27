using System;

namespace MonteCarloExample
{
    class Program
    {
        private static MonteCarloPiService _piService = new MonteCarloPiService();

        static void Main(string[] args)
        {
            var pi = _piService.Get();

            Console.WriteLine($"Pi approximation: {pi}");
            Console.ReadLine();
        }
    }
}
