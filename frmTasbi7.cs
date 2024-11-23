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
    public partial class frmTasbi7 : Form
    {

        private byte CounterSobhanallah = 0;
        private byte CounterHamdollah = 0;
        private byte CounterLaIlaha = 0;
        private byte CounterAllahoAkbar = 0;
        private byte CounterRbiIghfirli = 0;
        private byte CounterAstaghfiroLlah = 0;
        private byte CounterLa7awlawala9owa = 0;
        private byte CounterSalimWbarik = 0;

        public frmTasbi7()
        {
            InitializeComponent();
        }



        private void btnCounterSobhanallah_Click(object sender, EventArgs e)
        {
            CounterSobhanallah++;
            btnCounterSobhanallah.Text = CounterSobhanallah.ToString();
        }

        private void btnCounterHamdollah_Click(object sender, EventArgs e)
        {
            CounterHamdollah++;
            btnCounterHamdollah.Text = CounterHamdollah.ToString();
        }

        private void btnCounterLaIlaha_Click(object sender, EventArgs e)
        {
            CounterLaIlaha++;
            btnCounterLaIlaha.Text = CounterLaIlaha.ToString();
        }

        private void btnCounterAllahoAkbar_Click(object sender, EventArgs e)
        {
            CounterAllahoAkbar++;
            btnCounterAllahoAkbar.Text = CounterAllahoAkbar.ToString();
        }

        private void btnCounterRbiIghfirli_Click(object sender, EventArgs e)
        {
            CounterRbiIghfirli++;
            btnCounterRbiIghfirli.Text = CounterRbiIghfirli.ToString();
        }

        private void btnCounterAstaghfiroLlah_Click(object sender, EventArgs e)
        {
            CounterAstaghfiroLlah++;
            btnCounterAstaghfiroLlah.Text = CounterAstaghfiroLlah.ToString();
        }

        private void btnCounterLa7awlawala9owa_Click(object sender, EventArgs e)
        {
            CounterLa7awlawala9owa++;
            btnCounterLa7awlawala9owa.Text = CounterLa7awlawala9owa.ToString();
        }

        private void btnCounterSalimWbarik_Click(object sender, EventArgs e)
        {
            CounterSalimWbarik++;
            btnCounterSalimWbarik.Text = CounterSalimWbarik.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CounterSobhanallah = 0;
            btnCounterSobhanallah.Text = CounterSobhanallah.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CounterHamdollah = 0;
            btnCounterHamdollah.Text = CounterHamdollah.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CounterLaIlaha = 0;
            btnCounterLaIlaha.Text = CounterLaIlaha.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CounterAllahoAkbar = 0;
            btnCounterAllahoAkbar.Text = CounterAllahoAkbar.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            CounterRbiIghfirli = 0;
            btnCounterRbiIghfirli.Text = CounterRbiIghfirli.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            CounterAstaghfiroLlah = 0;
            btnCounterAstaghfiroLlah.Text = CounterAstaghfiroLlah.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            CounterLa7awlawala9owa = 0;
            btnCounterLa7awlawala9owa.Text = CounterLa7awlawala9owa.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            CounterSalimWbarik = 0;
            btnCounterSalimWbarik.Text = CounterSalimWbarik.ToString();
        }
    }




}
