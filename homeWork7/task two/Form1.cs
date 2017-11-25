using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_two
{
    public partial class frm : Form
    {

        public frm()
        {
            InitializeComponent();
        }

        int number = 0;
        int count = 0;
        int input = 0;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 100);
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            input = int.Parse(tb.Text);
            count++;
            lblCountNumber.Text = count.ToString();
            if (input == number)
            {
                MessageBox.Show($"Right! You have {count} try/tries)");
            }
            else MessageBox.Show("Wrong. . . Try again.");
        }
    }
}
