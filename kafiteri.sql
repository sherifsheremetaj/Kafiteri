-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 15, 2017 at 06:08 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kafiteri`
--

-- --------------------------------------------------------

--
-- Table structure for table `alkool`
--

CREATE TABLE `alkool` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Cmimi` double(10,2) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `alkool`
--

INSERT INTO `alkool` (`ID`, `Emri`, `Cmimi`, `Data`) VALUES
(1, 'RakiShpisë', 1.00, '2017-06-15'),
(2, 'Badell', 1.00, '2017-06-15'),
(3, 'Malibu', 1.00, '2017-06-15'),
(4, 'SmirnoffIce', 2.30, '2017-06-14'),
(5, 'JackDaniels', 2.30, '2017-06-14'),
(6, 'SmirnoffVodka', 2.30, '2017-06-14'),
(7, 'VodkeKuqe', 2.30, '2017-06-14'),
(8, 'Shampanjë', 2.30, '2017-06-14'),
(9, 'GrejGus', 2.30, '2017-06-14'),
(10, 'B52', 2.30, '2017-06-14'),
(11, 'Tekilla', 2.62, '2017-06-07'),
(12, 'DomPerijon', 2.62, '2017-06-07'),
(13, 'Martini', 2.62, '2017-06-07'),
(14, 'JackDanielsMjaltë', 2.62, '2017-06-07'),
(15, 'Sambuk', 2.62, '2017-06-07'),
(16, 'GjoniWoker', 2.62, '2017-06-07'),
(17, 'Beiles', 2.62, '2017-06-07'),
(18, 'Koktell', 2.62, '2017-06-07'),
(19, 'Jeger', 2.62, '2017-06-07'),
(20, 'Vinë', 6.00, '2017-06-07');

-- --------------------------------------------------------

--
-- Table structure for table `birratstok`
--

CREATE TABLE `birratstok` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Sasia` double NOT NULL,
  `Cmimi` double(10,2) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `birratstok`
--

INSERT INTO `birratstok` (`ID`, `Emri`, `Sasia`, `Cmimi`, `Data`) VALUES
(1, 'BirraPeja', 194, 0.70, '2017-06-07'),
(2, 'BirraTirana', 198, 0.70, '2017-06-07'),
(3, 'BirraLasko', 198, 0.70, '2017-06-07'),
(4, 'BirraMiller', 198, 1.30, '2017-06-08'),
(5, 'BirraCarlsberg', 197, 1.30, '2017-06-08'),
(6, 'BirraShkup', 198, 1.30, '2017-06-08'),
(7, 'BirraSomersby', 197, 1.30, '2017-06-08'),
(8, 'BirraKorça', 195, 1.30, '2017-06-08'),
(9, 'BirraPeroni', 196, 0.70, '2017-06-15'),
(10, 'BirraElbar', 197, 0.70, '2017-06-15'),
(11, 'BirraPejaShishe', 200, 0.70, '2017-06-15'),
(12, 'BirraPrishtinaShishe', 199, 0.70, '2017-06-15'),
(13, 'BirraTuborgShishe', 200, 0.70, '2017-06-15'),
(14, 'BirraMillerShishe', 198, 0.70, '2017-06-15'),
(15, 'BirraNikshiq', 199, 0.70, '2017-06-15'),
(16, 'BirraHeinekenShishe', 200, 0.70, '2017-06-15'),
(17, 'BirraCoronaShishe', 199, 0.70, '2017-06-15'),
(18, 'BirraShkupShishe', 199, 0.70, '2017-06-15'),
(19, 'BirraPeroniShishe', 199, 0.70, '2017-06-15'),
(20, 'BirraAmsteelShishe', 200, 0.70, '2017-06-15');

-- --------------------------------------------------------

--
-- Table structure for table `embelsira`
--

CREATE TABLE `embelsira` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Cmimi` double NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `embelsira`
--

INSERT INTO `embelsira` (`ID`, `Emri`, `Cmimi`, `Data`) VALUES
(1, 'Trileqe', 2, '2017-06-08'),
(2, 'Akullore', 2, '2017-06-08');

-- --------------------------------------------------------

--
-- Table structure for table `kafestok`
--

CREATE TABLE `kafestok` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Cmimi` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kafestok`
--

INSERT INTO `kafestok` (`ID`, `Emri`, `Cmimi`) VALUES
(1, 'Espressoshkurt', 0.50),
(2, 'EspressoGjate', 0.50),
(3, 'EspressoMesme', 0.50),
(4, 'MakiatoMadhe', 0.50),
(5, 'MakiatoVogel', 0.50),
(6, 'Amerikane', 0.50),
(7, 'NessKlasik', 0.50),
(8, 'NessVanille', 0.50),
(9, 'Cappuccino', 0.50),
(10, 'Bambi', 0.50);

-- --------------------------------------------------------

--
-- Table structure for table `klogin`
--

CREATE TABLE `klogin` (
  `ID` int(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klogin`
--

INSERT INTO `klogin` (`ID`, `Username`, `Password`) VALUES
(1, 'kam', 'kam');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`ID`, `Username`, `Password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `picat`
--

CREATE TABLE `picat` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Cmimi` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `picat`
--

INSERT INTO `picat` (`ID`, `Emri`, `Cmimi`) VALUES
(1, 'PicëShpisë', 5.00),
(2, 'PicëNapolitane', 5.00),
(3, 'PicëVieneze', 5.00),
(4, 'PicëMargarita', 5.00),
(5, 'PicëGreke', 5.00),
(6, 'PicëBardhe', 5.00),
(7, 'Picë4Stinet', 5.00),
(8, 'PicëPrimavera', 5.00),
(9, 'PicëSiciliane', 5.00);

-- --------------------------------------------------------

--
-- Table structure for table `pijetstok`
--

CREATE TABLE `pijetstok` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Sasia` double NOT NULL,
  `Cmimi` double(10,2) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pijetstok`
--

INSERT INTO `pijetstok` (`ID`, `Emri`, `Sasia`, `Cmimi`, `Data`) VALUES
(1, 'CocaCola', 192, 0.70, '2017-06-22'),
(2, 'CocaColaZero', 190, 1.00, '2017-06-22'),
(3, 'Fanta', 185, 1.00, '2017-06-22'),
(4, 'Sprite', 185, 1.00, '2017-06-22'),
(5, 'Pepsi', 179, 1.00, '2017-06-22'),
(6, 'DoubleForce', 192, 1.00, '2017-06-22'),
(7, 'GoldenEagle', 192, 1.00, '2017-06-22'),
(8, 'RedBull', 200, 1.00, '2017-06-22'),
(9, 'RedRain', 197, 1.00, '2017-06-22'),
(10, 'Relax', 198, 1.00, '2017-06-22'),
(11, 'Shweps', 197, 0.75, '2017-06-23'),
(12, 'CocaColaShishe', 198, 1.00, '2017-06-08'),
(13, 'FantaShishe', 199, 1.00, '2017-06-08'),
(14, 'ShwepsShishe', 199, 1.00, '2017-06-08'),
(15, 'SpriteShishe', 198, 1.00, '2017-06-08'),
(16, 'Laçin', 198, 1.00, '2017-06-08'),
(17, 'Monster', 199, 1.00, '2017-06-08'),
(18, 'UjëGazuar', 199, 1.00, '2017-06-08'),
(19, 'UjëThjeshtë', 199, 1.00, '2017-06-08'),
(20, 'Koktell', 198, 1.00, '2017-06-08'),
(21, 'Fruktall', 198, 1.00, '2017-06-08'),
(22, 'Sola', 196, 0.30, '2017-06-15'),
(23, 'Juice', 199, 0.30, '2017-06-15'),
(24, 'IceTea', 199, 0.30, '2017-06-15');

-- --------------------------------------------------------

--
-- Table structure for table `shitja`
--

CREATE TABLE `shitja` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Sasia` double NOT NULL,
  `Cmimi` double NOT NULL,
  `Totali` double NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shitja`
--

INSERT INTO `shitja` (`ID`, `Emri`, `Sasia`, `Cmimi`, `Totali`, `Data`) VALUES
(1, 'Espresso e Shkurtë', 1, 0.5, 0.5, '2017-06-20'),
(2, 'Espresso e Gjatë', 1, 0.5, 0.5, '2017-06-20'),
(3, 'Golden Eagle', 1, 1, 1, '2017-06-20'),
(4, 'Birra Elbar', 1, 0.7, 0.7, '2017-06-20'),
(5, 'Birra Korça', 1, 1.3, 1.3, '2017-06-20'),
(6, 'Picë Napolitane', 1, 5, 5, '2017-06-20'),
(7, 'Picë Vieneze', 1, 5, 5, '2017-06-20'),
(8, 'Picë e Shpisë', 1, 5, 5, '2017-06-20'),
(9, 'Picë Napolitane', 1, 5, 5, '2017-06-20'),
(10, 'Picë 4Stinet', 1, 5, 5, '2017-06-20'),
(11, 'Picë Primavera', 1, 5, 5, '2017-06-20'),
(12, 'Picë Margarita', 1, 5, 5, '2017-06-20'),
(13, 'Picë Greke', 1, 5, 5, '2017-06-20'),
(14, 'Picë e Bardhe', 1, 5, 5, '2017-06-20'),
(15, 'Picë Vieneze', 1, 5, 5, '2017-06-20'),
(16, 'Picë Napolitane', 1, 5, 5, '2017-06-20'),
(17, 'Picë e Shpisë', 1, 5, 5, '2017-06-20'),
(18, 'Picë Siciliane', 1, 5, 5, '2017-06-20'),
(19, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-06-20'),
(20, 'Golden Eagle', 1, 1, 1, '2017-06-20'),
(21, 'RedBull', 1, 1, 1, '2017-06-20'),
(22, 'Birra Peroni', 1, 0.7, 0.7, '2017-06-20'),
(23, 'Picë e Shpisë', 1, 5, 5, '2017-06-20'),
(24, 'Picë Napolitane', 1, 5, 5, '2017-06-20'),
(25, 'Picë e Shpisë', 4, 5, 20, '2017-06-20'),
(26, 'Picë Napolitane', 4, 5, 20, '2017-06-20'),
(27, 'Ice Tea', 1, 0.3, 0.3, '2017-06-20'),
(28, 'Juice', 1, 0.3, 0.3, '2017-06-20'),
(29, 'Laçin', 1, 1, 1, '2017-06-20'),
(30, 'Sprite Shishe', 1, 1, 1, '2017-06-20'),
(31, 'Sola', 1, 0.3, 0.3, '2017-06-20'),
(32, 'Koktell', 1, 1, 1, '2017-06-20'),
(33, 'Fruktall', 1, 1, 1, '2017-06-20'),
(34, 'Dom Perijon', 1, 2.62, 2.62, '2017-06-20'),
(35, 'Vinë', 1, 6, 6, '2017-06-20'),
(36, 'Martini', 1, 2.62, 2.62, '2017-06-20'),
(37, 'Jack Daniels', 1, 2.3, 2.3, '2017-06-20'),
(38, 'Jack Daniels Mjaltë', 1, 2.62, 2.62, '2017-06-20'),
(39, 'B52', 1, 2.3, 2.3, '2017-06-20'),
(40, 'Koktell', 1, 2.62, 2.62, '2017-06-20'),
(41, 'Vinë', 1, 6, 6, '2017-06-20'),
(42, 'Martini', 1, 2.62, 2.62, '2017-06-20'),
(43, 'Vodkë e Kuqe', 1, 2.3, 2.3, '2017-06-20'),
(44, 'Smirnoff Vodka', 1, 2.3, 2.3, '2017-06-20'),
(45, 'Smirnoff Ice', 1, 2.3, 2.3, '2017-06-20'),
(46, 'Grey Goose', 1, 2.3, 2.3, '2017-06-20'),
(47, 'Dom Perijon', 1, 2.62, 2.62, '2017-06-20'),
(48, 'Dom Perijon', 1, 2.62, 2.62, '2017-06-20'),
(49, 'Vinë', 1, 6, 6, '2017-06-20'),
(50, 'Martini', 1, 2.62, 2.62, '2017-06-20'),
(51, 'Jack Daniels', 1, 2.3, 2.3, '2017-06-20'),
(52, 'Jack Daniels Mjaltë', 1, 2.62, 2.62, '2017-06-20'),
(53, 'B52', 1, 2.3, 2.3, '2017-06-20'),
(54, 'Koktell', 1, 2.62, 2.62, '2017-06-20'),
(55, 'Vinë', 1, 6, 6, '2017-06-20'),
(56, 'Martini', 1, 2.62, 2.62, '2017-06-20'),
(57, 'Vodkë e Kuqe', 1, 2.3, 2.3, '2017-06-20'),
(58, 'Smirnoff Vodka', 1, 2.3, 2.3, '2017-06-20'),
(59, 'Smirnoff Ice', 1, 2.3, 2.3, '2017-06-20'),
(60, 'Grey Goose', 1, 2.3, 2.3, '2017-06-20'),
(61, 'Dom Perijon', 1, 2.62, 2.62, '2017-06-20'),
(62, 'Hamburger i Bardhë', 1, 0.8, 0.8, '2017-06-22'),
(63, 'Sandwich', 1, 0.8, 0.8, '2017-06-22'),
(64, 'Hamburger Klasik', 1, 0.8, 0.8, '2017-06-22'),
(65, 'Espresso e Shkurtë', 1, 0.5, 0.5, '2017-06-22'),
(66, 'Espresso e Gjatë', 1, 0.5, 0.5, '2017-06-22'),
(67, 'Makiato e Madhe', 1, 0.5, 0.5, '2017-06-22'),
(68, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-06-22'),
(69, 'Espresso e Mesme', 1, 0.5, 0.5, '2017-06-22'),
(70, 'Amerikane', 1, 0.5, 0.5, '2017-06-22'),
(71, 'Cappuccino', 1, 0.5, 0.5, '2017-06-22'),
(72, 'Ness Vanille', 1, 0.5, 0.5, '2017-06-22'),
(73, 'Bambi', 1, 0.5, 0.5, '2017-06-22'),
(74, 'Birra Carlsberg', 1, 1.3, 1.3, '2017-06-22'),
(75, 'Sola', 1, 0.3, 0.3, '2017-06-22'),
(76, 'RedBull', 1, 1, 1, '2017-06-22'),
(77, 'Vodkë e Kuqe', 1, 2.3, 2.3, '2017-06-22'),
(78, 'Makiato e Madhe', 1, 0.5, 0.5, '2017-06-22'),
(79, 'Ness Vanille', 1, 0.5, 0.5, '2017-06-22'),
(80, 'Pepsi', 1, 1, 1, '2017-06-22'),
(81, 'Hamburger Klasik', 1, 0.8, 0.8, '2017-06-22'),
(82, 'Birra Peja', 1, 0.7, 0.7, '2017-06-22'),
(83, 'Trileqe', 1, 2, 2, '2017-06-22'),
(84, 'Raki e Shpisë', 1, 1, 1, '2017-06-22'),
(85, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-06-25'),
(86, 'RedBull', 1, 1, 1, '2017-06-25'),
(87, 'Birra Peja', 1, 0.7, 0.7, '2017-06-25'),
(88, 'Grey Goose', 1, 2.3, 2.3, '2017-06-25'),
(89, 'Picë e Shpisë', 1, 5, 5, '2017-06-25'),
(90, 'Hamburger Klasik', 1, 0.8, 0.8, '2017-06-25'),
(91, 'Tost', 1, 0.8, 0.8, '2017-06-25'),
(92, 'Trileqe', 1, 2, 2, '2017-06-25'),
(93, 'Espresso e Shkurtë', 1, 0.5, 0.5, '2017-11-15'),
(94, 'Espresso e Shkurtë', 1, 0.5, 0.5, '2017-11-15'),
(95, 'Golden Eagle', 1, 1, 1, '2017-11-15'),
(96, 'Pepsi', 1, 1, 1, '2017-11-15'),
(97, 'Shweps', 1, 0.75, 0.75, '2017-11-15'),
(98, 'Vodkë e Kuqe', 1, 2.3, 2.3, '2017-11-15'),
(99, 'Tekilla', 1, 2.62, 2.62, '2017-11-15'),
(100, 'Vinë', 1, 6, 6, '2017-11-15'),
(101, 'Dom Perijon', 1, 2.62, 2.62, '2017-11-15'),
(102, 'Picë Greke', 1, 5, 5, '2017-11-15'),
(103, 'Tost', 1, 0.8, 0.8, '2017-11-15'),
(104, 'Akullore', 1, 2, 2, '2017-11-15'),
(105, 'Makiato e Madhe', 1, 0.5, 0.5, '2017-11-15'),
(106, 'RedBull', 1, 1, 1, '2017-11-15'),
(107, 'Coca Cola Zero', 1, 1, 1, '2017-11-15'),
(108, 'Birra Peja', 1, 0.7, 0.7, '2017-11-15'),
(109, 'Jack Daniels', 1, 2.3, 2.3, '2017-11-15'),
(110, 'Picë Margarita', 1, 5, 5, '2017-11-15'),
(111, 'Hamburger Klasik', 1, 0.8, 0.8, '2017-11-15'),
(112, 'Trileqe', 1, 2, 2, '2017-11-15'),
(113, 'Akullore', 1, 2, 2, '2017-11-15'),
(114, 'Fanta', 1, 1, 1, '2017-11-15'),
(115, 'RedBull', 1, 1, 1, '2017-11-15'),
(116, 'Sola', 1, 0.3, 0.3, '2017-11-15'),
(117, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-11-15'),
(118, 'Ness Vanille', 1, 0.5, 0.5, '2017-11-15'),
(119, 'Ness Klasik', 1, 0.5, 0.5, '2017-11-15'),
(120, 'Picë e Bardhe', 1, 5, 5, '2017-11-15'),
(121, 'Picë Vieneze', 1, 5, 5, '2017-11-15'),
(122, 'Akullore', 1, 2, 2, '2017-11-15'),
(123, 'Fanta', 1, 1, 1, '2017-11-15'),
(124, 'RedBull', 1, 1, 1, '2017-11-15'),
(125, 'Sola', 1, 0.3, 0.3, '2017-11-15'),
(126, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-11-15'),
(127, 'Ness Vanille', 1, 0.5, 0.5, '2017-11-15'),
(128, 'Ness Klasik', 1, 0.5, 0.5, '2017-11-15'),
(129, 'Akullore', 1, 2, 2, '2017-11-15'),
(130, 'Fanta', 1, 1, 1, '2017-11-15'),
(131, 'RedBull', 1, 1, 1, '2017-11-15'),
(132, 'Sola', 1, 0.3, 0.3, '2017-11-15'),
(133, 'Makiato e Vogel', 1, 0.5, 0.5, '2017-11-15'),
(134, 'Ness Vanille', 1, 0.5, 0.5, '2017-11-15'),
(135, 'Ness Klasik', 1, 0.5, 0.5, '2017-11-15');

-- --------------------------------------------------------

--
-- Table structure for table `ushqimet`
--

CREATE TABLE `ushqimet` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `Cmimi` double(10,2) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ushqimet`
--

INSERT INTO `ushqimet` (`ID`, `Emri`, `Cmimi`, `Data`) VALUES
(1, 'HamburgerKlasik', 0.80, '2017-06-06'),
(2, 'HamburgerBardhë', 0.80, '2017-06-06'),
(3, 'Sandwich', 0.80, '2017-06-06'),
(4, 'Qebapa', 0.80, '2017-06-06'),
(5, 'HotDog', 0.80, '2017-06-06'),
(6, 'Djathë', 0.80, '2017-06-06'),
(7, 'SallatëShope', 0.80, '2017-06-06'),
(8, 'Pulë', 0.80, '2017-06-06'),
(9, 'Sugjukë', 0.80, '2017-06-06'),
(10, 'BurekMish', 0.80, '2017-06-06'),
(11, 'BurekDjathë', 0.80, '2017-06-06'),
(12, 'Tost', 0.80, '2017-06-06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alkool`
--
ALTER TABLE `alkool`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `birratstok`
--
ALTER TABLE `birratstok`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `embelsira`
--
ALTER TABLE `embelsira`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `kafestok`
--
ALTER TABLE `kafestok`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `klogin`
--
ALTER TABLE `klogin`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `picat`
--
ALTER TABLE `picat`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pijetstok`
--
ALTER TABLE `pijetstok`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shitja`
--
ALTER TABLE `shitja`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `ushqimet`
--
ALTER TABLE `ushqimet`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alkool`
--
ALTER TABLE `alkool`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `birratstok`
--
ALTER TABLE `birratstok`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `embelsira`
--
ALTER TABLE `embelsira`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `kafestok`
--
ALTER TABLE `kafestok`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `klogin`
--
ALTER TABLE `klogin`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `picat`
--
ALTER TABLE `picat`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `pijetstok`
--
ALTER TABLE `pijetstok`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `shitja`
--
ALTER TABLE `shitja`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;
--
-- AUTO_INCREMENT for table `ushqimet`
--
ALTER TABLE `ushqimet`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
