using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attfisica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            int peso = Convert.ToInt32(txtPeso.Text);
            int tempo = Convert.ToInt32(txtTempo.Text);
            int resposta = peso * tempo;
            txtKcalResultado.Text = resposta.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
