using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Profiles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? AgentJsonStr { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? ActivityId { get; set; }

    public string? ActivityCode { get; set; }

    public string? Hash { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}
