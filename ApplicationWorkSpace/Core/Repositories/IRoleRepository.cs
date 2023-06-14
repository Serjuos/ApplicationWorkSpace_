using ASP.ApplicationWorkSpace.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace ASP.ApplicationWorkSpace.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
