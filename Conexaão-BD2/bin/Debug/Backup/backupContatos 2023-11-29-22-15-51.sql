-- MySqlBackup.NET 2.3.6
-- Dump Time: 2023-11-29 22:15:51
-- --------------------------------------
-- Server version 10.4.28-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tbcontato
-- 

DROP TABLE IF EXISTS `tbcontato`;
CREATE TABLE IF NOT EXISTS `tbcontato` (
  `codContato` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  `telefone` char(13) DEFAULT NULL,
  `celular` char(14) DEFAULT NULL,
  `email` varchar(35) NOT NULL,
  PRIMARY KEY (`codContato`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table tbcontato
-- 

/*!40000 ALTER TABLE `tbcontato` DISABLE KEYS */;
INSERT INTO `tbcontato`(`codContato`,`nome`,`telefone`,`celular`,`email`) VALUES(1,'oi legal mano','','(54)54848-7489','legal@gmail.com'),(2,'pinacolada','','(44)68468-4684','pina@gmail.com'),(3,'beluga','','(58)45254-2544','beluga@gmail.com'),(4,'paulo','','(54)54545-5456','paulo@gmail.com');
/*!40000 ALTER TABLE `tbcontato` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-11-29 22:15:51
-- Total time: 0:0:0:0:135 (d:h:m:s:ms)
