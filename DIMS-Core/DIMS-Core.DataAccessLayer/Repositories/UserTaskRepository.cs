using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class UserTaskRepository : Repository<UserTask>
{
    public UserTaskRepository(DbContext context) : base(context)
    {
    }
}