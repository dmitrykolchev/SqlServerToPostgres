﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ObjectDataTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public string? SecObjectType { get; set; }

    public string? AccessBlockType { get; set; }

    public List<long>? RoleId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
