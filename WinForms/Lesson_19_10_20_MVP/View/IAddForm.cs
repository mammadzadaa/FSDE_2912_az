using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.View
{
    public interface IAddForm
    {
        string Title { get; }
        string Description { get; }

        event Action Add;
    }
}
