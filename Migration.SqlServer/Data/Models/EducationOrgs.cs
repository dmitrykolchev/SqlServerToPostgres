using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class EducationOrgs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? DispName { get; set; }

    public string? ContactMain { get; set; }

    public string? TelephoneWork { get; set; }

    public string? TelephoneMobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public string? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsProviderCourses { get; set; }
}
