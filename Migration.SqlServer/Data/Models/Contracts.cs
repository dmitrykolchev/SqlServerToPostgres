using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Contracts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public string? Number { get; set; }

    public long? ContractTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public double? Cost { get; set; }

    public string? Currency { get; set; }

    public long? EducationOrgId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? FilesCount { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public double? CostNds { get; set; }
}
