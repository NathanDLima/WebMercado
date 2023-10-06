-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Out-2023 às 22:06
-- Versão do servidor: 10.4.25-MariaDB
-- versão do PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `webmercado2`
--
CREATE DATABASE IF NOT EXISTS `webmercado2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `webmercado2`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroleclaims`
--

CREATE TABLE IF NOT EXISTS `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroles`
--

CREATE TABLE IF NOT EXISTS `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('226ea878-15ad-4039-9f3c-8374fe4429ba', 'Administrador', 'ADMINISTRADOR', 'd87191a4-3c2c-47c0-a004-a39097c2ccb2'),
('db684739-0198-4325-8b4d-ec21c1660d67', 'Cliente', 'CLIENTE', 'f2ecd002-d089-4502-bd05-f83d0a646b31');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserclaims`
--

CREATE TABLE IF NOT EXISTS `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserlogins`
--

CREATE TABLE IF NOT EXISTS `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserroles`
--

CREATE TABLE IF NOT EXISTS `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('5c1c4412-0114-468f-a9cf-81ee07f2e81e', '226ea878-15ad-4039-9f3c-8374fe4429ba'),
('9e9e8595-a391-47db-a6fc-18e5063ab001', 'db684739-0198-4325-8b4d-ec21c1660d67'),
('d49f8072-5e8c-424c-bc93-29de59ae2a48', 'db684739-0198-4325-8b4d-ec21c1660d67');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusers`
--

CREATE TABLE IF NOT EXISTS `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Apelido` varchar(20) DEFAULT NULL,
  `DataNascimento` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Nome`, `Apelido`, `DataNascimento`) VALUES
('5c1c4412-0114-468f-a9cf-81ee07f2e81e', 'admin@webmercado.com.br', 'ADMIN@WEBMERCADO.COM.BR', 'admin@webmercado.com.br', 'ADMIN@WEBMERCADO.COM.BR', 1, 'AQAAAAEAACcQAAAAEP3YpjmwofNwGgGuhX0NPszU6Pbikw4cRxHuOi2cbf54gI0fbmPhV97U7bi08Ey8xw==', '25666', 'bd909823-34d7-4cbd-80d9-0f69e2952a06', NULL, 0, 0, NULL, 0, 0, 'Admin', 'Admin', '2020-11-10 20:35:28'),
('9e9e8595-a391-47db-a6fc-18e5063ab001', 'nathan@live.com', 'NATHAN@LIVE.COM', 'nathan@live.com', 'NATHAN@LIVE.COM', 0, 'AQAAAAEAACcQAAAAEP0xLsKQIrR9mRNRLT+ixE4loowR0pGhhLuYEK5XUPQ/oWv4SMzqhLoX3MvdtNCi5A==', 'LNMMJA3HXK3HAXZD6JTBUPNTRN4AV4A6', '48c1add0-9991-418d-8582-90b56db789a3', NULL, 0, 0, NULL, 1, 0, 'Nathan2', 'Nathan2', '2002-11-08 00:00:00'),
('d49f8072-5e8c-424c-bc93-29de59ae2a48', 'nadavison@live.com', 'NADAVISON@LIVE.COM', 'nadavison@live.com', 'NADAVISON@LIVE.COM', 0, 'AQAAAAEAACcQAAAAEL8VqozvrX1Lk5qGnTKq29A3Xitr8Fx1SRvcwg41zwE7VkZHzBNaplbJ6u1E/TWlyw==', 'YLPCIUHL5O4Q5OHFALKZVFDNBZTIGKDG', 'aceaa567-1ac3-4569-bc65-43980cf981fe', NULL, 0, 0, NULL, 1, 0, 'Nathan Lima', 'Nathan', '2002-11-08 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusertokens`
--

CREATE TABLE IF NOT EXISTS `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itempedido`
--

CREATE TABLE IF NOT EXISTS `itempedido` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PedidoId` int(11) NOT NULL,
  `ProdutoId` int(11) NOT NULL,
  `Quantidade` int(11) NOT NULL,
  `ValorTotal` double NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `PedidoId` (`PedidoId`),
  KEY `ProdutoId` (`ProdutoId`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `DataPedido` datetime DEFAULT NULL,
  `ValorTotal` double(10,0) DEFAULT NULL,
  `IdUser` varchar(85) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IdUser` (`IdUser`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(70) NOT NULL,
  `Descricao` varchar(500) DEFAULT NULL,
  `EstoqueAtual` int(11) NOT NULL,
  `EstoqueMinimo` int(11) NOT NULL,
  `ValorCusto` double NOT NULL,
  `ValorVenda` double NOT NULL,
  `DataCadastro` datetime NOT NULL,
  `CategoriaId` int(11) NOT NULL,
  `Imagem` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Produto_CategoriaId` (`CategoriaId`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20201110233528_inicio', '3.1.9');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `itempedido`
--
ALTER TABLE `itempedido`
  ADD CONSTRAINT `itempedido_ibfk_1` FOREIGN KEY (`PedidoId`) REFERENCES `pedido` (`Id`),
  ADD CONSTRAINT `itempedido_ibfk_2` FOREIGN KEY (`ProdutoId`) REFERENCES `produto` (`Id`);

--
-- Limitadores para a tabela `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`IdUser`) REFERENCES `aspnetusers` (`Id`);

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `FK_Produto_Categoria_CategoriaId` FOREIGN KEY (`CategoriaId`) REFERENCES `categoria` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
