namespace Lesson_25_02_21
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reqem")]
    public partial class Reqem
    {
        public int id { get; set; }

        public int eded { get; set; }
    }
}
