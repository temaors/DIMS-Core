using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class TaskTrackRepositoryFixture : AbstractRepositoryFixture<TaskTrack>
{
    public TaskTrackRepositoryFixture() : base(typeof(TaskTrackRepository))
    {
    }

    protected override void InitDatabase()
    {
        var entry = Context.TaskTracks.Add(new TaskTrack()
                               {
                                    TrackDate = DateTime.Now,
                                    TrackNote = "Task finished"
                               });
        Context.SaveChanges();
        entry.State = EntityState.Detached;
    }
}