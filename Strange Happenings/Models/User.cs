using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strange_Happenings.Models
{
    public class User
    {
        //User
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserFirstName { get; set; }
        public virtual string UserLastName { get; set; }
        public virtual string Speciality { get; set; }

    }
}