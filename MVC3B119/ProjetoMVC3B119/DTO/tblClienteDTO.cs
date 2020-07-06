using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ProjetoMVC3B119.DTO
{
	public class tblClienteDTO
	{
		private int id_cliente, tb_cliente;
		private string nome_cliente, sobrenome_cliente, cpf_cliente, email_cliente, senha_cliente, nome_mae;

		public int Id_cliente { get => id_cliente; set => id_cliente = value; }
		public int Tb_cliente { get => tb_cliente; set => tb_cliente = value; }
		public string Email_cliente { get => email_cliente; set => email_cliente = value; }
		public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }
		public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }

		public string Nome_mae
		{
			get => nome_mae;

			set
			{
				if (value != string.Empty) nome_mae = value;
				else throw new Exception("Informe o nome da sua mãe!");
			}
		}

		public string Cpf_cliente
		{
			get => cpf_cliente;

			set
			{
				if (value != string.Empty) cpf_cliente = value;
				else throw new Exception("O campo cpf é obrigatório!");
			}
		}

		public string Nome_cliente
		{
			get => nome_cliente;

			set
            {
				if (value != string.Empty) nome_cliente = value;
				else throw new Exception("O campo nome é obrigatório!");
			}
		}
	}
}