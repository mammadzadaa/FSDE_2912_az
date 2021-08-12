using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_12_08_21.Models
{
    public static class SampleData
    {
        public static void Initilize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Model = "Iphone 12 Pro",
                        Vendor = "Apple",
                        Price = 2700
                    },
                    new Phone
                    {
                        Model = "Galaxy S21 Ultra",
                        Vendor = "Samsung",
                        Price = 2899
                    },
                    new Phone
                    {
                        Model = "Pocco M3",
                        Vendor = "Xiaomi",
                        Price = 350
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
