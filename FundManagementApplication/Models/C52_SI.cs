﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundManagementApplication.Models
{
    [Table("C52.SI")]
    public partial class C52_SI
    {
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(45)]
        public string Ticker { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(11, 10)")]
        public decimal DR { get; set; }

        [ForeignKey(nameof(Ticker))]
        [InverseProperty(nameof(Shares_Weightage.C52_SI))]
        public virtual Shares_Weightage TickerNavigation { get; set; }
    }
}
