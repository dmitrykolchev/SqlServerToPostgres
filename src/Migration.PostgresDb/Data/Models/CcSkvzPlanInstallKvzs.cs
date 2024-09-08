using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcSkvzPlanInstallKvzs
{
    public long Id { get; set; }

    public long? KvzPersonId { get; set; }

    public string? Kvz { get; set; }

    public string? Method { get; set; }

    public long? FormalizeDivId { get; set; }

    public long? FormalizePersonId { get; set; }

    public DateTime? FactDate { get; set; }

    public short? IsComplete { get; set; }

    public string? Code { get; set; }

    public string? ProtFileId { get; set; }

    public short? IsInPoll { get; set; }

    public short? IsPollComplete { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? MmFileId { get; set; }
}
