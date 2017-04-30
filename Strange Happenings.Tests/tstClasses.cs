using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strange_Happenings.Models;

namespace Strange_Happenings.Tests
{
    [TestClass]
    public class Classes
    {
        [TestMethod]

        public void InstanceOK()

        {

            //create an instance class

            Genre AnAuthor = new Genre();

            //test to see that it exists

            Assert.IsNotNull(AnAuthor);
            
          
        }

        [TestMethod]

        public void InstanceOK2()

        {

            Review AReview = new Review();

            Assert.IsNotNull(AReview);

                    
        }

        [TestMethod]

        public void InstanceOK3()

        {

            Article AnArticle = new Article();

            Assert.IsNotNull(AnArticle);


        }





    }

}
