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
        //private static string connectionString = @"Server=DESKTOP-5EV3VQR\SQLEXPRESS;Database=DOAN;Trusted_Connection=True;MultipleActiveResultSets=true;";
        private SqlConnection data { get; set; }

        private DataTable _account;

        public DataTable Account { get { return _account; } }

        public ConnectData()
        {
            data = new SqlConnection(connectionString);
            _account = new DataTable();
        }

        #region LoadData
        /// <summary>
        /// Load Data From Database
        /// </summary>
        /// <param name="genreid"></param>
        /// <returns></returns>      
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
                if (!ex.Message.Contains("Thread was being aborted"))
                {
                    return dataMovie(genreid);
                }
                else Console.WriteLine(ex.Message);
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

        #endregion

        #region Login Action
        public bool Login(string username, string password) // Check Login
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
                        if (reader.Read())
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
        #endregion

        #region Data Account
        public bool setFavorite(string username, string movie_id)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = @"INSERT INTO Favorite VALUES (@username,@MovieID)";
                    cmd.Parameters.AddWithValue("@MovieID", movie_id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }
        public bool delFavorite(string username, string movie_id)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = @"DELETE FROM Favorite WHERE username=@username and movie_id=@MovieID";
                    cmd.Parameters.AddWithValue("@MovieID", movie_id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }
        public bool checkFavorite(string username, string movie_id)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "SELECT * FROM Favorite WHERE username=@USERNAME and movie_id=@movie_id";
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@movie_id", movie_id);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
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
        public bool checkHistory(string username, string movie_id)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "SELECT * FROM History WHERE username=@USERNAME and movie_id=@movie_id";
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@movie_id", movie_id);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
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
        public bool setHistory(string username, string movie_id)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = @"INSERT INTO History VALUES (@username,@MovieID,@datetime)";
                    cmd.Parameters.AddWithValue("@MovieID", movie_id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    return true;
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
            try
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
            catch (Exception ex)
            {
                data.Close();
                if (ex.Message.Contains("The connection was not closed. The connection's current state is open."))
                {
                    return dataHistory(username);
                }
                return null;
            }
        }
        public DataSet dataFavorite(string username) // Get Favorite Movie Of Account
        {
            try
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
            catch (Exception ex)
            {
                data.Close();
                if (ex.Message.Contains("The connection was not closed. The connection's current state is open."))
                {
                    return dataFavorite(username);
                }
                return null;
            }
        }
        #endregion

        #region Search Options
        public DataSet searchMovie(string keyword)
        {
            try
            {
                data.Open();
                DataSet result = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT *  FROM Movies WHERE LOWER(title) LIKE LOWER(@keyword)", data))
                {
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    da.Fill(result);
                    da.Dispose();
                }
                data.Close();
                return result;
            }
            catch (Exception ex)
            {

                data.Close();
                if (!ex.Message.Contains("Thread was being aborted"))
                {
                    return searchMovie(keyword);
                }
                else Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataSet searchFavorite(string keyword)
        {
            try
            {
                data.Open();
                DataSet result = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Movies JOIN Favorite ON Movies.movie_id = Favorite.movie_id WHERE Favorite.username = @username AND LOWER(Movies.title) LIKE LOWER(@keyword)", data))
                {
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    da.SelectCommand.Parameters.AddWithValue("@username", Account.Rows[0]["username"].ToString());
                    da.Fill(result);
                    da.Dispose();
                }
                data.Close();
                return result;
            }
            catch (Exception ex)
            {

                data.Close();
                if (!ex.Message.Contains("Thread was being aborted"))
                {
                    return searchMovie(keyword);
                }
                else Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataSet searchHis(string keyword)
        {
            try
            {
                data.Open();
                DataSet result = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Movies JOIN History ON Movies.movie_id = History.movie_id WHERE History.username = @username AND LOWER(Movies.title) LIKE LOWER(@keyword)", data))
                {
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    da.SelectCommand.Parameters.AddWithValue("@username", Account.Rows[0]["username"].ToString());
                    da.Fill(result);
                    da.Dispose();
                }
                data.Close();
                return result;
            }
            catch (Exception ex)
            {

                data.Close();
                if (!ex.Message.Contains("Thread was being aborted"))
                {
                    return searchMovie(keyword);
                }
                else Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion



        #region Manage Movie
        public bool checkExist(string id)
        {
            using (SqlCommand cmd = new SqlCommand() { Connection = data })
            {
                try
                {
                    data.Open();
                    cmd.CommandText = "SELECT * FROM Movies WHERE movie_id = @MovieID";
                    cmd.Parameters.AddWithValue("MovieID", id);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        return reader.Read();
                    }
                }
                catch (Exception ex)
                {
                    data.Close();
                    return false;
                }
            }
        }

        public bool MovieAdd(string movieid, string title, string plot, int rating, string director, string movie_link, string poster_link, string nation, string year)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand() { Connection = data })
                {
                    cmd.CommandText = "insert into Movies (movie_id,title,plot,rating,director,movie_link,poster,year_create,nation,views_count) values(@MovieID,@Title,@Plot,@Rating,@Director,@Movie_Link,@Poster,@Year_Create,@Nation,@Views)";
                    cmd.Parameters.AddWithValue("@MovieID", movieid);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Plot", plot);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Director", director);
                    cmd.Parameters.AddWithValue("@Movie_Link", movie_link);
                    cmd.Parameters.AddWithValue("@Poster", poster_link);
                    cmd.Parameters.AddWithValue("@Nation", nation);
                    cmd.Parameters.AddWithValue("@Year_Create", year);
                    cmd.Parameters.AddWithValue("@Views", 0);
                    cmd.ExecuteNonQuery();
                    data.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }


        public bool MovieDel(string movieid)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand() { Connection = data })
                {
                    cmd.CommandText = "DELETE FROM Movie_Genres WHERE movie_id = @MovieID  DELETE FROM Movies WHERE movie_id = @MovieID";
                    cmd.Parameters.AddWithValue("@MovieID", movieid);
                    cmd.ExecuteNonQuery();
                    data.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }

        public bool MovieGenresAdd(string[] genre)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand() { Connection = data })
                {
                    cmd.CommandText = "INSERT INTO Movie_Genres VALUES " + string.Join(",", genre) + ";";
                    cmd.ExecuteNonQuery();
                    data.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                data.Close();
                return false;
            }
        }
        #endregion

        #region Update Account Information

        public bool UpdateInfor(string name, string email,string password)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = data;
                    cmd.CommandText = "UPDATE Account SET name=@name , email = @email , password = @password WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", this.Account.Rows[0]["username"].ToString());
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    data.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                data.Close();
                return false;
            }
        }

        #endregion


    }
}
