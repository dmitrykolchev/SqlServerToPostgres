using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Roles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentRoleId { get; set; }

    public string? CatalogName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }
}
