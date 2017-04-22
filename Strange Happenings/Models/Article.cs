using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strange_Happenings.Models
{
    public class Article
    {
        public virtual int ArticleID { get; set; }
        public virtual string ArticleName { get; set; }
        public virtual string ArticleDescription { get; set; }

        //Article is linked to one user
        public virtual int UserID { get; set; }
        public virtual User User { get; set; }

    
    }
}