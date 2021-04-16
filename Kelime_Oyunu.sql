-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: kelime_oyunu
-- ------------------------------------------------------
-- Server version	5.7.31

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
-- Table structure for table `kullanici`
--

DROP TABLE IF EXISTS `kullanici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanici` (
  `idKullanici` int(11) NOT NULL AUTO_INCREMENT,
  `Kullanici_Adi` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Skor` int(11) NOT NULL DEFAULT '0',
  `Sure` varchar(200) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`idKullanici`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanici`
--

LOCK TABLES `kullanici` WRITE;
/*!40000 ALTER TABLE `kullanici` DISABLE KEYS */;
/*!40000 ALTER TABLE `kullanici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sorular`
--

DROP TABLE IF EXISTS `sorular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sorular` (
  `idSorular` int(11) NOT NULL AUTO_INCREMENT,
  `Soru` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Cevap` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Kelime_sayisi` int(11) NOT NULL,
  PRIMARY KEY (`idSorular`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sorular`
--

LOCK TABLES `sorular` WRITE;
/*!40000 ALTER TABLE `sorular` DISABLE KEYS */;
INSERT INTO `sorular` VALUES (1,'Ulvi” sözünün Türkçe kökenli eş anlamlısı','Yüce',4),(2,'Üzerinde yakıcı tüyler bulunan bir ot','Isırgan',7),(3,'Araç üstü yüklüğü','Portbagaj',9),(4,'Gasilhaneye giden yolun başlangıcı olan mekan','Doğumhane',9),(5,'“Maç” sözcüğünün eş anlamlısı','Karşılaşma',10),(6,'Ulvi” sözünün Türkçe kökenli eş anlamlısı','Yüce',4),(7,'Odun, kömür, elektrik, gaz veya doğal gaz ile kullanılan çeşitleri bulunan ısınma gereci','Soba',4),(8,'Kasaplık hayvanlardan sağlanan kemiksiz besin maddesi','Lopet',5),(9,'“Seyrek” sözünün eş ve yakın anlamlı karşılığı','Nadir',5),(10,'Birden fazla dükkan veya yazıhanenin bulunduğu çok katlı bia','İşhanı',6),(11,'“Boyamak, süsleyerek değişik hale sokmak” anlamındaki Fransızca kökenli bir kelimeden türeyen söz','Makyaj',6),(12,'Sevinç, korku, sabırsızlık, kızgınlık gibi sebeplerle ortaya çıkan güçlü ve geçici duygu durumu','Heyecan',7),(13,'Üzerinde yakıcı tüyler bulunan bir ot','Isırgan',7),(14,'Otobüs, uçak gibi taşıtların yolcularını ilk aldığı ve son bıraktığı yer','Terminal',8),(15,'Saray, köşk ve konaklarda erkek konukların kabul edildiği yer','Selamlık',8),(16,'Araç üstü yüklüğü','Portbagaj',9),(17,'Gasilhaneye giden yolun başlangıcı olan mekan','Doğumhane',9),(18,'Verilmek istenen mesajın ulaşması istenen grup veya topluluk','Hedefkitle',10),(19,'“Maç” sözcüğünün eş anlamlısı','Karşılaşma',10);
/*!40000 ALTER TABLE `sorular` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-04 22:12:21
