USE [master]
GO
/****** Object:  Database [JDSOL_SOLICITACAO]    Script Date: 07/10/2019 11:10:14 ******/
CREATE DATABASE [JDSOL_SOLICITACAO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JDSOL_SOLICITACAO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Data\Local\JDSOL_SOLICITACAO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JDSOL_SOLICITACAO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Data\Local\JDSOL_SOLICITACAO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JDSOL_SOLICITACAO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ARITHABORT OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET  MULTI_USER 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JDSOL_SOLICITACAO', N'ON'
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET QUERY_STORE = OFF
GO
USE [JDSOL_SOLICITACAO]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [JDSOL_SOLICITACAO]
GO
/****** Object:  User [jddesenv]    Script Date: 07/10/2019 11:10:14 ******/
CREATE USER [jddesenv] FOR LOGIN [jddesenv] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [jddesenv]
GO
USE [JDSOL_SOLICITACAO]
GO
/****** Object:  Sequence [dbo].[SQJKB_BASE_CONHECIMENTO]    Script Date: 07/10/2019 11:10:14 ******/
/*CREATE SEQUENCE [dbo].[SQJKB_BASE_CONHECIMENTO] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [JDSOL_SOLICITACAO]
GO*/
/****** Object:  Sequence [dbo].[SQJKB_PALAVRA_CHAVE]    Script Date: 07/10/2019 11:10:14 ******/
CREATE SEQUENCE [dbo].[SQJKB_PALAVRA_CHAVE] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [JDSOL_SOLICITACAO]
GO
/****** Object:  Sequence [dbo].[SQJKB_PRODUTO]    Script Date: 07/10/2019 11:10:14 ******/
CREATE SEQUENCE [dbo].[SQJKB_PRODUTO] 
 AS [numeric](9, 0)
 START WITH 3
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999999999
 CACHE 
GO
USE [JDSOL_SOLICITACAO]
GO
/****** Object:  Sequence [dbo].[SQJKB_USUARIO]    Script Date: 07/10/2019 11:10:14 ******/
CREATE SEQUENCE [dbo].[SQJKB_USUARIO] 
 AS [numeric](9, 0)
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999999999
 CACHE 
GO
/****** Object:  Table [dbo].[TBJKB_BASE_CONHECIMENTO]    Script Date: 07/10/2019 11:10:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_BASE_CONHECIMENTO](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
	[TP_VISUALIZACAO] [varchar](10) NOT NULL,
	[ST_BASE] [varchar](3) NOT NULL,
 CONSTRAINT [PK_TBJKB_BASE_CONHECIMENTO] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_BASE_PRODUTO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_BASE_PRODUTO](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[ID_PRODUTO] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
 CONSTRAINT [PK_TBJKB_BASE_PRODUTO] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC,
	[ID_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_BUSCA_CHAVE]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_BUSCA_CHAVE](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[ID_PALAVRA] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
 CONSTRAINT [PK_TBJKB_BUSCA_CHAVE] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC,
	[ID_PALAVRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_CAUSA_RAIZ]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_CAUSA_RAIZ](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[SQ_VERSAO] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
	[TP_VISUALIZACAO] [varchar](10) NOT NULL,
	[TX_CAUSA_RAIZ] [text] NOT NULL,
 CONSTRAINT [PK_TBJKB_CAUSA_RAIZ] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC,
	[SQ_VERSAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_PALAVRA_CHAVE]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_PALAVRA_CHAVE](
	[ID_PALAVRA] [numeric](9, 0) NOT NULL,
	[PALAVRA] [varchar](50) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
 CONSTRAINT [PK_TBJKB_PALAVRA_CHAVE] PRIMARY KEY CLUSTERED 
(
	[ID_PALAVRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_PRODUTO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_PRODUTO](
	[ID_PRODUTO] [numeric](9, 0) NOT NULL,
	[NM_PRODUTO] [varchar](50) NOT NULL,
	[CD_PRODUTO] [varchar](5) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
 CONSTRAINT [PKJKB_PRODUTO] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [AKJKB_PRODUTO] UNIQUE NONCLUSTERED 
(
	[CD_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_RESUMO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_RESUMO](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[SQ_VERSAO] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
	[TP_VISUALIZACAO] [varchar](10) NOT NULL,
	[DS_TITULO] [varchar](1000) NOT NULL,
	[TX_RESUMO] [text] NOT NULL,
 CONSTRAINT [PK_TBJKB_RESUMO] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC,
	[SQ_VERSAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_SITUACAO_BASE]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_SITUACAO_BASE](
	[ST_BASE] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TBJKB_SITUACAO_BASE] PRIMARY KEY CLUSTERED 
(
	[ST_BASE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_SITUACAO_USUARIO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_SITUACAO_USUARIO](
	[ST_USUARIO] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TBJKB_SITUACAO_USUARIO] PRIMARY KEY CLUSTERED 
(
	[ST_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_SOLUCAO_PALIATIVA]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA](
	[ID_KB] [numeric](9, 0) NOT NULL,
	[SQ_VERSAO] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
	[TP_VISUALIZACAO] [varchar](10) NOT NULL,
	[TX_SOLUCAO_PALIATIVA] [text] NOT NULL,
 CONSTRAINT [PK_TBJKB_SOLUCAO_PALIATIVA] PRIMARY KEY CLUSTERED 
(
	[ID_KB] ASC,
	[SQ_VERSAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_TIPO_VISUALIZACAO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_TIPO_VISUALIZACAO](
	[TP_VISUALIZACAO] [varchar](10) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TBJKB_TIPO_VISUALIZACAO] PRIMARY KEY CLUSTERED 
(
	[TP_VISUALIZACAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBJKB_USUARIO]    Script Date: 07/10/2019 11:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJKB_USUARIO](
	[ID_USUARIO] [numeric](9, 0) NOT NULL,
	[NM_USUARIO] [varchar](100) NOT NULL,
	[EMAIL_USUARIO] [varchar](200) NOT NULL,
	[HASH_SENHA] [varchar](100) NULL,
	[ID_USUARIO_REGISTRO] [numeric](9, 0) NOT NULL,
	[DH_REGISTRO] [numeric](14, 0) NOT NULL,
	[ST_USUARIO] [varchar](3) NOT NULL,
 CONSTRAINT [PKJKB_USUARIO] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_BASE_SITUACAO] FOREIGN KEY([ST_BASE])
REFERENCES [dbo].[TBJKB_SITUACAO_BASE] ([ST_BASE])
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO] CHECK CONSTRAINT [FKJKB_BASE_SITUACAO]
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_BASE_TP_VISUAL] FOREIGN KEY([TP_VISUALIZACAO])
REFERENCES [dbo].[TBJKB_TIPO_VISUALIZACAO] ([TP_VISUALIZACAO])
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO] CHECK CONSTRAINT [FKJKB_BASE_TP_VISUAL]
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_BASE_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_BASE_CONHECIMENTO] CHECK CONSTRAINT [FKJKB_BASE_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_BASE_PRODUTO_PRODUTO] FOREIGN KEY([ID_PRODUTO])
REFERENCES [dbo].[TBJKB_PRODUTO] ([ID_PRODUTO])
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO] CHECK CONSTRAINT [FKJKB_BASE_PRODUTO_PRODUTO]
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_BASE_PRODUTO_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO] CHECK CONSTRAINT [FKJKB_BASE_PRODUTO_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_PRODUTO_BASE] FOREIGN KEY([ID_KB])
REFERENCES [dbo].[TBJKB_BASE_CONHECIMENTO] ([ID_KB])
GO
ALTER TABLE [dbo].[TBJKB_BASE_PRODUTO] CHECK CONSTRAINT [FKJKB_PRODUTO_BASE]
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE]  WITH CHECK ADD  CONSTRAINT [FKJKB_BUSCA_CHAVE_BASE] FOREIGN KEY([ID_KB])
REFERENCES [dbo].[TBJKB_BASE_CONHECIMENTO] ([ID_KB])
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE] CHECK CONSTRAINT [FKJKB_BUSCA_CHAVE_BASE]
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE]  WITH CHECK ADD  CONSTRAINT [FKJKB_BUSCA_CHAVE_PALAVRA] FOREIGN KEY([ID_PALAVRA])
REFERENCES [dbo].[TBJKB_PALAVRA_CHAVE] ([ID_PALAVRA])
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE] CHECK CONSTRAINT [FKJKB_BUSCA_CHAVE_PALAVRA]
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE]  WITH CHECK ADD  CONSTRAINT [FKJKB_CHAVE_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_BUSCA_CHAVE] CHECK CONSTRAINT [FKJKB_CHAVE_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ]  WITH CHECK ADD  CONSTRAINT [FKJKB_CAUSA_RAIZ_BASE] FOREIGN KEY([ID_KB])
REFERENCES [dbo].[TBJKB_BASE_CONHECIMENTO] ([ID_KB])
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ] CHECK CONSTRAINT [FKJKB_CAUSA_RAIZ_BASE]
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ]  WITH CHECK ADD  CONSTRAINT [FKJKB_CAUSA_RAIZ_TP_VISUAL] FOREIGN KEY([TP_VISUALIZACAO])
REFERENCES [dbo].[TBJKB_TIPO_VISUALIZACAO] ([TP_VISUALIZACAO])
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ] CHECK CONSTRAINT [FKJKB_CAUSA_RAIZ_TP_VISUAL]
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ]  WITH CHECK ADD  CONSTRAINT [FKJKB_CAUSA_RAIZ_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_CAUSA_RAIZ] CHECK CONSTRAINT [FKJKB_CAUSA_RAIZ_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_PALAVRA_CHAVE]  WITH CHECK ADD  CONSTRAINT [FKJKB_PALAVRA_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_PALAVRA_CHAVE] CHECK CONSTRAINT [FKJKB_PALAVRA_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_PRODUTO]  WITH CHECK ADD  CONSTRAINT [FKJKB_PRODUTO_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_PRODUTO] CHECK CONSTRAINT [FKJKB_PRODUTO_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_RESUMO]  WITH CHECK ADD  CONSTRAINT [FKJKB_RESUMO_BASE] FOREIGN KEY([ID_KB])
REFERENCES [dbo].[TBJKB_BASE_CONHECIMENTO] ([ID_KB])
GO
ALTER TABLE [dbo].[TBJKB_RESUMO] CHECK CONSTRAINT [FKJKB_RESUMO_BASE]
GO
ALTER TABLE [dbo].[TBJKB_RESUMO]  WITH CHECK ADD  CONSTRAINT [FKJKB_RESUMO_TP_VISUAL] FOREIGN KEY([TP_VISUALIZACAO])
REFERENCES [dbo].[TBJKB_TIPO_VISUALIZACAO] ([TP_VISUALIZACAO])
GO
ALTER TABLE [dbo].[TBJKB_RESUMO] CHECK CONSTRAINT [FKJKB_RESUMO_TP_VISUAL]
GO
ALTER TABLE [dbo].[TBJKB_RESUMO]  WITH CHECK ADD  CONSTRAINT [FKJKB_RESUMO_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_RESUMO] CHECK CONSTRAINT [FKJKB_RESUMO_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA]  WITH CHECK ADD  CONSTRAINT [FKJKB_SOLUCAO_BASE] FOREIGN KEY([ID_KB])
REFERENCES [dbo].[TBJKB_BASE_CONHECIMENTO] ([ID_KB])
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA] CHECK CONSTRAINT [FKJKB_SOLUCAO_BASE]
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA]  WITH CHECK ADD  CONSTRAINT [FKJKB_SOLUCAO_TP_VISUAL] FOREIGN KEY([TP_VISUALIZACAO])
REFERENCES [dbo].[TBJKB_TIPO_VISUALIZACAO] ([TP_VISUALIZACAO])
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA] CHECK CONSTRAINT [FKJKB_SOLUCAO_TP_VISUAL]
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA]  WITH CHECK ADD  CONSTRAINT [FKJKB_SOLUCAO_USUARIO] FOREIGN KEY([ID_USUARIO_REGISTRO])
REFERENCES [dbo].[TBJKB_USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_SOLUCAO_PALIATIVA] CHECK CONSTRAINT [FKJKB_SOLUCAO_USUARIO]
GO
ALTER TABLE [dbo].[TBJKB_USUARIO]  WITH CHECK ADD  CONSTRAINT [FKJKB_USUARIO_SITUACAO] FOREIGN KEY([ST_USUARIO])
REFERENCES [dbo].[TBJKB_SITUACAO_USUARIO] ([ST_USUARIO])
GO
ALTER TABLE [dbo].[TBJKB_USUARIO] CHECK CONSTRAINT [FKJKB_USUARIO_SITUACAO]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_CONHECIMENTO', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_CONHECIMENTO', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_CONHECIMENTO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Visualização da Informação' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_CONHECIMENTO', @level2type=N'COLUMN',@level2name=N'TP_VISUALIZACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Situação da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_CONHECIMENTO', @level2type=N'COLUMN',@level2name=N'ST_BASE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_PRODUTO', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_PRODUTO', @level2type=N'COLUMN',@level2name=N'ID_PRODUTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_PRODUTO', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BASE_PRODUTO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BUSCA_CHAVE', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Palavra Chave' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BUSCA_CHAVE', @level2type=N'COLUMN',@level2name=N'ID_PALAVRA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BUSCA_CHAVE', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_BUSCA_CHAVE', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sequência da Versão' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'SQ_VERSAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Visualização' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'TP_VISUALIZACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descrição da Causa Raiz' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_CAUSA_RAIZ', @level2type=N'COLUMN',@level2name=N'TX_CAUSA_RAIZ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Palavra Chave' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PALAVRA_CHAVE', @level2type=N'COLUMN',@level2name=N'ID_PALAVRA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Palavra Chave' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PALAVRA_CHAVE', @level2type=N'COLUMN',@level2name=N'PALAVRA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PALAVRA_CHAVE', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PALAVRA_CHAVE', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PRODUTO', @level2type=N'COLUMN',@level2name=N'ID_PRODUTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome do Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PRODUTO', @level2type=N'COLUMN',@level2name=N'NM_PRODUTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código do Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PRODUTO', @level2type=N'COLUMN',@level2name=N'CD_PRODUTO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PRODUTO', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_PRODUTO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sequência da Versão' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'SQ_VERSAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Visualização' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'TP_VISUALIZACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Título da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'DS_TITULO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Resumo/Descrição da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_RESUMO', @level2type=N'COLUMN',@level2name=N'TX_RESUMO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Situação da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SITUACAO_BASE', @level2type=N'COLUMN',@level2name=N'ST_BASE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descrição' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SITUACAO_BASE', @level2type=N'COLUMN',@level2name=N'DESCRICAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Situação do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SITUACAO_USUARIO', @level2type=N'COLUMN',@level2name=N'ST_USUARIO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descrição' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SITUACAO_USUARIO', @level2type=N'COLUMN',@level2name=N'DESCRICAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador da Base de Conhecimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SOLUCAO_PALIATIVA', @level2type=N'COLUMN',@level2name=N'ID_KB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sequência da Versão' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SOLUCAO_PALIATIVA', @level2type=N'COLUMN',@level2name=N'SQ_VERSAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SOLUCAO_PALIATIVA', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SOLUCAO_PALIATIVA', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Visualização' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_SOLUCAO_PALIATIVA', @level2type=N'COLUMN',@level2name=N'TP_VISUALIZACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Visualização' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_TIPO_VISUALIZACAO', @level2type=N'COLUMN',@level2name=N'TP_VISUALIZACAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descrição' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_TIPO_VISUALIZACAO', @level2type=N'COLUMN',@level2name=N'DESCRICAO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'NM_USUARIO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email do usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'EMAIL_USUARIO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hash da Senha do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'HASH_SENHA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'ID_USUARIO_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Data e Hora Registro (AAAAMMDDHHmmss)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'DH_REGISTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Situação do Usuário' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TBJKB_USUARIO', @level2type=N'COLUMN',@level2name=N'ST_USUARIO'
GO
USE [master]
GO
ALTER DATABASE [JDSOL_SOLICITACAO] SET  READ_WRITE 
GO
