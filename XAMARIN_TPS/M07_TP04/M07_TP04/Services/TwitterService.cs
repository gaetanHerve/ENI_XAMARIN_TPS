using M07_TP04.Entities;
using M07_TP04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace M07_TP04.Services
{
    public class TwitterService : ITwitterService
    {
        public List<Tweet> Tweets { get; set; }

        public TwitterService()
        {
            Tweets = new List<Tweet>();
            User user1 = new User() { Login = "monLogin1", Password = "password1" };
            User user2 = new User() { Login = "monLogin2", Password = "password2" };
            Tweet tweet1 = new Tweet(user1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", DateTime.Now);
            Tweet tweet2 = new Tweet(user1, "Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", DateTime.Now);
            Tweet tweet3 = new Tweet(user2, "maximus arcu lectus at lectus", DateTime.Now);
            Tweet tweet4 = new Tweet(user2, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce ipsum nisl, accumsan ac diam sed, scelerisque tempus sapien.", DateTime.Now);
            this.Tweets.Add(tweet1);
            this.Tweets.Add(tweet2);
            this.Tweets.Add(tweet3);
            this.Tweets.Add(tweet4);
        }

        public bool authenticate(User user)
        {
            Boolean result = false;

            result = this.Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Password == user.Password);

            return result;
        }

        public List<Tweet> getTweets(User user)
        {
            List<Tweet> result = (List<Tweet>)this.Tweets.Select(x => x.User).Where(x => x.Login == user.Login && x.Password == user.Password);
            return result;
        }

    }
}
