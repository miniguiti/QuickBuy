using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
	public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
	{
		public void Configure(EntityTypeBuilder<ItemPedido> builder)
		{
			builder.HasKey(ip => ip.Id);

			//builder
			//	.Property(ip => ip.ProdutoId)

			builder
				.Property(ip => ip.Quantidade)
				.IsRequired();
		}
	}
}
