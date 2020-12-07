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
    public partial class Check_Out : Form
    {
        public Check_Out()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Check_Out_Load(object sender, EventArgs e)
        {
            //string test = Shop_All.kayak1.ToString() ;

           // chboxTest.CheckState;

            if (((Shop_All)Owner).kayak1 == true)
            {
                chboxTest.Checked = true;
            }
        }
    }
}
