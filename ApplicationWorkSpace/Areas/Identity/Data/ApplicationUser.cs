using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace ASP.ApplicationWorkSpace.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [DisplayName("Имя")]

    public string? FirstName { get; set; }

    [DisplayName("Отчество")]

    public string? LastName { get; set; }
}

public class ApplicationRole : IdentityRole
{

}
