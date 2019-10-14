using JDKB.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace JDKB.Data.EF
{
    public class JDDataContext : DbContext
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public JDDataContext(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            //this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public JDDataContext(string connectionString)
        {            
            _connectionString = connectionString;
            //this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<NPC_Situacao> NPCSituacao { get; set; }
        public DbSet<NPC_Erro> NPCErro { get; set; }
        public DbSet<SOL_Depto> SOL_Depto { get; set; }
        public DbSet<TipoVisualizacao> TipoVisualizacao { get; set; }
        public DbSet<SituacaoBase> SituacaoBase { get; set; }
        public DbSet<BaseConhecimento> BaseConhecimento { get; set; }
        public DbSet<CausaRaiz> CausaRaiz { get; set; }
        public DbSet<Resumo> Resumo { get; set; }
        public DbSet<SolucaoPaliativa> SolucaoPaliativa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<PalavraChave> PalavraChave { get; set; }
        public DbSet<BuscaChave> BuscaChave { get; set; }
        public DbSet<SituacaoUsuario> SituacaoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<BaseProduto> BaseProduto { get; set; }
        public DbSet<Anexo> Anexo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_config != null)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("JDConexao"));
            }
            else if (_connectionString != null)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            /// ENTIDADE - Anexo
            modelBuilder.Entity<Anexo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NomeArquivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            /// ENTIDADE - Produto
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PKJKB_PRODUTO");

                entity.ToTable("TBJKB_PRODUTO");

                entity.Property(e => e.IdProduto)
                    .ForSqlServerUseSequenceHiLo("SQJKB_PRODUTO");

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

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PRODUTO_USUARIO");
            });

            /// Entidade - BaseProduto
            modelBuilder.Entity<BaseProduto>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdProduto });

                entity.ToTable("TBJKB_BASE_PRODUTO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.IdProduto)
                    .HasColumnName("ID_PRODUTO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DtHrRegistro)
                    .HasColumnName("DH_REGISTRO")
                    .HasColumnType("numeric(14, 0)");

                entity.Property(e => e.IdUsuarioRegistro)
                    .HasColumnName("ID_USUARIO_REGISTRO")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.BaseConhecimento)
                    .WithMany(p => p.BaseProduto)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PRODUTO_BASE");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.BaseProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_PRODUTO_PRODUTO");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.BaseProduto)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_PRODUTO_USUARIO");
            });

            /// ENTIDADE - BaseConhecimento
            modelBuilder.Entity<BaseConhecimento>(entity =>
            {
                entity.HasKey(e => e.Id);                

                entity.ToTable("TBJKB_BASE_CONHECIMENTO");

                entity.Property(e => e.Id)
                    .ForSqlServerUseSequenceHiLo("SQJKB_BASE_CONHECIMENTO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DtHrRegistro)
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

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.BaseConhecimento)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_USUARIO");

                entity.HasOne(d => d.SituacaoBase)
                    .WithMany(p => p.BaseConhecimento)
                    .HasForeignKey(d => d.StBase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_SITUACAO");

                entity.HasOne(d => d.TipoVisualizacao)
                    .WithMany(p => p.BaseConhecimento)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BASE_TP_VISUAL");

                entity.Ignore(e => e.TotalMath);
            });

            /// ENTIDADE - CausaRaiz
            modelBuilder.Entity<CausaRaiz>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SeqVersao });

                entity.ToTable("TBJKB_CAUSA_RAIZ");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SeqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DtHrRegistro)
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

                entity.Property(e => e.Texto)
                    .HasColumnName("TX_CAUSA_RAIZ")
                    .HasColumnType("text");

                entity.HasOne(d => d.BaseConhecimento)
                    .WithMany(p => p.CausaRaiz)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_BASE");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.CausaRaiz)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_USUARIO");

                entity.HasOne(d => d.TipoVisualizacao)
                    .WithMany(p => p.CausaRaiz)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CAUSA_RAIZ_TP_VISUAL");
            });

            /// ENTIDADE - Resumo
            modelBuilder.Entity<Resumo>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SeqVersao });

                entity.ToTable("TBJKB_RESUMO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SeqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DtHrRegistro)
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

                entity.Property(e => e.DsTitulo)
                    .IsRequired()
                    .HasColumnName("DS_TITULO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Texto)
                    .HasColumnName("TX_RESUMO")
                    .HasColumnType("text");

                entity.HasOne(d => d.BaseConhecimento)
                    .WithMany(p => p.Resumo)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_BASE");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Resumo)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_USUARIO");

                entity.HasOne(d => d.TipoVisualizacao)
                    .WithMany(p => p.Resumo)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_RESUMO_TP_VISUAL");
            });

            /// ENTIDADE - SolucaoPaliativa
            modelBuilder.Entity<SolucaoPaliativa>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SeqVersao });

                entity.ToTable("TBJKB_SOLUCAO_PALIATIVA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_KB")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SeqVersao)
                    .HasColumnName("SQ_VERSAO")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DtHrRegistro)
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

                entity.Property(e => e.Texto).HasColumnName("TX_SOLUCAO_PALIATIVA");

                entity.HasOne(d => d.BaseConhecimento)
                    .WithMany(p => p.SolucaoPaliativa)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_BASE");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SolucaoPaliativa)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_USUARIO");

                entity.HasOne(d => d.TipoVisualizacao)
                    .WithMany(p => p.SolucaoPaliativa)
                    .HasForeignKey(d => d.TpVisualizacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_SOLUCAO_TP_VISUAL");
            });

            /// ENTIDADE - SituacaoBase
            modelBuilder.Entity<SituacaoBase>(entity =>
            {
                entity.HasKey(e => e.Situacao);

                entity.ToTable("TBJKB_SITUACAO_BASE");

                entity.Property(e => e.Situacao)
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

            /// ENTIDADE - TipoVisualizacao
            modelBuilder.Entity<TipoVisualizacao>(entity =>
            {
                entity.HasKey(e => e.Tipo);

                entity.ToTable("TBJKB_TIPO_VISUALIZACAO");

                entity.Property(e => e.Tipo)
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

            /// ENTIDADE - BuscaChave
            modelBuilder.Entity<BuscaChave>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdPalavra });

                entity.ToTable("TBJKB_BUSCA_CHAVE");

                entity.Property(e => e.Id)
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

                entity.HasOne(d => d.BaseConhecimento)
                    .WithMany(p => p.BuscaChave)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BUSCA_CHAVE_BASE");

                entity.HasOne(d => d.PalavraChave)
                    .WithMany(p => p.BuscaChave)
                    .HasForeignKey(d => d.IdPalavra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_BUSCA_CHAVE_PALAVRA");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.BuscaChave)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_CHAVE_USUARIO");

                entity.Ignore(e => e.Tags);
            });

            /// Entidade - PalavraChave
            modelBuilder.Entity<PalavraChave>(entity =>
            {
                entity.HasKey(e => e.IdPalavra);

                entity.ToTable("TBJKB_PALAVRA_CHAVE");

                entity.Property(e => e.IdPalavra)
                    .ForSqlServerUseSequenceHiLo("SQJKB_PALAVRA_CHAVE");

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

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PalavraChave)
                    .HasForeignKey(d => d.IdUsuarioRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_PALAVRA_USUARIO");
            });

            /// Entidade - Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PKJKB_USUARIO");

                entity.Property(e => e.IdUsuario)
                    .ForSqlServerUseSequenceHiLo("SQJKB_USUARIO");

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

                entity.HasOne(d => d.SituacaoUsuario)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.StUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKJKB_USUARIO_SITUACAO");
            });

            modelBuilder.Entity<SituacaoUsuario>(entity =>
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

            /// SEQUENCE - BaseConhecimento
            modelBuilder.HasSequence("SQJKB_BASE_CONHECIMENTO");

            /// SEQUENCE - PalavraChave
            modelBuilder.HasSequence<Int64>("SQJKB_PALAVRA_CHAVE")
                .StartsAt(1).IncrementsBy(1);

            modelBuilder.HasSequence<Int64>("SQJKB_PRODUTO")
                .StartsAt(3).IncrementsBy(1);

            modelBuilder.HasSequence<Int64>("SQJKB_USUARIO")
                .StartsAt(2).IncrementsBy(1);

        }
    }
}
