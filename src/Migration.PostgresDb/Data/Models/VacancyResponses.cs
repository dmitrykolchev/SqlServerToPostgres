using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class VacancyResponses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? VacancyId { get; set; }

    public string? VacancyName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? RecruiterPersonId { get; set; }

    public string? RecruiterPersonFullname { get; set; }

    public long? ResponseAuthorPersonId { get; set; }

    public string? ResponseAuthorFullname { get; set; }

    public long? ResumeId { get; set; }

    public long? CareerReserveId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateInvitation { get; set; }

    public string? Status { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
