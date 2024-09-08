﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcEduFields
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? Station { get; set; }

    public long? FieldType { get; set; }

    public bool? Archive { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
