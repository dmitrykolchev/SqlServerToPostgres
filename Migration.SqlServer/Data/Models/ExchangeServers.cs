﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ExchangeServers
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUploadDate { get; set; }

    public DateTime? LastDownloadDate { get; set; }

    public string? ServerVersion { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? RoleId { get; set; }
}
