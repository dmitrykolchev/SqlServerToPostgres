using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ClModules
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ClCourseId { get; set; }

    public string? ResourceUrl { get; set; }

    public string? Category { get; set; }

    public string? CategoryLabel { get; set; }

    public long? SlideWidth { get; set; }

    public long? SlideHeight { get; set; }

    public bool? IsTemplate { get; set; }

    public long? Stamp { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

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

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
