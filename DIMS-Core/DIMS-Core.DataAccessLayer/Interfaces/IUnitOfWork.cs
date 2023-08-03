using System;
using System.Threading.Tasks;
using DIMS_Core.DataAccessLayer.Models;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Task> TaskRepository { get; }
        IRepository<TaskState> TaskStateRepository { get; }
        IRepository<TaskTrack> TaskTrackRepository { get; }
        
        IRepository<UserProfile> UserProfileRepository { get; }
        IRepository<UserTask> UserTaskRepository { get; }
        IRepository<Direction> DirectionRepository { get; }

        IReadOnlyRepository<VUserProfile> VUserProfileRepository { get; }
        IReadOnlyRepository<VUserProgress> VUserProgressRepository { get; }
        IReadOnlyRepository<VUserTask> VUserTaskRepository { get; }
        IReadOnlyRepository<VUserTrack> VUserTrackRepository { get; }
        Task Save();
    }
}