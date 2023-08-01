INSERT INTO [dbo].[Task]
(
 [Name],
 [Description],
 [StartDate],
 [DeadLineDate]
)
VALUES(
    'Pattern Repository',
    'Implement all repositories and all methods for CRUD operations with 5 entities',
    '2023-08-01',
    '2023-08-07'
    ),
    (
    'DTO',
    'Implement data transfer objects in data access layer',
    '2023-08-01',
    '2023-08-09'
    ),
    (
    'Update repositories',
    'Add findByUserName(string UserName) method to UserRepository witch will return only one User with username',
    '2023-08-09',
    '2023-08-10'
    )