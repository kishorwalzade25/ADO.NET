using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADO.NET.Connection_Oriented_Model
{
    public  class CRUD_Operation
    {
        SqlConnection cn;
        SqlCommand cmd;
       public CRUD_Operation() 
        {
         
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Temp;Data Source=LAPTOP-A5NHDOOV";
            cn = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
        }

        public void Add_Data() 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into CompanyRevenues values (@cname,@revenue)";
            cmd.Parameters.AddWithValue("@cname", "Omega");
            cmd.Parameters.AddWithValue("@revenue", 500000);

            if (cn.State == ConnectionState.Closed) 
            {
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void View_Data()  
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select * from CompanyRevenues";
            if (cn.State == ConnectionState.Closed) 
            {
                cn.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();

            dt.Load(dr);
            //ds.Tables.Add(dt);
            
        }

        public void search() 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select revenue from CompanyRevenues where cname=@cname";
            cmd.Parameters.AddWithValue("@cname", "NightShell");
            if (cn.State == ConnectionState.Closed) 
            {
                cn.Open();
            }

            decimal revenue = (decimal)cmd.ExecuteScalar();
            cn.Close();

        }

        public void update() 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "update CompanyRevenues set revenue=@revenue where cname=@cname";
            cmd.Parameters.AddWithValue("@cname", "Daycare");
            cmd.Parameters.AddWithValue("@revenue", 70000);

            if (cn.State == ConnectionState.Closed) 
            {
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete() 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete  from CompanyRevenues where cname = @cname";
            cmd.Parameters.AddWithValue("@cname", "Daycare");

            if (cn.State == ConnectionState.Closed) 
            {
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
