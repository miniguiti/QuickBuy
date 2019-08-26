using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
	public class Pedido
	{
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public int UsuarioId { get; set; }

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
	}
}
