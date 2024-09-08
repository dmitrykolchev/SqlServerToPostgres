using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class FfSppkPersons
{
    public long Id { get; set; }

    public long FfSppkDatesId { get; set; }

    public long PersonId { get; set; }

    public bool IsFinished { get; set; }

    public int? DurPractice { get; set; }

    public int? DurTheory { get; set; }

    public int? DurTotal { get; set; }

    public int? DurStaging { get; set; }

    public int? DurEquip { get; set; }

    public int? DurDouble { get; set; }

    public int? DurAdditional { get; set; }

    public long? ResponsePerson { get; set; }

    public long? ResponsePosition { get; set; }

    public virtual FfSppkDates FfSppkDates { get; set; } = null!;
}
