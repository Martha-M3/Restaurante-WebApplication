using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Keyless]
    public partial class VwDailySale
    {
        [Column(TypeName = "date")]
        public DateTime? SaleDay { get; set; }
        public int? TotalTransactions { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? TotalSales { get; set; }
        public int? TotalItemsSold { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; } = null!;
        [StringLength(100)]
        public string CustomerName { get; set; } = null!;
    }
}
