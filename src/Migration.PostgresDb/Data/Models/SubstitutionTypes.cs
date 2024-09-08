using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class SubstitutionTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public string? OperationCodes { get; set; }

    public List<long>? OperationId { get; set; }

    public string? RemoteActionCodes { get; set; }

    public List<long>? RemoteActionId { get; set; }

    public string? DataStr { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
