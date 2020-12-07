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
    public partial class Gear_and_Accessories : Form
    {
        public Gear_and_Accessories()
        {
            InitializeComponent();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop_All nk = new Shop_All();
            nk.ShowDialog();
        }

        private void newKayaksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            New_Kayaks nk = new New_Kayaks();
            nk.ShowDialog();
        }

        private void gearAndAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us au = new About_Us();
            au.ShowDialog();
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
