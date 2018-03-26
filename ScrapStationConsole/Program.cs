using System;

namespace MachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var module = ScrapPrediction.IsScrap(new Double[] { 1.0, 1.276541629, 15.88239006 });
            Console.WriteLine($"This should not be Scrap -> Probability :{module.Item1:N2}  Scrap : {module.Item2}");

            module = ScrapPrediction.IsScrap(new Double[] { 1.0, 2.815402647, 8.265707992 });
            Console.WriteLine($"This should be Scrap -> Probability :{module.Item1:N2}  Scrap : {module.Item2}");

            Console.ReadKey();

        }
    }
}
