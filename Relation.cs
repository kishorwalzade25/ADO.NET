using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
     class Relation
    {
        SqlConnection cn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataSet ds;
        public void Master_Relation() 
        {
            // string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwnd;Data Source=sekhartheguru";
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=LAPTOP-A5NHDOOV";
            cn = new SqlConnection(cs);
            da1 = new SqlDataAdapter("select * from categories", cn);
            da2 = new SqlDataAdapter("select * from products", cn);
            ds = new DataSet();
            da1.Fill(ds, "categories");
            da2.Fill(ds, "products");
            ds.Relations.Add("Categories_Products", ds.Tables["categories"].Columns["CategoryID"], ds.Tables["products"].Columns["CategoryID"]);


            var parentRow = ds.Tables["categories"].Rows[0];
            var childRows = parentRow.GetChildRows("Categories_Products");
            DataTable childTable = ds.Tables["products"].Clone();
            foreach (var row in childRows)
            {
                childTable.ImportRow(row);
            }

        }
    }
}
