using AppGunaExemplo.Configuracao;
using Cadastro_Empresa;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Form3.listaEmpresa.Clear();

            Consultar();

            dataGridView1.DataSource = Form3.listaEmpresa;
            
        }
        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {

                    var em = new Empresa();

                    em.RazaoSocial = DAOHelper.GetString(leitor, "razao_social_emp");
                    em.NaturezaJuridica = DAOHelper.GetString(leitor, "natureza_juridica_emp");
                    em.NomeFantasia = DAOHelper.GetString(leitor, "nome_fantasia_emp");
                    em.NomeP = DAOHelper.GetString(leitor, "nome_proprietario_emp");
                    em.Estado = DAOHelper.GetString(leitor, "estado_emp");
                    em.Cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    em.Endereco = DAOHelper.GetString(leitor, "endereco_emp");
                    em.CNPJ = DAOHelper.GetString(leitor, "cnpj_emp");
                    em.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    em.CPF = DAOHelper.GetString(leitor, "cpf_emp");
                    em.DataInicial = DAOHelper.GetDateTime(leitor, "data_inicial_emp");
                    em.CapitalSocial = DAOHelper.GetDouble(leitor, "capital_social_emp");
                    em.RegimeTributario = DAOHelper.GetString(leitor, "regime_tributario_emp");
                    em.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    em.PorteEmpresa = DAOHelper.GetString(leitor, "porte_empresa_emp");
                    em.SituacaoCadastral = DAOHelper.GetString(leitor, "situacao_cadastral_emp");

                    var posicaoColuna = leitor.GetOrdinal("razao_social_emp");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {

                        em.RazaoSocial = leitor.GetString("razao_social_emp");
                        em.NaturezaJuridica = leitor.GetString("natureza_juridica_emp");
                        em.NomeFantasia = leitor.GetString("nome_fantasia_emp");
                        em.NomeP = leitor.GetString("nome_proprietario_emp");
                        em.Estado = leitor.GetString("estado_emp");
                        em.Cidade = leitor.GetString("cidade_emp");
                        em.Endereco = leitor.GetString("endereco_emp");
                        em.CNPJ = leitor.GetString("cnpj_emp");
                        em.Telefone = leitor.GetString("telefone_emp");
                        em.CPF = leitor.GetString("cpf_emp");
                        em.DataInicial = leitor.GetDateTime("data_inicial_emp");
                        em.CapitalSocial = leitor.GetDouble("capital_social_emp");
                        em.RegimeTributario = leitor.GetString("regime_tributario_emp");
                        em.Tipo = leitor.GetString("tipo_emp");
                        em.PorteEmpresa = leitor.GetString("porte_empresa_emp");
                        em.SituacaoCadastral = leitor.GetString("situacao_cadastral_emp");
                    }

                    Form3.listaEmpresa.Add(em);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 empresa = new Form3();
            this.Visible = false;
            empresa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 menu = new Form5();

            this.Visible = false;
            menu.ShowDialog();
        }
    }
}
