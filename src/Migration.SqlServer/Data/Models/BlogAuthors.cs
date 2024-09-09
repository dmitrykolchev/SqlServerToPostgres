using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class BlogAuthors
{
    public long Id { get; set; }

    public long? BlogId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? IsFullModerator { get; set; }
}
