using AppointmentService.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger<AppointmentController> _logger;

        public AppointmentController(ILogger<AppointmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<Appointment> TryGetAppointment(string phoneNumber)
        {
            // Search the appointment DB for the inputted phone number
            // If the appointment is schedules less than X minutes from the time the querry was send, return the appointment details
            // And notify the queue service that the patient has arrived and can be called to an office
        }

        [HttpPost]
        public async Task<bool> ScheduleAppointment(Appointment appointment)
        {
            // Add the inputted appointment to the DB if there isn't already an appointment at the same time and type
        }

        [HttpDelete]
        public async Task<bool> CancelAppointment(Appointment appointment)
        {
            // Cancel the inputted appointment
        }
    }
}
