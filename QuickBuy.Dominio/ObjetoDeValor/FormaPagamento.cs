using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
	public class FormaPagamento
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }

		public bool EhBoleto
		{
			get { return Id == (int)TiposFormaPagamentoEnum.Boleto; }
		}
		public bool EhCartaoDeCredito
		{
			get { return Id == (int)TiposFormaPagamentoEnum.CartaoDeCredito; }
		}
		public bool EhDeposito
		{
			get { return Id == (int)TiposFormaPagamentoEnum.Deposito; }
		}
		public bool NaoFoiDefinido
		{
			get { return Id == (int)TiposFormaPagamentoEnum.NaoDefinido; }
		}
	}
}
