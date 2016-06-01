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
    public partial class Suspender : Form
    {
        public Suspender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suspender2 suspender2 = new Suspender2();
            suspender2.ShowDialog();
            this.Close();
        }
    }
}
