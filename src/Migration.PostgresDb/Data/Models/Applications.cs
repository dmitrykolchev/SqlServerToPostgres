using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Applications
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public string? Type { get; set; }

    public string? ListXmsUrl { get; set; }

    public string? DefaultXmsUrl { get; set; }

    public List<long>? WebModeId { get; set; }

    public string? Vendor { get; set; }

    public string? VendorLibrary { get; set; }

    public string? LicType { get; set; }

    public bool? Changed { get; set; }

    public bool? IsStd { get; set; }

    public List<long>? RoleId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
