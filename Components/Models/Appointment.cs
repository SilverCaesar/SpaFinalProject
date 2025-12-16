namespace SpaFinalProject.Components.Models
{
    public class Appointment
    {
        private int appointment_id;
        //fk customer_id
        private int customer_id;
        //fk employee
        private int employee_id;
        //fk service
        private int service_id;

        private DateTime date;
        private DateTime start;
        private string ?status;
        private string ?Notes;
        private decimal price;
        private int duration;
    }
}
