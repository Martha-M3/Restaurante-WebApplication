using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Keyless]
    public partial class VwMonthlyExpense
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        [StringLength(100)]
        public string ExpenseCategoryName { get; set; } = null!;
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? TotalAmount { get; set; }
        public int? NumberOfExpenses { get; set; }
    }
}
