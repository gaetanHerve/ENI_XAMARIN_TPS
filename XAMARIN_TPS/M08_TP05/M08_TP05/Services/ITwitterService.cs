using M08_TP05.Entities;
using M08_TP05.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace M08_TP05.Services
{
    interface ITwitterService
    {
        Boolean authenticate(User user);
        List<Tweet> getTweets(User user);
    }
}
