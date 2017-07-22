CREATE DATABASE  IF NOT EXISTS `fabricaapp_ra` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `fabricaapp_ra`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: robb0161.publiccloud.com.br    Database: fabricaapp_ra
-- ------------------------------------------------------
-- Server version	5.1.73-rel14.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aluno`
--

DROP TABLE IF EXISTS `aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aluno` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `ra` varchar(15) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `usuario_id` (`usuario_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='tabela responsável por manter informações do aluno, assim co';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno`
--

LOCK TABLES `aluno` WRITE;
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checkpoint`
--

DROP TABLE IF EXISTS `checkpoint`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checkpoint` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` datetime NOT NULL,
  `evento_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `evento_id` (`evento_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkpoint`
--

LOCK TABLES `checkpoint` WRITE;
/*!40000 ALTER TABLE `checkpoint` DISABLE KEYS */;
/*!40000 ALTER TABLE `checkpoint` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nome` (`nome`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `local`
--

DROP TABLE IF EXISTS `local`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `local` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `endereco` varchar(255) NOT NULL,
  `evento_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `evento_id` (`evento_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `local`
--

LOCK TABLES `local` WRITE;
/*!40000 ALTER TABLE `local` DISABLE KEYS */;
/*!40000 ALTER TABLE `local` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participante`
--

DROP TABLE IF EXISTS `participante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participante` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `evento_id` int(11) NOT NULL,
  `aluno_id` int(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `evento_id` (`evento_id`),
  KEY `aluno_id` (`aluno_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participante`
--

LOCK TABLES `participante` WRITE;
/*!40000 ALTER TABLE `participante` DISABLE KEYS */;
/*!40000 ALTER TABLE `participante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presenca`
--

DROP TABLE IF EXISTS `presenca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `presenca` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tempo` datetime NOT NULL,
  `qr_code_id` int(11) NOT NULL,
  `participante_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `qr_code_id` (`qr_code_id`),
  KEY `participante_id` (`participante_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presenca`
--

LOCK TABLES `presenca` WRITE;
/*!40000 ALTER TABLE `presenca` DISABLE KEYS */;
/*!40000 ALTER TABLE `presenca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `qr_code`
--

DROP TABLE IF EXISTS `qr_code`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `qr_code` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(255) DEFAULT NULL,
  `evento_id` int(11) NOT NULL,
  `local_id` int(11) NOT NULL,
  `checkpoint_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `evento_id` (`evento_id`),
  KEY `local_id` (`local_id`),
  KEY `checkpoint_id` (`checkpoint_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `qr_code`
--

LOCK TABLES `qr_code` WRITE;
/*!40000 ALTER TABLE `qr_code` DISABLE KEYS */;
/*!40000 ALTER TABLE `qr_code` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='tabela de usuários';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-06-03 11:29:24
