using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PersonObjectLinkObjects
{
    public long Id { get; set; }

    public long? PersonObjectId { get; set; }

    public string? PersonObjectType { get; set; }

    public string? ObjectCatalog { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public bool? CanEdit { get; set; }

    public bool? CanDelete { get; set; }

    public long? SubjectId { get; set; }

    public string? SubjectType { get; set; }
}
