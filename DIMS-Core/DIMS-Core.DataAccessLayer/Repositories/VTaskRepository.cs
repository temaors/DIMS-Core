using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class VTaskRepository : ReadOnlyRepository<VTask>
{
    public VTaskRepository(DimsCoreContext context) : base(context)
    {
    }
}