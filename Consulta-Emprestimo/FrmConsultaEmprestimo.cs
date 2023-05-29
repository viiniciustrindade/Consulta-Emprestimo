using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Emprestimo
{
    public partial class FrmConsultaEmprestimo : Form
    {
        public FrmConsultaEmprestimo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void AbrirSelecaoLocal()
        {
            SelecionarLocal local = new SelecionarLocal();
            local.ShowDialog();
            txtLocal.Text = local.nomeLocal;
        }

        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLocal();
        }
        public void AbrirSelecaoAutor()
        {
            SelecionarAutor autor = new SelecionarAutor();
            autor.ShowDialog();

            txtAutor.Text = autor.nomeAutor;
        }
        public void AbrirSelecaoSecao()
        {
            SelecionarSecao secao = new SelecionarSecao();
            secao.ShowDialog();
            txtSecao.Text = secao.nomeSecao;
        }
        private void btnCarregarAutor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoAutor();
        }

        private void btnCarregarSecao_Click(object sender, EventArgs e)
        {
            AbrirSelecaoSecao();
        }
        public void AbrirSelecaoLeitor()
        {
            SelecionarLeitor local = new SelecionarLeitor();
            local.ShowDialog();
            txtLeitor.Text = local.nomeLeitor;
        }
        private void btnCarregarLeitor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLeitor();
        }
    }
}
