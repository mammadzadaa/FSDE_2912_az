namespace Lesson_25_02_21
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

        public int? StatusId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPriece { get; set; }

        public DateTime Time { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Status Status { get; set; }
    }
}
