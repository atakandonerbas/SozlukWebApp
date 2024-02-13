using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class DataModal
    {
        SqlConnection con; SqlCommand cmd;

        public DataModal()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

    }
}
