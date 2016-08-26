using MedexpMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedexpMobile.Pages
{
    public partial class Patients : ContentPage
    {
        public Patients()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
            PatientService service = new PatientService();

            var patientsList = service.GetListOfPatients();

            PatientsListView.IsPullToRefreshEnabled = true;
            PatientsListView.ItemsSource = patientsList;

        }
        public async void PatientExpedientClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentInformation());
        }
    }
}
