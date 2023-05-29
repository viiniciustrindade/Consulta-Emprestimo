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
    public partial class SelecionarLeitor : Form
    {
        public SelecionarLeitor()
        {
            InitializeComponent();
        }
        public string nomeLeitor { get; private set; }
        public void FecharFormulario()
        {
            nomeLeitor = txtNomeLeitor2.Text;

            this.Close();
        }
        private void SelecionarLeitor_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid2.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LeitorDAO dao = new LeitorDAO(connection);
                List<LeitorModel> leitores = dao.GetLeitores();
                foreach (LeitorModel leitor in leitores)
                {
                    DataGridViewRow row = dadosGrid2.Rows[dadosGrid2.Rows.Add()];
                    row.Cells[colCodLeitor.Index].Value = leitor.codLeitor;
                    row.Cells[colNomeLeitor.Index].Value = leitor.nomeLeitor;
                }
            }
        }

        private void txtcodLeitor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtcodLeitor.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid2.Rows)
            {
                string nomeAutor = row.Cells[colCodLeitor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtNomeLeitor2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLeitor2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid2.Rows)
            {
                string nomeAutor = row.Cells[colNomeLeitor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodLeitor.Text = dadosGrid2.Rows[e.RowIndex].Cells[colCodLeitor.Index].Value + "";
                txtNomeLeitor2.Text = dadosGrid2.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";

                FecharFormulario();

            }
        }
    }
}
