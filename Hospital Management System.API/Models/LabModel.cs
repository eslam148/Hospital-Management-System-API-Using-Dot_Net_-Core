namespace Hospital_Management_System.API.Models
{
    public class LabModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string NormalRang { get; set; }
        public string result { get; set; }

        public string PatientId { get; set; }
    }
}
