using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Recommendations
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? WorkPhone { get; set; }

    public string? MobilePhone { get; set; }

    public long? VacancyId { get; set; }

    public string? VacancyName { get; set; }

    public long? SrcPersonId { get; set; }

    public string? SrcPersonFullname { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? Fullname { get; set; }

    public string? Status { get; set; }
}
