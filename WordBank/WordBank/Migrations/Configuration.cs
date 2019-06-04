namespace WordBank.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Repozitory;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {    
        }

        protected override void Seed(ApplicationDbContext context)
        {
            
            //  This method will be called after migrating to the latest version.
            string[] roles = { "Standard", "Volunteer", "Specialist","Admin" };
            foreach (string RoleName in roles)
            {
                if (!context.Roles.Any(r => r.Name == RoleName))
                {
                    var store = new RoleStore<IdentityRole>(context);
                    var manager = new RoleManager<IdentityRole>(store);
                    var role = new IdentityRole { Name = RoleName };
                    manager.Create(role);
                }
            }
          
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
