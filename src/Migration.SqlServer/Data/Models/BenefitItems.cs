using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class BenefitItems
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? BenefitId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
