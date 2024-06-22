CREATE DATABASE  IF NOT EXISTS `catalogo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `catalogo`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: catalogo
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
INSERT INTO `catalogo` VALUES ('170455b6-2dc2-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',200.00,'https://youtube.com'),('770c5e93-2455-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',13.00,'https://youtube.com'),('7b5f8616-2dc3-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',200.00,'https://youtube.com'),('85b8f10c-2dd0-11ef-959b-005056ac9f53','95481914-2dcf-11ef-959b-005056ac9f53','95481afc-2dcf-11ef-959b-005056ac9f53','2a432523-2dd0-11ef-959b-005056ac9f53','95481ea6-2dcf-11ef-959b-005056ac9f53','95481735-2dcf-11ef-959b-005056ac9f53','95481cd6-2dcf-11ef-959b-005056ac9f53',100.00,'https://youtube.com'),('a74f54fe-2dc1-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',200.00,'https://youtube.com'),('d681ec7b-2dc4-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',200.00,'https://youtube.com'),('f54cc1d8-2455-11ef-959b-005056ac9f53','0017a821-1251-11ef-a04e-02500869912c','0017c0b8-1251-11ef-a04e-02500869912c','0017bd53-1251-11ef-a04e-02500869912c','0017c810-1251-11ef-a04e-02500869912c','0017b86b-1251-11ef-a04e-02500869912c','0017c460-1251-11ef-a04e-02500869912c',1000.00,'https://youtube.com');
/*!40000 ALTER TABLE `catalogo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'catalogo'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-22 17:05:56
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monolito`
--

LOCK TABLES `monolito` WRITE;
/*!40000 ALTER TABLE `monolito` DISABLE KEYS */;
INSERT INTO `monolito` VALUES (1,'ação','guerra','jornada lunatica','vídeo',14,'Nicolas Silva');
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
	DECLARE categoriaEncontrada VARCHAR(255);
    DECLARE classificacaoEncontrada VARCHAR(255);
    DECLARE generoEncontrado VARCHAR(255);
    DECLARE midiaEncontrada VARCHAR(255);
    DECLARE participanteEncontrado VARCHAR(255);
    DECLARE tipoMidiaEncontrada VARCHAR(255);

    SELECT NOME INTO categoriaEncontrada 
    FROM apoionegocio.CATEGORIA 
    WHERE NOME = NEW.CATEGORIA;

    IF (categoriaEncontrada IS NULL) THEN
        INSERT INTO apoionegocio.CATEGORIA(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.CATEGORIA, NOW(), NULL);
    END IF;

    SELECT NOME INTO classificacaoEncontrada 
    FROM apoionegocio.CLASSIFICACAO 
    WHERE NOME = NEW.CLASSIFICACAO;

    IF (classificacaoEncontrada IS NULL) THEN
        INSERT INTO apoionegocio.CLASSIFICACAO(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.CLASSIFICACAO, NOW(), NULL);
    END IF;
    
    SELECT NOME INTO generoEncontrado 
    FROM apoionegocio.GENERO 
    WHERE NOME = NEW.GENERO;

    IF (generoEncontrado IS NULL) THEN
        INSERT INTO apoionegocio.GENERO(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.GENERO, NOW(), NULL);
    END IF;

    SELECT NOME INTO midiaEncontrada 
    FROM apoionegocio.MIDIA 
    WHERE NOME = NEW.MIDIA;

    IF (midiaEncontrada IS NULL) THEN
        INSERT INTO apoionegocio.MIDIA(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.MIDIA, NOW(), NULL);
    END IF;
    
    SELECT NOME INTO participanteEncontrado 
    FROM apoionegocio.PARTICIPANTES 
    WHERE NOME = NEW.PARTICIPANTE;

    IF (participanteEncontrado IS NULL) THEN
        INSERT INTO apoionegocio.PARTICIPANTES(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.PARTICIPANTE, NOW(), NULL);
    END IF;

    
    SELECT NOME INTO tipoMidiaEncontrada 
    FROM apoionegocio.TIPO_MIDIA 
    WHERE NOME = NEW.TIPO_MIDIA;

    IF (tipoMidiaEncontrada IS NULL) THEN
        INSERT INTO apoionegocio.TIPO_MIDIA(NOME, DATAREGISTRO, DATAINATIVACAO) 
        VALUES (NEW.TIPO_MIDIA, NOW(), NULL);
    END IF;
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

-- Dump completed on 2024-06-22 17:05:57
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
INSERT INTO `categoria` VALUES ('2a432523-2dd0-11ef-959b-005056ac9f53','sla','2024-02-02 00:00:00','2024-02-02 00:00:00');
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
INSERT INTO `classificacao` VALUES ('95481735-2dcf-11ef-959b-005056ac9f53','14','2024-06-18 21:05:05',NULL);
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
INSERT INTO `genero` VALUES ('95481914-2dcf-11ef-959b-005056ac9f53','ação','2024-06-18 21:05:05',NULL);
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
INSERT INTO `midia` VALUES ('95481afc-2dcf-11ef-959b-005056ac9f53','jornada lunatica','2024-06-18 21:05:05',NULL);
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
INSERT INTO `participantes` VALUES ('95481cd6-2dcf-11ef-959b-005056ac9f53','Nicolas Silva','2024-06-18 21:05:05',NULL);
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
INSERT INTO `tipo_midia` VALUES ('95481ea6-2dcf-11ef-959b-005056ac9f53','vídeo','2024-06-18 21:05:05',NULL);
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

-- Dump completed on 2024-06-22 17:05:57
