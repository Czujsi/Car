using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car1
{
    public partial class Form1 : Form
    {
        int speedIncrease;
        int speedDecrease;
        int counter;
        public Form1()
        {
            InitializeComponent();
            
            speedDecrease = 0;
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(speedIncrease >= 25)
            {
                speedIncrease = 25;
            }
            else
            {
                speedIncrease++;
            }
            label1.Text = speedIncrease.ToString();
            

        }
        void Acceleration()
        {
            speedIncrease = 0;
            timer1.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Acceleration();
            }
        }
    }
}
