﻿namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkExample.Data.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =  true;
        }

        protected override void Seed(EntityFrameworkExample.Data.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
