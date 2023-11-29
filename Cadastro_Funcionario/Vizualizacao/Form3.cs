using Cadastro_Funcionario.Vizualizacao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppGunaExemplo.Configuracao;

namespace Cadastro_Empresa
{
    public partial class Form3 : Form
    {
        public static List<Empresa> listaEmpresa = new List<Empresa>();
        public Form3()
        {
            InitializeComponent();
        }
        private void Inserir(Empresa em)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Empresa (razao_social_emp, nome_fantasia_emp, cnpj_emp, nome_proprietario_emp, cpf_emp, telefone_emp, estado_emp, cidade_emp, endereco_emp, situacao_cadastral_emp, natureza_juridica_emp, data_inicial_emp, tipo_emp, regime_tributario_emp, porte_empresa_emp, capital_social_emp ) VALUES (@razaoSocial, @nomeFantasia, @cnpj, @nomeP, @cpf, @telefone, @estado, @cidade, @endereco, @situacaoCadastral, @naturezaJuridica, @dataInicial, @tipo, @regimeTributario, @porteEmpresa, @capitalSocial)");

                comando.Parameters.AddWithValue("@razaoSocial", em.RazaoSocial);
                comando.Parameters.AddWithValue("@nomeFantasia", em.NomeFantasia);
                comando.Parameters.AddWithValue("@cnpj", em.CNPJ);
                comando.Parameters.AddWithValue("@nomeP", em.NomeP);
                comando.Parameters.AddWithValue("@cpf", em.CPF);
                comando.Parameters.AddWithValue("@telefone", em.Telefone);
                comando.Parameters.AddWithValue("@estado", em.Estado);
                comando.Parameters.AddWithValue("@cidade", em.Cidade);
                comando.Parameters.AddWithValue("@endereco", em.Endereco);
                comando.Parameters.AddWithValue("@naturezaJuridica", em.NaturezaJuridica);
                comando.Parameters.AddWithValue("@situacaoCadastral", em.SituacaoCadastral);
                comando.Parameters.AddWithValue("@dataInicial", em.DataInicial);
                comando.Parameters.AddWithValue("@tipo", em.Tipo);
                comando.Parameters.AddWithValue("@regimeTributario", em.RegimeTributario);
                comando.Parameters.AddWithValue("@porteEmpresa", em.PorteEmpresa);
                comando.Parameters.AddWithValue("@capitalSocial", em.CapitalSocial);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa Cadastrado com sucesso!");
                }

                LimparTextBoxs();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string razaoSocial = razaoSocial_tx.Text;
                string nomeFantasia = nomeFantasia_tx.Text;
                string cnpj = cnpj_tx.Text;
                string cpf = cpf_tx.Text;
                string nomeP = nomeP_tx.Text;
                string telefone = telefone_tx.Text;
                string situacaoCadastral = situacaoCadastral_tx.Text;
                string naturezaJuridica = naturezaJuridica_tx.Text;
                double capitalSocial = Convert.ToDouble(capitalSocial_tx.Text);
                string estado = estado_tx.Text;
                string cidade = cidade_tx.Text;
                string endereco = endereco_tx.Text;
                DateTime dataInicial = Convert.ToDateTime(dataInicio_tx.Text);
                string porteEmpresa = "";

                if (pequeno_tx.Checked)
                {
                    porteEmpresa = pequeno_tx.Text;
                }
                else if (medio_tx.Checked)
                {
                    porteEmpresa = medio_tx.Text;
                }
                if (grande_tx.Checked)
                {
                    porteEmpresa = grande_tx.Text;
                }

                string tipo = "";
                if (filial_tx.Checked)
                {
                    tipo = filial_tx.Text;
                }
                else if (matriz_tx.Checked)
                {
                    tipo = matriz_tx.Text;
                }

                string regimeTributario = "";
                if (simplesN_tx.Checked)
                {
                    regimeTributario = simplesN_tx.Text;
                }
                else if (lucroP_tx.Checked)
                {
                    regimeTributario = lucroP_tx.Text;
                }
                if (real_tx.Checked)
                {
                    regimeTributario = real_tx.Text;
                }
                Empresa em = new Empresa(razaoSocial, nomeFantasia, nomeP, cnpj, cpf, estado, cidade, endereco, telefone, situacaoCadastral, naturezaJuridica, capitalSocial, dataInicial, regimeTributario, tipo, porteEmpresa);
                MessageBox.Show("CPF: " + ValidarCpf.ValidaCPF(cpf).ToString());
                MessageBox.Show("CNPJ:" + ValidaCNPJ.IsCnpj(cnpj).ToString());
                Inserir(em);

             

                if (ExistemTextBoxsVazios())
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    Form4 consultarE = new Form4();
                    this.Visible = false;
                    consultarE.ShowDialog();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void real_tx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
