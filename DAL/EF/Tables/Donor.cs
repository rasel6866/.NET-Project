using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Donor
{
    public int Id { get; set; }

    public string BloodGroup { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime LastDonationDate { get; set; }

    public string Uid { get; set; } = null!;
}
