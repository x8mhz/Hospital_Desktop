using Hospital.Desktop.Model.Data;
using Hospital.Desktop.Model.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hospital.Desktop.Model.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private SqlDataReader _dr;
        
        public IEnumerable<HospitalCenter> GetAllHospitals()
        {
            var con = new Connection { StrCommand = { CommandText = @"SELECT * FROM TabHospital" } };

            con.OpenConnection();
            _dr = con.StrCommand.ExecuteReader();

            var list = new List<HospitalCenter>();

            while (_dr.Read())
            {
                list.Add(new HospitalCenter
                {
                    Id = (int) _dr.GetInt32(0),
                    Localization = (string) _dr.GetString(1),
                    QtdRoom = (int) _dr.GetInt32(2)
                });
            }

            con.CloseConnection();

            return list;
        }
    }
}