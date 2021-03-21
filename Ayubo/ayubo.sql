-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 21, 2021 at 06:50 AM
-- Server version: 5.7.26
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ayubo`
--

-- --------------------------------------------------------

--
-- Table structure for table `hire`
--

DROP TABLE IF EXISTS `hire`;
CREATE TABLE IF NOT EXISTS `hire` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `vehicleNo` int(11) NOT NULL,
  `StartingDate` int(11) NOT NULL,
  `EndingDate` int(11) NOT NULL,
  `StartingKm` int(11) NOT NULL,
  `EndingKm` int(11) NOT NULL,
  `Package` varchar(20) NOT NULL,
  `Amount` varchar(200) NOT NULL,
  `Type` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hire`
--

INSERT INTO `hire` (`Id`, `vehicleNo`, `StartingDate`, `EndingDate`, `StartingKm`, `EndingKm`, `Package`, `Amount`, `Type`) VALUES
(1, 1234, 12, 23, 1233, 1344, 'package_100', '12000 + 2200 + 1650', 'day tour');

-- --------------------------------------------------------

--
-- Table structure for table `package`
--

DROP TABLE IF EXISTS `package`;
CREATE TABLE IF NOT EXISTS `package` (
  `package_Name` varchar(100) NOT NULL,
  `Package_Price` double NOT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `package`
--

INSERT INTO `package` (`package_Name`, `Package_Price`, `Id`) VALUES
('package_100', 10000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `rent`
--

DROP TABLE IF EXISTS `rent`;
CREATE TABLE IF NOT EXISTS `rent` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `vehicleNo` int(11) NOT NULL,
  `StartingDate` int(11) NOT NULL,
  `EndingDate` int(11) NOT NULL,
  `Driver` tinyint(1) NOT NULL,
  `CalculatedRent` double NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rent`
--

INSERT INTO `rent` (`Id`, `vehicleNo`, `StartingDate`, `EndingDate`, `Driver`, `CalculatedRent`) VALUES
(1, 1234, 23, 12, 1, 27000);

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
CREATE TABLE IF NOT EXISTS `vehicle` (
  `VehicleNo` int(11) NOT NULL,
  `VehicleType` varchar(100) NOT NULL,
  PRIMARY KEY (`VehicleNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`VehicleNo`, `VehicleType`) VALUES
(1234, 'Van');

-- --------------------------------------------------------

--
-- Table structure for table `vehicletype`
--

DROP TABLE IF EXISTS `vehicletype`;
CREATE TABLE IF NOT EXISTS `vehicletype` (
  `VehicleType` varchar(100) NOT NULL,
  `Tariff` double NOT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicletype`
--

INSERT INTO `vehicletype` (`VehicleType`, `Tariff`, `Id`) VALUES
('Van', 2000, 1),
('car', 200, 4);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
