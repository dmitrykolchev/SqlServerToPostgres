using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class BenefitProfiles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? Status { get; set; }

    public long? PositionFamilyId { get; set; }

    public long? SubdivisionGroupId { get; set; }

    public long? PersonRegionId { get; set; }

    public long? SubdivisionRegionId { get; set; }

    public long? PersonPlaceId { get; set; }

    public long? SubdivisionPlaceId { get; set; }

    public long? WorkFormId { get; set; }

    public long? WorkingConditionTypeId { get; set; }

    public long? WorkExperience { get; set; }

    public List<long>? PositionCommonsIds { get; set; }

    public List<long>? GradesIds { get; set; }

    public List<long>? BenefitsIds { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}
