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
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            Company_Email ce = new Company_Email();
            ce.StartPosition = FormStartPosition.CenterScreen;
            ce.Show();
        }
    }
}
