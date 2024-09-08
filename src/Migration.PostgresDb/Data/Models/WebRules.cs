using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WebRules
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? IsPattern { get; set; }

    public bool? UseMatches { get; set; }

    public string? RedirectUrl { get; set; }

    public long? RedirectType { get; set; }

    public long? RedirectWebModeId { get; set; }

    public long? Weight { get; set; }

    public long? WebDesignId { get; set; }

    public long? SiteId { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }
}
