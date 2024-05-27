CREATE DATABASE  IF NOT EXISTS `apoionegocio` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `apoionegocio`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: apoionegocio
-- ------------------------------------------------------
-- Server version	8.0.26

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

-- Dump completed on 2024-05-27 20:16:32
CREATE DATABASE  IF NOT EXISTS `legado` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `legado`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: legado
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `monolito`
--

DROP TABLE IF EXISTS `monolito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `monolito` (
  `id` int NOT NULL AUTO_INCREMENT,
  `genero` varchar(20) NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `midia` varchar(50) NOT NULL,
  `tipo_midia` varchar(50) NOT NULL,
  `classificacao` int NOT NULL,
  `participante` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monolito`
--

LOCK TABLES `monolito` WRITE;
/*!40000 ALTER TABLE `monolito` DISABLE KEYS */;
INSERT INTO `monolito` VALUES (32,'Ação','Filme','Blu-ray','Física',5,'Bruce Willis'),(33,'Comédia','Série','Streaming','Digital',4,'Tina Fey'),(34,'Drama','Livro','Impresso','Física',3,'Jane Austen'),(35,'Ficção Científica','Filme','DVD','Física',4,'Sigourney Weaver'),(36,'Romance','Série','Streaming','Digital',4,'Noah Centineo'),(37,'Aventura','Jogo','Download','Digital',5,'Nathan Drake'),(38,'Fantasia','Livro','E-book','Digital',4,'J.K. Rowling'),(39,'Suspense','Filme','Blu-ray','Física',4,'Alfred Hitchcock'),(40,'Documentário','Série','Streaming','Digital',3,'David Attenborough'),(41,'Comédia Romântica','Filme','DVD','Física',4,'Meg Ryan'),(42,'Ação','Filme','Blu-ray','Física',5,'Bruce Willis'),(43,'Comédia','Série','Streaming','Digital',4,'Tina Fey'),(44,'Drama','Livro','Impresso','Física',3,'Jane Austen'),(45,'Ficção Científica','Filme','DVD','Física',4,'Sigourney Weaver'),(46,'Romance','Série','Streaming','Digital',4,'Noah Centineo'),(47,'Ação','Filme','Blu-ray','Física',5,'Bruce Willis'),(48,'Comédia','Série','Streaming','Digital',4,'Tina Fey'),(49,'Drama','Livro','Impresso','Física',3,'Jane Austen'),(50,'Ficção Científica','Filme','DVD','Física',4,'Sigourney Weaver'),(51,'Romance','Série','Streaming','Digital',4,'Noah Centineo'),(54,'AWD','AWD','AW','WD',4,'AWD'),(55,'STRING','STRING','STRING','STRING',3,'STRING');
/*!40000 ALTER TABLE `monolito` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `monolito_AFTER_INSERT` AFTER INSERT ON `monolito` FOR EACH ROW BEGIN
	INSERT INTO apoionegocio.CATEGORIA(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.CATEGORIA, NOW(), NULL);
    INSERT INTO apoionegocio.CLASSIFICACAO(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.CLASSIFICACAO, NOW(), NULL);
    INSERT INTO apoionegocio.GENERO(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.GENERO, NOW(), NULL);
    INSERT INTO apoionegocio.MIDIA(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.MIDIA, NOW(), NULL);
    INSERT INTO apoionegocio.PARTICIPANTES(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.PARTICIPANTE, NOW(), NULL);
    INSERT INTO apoionegocio.TIPO_MIDIA(NOME, DATAREGISTRO, DATAINATIVACAO) VALUES (NEW.TIPO_MIDIA, NOW(), NULL);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Dumping routines for database 'legado'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-27 20:16:32
