using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalLogAgntsQuals
{
    public long Id { get; set; }

    public long? StaffevalQualification { get; set; }

    public long? Agent1 { get; set; }

    public DateTime? LastSendDate1 { get; set; }

    public long? Agent2 { get; set; }

    public DateTime? LastSendDate2 { get; set; }

    public long? Agent3 { get; set; }

    public DateTime? LastSendDate3 { get; set; }

    public long? Agent4 { get; set; }

    public DateTime? LastSendDate4 { get; set; }

    public long? Agent5 { get; set; }

    public DateTime? LastSendDate5 { get; set; }

    public long? Agent6 { get; set; }

    public DateTime? LastSendDate6 { get; set; }

    public long? Agent7 { get; set; }

    public DateTime? LastSendDate7 { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
