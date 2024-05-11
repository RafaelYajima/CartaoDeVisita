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
    public partial class cartaoVizita : Form
    {
        string nome, idade, telefone, email, endereco;
        public cartaoVizita(string lblNome, string lblIdade, string lblTelefone, string lblEmail, string lblEndereco)
        {
            InitializeComponent();
            nome = lblNome;
            idade = lblIdade;
            telefone = lblTelefone;
            email = lblEmail;
            endereco = lblEndereco;
        }

        private void cartaoVizita_Load(object sender, EventArgs e)
        {
            nomeCartao.Text = nome;
            idadeCartao.Text= idade;
            emailCartao.Text= email;
            telefoneCartao.Text= telefone;
            emailCartao.Text= email;
            enderecoCartao.Text= endereco;
        }
    }
}
