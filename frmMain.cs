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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        void LoadForm(object frmSender)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }

            Form myForm = frmSender as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();

            

        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            LoadForm(new frmHome());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new frmHome());
        }

        private void btnMawaqitSalat_Click(object sender, EventArgs e)
        {
            LoadForm(new frmMawaqitSalat());
        }

        private void btnAzkar_Click(object sender, EventArgs e)
        {
            LoadForm(new frmAzkar());
        }

        private void btnTasbih_Click(object sender, EventArgs e)
        {
            LoadForm(new frmTasbi7());
        }

        private void btnQuran_Click(object sender, EventArgs e)
        {
            LoadForm(new frmQuran());
        }
    }
}
