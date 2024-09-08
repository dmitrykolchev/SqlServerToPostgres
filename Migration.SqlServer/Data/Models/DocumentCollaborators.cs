using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DocumentCollaborators
{
    public long Id { get; set; }

    public string? ParentObjectType { get; set; }

    public long? ParentObjectId { get; set; }

    public string? ParentObjectName { get; set; }

    public long? SiteId { get; set; }

    public long? DocumentId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? CanCreate { get; set; }

    public bool? CanEdit { get; set; }

    public bool? CanDelete { get; set; }
}
