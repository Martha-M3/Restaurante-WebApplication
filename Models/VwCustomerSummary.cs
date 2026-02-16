using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Keyless]
    public partial class VwCustomerSummary
    {
        [StringLength(100)]
        public string CustName { get; set; } = null!;
        [StringLength(20)]
        public string CustPhoneNumber { get; set; } = null!;
        public int? TotalPurchases { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal TotalSpent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPurchaseDate { get; set; }
    }
}
