using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGunaExemplo.Configuracao;
using Cadastro_Funcionario.Vizualizacao;

namespace Cadastro_Funcionario
{
    public partial class Form1 : Form
    {
        public static List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Inserir(Funcionario f)
        {


            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Funcionario (nome_fun, cpf_fun, rg_fun, estado_civil_fun, data_nascimento_fun, email_fun, telefone_fun, estado_fun, cidade_fun, endereco_fun, funcao_fun, salario_fun ) VALUES(@nome, @cpf, @rg, @estadoCivil, @dataNascimento, @email, @telefone, @estado, @cidade, @endereco, @funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", f.Nome);
                comando.Parameters.AddWithValue("@cpf", f.CPF);
                comando.Parameters.AddWithValue("@rg", f.RG);
                comando.Parameters.AddWithValue("@estadoCivil", f.EstadoCivil);
                comando.Parameters.AddWithValue("@datanascimento", f.DataNascimento);
                comando.Parameters.AddWithValue("@email", f.Email);
                comando.Parameters.AddWithValue("@telefone", f.Telefone);
                comando.Parameters.AddWithValue("@estado", f.Estado);
                comando.Parameters.AddWithValue("@cidade", f.Cidade);
                comando.Parameters.AddWithValue("@endereco", f.Endereco);
                comando.Parameters.AddWithValue("@funcao", f.Funcao);
                comando.Parameters.AddWithValue("@salario", f.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    Console.WriteLine("Funcionario Cadastrado com sucesso!");
                }

                LimparTextBoxs();
              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

      

        private void LimparTextBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        private bool ExistemTextBoxsVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    var text = control.Text.Replace(",", "").Replace(".", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
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
                string estadoCivil = estadoCivil_tx.Text;
                double salario = Convert.ToDouble(salario_tx.Text);
                string cpf = cpf_tx.Text;
                string rg = rg_tx.Text;
                DateTime datanascimento = Convert.ToDateTime(datanascimento_tx.Text);
                Funcionario f = new Funcionario(nome, funcao, estado, cidade, endereco, telefone, email, estadoCivil, cpf, rg, salario, datanascimento);
                
                MessageBox.Show("CPF:" + ValidarCpf.ValidaCPF(cpf).ToString());
                MessageBox.Show("Funcionário cadastrado com sucesso.");

                if (ExistemTextBoxsVazios())
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    Inserir(f);
                }

                Form2 consultarF = new Form2();
                this.Visible = false;
                consultarF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
