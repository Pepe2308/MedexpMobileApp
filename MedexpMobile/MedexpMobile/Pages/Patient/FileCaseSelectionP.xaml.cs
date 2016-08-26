﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedexpMobile.Pages.Patient
{
    public partial class FileCaseSelectionP : ContentPage
    {
        public FileCaseSelectionP()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "medexpLogo.png");
        }
        public async void PatientInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentInformation());
        }

        public async void PatientAppointmentClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Aun no estoy implementado", "Ok");
        }
    }
}
