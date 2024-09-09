using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DocTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public string? ObjectName { get; set; }

    public string? DispName { get; set; }

    public bool? IsCraveForReboot { get; set; }

    public long? CustomWebTemplateId { get; set; }

    public long? CustomAdminTemplateId { get; set; }

    public string? AccessBlockType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RoleId { get; set; }
}
