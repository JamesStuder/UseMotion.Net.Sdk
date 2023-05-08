using System.Collections.Generic;
using UseMotion.Net.Sdk.Models;

namespace UseMotion.Net.Sdk.Interfaces
{
    /// <summary>
    /// For API Documentation see https://docs.usemotion.com/
    /// </summary>
    public interface IMotionApi
    {
        #region Tasks
        /// <summary>
        /// Update a Task
        /// </summary>
        /// <param name="taskId">Id of task to update</param>
        /// <param name="data">Updated task</param>
        /// <returns>Updated Task</returns>
        public Task UpdateTask(string taskId, TaskPatch data);
    
        /// <summary>
        /// Retrieve Task
        /// </summary>
        /// <param name="taskId">Id of task to get</param>
        /// <returns>Task</returns>
        public Task RetrieveTask(string taskId);
    
        /// <summary>
        /// Delete a Task
        /// </summary>
        /// <param name="taskId">Id of task to delete</param>
        /// <returns>True if deleted and false if not deleted</returns>
        public bool DeleteTask(string taskId);
    
        /// <summary>
        /// Create Task
        /// </summary>
        /// <remarks>When passing in a task description, the input will be treated as GitHub Flavored Markdown.</remarks>
        /// <param name="data">Object for creating a task</param>
        /// <returns>Created Task</returns>
        public Task CreateTask(TaskPost data);
    
        /// <summary>
        /// List Tasks
        /// </summary>
        /// <remarks>By default, all tasks that are completed are left out unless specifically filtered for via the status.</remarks>
        /// <param name="workspaceId">Limit tasks returned by the status on the task</param>
        /// <param name="assigneeId">Limit tasks returned to a specific assignee</param>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <param name="label">Limit tasks returned by label on the task</param>
        /// <param name="name">Limit tasks returned to those that contain this string. Case in-sensitive</param>
        /// <param name="projectId">Limit tasks returned to those that contain this string. Case in-sensitive</param>
        /// <param name="status">Limit tasks returned by the status on the task</param>
        /// <returns>List of tasks</returns>
        public ListTasks ListTasks(string workspaceId, string assigneeId = "", string cursor = "", string label = "", string name = "", string projectId = "", string status = "");
    
        /// <summary>
        /// Move Workspace
        /// </summary>
        /// <remarks>When moving tasks from one workspace to another, the tasks project, status, and label(s) and assignee will all be reset</remarks>
        /// <param name="taskId">Id of task to move</param>
        /// <param name="data">Object with data about the move</param>
        /// <returns>Moved Task</returns>
        public Task MoveWorkspace(string taskId, MoveTask data);
        #endregion
    
        #region Recurring Tasks
        /// <summary>
        /// Create a Recurring Task
        /// </summary>
        /// <remarks>When passing in a task description, the input will be treated as GitHub Flavored Markdown. Please consult the API documentation on Defining inputs for the Recurring Task.</remarks>
        /// <param name="data">Recurring task to send to api</param>
        /// <returns>Recurring Task that was created</returns>
        public RecurringTask CreateRecurringTask(RecurringTaskPost data);
    
        /// <summary>
        /// List Recurring Tasks
        /// </summary>
        /// <param name="workspaceId">The id of the workspace you want tasks from.</param>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <returns>List of recurring tasks</returns>
        public ListRecurringTasks ListRecurringTasks(string workspaceId, string cursor = "");
    
        /// <summary>
        /// Delete recurring tasks
        /// </summary>
        /// <param name="id">Id of recurring task to delete</param>
        /// <returns>True if deleted and false if not deleted</returns>
        public bool DeleteRecurringTask(string id);
        #endregion
    
        #region Comments
        /// <summary>
        /// Create Comment
        /// </summary>
        /// <remarks>When posting a comment, the content will be treated as GitHub Flavored Markdown.</remarks>
        /// <param name="data">Comment object</param>
        /// <returns>Comment that was created</returns>
        public Comment CreateComment(CommentPost data);
    
        /// <summary>
        /// List Comments
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <returns>List of comments</returns>
        public ListComments ListComments(string taskId, string cursor = "");
        #endregion
    
        #region Projects
        /// <summary>
        /// Retrieve Project
        /// </summary>
        /// <param name="id">Id of project to get</param>
        /// <returns>Project</returns>
        public Project RetrieveProject(string id);
    
        /// <summary>
        /// Retrieve Project
        /// </summary>
        /// <param name="workspaceId">Id of workspace that owns the project</param>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <returns>List of projects</returns>
        public ListProjects ListProjects(string workspaceId, string cursor = "");
    
        /// <summary>
        /// Create Project
        /// </summary>
        /// <param name="data">Object used to create a project</param>
        /// <returns>Project data that was created</returns>
        public Project CreateProject(ProjectPost data);
        #endregion
    
        #region Workspaces
        /// <summary>
        /// List statuses for a workspace
        /// </summary>
        /// <param name="workspaceId">Id of workspace to get</param>
        /// <returns>List of statues for the workspace</returns>
        public List<Status> ListStatusesForAWorkspace(string workspaceId);
    
        /// <summary>
        /// List workspaces
        /// </summary>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <param name="ids">List of workspace ids to get</param>
        /// <returns>List of workspaces</returns>
        public ListWorkspaces ListWorkspaces(string cursor = "", string[]? ids = null);
        #endregion
    
        #region Users
        /// <summary>
        ///  List users
        /// </summary>
        /// <param name="cursor">Use if a previous request returned a cursor. Will page through results</param>
        /// <param name="teamId">Filter users by team</param>
        /// <param name="workspaceId">Filter users by workspace</param>
        /// <returns>List of users</returns>
        public ListUsers ListUsers(string cursor = "", string teamId = "", string workspaceId = "");
        #endregion
    
        #region Schedules
        /// <summary>
        /// Get a list of schedules for your user
        /// </summary>
        /// <returns>List of schedules</returns>
        public List<Schedule> GetSchedules();
        #endregion
    }
}