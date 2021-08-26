using System;
using EconomicalQuestions.Simulations;

namespace EconomicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            var savingWithSharesSimpleCase = new SavingWithSharesSimpleCase();

            var results = savingWithSharesSimpleCase.Run(2000, (1.04), 30);


            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            
            
            Console.WriteLine("Hello World!");
        }
    }
}