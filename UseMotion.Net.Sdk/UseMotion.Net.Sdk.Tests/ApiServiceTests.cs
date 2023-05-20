using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
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
            string taskId = Config["TaskId"] ?? string.Empty;
            TaskPatch data = new()
            {
                Name = "Updated Via API"
            };
    
            Task responseObject = MotionApi.UpdateTask(taskId, data);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Name, Is.EqualTo(data.Name));
        }

        [Test]
        public void RetrieveTaskTest()
        {
            string taskId = Config["TaskId"] ?? string.Empty;
            Task responseObject = MotionApi.RetrieveTask(taskId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Id, Is.EqualTo(taskId));
        }

        [Test]
        public void DeleteTaskTest()
        {
            string taskId = Config["TaskId"] ?? string.Empty;
            bool responseObject = MotionApi.DeleteTask(taskId);
            Assert.That(responseObject, Is.True);
        }

        [Test]
        public void CreateTaskTest()
        {
            TaskPost data = new ()
            {
                Name = "Created Via API",
                WorkspaceId = Config["WorkspaceId"] ?? string.Empty,
                ProjectId = Config["ProjectId"] ?? string.Empty,
                Description = "Created Via API",
                Priority = "LOW",
                Duration = 30
            };
            Task responseObject = MotionApi.CreateTask(data);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Name, Is.EqualTo(data.Name));
            Assert.That(responseObject.Workspace?.Id, Is.EqualTo(data.WorkspaceId));
            Assert.That(responseObject.Project?.Id, Is.EqualTo(data.ProjectId));
        }

        [Test]
        public void ListTasksTest()
        {
            string workspaceId = Config["WorkspaceId"] ?? string.Empty;
            string projectId = Config["ProjectId"] ?? string.Empty;

            ListTasks responseObject = MotionApi.ListTasks(workspaceId, "", "", "", "", projectId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Tasks, Is.Not.Null);
            Assert.That(responseObject.Tasks, Is.Not.Empty);
        }

        [Test]
        public void MoveWorkspaceTest()
        {
            string taskId = Config["TaskId"] ?? string.Empty;
            MoveTask data = new ()
            {
                WorkspaceId = Config["WorkspaceId2"] ?? string.Empty
            };
            Task responseObject = MotionApi.MoveWorkspace(taskId, data);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Workspace?.Id, Is.EqualTo(data.WorkspaceId));
        }
        #endregion

        #region Recurring Tasks
        [Test]
        public void CreateRecurringTaskTest()
        {
            RecurringTaskPost data = new ()
            {
                Frequency = "daily_every_week_day",
                Name = "Test via api",
                WorkspaceId = Config["WorkspaceId"] ?? string.Empty
            };

            RecurringTask responseObject = MotionApi.CreateRecurringTask(data);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Name, Is.EqualTo(data.Name));
            Assert.That(responseObject.Workspace.Id, Is.EqualTo(data.WorkspaceId));
        }

        [Test]
        public void ListRecurringTasksTest()
        {
            string workspaceId = Config["WorkspaceId"] ?? string.Empty;

            ListRecurringTasks responseObject = MotionApi.ListRecurringTasks(workspaceId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Tasks, Is.Not.Null);
        }

        [Test]
        public void DeleteRecurringTaskTest()
        {
            string id = Config["RecurringTaskId"] ?? string.Empty;
            bool responseObject = MotionApi.DeleteRecurringTask(id);
            Assert.That(responseObject, Is.True);
        }
        #endregion

        #region Comments
        [Test]
        public void CreateCommentTest()
        {
            CommentPost data = new ()
            {
                TaskId = Config["TaskId"] ?? string.Empty,
                Content = "This is a create from unit test via API"
            };

            Comment responseObject = MotionApi.CreateComment(data);
            Assert.That(responseObject, Is.Not.Null);
        }

        [Test]
        public void ListCommentsTest()
        {
            string taskId = Config["TaskId"] ?? string.Empty;

            ListComments responseObject = MotionApi.ListComments(taskId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Comments, Is.Not.Null);
            Assert.That(responseObject.Comments, Is.Not.Empty);
        }
        #endregion

        #region Projects
        [Test]
        public void RetrieveProject()
        {
            string id = Config["ProjectId"] ?? string.Empty;
            Project responseObject = MotionApi.RetrieveProject(id);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Id, Is.EqualTo(id));
        }

        [Test]
        public void ListProjects()
        {
            string workspaceId = Config["WorkspaceId"] ?? string.Empty;

            ListProjects responseObject = MotionApi.ListProjects(workspaceId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Projects, Is.Not.Empty);
        }

        [Test]
        public void CreateProject()
        {
            ProjectPost data = new ()
            {
                Name = "Test Project Created Via API",
                WorkspaceId = Config["WorkspaceId"] ?? string.Empty,
                Description = "Test Project Created Via API",
                Priority = "LOW"
                
            };
            Project responseObject = MotionApi.CreateProject(data);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.WorkspaceId, Is.EqualTo(data.WorkspaceId));
            Assert.That(responseObject.Name, Is.EqualTo(data.Name));
        }
        #endregion
    
        #region Workspaces
        [Test]
        public void ListStatusesForAWorkspaceTest()
        {
            string workspaceId = Config["WorkspaceId"] ?? string.Empty;

            List<Status> responseObject = MotionApi.ListStatusesForAWorkspace(workspaceId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject, Is.Not.Empty);
        }

        [Test]
        public void ListWorkspacesTest()
        {
            ListWorkspaces responseObject = MotionApi.ListWorkspaces();
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Workspaces, Is.Not.Empty);

        }
        #endregion
    
        #region Users
        [Test]
        public void ListUsers()
        {
            string workspaceId = Config["WorkspaceId"] ?? string.Empty;

            ListUsers responseObject = MotionApi.ListUsers("","",workspaceId);
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject.Users, Is.Not.Empty);
        }
        #endregion
    
        #region Schedules
        [Test]
        public void GetSchedules()
        {
            List<Schedule> responseObject = MotionApi.GetSchedules();
            Assert.That(responseObject, Is.Not.Null);
            Assert.That(responseObject, Is.Not.Empty);
        }
        #endregion
    }
}