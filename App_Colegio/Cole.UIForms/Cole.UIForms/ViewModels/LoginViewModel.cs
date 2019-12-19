namespace Cole.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class LoginViewModel
    {
        public string User { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand => new RelayCommand(Login);


        private async void Login()
        {
            if (string.IsNullOrEmpty(this.User))
            {
                await Application.Current.MainPage.DisplayAlert("Error", 
                    "You must enter an User", 
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "You must enter an Password",
                    "Accept");
                return;
            }
            await Application.Current.MainPage.DisplayAlert("Ok",
                   "Lo que sigue",
                   "Accept");
        }
    }
}
