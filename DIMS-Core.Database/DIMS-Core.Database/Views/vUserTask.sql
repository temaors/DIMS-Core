CREATE VIEW [dbo].[vUserTask]
AS
SELECT UserTask.UserId,
       Task.TaskId,
       Task.Name as TaskName,
       Task.Description,
       Task.StartDate,
       Task.DeadlineDate,
       TaskState.StateName as State
FROM [Task]
    INNER JOIN [UserTask] ON Task.TaskId = UserTask.TaskId
    INNER JOIN [TaskState] ON UserTask.StateId = TaskState.StateId                      