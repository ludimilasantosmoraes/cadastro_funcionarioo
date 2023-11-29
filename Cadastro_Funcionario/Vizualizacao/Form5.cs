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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void CadastrarEmpresa_Click(object sender, EventArgs e)
        {
            Form3 empresa = new Form3();
            this.Visible = false;
            empresa.ShowDialog();
        }

        private void CadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Form1 funcionario= new Form1();
            this.Visible = false;
            funcionario.ShowDialog();
        }

        private void ConsultarEmpresa_Click(object sender, EventArgs e)
        {
            Form4 consultaE = new Form4();
            this.Visible = false;
            consultaE.ShowDialog();
        }

        private void ConsultarFuncionario_Click(object sender, EventArgs e)
        {
            Form2 consultaF = new Form2();
            this.Visible = false;
            consultaF.ShowDialog();
        }
    }
}
