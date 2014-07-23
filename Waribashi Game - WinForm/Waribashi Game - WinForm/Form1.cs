using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waribashi_Game___WinForm
{
    public partial class Form1 : Form
    {
       private int L1, L2, R1, R2;            
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            L1 = 1;
            L2 = 1;
            R1 = 1;
            R2 = 1;
            Player1Turn(L1, L2, R1, R2);
        }

        private void Player1Turn(int L1, int L2, int R1, int R2)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label9.Text = L1.ToString();
            label10.Text = R1.ToString();
            label11.Text = L2.ToString();
            label12.Text = R2.ToString();
        }

        private void Player2Turn(int L1, int L2, int R1, int R2)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            label9.Text = L1.ToString();
            label10.Text = R1.ToString();
            label11.Text = L2.ToString();
            label12.Text = R2.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            L2 = L2 + L1;
            Player2Turn(L1, L2, R1, R2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R2 = R2 + L1;
            Player2Turn(L1, L2, R1, R2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L2 = L2 + R1;
            Player2Turn(L1, L2, R1, R2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            R2 = R2 + R1;
            Player2Turn(L1, L2, R1, R2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            L1 = L1 + L2;
            Player1Turn(L1, L2, R1, R2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            R1 = R1 + L2;
            Player1Turn(L1, L2, R1, R2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            L1 = L1 + R2;
            Player1Turn(L1, L2, R1, R2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            R1 = R1 + R2;
            Player1Turn(L1, L2, R1, R2);
        }

    }
}
