using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ObjectDatas
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ObjectDataTypeId { get; set; }

    public long? BudgetPeriodId { get; set; }

    public string? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? ObjectType { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
