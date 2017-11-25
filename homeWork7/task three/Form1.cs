using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.lblCompanyName.Text = tbCompanyName.Text.ToString();
            f2.lblFIODirector.Text = tbFIODirector.Text.ToString();
            f2.lblFunction.Text = tbFunction.Text.ToString();
            f2.lblOwnFIO.Text = tbOwnFIO.Text.ToString();
            f2.lblStart.Text = tbStart.Text.ToString();
            f2.lblEnd.Text = tbEnd.Text.ToString();
            f2.lblName.Text = tbName.Text.ToString();
            f2.lblNow.Text = tbNow.Text.ToString();
            f2.Show();
        }
    }
}
