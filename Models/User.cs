using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    [Index("EmailAddress", Name = "UQ__Users__49A14740BB42EE3F", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            Expenses = new HashSet<Expense>();
            Sales = new HashSet<Sale>();
            Stocks = new HashSet<Stock>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        public string EmailAddress { get; set; } = null!;
        [StringLength(100)]
        public string Password { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Expense> Expenses { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Sale> Sales { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
