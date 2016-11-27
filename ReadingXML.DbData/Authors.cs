using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ReadingXML.DbData
{
    public class Authors : IAuthors
    {

        public DataSet GetAuthors()
        {
            var s = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var ds = new DataSet();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT au_id, au_lname, phone, address, city, state, zip, contract FROM AUTHORS", conn);
            da.Fill(ds, "authors");
            conn.Open();
            return ds;
        }
    }
}
