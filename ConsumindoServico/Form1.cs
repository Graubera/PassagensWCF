using ConsumindoServico.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.Nome = nome;
                clienteCadastro.cpf = cpf;
                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception)
            {
                // salvaria um log
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.buscar(nome);
                txtCpf.Text = resultado.cpf;
            }
            catch (Exception)
            {
                // salva um log
            }
        }
    }
}
