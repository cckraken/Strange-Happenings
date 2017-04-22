using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Strange_Happenings.Models
{
    public class Topic
    {
        //Topic model
        public virtual int TopicID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
       
        //Each topic has one or many genres linked to it
        public virtual int GenreID { get; set; }
        public virtual Genre GenreName { get; set; }
        
        //Each topic has one or many reviews linked to it
        public IEnumerable<Review> Reviews { get; set; } 

    }
}