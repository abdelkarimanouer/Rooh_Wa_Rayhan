using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using روح_وريحان.Properties;

namespace روح_وريحان
{
    public partial class frmQuran : Form
    {
        public frmQuran()
        {
            InitializeComponent();
        }

        void TurnOffSound(Button btn, SoundPlayer Sp)
        {
            if (btn.Tag.ToString() == "Play")
            {
                Sp.Play();
                btn.BackgroundImage = Resources.pngegg;
                btn.Tag = "Stop";
            }
            else
            {
                Sp.Stop();
                btn.BackgroundImage = Resources.play;
                btn.Tag = "Play";
            }
        }

        private void button208_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("قريش.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button113_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الفاتحة.wav");

            TurnOffSound((Button)sender, Sp);

        }

        private void button206_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الماعون.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button204_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الكوثر.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button226_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الكافرون.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button224_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("النصر.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button222_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("المسد.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button220_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الاخلاص.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button218_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الفلق.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button216_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الناس.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button210_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الفيل.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button212_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("الهمزة.wav");

            TurnOffSound((Button)sender, Sp);
        }

        private void button214_Click(object sender, EventArgs e)
        {
            SoundPlayer Sp = new SoundPlayer("العصر.wav");

            TurnOffSound((Button)sender, Sp);
        }
    
    }
}
