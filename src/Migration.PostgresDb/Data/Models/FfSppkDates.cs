using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class FfSppkDates
{
    public long Id { get; set; }

    public long FfSppkId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? FinishDate { get; set; }

    public string? Place { get; set; }

    public long? PersonsCnt { get; set; }

    public virtual FfSppk FfSppk { get; set; } = null!;

    public virtual ICollection<FfSppkPersons> FfSppkPersons { get; set; } = new List<FfSppkPersons>();
}
