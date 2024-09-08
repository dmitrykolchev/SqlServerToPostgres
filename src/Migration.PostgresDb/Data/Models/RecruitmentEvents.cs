using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class RecruitmentEvents
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? VacancyId { get; set; }

    public long? EstaffEventTypeId { get; set; }

    public long? EstaffEventTypeStatusId { get; set; }

    public long? RecruitmentSystemId { get; set; }

    public long? SiteId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
