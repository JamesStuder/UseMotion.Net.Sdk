using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using Newtonsoft.Json;
using UseMotion.Net.Sdk.DataAccess;
using UseMotion.Net.Sdk.Interfaces;
using UseMotion.Net.Sdk.Models;

namespace UseMotion.Net.Sdk.Services
{
    /// <inheritdoc />
    public class MotionService : IMotionApi
    {
        private ApiAccess MotionApiAccess { get; }
        public MotionService(string apiKey)
        {
            MotionApiAccess = new ApiAccess(apiKey);
        }

        #region Tasks
        public Task UpdateTask(string taskId, TaskPatch data)
        {
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PatchAsync($"/tasks/{taskId}", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Task>(responseJson)!;
        }

        public Task RetrieveTask(string taskId)
        {
            string responseJson = MotionApiAccess.GetAsync($"/tasks/{taskId}").Result;
            return JsonConvert.DeserializeObject<Task>(responseJson)!;
        }

        public bool DeleteTask(string taskId)
        {
            return MotionApiAccess.DeleteAsync($"/tasks/{taskId}").Result;
        }

        public Task CreateTask(TaskPost data)
        {
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PostAsync($"/tasks", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Task>(responseJson)!;
        }

        public ListTasks ListTasks(string workSpaceId, string assigneeId = "", string cursor = "", string label = "", string name = "", string projectId = "", string status = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "workSpaceId", workSpaceId },
                { "assigneeId", assigneeId },
                { "cursor", cursor },
                { "label", label },
                { "name", name },
                { "projectId", projectId },
                { "status", status }
            };

            properties = properties.Where(entry => !string.IsNullOrEmpty(entry.Value)).ToDictionary(entry => entry.Key, entry => entry.Value);
            
            string responseJson = MotionApiAccess.GetAsync($"/tasks", properties).Result;
            return JsonConvert.DeserializeObject<ListTasks>(responseJson)!;
        }

        public Task MoveWorkspace(string taskId, MoveTask data)
        {
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PatchAsync($"/tasks/{taskId}/move", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Task>(responseJson)!;
        }
        #endregion

        #region Recurring Tasks
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
            return MotionApiAccess.DeleteAsync($"/recurring-tasks/{id}").Result;
        }
        #endregion

        #region Comments
        public Comment CreateComment(CommentPost data)
        {
            throw new System.NotImplementedException();
        }

        public ListComments ListComments(string taskId, string cursor = "")
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Projects
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
        #endregion
        
        #region Workspaces
        public List<Status> ListStatusesForAWorkspace(string workspaceId)
        {
            throw new System.NotImplementedException();
        }

        public ListWorkspaces ListWorkspaces(string cursor = "", string[]? ids = null)
        {
            throw new System.NotImplementedException();
        }
        #endregion
        
        #region Users
        public ListUsers ListUsers(string cursor = "", string teamId = "", string workspaceId = "")
        {
            throw new System.NotImplementedException();
        }
        #endregion
        
        #region Schedules
        public List<Schedule> GetSchedules()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}