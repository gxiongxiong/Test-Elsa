using Elsa.Mediator.Services;
using Elsa.Workflows.Persistence.Entities;

namespace Elsa.Workflows.Runtime.Notifications;

public record WorkflowBookmarksSaved(List<WorkflowBookmark> Bookmarks) : INotification;