using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CaPlanUpdatesDuration
{
    public int Id { get; set; }

    public int Year { get; set; }

    public long EmId { get; set; }

    public DateTime CreateDate { get; set; }

    public double? Duration { get; set; }

    public long UserId { get; set; }

    public bool? IsLast { get; set; }
}
