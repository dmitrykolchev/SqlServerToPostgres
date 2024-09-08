using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPmtoObservationSpecialists
{
    public long Id { get; set; }

    public long? Observation { get; set; }

    public long? Collaborator { get; set; }

    public string? Fullname { get; set; }

    public string? Position { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
