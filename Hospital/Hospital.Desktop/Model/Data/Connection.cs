using System.Data.SqlClient;

namespace Hospital.Desktop.Model.Data
{
    public class Connection
    {
        private const string StrCon = @"Data Source=DESKTOP-KK4D9PQ\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        private SqlConnection Con { get;}
        private SqlCommand Cmd { get; set; }

        public SqlCommand StrCommand
        {
            get => Cmd;
            set => Cmd = value;
        }

        public Connection()
        {         
            Con = new SqlConnection(StrCon);
            Cmd = new SqlCommand { Connection = Con};
        }

        public bool OpenConnection()
        {
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}