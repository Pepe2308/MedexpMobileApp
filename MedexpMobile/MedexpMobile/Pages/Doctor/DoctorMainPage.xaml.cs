using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedexpMobile.Pages
{
    public partial class DoctorMainPage : ContentPage
    {
        public DoctorMainPage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
        }

        public async void PatientsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Patients());
        }

        public async void AppointmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentListView());
        }
    }
}
