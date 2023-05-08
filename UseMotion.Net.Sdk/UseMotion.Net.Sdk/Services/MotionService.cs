using System.Collections.Generic;
using UseMotion.Net.Sdk.Interfaces;
using UseMotion.Net.Sdk.Models;

namespace UseMotion.Net.Sdk.Services;

/// <inheritdoc />
public class MotionService : IMotionApi
{
    public Task UpdateTask(string taskId, TaskPatch data)
    {
        throw new System.NotImplementedException();
    }

    public Task RetrieveTask(string taskId)
    {
        throw new System.NotImplementedException();
    }

    public bool DeleteTask(string taskId)
    {
        throw new System.NotImplementedException();
    }

    public Task CreateTask(TaskPost data)
    {
        throw new System.NotImplementedException();
    }

    public ListTasks ListTasks(string workSpaceId, string assigneeId = "", string cursor = "", string label = "", string name = "", string projectId = "", string status = "")
    {
        throw new System.NotImplementedException();
    }

    public Task MoveWorkspace(string taskId, MoveTask data)
    {
        throw new System.NotImplementedException();
    }

    public RecurringTask CreateRecurringTask(RecurringTaskPost data)
    {
        throw new System.NotImplementedException();
    }

    public ListRecurringTasks ListRecurringTasks(string workspaceId, string cursor = "")
    {
        throw new System.NotImplementedException();
    }

    public bool DeleteRecurringTask(string id)
    {
        throw new System.NotImplementedException();
    }

    public Comment CreateComment(CommentPost data)
    {
        throw new System.NotImplementedException();
    }

    public ListComments ListComments(string taskId, string cursor = "")
    {
        throw new System.NotImplementedException();
    }

    public Project RetrieveProject(string id)
    {
        throw new System.NotImplementedException();
    }

    public ListProjects ListProjects(string workspaceId, string cursor = "")
    {
        throw new System.NotImplementedException();
    }

    public Project CreateProject(ProjectPost data)
    {
        throw new System.NotImplementedException();
    }

    public List<Status> ListStatusesForAWorkspace(string workspaceId)
    {
        throw new System.NotImplementedException();
    }

    public ListWorkspaces ListWorkspaces(string cursor = "", string[]? ids = null)
    {
        throw new System.NotImplementedException();
    }

    public ListUsers ListUsers(string cursor = "", string teamId = "", string workspaceId = "")
    {
        throw new System.NotImplementedException();
    }

    public List<Schedule> GetSchedules()
    {
        throw new System.NotImplementedException();
    }
}