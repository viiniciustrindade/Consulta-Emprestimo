using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public void AbrirSelecaoLocal()
        {
            SelecionarLocal local = new SelecionarLocal();
            local.ShowDialog();
            txtLocal.Text = local.nomeLocal;
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
        public void AbrirSelecaoLeitor()
        {
            SelecionarLeitor local = new SelecionarLeitor();
            local.ShowDialog();
            txtLeitor.Text = local.nomeLeitor;
        }
        private void btnCarregarLocal_Click_1(object sender, EventArgs e)
        {
            AbrirSelecaoLocal();
        }

        private void btnCarregarAutor_Click_1(object sender, EventArgs e)
        {
            AbrirSelecaoAutor();
        }

        private void btnCarregarLeitor_Click_1(object sender, EventArgs e)
        {
            AbrirSelecaoLeitor();
        }

        private void btnCarregarSecao_Click_1(object sender, EventArgs e)
        {
            AbrirSelecaoSecao();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

                StringBuilder sql2 = new StringBuilder();
                sql2.AppendLine("SELECT ITE.nome, RES.nomeLeitor, ITE.tipoItem, RES.situacao, ITE.nomeLocal, ITE.nomeAutor, ITE.secao, ITE.nomeEditora, ITE.tipoStatus, RES.dataReserva, RES.prazoReserva");
                sql2.AppendLine("FROM mvtBibReserva RES INNER JOIN mvtBibItemAcervo ITE ON RES.codItem = ITE.codItem");
                sql2.AppendLine("WHERE 1=1");
                if (!string.IsNullOrEmpty(txtNomeItem.Text))
                {
                    sql2.AppendLine($"AND ITE.nome LIKE '%{txtNomeItem.Text}%'");
                }
                if (!string.IsNullOrEmpty(cbxSituacao.Text))
                {
                    sql2.AppendLine($"AND RES.situacao LIKE '%{cbxSituacao.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtLeitor.Text))
                {
                    sql2.AppendLine($"AND RES.nomeLeitor LIKE '%{txtLeitor.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtLocal.Text))
                {
                    sql2.AppendLine($"AND ITE.nomeLocal LIKE '%{txtLocal.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtSecao.Text))
                {
                    sql2.AppendLine($"AND ITE.secao LIKE '%{txtSecao.Text}%'");
                }
                if (!string.IsNullOrEmpty(cbxTipoItem.Text))
                {
                    sql2.AppendLine($"AND ITE.tipoItem LIKE '%{cbxTipoItem.Text}%'");
                }
                if (dtpDataInicio.Value != null)
                {
                    sql2.AppendLine($"AND RES.dataReserva >= '{dtpDataInicio.Value.Date}'");
                }
                if (dtpDataFim.Value != null)
                {
                    sql2.AppendLine($"AND RES.prazoReserva <= '{dtpDataFim.Value.Date}'");
                }
            using (SqlConnection connection = DaoConnection.GetConexao())
            {

                using (SqlCommand command = new SqlCommand(sql2.ToString(), connection))
                {

                    SqlDataReader reader = command.ExecuteReader();
                    dadosGrid.Rows.Clear();
                    while (reader.Read())
                    {
                        DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                        row.Cells[colNomeItem.Index].Value = reader["nome"].ToString();
                        row.Cells[colLeitor.Index].Value = reader["nomeLeitor"].ToString();
                        row.Cells[colLocal.Index].Value = reader["nomeLocal"].ToString();
                        row.Cells[colEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colSituacao.Index].Value = reader["situacao"].ToString();
                        row.Cells[colDataInicio.Index].Value = reader["dataReserva"].ToString().Substring(0, 10);
                        row.Cells[colDataFim.Index].Value = reader["prazoReserva"].ToString().Substring(0, 10);
                        row.Cells[colTipoItem.Index].Value = reader["tipoItem"].ToString();
                        row.Cells[colSecao.Index].Value = reader["secao"].ToString();
                    }
                }
            }
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            txtNomeItem.Text = "";
            cbxTipoItem.SelectedIndex = -1;
            txtLocal.Text = "";
            txtAutor.Text = "";
            txtLeitor.Text = "";
            txtSecao.Text = "";
            cbxSituacao.SelectedIndex = -1;
            dadosGrid.Rows.Clear();
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
            cbxTipoItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
            cbxSituacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSituacao.Index].Value + "";
            txtLeitor.Text = dadosGrid.Rows[e.RowIndex].Cells[colLeitor.Index].Value + "";
            dtpDataInicio.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataInicio.Index].Value + "";
            dtpDataFim.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataFim.Index].Value + "";
            txtLocal.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocal.Index].Value + "";
            txtSecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
            txtAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[colAutor.Index].Value + "";
        }
    }
}

