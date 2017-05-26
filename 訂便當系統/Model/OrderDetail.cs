namespace 訂便當系統.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        public int OrderDetail_Id { get; set; }

        public int? Order_Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Qty { get; set; }

        public virtual Order Order { get; set; }
    }
}
