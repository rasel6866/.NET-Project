using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class BloodRequest
{
    public int Id { get; set; }

    public string PatientName { get; set; } = null!;

    public string BloodGroup { get; set; } = null!;

    public string Hospital { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public int Uid { get; set; }

    public int Did { get; set; }
}
