using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ProfessionalAreas
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? ParentId { get; set; }

    public long? ProfessionalAreaTypeId { get; set; }

    public string? Comment { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
