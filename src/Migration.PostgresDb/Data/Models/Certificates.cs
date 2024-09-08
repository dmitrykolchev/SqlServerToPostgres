using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Certificates
{
    public long Id { get; set; }

    public string? Serial { get; set; }

    public string? Number { get; set; }

    public long? TypeId { get; set; }

    public string? TypeName { get; set; }

    public long? EducationOrgId { get; set; }

    public long? EventId { get; set; }

    public long? QualificationId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonSubdivisionCode { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }

    public bool? Valid { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}
