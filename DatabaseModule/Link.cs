using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DatabaseModule
{
    public class Link
    {


        //Conn Instance Object of SQl Connection Class
        SqlConnection conection;

        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=LAPTOP-RC3ICK9D\\SQLEXPRESS;Initial Catalog=VideoPortal;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand cmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;

        //this method is used to execute the sql query like insert delete update in the database tables
        public void SqlQuery(String query)
        {
            conection = new SqlConnection(conStr);
            conection.Open();
            cmd = new SqlCommand(query, conection);
            cmd.ExecuteNonQuery();
            conection.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable srchRecord(String qry)
        {
            DataTable tbl = new DataTable();


            conection = new SqlConnection(conStr);

            conection.Open();
            cmd = new SqlCommand(qry, conection);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conection.Close();

            return tbl;
        }





    }
}
