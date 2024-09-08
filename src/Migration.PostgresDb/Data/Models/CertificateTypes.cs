using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CertificateTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? EducationOrgId { get; set; }

    public long? RequiredQuantity { get; set; }

    public double? Duration { get; set; }

    public bool? Forever { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
