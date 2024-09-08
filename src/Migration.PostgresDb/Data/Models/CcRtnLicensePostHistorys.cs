using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicensePostHistorys
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public long? MainDivId { get; set; }

    public string? MainDivName { get; set; }

    public long? DivId { get; set; }

    public string? DivName { get; set; }

    public string? Name { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
