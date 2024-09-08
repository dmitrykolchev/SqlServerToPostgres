using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcEduOrgCodes
{
    public long Id { get; set; }

    public long? EducationOrgId { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
