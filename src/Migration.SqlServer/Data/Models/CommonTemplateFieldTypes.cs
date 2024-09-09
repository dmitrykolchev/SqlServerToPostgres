using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonTemplateFieldTypes
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? FieldType { get; set; }

    public string? Icon { get; set; }
}
