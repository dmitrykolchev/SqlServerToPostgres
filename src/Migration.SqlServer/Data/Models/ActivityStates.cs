using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ActivityStates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? AgentJsonStr { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? ActivityId { get; set; }

    public string? ActivityCode { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Registration { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
