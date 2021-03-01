using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25_02_21
{
    public class Sale
    {
        public int Id { get; set; }

        public Car Car { get; set; }

        public Buyer Buyer { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime DateTime { get; set; }
    }
}
