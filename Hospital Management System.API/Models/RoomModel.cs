namespace Hospital_Management_System.API.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int HospitalId { get; set; }
    }
}
