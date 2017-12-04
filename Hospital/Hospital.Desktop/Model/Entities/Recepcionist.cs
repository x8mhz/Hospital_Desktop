namespace Hospital.Desktop.Model.Entities
{
    public class Recepcionist
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Genere { get; set; }
        public string BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}