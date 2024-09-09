using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnApplications
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PostLicensedId { get; set; }

    public long? ActivityId { get; set; }

    public long? ApplicationTypeId { get; set; }

    public bool? FlToConcern { get; set; }

    public long? LicenseId { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? FactDate { get; set; }

    public DateTime? FactDateRtn { get; set; }

    public bool? FlNotApply { get; set; }

    public string? Note { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
