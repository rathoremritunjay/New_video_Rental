using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseModule
{
   public class Rental
    {
        int MovieID;
        int CustomerID;
        String issueDate;
        String returnDate;

        Link obj = new Link();

        public void setMovieId(int Id) {
            this.MovieID = Id;
        }

        public int getMovieId() {
            return MovieID;
        }

        public void setCustomerId(int Id)
        {
            this.CustomerID = Id;
        }

        public int getCustomerId()
        {
            return CustomerID;
        }


        public void setIssueDate(String issueDate) {
            this.issueDate = issueDate;
        }

        public String getIssueDate() {
            return issueDate;
        }
        public void setReturnDate(String returnDate)
        {
            this.returnDate = returnDate;
        }

        public String getreturnDate()
        {
            return returnDate;
        }



        public Rental(int id,int CustomerId,int MovieId,String issueDate,String returnDate) {
            setMovieId(MovieId);
            setCustomerId(CustomerId);
            setIssueDate(issueDate);
            setReturnDate(returnDate);
        }


        //this method is used to compare the no of copies in are booked is less then the total copies or not 
        public int srchMovieData(int MovieID) {
            DataTable tbl = new DataTable();
            String cmd1 = "select * from Movie where id="+MovieID+"";
            tbl = obj.srchRecord(cmd1);
            int copies = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["Copies"].ToString());

            String cmd = "select * from Rent where MovieId="+MovieID+" and returnDate='Booked'";
            tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            if (copies > tbl.Rows.Count)
            {
                return 1;
            }
            else {
                return 0;
            }
            

        }

        //this method is used to compare the no of copies in are booked by the customer 
        public int srchCutomerData(int CustomerID)
        {
            DataTable tbl = new DataTable();
           
            String cmd = "select * from Rent where CustomerId=" + CustomerID + " and returnDate='Booked'";
            tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            if (tbl.Rows.Count < 2)
            {
                return 1;
            }
            else {
                return 0;
            }
  

        }



        public int issueMovie() {

            if (srchMovieData(getMovieId()) == 1 && srchCutomerData(getCustomerId()) == 1)
            {
                String cmd = "insert into Rent (CustomerId,MovieId,issueDate,returnDate) values("+getCustomerId()+","+getMovieId()+",'"+getIssueDate()+"','Booked')";
                obj.SqlQuery(cmd);
                return 1;
            }
            else {
                return 0;   
            }
        }

        public int returnMovie(int rentId, int movieId) {

            String Query = "select * from movie where id=" + Convert.ToInt32(movieId) + "";
            DataTable tbl = new DataTable();
            tbl =obj.srchRecord(Query);
            int cost = 1;
            if (tbl.Rows.Count > 0)
            {
                cost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());
            }
           // MessageBox.Show(""+cost);

            DateTime new_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(getIssueDate());


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));
          //  MessageBox.Show("" + DaysInterval);

            if (DaysInterval==0) {
                DaysInterval++;
            }
            int Price = Convert.ToInt32(DaysInterval) * cost;

            String cmd="update Rent set customerId="+getCustomerId()+",MovieId="+getMovieId()+",issueDate='"+getIssueDate()+"',returnDate='"+getreturnDate()+"' where id="+rentId+"";

            obj.srchRecord(cmd);
            return Price;


        }

        public int delMovie(int Id)
        {

            Link obj = new Link();
            DataTable dt = new DataTable();
            String cmd1 = "Select * from Rent Where id=" + Id + " and returnDate='Booked'";
            dt = obj.srchRecord(cmd1);
            if (dt.Rows.Count == 0)
            {


                String cmd = "delete from Rent where id=" + Id + "";
                obj.SqlQuery(cmd);
                return 0;
            }
            else {
                return 1;
            }
                
            
        }






        public void Datarecord(DataGridView dgv) {
            String cmd = "select * from Rent ";
            
            DataTable tbl = new DataTable();
            tbl=obj.srchRecord(cmd);
            dgv.DataSource = tbl;
        }


    }
}
