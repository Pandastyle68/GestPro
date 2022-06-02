-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 02 juin 2022 à 15:01
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdd_progest`
--

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `idEmploye` int(11) NOT NULL,
  `idProduit` int(11) NOT NULL,
  `quantite` int(11) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`numero`,`date`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`numero`, `idEmploye`, `idProduit`, `quantite`, `date`) VALUES
(1, 2, 2, 10, '2022-06-02'),
(2, 2, 2, 20, '2022-06-01'),
(3, 2, 1, 10, '2022-06-01'),
(4, 1, 2, 20, '2022-06-01'),
(5, 2, 2, 25, '2022-06-02');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

DROP TABLE IF EXISTS `employe`;
CREATE TABLE IF NOT EXISTS `employe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `employe`
--

INSERT INTO `employe` (`id`, `nom`, `prenom`, `tel`, `email`) VALUES
(1, 'Delatarte', 'Tom', '0755489611', 'tomdel@gmail.com'),
(2, 'Celik', 'Melihsah', '0651497532', 'melihcelik@gmail.fr'),
(3, 'Claudius', 'Jean', '0745785432', 'JeanClaude@gmail.fr'),
(4, 'Dumont', 'Arnaud', '0768549421', 'arnauddumont@outlook.com');

-- --------------------------------------------------------

--
-- Structure de la table `fidele`
--

DROP TABLE IF EXISTS `fidele`;
CREATE TABLE IF NOT EXISTS `fidele` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `dateNaissance` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `fidele`
--

INSERT INTO `fidele` (`id`, `nom`, `prenom`, `dateNaissance`) VALUES
(1, 'Claudius', 'Jean', '1998-05-21'),
(2, 'Auguste', 'Gérard', '1989-04-25');

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `adresse` varchar(200) NOT NULL,
  `pays` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`id`, `nom`, `adresse`, `pays`) VALUES
(1, 'Lutti', 'Bondues', 'France'),
(2, 'Ferrero', 'Mont-Saint-Aignan', 'France'),
(3, 'Nestle', 'Vevey', 'Suisse'),
(4, 'BN', 'Nantes', 'France');

-- --------------------------------------------------------

--
-- Structure de la table `occupe`
--

DROP TABLE IF EXISTS `occupe`;
CREATE TABLE IF NOT EXISTS `occupe` (
  `idEmploye` int(11) NOT NULL,
  `idPoste` int(11) NOT NULL,
  PRIMARY KEY (`idEmploye`,`idPoste`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `occupe`
--

INSERT INTO `occupe` (`idEmploye`, `idPoste`) VALUES
(2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `poste`
--

DROP TABLE IF EXISTS `poste`;
CREATE TABLE IF NOT EXISTS `poste` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `poste`
--

INSERT INTO `poste` (`id`, `libelle`) VALUES
(1, 'Directeur général'),
(2, 'Directeur technique'),
(3, 'Directeur des ressources humaines'),
(4, 'Employé');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) NOT NULL,
  `poids` float NOT NULL,
  `stock` int(11) NOT NULL,
  `prixAchat` float NOT NULL,
  `prixVente` float NOT NULL,
  `idFournisseur` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`id`, `libelle`, `poids`, `stock`, `prixAchat`, `prixVente`, `idFournisseur`) VALUES
(1, 'Bonbon acidulé', 225, 10, 1.02, 1.97, 1),
(2, 'Maxi Chocolat', 231, 15, 1.23, 2.15, 2),
(10, 'Bueno', 250, 20, 1.09, 1.99, 2),
(9, 'Country', 150, 25, 0.4, 1.5, 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
