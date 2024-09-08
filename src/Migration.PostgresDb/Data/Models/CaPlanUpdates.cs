using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CaPlanUpdates
{
    public int Id { get; set; }

    public int CaPlanId { get; set; }

    public long? EduOrgId { get; set; }

    public int Year { get; set; }

    public long EmId { get; set; }

    public DateTime CreateDate { get; set; }

    public short? IsCentral { get; set; }

    public short? IsEdu { get; set; }

    public int? PersonNum { get; set; }

    public long UserId { get; set; }

    public short? IsLast { get; set; }

    public virtual CaPlan CaPlan { get; set; } = null!;
}
