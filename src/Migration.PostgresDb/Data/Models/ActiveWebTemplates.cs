using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ActiveWebTemplates
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRole { get; set; }

    public string? Mode { get; set; }

    public long? WebDesignId { get; set; }

    public long? SiteId { get; set; }

    public string? Hash { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
