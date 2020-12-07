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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your account has been successfully created!");
            this.Hide();
            Home ho = new Home();
            ho.ShowDialog();
        }
    }
}
