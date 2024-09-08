using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PrintForms
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? ObjectName { get; set; }

    public string? FileName { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
