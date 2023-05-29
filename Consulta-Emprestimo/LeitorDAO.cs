using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Emprestimo
{
    public class LeitorDAO
    {
        private SqlConnection Connection { get; }
        public LeitorDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<LeitorModel> GetLeitores()
        {
            List<LeitorModel> leitores = new List<LeitorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT LEI.codLeitor, LEI.Leitor FROM mvtBibLeitor LEI");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(PopulateDr(dr));
                    }
                }
            }
            return leitores;
        }
        private LeitorModel PopulateDr(SqlDataReader dr)
        {
            string codLeitor = "";
            string nomeLeitor = "";
            if (DBNull.Value != dr["codLeitor"])
            {
                codLeitor = dr["codLeitor"] + "";
            }

            if (DBNull.Value != dr["Leitor"])
            {
                nomeLeitor = dr["Leitor"] + "";
            }
            return new LeitorModel()
            {
                codLeitor = codLeitor,
                nomeLeitor = nomeLeitor
            };
        }
    }
}
