using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CaApprove
{
    public int Id { get; set; }

    public int CaPlanId { get; set; }

    public long RequestId { get; set; }

    public int Year { get; set; }

    public bool IsCentral { get; set; }

    public bool IsEdu { get; set; }

    public string StantionName { get; set; } = null!;

    public string? EduOrgName { get; set; }

    public long? EduOrgId { get; set; }

    public long EmId { get; set; }

    public string? EmCode { get; set; }

    public string EmName { get; set; } = null!;

    public int Duration { get; set; }

    public double DurationDay { get; set; }

    public double? Cost { get; set; }

    public double? CostDay { get; set; }

    public DateTime FinishDate { get; set; }

    public string? Division { get; set; }

    public string? Comment { get; set; }

    public DateTime StartDate { get; set; }

    public int? PersonNum { get; set; }

    public bool? IsMass { get; set; }

    public virtual CaPlan CaPlan { get; set; } = null!;
}
