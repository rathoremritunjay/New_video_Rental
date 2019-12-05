using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseModule
{
   public class Movie
    {

        Link obj = new Link();

        String Name;
        String Score = "";
        int Year;
        int Cost;
        int Copies;
        public void setName(String Title) {
            this.Name = Title;
        }
        public String getName() {
            return Name;
        }
        public void setScore(String Score) {
            this.Score = Score;
        }

        public String getScore() {
            return Score;
        }

        public void setYear(int Year) {
            this.Year = Year;
        }
        public int getYear() {
            return Year;
        }


        public void setCost(int cost) {
            this.Cost = cost;
        }

        public int getCost() {
            return Cost;
        }


        public void setCopies(int copies) {
            this.Copies = copies;
        }


        public int getCopies()
        {
            return Copies;

        }


        public Movie(int Id,String Name,String Score,int Year,int cost,int copies)
        {
            setName(Name);
            setScore(Score);
            setYear(Year);
            setCost(cost);
            setCopies(copies);

        }

        // add the details of the Movie to the Movie table to save in the database 
        public void addMovie() {
            String cmd = "insert into movie(Name,Score,Year,Cost,Copies) values ('"+getName()+"','"+getScore()+"',"+getYear()+","+getCost()+","+getCopies()+")";
            obj.SqlQuery(cmd);
        }

        //this user define method that is used to delete the record of the Movie from the table 
        public void delMovie(int Id)
        {
            string cmd = "delete from Movie where id='" + Id + "'";
            obj.SqlQuery(cmd);
        }

        public void updateMovie(int Id) {

            String cmd = "update Movie set Name='" + getName() + "',Score='" + getScore() + "',Year=" + getYear() + ",Cost=" + getCost() + ",Copies=" + getCopies() + " where  id='" + Id + "'";
            obj.SqlQuery(cmd);
        }

        public int srchMovieData(int MovieID)
        {
            DataTable tbl = new DataTable();

            String cmd = "select * from Rent where MovieId=" + MovieID + " and returnDate='Booked'";
            tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            return tbl.Rows.Count;


        }

        public String mostMovie() {
            DataTable tblData = new DataTable();
            tblData = obj.srchRecord("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = obj.srchRecord("select * from Rent where movieId=" + Convert.ToInt32(tblData.Rows[x]["id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            return Title;



        }

        public void Datarecord(DataGridView dgv)
        {
            String cmd = "select * from Movie";

            DataTable tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            dgv.DataSource = tbl;
        }




    }
}
