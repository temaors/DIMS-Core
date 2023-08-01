CREATE TABLE [dbo].[TaskTrack]
(
    [TaskTrackId]           INT             NOT NULL IDENTITY (1, 1),
    [UserTaskId]            INT             NOT NULL,
    [TrackDate]             Date            NOT NULL,
    [TrackNote]             NVARCHAR(255)   NOT NULL,

    CONSTRAINT PK_TaskTrack_TaskTrackId PRIMARY KEY (TaskTrackId),
    CONSTRAINT FK_TaskTrack_UserTask_UserTaskId FOREIGN KEY (UserTaskId) REFERENCES UserTask (UserTaskId)
    )