﻿using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonObjectProfiles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public List<string>? ObjectCatalog { get; set; }

    public DateTime? ModificationDate { get; set; }
}
