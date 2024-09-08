using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Hosts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Hostname { get; set; }

    public long? Port { get; set; }

    public string? Host { get; set; }

    public string? PortalAuthType { get; set; }

    public bool? AllowLdsAuth { get; set; }

    public long? SiteId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
