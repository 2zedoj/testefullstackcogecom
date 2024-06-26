USE [master]
GO
/****** Object:  Database [bancodedadostestefullstackcogecom]    Script Date: 25/03/2024 18:32:09 ******/
CREATE DATABASE [bancodedadostestefullstackcogecom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bancodedadostestefullstackcogecom', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\bancodedadostestefullstackcogecom.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bancodedadostestefullstackcogecom_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\bancodedadostestefullstackcogecom_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bancodedadostestefullstackcogecom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ARITHABORT OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET RECOVERY FULL 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET  MULTI_USER 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bancodedadostestefullstackcogecom', N'ON'
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET QUERY_STORE = ON
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bancodedadostestefullstackcogecom]
GO
/****** Object:  Table [dbo].[Cooperado]    Script Date: 25/03/2024 18:32:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cooperado](
	[Id] [int] NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Telefone] [varchar](100) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Ativo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 25/03/2024 18:32:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[Id] [int] NOT NULL,
	[Logradouro] [varchar](255) NOT NULL,
	[Bairro] [varchar](255) NOT NULL,
	[Localidade] [varchar](255) NOT NULL,
	[UF] [varchar](2) NOT NULL,
	[numero] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadeConsumidora]    Script Date: 25/03/2024 18:32:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadeConsumidora](
	[Id] [int] NOT NULL,
	[Codigo] [varchar](255) NOT NULL,
	[Concessionaria] [int] NOT NULL,
	[Ativo] [bit] NOT NULL,
	[CooperadoId] [int] NULL,
	[EnderecoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UnidadeConsumidora]  WITH CHECK ADD  CONSTRAINT [FK_Cooperado_UnidadeConsumidora] FOREIGN KEY([CooperadoId])
REFERENCES [dbo].[Cooperado] ([Id])
GO
ALTER TABLE [dbo].[UnidadeConsumidora] CHECK CONSTRAINT [FK_Cooperado_UnidadeConsumidora]
GO
ALTER TABLE [dbo].[UnidadeConsumidora]  WITH CHECK ADD  CONSTRAINT [FK_UnidadeConsumidora_Endereco] FOREIGN KEY([EnderecoId])
REFERENCES [dbo].[Endereco] ([Id])
GO
ALTER TABLE [dbo].[UnidadeConsumidora] CHECK CONSTRAINT [FK_UnidadeConsumidora_Endereco]
GO
USE [master]
GO
ALTER DATABASE [bancodedadostestefullstackcogecom] SET  READ_WRITE 
GO
