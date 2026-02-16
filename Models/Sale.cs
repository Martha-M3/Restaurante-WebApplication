using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    public partial class Sale
    {
        [Key]
        [Column("SaleID")]
        public int SaleId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SaleDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [StringLength(20)]
        public string? Status { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column("PaymentMethodID")]
        public int? PaymentMethodId { get; set; }
        public int Quantity { get; set; }
        [Column("MenuID")]
        public int? MenuId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Sales")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("MenuId")]
        [InverseProperty("Sales")]
        public virtual Menu? Menu { get; set; }
        [ForeignKey("PaymentMethodId")]
        [InverseProperty("Sales")]
        public virtual PaymentMethod? PaymentMethod { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Sales")]
        public virtual User? User { get; set; }
    }
}
