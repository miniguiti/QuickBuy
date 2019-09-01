using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
	class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
	{
		public void Configure(EntityTypeBuilder<FormaPagamento> builder)
		{
			builder.HasKey(fp => fp.Id);

			builder
				.Property(fp => fp.Nome)
				.IsRequired()
				.HasMaxLength(100);

			builder
				.Property(fp => fp.Descricao)
				.IsRequired()
				.HasMaxLength(500);
		}
	}
}
