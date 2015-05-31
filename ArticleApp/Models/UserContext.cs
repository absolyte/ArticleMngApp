using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ArticleApp.Models
{
   

    public class UserContext : DbContext
    {

        public DbSet<UserModel> Users { get; set; }
    }
}