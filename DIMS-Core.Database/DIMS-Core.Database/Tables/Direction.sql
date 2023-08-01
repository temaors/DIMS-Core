CREATE TABLE [dbo].[Direction]
(
    [DirectionId] INT           NOT NULL IDENTITY (1, 1),
    [Name]        NVARCHAR(50)  NOT NULL,
    [Description] NVARCHAR(250) NULL,

    CONSTRAINT PK_Direction_DirectionId PRIMARY KEY (DirectionId)
)
