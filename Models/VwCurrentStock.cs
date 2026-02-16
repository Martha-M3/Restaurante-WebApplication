using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Keyless]
    public partial class VwCurrentStock
    {
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        public string? CategoryName { get; set; }
        public int CurrentStock { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(21, 2)")]
        public decimal? TotalValue { get; set; }
    }
}
