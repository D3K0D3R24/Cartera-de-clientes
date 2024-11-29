-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2023-06-07 14:04:03
-- --------------------------------------
-- Server version 10.4.24-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of cliente
-- 

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `ID_CLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE_CLIENTE` varchar(45) NOT NULL,
  `CORREO` varchar(40) NOT NULL,
  `TELEFONO` varchar(20) NOT NULL,
  `DIRECCION` varchar(50) NOT NULL,
  `EDAD` int(11) NOT NULL,
  `RANGO` varchar(20) NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table cliente
-- 

/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente`(`ID_CLIENTE`,`NOMBRE_CLIENTE`,`CORREO`,`TELEFONO`,`DIRECCION`,`EDAD`,`RANGO`) VALUES
(1,'Cliente1','cliente1@gmail.com','9971200941','Calle 54 x 37 y 39',20,'Inicial');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- 
-- Definition of creditos
-- 

DROP TABLE IF EXISTS `creditos`;
CREATE TABLE IF NOT EXISTS `creditos` (
  `ID_CREDITOS` int(11) NOT NULL AUTO_INCREMENT,
  `FECHA_OTORGAMIENTO` date NOT NULL,
  `CANTIDAD_CREDITO` float NOT NULL,
  `VIGENCIA` date NOT NULL,
  `SALDO_RESTANTE` float NOT NULL,
  `INTERES` double NOT NULL,
  `FK_ID_CLIENTE` int(11) NOT NULL,
  `FK_ID_EMPLEADO` int(11) NOT NULL,
  PRIMARY KEY (`ID_CREDITOS`),
  KEY `FK_ID_CLIENTE` (`FK_ID_CLIENTE`),
  KEY `FK_ID_EMPLEADO` (`FK_ID_EMPLEADO`),
  CONSTRAINT `creditos_ibfk_1` FOREIGN KEY (`FK_ID_CLIENTE`) REFERENCES `cliente` (`ID_CLIENTE`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `creditos_ibfk_2` FOREIGN KEY (`FK_ID_EMPLEADO`) REFERENCES `usuarios` (`ID_USUARIO`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table creditos
-- 

/*!40000 ALTER TABLE `creditos` DISABLE KEYS */;
INSERT INTO `creditos`(`ID_CREDITOS`,`FECHA_OTORGAMIENTO`,`CANTIDAD_CREDITO`,`VIGENCIA`,`SALDO_RESTANTE`,`INTERES`,`FK_ID_CLIENTE`,`FK_ID_EMPLEADO`) VALUES
(9,'2023-06-02 00:00:00',60000,'2023-06-15 00:00:00',0,10,1,1);
/*!40000 ALTER TABLE `creditos` ENABLE KEYS */;

-- 
-- Definition of pagos
-- 

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE IF NOT EXISTS `pagos` (
  `ID_PAGO` int(11) NOT NULL AUTO_INCREMENT,
  `FECHA_PAGO` date NOT NULL,
  `CANTIDAD_PAGO` float NOT NULL,
  `FK_ID_CLIENTE` int(11) NOT NULL,
  `FK_ID_EMPLEADO` int(11) NOT NULL,
  `FK_ID_CREDITO` int(11) NOT NULL,
  PRIMARY KEY (`ID_PAGO`),
  KEY `FK_ID_CLIENTE` (`FK_ID_CLIENTE`),
  KEY `FK_ID_CREDITO` (`FK_ID_CREDITO`),
  KEY `FK_ID_EMPLEADO` (`FK_ID_EMPLEADO`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`FK_ID_CLIENTE`) REFERENCES `cliente` (`ID_CLIENTE`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pagos_ibfk_2` FOREIGN KEY (`FK_ID_CREDITO`) REFERENCES `creditos` (`ID_CREDITOS`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pagos_ibfk_3` FOREIGN KEY (`FK_ID_EMPLEADO`) REFERENCES `usuarios` (`ID_USUARIO`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table pagos
-- 

/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos`(`ID_PAGO`,`FECHA_PAGO`,`CANTIDAD_PAGO`,`FK_ID_CLIENTE`,`FK_ID_EMPLEADO`,`FK_ID_CREDITO`) VALUES
(12,'2023-06-03 00:00:00',3000,1,1,9),
(13,'2023-06-03 00:00:00',5000,1,1,9),
(14,'2023-06-05 00:00:00',5000,1,1,9),
(15,'2023-06-05 00:00:00',5000,1,1,9),
(16,'2023-06-05 00:00:00',5000,1,1,9),
(17,'2023-06-05 00:00:00',40000,1,1,9);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;

-- 
-- Definition of usuarios
-- 

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID_USUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `USUARIO` varchar(45) NOT NULL,
  `PASSWORD` varchar(20) NOT NULL,
  PRIMARY KEY (`ID_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table usuarios
-- 

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios`(`ID_USUARIO`,`USUARIO`,`PASSWORD`) VALUES
(1,'Administrador','admin123'),
(2,'empleado1','123');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-06-07 14:04:04
-- Total time: 0:0:0:0:510 (d:h:m:s:ms)
