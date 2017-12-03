namespace Hospital.Desktop.Model.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Genere { get; set; }
        public string BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }

        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public string Notice { get; set; }
        public string Specialization { get; set; }
    }
}