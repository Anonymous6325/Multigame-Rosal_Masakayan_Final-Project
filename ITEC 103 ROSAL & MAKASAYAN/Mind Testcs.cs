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
    public partial class Mind_Testcs : Form
    {
        public Mind_Testcs()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Easy easyForm = new Easy();

             
            easyForm.Show();

             
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Moderate moderateForm = new Moderate();

             
            moderateForm.Show();

             
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Difficult difficultForm = new Difficult();

             
            difficultForm.Show();

             
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
             
            Sub_Menu subMenu = new Sub_Menu();

             
            subMenu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
