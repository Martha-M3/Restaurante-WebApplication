using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [Column("StockID")]
        public int StockId { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        public int? CreditQuantity { get; set; }
        public int? DebitQuantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [StringLength(20)]
        public string? Status { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("PaymentMethodID")]
        public int? PaymentMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MovementDate { get; set; }
        [StringLength(200)]
        public string? Notes { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("Stocks")]
        public virtual Product? Product { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Stocks")]
        public virtual User? User { get; set; }
    }
}
