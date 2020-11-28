using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mange_Movie
{
    class ConnectDatabase
    {
        public static string connectionString = @"Server=tcp:hunghuy2009.database.windows.net,1433;Initial Catalog=H3K;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection data;

        public ConnectDatabase()
        {
            data = new SqlConnection(connectionString);
        }

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

        public bool MovieAdd(string movieid,string title,string plot, int rating, string director, string movie_link,byte[] poster,string nation,string year)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand() { Connection = data})
                {
                    cmd.CommandText = "insert into Movies (movie_id,title,plot,rating,director,movie_link,poster,year_create,nation,views_count) values(@MovieID,@Title,@Plot,@Rating,@Director,@Movie_Link,@Poster,@Year_Create,@Nation,@Views)";
                    cmd.Parameters.AddWithValue("@MovieID", movieid);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Plot", plot);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Director", director);
                    cmd.Parameters.AddWithValue("@Movie_Link", movie_link);
                    cmd.Parameters.AddWithValue("@Poster", poster);
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
                    cmd.CommandText = " DELETE FROM Movies WHERE movie_id = @MovieID";
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

        public bool MovieGenresAdd(string [] genre)
        {
            try
            {
                data.Open();
                using (SqlCommand cmd = new SqlCommand() { Connection = data })
                {
                    cmd.CommandText = "INSERT INTO Movie_Genres VALUES " + string.Join(",", genre) +";";
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


    }
}
