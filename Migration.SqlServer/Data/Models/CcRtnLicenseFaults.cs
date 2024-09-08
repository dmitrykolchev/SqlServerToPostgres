﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenseFaults
{
    public long Id { get; set; }

    public long? LicenseActivityId { get; set; }

    public DateTime? Date { get; set; }

    public string? OrderProps { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
