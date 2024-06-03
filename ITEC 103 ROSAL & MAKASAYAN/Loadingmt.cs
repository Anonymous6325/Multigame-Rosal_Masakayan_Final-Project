using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_103_ROSAL___MAKASAYAN
{
    public partial class Loadingmt : Form
    {
        public Loadingmt()
        {
            InitializeComponent();
        }

        private void Loadingmt_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label1.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();

                 
                Mind_Testcs game1l = new Mind_Testcs();

                 
                game1l.Show();
                this.Hide();
            }
        }
    }
}
