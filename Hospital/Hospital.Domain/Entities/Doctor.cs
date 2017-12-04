namespace Hospital.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Genere { get; set; }
        public string BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }

        public string Specialization { get; set; }
        public string PhNo { get; set; }
    }
}