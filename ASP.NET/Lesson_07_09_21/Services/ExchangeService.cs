using System;
using System.Collections.Generic;

namespace Lesson_07_09_21.Services
{
    
    public interface IExchangeService
    {
        public double Convert(string from, string to, double amount);
        public void AddRate(string curency, double rate);
        }
    
    public class ExchangeService : IExchangeService
    {
        private static Dictionary<string, double> exchangeRate = new Dictionary<string, double>()
        {
            ["USD"] =  1.7 ,
            ["RUBL"] =  0.023,
            ["EUR"] = 2.01,
            ["GBP"] = 2.34,
            ["AZN"] = 1
        };
           

        public double Convert(string from, string to, double amount)
        {
            try
            {
                return amount * exchangeRate[from] / exchangeRate[to];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddRate(string curency, double rate)
        {
            exchangeRate.Add(curency, rate);
        }
    }
}
