namespace GymAppln.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;


    using System.Data.Entity.Migrations;

    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GymAppln.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GymAppln.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            if (!context.Users.Any(r => r.UserName == "admin@GymBooking.se"))
            {
                var rRole = new RoleStore<IdentityRole>(context);
                var rManager = new RoleManager<IdentityRole>(rRole);

                var uStore = new UserStore<ApplicationUser>(context);
                var uManager = new UserManager<ApplicationUser>(uStore);

                var user = new ApplicationUser { UserName = "admin@GymBooking.se" };

                uManager.Create(user, "password");
                rManager.Create(new IdentityRole { Name = "admin" });
                uManager.AddToRole(user.Id, "admin");

                











            }
        }
    }
}
