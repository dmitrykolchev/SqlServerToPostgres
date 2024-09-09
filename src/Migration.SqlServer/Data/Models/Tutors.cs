using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Tutors
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public long? CareerReserveTypeId { get; set; }

    public string? Status { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
