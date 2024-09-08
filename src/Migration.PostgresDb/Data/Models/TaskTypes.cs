using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class TaskTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? WorkflowId { get; set; }

    public string? CreateTaskTypeId { get; set; }

    public string? EditTaskTypeId { get; set; }

    public string? ViewTaskTypeId { get; set; }

    public bool? ShowInWorkspace { get; set; }

    public bool? RelatedToProjects { get; set; }

    public string? RelatedObjectType { get; set; }

    public bool? Virtual { get; set; }

    public long? VirtualRemoteCollectionId { get; set; }

    public long? VirtualRemoteActionId { get; set; }

    public bool? CanChangeStatus { get; set; }

    public bool? CanChangeTask { get; set; }

    public bool? CanDeleteTask { get; set; }

    public long? RelatedConversationTypeId { get; set; }

    public bool? UseCustomWvars { get; set; }

    public bool? ConsiderTimeInWorkspace { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }
}
