namespace Lesson_25_02_21
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdersLog")]
    public partial class OrdersLog
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int? StatusId { get; set; }

        public DateTime Time { get; set; }

        public virtual LogStatu LogStatu { get; set; }
    }
}
