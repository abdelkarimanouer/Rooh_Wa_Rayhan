using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روح_وريحان
{
    public partial class frmAzkar : Form
    {
        public frmAzkar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAzkaroSaba7 frm = new frmAzkaroSaba7();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAzkarMasa2 frm = new frmAzkarMasa2();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAzkarSleep frm = new frmAzkarSleep();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAzkarAfterSalawat frm = new frmAzkarAfterSalawat();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmKhatmL9or2an frm = new frmKhatmL9or2an();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmAzkarSalat frm = new frmAzkarSalat();
            frm.ShowDialog();
        }
    }
}
