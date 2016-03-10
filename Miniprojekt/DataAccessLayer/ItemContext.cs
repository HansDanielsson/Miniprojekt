using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Miniprojekt.Models;

namespace Miniprojekt.DataAccessLayer
{
    public class ItemContext : DbContext
    {
        public ItemContext() : base("DefaultConnection") { }

        public DbSet<ColorOnScreen> ColorOnScreen { get; set; }
        public DbSet<PictureOnScreen> PictureOnScreen { get; set; }
        public DbSet<TextOnScreen> TextOnScreen { get; set; }
        public DbSet<UserName> UserName { get; set; }
        public DbSet<UserRecord> UserRecord { get; set; }
    }
}