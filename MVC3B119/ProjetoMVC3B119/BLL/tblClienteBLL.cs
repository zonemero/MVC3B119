using ProjetoMVC3D240.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjetoMVC3B119.BLL
{
    public class tblClienteBLL
    {
        private DALMVC banco = new DALMVC();

        public bool ConsultarBeneficio(string nome, string cpf, string nome_mae)
        {
            string consulta = string.Format($@"SELECT * FROM tbl_cliente WHERE nome_cliente = '{nome}' AND cpf_cliente = '{cpf}' AND nome_mae = '{nome_mae}';");
            DataTable dt = banco.ExecutarConsulta(consulta);

            if (dt.Rows.Count == 1) return true;
            else return false;
        }
    }
}