-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 05, 2018 at 01:13 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `indaya`
--
CREATE DATABASE IF NOT EXISTS `indaya` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `indaya`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `AddCliente`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddCliente` (IN `Nome` VARCHAR(255))  NO SQL
INSERT INTO clientes VALUES(0, Nome)$$

DROP PROCEDURE IF EXISTS `AddProduto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddProduto` (IN `Nome` VARCHAR(255), IN `Descricao` VARCHAR(255))  NO SQL
INSERT INTO produtos VALUES(0, Nome, Descricao)$$

DROP PROCEDURE IF EXISTS `AddUsuario`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddUsuario` (IN `Nome` VARCHAR(255), IN `Senha` VARCHAR(255))  NO SQL
INSERT INTO usuarios VALUES(0, Nome, Senha)$$

DROP PROCEDURE IF EXISTS `AddVenda`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddVenda` (IN `Valor` DOUBLE, IN `Cliente` INT, IN `Qtd` INT, IN `Produto` INT, IN `DataVenda` VARCHAR(15), IN `Nota` VARCHAR(255))  NO SQL
INSERT INTO vendas VALUES(0, Valor, Cliente, Qtd, Produto, DataVenda, Nota)$$

DROP PROCEDURE IF EXISTS `LoginUsuario`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LoginUsuario` (IN `Usuario` VARCHAR(255), IN `Senha` VARCHAR(255))  NO SQL
SELECT * FROM usuarios WHERE NomeUsu = Usuario and SenhaUsu = Senha$$

DROP PROCEDURE IF EXISTS `SelectClientes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectClientes` ()  NO SQL
SELECT * FROM clientes$$

DROP PROCEDURE IF EXISTS `SelectProdutos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectProdutos` ()  NO SQL
SELECT * FROM produtos$$

DROP PROCEDURE IF EXISTS `SelectProdutosEspecifica`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectProdutosEspecifica` (IN `Pesquisa` VARCHAR(255))  NO SQL
SELECT * FROM produtos WHERE CodigoProduto LIKE Pesquisa or NomeProduto LIKE '%Pesquisa%' or DescricaoProduto LIKE '%Pesquisa%'$$

DROP PROCEDURE IF EXISTS `SelectUsuarios`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectUsuarios` ()  NO SQL
SELECT * FROM usuarios$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `CodigoCliente` int(11) NOT NULL AUTO_INCREMENT,
  `NomeCliente` varchar(255) NOT NULL,
  PRIMARY KEY (`CodigoCliente`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

INSERT INTO `clientes` (`CodigoCliente`, `NomeCliente`) VALUES
(1, 'qualquerum'),
(2, 'Ville');

-- --------------------------------------------------------

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE IF NOT EXISTS `produtos` (
  `CodigoProduto` int(11) NOT NULL AUTO_INCREMENT,
  `NomeProduto` varchar(255) NOT NULL,
  `DescricaoProduto` varchar(255) NOT NULL,
  PRIMARY KEY (`CodigoProduto`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produtos`
--

INSERT INTO `produtos` (`CodigoProduto`, `NomeProduto`, `DescricaoProduto`) VALUES
(1, 'Pão Frances', '50g'),
(2, 'Pão de Leite', 'Agranel 50g');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `CodigoUsu` int(11) NOT NULL AUTO_INCREMENT,
  `NomeUsu` varchar(255) NOT NULL,
  `SenhaUsu` varchar(255) NOT NULL,
  PRIMARY KEY (`CodigoUsu`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`CodigoUsu`, `NomeUsu`, `SenhaUsu`) VALUES
(1, 'teste', 'teste123'),
(2, 'Aline Fernanda de Miranda Teles', '240983'),
(3, 'Ryan', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `vendas`
--

DROP TABLE IF EXISTS `vendas`;
CREATE TABLE IF NOT EXISTS `vendas` (
  `IdVenda` int(11) NOT NULL AUTO_INCREMENT,
  `ValorVenda` double NOT NULL,
  `IdCliente` int(11) NOT NULL,
  `QuantidadeProduto` int(11) NOT NULL,
  `IdProduto` int(11) NOT NULL,
  `Data` varchar(15) NOT NULL,
  `NumeroNota` varchar(255) NOT NULL,
  PRIMARY KEY (`IdVenda`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vendas`
--

INSERT INTO `vendas` (`IdVenda`, `ValorVenda`, `IdCliente`, `QuantidadeProduto`, `IdProduto`, `Data`, `NumeroNota`) VALUES
(1, 1231.2, 3, 10, 1, '01/10/2018', ''),
(2, 1231.2, 3, 10, 1, '01/10/2018', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
