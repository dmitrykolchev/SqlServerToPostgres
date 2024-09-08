using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalInstructors
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? Code { get; set; }

    public long? UtpDivision { get; set; }

    public short? NotInState { get; set; }

    public long? StationId { get; set; }

    public DateTime? StartWorkingDate { get; set; }

    public string? Direction { get; set; }

    public string? Comment { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
