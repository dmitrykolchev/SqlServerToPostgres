using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Policys
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? Number { get; set; }

    public long? PolicyTypeId { get; set; }

    public string? StateId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
