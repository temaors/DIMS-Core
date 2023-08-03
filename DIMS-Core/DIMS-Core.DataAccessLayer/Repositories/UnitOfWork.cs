using System;
using System.Threading.Tasks;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    /// <summary>
    ///     This class is unit of work pattern.
    ///     He is pretty popular in projects which have repository approach and using when you need to have access to many
    ///     repositories in one class under one context.
    ///     You can read about the pattern in Internet.
    /// </summary>
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DimsCoreContext _context;

        public UnitOfWork(DimsCoreContext context,
                          IRepository<Task> taskRepository,
                          IRepository<TaskState> taskStateRepository,
                          IRepository<TaskTrack> taskTrackRepository,
                          IRepository<UserTask> userTaskRepository,
                          IRepository<UserProfile> userProfileRepository,
                          IRepository<Direction> directionRepository,
                          IReadOnlyRepository<VUserProfile> vUserProfileRepository,
                          IReadOnlyRepository<VUserProgress> vUserProgressRepository,
                          IReadOnlyRepository<VUserTask> vUserTaskRepository,
                          IReadOnlyRepository<VUserTrack> vUserTrackRepository)
        {
            _context = context;
            TaskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            UserTaskRepository = userTaskRepository ?? throw new ArgumentNullException(nameof(userTaskRepository));
            TaskTrackRepository = taskTrackRepository ?? throw new ArgumentNullException(nameof(taskTrackRepository));
            TaskStateRepository = taskStateRepository ?? throw new ArgumentNullException(nameof(taskStateRepository));
            UserProfileRepository = userProfileRepository ?? throw new ArgumentNullException(nameof(userProfileRepository));
            DirectionRepository = directionRepository ?? throw new ArgumentNullException(nameof(directionRepository));
            VUserProfileRepository = vUserProfileRepository ?? throw new ArgumentNullException(nameof(vUserProfileRepository));
            VUserProgressRepository = vUserProgressRepository ?? throw new ArgumentNullException(nameof(vUserProgressRepository));
            VUserTaskRepository = vUserTaskRepository ?? throw new ArgumentNullException(nameof(vUserTaskRepository));
            VUserTrackRepository = vUserTrackRepository ?? throw new ArgumentNullException(nameof(vUserTrackRepository));

        }

        public IRepository<Task> TaskRepository { get; }
        public IRepository<TaskState> TaskStateRepository { get; }
        public IRepository<TaskTrack> TaskTrackRepository { get; }
        public IRepository<UserProfile> UserProfileRepository { get; }
        public IRepository<UserTask> UserTaskRepository { get; }
        public IRepository<Direction> DirectionRepository { get; }
        public IReadOnlyRepository<VUserProfile> VUserProfileRepository { get; }
        public IReadOnlyRepository<VUserProgress> VUserProgressRepository { get; }
        public IReadOnlyRepository<VUserTask> VUserTaskRepository { get; }
        public IReadOnlyRepository<VUserTrack> VUserTrackRepository { get; }

        /// <summary>
        ///     This method is not important here because each repository already has same method.
        ///     But remember you can use repositories separately from unit of work. So 'Save' method exists in UnitOfWork and
        ///     Repository.
        /// </summary>
        /// <returns></returns>
        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}