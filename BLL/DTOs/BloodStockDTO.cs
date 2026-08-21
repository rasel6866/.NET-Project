using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs
{
    public class BloodStockDTO
    {
        public int Id { get; set; }

        [Required]
        public string BloodGroup { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }
    }
}