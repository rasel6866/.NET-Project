using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs
{
    public class DonorDTO
    {
        public int Id { get; set; }

        [Required]
        public string BloodGroup { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        public string Phone { get; set; } = null!;

        public DateTime LastDonationDate { get; set; }

        [Required]
        public string Uid { get; set; } = null!;
    }
}