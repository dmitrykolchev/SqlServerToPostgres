using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Presentations
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? FileId { get; set; }

    public long? EventId { get; set; }

    public long? VclassSettingId { get; set; }

    public DateTime? ModificationDate { get; set; }
}
