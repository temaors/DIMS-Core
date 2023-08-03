using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class VUserTaskRepository : ReadOnlyRepository<VUserTask>
{
    public VUserTaskRepository(DimsCoreContext context) : base(context)
    {
    }
}