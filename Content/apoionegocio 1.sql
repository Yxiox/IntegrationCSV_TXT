CREATE DATABASE  IF NOT EXISTS `apoionegocio` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `apoionegocio`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: apoionegocio
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(50) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES ('0017bd53-1251-11ef-a04e-02500869912c','Filme','2024-05-14 21:20:57',NULL);
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classificacao`
--

DROP TABLE IF EXISTS `classificacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classificacao` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(3) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classificacao`
--

LOCK TABLES `classificacao` WRITE;
/*!40000 ALTER TABLE `classificacao` DISABLE KEYS */;
INSERT INTO `classificacao` VALUES ('0017b86b-1251-11ef-a04e-02500869912c','5','2024-05-14 21:20:57',NULL);
/*!40000 ALTER TABLE `classificacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genero` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(20) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES ('0017a821-1251-11ef-a04e-02500869912c','Ação','2024-05-14 21:20:57',NULL),('32aad640-1251-11ef-a04e-02500869912c','Terror','2024-05-14 22:20:57',NULL);
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `midia`
--

DROP TABLE IF EXISTS `midia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `midia` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(50) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `midia`
--

LOCK TABLES `midia` WRITE;
/*!40000 ALTER TABLE `midia` DISABLE KEYS */;
INSERT INTO `midia` VALUES ('0017c0b8-1251-11ef-a04e-02500869912c','Blu-ray','2024-05-14 21:20:57',NULL);
/*!40000 ALTER TABLE `midia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participantes`
--

DROP TABLE IF EXISTS `participantes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `participantes` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(100) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participantes`
--

LOCK TABLES `participantes` WRITE;
/*!40000 ALTER TABLE `participantes` DISABLE KEYS */;
INSERT INTO `participantes` VALUES ('0017c460-1251-11ef-a04e-02500869912c','Bruce Willis','2024-05-14 21:20:57',NULL);
/*!40000 ALTER TABLE `participantes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_midia`
--

DROP TABLE IF EXISTS `tipo_midia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_midia` (
  `ID` varchar(40) NOT NULL DEFAULT (uuid()),
  `NOME` varchar(50) NOT NULL,
  `DATAREGISTRO` datetime NOT NULL,
  `DATAINATIVACAO` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `NOME` (`NOME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_midia`
--

LOCK TABLES `tipo_midia` WRITE;
/*!40000 ALTER TABLE `tipo_midia` DISABLE KEYS */;
INSERT INTO `tipo_midia` VALUES ('0017c810-1251-11ef-a04e-02500869912c','Física','2024-05-14 21:20:57',NULL);
/*!40000 ALTER TABLE `tipo_midia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'apoionegocio'
--

--
-- Dumping routines for database 'apoionegocio'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-14 21:24:48
