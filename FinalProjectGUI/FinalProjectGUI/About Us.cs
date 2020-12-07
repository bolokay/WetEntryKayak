using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUI
{
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop_All nk = new Shop_All();
            nk.ShowDialog();
        }

        private void newKayaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Kayaks nk = new New_Kayaks();
            nk.ShowDialog();
        }

        private void gearAndAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gear_and_Accessories gaa = new Gear_and_Accessories();
            gaa.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Us cu = new Contact_Us();
            cu.ShowDialog();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Out co = new Check_Out();
            co.ShowDialog();
        }
    }
}
