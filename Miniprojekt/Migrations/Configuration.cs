namespace Miniprojekt.Migrations
{
    using Miniprojekt.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccessLayer.ItemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Miniprojekt.DataAccessLayer.ItemContext context)
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

            //context.UserName.AddOrUpdate(
            //    new UserName { NickName="User1"},
            //    new UserName { NickName="User2"},
            //    new UserName { NickName="User3"}
            //    );

            //context.UserRecord.AddOrUpdate(
            //    new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 1, Points = 100 },
            //    new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 2, Points = 200 },
            //    new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 3, Points = 300 }
            //    );

            //context.ColorOnScreen.AddOrUpdate(
            //    new ColorOnScreen { Name = "Röd", rgb = 16711680 },
            //    new ColorOnScreen { Name = "Grön", rgb = 65280 },
            //    new ColorOnScreen { Name = "Blå", rgb = 255 },
            //    new ColorOnScreen { Name = "Gul", rgb = 16776960 },
            //    new ColorOnScreen { Name = "Svart", rgb = 0 },
            //    new ColorOnScreen { Name = "Brun", rgb = 10824234 }
            //    );

            //context.TextOnScreen.AddOrUpdate(
            //    new TextOnScreen
            //    {
            //        WrongText = "Mors*lilla*olle*i*skogen*gick*ut*en*dag*för*att*handla*mat.",
            //        OkText = "Mors lilla olle i skogen gick ut en dag för att handla mat." },
            //    new TextOnScreen
            //    {
            //        WrongText = "En*liten*gul*anka*vill*bada*i*ditt*badkar.",
            //        OkText = "En liten gul anka vill bada i ditt badkar." },
            //    new TextOnScreen
            //    {
            //        WrongText = "Som*man*skriver*kan*man*läsa*här.",
            //        OkText = "Som man skriver kan man läsa här." }
            //    );
			//context.UserName.AddOrUpdate(
			//	new UserName { NickName = "User1" },
			//	new UserName { NickName = "User2" },
			//	new UserName { NickName = "User3" }
			//	);
			//context.UserRecord.AddOrUpdate(
			//	new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 1, Points = 100 },
			//	new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 2, Points = 200 },
			//	new UserRecord { Category = CategoryType.PictureOnScreen, UserID = 3, Points = 300 }
			//	);
			//context.ColorOnScreen.AddOrUpdate(
			//	new ColorOnScreen { Name = "Röd", rgb = 16711680 },
			//	new ColorOnScreen { Name = "Grön", rgb = 65280 },
			//	new ColorOnScreen { Name = "Blå", rgb = 255 },
			//	new ColorOnScreen { Name = "Gul", rgb = 16776960 },
			//	new ColorOnScreen { Name = "Svart", rgb = 0 },
			//	new ColorOnScreen { Name = "Brun", rgb = 10824234 }
			//	);

			//context.TextOnScreen.AddOrUpdate(
			//	new TextOnScreen
			//	{
			//		WrongText = "Mors*lilla*olle*i*skogen*gick*ut*en*dag*för*att*handla*mat.",
			//		OkText = "Mors lilla olle i skogen gick ut en dag för att handla mat."
			//	},
			//	new TextOnScreen
			//	{
			//		WrongText = "En*liten*gul*anka*vill*bada*i*ditt*badkar.",
			//		OkText = "En liten gul anka vill bada i ditt badkar."
			//	},
			//	new TextOnScreen
			//	{
			//		WrongText = "Som*man*skriver*kan*man*läsa*här.",
			//		OkText = "Som man skriver kan man läsa här."
			//	}
			//	);
			//context.PictureOnScreen.AddOrUpdate(
			//new PictureOnScreen { Image = "Fyrkant" },
			//new PictureOnScreen { Image = "Cirkel" },
			//new PictureOnScreen { Image = "Triangel" },
			//new PictureOnScreen { Image = "Hexagon" },
			//new PictureOnScreen { Image = "Polygon" }
			//);
        }
    }
}
