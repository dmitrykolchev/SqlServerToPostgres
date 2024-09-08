using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonObjectLinks
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? SubjectId { get; set; }

    public string? SubjectType { get; set; }

    public string? ObjectCatalog { get; set; }

    public string? Title { get; set; }

    public bool? AllCanCreate { get; set; }

    public bool? AllCanEdit { get; set; }

    public bool? AllCanDelete { get; set; }

    public DateTime? ModificationDate { get; set; }
}
