using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDevice(new SamsungFactory());
        }

        public static void UseDevice(ITechCompany company)
        {
            var phone = company.CreatePhone();
            var tablet = company.CreateTablet();
            var watch = company.CreateWatch();

            phone.Call();
            tablet.WtchVideo();
            watch.ShowSteps();
        }
    }
}
