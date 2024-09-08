using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CustomChatbotTemplates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public string? OutType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public List<long>? RoleId { get; set; }
}
