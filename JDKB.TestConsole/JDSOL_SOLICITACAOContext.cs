using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JDKB.TestConsole
{
    public partial class JDSOL_SOLICITACAOContext : DbContext
    {
        public JDSOL_SOLICITACAOContext()
        {
        }

        public JDSOL_SOLICITACAOContext(DbContextOptions<JDSOL_SOLICITACAOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbjkbBaseConhecimento> TbjkbBaseConhecimento { get; set; }
        public virtual DbSet<TbjkbBaseProduto> TbjkbBaseProduto { get; set; }
        public virtual DbSet<TbjkbBuscaChave> TbjkbBuscaChave { get; set; }
        public virtual DbSet<TbjkbCausaRaiz> TbjkbCausaRaiz { get; set; }
        public virtual DbSet<TbjkbPalavraChave> TbjkbPalavraChave { get; set; }
        public virtual DbSet<TbjkbProduto> TbjkbProduto { get; set; }
        public virtual DbSet<TbjkbResumo> TbjkbResumo { get; set; }
        public virtual DbSet<TbjkbSituacaoBase> TbjkbSituacaoBase { get; set; }
        public virtual DbSet<TbjkbSituacaoUsuario> TbjkbSituacaoUsuario { get; set; }
        public virtual DbSet<TbjkbSolucaoPaliativa> TbjkbSolucaoPaliativa { get; set; }
        public virtual DbSet<TbjkbTipoVisualizacao> TbjkbTipoVisualizacao { get; set; }
        public virtual DbSet<TbjkbUsuario> TbjkbUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<TbjkbBaseConhecimento>(entity =>
            {
                entity.HasKey(e => e.IdKb);

                entity.ToTable("TBJKB_BASE_CONHECIMENTO");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.StBase)
                    .IsRequired()
                    .HasColumnName("ST_BASE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TpVisualizacao)
                    .IsRequired()
                    .HasColumnName("TP_VISUALIZACAO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbBaseConhecimento)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_USUARIO");

                entity.HasOne(d => d.StBaseNavigation)
                    .WithMany(p => p.TbjkbBaseConhecimento)
                    .HasForeignKey(d => d.StBase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_SITUACAO");

                entity.HasOne(d => d.TpVisualizacaoNavigation)
                    .WithMany(p => p.TbjkbBaseConhecimento)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_TP_VISUAL");
            });

            modelBuilder.Entity<TbjkbBaseProduto>(entity =>
            {
                entity.HasKey(e => new { e.IdKb, e.IdProduto });

                entity.ToTable("TBJKB_BASE_PRODUTO");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.IdProduto)
                    .HasColumnName("ID_PRODUTO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.IdKbNavigation)
                    .WithMany(p => p.TbjkbBaseProduto)
                    .HasForeignKey(d => d.IdKb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PRODUTO_BASE");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbjkbBaseProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_PRODUTO_PRODUTO");

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbBaseProduto)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_PRODUTO_USUARIO");
            });

            modelBuilder.Entity<TbjkbBuscaChave>(entity =>
            {
                entity.HasKey(e => new { e.IdKb, e.IdPalavra });

                entity.ToTable("TBJKB_BUSCA_CHAVE");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.IdPalavra)
                    .HasColumnName("ID_PALAVRA")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.IdKbNavigation)
                    .WithMany(p => p.TbjkbBuscaChave)
                    .HasForeignKey(d => d.IdKb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BUSCA_CHAVE_BASE");

                entity.HasOne(d => d.IdPalavraNavigation)
                    .WithMany(p => p.TbjkbBuscaChave)
                    .HasForeignKey(d => d.IdPalavra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BUSCA_CHAVE_PALAVRA");

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbBuscaChave)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CHAVE_USUARIO");
            });

            modelBuilder.Entity<TbjkbCausaRaiz>(entity =>
            {
                entity.HasKey(e => new { e.IdKb, e.SqVersao });

                entity.ToTable("TBJKB_CAUSA_RAIZ");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TpVisualizacao)
                    .IsRequired()
                    .HasColumnName("TP_VISUALIZACAO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxCausaRaiz)
                    .IsRequired()
                    .HasColumnName("TX_CAUSA_RAIZ")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdKbNavigation)
                    .WithMany(p => p.TbjkbCausaRaiz)
                    .HasForeignKey(d => d.IdKb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_BASE");

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbCausaRaiz)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_USUARIO");

                entity.HasOne(d => d.TpVisualizacaoNavigation)
                    .WithMany(p => p.TbjkbCausaRaiz)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_TP_VISUAL");
            });

            modelBuilder.Entity<TbjkbPalavraChave>(entity =>
            {
                entity.HasKey(e => e.IdPalavra);

                entity.ToTable("TBJKB_PALAVRA_CHAVE");

                entity.Property(e => e.IdPalavra)
                    .HasColumnName("ID_PALAVRA")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Palavra)
                    .IsRequired()
                    .HasColumnName("PALAVRA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbPalavraChave)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PALAVRA_USUARIO");
            });

            modelBuilder.Entity<TbjkbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PKJKB_PRODUTO");

                entity.ToTable("TBJKB_PRODUTO");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("AKJKB_PRODUTO")
                    .IsUnique();

                entity.Property(e => e.IdProduto)
                    .HasColumnName("ID_PRODUTO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("CD_PRODUTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.NmProduto)
                    .IsRequired()
                    .HasColumnName("NM_PRODUTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbProduto)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PRODUTO_USUARIO");
            });

            modelBuilder.Entity<TbjkbResumo>(entity =>
            {
                entity.HasKey(e => new { e.IdKb, e.SqVersao });

                entity.ToTable("TBJKB_RESUMO");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.DsTitulo)
                    .IsRequired()
                    .HasColumnName("DS_TITULO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TpVisualizacao)
                    .IsRequired()
                    .HasColumnName("TP_VISUALIZACAO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxResumo)
                    .IsRequired()
                    .HasColumnName("TX_RESUMO")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdKbNavigation)
                    .WithMany(p => p.TbjkbResumo)
                    .HasForeignKey(d => d.IdKb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_BASE");

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbResumo)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_USUARIO");

                entity.HasOne(d => d.TpVisualizacaoNavigation)
                    .WithMany(p => p.TbjkbResumo)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_TP_VISUAL");
            });

            modelBuilder.Entity<TbjkbSituacaoBase>(entity =>
            {
                entity.HasKey(e => e.StBase);

                entity.ToTable("TBJKB_SITUACAO_BASE");

                entity.Property(e => e.StBase)
                    .HasColumnName("ST_BASE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbjkbSituacaoUsuario>(entity =>
            {
                entity.HasKey(e => e.StUsuario);

                entity.ToTable("TBJKB_SITUACAO_USUARIO");

                entity.Property(e => e.StUsuario)
                    .HasColumnName("ST_USUARIO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbjkbSolucaoPaliativa>(entity =>
            {
                entity.HasKey(e => new { e.IdKb, e.SqVersao });

                entity.ToTable("TBJKB_SOLUCAO_PALIATIVA");

                entity.Property(e => e.IdKb)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TpVisualizacao)
                    .IsRequired()
                    .HasColumnName("TP_VISUALIZACAO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxSolucaoPaliativa)
                    .IsRequired()
                    .HasColumnName("TX_SOLUCAO_PALIATIVA")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdKbNavigation)
                    .WithMany(p => p.TbjkbSolucaoPaliativa)
                    .HasForeignKey(d => d.IdKb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_BASE");

                entity.HasOne(d => d.IdUsuarioRegistroNavigation)
                    .WithMany(p => p.TbjkbSolucaoPaliativa)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_USUARIO");

                entity.HasOne(d => d.TpVisualizacaoNavigation)
                    .WithMany(p => p.TbjkbSolucaoPaliativa)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_TP_VISUAL");
            });

            modelBuilder.Entity<TbjkbTipoVisualizacao>(entity =>
            {
                entity.HasKey(e => e.TpVisualizacao);

                entity.ToTable("TBJKB_TIPO_VISUALIZACAO");

                entity.Property(e => e.TpVisualizacao)
                    .HasColumnName("TP_VISUALIZACAO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbjkbUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PKJKB_USUARIO");

                entity.ToTable("TBJKB_USUARIO");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_USUARIO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DhRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.EmailUsuario)
                    .IsRequired()
                    .HasColumnName("EMAIL_USUARIO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HashSenha)
                    .HasColumnName("HASH_SENHA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.NmUsuario)
                    .IsRequired()
                    .HasColumnName("NM_USUARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StUsuario)
                    .IsRequired()
                    .HasColumnName("ST_USUARIO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.StUsuarioNavigation)
                    .WithMany(p => p.TbjkbUsuario)
                    .HasForeignKey(d => d.StUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_USUARIO_SITUACAO");
            });

            modelBuilder.HasSequence("SQJKB_BASE_CONHECIMENTO");

            modelBuilder.HasSequence("SQJKB_PALAVRA_CHAVE");

            modelBuilder.HasSequence<decimal>("SQJKB_PRODUTO")
                .StartsAt(3)
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence<decimal>("SQJKB_USUARIO")
                .HasMin(1)
                .HasMax(999999999);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}