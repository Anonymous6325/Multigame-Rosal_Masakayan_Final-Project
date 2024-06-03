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
    public partial class Sub_Menu : Form
    {
        public Sub_Menu()
        {
            InitializeComponent();
        }

        private void Sub_Menu_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();

            menuForm.Show();
            this.Close();
        }
    }
}
