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
    public partial class Company_Email : Form
    {
        public Company_Email()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtEmail.TextLength != 0) && (rtxtMessage.TextLength != 0))
                MessageBox.Show("Email successfully sent");
            else
                MessageBox.Show("Email address/message cannot be blank!");
        }
    }
}
