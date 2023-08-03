using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories;

public class VUserTrackRepository : ReadOnlyRepository<VUserTrack>
{
    public VUserTrackRepository(DimsCoreContext context) : base(context)
    {
    }
}