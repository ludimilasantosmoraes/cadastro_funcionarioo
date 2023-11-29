using AppGunaExemplo.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Funcionario.Vizualizacao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1.listaFuncionarios.Clear();

            Consultar();
            dataGridViewFuncionario.DataSource = Form1.listaFuncionarios;

        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    var f = new Funcionario();

                    f.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    f.CPF = DAOHelper.GetString(leitor, "cpf_fun");
                    f.RG = DAOHelper.GetString(leitor, "rg_fun");
                    f.EstadoCivil = DAOHelper.GetString(leitor, "estado_civil_fun");
                    f.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    f.Cidade = DAOHelper.GetString(leitor, "cidade_fun");
                    f.Endereco = DAOHelper.GetString(leitor, "endereco_fun");
                    f.Email = DAOHelper.GetString(leitor, "email_fun");
                    f.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    f.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    f.DataNascimento = DAOHelper.GetDateTime(leitor, "data_nascimento_fun");
                    f.Salario = DAOHelper.GetDouble(leitor, "salario_fun");

                    var posicaoColuna = leitor.GetOrdinal("nome_fun");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {
                        f.Nome = leitor.GetString("nome_fun");
                        f.CPF = leitor.GetString("cpf_fun");
                        f.RG = leitor.GetString("rg_fun");
                        f.EstadoCivil = leitor.GetString("estado_civil_fun");
                        f.Estado = leitor.GetString("estado_fun");
                        f.Cidade = leitor.GetString("cidade_fun");
                        f.Endereco = leitor.GetString("endereco_fun");
                        f.Email = leitor.GetString("email_fun");
                        f.Telefone = leitor.GetString("telefone_fun");
                        f.Funcao = leitor.GetString("funcao_fun");
                        f.DataNascimento = leitor.GetDateTime("data_nascimento_fun");
                        f.Salario = leitor.GetDouble("salario_fun");

                    }

                    Form1.listaFuncionarios.Add(f);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 funcionario = new Form1();
            this.Visible = false;
            funcionario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 menu = new Form5();
            this.Visible = false;
            menu.ShowDialog();
        }
    }
}
