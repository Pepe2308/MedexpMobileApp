using MedexpMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedexpMobile.Pages
{
    public partial class LoginPage : ContentPage
    {
        DoctorService _doctorService = new DoctorService();
        PatientService _patientService = new PatientService();

        public LoginPage()
        {
            InitializeComponent();
        }

        public async void ForgetPasswordMethod(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Aun no estoy implementado", "Ok");
        }

        private async void SignInPressed(object sender, EventArgs e)
        {
            var doctor = _doctorService.GetDoctor(1);
            var patient = _patientService.GetPatient();

            if (string.IsNullOrEmpty(Username.Text))
            {
                await DisplayAlert("Alerta", "Ingrese nombre de usuario", "Aceptar");
                Username.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Alerta", "Ingrese contraseña", "Aceptar");
                Password.Focus();
                return;
            }
            //waitActivityIndicator.IsRunning = true;
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:6229");
            //string url = string.Format("api/DeviceUsersAPI/{0}/{1}",Username.Text,Password.Text);
            //var response = await client.GetAsync(url);
            //var result = response.Content.ReadAsStringAsync().Result;
            //waitActivityIndicator.IsRunning = false;
            //if(string.IsNullOrEmpty(result)|| result == "null")
            //{
            //    await DisplayAlert("Alerta", "Usuario o clave no valido", "Aceptar");
            //    Username.Text = string.Empty;
            //    Password.Text = string.Empty;
            //    return;
            //}
            // await Navigation.PushAsync(new MainPage());

            if (doctor.Username.Equals(Username.Text) && doctor.Password.Equals(Password.Text))
            {
                waitActivityIndicator.IsRunning = true;
                await Task.Delay(3000);
                //App.Current.MainPage = new NavigationPage(new FirstPage());
                await Navigation.PushAsync(new DoctorMainPage());
                waitActivityIndicator.IsRunning = false;
                Username.Text = string.Empty;
                Password.Text = string.Empty;
            }
            else if (patient.Username.Equals(Username.Text) && patient.Password.Equals(Password.Text))
            {
                waitActivityIndicator.IsRunning = true;
                await Task.Delay(3000);
                //App.Current.MainPage = new NavigationPage(new FirstPage());
                await Navigation.PushAsync(new PatientMainPage());
                waitActivityIndicator.IsRunning = false;
                Username.Text = string.Empty;
                Password.Text = string.Empty;
            }
            else
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Aceptar");
                Username.Text = string.Empty;
                Password.Text = string.Empty;
                return;
            }
        }
    }
}
