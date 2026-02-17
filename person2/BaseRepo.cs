using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace person2
{
    internal class BaseRepo
    {
        string cs = "Data Source=.;Initial Catalog=Schooldb;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        public BaseRepo()
        {
            con = new SqlConnection(cs);
        }
        protected void Execute(SqlCommand cmd)
        {
            cmd.Connection = con;

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }

            con.Close();
        }
    }
}
