using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class TaskStateRepository : Repository<TaskState>
{
    public TaskStateRepository(DbContext context) : base(context)
    {
    }
}