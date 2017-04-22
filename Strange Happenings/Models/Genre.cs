using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strange_Happenings.Models
{
    public class Genre
    {
        //Genre is linked to topic
        //Each topic has one or more genres
        public virtual int GenreID { get; set; }
        public virtual string GenreName { get; set; }
    }
}