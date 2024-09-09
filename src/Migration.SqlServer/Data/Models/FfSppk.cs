using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class FfSppk
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public long? ResponsePerson { get; set; }

    public long Station { get; set; }

    public long Division { get; set; }

    public bool? IsNorm { get; set; }

    public long? EduTypeId { get; set; }

    public int? DurPractice { get; set; }

    public int? DurTheory { get; set; }

    public int? DurTotal { get; set; }

    public int? DurStaging { get; set; }

    public int? DurEquip { get; set; }

    public int? DurDouble { get; set; }

    public int? DurAdditional { get; set; }

    public string? NormUncheck { get; set; }

    public long? ResponsePosition { get; set; }

    public virtual ICollection<FfSppkDates> FfSppkDates { get; set; } = new List<FfSppkDates>();
}
