namespace AddressBook.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AddressBook.Infrastructure.DataAccess.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AddressBook.Infrastructure.DataAccess.DataContext context)
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

            context.Users.AddOrUpdate<DataAccess.Entities.User>(
                new DataAccess.Entities.User[]
                {
                    new DataAccess.Entities.User
                    {
                        Email = "admin@gmail.com",
                        Password = "5f4dcc3b5aa765d61d8327deb882cf99".ToUpper()
                    }
                }
            );
        }
    }
}
