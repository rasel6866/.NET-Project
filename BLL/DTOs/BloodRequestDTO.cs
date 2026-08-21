using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs
{
    public class BloodRequestDTO
    {
        public int Id { get; set; }

        [Required]
        public string PatientName { get; set; } = null!;

        [Required]
        public string BloodGroup { get; set; } = null!;

        [Required]
        public string Hospital { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;

        public DateTime RequestDate { get; set; }

        public int Uid { get; set; }

        public int Did { get; set; }
    }
}