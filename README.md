# UseMotion.Net.Sdk
This is a .NET SDK that I created to work with the Motion (https://www.usemotion.com/) API.

Please go to https://docs.usemotion.com/docs/motion-rest-api/44e37c461ba67-motion-rest-api to learn about thier api and some of the considerations (i.e. whats required, how data should be formatted, etc.

This project is not affiliated with Motion and this was something I put together based on my needs to create mulitple integrations.

## Implementation
1) Install Nuget Package https://www.nuget.org/packages/UseMotion.Net.Sdk/
3) Instantiate the interface `IMotionApi MotionApi = new MotionService("INSERT MOTION API KEY");`

## Usage
Example Create Task:
```
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
```
For additional examples check out the Unit Tests for the project in UseMotion.Net.Sdk.Tests

## Unit Tests
To use the unit test project you will need to add an `appsettings.json` to the project.  Below is how it should be setup based on what is currently setup in the unit test project.
```
{
    "UseMotionAPIKey" : "",
    "TaskId" : "",
    "WorkspaceId" : "",
    "WorkspaceId2" : "",
    "RecurringTaskId" : "",
    "ProjectId" : "",
    "TeamId" : "",
    "UserId" : ""
}
```
