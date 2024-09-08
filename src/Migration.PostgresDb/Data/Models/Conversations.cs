using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Conversations
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

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

    public DateTime? CreateDate { get; set; }

    public long? ConversationTypeId { get; set; }

    public string? FormatId { get; set; }

    public string? StateId { get; set; }

    public string? CustomStateId { get; set; }

    public bool? IsPublic { get; set; }

    public long? PositionPriority { get; set; }

    public string? ListCss { get; set; }

    public List<long>? Objects { get; set; }

    public string? ActiveObjectType { get; set; }

    public string? ActiveObjectName { get; set; }

    public long? ActiveObjectId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? ParticipantsId { get; set; }

    public bool? ProhibitWrite { get; set; }

    public bool? CanCall { get; set; }

    public bool? CanChangeParticipant { get; set; }

    public bool? CanShowAdditionalInfo { get; set; }
}
