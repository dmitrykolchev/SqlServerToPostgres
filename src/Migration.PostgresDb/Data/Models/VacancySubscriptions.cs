using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class VacancySubscriptions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public bool? IsActive { get; set; }

    public string? FullTextSearchStr { get; set; }

    public long? SiteId { get; set; }

    public DateTime? SendVacancyDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
