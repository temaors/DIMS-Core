CREATE TABLE [dbo].[TaskState]
(
    [StateId]               INT             NOT NULL IDENTITY (1, 1),
    [StateName]             NVARCHAR(25)    NOT NULL,

    CONSTRAINT PK_TaskState_StateId PRIMARY KEY (StateId)
    )