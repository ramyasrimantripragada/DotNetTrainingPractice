using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WordVoyagerMVC.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<UsersModel> users { get; set; }
        public DbSet<TagModel> tags { get; set; }

    }
}