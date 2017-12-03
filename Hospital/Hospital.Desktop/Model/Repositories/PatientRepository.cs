using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital.Desktop.Model.Entities;

namespace Hospital.Desktop.Model.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public bool SavePatient(List<string> patientList)
        {
            try
            {
                var patient = new Patient
                {
                    Name = patientList[0],
                    Genere = patientList[1],
                    BirthDate = patientList[2],
                    Cpf = patientList[3],
                    Telephone = patientList[4],
                    ZipCode = patientList[5],
                    Street = patientList[6],
                    Number = patientList[7],
                    Country = patientList[8],
                    State = patientList[9],
                    City = patientList[10],
                    Notice = patientList[11],
                    Specialization = patientList[12]
                };

                var con = new SqlConnection(@"Data Source=DESKTOP-KK4D9PQ\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
                con.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO TabPatient(Id, Name, Genere, BirthDate, Cpf, Telephone, ZipCode, Street, Number, Country, State, City, Notice, Specialization) VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @l, @m, @n, @o)")
                {
                    Connection = con
                };

                cmd.Parameters.AddWithValue("@a", patient.Id);
                cmd.Parameters.AddWithValue("@b", patient.Name);
                cmd.Parameters.AddWithValue("@c", patient.Genere);
                cmd.Parameters.AddWithValue("@d", patient.BirthDate);
                cmd.Parameters.AddWithValue("@e", patient.Cpf);
                cmd.Parameters.AddWithValue("@f", patient.Telephone);
                cmd.Parameters.AddWithValue("@g", patient.ZipCode);
                cmd.Parameters.AddWithValue("@h", patient.Street);
                cmd.Parameters.AddWithValue("@i", patient.Number);
                cmd.Parameters.AddWithValue("@j", patient.Country);
                cmd.Parameters.AddWithValue("@l", patient.State);
                cmd.Parameters.AddWithValue("@m", patient.City);
                cmd.Parameters.AddWithValue("@n", patient.Notice);
                cmd.Parameters.AddWithValue("@o", patient.Specialization);


                con.Close();
                Console.WriteLine("SIM SIM SIM SIM");

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("ERRO ERRO ERRO ERRO");
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}