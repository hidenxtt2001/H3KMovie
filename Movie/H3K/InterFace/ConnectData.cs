using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3K.InterFace
{
    class ConnectData
    {
        private static string connectionString = @"Server=tcp:hunghuy2009.database.windows.net,1433;Initial Catalog=H3K;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection data { get; set; }

        public ConnectData()
        {
            data = new SqlConnection(connectionString);
        }
        public DataSet dataMovie()
        {
            data.Open();
            DataSet result = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(@"select * from Movies", data))
            {
                da.Fill(result);
                da.Dispose();
            }
            data.Close();
            return result;

        }
        public DataSet dataGenres()
        {
            data.Open();
            DataSet result = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(@"select movieid,genreid from Movie_genres", data))
            {
                da.Fill(result);
                da.Dispose();
            }
            data.Close();
            return result;
        }

        public bool Login(string username,string password)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "SELECT * FROM Account WHERE username=@USERNAME and password=@PASSWORD";
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        return reader.Read();
                    }
                }
            }
            catch (Exception)
            {
                data.Close();
                return false;
            }
        }

        public bool Register(string username, string password, string email)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "SELECT * FROM Account WHERE username=@USERNAME or email=@EMAIL";
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if(reader.Read())
                        {
                            return false;
                        }
                        else
                        {
                            reader.Close();
                            data.Open();
                            cmd.CommandText = "INSERT INTO Account (username,password,email) VALUES (@USERNAME,@PASSWORD,@EMAIL)";
                            cmd.ExecuteNonQuery();
                            data.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }
    }
}
