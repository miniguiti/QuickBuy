﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
	public class QuickBuyContexto : DbContext
	{
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<ItemPedido> ItemPedidos { get; set; }
		public DbSet<FormaPagamento> FormaPagamentos { get; set; }

		public QuickBuyContexto(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Classes de mapeamento			
			modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
			modelBuilder.ApplyConfiguration(new PedidoConfiguration());
			modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
			modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
			modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
			base.OnModelCreating(modelBuilder);
		}
	}
}

