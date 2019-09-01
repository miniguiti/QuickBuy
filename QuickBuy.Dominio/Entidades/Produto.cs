using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
	public class Produto : Entidade
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }

		public override void Validate()
		{
			if (string.IsNullOrEmpty(Nome))
				AdicionarMensagemDeValidacao("Nome do produto não informado.");
			if (string.IsNullOrEmpty(Descricao))
				AdicionarMensagemDeValidacao("Descrição do profuto não informada.");
			if (Preco == 0)
				AdicionarMensagemDeValidacao("O preço do produto não foi informado.");
		}
	}
}
