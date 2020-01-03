namespace Cole.UIForms.ViewModels
{
    using Cole.Common.Models;
    using Cole.Common.Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class TutorsViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Tutor> tutors;
        //Refresh valores
        public ObservableCollection<Tutor> Tutors
        {
            get { return this.tutors; }
            set { this.SetValue(ref this.tutors, value); }
        }

        public TutorsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadTutors();
        }
        private async void LoadTutors()
        {
            var response = await this.apiService.GetListAsync<Tutor>(
                "https://localhost:44396",
                "/api",
                "/Tutors");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
            }
            var myTutors = (List<Tutor>)response.Result;
            this.Tutors = new ObservableCollection<Tutor>(myTutors);
        }
    }
}
