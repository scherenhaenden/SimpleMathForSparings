using System.Collections.Generic;

namespace EconomicalQuestions.Simulations
{
    public class SavingWithSharesSimpleCase
    {
        public  List<string> Run(int yearlySaving, double averageDividends, int years)
        {

            double spares = 0;
            double ownInvestment = 0;
            List<string> sumOfOutPuts = new List<string>();
            

            for (int i = 0; i < years; i++)
            {
                spares += yearlySaving;
                ownInvestment += yearlySaving;
                var possibleGaining = spares * averageDividends;

                var difference = possibleGaining - spares;

                difference = difference * 2  / 3;

                spares = spares + difference;
                
                sumOfOutPuts.Add(CreateString(i+1, spares, ownInvestment, (spares - ownInvestment), difference));
            }

            return sumOfOutPuts;
        }


        public string CreateString(int year, double money, double ownInvestment, double winningsFromPercentage, double winningsCurrentYear)
        {
            return $"Year number {year} i would have so much money: {money}. OwnInvestment {ownInvestment}. Cumulated winnings {winningsFromPercentage}. Winnings current year {winningsCurrentYear}";
        }
        
        
        
    }
}