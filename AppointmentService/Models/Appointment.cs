namespace AppointmentService.Models
{
    public record Appointment
    {
        public required DateTime AppointmentTime { get; set; }
        public required string AppointmentType { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
