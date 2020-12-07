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
    
    public partial class Shop_All : Form
    {
        public bool kayak1 = false;
        public bool kayak2 = false;
        public bool kayak3 = false;
        public bool kayak4 = false;
        public bool kayak5 = false;
        public bool kayak6 = false;
        public bool kayak7 = false;
        public bool kayak8 = false;


        public Shop_All()
        {
            InitializeComponent();
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Check_Out co = new Check_Out();
            co.StartPosition = FormStartPosition.CenterScreen;
            co.ShowDialog(this);
        }

        private void ChkboxKayak1_CheckedChanged(object sender, EventArgs e)
        {
            kayak1 = !kayak1;
        }

        private void ChkboxKayak2_CheckedChanged(object sender, EventArgs e)
        {
            kayak2 = !kayak2;
        }

        private void ChkboxKayak3_CheckedChanged(object sender, EventArgs e)
        {
            kayak3 = !kayak3;
        }

        private void ChkboxKayak4_CheckedChanged(object sender, EventArgs e)
        {
            kayak4 = !kayak4;
        }

        private void ChkboxKayak5_CheckedChanged(object sender, EventArgs e)
        {
            kayak5 = !kayak5;
        }

        private void ChkboxKayak6_CheckedChanged(object sender, EventArgs e)
        {
            kayak6 = !kayak6;
        }

        private void ChkboxKayak7_CheckedChanged(object sender, EventArgs e)
        {
            kayak7 = !kayak7;
        }

        private void ChkboxKayak8_CheckedChanged(object sender, EventArgs e)
        {
            kayak8 = !kayak8;
        }
    }
}
