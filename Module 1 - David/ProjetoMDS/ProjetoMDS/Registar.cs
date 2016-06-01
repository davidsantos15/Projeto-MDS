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
    public partial class Registar : Form
    {
        private UtilizadoresContainer utilizadores;

        public Registar()
        {
            InitializeComponent();
        }

        private void Registar_Load(object sender, EventArgs e)
        {
            utilizadores = new UtilizadoresContainer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Altera a cor de fundo da text box caso esta não tenha nada escrito
            if (textBox1.Text.Length == 0)
            {
                textBox1.BackColor = Color.Red;
                return;
            }
            //Mete a cor de fundo da text box para a cor original caso tenha algo escrito
            textBox1.BackColor = Color.White;

            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.BackColor = Color.Red;
                return;
            }

            textBox1.BackColor = Color.White;

            if (textBox2.Text.Length == 0)
            {
                textBox2.BackColor = Color.Red;
                return;
            }

            textBox2.BackColor = Color.White;

            if (textBox3.Text.Length == 0)
            {
                textBox3.BackColor = Color.Red;
                return;
            }
            textBox3.BackColor = Color.White;

            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.BackColor = Color.Red;
                return;
            }

            textBox2.BackColor = Color.White;


            Utilizador novoUtilizador = new Utilizador();
            novoUtilizador.Nome = textBox1.Text;
            novoUtilizador.Sexo = comboBox1.Text;
            novoUtilizador.DatadeNasc = dateTimePicker1.Value;
            novoUtilizador.NIF = textBox2.Text;
            novoUtilizador.Morada = textBox3.Text;
            novoUtilizador.TipoConta = comboBox2.Text;

            utilizadores.UtilizadorSet.Add(novoUtilizador);

            utilizadores.SaveChanges();

            MessageBox.Show("Foi registado um novo utilizador com sucesso!", "Registado com Sucesso");
            this.Close();
        }

        private void Registar_Load_1(object sender, EventArgs e)
        {
            utilizadores = new UtilizadoresContainer();
        }
    }
}
