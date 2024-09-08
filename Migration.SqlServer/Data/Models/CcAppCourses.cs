using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcAppCourses
{
    public long Id { get; set; }

    public long? Eduapp { get; set; }

    public long? EduObjId { get; set; }

    public string? EduObjName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
