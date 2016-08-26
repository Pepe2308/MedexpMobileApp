using MedexpMobile.Models;
using MedexpMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedexpMobile.Pages
{
    public partial class DoctorAppointment : ContentPage
    {
        public DoctorAppointment()
        {
            InitializeComponent();

            AppointmentService service = new AppointmentService();

            var appointmentList = service.GetAllAppointments();

            MedicinesListView.IsPullToRefreshEnabled = true;
            MedicinesListView.ItemsSource = appointmentList;
        }
        public async void ViewPatientExpedient(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentInformation());
        }
    }
}
