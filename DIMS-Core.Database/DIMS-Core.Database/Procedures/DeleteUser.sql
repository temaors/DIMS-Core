CREATE PROCEDURE DeleteUser @UserId INT
    AS
DELETE UserProfile
WHERE UserId = @UserId
    GO;