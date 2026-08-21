using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class BloodStock
{
    public int Id { get; set; }

    public string BloodGroup { get; set; } = null!;

    public int Quantity { get; set; }
}
