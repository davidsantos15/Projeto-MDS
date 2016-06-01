using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "davidsantos" && textBox2.Text == "12345") || (textBox1.Text == "ruirijo" && textBox2.Text == "mds123"))
            {
                this.Hide();
                MenuPrincipal meuprinc = new MenuPrincipal();
                meuprinc.ShowDialog();
                this.Close();
            }else
                MessageBox.Show("Os dados introduzidos estão incorretos", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
