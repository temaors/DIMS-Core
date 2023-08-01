CREATE PROCEDURE SetUserTaskAsFail @UserIdParam INT, @TaskIdParam INT
    AS
UPDATE TaskState
    SET StateName = 'Failed'
    WHERE StateId = (SELECT StateId FROM UserTask WHERE UserId = @UserIdParam and TaskId = @TaskIdParam)
    GO;