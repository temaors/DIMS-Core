CREATE TABLE [dbo].[Task]
(
    [TaskId]                INT             NOT NULL IDENTITY (1, 1),
    [Name]                  NVARCHAR(50)    NOT NULL,
    [Description]           NVARCHAR(255)   NOT NULL,
    [StartDate]             Date            NOT NULL,
    [DeadlineDate]          Date            NOT NULL,

    CONSTRAINT PK_Task_TaskId PRIMARY KEY (TaskId)
    )
