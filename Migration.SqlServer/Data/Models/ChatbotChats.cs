using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ChatbotChats
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? LastMessageDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? BotId { get; set; }

    public long? ChatbotStageId { get; set; }

    public long? ChatbotTypeId { get; set; }

    public long? ChatbotId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PersonPositionId { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonPositionCode { get; set; }

    public long? PersonOrgId { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonOrgCode { get; set; }

    public long? PersonSubdivisionId { get; set; }

    public string? PersonSubdivisionName { get; set; }

    public string? PersonSubdivisionCode { get; set; }

    public string? PersonInstanceId { get; set; }

    public string? PersonCode { get; set; }
}
