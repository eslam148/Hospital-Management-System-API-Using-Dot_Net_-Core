namespace Hospital_Management_System.API.Models
{
    public class DepartmentModel
    {
        public Guid id { get; set; }
        public string Name { get; set; }

        public int HospitalId { get; set; }
    }
}
