CREATE VIEW [dbo].[vUserTrack]
AS
SELECT UserTask.UserId,
       UserTask.TaskId,
       TaskTrack.TaskTrackId,
       Task.Name as TaskName,
       TaskTrack.TrackNote,
       TaskTrack.TrackDate
FROM [TaskTrack]
    INNER JOIN [UserTask] ON TaskTrack.UserTaskId = UserTask.UserTaskId
    INNER JOIN [Task] ON UserTask.TaskId = Task.TaskId