using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace H3K.InterFace
{
    public class ConnectData
    {
        private static string connectionString = @"Server=tcp:hunghuy2009.database.windows.net,1433;Initial Catalog=H3K;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection data { get; set; }

        private DataTable _account;

        public DataTable Account { get { return _account; } }

        public ConnectData()
        {
            data = new SqlConnection(connectionString);
            _account = new DataTable();
        }
        public DataSet dataMovie(int genreid) // Get Movie follow genre
        {
            try
            {
                data.Open();
                DataSet result = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Movies JOIN Movie_Genres ON Movies.movie_id = Movie_Genres.movie_id WHERE Movie_Genres.genre_id = @GENREID", data))
                {
                    da.SelectCommand.Parameters.AddWithValue("@GENREID", genreid);
                    da.Fill(result);
                    da.Dispose();
                }
                data.Close();
                return result;
            }
            catch (Exception ex)
            {
                data.Close();
                if (ex.Message == "The connection was not closed. The connection's current state is connecting.")
                {
                    dataMovie(genreid);
                }
                return null;
            }

        }
        public DataSet dataGenres() // Get Genres
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

        public bool Login(string username,string password) // Check Login
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
                        if (reader.HasRows)
                        {
                            _account.Load(reader);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                data.Close();
                return false;
            }
        }

        public bool Register(string username, string password, string email) //Register Account 
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

        public DataSet dataHistory(string username) // Get History Movie of Account
        {
            data.Open();
            DataSet result = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(@"select mv.* from History his join Account ac on his.username = ac.username join Movies mv on mv.movie_id = his.movie_id where ac.username = @username", data))
            {
                da.SelectCommand.Parameters.AddWithValue("@username", username);
                da.Fill(result);
                da.Dispose();
            }
            data.Close();
            return result;
        }

        public DataSet dataFavorite(string username) // Get Favorite Movie Of Account
        {
            data.Open();
            DataSet result = new DataSet();
            using (SqlDataAdapter da = new SqlDataAdapter(@"select mv.* from Favorite fv join Account ac on fv.username = ac.username join Movies mv on mv.movie_id = fv.movie_id where ac.username = @username ", data))
            {
                da.SelectCommand.Parameters.AddWithValue("@username", username);
                da.Fill(result);
                da.Dispose();
            }
            data.Close();
            return result;
        }

        public bool UpdateAccount()
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "SELECT * FROM Account WHERE username=@USERNAME";
                    cmd.Parameters.AddWithValue("@USERNAME", _account.Rows[0]["username"].ToString());
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            _account.Load(reader);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                data.Close();
                return false;
            }
        }

        public void Logout() // Logout Account
        {
            if (Account != null) _account = null;
        }
    }
}
