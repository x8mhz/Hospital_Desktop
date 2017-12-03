using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital.Desktop.Model.Data;
using Hospital.Desktop.Model.Entities;

namespace Hospital.Desktop.Model.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private SqlDataReader _dr;

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

                var con = new Connection
                {
                    StrCommand = {CommandText = @"INSERT INTO TabPatient(Name, Genere, BirthDate, Cpf, Telephone, ZipCode, Street, Number, Country, State, City, Notice, Specialization) VALUES(@b, @c, @d, @e, @f, @g, @h, @i, @j, @l, @m, @n, @o)" }};
                con.OpenConnection();

                con.StrCommand.Parameters.AddWithValue("@b", patient.Name);
                con.StrCommand.Parameters.AddWithValue("@c", patient.Genere);
                con.StrCommand.Parameters.AddWithValue("@d", patient.BirthDate);
                con.StrCommand.Parameters.AddWithValue("@e", patient.Cpf);
                con.StrCommand.Parameters.AddWithValue("@f", patient.Telephone);
                con.StrCommand.Parameters.AddWithValue("@g", patient.ZipCode);
                con.StrCommand.Parameters.AddWithValue("@h", patient.Street);
                con.StrCommand.Parameters.AddWithValue("@i", patient.Number);
                con.StrCommand.Parameters.AddWithValue("@j", patient.Country);
                con.StrCommand.Parameters.AddWithValue("@l", patient.State);
                con.StrCommand.Parameters.AddWithValue("@m", patient.City);
                con.StrCommand.Parameters.AddWithValue("@n", patient.Notice);
                con.StrCommand.Parameters.AddWithValue("@o", patient.Specialization);

                con.StrCommand.ExecuteNonQuery();
                con.CloseConnection();

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public IEnumerable<Patient> GetAllPacients()
        {
            var con = new Connection { StrCommand = {CommandText = @"SELECT * FROM TabPatient"}};
            con.OpenConnection();
            _dr = con.StrCommand.ExecuteReader();

            var list = new List<Patient>();

            while (_dr.Read())
            {
                list.Add(new Patient
                {
                    Id = _dr.GetInt32(0),
                    Name = _dr.GetString(1),
                    Genere = _dr.GetString(2),
                    BirthDate = _dr.GetString(3),
                    Cpf = _dr.GetString(4),
                    Telephone = _dr.GetString(5),
                    ZipCode = _dr.GetString(6),
                    Street = _dr.GetString(7),
                    Number = _dr.GetString(8),
                    Country = _dr.GetString(9),
                    State = _dr.GetString(10),
                    City = _dr.GetString(11),
                    Notice = _dr.GetString(12),
                    Specialization = _dr.GetString(13)
                });
            }

            con.CloseConnection();

            return list;
        }
    }
}