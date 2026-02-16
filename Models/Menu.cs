using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Table("Menu")]
    public partial class Menu
    {
        public Menu()
        {
            Sales = new HashSet<Sale>();
        }

        [Key]
        [Column("MenuID")]
        public int MenuId { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public bool? IsAvailable { get; set; }

        [InverseProperty("Menu")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
