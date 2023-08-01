CREATE PROCEDURE DeleteTask @TaskId INT
    AS
DELETE Task
WHERE TaskId = @TaskId
    GO;