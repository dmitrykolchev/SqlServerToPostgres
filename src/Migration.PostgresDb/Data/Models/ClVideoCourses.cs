using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ClVideoCourses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public DateTime? LastCompileDate { get; set; }

    public long? MediaFileId { get; set; }

    public long? SimpleMediaFileId { get; set; }

    public List<long>? AuthorsId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? CreationDate { get; set; }
}
