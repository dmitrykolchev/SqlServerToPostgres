using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class OverrideWebTemplates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ParentId { get; set; }

    public string? Mode { get; set; }

    public string? ModeException { get; set; }

    public string? Zone { get; set; }

    public long? CustomWebTemplateId { get; set; }

    public string? CustomWebTemplateName { get; set; }

    public long? WebDesignId { get; set; }

    public long? SiteId { get; set; }

    public long? Weight { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public bool? IsEnabled { get; set; }

    public long? WvarsNum { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
