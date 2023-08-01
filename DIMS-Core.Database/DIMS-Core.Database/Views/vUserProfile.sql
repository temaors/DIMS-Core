CREATE VIEW [dbo].[vUserProfile]
AS
SELECT UserProfile.UserId,
       (UserProfile.FirstName + ' ' + UserProfile.LastName) AS FullName,
       UserProfile.Email,
       Direction.Name AS Direction,
       UserProfile.Sex,
       UserProfile.Education,
       (SELECT dbo.GetFullAge(UserProfile.BirthDate)) AS Age,
       UserProfile.UniversityAverageScore,
       UserProfile.MathScore,
       UserProfile.Address,
       UserProfile.MobilePhone,
       UserProfile.Skype,
       UserProfile.StartDate
FROM [UserProfile]
     INNER JOIN [Direction] ON UserProfile.DirectionId = Direction.DirectionId