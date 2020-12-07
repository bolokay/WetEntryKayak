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
using SqlExample;

namespace FinalProjectGUI
{
    public partial class Login : Form
    {
        private SQLHelper helper = new SQLHelper();
        public Login()
        {
            InitializeComponent();
        }


        //private bool makeDataBaseConnection()
        //{


        //    helper.DBName = "PROJECTF2027";
        //    helper.User_Name = "PROJECTF2027";
        //    helper.Password = "SH93ack$";
        //    helper.ServerName = "essql1.walton.uark.edu";
        //    return true;
        //}

        //private void connect()
        //{

        //    try
        //    {
        //        if (!makeDataBaseConnection())
        //            MessageBox.Show("Failure to connect", "Connection Fail", MessageBoxButtons.OK);
        //        else if (helper.TestConnection())
        //        {
                    
                    

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

            private void btnSignIn_Click(object sender, EventArgs e)
        {


            try
            {



                if (radioCustomer.Checked == true)
                {
                    //sql connection//
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data source=essql1.walton.uark.edu;" +
                        "Initial Catalog=PROJECTF2027;" +
                        "USER ID=PROJECTF2027;Password=SH93ack$";

                    con.Open();

                    string password = txtPassword.Text;
                    SqlCommand cmd = new SqlCommand("select User_Name,Password from UserID_Password where User_Name='" +
                        txtUsername.Text + "'and Password='" + txtPassword.Text + "' and Customer_ID is not null", con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login sucess. Welcome to your account.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid login please check username and password");
                    }
                    con.Close();
                }

                /////////
                else if (radioEmployee.Checked == true)
                {
                    //sql connection//
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data source=essql1.walton.uark.edu;" +
                        "Initial Catalog=PROJECTF2027;" +
                        "USER ID=PROJECTF2027;Password=SH93ack$";
                    con.Open();

                    string password = txtPassword.Text;
                    SqlCommand cmd = new SqlCommand("select User_Name,Password from UserID_Password where User_Name='" +
                        txtUsername.Text + "'and Password='" + txtPassword.Text + "' and Employee_ID is not null", con);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login sucess. Welcome to your account.");
                        EmployeeDashboard ed = new EmployeeDashboard();
                        ed.StartPosition = FormStartPosition.CenterScreen;
                        ed.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login please check username and password");
                    }
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error incorrect see this: " + ex);
            }

        }




            private void lblClickHere_Click(object sender, EventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.StartPosition = FormStartPosition.CenterScreen;
            ca.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us for further assistance");
        }

       
    }
}
