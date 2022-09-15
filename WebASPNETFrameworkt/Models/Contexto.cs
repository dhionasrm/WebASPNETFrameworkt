using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebASPNETFrameworkt.Models
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);
        }
    }
}
