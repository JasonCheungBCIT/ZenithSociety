using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using ZenithDataLib.Models;

[assembly: OwinStartupAttribute(typeof(ZenithWebSite.Startup))]
namespace ZenithWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        // In this method we will create default User roles and Admin user for login   
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {
                // first we create Admin rool   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                // Here we create a Admin super user who will maintain the website                  
                var user = new ApplicationUser();
                user.UserName = "ZenithAdmin";
                user.Email = "admin@zenith.com";
                string userPWD = "!@#123QWEqwe";

                // Create an admin user for marking 
                var user2 = new ApplicationUser();
                user2.UserName = "a";
                user2.Email = "a@a.a";
                string user2PWD = "P@$$w0rd";

                //Add default User to Role Admin  
                var chkUser = UserManager.Create(user, userPWD);
                var chkUser2 = UserManager.Create(user2, user2PWD);
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                    var result2 = UserManager.AddToRole(user2.Id, "Admin");
                }
            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("Member"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Member";
                roleManager.Create(role);

                // Here we create a Admin super user who will maintain the website                  
                var user = new ApplicationUser();
                user.UserName = "m";
                user.Email = "m@m.c";
                string userPWD = "P@$$w0rd";

                var chkUser = UserManager.Create(user, userPWD);

                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }
        }
    }
}
