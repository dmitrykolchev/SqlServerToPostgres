using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Expenses
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PayStageId { get; set; }

    public string? TypeId { get; set; }

    public long? Cost { get; set; }

    public string? Number { get; set; }

    public DateTime? ExpenseCreateDate { get; set; }

    public bool? IsReceived { get; set; }

    public bool? IsFormed { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? Comment { get; set; }
}
