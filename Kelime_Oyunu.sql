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
INSERT INTO `sorular` VALUES (1,'Ulvi??? s??z??n??n T??rk??e k??kenli e?? anlaml??s??','Y??ce',4),(2,'??zerinde yak??c?? t??yler bulunan bir ot','Is??rgan',7),(3,'Ara?? ??st?? y??kl??????','Portbagaj',9),(4,'Gasilhaneye giden yolun ba??lang??c?? olan mekan','Do??umhane',9),(5,'???Ma????? s??zc??????n??n e?? anlaml??s??','Kar????la??ma',10),(6,'Ulvi??? s??z??n??n T??rk??e k??kenli e?? anlaml??s??','Y??ce',4),(7,'Odun, k??m??r, elektrik, gaz veya do??al gaz ile kullan??lan ??e??itleri bulunan ??s??nma gereci','Soba',4),(8,'Kasapl??k hayvanlardan sa??lanan kemiksiz besin maddesi','Lopet',5),(9,'???Seyrek??? s??z??n??n e?? ve yak??n anlaml?? kar????l??????','Nadir',5),(10,'Birden fazla d??kkan veya yaz??hanenin bulundu??u ??ok katl?? bia','????han??',6),(11,'???Boyamak, s??sleyerek de??i??ik hale sokmak??? anlam??ndaki Frans??zca k??kenli bir kelimeden t??reyen s??z','Makyaj',6),(12,'Sevin??, korku, sab??rs??zl??k, k??zg??nl??k gibi sebeplerle ortaya ????kan g????l?? ve ge??ici duygu durumu','Heyecan',7),(13,'??zerinde yak??c?? t??yler bulunan bir ot','Is??rgan',7),(14,'Otob??s, u??ak gibi ta????tlar??n yolcular??n?? ilk ald?????? ve son b??rakt?????? yer','Terminal',8),(15,'Saray, k????k ve konaklarda erkek konuklar??n kabul edildi??i yer','Selaml??k',8),(16,'Ara?? ??st?? y??kl??????','Portbagaj',9),(17,'Gasilhaneye giden yolun ba??lang??c?? olan mekan','Do??umhane',9),(18,'Verilmek istenen mesaj??n ula??mas?? istenen grup veya topluluk','Hedefkitle',10),(19,'???Ma????? s??zc??????n??n e?? anlaml??s??','Kar????la??ma',10);
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
