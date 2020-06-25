using System;
using System.Collections.Generic;
using System.Text;

namespace M07_TP04.Entities
{
    public class Tweet
    {
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Data { get; set; }
        public Tweet(User user, string data, DateTime createdAt)
        {
            User = user;
            Data = data;
            CreatedAt = createdAt;
        }
    }
}
