using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_05_08_21.Services
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToString("hh:mm:ss");
    }

    public static class ServiceProviderExtentions
    {
        public static IServiceCollection AddTimeService(this IServiceCollection services)
        {
            return services.AddTransient<TimeService>();
        }
    }
}
