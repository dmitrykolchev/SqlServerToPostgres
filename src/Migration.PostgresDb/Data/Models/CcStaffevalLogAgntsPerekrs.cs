using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalLogAgntsPerekrs
{
    public long Id { get; set; }

    public long? StaffevalPgPerekrest { get; set; }

    public long? Agent1 { get; set; }

    public DateTime? LastSendDate1 { get; set; }

    public long? Agent2 { get; set; }

    public DateTime? LastSendDate2 { get; set; }

    public long? Agent3 { get; set; }

    public DateTime? LastSendDate3 { get; set; }

    public long? Agent4 { get; set; }

    public DateTime? LastSendDate4 { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public short? VisitingRatingIsSend { get; set; }

    public short? SelfRatingIsSend { get; set; }

    public long? Agent5Visitor { get; set; }

    public DateTime? LastSendDate5Visitor { get; set; }

    public long? Agent5Self { get; set; }

    public DateTime? LastSendDate5Self { get; set; }

    public long? Agent6Visitor { get; set; }

    public DateTime? LastSendDate6Visitor { get; set; }

    public long? Agent6Self { get; set; }

    public DateTime? LastSendDate6Self { get; set; }
}
