using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using UseMotion.Net.Sdk.Interfaces;
using UseMotion.Net.Sdk.Models;
using UseMotion.Net.Sdk.Services;

namespace UseMotion.Net.Sdk.Tests
{
    public class ApiServiceTests
    {
        private IMotionApi MotionApi { get; }
        private IConfiguration Config { get; }
        public ApiServiceTests()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            Config = builder.Build();
            MotionApi = new MotionService(Config["UseMotionAPIKey"] ?? string.Empty);
        }
        
        #region Tasks
        [Test]
        public void UpdateTaskTest()
        {
            const string taskId = "";
            TaskPatch data = new()
            {
                Name = ""
            };
    
            Task responseObject = MotionApi.UpdateTask(taskId, data);
        }

        [Test]
        public void RetrieveTaskTest()
        {
            const string taskId = "";
            Task responseObject = MotionApi.RetrieveTask(taskId);
           
        }

        [Test]
        public void DeleteTaskTest()
        {
            const string taskId = "";
            bool responseObject = MotionApi.DeleteTask(taskId);
        }

        [Test]
        public void CreateTaskTest()
        {
            TaskPost data = new ()
            {
                Name = "",
                WorkspaceId = ""
            };
            Task responseObject = MotionApi.CreateTask(data);
        }

        [Test]
        public void ListTasksTest()
        {
            const string workspaceId = "";
            const string assigneeId = "";
            const string cursor = "";
            const string label = "";
            const string name = "";
            const string projectId = "";
            const string status = "";
            
            ListTasks responseObject = MotionApi.ListTasks(workspaceId, assigneeId, cursor, label, name, projectId, status);
        }

        [Test]
        public void MoveWorkspaceTest()
        {
            const string taskId = "";
            MoveTask data = new ()
            {
                WorkspaceId = ""
            };
            Task responseObject = MotionApi.MoveWorkspace(taskId, data);
        }
        #endregion

        #region Recurring Tasks
        [Test]
        public void CreateRecurringTaskTest()
        {
            RecurringTaskPost data = new ()
            {
                Frequency = "",
                Name = "",
                WorkspaceId = ""
            };
            string jsonToSend = JsonConvert.SerializeObject(data);
            RecurringTask responseObject = MotionApi.CreateRecurringTask(data);
        }

        [Test]
        public void ListRecurringTasksTest()
        {
            const string workspaceId = "";
            const string cursor = "";

            ListRecurringTasks responseObject = MotionApi.ListRecurringTasks(workspaceId, cursor);
        }

        [Test]
        public void DeleteRecurringTaskTest()
        {
            const string id = "";
            bool responseObject = MotionApi.DeleteRecurringTask(id);
        }
        #endregion

        #region Comments
        [Test]
        public void CreateCommentTest()
        {
            CommentPost data = new ()
            {
                TaskId = "",
                Content = ""
            };

            Comment responseObject = MotionApi.CreateComment(data);
        }

        [Test]
        public void ListCommentsTest()
        {
            const string taskId = "";
            const string cursor = "";

            ListComments responseObject = MotionApi.ListComments(taskId, cursor);
        }
        #endregion

        #region Projects
        [Test]
        public void RetrieveProject()
        {
            const string id = "";
            Project responseObject = MotionApi.RetrieveProject(id);
        }

        [Test]
        public void ListProjects()
        {
            const string workspaceId = "";
            const string cursor = "";
        
            ListProjects responseObject = MotionApi.ListProjects(workspaceId, cursor);
        }

        [Test]
        public void CreateProject()
        {
            ProjectPost data = new ()
            {
                Name = "",
                WorkspaceId = ""
            };
            Project responseObject = MotionApi.CreateProject(data);
        }
        #endregion
    
        #region Workspaces
        [Test]
        public void ListStatusesForAWorkspaceTest()
        {
            const string workspaceId = "";

            List<Status> responseObject = MotionApi.ListStatusesForAWorkspace(workspaceId);

        }

        [Test]
        public void ListWorkspacesTest()
        {
            const string cursor = "";
            const string[]? ids = null;

            ListWorkspaces responseObject = MotionApi.ListWorkspaces(cursor, ids);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Workspaces, Is.Not.Empty);

        }
        #endregion
    
        #region Users
        [Test]
        public void ListUsers()
        {
            const string cursor = "";
            const string teamId = "";
            const string workspaceId = "";

            ListUsers responseObject = MotionApi.ListUsers(cursor, teamId, workspaceId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Users, Is.Not.Empty);
        }
        #endregion
    
        #region Schedules
        [Test]
        public void GetSchedules()
        {
            List<Schedule> responseObject = MotionApi.GetSchedules();
        }
        #endregion
    }
}