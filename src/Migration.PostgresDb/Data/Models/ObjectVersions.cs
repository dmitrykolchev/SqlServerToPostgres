using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectVersions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? CatalogName { get; set; }

    public long? ObjectId { get; set; }

    public DateTime? ObjectModificationDate { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
