using System;
using System.Collections.Generic;
using System.Text;
using TPBonus.Entities;

namespace TPBonus.Services
{
    public interface ITwitterService
    {
        Boolean Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
