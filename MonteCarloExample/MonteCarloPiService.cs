using System;

namespace MonteCarloExample
{
    public class MonteCarloPiService
    {
        private Random _randomGenerator = new Random();
        private int _iterations = 100000000;

        public double Get()
        {
            var hits = 0;

            for (var i = 0; i <= _iterations; i++)
            {
                var x = _randomGenerator.NextDouble();
                var y = _randomGenerator.NextDouble();

                if (x * x + y * y <= 1) hits += 1;
            }

            var pi = (hits / (double) _iterations) * 4;
            return pi;
        }
    }
}