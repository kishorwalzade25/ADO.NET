using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET.Connection_Oriented_Model
{
    public class StoredProcedures
    {
        SqlConnection cn;
        SqlCommand cmd;
        public StoredProcedures() 
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Temp;Data Source=LAPTOP-A5NHDOOV";
            cn = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            

        }

        public void Exe_Pro() 
        {
            cmd.CommandText = "GetCompanyName";
            cmd.Parameters.AddWithValue("@revenue", 20000);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();

            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);

        }
    }
}
