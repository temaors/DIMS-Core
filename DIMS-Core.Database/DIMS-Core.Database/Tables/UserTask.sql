CREATE TABLE [dbo].[UserTask]
(
    [UserTaskId]           INT             NOT NULL IDENTITY (1, 1),
    [TaskId]               INT             NOT NULL,
    [UserId]               INT             NOT NULL,
    [StateId]              INT             NOT NULL,

    CONSTRAINT PK_UserTask_UserTaskId PRIMARY KEY (UserTaskId),
    CONSTRAINT FK_UserTask_Task_TaskId FOREIGN KEY (TaskId) REFERENCES Task (TaskId),
    CONSTRAINT FK_UserTask_UserProfile_UserId FOREIGN KEY (UserID) REFERENCES UserProfile (UserId),
    CONSTRAINT FK_UserTask_TaskState_StateId FOREIGN KEY (StateId) REFERENCES TaskState (StateId)
    )