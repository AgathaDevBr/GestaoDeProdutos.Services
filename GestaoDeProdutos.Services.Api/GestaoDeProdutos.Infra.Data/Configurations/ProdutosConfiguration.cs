using GestaoDeProdutos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Infra.Data.Configurations
{
    internal class ProdutosConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Preco).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.EstoqueId).IsRequired();

            builder.HasOne(p => p.Estoque)
                .WithMany(e => e.Produtos)
                .HasForeignKey(p => p.EstoqueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Categoria)
               .WithMany(p => p.Produtos)
               .HasForeignKey(p => p.CategoriaId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
