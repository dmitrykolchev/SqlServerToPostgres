using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Acquaints
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? NormativeDate { get; set; }

    public long? AcquaintNum { get; set; }

    public long? AcquaintedNum { get; set; }

    public string? Collaborators { get; set; }

    public bool? Status { get; set; }

    public long? ReacquaintancePeriod { get; set; }

    public List<long>? AssessmentsId { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
