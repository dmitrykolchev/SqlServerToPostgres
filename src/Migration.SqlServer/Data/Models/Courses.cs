using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Courses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public double? Price { get; set; }

    public double? MaxScore { get; set; }

    public bool? YourselfStart { get; set; }

    public long? Duration { get; set; }

    public string? RoleId { get; set; }

    public long? PersonId { get; set; }

    public long? ClCourseId { get; set; }

    public bool? PwtDisp { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public long? ResourceId { get; set; }

    public long? EducationOrgId { get; set; }

    public string? BaseUrl { get; set; }

    public bool? EnableAnonymousAccess { get; set; }

    public long? AccessLevel { get; set; }

    public string? AccessRoles { get; set; }

    public string? AccessGroups { get; set; }

    public long? AccessOrgId { get; set; }

    public long? AccessSiteId { get; set; }

    public long? AccessHostId { get; set; }

    public string? Operator { get; set; }

    public string? Conditions { get; set; }
}
