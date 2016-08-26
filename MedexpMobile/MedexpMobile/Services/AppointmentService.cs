using MedexpMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedexpMobile.Services
{
    public class AppointmentService
    {
        public ICollection<Appointment> GetAllAppointments()
        {
            PatientService patient = new PatientService();
            List<Appointment> list = new List<Appointment>();
            list.Add(new Appointment
            {
                AppointmentId = 1,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 2,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 3,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            list.Add(new Appointment
            {
                AppointmentId = 4,
                Patient = patient.GetPatient(),
                Status = "Libre",
                Type = "Cita Medica",
                AppointmentDate = DateTime.Now,
                Hour = DateTime.Now,
                Severity = "Alta",
                Folio = "00001"
            });
            return list;
        }
    }
}
