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


        private bool makeDataBaseConnection()
        {


            helper.DBName = "PROJECTF2027";
            helper.User_Name = "PROJECTF2027";
            helper.Password = "SH93ack$";
            helper.ServerName = "essql1.walton.uark.edu";
            return true;
        }

        private void connect()
        {

            try
            {
                if (!makeDataBaseConnection())
                    MessageBox.Show("Failure to connect", "Connection Fail", MessageBoxButtons.OK);
                else if (helper.TestConnection())
                {
                    if (radioCustomer.Checked == true)
                    {
                        string username = txtUsername.Text;
                        string password = txtPassword.Text;

                        try
                        {
                            var user = helper.ExecuteScalar("Select User_Name FROM UserID_Password WHERE User_Name = " + username + " AND Customer_ID IS NOT NULL", CommandType.Text);
                            var pass = helper.ExecuteScalar("Select Password FROM UserID_Password WHERE Password = " + password + " AND Customer_ID IS NOT NULL", CommandType.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                      


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnSignIn_Click(object sender, EventArgs e)
        {
          


                connect();



                //    try
                //    {



                //        if (radioCustomer.Checked == true)
                //        {
                //            //sql connection//
                //            SqlConnection con = new SqlConnection();
                //            con.ConnectionString = "Data source=essql1.walton.uark.edu;" +
                //                "Initial Catalog=PROJECTF2027;" +
                //                "USER ID=PROJECTF2027;Password=SH93ack$";

                //            con.Open();

                //            string password = txtPassword.Text;
                //            SqlCommand cmd = new SqlCommand("select User_ID,Password from UserID_Password where User_ID='" +
                //                txtUsername.Text + "'and Password='" + txtPassword.Text + "'", con);

                //            SqlDataAdapter da = new SqlDataAdapter(cmd);
                //            DataTable dt = new DataTable();
                //            da.Fill(dt);
                //            if (dt.Rows.Count > 0)
                //            {
                //                MessageBox.Show("Login sucess. Welcome to your account.");
                //                this.Hide();
                //                Home ho = new Home();
                //                ho.ShowDialog();
                //            }
                //            else
                //            {
                //                MessageBox.Show("Invalid login please check username and password");
                //            }
                //            con.Close();
                //        }

                //        /////////
                //        else if (radioEmployee.Checked == true)
                //        {
                //            //sql connection//
                //            SqlConnection con = new SqlConnection();
                //            con.ConnectionString = "Data source=essql1.walton.uark.edu;" +
                //                "Initial Catalog=PROJECTF2027;" +
                //                "USER ID=PROJECTF2027;Password=SH93ack$";
                //            con.Open();

                //            string password = txtPassword.Text;
                //            SqlCommand cmd = new SqlCommand("select User_ID,Password from UserID_Password where User_ID='" +
                //                txtUsername.Text + "'and Password='" + txtPassword.Text + "'", con);


                //            SqlDataAdapter da = new SqlDataAdapter(cmd);
                //            DataTable dt = new DataTable();
                //            da.Fill(dt);
                //            if (dt.Rows.Count > 0)
                //            {
                //                MessageBox.Show("Login sucess. Welcome to your account.");
                //                this.Hide();
                //                Home ho = new Home();
                //                ho.ShowDialog();
                //            }
                //            else
                //            {
                //                MessageBox.Show("Invalid login please check username and password");
                //            }
                //            con.Close();
                //        }

                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Error incorrect see this: " + ex);
                //    }
            
        }




            private void lblClickHere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Account ca = new Create_Account();
            ca.ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us for further assistance.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ho = new Home();
            ho.ShowDialog();
        }
    }
}
