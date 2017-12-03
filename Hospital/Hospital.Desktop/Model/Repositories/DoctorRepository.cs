using Hospital.Desktop.Model.Data;
using Hospital.Desktop.Model.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hospital.Desktop.Model.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private SqlDataReader _dr;

        public IEnumerable<Doctor> GetAllDoctors()
        {
            var con = new Connection {StrCommand = {CommandText = @"SELECT * FROM TabDoctor"}};

            con.OpenConnection();
            _dr = con.StrCommand.ExecuteReader();

            var list = new List<Doctor>();

            while (_dr.Read())
            {
                list.Add(new Doctor
                {
                    Id = _dr.GetInt32(0),
                    Name = _dr.GetString(1),
                    Genere = _dr.GetString(2),
                    BirthDate = _dr.GetString(3),
                    Cpf = _dr.GetString(4),
                    Telephone = _dr.GetString(5),
                    Specialization = _dr.GetString(6),
                    PhNo = _dr.GetString(7)
                });
            }

            con.CloseConnection();

            return list;
        }
    }
}