using ProjetoMVC3D240.BLL;
using ProjetoMVC3D240.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVC3B119.UI
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Label msgerro = FindControl("msgerro") as Label;

            try
            {
                msgerro.Visible = false;
                tblClienteDTO clienteDTO = new tblClienteDTO();
                clienteDTO.Cpf_cliente = txtCpf3B119.Text;
                clienteDTO.Nome_cliente = txtNome3B119.Text;
                clienteDTO.Nome_mae = txtNomeMae3B119.Text;

                tblClienteBLL clienteBLL = new tblClienteBLL();
                if (clienteBLL.ConsultarBeneficio(clienteDTO.Nome_cliente, clienteDTO.Cpf_cliente, clienteDTO.Nome_mae))
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                    msgerro.ForeColor = System.Drawing.Color.DarkOliveGreen;
                }
                else
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                    msgerro.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception exception)
            {
                msgerro.Visible = true;
                msgerro.Text = exception.Message;
                msgerro.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}