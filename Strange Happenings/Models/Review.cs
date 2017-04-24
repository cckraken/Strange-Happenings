using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strange_Happenings.Models
{
    public class Review
    {
        public virtual int ReviewID { get; set; }
        public virtual string AuthorName { get; set; }
        public virtual string ReviewDescription { get; set; }
     
        //There can be one or many reviews on one article
        public virtual int ArticleID { get; set; }
        public virtual Article Article { get; set; }



    }
}