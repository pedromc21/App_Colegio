namespace Cole.UIForms.ViewModels
{
    using Cole.UIForms.Views;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class LoginViewModel
    {
        public string User { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand => new RelayCommand(Login);
        //Constructor
        public LoginViewModel()
        {

            this.User = "invernaderosjc@hotmail.com";
            this.Password = "M3N6BCYK";
        }
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
            MainViewModel.GetInstance().Tutors = new TutorsViewModel(); 
            await Application.Current.MainPage.Navigation.PushAsync(new TutorsPage());
        }
    }
}
