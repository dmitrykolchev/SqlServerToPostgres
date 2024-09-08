using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnPostApproveds
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? CategoryId { get; set; }

    public long? SubcategoryId { get; set; }

    public short? FlOperative { get; set; }

    public short? FlActive { get; set; }

    public short? FlLead { get; set; }

    public short? FlCaControl { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
