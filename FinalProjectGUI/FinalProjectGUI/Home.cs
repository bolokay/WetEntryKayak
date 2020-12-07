using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlExample;

namespace FinalProjectGUI
{
    public partial class Home : Form
    {

        private SQLHelper helper = new SQLHelper();

        Shop_All sa = new Shop_All();
        New_Kayaks nk = new New_Kayaks();
        Gear_and_Accessories ga = new Gear_and_Accessories();
        About_Us ab = new About_Us();
        Contact_Us cu = new Contact_Us();
        Check_Out co = new Check_Out();
        Login lo = new Login();
        

        public Home()
        {
            InitializeComponent();
            Color myColor = Color.FromArgb(100, Color.Black);
            lblHeader.BackColor = myColor;
            lblShopAll.BackColor = myColor;
        }

        void navigateAway()
        {
            backgroundGB.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sa.Show();
            sa.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sa.Show();
            sa.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void newKayaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nk.Show();
            nk.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void gearAndAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ga.Show();
            ga.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ab.Show();
            ab.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cu.Show();
            cu.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            co.Show();
            co.WindowState = FormWindowState.Maximized;
            navigateAway();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lo.Show();
            lo.WindowState = FormWindowState.Maximized;
            navigateAway();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = new MenuStrip();



            sa.MdiParent = this;
            nk.MdiParent = this;
            ga.MdiParent = this;
            ab.MdiParent = this;
            cu.MdiParent = this;
            co.MdiParent = this;
            lo.MdiParent = this;
            
        }

        private void LblShopAll_Click(object sender, EventArgs e)
        {
            sa.Show();
            sa.WindowState = FormWindowState.Maximized;
            navigateAway();
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


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
