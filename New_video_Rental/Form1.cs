using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_video_Rental
{
    public partial class Form1 : Form
    {
        int rentID = 0;
        int customer = 0,movie=0,rent=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCus_Click(object sender, EventArgs e)
        {
            //check the compoenent of the cusotmer portal to save the details of the customer    
            if (txtfName.Text.ToString().Equals("") || txtLName.Text.ToString().Equals("") || txtAddress.Text.ToString().Equals("") || txtMobile.Text.ToString().Equals(""))
            {
                MessageBox.Show("Enter all the details first to store the details of the customer ");
            }
            else {
                //if all the details are accurate then create the instance object of the customer class and pass the details to the customer class 
                DatabaseModule.Customer obj_Cust = new DatabaseModule.Customer(1, txtfName.Text.ToString(), txtLName.Text.ToString(), txtAddress.Text.ToString(), txtMobile.Text.ToString());
                obj_Cust.addCustomer();
                MessageBox.Show("Customer Record is saved in the Database");
                //after saving all the details all the component make empty 
                txtfName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtMobile.Text = "";

            }
        }

        private void DeleteCus_Click(object sender, EventArgs e)
        {
            try {
                //after fetching the details delete the particular record from the database 
                int Id = Convert.ToInt32(CustomerID.Text.ToString());
                DatabaseModule.Customer obj_Cust = new DatabaseModule.Customer(1, txtfName.Text.ToString(), txtLName.Text.ToString(), txtAddress.Text.ToString(), txtMobile.Text.ToString());
                if (obj_Cust.srchCutomerData(Id) == 0)
                {
                    //obj_Cust.delCustomer(Id);
                    MessageBox.Show("Selected Customer is Deleted from the Database ");

                }
                else {
                    MessageBox.Show("Customer already have movie on booking ");
                }


                //after saving all the details all the component make empty 
                txtfName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtMobile.Text = "";

                CustomerID.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void updateCus_Click(object sender, EventArgs e)
        {
            //check the compoenent of the cusotmer portal to save the details of the customer    
            if (txtfName.Text.ToString().Equals("") || txtLName.Text.ToString().Equals("") || txtAddress.Text.ToString().Equals("") || txtMobile.Text.ToString().Equals("") )
            {
                MessageBox.Show("Enter all the details first to Update the details of the customer ");
            }
            else
            {
                int Id = Convert.ToInt32(CustomerID.Text.ToString());

                //if all the details are accurate then create the instance object of the customer class and pass the details to the customer class 
                DatabaseModule.Customer obj_Cust = new DatabaseModule.Customer(Id, txtfName.Text.ToString(), txtLName.Text.ToString(), txtAddress.Text.ToString(), txtMobile.Text.ToString());
                obj_Cust.updateCustomer(Id);
                MessageBox.Show("Customer Record is Updated in the Database");
                //after saving all the details all the component make empty 
                txtfName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtMobile.Text = "";
                CustomerID.Text = "";

            }

        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString().Equals("") || txtScore.Text.ToString().Equals("") || txtYear.Text.ToString().Equals("") || txtCopies.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all the details of the Movie POrtal to keep it up to Date ");
            }
            else {


                try
                {

                    //dislay the cost of the price of the video after adding the year of the video
                    DateTime dateNow = DateTime.Now;

                    int Currentyear = dateNow.Year;

                    int diffYear = Currentyear - Convert.ToInt32(txtYear.Text.ToString());
                    // MessageBox.Show(diff.ToString());
                    if (diffYear >= 5)
                    {
                        txtCost.Text = "2";
                    }
                    if (diffYear >= 0 && diffYear < 5)
                    {
                        txtCost.Text = "5";
                    }

                }
                catch (Exception ex)
                {

                }

                DatabaseModule.Movie obj_Movie = new DatabaseModule.Movie(1, txtName.Text.ToString(), txtScore.Text.ToString(), Convert.ToInt32(txtYear.Text.ToString()), Convert.ToInt32(txtCost.Text.ToString()), Convert.ToInt32(txtCopies.Text.ToString()));
                obj_Movie.addMovie();
                MessageBox.Show("Movie Record is saved in the Database Table and the Movie Rental Cost is ==$"+txtCost.Text);
                txtName.Text = "";
                txtScore.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";

            }

        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (MovieId.Text.ToString().Equals(""))
                {
                    MessageBox.Show("Select the Movie First to delete ");
                }
                else
                {
                    DatabaseModule.Movie obj_Movie = new DatabaseModule.Movie(1, txtName.Text.ToString(), txtScore.Text.ToString(), Convert.ToInt32(txtYear.Text.ToString()), Convert.ToInt32(txtCost.Text.ToString()), Convert.ToInt32(txtCopies.Text.ToString()));
                    if (obj_Movie.srchMovieData(Convert.ToInt32(MovieId.Text.ToString())) == 0)
                    {

                        obj_Movie.delMovie(Convert.ToInt32(MovieId.Text.ToString()));
                        MessageBox.Show("Movie Record is deleted from the Database ");
                    }
                    else
                    {
                        MessageBox.Show("Movie is already booked ");
                    }
                    txtName.Text = "";
                    txtScore.Text = "";
                    txtYear.Text = "";
                    txtCost.Text = "";
                    txtCopies.Text = "";
                    MovieId.Text = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString().Equals("") || txtScore.Text.ToString().Equals("") || MovieId.Text.ToString().Equals("") || txtYear.Text.ToString().Equals("") || txtCopies.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all the details of the Movie POrtal to keep it up to Date ");
            }
            else
            {
                DatabaseModule.Movie obj_Movie = new DatabaseModule.Movie(1, txtName.Text.ToString(), txtScore.Text.ToString(), Convert.ToInt32(txtYear.Text.ToString()), Convert.ToInt32(txtCost.Text.ToString()), Convert.ToInt32(txtCopies.Text.ToString()));
                obj_Movie.updateMovie(Convert.ToInt32(MovieId.Text.ToString()));
                MessageBox.Show("Movie Record is Updated in the Database Table ");
                txtName.Text = "";
                txtScore.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
                MovieId.Text = "";



            }


        }

        private void ShowRental_Click(object sender, EventArgs e)
        {
            DatabaseModule.Rental obj = new DatabaseModule.Rental(1,1,1,"MovieIssueDate.Text","MovieReturnDate.Text");
            obj.Datarecord(Database);
            rent = 1;
            movie = 0;
            customer = 0;
        }

        private void ShowVideo_Click(object sender, EventArgs e)
        {

            DatabaseModule.Movie obj = new DatabaseModule.Movie(1, "txtName.Text.ToString()", "txtScore.Text.ToString()",2019, 5,5);
            obj.Datarecord(Database);
            movie = 1;
            rent = 0;
            customer = 0;
        }

        private void ShowCustomer_Click(object sender, EventArgs e)
        {
            DatabaseModule.Customer obj = new DatabaseModule.Customer(1, "txtfName.Text.ToString("," txtLName.Text.ToString()", "txtAddress.Text.ToString()"," txtMobile.Text.ToString()");
            obj.Datarecord(Database);
            customer = 1;
            rent = 0;
            movie = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MovieId.Text.ToString().Equals("") || CustomerID.Text.ToString().Equals(""))
            {
                MessageBox.Show("select the movie or customer first to book any movie ");
            }
            else {
                DatabaseModule.Rental obj_rent = new DatabaseModule.Rental(1, Convert.ToInt32(CustomerID.Text.ToString()), Convert.ToInt32(MovieId.Text.ToString()), MovieIssueDate.Text, MovieReturnDate.Text);
                if (obj_rent.issueMovie() == 1)
                {
                    MessageBox.Show("Movie is issued on rent ");
                }
                else {
                    MessageBox.Show("Movie is already booked or customer alrady may have 2 cd already on rent ");
                }

                MovieId.Text = "";
                CustomerID.Text = "";
                txtfName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtMobile.Text = "";

                txtName.Text = "";
                txtScore.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
            }


        }

        private void btnMovieReturn_Click(object sender, EventArgs e)
        {

            DatabaseModule.Rental obj_rent = new DatabaseModule.Rental(rentID, Convert.ToInt32(CustomerID.Text), Convert.ToInt32(MovieId.Text), MovieIssueDate.Text, MovieReturnDate.Text);
          
            MessageBox.Show("the charges of the movie is $"+obj_rent.returnMovie(rentID, Convert.ToInt32(MovieId.Text)));

            MovieId.Text = "";
            CustomerID.Text = "";
            txtfName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtScore.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
            txtCopies.Text = "";
            rent = 0;

        }

        private void Database_DoubleClick(object sender, EventArgs e)
        {
            if (customer==1) {
                CustomerID.Text= Database.CurrentRow.Cells[0].Value.ToString();
                txtfName.Text = Database.CurrentRow.Cells[1].Value.ToString();
                txtLName.Text=Database.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text= Database.CurrentRow.Cells[3].Value.ToString();
                txtMobile.Text= Database.CurrentRow.Cells[4].Value.ToString();
                customer = 0;

            }
            if (rent==1) {
                rentID=Convert.ToInt32( Database.CurrentRow.Cells[0].Value.ToString());
                CustomerID.Text=Database.CurrentRow.Cells[1].Value.ToString();
                MovieId.Text  = Database.CurrentRow.Cells[2].Value.ToString();
                MovieIssueDate.Text=Database.CurrentRow.Cells[3].Value.ToString();
                rent = 0;
            }


            if (movie==1) {
                MovieId.Text=Database.CurrentRow.Cells[0].Value.ToString();
                txtName.Text= Database.CurrentRow.Cells[1].Value.ToString();
                txtScore.Text= Database.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text= Database.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text= Database.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text= Database.CurrentRow.Cells[5].Value.ToString();
                movie = 0;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rentID>0) {
                DatabaseModule.Rental obj_Rental = new DatabaseModule.Rental(1, Convert.ToInt32(CustomerID.Text.ToString()), Convert.ToInt32(MovieId.Text.ToString()), MovieIssueDate.Text, MovieReturnDate.Text);
                if (obj_Rental.delMovie(rentID) == 0)
                {
                    MessageBox.Show("Rental Video is Deleted ");
                }
                else {
                    MessageBox.Show("Movie is already Booked ");
                }

                MovieId.Text = "";
                CustomerID.Text = "";
                txtfName.Text = "";
                txtLName.Text = "";
                txtAddress.Text = "";
                txtMobile.Text = "";
                txtName.Text = "";
                txtScore.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
                rent = 0;

            }
        }

        private void btnMostCustomer_Click(object sender, EventArgs e)
        {
            DatabaseModule.Customer obj_Cust = new DatabaseModule.Customer(1," txtfName.Text.ToString()", "txtLName.Text.ToString()"," txtAddress.Text.ToString()"," txtMobile.Text.ToString()");
            MessageBox.Show("the Best Customer is " + obj_Cust.mostCustomer());


        }

        private void btnMostMovie_Click(object sender, EventArgs e)
        {
            DatabaseModule.Movie obj_Movie = new DatabaseModule.Movie(1," txtName.Text.ToString()"," txtScore.Text.ToString()",2019, 5,5);
            MessageBox.Show("" + obj_Movie.mostMovie());
        }
    }
}
