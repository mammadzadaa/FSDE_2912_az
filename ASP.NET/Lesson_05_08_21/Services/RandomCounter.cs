using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_05_08_21.Services
{
    public class RandomCounter : ICounter
    {
        static Random rnd = new Random();
        private int _value;
        public int Value => _value;
        public RandomCounter()
        {
            _value = rnd.Next(0,100000);
        }
    }
}
