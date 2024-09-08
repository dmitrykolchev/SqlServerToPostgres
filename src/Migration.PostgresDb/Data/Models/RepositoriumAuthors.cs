using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RepositoriumAuthors
{
    public long Id { get; set; }

    public long? RepositoriumId { get; set; }

    public string? RepositoriumName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }
}
