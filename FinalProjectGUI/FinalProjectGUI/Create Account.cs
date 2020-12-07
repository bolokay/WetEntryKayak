using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProjectGUI
{
    public partial class Create_Account : Form
    {
   

        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection();
          //  con.ConnectionString = "Data source=essql1.walton.uark.edu;" +
          //                  "Initial Catalog=PROJECTF2027;" +
         //                   "USER ID=PROJECTF2027;Password=SH93ack$";
         //   con.Open();

           // String query = "INSERT INTO Customer(Email_Address, First_Name, Last_Name, Country, State, City, Zip_Code, Address, Phone_Number) VALUES ('" + txt1.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + txt8.Text + "','" + txt9.Text + "','" + txt10.Text + "','" + txt11.Text + "')";
          //  String query3 = "Select Customer_ID from Customer Where Customer_ID = '"
          //  String query2 = "INSERT INTO UserID_Password (User_Name, Password)  Values ('" +txt1.Text "','" + txt2.Text + "')";
          //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
          //  SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
           // int v = sda.SelectCommand.ExecuteNonQuery();
          //  int c = sda2.SelectCommand.ExecuteNonQuery();
          //  con.Close();
            MessageBox.Show("Your account has been successfully created!");
            this.Close();
            
        }
    }
}
