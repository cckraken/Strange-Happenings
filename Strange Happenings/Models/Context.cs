using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Strange_Happenings.Models
{
    public class Context : DbContext
    {

        public DbSet<Article> Article { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<User> User { get; set; }

        public Context() : base("name=Context")
        {

        }
    }
}

    

    

       

    
