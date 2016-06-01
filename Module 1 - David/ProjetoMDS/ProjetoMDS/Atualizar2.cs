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
    public partial class Atualizar2 : Form
    {
        public Atualizar2()
        {
            InitializeComponent();
            string user = "David Santos NIF: 213456987";
            ListaDeUtilizadores.Items.Add(user);
            ListaDeUtilizadores.SelectedItem = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar3 atualizar3 = new Atualizar3();
            atualizar3.ShowDialog();
            this.Close();
        }
    }
}
