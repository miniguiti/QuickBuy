using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Contratos;

namespace QuickBuy.Repositorio.Repositorio
{
	public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class 
	{
		public BaseRepositorio()
		{
				
		}
		public void Adicionar(Tentity entity)
		{
			throw new NotImplementedException();
		}

		public void Atualizar(Tentity entity)
		{
			throw new NotImplementedException();
		}
		public Tentity ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Tentity> ObterTodos()
		{
			throw new NotImplementedException();
		}

		public void Remover(Tentity entity)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}

