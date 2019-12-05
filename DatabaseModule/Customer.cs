using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseModule
{
   public  class Customer
    {
        String FirstName;
        String LastName;
        String Address;
        String Contact;

        Link obj = new Link();

        public void setFirstName(String FirstName) {
            this.FirstName = FirstName;
        }
        public String getFirstName() {
            return FirstName;
        }

        public void setLastName(String LastName)
        {
            this.LastName = LastName;
        }
        public String getLastName()
        {
            return LastName;
        }

        public void setAddress(String Address)
        {
            this.Address= Address;
        }
        public String getAddress()
        {
            return Address;
        }


        public void setContact(String Contact)
        {
            this.Contact = Contact;
        }
        public String getContact()
        {
            return Contact;
        }


        //  constructor of the customer class that is used to pass the value to the nested function 
        public Customer(int id,String fName,String lName,String Address,String Contact) {
            setFirstName(fName);
            setLastName(lName);
            setAddress(Address);
            setContact(Contact);
        }

        // add the details of the customer to the customer table to save in the database 
        public void addCustomer() {
            String cmd = "Insert into customer(firstName,lastName,Address,Contact) values ('"+getFirstName()+"','"+getLastName()+"','"+getAddress()+"','"+getContact()+"')";
            obj.SqlQuery(cmd);
        }


        //this user define method that is used to delete the record of the customer from the table 
        public void delCustomer(int Id) {
            string cmd = "delete from customer where id='" + Id + "'";
            obj.SqlQuery(cmd);
        }

        //this method is used to compare the no of copies in are booked by the customer 
        public int srchCutomerData(int CustomerID)
        {
            DataTable tbl = new DataTable();

            String cmd = "select * from Rent where CustomerId=" + CustomerID + " and returnDate='Booked'";
            tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            return tbl.Rows.Count;


        }



        public String mostCustomer() {

            DataTable tblData = new DataTable();
            tblData = obj.srchRecord("select * from Customer ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =obj.srchRecord("select * from Rent where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["firstName"].ToString()+" "+ tblData.Rows[x]["lastName"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            return Title;

        }


        public void updateCustomer(int Id) {

            String cmd = "update customer set firstName='" + getFirstName() + "',lastName='" + getLastName() + "',Address='" + getAddress() + "',Contact='" + getContact() + "'  where id='" + Id + "'";

            obj.SqlQuery(cmd);
        }

        public void Datarecord(DataGridView dgv)
        {
            String cmd = "select * from Customer";

            DataTable tbl = new DataTable();
            tbl = obj.srchRecord(cmd);
            dgv.DataSource = tbl;
        }


    }
}
