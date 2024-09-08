using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DigitalSignatures
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? SignDate { get; set; }

    public bool? IsSigned { get; set; }

    public long? CustomWebTemplateId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
