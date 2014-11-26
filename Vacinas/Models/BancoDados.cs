namespace Vacinas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BancoDados : DbContext
    {
        public BancoDados()
            : base("name=BancoDados")
        {
        }

        public virtual DbSet<alergiamotivo> alergiamotivo { get; set; }
        public virtual DbSet<doenca> doenca { get; set; }
        public virtual DbSet<elementonatural> elementonatural { get; set; }
        public virtual DbSet<medicamento> medicamento { get; set; }
        public virtual DbSet<medico> medico { get; set; }
        public virtual DbSet<paciente> paciente { get; set; }
        public virtual DbSet<pacientealergia> pacientealergia { get; set; }
        public virtual DbSet<pacientedoenca> pacientedoenca { get; set; }
        public virtual DbSet<pacientepeso> pacientepeso { get; set; }
        public virtual DbSet<pacientevacina> pacientevacina { get; set; }
        public virtual DbSet<posologia> posologia { get; set; }
        public virtual DbSet<posto> posto { get; set; }
        public virtual DbSet<principioativo> principioativo { get; set; }
        public virtual DbSet<vacina> vacina { get; set; }
        public virtual DbSet<vacinacronograma> vacinacronograma { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<doenca>()
                .Property(e => e.nomedoenca)
                .IsUnicode(false);

            modelBuilder.Entity<doenca>()
                .HasMany(e => e.pacientedoenca)
                .WithRequired(e => e.doenca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doenca>()
                .HasMany(e => e.vacina)
                .WithMany(e => e.doenca)
                .Map(m => m.ToTable("vacinadoenca").MapLeftKey("iddoenca").MapRightKey("idvacina"));

            modelBuilder.Entity<elementonatural>()
                .Property(e => e.nomeelementonatural)
                .IsUnicode(false);

            modelBuilder.Entity<medicamento>()
                .Property(e => e.nomemedicamento)
                .IsUnicode(false);

            modelBuilder.Entity<medicamento>()
                .HasMany(e => e.posologia)
                .WithRequired(e => e.medicamento)
                .HasForeignKey(e => e.idmedico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<medicamento>()
                .HasMany(e => e.principioativo)
                .WithMany(e => e.medicamento)
                .Map(m => m.ToTable("medicamentocomposicao").MapLeftKey("idmedicamento").MapRightKey("idprincipioativo"));

            modelBuilder.Entity<medico>()
                .Property(e => e.nomemedico)
                .IsUnicode(false);

            modelBuilder.Entity<medico>()
                .HasMany(e => e.posologia)
                .WithRequired(e => e.medico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.nomepaciente)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.tiposanguineo)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.fatorsanguineo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .HasMany(e => e.pacientevacina)
                .WithRequired(e => e.paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pacientealergia>()
                .Property(e => e.observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<pacientepeso>()
                .Property(e => e.peso)
                .HasPrecision(12, 2);

            modelBuilder.Entity<pacientevacina>()
                .Property(e => e.responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<posologia>()
                .Property(e => e.textoposologia)
                .IsUnicode(false);

            modelBuilder.Entity<posto>()
                .Property(e => e.nomeposto)
                .IsUnicode(false);

            modelBuilder.Entity<posto>()
                .Property(e => e.tipoposto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<posto>()
                .HasMany(e => e.pacientevacina)
                .WithRequired(e => e.posto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<principioativo>()
                .Property(e => e.nomeprincipioativo)
                .IsUnicode(false);

            modelBuilder.Entity<vacina>()
                .Property(e => e.nomevacina)
                .IsUnicode(false);

            modelBuilder.Entity<vacina>()
                .HasMany(e => e.pacientevacina)
                .WithRequired(e => e.vacina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vacinacronograma>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<vacinacronograma>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vacinacronograma>()
                .HasMany(e => e.vacinacronograma1)
                .WithOptional(e => e.vacinacronograma2)
                .HasForeignKey(e => e.idanterior);
        }
    }
}
