-- --------------------------------------------------------
-- Host:                         (local)\sqlexpress
-- Server version:               Microsoft SQL Server 2017 (RTM) - 14.0.1000.169
-- Server OS:                    Windows 10 Home 10.0 <X64> (Build 18362: )
-- HeidiSQL Version:             10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for BlackTulipDB
CREATE DATABASE IF NOT EXISTS "BlackTulipDB";
USE "BlackTulipDB";

-- Dumping structure for table BlackTulipDB.bestellingen
CREATE TABLE IF NOT EXISTS "bestellingen" (
	"BID" INT(10,0) NOT NULL,
	"Datum" VARCHAR(50) NULL DEFAULT NULL,
	"KID" INT(10,0) NOT NULL,
	PRIMARY KEY ("BID")
);

-- Data exporting was unselected.

-- Dumping structure for table BlackTulipDB.Item
CREATE TABLE IF NOT EXISTS "Item" (
	"IID" INT(10,0) NOT NULL,
	"Hoeveelheid" VARCHAR(50) NULL DEFAULT NULL,
	"BID" INT(10,0) NOT NULL,
	"PID" INT(10,0) NOT NULL,
	PRIMARY KEY ("IID")
);

-- Data exporting was unselected.

-- Dumping structure for table BlackTulipDB.klant
CREATE TABLE IF NOT EXISTS "klant" (
	"KID" INT(10,0) NOT NULL,
	"Naam" VARCHAR(50) NULL DEFAULT NULL,
	"Stad" VARCHAR(50) NULL DEFAULT NULL,
	"MobielNummer" VARCHAR(50) NULL DEFAULT NULL,
	"EMail" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("KID")
);

-- Data exporting was unselected.

-- Dumping structure for table BlackTulipDB.product
CREATE TABLE IF NOT EXISTS "product" (
	"PID" INT(10,0) NOT NULL,
	"ProductNaam" VARCHAR(50) NULL DEFAULT NULL,
	"PtID" INT(10,0) NOT NULL,
	"Prijs" MONEY(19,4) NOT NULL,
	"Afbeelding" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("PID")
);

-- Data exporting was unselected.

-- Dumping structure for table BlackTulipDB.producttypen
CREATE TABLE IF NOT EXISTS "producttypen" (
	"PtID" INT(10,0) NOT NULL,
	"Omschrijving" VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY ("PtID")
);

-- Data exporting was unselected.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
