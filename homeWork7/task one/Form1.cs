using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count;
        public int Number;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            count++;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            count++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            count++;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Number = rnd.Next(0, 50);
            MessageBox.Show($"Your number is {Number}. Good luck, my friend.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
