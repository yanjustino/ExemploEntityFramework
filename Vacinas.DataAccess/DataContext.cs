namespace Vacinas.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Vacinas.DataModel;

    public partial class DataContext : DbContext
    {
        private static DataContext _context;

        public DataContext(): base("name=DataContext")
        {
        }

        public static DataContext Current
        {
            get
            {
                _context = _context ?? new DataContext();
                return _context;
            }
        }

        public virtual DbSet<alergiamotivo> alergiamotivoes { get; set; }
        public virtual DbSet<doenca> doencas { get; set; }
        public virtual DbSet<elementonatural> elementonaturals { get; set; }
        public virtual DbSet<medicamento> medicamentoes { get; set; }
        public virtual DbSet<medico> medicos { get; set; }
        public virtual DbSet<paciente> pacientes { get; set; }
        public virtual DbSet<pacientealergia> pacientealergias { get; set; }
        public virtual DbSet<pacientedoenca> pacientedoencas { get; set; }
        public virtual DbSet<pacientepeso> pacientepesoes { get; set; }
        public virtual DbSet<pacientevacina> pacientevacinas { get; set; }
        public virtual DbSet<posologia> posologias { get; set; }
        public virtual DbSet<posto> postoes { get; set; }
        public virtual DbSet<principioativo> principioativoes { get; set; }
        public virtual DbSet<vacina> vacinas { get; set; }
        public virtual DbSet<vacinacronograma> vacinacronogramas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<doenca>()
                .Property(e => e.nomedoenca)
                .IsUnicode(false);

            modelBuilder.Entity<doenca>()
                .HasMany(e => e.pacientedoencas)
                .WithRequired(e => e.doenca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doenca>()
                .HasMany(e => e.vacinas)
                .WithMany(e => e.doencas)
                .Map(m => m.ToTable("vacinadoenca").MapLeftKey("iddoenca").MapRightKey("idvacina"));

            modelBuilder.Entity<elementonatural>()
                .Property(e => e.nomeelementonatural)
                .IsUnicode(false);

            modelBuilder.Entity<medicamento>()
                .Property(e => e.nomemedicamento)
                .IsUnicode(false);

            modelBuilder.Entity<medicamento>()
                .HasMany(e => e.posologias)
                .WithRequired(e => e.medicamento)
                .HasForeignKey(e => e.idmedico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<medicamento>()
                .HasMany(e => e.principioativoes)
                .WithMany(e => e.medicamentoes)
                .Map(m => m.ToTable("medicamentocomposicao").MapLeftKey("idmedicamento").MapRightKey("idprincipioativo"));

            modelBuilder.Entity<medico>()
                .Property(e => e.nomemedico)
                .IsUnicode(false);

            modelBuilder.Entity<medico>()
                .HasMany(e => e.posologias)
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
                .HasMany(e => e.pacientevacinas)
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
                .HasMany(e => e.pacientevacinas)
                .WithRequired(e => e.posto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<principioativo>()
                .Property(e => e.nomeprincipioativo)
                .IsUnicode(false);

            modelBuilder.Entity<vacina>()
                .Property(e => e.nomevacina)
                .IsUnicode(false);

            modelBuilder.Entity<vacina>()
                .HasMany(e => e.pacientevacinas)
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
