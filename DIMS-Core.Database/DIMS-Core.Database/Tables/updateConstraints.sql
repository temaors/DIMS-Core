

ALTER TABLE UserProfile DROP CONSTRAINT FK_UserProfile_Directions_DirectionId;

ALTER TABLE UserProfile
        add CONSTRAINT FK_UserProfile_Directions_DirectionId FOREIGN KEY (DirectionId) REFERENCES Direction (DirectionId) 
            ON DELETE CASCADE ON UPDATE CASCADE;



ALTER TABLE TaskTrack DROP CONSTRAINT FK_TaskTrack_UserTask_UserTaskId;

ALTER TABLE TaskTrack
    add CONSTRAINT FK_TaskTrack_UserTask_UserTaskId FOREIGN KEY (UserTaskId) REFERENCES UserTask (UserTaskId)
        ON DELETE CASCADE ON UPDATE CASCADE;




ALTER TABLE UserTask DROP CONSTRAINT FK_UserTask_Task_TaskId;
ALTER TABLE UserTask DROP CONSTRAINT FK_UserTask_UserProfile_UserId;
ALTER TABLE UserTask DROP CONSTRAINT FK_UserTask_TaskState_StateId;


ALTER TABLE UserTask
    add CONSTRAINT FK_UserTask_Task_TaskId FOREIGN KEY (TaskId) REFERENCES Task (TaskId)
        ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE UserTask       
    add CONSTRAINT FK_UserTask_UserProfile_UserId FOREIGN KEY (UserID) REFERENCES UserProfile (UserId)
        ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE UserTask       
    add CONSTRAINT FK_UserTask_TaskState_StateId FOREIGN KEY (StateId) REFERENCES TaskState (StateId)
            ON DELETE CASCADE ON UPDATE CASCADE;