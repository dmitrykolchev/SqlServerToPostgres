using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class FileSources
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public bool? SearchAvailable { get; set; }

    public bool? SelectionAvailable { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public long? WebModeId { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }

    public string? ConditionsQual { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
