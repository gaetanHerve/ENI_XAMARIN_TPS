using M05TP01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace M05TP01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        LoginForm loginForm;
        public MainPage()
        {
            InitializeComponent();
            loginForm = new LoginForm(this.login,
                this.password,
                this.isReminded,
                new VisibilitySwitch());
        }

        private void connectionBtn_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("BUTTON CLICKED");
            if(this.loginForm.IsValid())
            {
                this.connectionForm.IsVisible = false;
                this.posts.IsVisible = true;
            } else
            {
                this.connectionForm.IsVisible = true;
                this.posts.IsVisible = false;
                this.error.Text = this.loginForm.ErrorForm.Message;
                this.error.IsVisible = true;
            }
        }
    }
}
