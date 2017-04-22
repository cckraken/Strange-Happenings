using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Strange_Happenings.Models
{
    public class DataInitialiser : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {

            //seed data for users
            User user1 = new User();
            user1.UserID = 1;
            user1.UserFirstName = "Daniel";
            user1.UserLastName = "Barrett";
            user1.UserName = "cckraken";
            context.User.Add(user1);

            User user2 = new User();
            user2.UserID = 2;
            user2.UserFirstName = "Matt";
            user2.UserLastName = "Carlin";
            user2.UserName = "carlincarlin";
            context.User.Add(user2);

            User user3 = new User();
            user3.UserID = 3;
            user3.UserFirstName = "Tom";
            user3.UserLastName = "Jones";
            user3.UserName = "TommyJ";
            context.User.Add(user3);


            //seed data for topics
            Topic topic1 = new Topic();
            topic1.TopicID = 1;
            topic1.Title = "Tottenham vs Chelsea";
            topic1.Description = "FA cup semifinal. Who wins?";
            topic1.GenreID = 1;         
            context.Topic.Add(topic1);

            //seed data for topics
            Topic topic2 = new Topic();
            topic2.TopicID = 1;
            topic2.Title = "Too much salt?";
            topic2.Description = "How much salt is too much?";
            topic1.GenreID = 2;
            context.Topic.Add(topic2);

            //seed data for topics
            Topic topic3 = new Topic();
            topic3.TopicID = 1;
            topic3.Title = "Ebola crisis";
            topic3.Description = "What can we do to help?";
            topic3.GenreID = 3;
            context.Topic.Add(topic3);




            //seed data for genres
            Genre GenreName = new Genre();
            GenreName.GenreID = 1;
            GenreName.GenreName = "Football";

            //seed data for genres
            Genre GenreName2 = new Genre();
            GenreName2.GenreID = 2;
            GenreName2.GenreName = "Cooking";

            //seed data for genres
            Genre GenreName3 = new Genre();
            GenreName3.GenreID = 3;
            GenreName3.GenreName = "World events";




            //seed data for reviews
            Review Review1 = new Review();
            Review1.ReviewID = 1;
            Review1.ArticleID = 1;
            Review1.AuthorName = "Daniel Barrett";
            Review1.ReviewDescription = "Excellent game. Chelsea got lucky though.";
            context.Review.Add(Review1);

            Review Review2 = new Review();
            Review2.ReviewID = 2;
            Review2.ArticleID = 2;
            Review2.AuthorName = "Matt Carlin";
            Review2.ReviewDescription = "I don't like any salt at all on my food.";
            context.Review.Add(Review2);

            Review Review3 = new Review();
            Review3.ReviewID = 3;
            Review3.ArticleID = 3;
            Review3.AuthorName = "Tom jones";
            Review3.ReviewDescription = "Just donate money, I suppose? Unless you're flying to get training and fly out over there.";
            context.Review.Add(Review3);

            base.Seed(context);

        
        }
    }
}