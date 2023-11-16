using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nome = nome_tx.Text;
                string funcao = funcao_tx.Text;
                string estado = estado_tx.Text;
                string cidade = cidade_tx.Text;
                string endereco = endereco_tx.Text;
                string telefone = telefone_tx.Text;
                string email = email_tx.Text;
                string estadoCivil = estado_tx.Text;
                double salario = Convert.ToDouble(salario_tx.Text);
                string cpf = cpf_tx.Text;
                string rg = rg_tx.Text;
                DateTime datanascimento = Convert.ToDateTime(datanascimento_tx.Text);
                Funcionario f = new Funcionario(nome, funcao, estado, cidade, endereco, telefone, email, estadoCivil, cpf, rg, salario, datanascimento);

                MessageBox.Show(ValidarCpf.ValidaCPF(cpf).ToString());
                MessageBox.Show(f.Nome + " cadastrado.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
