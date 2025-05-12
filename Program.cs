using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using ADO.NET.Connection_Oriented_Model;

namespace ADO.NET
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Temp;Data Source=LAPTOP-A5NHDOOV";


            ////Inserting record

            //SqlConnection cn = new SqlConnection(cs);
            //SqlDataAdapter da = new SqlDataAdapter("select *from Employees", cn);
            //SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Employees");
            //// next line is not imp
            //ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);
            //DataRow row;
            //row = ds.Tables[0].NewRow();
            //row["Empno"] = "0005";
            //row["Ename"] = "kishor";
            //row["Salary"] = "30000";
            //row["Hiredate"] ="1994/10/25";
            //ds.Tables[0].Rows.Add(row);
            //da.Update(ds.Tables[0]);

            //----------------------------------------------------------------------------------------------------------------/

            // Reading Record

            //SqlConnection cn = new SqlConnection(cs);
            //SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            ////  SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Employees");
            ////dataGridView1.DataSource = ds.Tables[0];

            //-----------------------------------------------------------------------------------------------------------------//

            // Search in Datarow

            //SqlConnection cn = new SqlConnection(cs);
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", cn);

            ////SqlDataAdapter da = new SqlDataAdapter("Select * from Employees where Empno=4", cn);

            //DataSet ds = new DataSet();
            //da.Fill(ds, "Employees");
            //ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);

            //if (ds.Tables[0].Rows.Contains(4) == true)
            //{
            //    DataRow dr;

            //    // find method return the matched row
            //    dr = ds.Tables[0].Rows.Find(4);
            //    string id = dr[0].ToString();

            //    string name = dr["Ename"].ToString();
            //    string name1 = dr[1].ToString();
            //}

            //------------------------------------------------------------------------------------------------------------/

            //  To Update

            //SqlConnection cn = new SqlConnection(cs);
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", cn);
            //DataSet ds = new DataSet();
            //SqlCommandBuilder cmb;
            //cmb = new SqlCommandBuilder(da);
            //da.Fill(ds, "Employees");
            //ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);

            ////DataRowCollection accept all rows in the table.

            //DataRowCollection row;
            //row = ds.Tables[0].Rows;
            //row[0].BeginEdit();
            //row[0][1] = "vaishali";
            //row[0][2] = "20000";
            //row[0].EndEdit();

            // Single Rows


            // DataRow row;
            //// row = ds.Tables[0].Rows.Find(5);
            // row = ds.Tables["Employees"].Rows.Find(5);

            // row.BeginEdit();
            // //row["Ename"] = "chandrabhan";
            // row[1] = "chandrakala";

            // //row["salary"] = "60000";
            //  row[2]="100000";
            //  row.EndEdit();

            //da.Update(ds.Tables[0]);

            //---------------------------------------------------------------------------------------------------------/

            // Delete Record

            //SqlConnection cn = new SqlConnection(cs);
            //SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            //SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Employees");
            //ds.Tables[0].Constraints.Add("Empno", ds.Tables[0].Columns[0], true);

            //ds.Tables[0].Rows.Find(104).Delete();
            //da.Update(ds.Tables[0]);

            //--------------------------------------------------------------------------------------------------------------/

            // Reading Excel sheet 

            //string csexcel = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Code\ADO.NET\kishor.xlsx;Extended Properties='Excel 12.0 Xml;HDR=Yes'";

            //OleDbConnection cnexcel = new OleDbConnection(csexcel);
            //OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Sheet1$]", cnexcel);
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable(); 

            //da.Fill(ds, "marks");
            //da.Fill(dt);
            //------------------------------------------------------------------------------------------------------------------/

            // parent-child relation

            //Relation ms = new Relation();
            //ms.Master_Relation();

            //-------------------------------------------------------------------------------------------------------------------/

            // Connection Oriented Model

            //CRUD_Operation crud = new CRUD_Operation();
            //  crud.Add_Data();
            // crud.View_Data();
            //  crud.search();
            //   crud.update();
            //  crud.Delete();

            //--------------------------------------------------------------------------------------------------------------------/

            // stored  procedure

            StoredProcedures sp = new StoredProcedures();
            sp.Exe_Pro();

            //-----------------------------------------------------------------------------------------------------------------//

            // Getting Files

            //Read_Image ri = new Read_Image();
            //// ri.Read_Img();
            //ri.save(); 
        }
    }

}
