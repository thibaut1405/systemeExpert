-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 25 juin 2019 à 14:44
-- Version du serveur :  5.7.19
-- Version de PHP :  7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `formes`
--

-- --------------------------------------------------------

--
-- Structure de la table `data`
--

DROP TABLE IF EXISTS `data`;
CREATE TABLE IF NOT EXISTS `data` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NbCotes` int(11) NOT NULL,
  `NbCotesPara` int(11) NOT NULL,
  `NbCotesEgaux` int(11) NOT NULL,
  `NbAnglesDroits` int(11) NOT NULL,
  `nomFigure` varchar(250) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `data`
--

INSERT INTO `data` (`ID`, `NbCotes`, `NbCotesPara`, `NbCotesEgaux`, `NbAnglesDroits`, `nomFigure`) VALUES
(27, 3, 0, 0, 0, 'Triangle quelconque'),
(28, 3, 0, 3, 0, 'Triangle equilatéral'),
(29, 3, 0, 0, 2, 'Forme impossible'),
(30, 3, 0, 3, 2, 'Forme impossible'),
(31, 5, 0, 0, 0, 'Pentagone quelconque'),
(32, 5, 0, 5, 0, 'Pentagone parfait'),
(33, 5, 0, 5, 2, 'Pentagone quelconque');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
