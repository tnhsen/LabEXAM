using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace LabEXAM.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string username;
        string password;
        string loginState;
        public Command LoginCommand { get; }

        public string UserName
        {
            get => username;
            set
            {
                username = value;
                var args = new PropertyChangedEventArgs(nameof(UserName));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string PassWord
        {
            get => password;
            set
            {
                password = value;
                var args = new PropertyChangedEventArgs(nameof(PassWord));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string LoginState
        {
            get => loginState;
            set
            {
                loginState = value;
                var args = new PropertyChangedEventArgs(nameof(LoginState));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public MainPageViewModel()
        {
            LoginCommand = new Command(() =>
            {
                LoginState = "";
                if (UserName == "sutstore" && PassWord == "1234")
                {
                    Application.Current.MainPage = new View.ProductListPage();
                }
                else
                {
                    LoginState = "Login failed";
                }
            });
        }
    }
}
