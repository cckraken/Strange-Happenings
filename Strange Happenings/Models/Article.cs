using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Strange_Happenings.Models
{
    public class Article
    {
        //many to one relationship with genre (FK GenreID)
        public virtual int ArticleID { get; set; }
        public virtual string ArticleName { get; set; }
        public virtual string ArticleDescription { get; set; }

        //Article is linked to one user
        public virtual int UserID { get; set; }
        public virtual User User { get; set; }

        //Article is linked to one genre
        public virtual int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        //Article is linked to many reviews
        public IEnumerable<Review> Reviews { get; set; }

    
    }
}