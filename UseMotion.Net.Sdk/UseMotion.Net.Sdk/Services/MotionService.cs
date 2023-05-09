using System.Collections.Generic;
using System.Linq;
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
            string responseJson = MotionApiAccess.PostAsync("/tasks", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Task>(responseJson)!;
        }

        public ListTasks ListTasks(string workspaceId, string assigneeId = "", string cursor = "", string label = "", string name = "", string projectId = "", string status = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "workspaceId", workspaceId },
                { "assigneeId", assigneeId },
                { "cursor", cursor },
                { "label", label },
                { "name", name },
                { "projectId", projectId },
                { "status", status }
            };

            properties = properties.Where(entry => !string.IsNullOrEmpty(entry.Value)).ToDictionary(entry => entry.Key, entry => entry.Value);
            
            string responseJson = MotionApiAccess.GetAsync("/tasks", properties).Result;
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
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PostAsync("/recurring-tasks", jsonToSend).Result;
            return JsonConvert.DeserializeObject<RecurringTask>(responseJson)!;
        }

        public ListRecurringTasks ListRecurringTasks(string workspaceId, string cursor = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "workspaceId", workspaceId },
                { "cursor", cursor },
            };

            properties = properties.Where(entry => !string.IsNullOrEmpty(entry.Value)).ToDictionary(entry => entry.Key, entry => entry.Value);
            
            string responseJson = MotionApiAccess.GetAsync("/recurring-tasks", properties).Result;
            return JsonConvert.DeserializeObject<ListRecurringTasks>(responseJson)!;
        }

        public bool DeleteRecurringTask(string id)
        {
            return MotionApiAccess.DeleteAsync($"/recurring-tasks/{id}").Result;
        }
        #endregion

        #region Comments
        public Comment CreateComment(CommentPost data)
        {
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PostAsync("/comments", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Comment>(responseJson)!;
        }

        public ListComments ListComments(string taskId, string cursor = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "taskId", taskId },
                { "cursor", cursor },
            };

            properties = properties.Where(entry => !string.IsNullOrEmpty(entry.Value)).ToDictionary(entry => entry.Key, entry => entry.Value);
            
            string responseJson = MotionApiAccess.GetAsync("/comments", properties).Result;
            return JsonConvert.DeserializeObject<ListComments>(responseJson)!;
        }
        #endregion

        #region Projects
        public Project RetrieveProject(string id)
        {
            string responseJson = MotionApiAccess.GetAsync($"/projects/{id}").Result;
            return JsonConvert.DeserializeObject<Project>(responseJson)!;
        }

        public ListProjects ListProjects(string workspaceId, string cursor = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "workspaceId", workspaceId },
                { "cursor", cursor }
            };

            properties = properties.Where(entry => !string.IsNullOrEmpty(entry.Value)).ToDictionary(entry => entry.Key, entry => entry.Value);
            
            string responseJson = MotionApiAccess.GetAsync("/projects", properties).Result;
            return JsonConvert.DeserializeObject<ListProjects>(responseJson)!;
        }

        public Project CreateProject(ProjectPost data)
        {
            string jsonToSend = JsonConvert.SerializeObject(data);
            string responseJson = MotionApiAccess.PostAsync("/projects", jsonToSend).Result;
            return JsonConvert.DeserializeObject<Project>(responseJson)!;
        }
        #endregion
        
        #region Workspaces
        public List<Status> ListStatusesForAWorkspace(string workspaceId)
        {
            Dictionary<string, string> properties = new ()
            {
                { "workspaceId", workspaceId }
            };

            string responseJson = MotionApiAccess.GetAsync("/statuses", properties).Result;
            return JsonConvert.DeserializeObject<List<Status>>(responseJson)!;
        }

        public ListWorkspaces ListWorkspaces(string cursor = "", string[]? ids = null)
        {
            Dictionary<string, string> properties = new();

            if (!string.IsNullOrEmpty(cursor))
            {
                properties.Add("cursor", cursor);
            }
            
            if (ids != null && ids.Length > 0)
            {
                properties.Add("ids", string.Join(",", ids));
            }

            string responseJson = MotionApiAccess.GetAsync("/workspaces", properties).Result;
            return JsonConvert.DeserializeObject<ListWorkspaces>(responseJson)!;
        }
        #endregion
        
        #region Users
        public ListUsers ListUsers(string cursor = "", string teamId = "", string workspaceId = "")
        {
            Dictionary<string, string> properties = new ()
            {
                { "cursor", cursor },
                { "teamId", teamId },
                { "workspaceId", workspaceId }
            };

            string responseJson = MotionApiAccess.GetAsync("/users", properties).Result;
            return JsonConvert.DeserializeObject<ListUsers>(responseJson)!;
        }
        #endregion
        
        #region Schedules
        public List<Schedule> GetSchedules()
        {
            string responseJson = MotionApiAccess.GetAsync("/schedules").Result;
            return JsonConvert.DeserializeObject<List<Schedule>>(responseJson)!;
        }
        #endregion
    }
}