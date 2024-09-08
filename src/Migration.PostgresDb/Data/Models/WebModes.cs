using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WebModes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsDefault { get; set; }

    public string? CatalogName { get; set; }

    public long? PlaceholderTemplateId { get; set; }

    public long? WebDesignId { get; set; }

    public long? SiteId { get; set; }

    public bool? UseFcache { get; set; }

    public bool? SearchablePortal { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
