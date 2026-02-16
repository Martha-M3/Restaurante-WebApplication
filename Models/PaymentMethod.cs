using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Table("PaymentMethod")]
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Expenses = new HashSet<Expense>();
            Sales = new HashSet<Sale>();
        }

        [Key]
        [Column("PaymentMethodID")]
        public int PaymentMethodId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(200)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [InverseProperty("PaymentMethod")]
        public virtual ICollection<Expense> Expenses { get; set; }
        [InverseProperty("PaymentMethod")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
