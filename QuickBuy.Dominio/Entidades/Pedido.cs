using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
	public class Pedido : Entidade
	{
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public int UsuarioId { get; set; }
		public virtual Usuario Usuario { get; set; }

		public DateTime DataPrevisaoEntrega { get; set; }
		public string CEP { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string EnderecoCompleto { get; set; }
		public int NumeroEndereco { get; set; }

		public int FormaDePagamentoId { get; set; }
		public FormaPagamento FormaPagamento { get; set; }

		/// <summary>
		/// Um pedido deve conter 1:n itens
		/// </summary>
		public ICollection<ItemPedido> ItensPedido { get; set; }

		public override void Validate()
		{
			LimparMensagemDeValidacao();

			if (!ItensPedido.Any())
				AdicionarMensagemDeValidacao("O pedido deve conter ao menos um item");

			if (string.IsNullOrEmpty(CEP))
				AdicionarMensagemDeValidacao("O CEP deve estar preenchido");


		}
	}
}
