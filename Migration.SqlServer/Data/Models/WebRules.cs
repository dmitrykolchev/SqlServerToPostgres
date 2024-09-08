using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class WebRules
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? IsPattern { get; set; }

    public string? RedirectUrl { get; set; }

    public long? RedirectType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? UseMatches { get; set; }
}
