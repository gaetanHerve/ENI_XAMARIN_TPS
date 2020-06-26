using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TPBonus.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPBonus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectionPage : ContentPage
    {
        public LoginForm LoginForm { get; set; }
        public ConnectionPage()
        {
            InitializeComponent();
            LoginForm = new LoginForm(this.login, this.password, this.isRemind, this.loginForm, this.errorLabel, this.connection);
        }

        public async void Connection_Clicked(object sender, EventArgs e)
        {
            if(LoginForm.AllowConnection())
            {
                await Navigation.PushAsync(new TweetListPage());
            }
        }
    }
}