using ASP.ApplicationWorkSpace.Areas.Identity.Data;
using ASP.ApplicationWorkSpace.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ASP.ApplicationWorkSpace.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
