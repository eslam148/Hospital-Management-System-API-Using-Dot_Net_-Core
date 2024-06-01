namespace Hospital_Management_System.API.Models
{
    public class DiagnosesModel
    {
        
       // public Guid id { get; set; }
        public string info { get; set; }
        public DateTime DateTime { get; set; }

        public Guid PatientId { get; set; }
    }
}
