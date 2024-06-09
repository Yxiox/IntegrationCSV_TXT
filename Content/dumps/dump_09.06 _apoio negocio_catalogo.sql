CREATE DATABASE  IF NOT EXISTS `catalogo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `catalogo`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: catalogo
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `catalogo`
--

DROP TABLE IF EXISTS `catalogo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalogo` (
  `ID` varchar(40) NOT NULL,
  `ID_GENERO` varchar(40) NOT NULL,
  `ID_MIDIA` varchar(40) NOT NULL,
  `ID_CATEGORIA` varchar(40) NOT NULL,
  `ID_TIPO_MIDIA` varchar(40) NOT NULL,
  `ID_CLASSIFICACAO` varchar(40) NOT NULL,
  `ID_PARTICIPANTE` varchar(40) NOT NULL,
  `PRECO` decimal(10,2) NOT NULL,
  `CAMINHO` varchar(250) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `idCATALOGO_UNIQUE` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo`
--

LOCK TABLES `catalogo` WRITE;
/*!40000 ALTER TABLE `catalogo` DISABLE KEYS */;
INSERT INTO `catalogo` VALUES ('770c5e93-2455-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',150.00,'https://youtube.com'),('f54cc1d8-2455-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',1000.00,'https://youtube.com');
/*!40000 ALTER TABLE `catalogo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-09 14:41:13
CREATE DATABASE  IF NOT EXISTS `apoionegocio` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `apoionegocio`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: apoionegocio
-- ------------------------------------------------------
-- Server version	8.0.36

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
INSERT INTO `categoria` VALUES ('0017bd53-1251-11ef-a04e-02500869912c','Filme','2024-05-14 21:20:57',NULL),('11eecdf9-1c7e-11ef-959b-005056ac9f53','AWD','2024-05-27 20:08:46',NULL),('40c05aa1-1c7e-11ef-959b-005056ac9f53','STRING','2024-05-27 20:10:04',NULL);
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
INSERT INTO `classificacao` VALUES ('0017b86b-1251-11ef-a04e-02500869912c','5','2024-05-14 21:20:57',NULL),('11eede71-1c7e-11ef-959b-005056ac9f53','4','2024-05-27 20:08:46',NULL),('40c05d77-1c7e-11ef-959b-005056ac9f53','3','2024-05-27 20:10:04',NULL);
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
INSERT INTO `genero` VALUES ('0017a821-1251-11ef-a04e-02500869912c','Ação','2024-05-14 21:20:57',NULL),('11eef5f9-1c7e-11ef-959b-005056ac9f53','AWD','2024-05-27 20:08:46',NULL),('32aad640-1251-11ef-a04e-02500869912c','Terror','2024-05-14 22:20:57',NULL),('40c05f0c-1c7e-11ef-959b-005056ac9f53','STRING','2024-05-27 20:10:04',NULL);
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
INSERT INTO `midia` VALUES ('0017c0b8-1251-11ef-a04e-02500869912c','Blu-ray','2024-05-14 21:20:57',NULL),('11ef03dc-1c7e-11ef-959b-005056ac9f53','AW','2024-05-27 20:08:46',NULL),('2f3e55c8-1c77-11ef-959b-005056ac9f53','sla','2024-02-02 00:00:00','2024-02-02 00:00:00'),('40c06071-1c7e-11ef-959b-005056ac9f53','STRING','2024-05-27 20:10:04',NULL);
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
INSERT INTO `participantes` VALUES ('0017c460-1251-11ef-a04e-02500869912c','Bruce Willis','2024-05-14 21:20:57',NULL),('11ef12c8-1c7e-11ef-959b-005056ac9f53','AWD','2024-05-27 20:08:46',NULL),('40c061d7-1c7e-11ef-959b-005056ac9f53','STRING','2024-05-27 20:10:04',NULL);
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
INSERT INTO `tipo_midia` VALUES ('0017c810-1251-11ef-a04e-02500869912c','Física','2024-05-14 21:20:57',NULL),('11ef214f-1c7e-11ef-959b-005056ac9f53','WD','2024-05-27 20:08:46',NULL),('40c0633f-1c7e-11ef-959b-005056ac9f53','STRING','2024-05-27 20:10:04',NULL);
/*!40000 ALTER TABLE `tipo_midia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-09 14:41:13
