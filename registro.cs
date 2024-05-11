using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaoDeVisita
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = numNome.Text;
            string idade = numIdade.Text;
            string telefone = numTelefone.Text;
            string email = numEmail.Text;
            string endereco = numEndereco.Text;

            cartaoVizita cartao = new cartaoVizita(nome, idade, telefone, email, endereco);

            cartao.ShowDialog();
        }
    }
}
