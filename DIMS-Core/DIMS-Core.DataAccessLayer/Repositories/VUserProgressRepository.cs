using System.Linq;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class VUserProgressRepository : ReadOnlyRepository<VUserProgress>
{
    public VUserProgressRepository(DimsCoreContext context) : base(context)
    {
    }
}