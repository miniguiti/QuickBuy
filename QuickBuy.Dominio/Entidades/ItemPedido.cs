using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
	public class ItemPedido : Entidade
	{
		public int Id { get; set; }
		public int ProdutoId { get; set; }
		public int Quantidade { get; set; }

		public override void Validate()
		{
			LimparMensagemDeValidacao();

			if (ProdutoId == 0)
				AdicionarMensagemDeValidacao("Referência do produto não encontrada.");

			if (Quantidade == 0)
				AdicionarMensagemDeValidacao("Quantidade do produto não foi informada");

		}
	}
}
