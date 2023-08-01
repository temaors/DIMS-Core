CREATE VIEW [dbo].[vUserProgress]
AS
SELECT UserTask.UserId,
       UserTask.TaskId,
       TaskTrack.TaskTrackId,
       (UserProfile.LastName + ' ' + UserProfile.Name) as UserName,
       Task.Name as TaskName,
       TaskTrack.TrackNote,
       TaskTrack.TrackDate
FROM [TaskTrack]
    INNER JOIN [UserTask] ON TaskTrack.UserTaskId = UserTask.UserTaskId
    INNER JOIN [UserProfile] ON UserTask.UserId = UserProfile.UserId
    INNER JOIN [Task] ON UserTask.TaskId = Task.TaskId