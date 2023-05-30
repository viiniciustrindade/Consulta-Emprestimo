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
            string sql = "SELECT ITE.codItem, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.secao, ITE.tipoStatus " +
            "FROM mvtBibItemAcervo ITE " +
            "WHERE 1 = 1";

            if (!string.IsNullOrEmpty(txtNomeItem.Text.Trim()))
            {
                sql += $" AND ITE.nome LIKE '%{txtNomeItem.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtLocal.Text.Trim()))
            {
                sql += $" AND ITE.nomeLocal LIKE '%{txtLocal.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(txtAutor.Text.Trim()))
            {
                sql += $" AND ITE.nomeAutor LIKE '%{txtAutor.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(cbxTipoItem.Text.Trim()))
            {
                sql += $" AND ITE.tipoItem LIKE '%{cbxTipoItem.Text.Trim()}%'";
            }
            /*if (!string.IsNullOrEmpty(txtColecao.Text.Trim()))
            {
                sql += $" AND ITE.nomeColecao LIKE '%{txtColecao.Text.Trim()}%'";
            }*/
            if (!string.IsNullOrEmpty(txtSecao.Text.Trim()))
            {
                sql += $" AND ITE.secao LIKE '%{txtSecao.Text.Trim()}%'";
            }
            if (!string.IsNullOrEmpty(cbxSituacao.Text.Trim()))
            {
                sql += $" AND ITE.tipoStatus LIKE '%{cbxSituacao.Text.Trim()}%'";
            }



            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                using(SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string sql2 = "SELECT TOP 1 nomeLeitor, dataReserva, prazoReserva FROM mvtBibReserva WHERE nomeItem = @nomeItem AND tipoItem = @tipoItem AND situacao = @situacao";
                    command.CommandText = sql2.ToString();
                    command.Parameters.Add(new SqlParameter("@tipoItem", cbxTipoItem.Text));
                    command.Parameters.Add(new SqlParameter("@nomeItem", txtNomeItem.Text));
                    command.Parameters.Add(new SqlParameter("@situacao", txtNomeItem.Text));


                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dadosGrid);
                        row.Cells[colNomeItem.Index].Value = reader["nome"].ToString();
                        row.Cells[colLeitor.Index].Value = reader["nomeLeitor"].ToString();
                        row.Cells[colLocal.Index].Value = reader["nomeLocal"].ToString();
                        row.Cells[colEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colSituacao.Index].Value = reader["tipoStatus"].ToString();
                        row.Cells[colTipoItem.Index].Value = reader["tipoItem"].ToString();
                        row.Cells[colSecao.Index].Value = reader["secao"].ToString();

                        dadosGrid.Rows.Add(row);
                    }
                }
            }
        }
    }
}

