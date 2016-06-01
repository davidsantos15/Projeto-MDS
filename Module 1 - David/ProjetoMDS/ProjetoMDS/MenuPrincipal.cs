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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            registar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar atualizar = new Atualizar();
            atualizar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suspender suspender = new Suspender();
            suspender.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
