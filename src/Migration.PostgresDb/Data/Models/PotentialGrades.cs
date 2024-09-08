using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PotentialGrades
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? DevelopmentPotentialId { get; set; }

    public string? AssessmentSource { get; set; }

    public long? PersonId { get; set; }

    public long? SuccessorId { get; set; }

    public long? PersonnelReserveId { get; set; }

    public long? AssessorId { get; set; }

    public DateTime? AssessmentDate { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
