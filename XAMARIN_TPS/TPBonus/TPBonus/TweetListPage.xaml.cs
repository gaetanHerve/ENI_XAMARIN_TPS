using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPBonus.Entities;
using TPBonus.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPBonus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetListPage : ContentPage
    {
        readonly ObservableCollection<Tweet> Tweets = new TwitterService().Tweets;
        public TweetListPage()
        {
            InitializeComponent();
            this.ListeTweets.ItemsSource = this.Tweets;
        }
    }
}