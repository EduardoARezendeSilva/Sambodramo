-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 10-Nov-2021 às 09:19
-- Versão do servidor: 8.0.18
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sambodramo`
--
CREATE DATABASE IF NOT EXISTS `sambodramo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `sambodramo`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `desfile`
--

DROP TABLE IF EXISTS `desfile`;
CREATE TABLE IF NOT EXISTS `desfile` (
  `id_desfile` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `samba_enrredo` varchar(80) NOT NULL,
  `entrada_rua` date NOT NULL,
  `nota` decimal(4,2) NOT NULL,
  `id_escola` int(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id_desfile`),
  KEY `id_escola` (`id_escola`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `desfile`
--

INSERT INTO `desfile` VALUES
(1, 'Caos', '2021-10-21', '5.00', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `escolas`
--

DROP TABLE IF EXISTS `escolas`;
CREATE TABLE IF NOT EXISTS `escolas` (
  `id_escola` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome_escola` varchar(80) NOT NULL,
  `ano_ult_part` char(4) NOT NULL,
  `nome_proprietario` varchar(80) NOT NULL,
  PRIMARY KEY (`id_escola`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `escolas`
--

INSERT INTO `escolas` VALUES
(1, 'Anfitriao', '2021', 'Arnaldo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) NOT NULL,
  `email` varchar(120) NOT NULL,
  `senha` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` VALUES
(1, 'Eduardo', 'Eduardo@email.com', '123456');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
