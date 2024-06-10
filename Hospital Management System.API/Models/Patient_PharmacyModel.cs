namespace Hospital_Management_System.API.Models
{
    public class Patient_PharmacyModel
    {
        public Guid PatientID { get; set; }
        public Guid PharmacyId { get; set; }
        public decimal Amount { get; set; }
    }
}
