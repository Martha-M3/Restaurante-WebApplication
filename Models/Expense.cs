using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    public partial class Expense
    {
        [Key]
        [Column("ExpenseID")]
        public int ExpenseId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(200)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpenseDate { get; set; }
        [StringLength(20)]
        public string? Status { get; set; }
        [Column("PaymentMethodID")]
        public int? PaymentMethodId { get; set; }
        public int? Quantity { get; set; }
        [Column("MenuID")]
        public int? MenuId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Expenses")]
        public virtual ExpenseCategory? Category { get; set; }
        [ForeignKey("PaymentMethodId")]
        [InverseProperty("Expenses")]
        public virtual PaymentMethod? PaymentMethod { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Expenses")]
        public virtual User? User { get; set; }
    }
}
