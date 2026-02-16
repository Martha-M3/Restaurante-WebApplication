using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Stocks = new HashSet<Stock>();
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? CurrentStock { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Products")]
        public virtual ProductCategory? Category { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
