using System;
using System.Collections.Generic;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<ITurPaket> turlar = new List<ITurPaket>();
            List<ITurFactory> turFactory = new List<ITurFactory>();
            turFactory.Add(new CruiseFactory());
            turFactory.Add(new SafariFactory());
            turFactory.Add(new HikingFactory());

            for (int i = 0; i < 5; i++)
            {
                var turIndex = random.Next(0,turFactory.Count);
                turlar.Add(turFactory[turIndex].CreateTur());
            }
            foreach (var item in turlar)
            {
                item.EnjoyIt();
            }
        }
    }
}
