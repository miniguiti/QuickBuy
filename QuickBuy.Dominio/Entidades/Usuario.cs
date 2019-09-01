using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
	public class Usuario : Entidade
	{
		public int Id { get; set; }
		public string Senha { get; set; }
		public string Email { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }

		/// <summary>
		/// Um usuário pode ter 0:n pedidos
		/// </summary>
		public virtual ICollection<Pedido> Pedidos { get; set; }

		public override void Validate()
		{
			LimparMensagemDeValidacao();

			if (string.IsNullOrEmpty(Email))
				AdicionarMensagemDeValidacao("O Email não foi informado");

			if (string.IsNullOrEmpty(Senha))
				AdicionarMensagemDeValidacao("A senha não informada");

		}
	}
}
