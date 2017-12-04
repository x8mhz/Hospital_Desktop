namespace Hospital.Domain.Entities
{
    public class HospitalCenter
    {
        public int Id { get; set; }
        public string Localization { get; set; }
        public string Sector { get; set; }
        public int QtdRoom { get; set; }
    }
}