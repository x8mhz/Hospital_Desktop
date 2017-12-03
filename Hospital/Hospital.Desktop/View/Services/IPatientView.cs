namespace Hospital.Desktop.View.Services
{
    public interface IPatientView
    {
        string NameComplete { get; set; }
        string Genere { get; set; }
        string BirthDate { get; set; }
        string Document { get; set; }
        string Telephone { get; set; }

        string ZipCode { get; set; }
        string Street { get; set; }
        string Number { get; set; }
        string Country { get; set; }
        string State { get; set; }
        string City { get; set; }

        string Notice { get; set; }
        string Specialization { get; set; }
    }
}