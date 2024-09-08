using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonHierarchys
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PositionId { get; set; }

    public long? ParentSubId { get; set; }

    public List<long>? SubdivisionId { get; set; }

    public bool? Ready { get; set; }
}
