using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Responses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public long? ResponseTypeId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public long? OwnerPersonId { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public double? BasicScore { get; set; }

    public string? BasicDesc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DoneDate { get; set; }

    public bool? IsPublic { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
