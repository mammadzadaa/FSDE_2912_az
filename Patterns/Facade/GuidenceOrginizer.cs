using System;

namespace Facade
{
    partial class Program
    {
        public static class GuidenceOrginizer
        {
            public static void GetOnlineGuidance()
            {
                Console.WriteLine("Guidance will be provided online");
            }
            public static void GetOfflineGuidance()
            {
                Console.WriteLine("Guide will meet you");
            }
        }
    }
}
