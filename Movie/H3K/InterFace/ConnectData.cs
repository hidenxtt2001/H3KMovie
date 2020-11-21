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
        private static string connectionString = @"Server=tcp:hunghuy201280.database.windows.net,1433;Initial Catalog=H3K;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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

    }
}
