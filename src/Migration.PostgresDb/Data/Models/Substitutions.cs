using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Substitutions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Status { get; set; }

    public long? SubstitutionTypeId { get; set; }

    public string? TargetObjectType { get; set; }

    public string? TargetObjectSelector { get; set; }

    public List<long>? TargetObjectId { get; set; }

    public string? DataStr { get; set; }

    public string? PersonSelector { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
