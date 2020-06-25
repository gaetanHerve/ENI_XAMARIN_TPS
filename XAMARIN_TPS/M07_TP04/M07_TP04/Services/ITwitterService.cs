using M07_TP04.Entities;
using M07_TP04.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace M07_TP04.Services
{
    interface ITwitterService
    {
        Boolean authenticate(User user);
        List<Tweet> getTweets(User user);
    }
}
