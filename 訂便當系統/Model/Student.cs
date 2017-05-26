namespace 訂便當系統.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int Student_Id { get; set; }

        [StringLength(50)]
        public string Student_Name { get; set; }

        [StringLength(50)]
        public string Student_Address { get; set; }

        [StringLength(50)]
        public string Student_Phone { get; set; }

        public int? Class_Id { get; set; }

        public virtual Classroom Classroom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
