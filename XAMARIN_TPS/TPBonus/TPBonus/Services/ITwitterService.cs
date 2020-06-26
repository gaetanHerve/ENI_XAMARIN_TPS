using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TPBonus.Entities;

namespace TPBonus.Services
{
    public interface ITwitterService
    {
        Boolean Authenticate(User user);
        ObservableCollection<Tweet> Tweets { get; }
    }
}
