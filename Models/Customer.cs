using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Restaurante_WebApplication.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        [Key]
        [Column("CustID")]
        public int CustId { get; set; }
        [StringLength(100)]
        public string CustName { get; set; } = null!;
        [StringLength(20)]
        public string? CustPhoneNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
