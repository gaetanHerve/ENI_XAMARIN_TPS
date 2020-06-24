using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace M05TP01.Models
{
    class LoginForm
    {
        public Entry Login { get; }
        public Entry Password { get; }
        public Switch IsReminded { get; }
        public VisibilitySwitch VisibilitySwitch { get; }
        public ErrorForm ErrorForm { get; }

        public LoginForm(Entry login,
            Entry password,
            Switch isReminded,
            VisibilitySwitch visibilitySwitch,
            ErrorForm errorForm)
        {
            Login = login;
            Password = password;
            IsReminded = isReminded;
            VisibilitySwitch = visibilitySwitch;
            ErrorForm = errorForm;
        }

        public Boolean IsValid()
        {
            Boolean result = true;

            if (!CheckLogin())
            {
                result = false;
                this.ErrorForm.Message = "veuillez saisir un identifiant valide";
            }

            if (!CheckPassword())
            {
                result = false;
                this.ErrorForm.Message = "veuillez saisir un mot de passe valide";
            }

            if (!CheckPassword() && !CheckLogin())
            {
                result = false;
                this.ErrorForm.Message = "veuillez saisir un identifiant et un mot de passe valides";
            }

            return result;
        }

        public Boolean CheckLogin()
        {
            Boolean result = true;
            if (this.Login.Text == null || string.IsNullOrEmpty(this.Login.Text.ToString()) || this.Login.Text.ToString().Length < 3)
            {
                result = false;
            }

            return result;
        }

        public Boolean CheckPassword()
        {
            Boolean result = true;
            if (this.Password.Text == null || string.IsNullOrEmpty(this.Password.Text.ToString()) || this.Password.Text.Length < 6)
            {
                result = false;
            }

            return result;
        }

    }
}
