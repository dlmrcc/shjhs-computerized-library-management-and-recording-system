-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema sacred
--

CREATE DATABASE IF NOT EXISTS sacred;
USE sacred;

--
-- Definition of table `book`
--

DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `bookid` int(10) unsigned NOT NULL auto_increment,
  `date` date NOT NULL,
  `title` varchar(100) NOT NULL,
  `edition` varchar(10) NOT NULL,
  `copy` varchar(3) NOT NULL,
  `publisher` varchar(50) NOT NULL,
  `year` int(10) unsigned NOT NULL,
  `remarks` varchar(3) NOT NULL,
  `author` varchar(80) NOT NULL,
  PRIMARY KEY  (`bookid`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book`
--

/*!40000 ALTER TABLE `book` DISABLE KEYS */;
INSERT INTO `book` (`bookid`,`date`,`title`,`edition`,`copy`,`publisher`,`year`,`remarks`,`author`) VALUES 
 (1,'2012-08-09','Modern English In Action','First','1','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (2,'2012-08-09','Modern English In Action','First','2','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (3,'2012-08-09','Modern English In Action','First','3','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (4,'2012-08-09','Modern English In Action','First','4','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (5,'2012-08-09','Modern English In Action','First','5','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (6,'2012-08-09','Modern English In Action','First','6','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (7,'2012-08-09','Modern English In Action','First','7','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (8,'2012-08-09','Modern English In Action','First','8','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (9,'2012-08-09','Modern English In Action','First','9','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (10,'2012-08-10','Better English','First','1','Phoenix Publishing House, Inc.',2000,'New','Josephine B. Serrano');
INSERT INTO `book` (`bookid`,`date`,`title`,`edition`,`copy`,`publisher`,`year`,`remarks`,`author`) VALUES 
 (11,'2012-08-10','Better English','First','2','Phoenix Publishing House, Inc.',2000,'New','Josephine B. Serrano'),
 (12,'2012-08-10','Better English','First','3','Phoenix Publishing House, Inc.',2000,'New','Josephine B. Serrano'),
 (13,'2012-08-10','Better English','First','4','Phoenix Publishing House, Inc.',2000,'New','Josephine B. Serrano'),
 (14,'2012-08-11','Modern English In Action','First','10','D. C. Health and Co.',1995,'New','Henry I. Christ'),
 (15,'2012-08-11','English Coom. Arts & Skills Thru Anglo-American & Fil. Lit. 111','First','1','Phoenix Press Inc.',2006,'New','Josephine B. Serrano'),
 (16,'2012-08-11','English Coom. Arts & Skills Thru Anglo-American & Fil. Lit. 111','First','2','Phoenix Press Inc.',2006,'New','Josephine B. Serrano'),
 (17,'2012-08-11','English Coom. Arts & Skills Thru Anglo-American & Fil. Lit. 111','First','3','Phoenix Press Inc.',2006,'New','Josephine B. Serrano'),
 (18,'2012-08-11','English Coom. Arts & Skills Thru Anglo-American & Fil. Lit. 111','First','4','Phoenix Press Inc.',2006,'New','Josephine B. Serrano');
INSERT INTO `book` (`bookid`,`date`,`title`,`edition`,`copy`,`publisher`,`year`,`remarks`,`author`) VALUES 
 (19,'2012-08-12','Communicate in English IV','First','1','Philippine Book Co.',1998,'New','Josefina Payawal Gabriel'),
 (20,'2012-08-12','Communicate in English IV','First','2','Philippine Book Co.',1998,'New','Josefina Payawal Gabriel'),
 (21,'2012-08-12','Communicate in English IV','First','3','Philippine Book Co.',1998,'New','Josefina Payawal Gabriel'),
 (22,'2012-08-12','Communicate in English IV','First','4','Philippine Book Co.',1998,'New','Josefina Payawal Gabriel'),
 (23,'2012-08-12','Communicate in English IV','First','5','Philippine Book Co.',1998,'New','Josefina Payawal Gabriel'),
 (24,'2012-08-15','gawa gawang aklat','1','1','psu bahay kubo',2012,'New','lopez, tabang, bravo'),
 (25,'2012-08-15','gawa gawang aklat','1','2','psu bahay kubo',2012,'New','lopez, tabang, bravo'),
 (26,'2012-08-15','gawa gawang aklat','1','3','psu bahay kubo',2012,'New','lopez, tabang, bravo'),
 (27,'2012-08-15','gawa gawang aklat','1','4','psu bahay kubo',2012,'New','lopez, tabang, bravo');
INSERT INTO `book` (`bookid`,`date`,`title`,`edition`,`copy`,`publisher`,`year`,`remarks`,`author`) VALUES 
 (28,'2012-08-15','gawa gawang aklat','1','5','psu bahay kubo',2012,'New','lopez, tabang, bravo'),
 (29,'2012-08-17','Language for Daily use','First','1','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (30,'2012-08-17','Language for Daily use','First','2','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (31,'2012-08-17','Language for Daily use','First','3','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (32,'2012-08-17','Language for Daily use','First','4','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (33,'2012-08-17','Language for Daily use','First','5','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (34,'2012-08-17','Language for Daily use','First','6','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (35,'2012-08-17','Language for Daily use','First','7','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (36,'2012-08-17','Language for Daily use','First','8','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson');
INSERT INTO `book` (`bookid`,`date`,`title`,`edition`,`copy`,`publisher`,`year`,`remarks`,`author`) VALUES 
 (37,'2012-08-17','Language for Daily use','First','9','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (38,'2012-08-17','Language for Daily use','First','10','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (39,'2012-08-17','Language for Daily use','First','11','Poenix Publishing House,Inc',2000,'New','Mildred A. Dawson'),
 (40,'2012-08-17','Algebra','First','1','adaadada',2012,'New','Davy'),
 (41,'2012-08-17','Algebra','First','2','adaadada',2012,'New','Davy'),
 (42,'2012-08-17','Algebra','First','3','adaadada',2012,'New','Davy'),
 (43,'2012-08-17','Algebra','First','4','adaadada',2012,'New','Davy'),
 (44,'2012-08-17','Algebra','First','5','adaadada',2012,'New','Davy');
/*!40000 ALTER TABLE `book` ENABLE KEYS */;


--
-- Definition of table `borrow`
--

DROP TABLE IF EXISTS `borrow`;
CREATE TABLE `borrow` (
  `borrowid` int(10) unsigned NOT NULL auto_increment,
  `userid` varchar(15) NOT NULL,
  `bookid` int(10) unsigned NOT NULL,
  `borrowerid` varchar(20) NOT NULL,
  `dateborrow` datetime NOT NULL,
  `datereturn` datetime default NULL,
  `billingflag` varchar(6) NOT NULL,
  `reserveflag` varchar(3) NOT NULL,
  `rate` double NOT NULL,
  `expecteddatereturn` datetime NOT NULL,
  PRIMARY KEY  (`borrowid`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrow`
--

/*!40000 ALTER TABLE `borrow` DISABLE KEYS */;
INSERT INTO `borrow` (`borrowid`,`userid`,`bookid`,`borrowerid`,`dateborrow`,`datereturn`,`billingflag`,`reserveflag`,`rate`,`expecteddatereturn`) VALUES 
 (13,'U-2012-01',40,'09-4411-23','2012-09-17 16:43:54',NULL,'Unpaid','No',2,'2012-09-24 16:43:54'),
 (14,'U-2012-01',10,'09-4411-23','2012-09-27 21:44:20',NULL,'Unpaid','No',2,'2012-10-01 21:44:20');
/*!40000 ALTER TABLE `borrow` ENABLE KEYS */;


--
-- Definition of table `borrower`
--

DROP TABLE IF EXISTS `borrower`;
CREATE TABLE `borrower` (
  `borrowerid` varchar(20) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `mname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `connum` varchar(15) NOT NULL,
  `address` varchar(80) NOT NULL,
  `borrowertype` varchar(7) NOT NULL,
  PRIMARY KEY  (`borrowerid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrower`
--

/*!40000 ALTER TABLE `borrower` DISABLE KEYS */;
INSERT INTO `borrower` (`borrowerid`,`fname`,`mname`,`lname`,`connum`,`address`,`borrowertype`) VALUES 
 ('09-4411-23','Lanie','D','Flores','09082764041','Barongbarong, Brooke\'s Point Palawan','Student'),
 ('123asd','Sacred','Heart','Jesus','143','In your heart','Student'),
 ('20001','menchie','oo','lopez','09999999999','kahitsanlang, sangasangang daan','Student'),
 ('2000AP','Hedeki','Y','Matchunaga','09997296124','Moreno Brooke\'s Point Palawan','Student'),
 ('20012AD','Zshyle joy','De Asis','Malacad','09085619627','Aborlan Palawan','Student'),
 ('2001BP','Helen','S','Austria','09213869951','BarongBarong Brooke\'s Point Palawan','Teacher'),
 ('2008-10-3894BP','Go','Yap','Lee','0934598293','Suring, Brooke\'s Point Palawan','Teacher'),
 ('200a','Bravo','P','Regina','09997276124','Barongbarong Brooke\'s Point','Student'),
 ('2011AH','Joemark','David','Karaw','09105812527','Puring Bataraza','Teacher'),
 ('25645a','Mantos','Gaga','Linogao','09090876543','Likoliko Street Di matagpuan city','Teacher'),
 ('34324','Angela','Delos Reyes','Santos','09090909090','Buligay','Student');
/*!40000 ALTER TABLE `borrower` ENABLE KEYS */;


--
-- Definition of table `borrowertype`
--

DROP TABLE IF EXISTS `borrowertype`;
CREATE TABLE `borrowertype` (
  `borrowertypeid` int(10) unsigned NOT NULL auto_increment,
  `borrowertype` varchar(10) NOT NULL,
  `rate` double NOT NULL,
  `bookvalue` double NOT NULL,
  `finestype` varchar(8) NOT NULL,
  `finestart` varchar(3) NOT NULL,
  PRIMARY KEY  (`borrowertypeid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrowertype`
--

/*!40000 ALTER TABLE `borrowertype` DISABLE KEYS */;
INSERT INTO `borrowertype` (`borrowertypeid`,`borrowertype`,`rate`,`bookvalue`,`finestype`,`finestart`) VALUES 
 (1,'Student',2,3,'Active','Mon'),
 (2,'Teacher',0,10,'Inactive','Mon');
/*!40000 ALTER TABLE `borrowertype` ENABLE KEYS */;


--
-- Definition of table `loghis`
--

DROP TABLE IF EXISTS `loghis`;
CREATE TABLE `loghis` (
  `logid` varchar(10) NOT NULL,
  `userid` varchar(45) NOT NULL,
  `login` datetime NOT NULL,
  `logout` datetime default NULL,
  PRIMARY KEY  (`logid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `loghis`
--

/*!40000 ALTER TABLE `loghis` DISABLE KEYS */;
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00001','U-2012-01','2012-07-10 01:38:45','2012-07-10 01:39:01'),
 ('2012-00002','U-2012-01','2012-07-29 00:36:59','2012-07-29 00:44:50'),
 ('2012-00003','U-2012-01','2012-07-29 00:45:23','2012-07-29 00:46:26'),
 ('2012-00004','U-2012-01','2012-07-29 00:47:36','2012-07-29 00:48:23'),
 ('2012-00005','U-2012-01','2012-08-07 07:10:30','2012-08-07 07:10:38'),
 ('2012-00006','U-2012-01','2012-08-07 07:10:42','2012-08-07 07:11:01'),
 ('2012-00007','U-2012-01','2012-08-07 07:12:22','2012-08-07 07:13:00'),
 ('2012-00008','U-2012-01','2012-08-07 07:13:06','2012-08-07 07:15:03'),
 ('2012-00009','U-2012-01','2012-08-07 07:18:12','2012-08-07 07:20:52'),
 ('2012-00010','U-2012-01','2012-08-07 07:26:43','2012-08-07 07:52:49'),
 ('2012-00011','U-2012-01','2012-08-07 08:18:43','2012-08-07 08:19:21'),
 ('2012-00012','U-2012-01','2012-08-07 08:19:23','2012-08-07 08:20:39'),
 ('2012-00013','U-2012-01','2012-08-07 08:20:40','2012-08-07 08:20:59'),
 ('2012-00014','U-2012-01','2012-08-07 08:21:58','2012-08-07 08:22:52');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00015','U-2012-01','2012-08-07 08:22:53','2012-08-07 08:23:22'),
 ('2012-00016','U-2012-01','2012-08-07 08:25:13','2012-08-07 08:25:35'),
 ('2012-00017','U-2012-01','2012-08-07 08:25:36','2012-08-07 08:27:06'),
 ('2012-00018','U-2012-01','2012-08-07 08:27:09','2012-08-07 08:27:19'),
 ('2012-00019','U-2012-01','2012-08-07 08:39:25','2012-08-07 08:41:04'),
 ('2012-00020','U-2012-01','2012-08-07 08:41:06','2012-08-07 08:43:48'),
 ('2012-00021','U-2012-01','2012-08-07 08:43:48','2012-08-09 21:12:51'),
 ('2012-00022','U-2012-01','2012-08-09 21:34:50','2012-08-09 21:36:28'),
 ('2012-00023','U-2012-01','2012-08-09 22:13:31','2012-08-09 22:54:16'),
 ('2012-00024','U-2012-01','2012-08-09 22:54:18','2012-08-09 22:55:12'),
 ('2012-00025','U-2012-01','2012-08-09 22:55:14','2012-08-09 22:56:36'),
 ('2012-00026','U-2012-01','2012-08-09 23:04:50','2012-08-09 23:10:44'),
 ('2012-00027','U-2012-01','2012-08-09 23:10:45','2012-08-09 23:11:13'),
 ('2012-00028','U-2012-01','2012-08-09 23:11:16','2012-08-09 23:24:23');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00029','U-2012-01','2012-08-09 23:24:25','2012-08-09 23:25:27'),
 ('2012-00030','U-2012-01','2012-08-09 23:25:32','2012-08-09 23:30:03'),
 ('2012-00031','U-2012-01','2012-08-09 23:30:05','2012-08-09 23:31:50'),
 ('2012-00032','U-2012-01','2012-08-09 23:32:16','2012-08-10 00:23:03'),
 ('2012-00033','U-2012-01','2012-08-10 00:23:05','2012-08-10 00:23:43'),
 ('2012-00034','U-2012-01','2012-08-10 00:23:45','2012-08-10 00:24:26'),
 ('2012-00035','U-2012-01','2012-08-10 00:24:28','2012-08-10 00:27:15'),
 ('2012-00036','U-2012-01','2012-08-10 00:27:18','2012-08-10 00:43:19'),
 ('2012-00037','U-2012-01','2012-08-10 05:48:27','2012-08-10 05:48:33'),
 ('2012-00038','U-2012-01','2012-08-10 06:00:51','2012-08-10 06:04:08'),
 ('2012-00039','U-2012-01','2012-08-10 06:04:10','2012-08-10 06:08:21'),
 ('2012-00040','U-2012-01','2012-08-10 06:08:23','2012-08-10 07:11:05'),
 ('2012-00041','U-2012-01','2012-08-10 07:11:48','2012-08-10 07:12:14'),
 ('2012-00042','U-2012-01','2012-08-10 07:22:55','2012-08-10 07:23:53');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00043','U-2012-01','2012-08-10 07:24:37','2012-08-10 07:25:01'),
 ('2012-00044','U-2012-02','2012-08-10 07:25:14','2012-08-10 07:34:45'),
 ('2012-00045','U-2012-01','2012-08-10 07:34:56','2012-08-10 07:35:42'),
 ('2012-00046','U-2012-01','2012-08-10 07:35:53','2012-08-10 08:57:02'),
 ('2012-00047','U-2012-01','2012-08-10 09:17:53','2012-08-10 15:34:46'),
 ('2012-00048','U-2012-01','2012-08-10 16:00:11','2012-08-10 16:06:08'),
 ('2012-00049','U-2012-01','2012-08-11 00:02:06','2012-08-11 00:11:17'),
 ('2012-00050','U-2012-01','2012-08-11 00:11:17','2012-08-11 00:12:22'),
 ('2012-00051','U-2012-01','2012-08-11 00:12:22','2012-08-11 00:13:13'),
 ('2012-00052','U-2012-01','2012-08-11 00:13:13','2012-08-11 00:27:28'),
 ('2012-00053','U-2012-01','2012-08-11 00:27:28','2012-08-11 00:31:12'),
 ('2012-00054','U-2012-01','2012-08-11 00:31:12','2012-08-11 00:32:00'),
 ('2012-00055','U-2012-01','2012-08-11 00:32:00','2012-08-11 00:32:52'),
 ('2012-00056','U-2012-01','2012-08-11 00:32:53','2012-08-11 00:32:57');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00057','U-2012-01','2012-08-11 00:32:57','2012-08-11 00:33:34'),
 ('2012-00058','U-2012-01','2012-08-11 00:33:36','2012-08-11 00:33:38'),
 ('2012-00059','U-2012-01','2012-08-11 00:33:47','2012-08-11 00:38:38'),
 ('2012-00060','U-2012-01','2012-08-11 00:38:40','2012-08-11 00:38:47'),
 ('2012-00061','U-2012-01','2012-08-11 01:00:55','2012-08-11 01:01:36'),
 ('2012-00062','U-2012-01','2012-08-11 01:03:02','2012-08-11 01:03:20'),
 ('2012-00063','U-2012-01','2012-08-11 01:03:47','2012-08-11 01:04:28'),
 ('2012-00064','U-2012-01','2012-08-11 01:04:49','2012-08-11 01:05:52'),
 ('2012-00065','U-2012-01','2012-08-11 12:07:35','2012-08-11 12:07:44'),
 ('2012-00066','U-2012-01','2012-08-11 12:08:12','2012-08-11 12:17:36'),
 ('2012-00067','U-2012-01','2012-08-11 12:17:38','2012-08-11 12:21:14'),
 ('2012-00068','U-2012-01','2012-08-11 12:34:40','2012-08-11 12:37:14'),
 ('2012-00069','U-2012-01','2012-08-11 12:37:15','2012-08-11 12:43:31'),
 ('2012-00070','U-2012-01','2012-08-11 12:43:33','2012-08-11 12:53:22');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00071','U-2012-01','2012-08-11 12:53:24','2012-08-11 12:53:45'),
 ('2012-00072','U-2012-01','2012-08-11 17:09:20','2012-08-11 17:12:25'),
 ('2012-00073','U-2012-01','2012-08-11 17:12:26','2012-08-11 17:29:57'),
 ('2012-00074','U-2012-01','2012-08-11 17:30:32','2012-08-11 17:31:31'),
 ('2012-00075','U-2012-01','2012-08-11 17:31:32','2012-08-11 17:32:46'),
 ('2012-00076','U-2012-01','2012-08-11 17:32:48','2012-08-11 20:51:24'),
 ('2012-00077','U-2012-01','2012-08-11 20:51:29','2012-08-11 20:53:57'),
 ('2012-00078','U-2012-01','2012-08-11 20:53:58','2012-08-11 21:00:41'),
 ('2012-00079','U-2012-01','2012-08-11 21:01:39','2012-08-11 21:01:52'),
 ('2012-00080','U-2012-01','2012-08-11 21:13:51','2012-08-11 21:14:17'),
 ('2012-00081','U-2012-01','2012-08-11 21:27:35','2012-08-11 21:29:59'),
 ('2012-00082','U-2012-01','2012-08-11 21:30:01','2012-08-11 22:27:38'),
 ('2012-00083','U-2012-01','2012-08-11 22:27:40','2012-08-11 23:02:19'),
 ('2012-00084','U-2012-01','2012-08-11 23:02:21','2012-08-11 23:02:57');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00085','U-2012-01','2012-08-11 23:06:09','2012-08-11 23:25:49'),
 ('2012-00086','U-2012-01','2012-08-11 23:26:28','2012-08-11 23:32:57'),
 ('2012-00087','U-2012-01','2012-08-11 23:33:00','2012-08-12 00:27:33'),
 ('2012-00088','U-2012-01','2012-08-12 00:27:36','2012-08-12 00:28:27'),
 ('2012-00089','U-2012-01','2012-08-12 00:28:29','2012-08-12 06:03:59'),
 ('2012-00090','U-2012-01','2012-08-12 06:04:01','2012-08-12 06:23:30'),
 ('2012-00091','U-2012-01','2012-08-12 06:23:32','2012-08-12 06:25:13'),
 ('2012-00092','U-2012-01','2012-08-12 06:25:29','2012-08-12 06:25:55'),
 ('2012-00093','U-2012-01','2012-08-12 06:59:46','2012-08-12 07:02:46'),
 ('2012-00094','U-2012-01','2012-08-12 07:11:13','2012-08-12 07:11:54'),
 ('2012-00095','U-2012-01','2012-08-12 17:09:53','2012-08-12 17:20:53'),
 ('2012-00096','U-2012-01','2012-08-12 17:21:03','2012-08-12 17:22:33'),
 ('2012-00097','U-2012-01','2012-08-12 18:31:32','2012-08-12 18:35:16'),
 ('2012-00098','U-2012-01','2012-08-12 18:35:22','2012-08-12 18:35:38');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00099','U-2012-01','2012-08-12 18:37:05','2012-08-12 18:59:51'),
 ('2012-00100','U-2012-01','2012-08-12 19:02:27','2012-08-12 19:10:52'),
 ('2012-00101','U-2012-01','2012-08-12 19:18:24','2012-08-12 19:18:34'),
 ('2012-00102','U-2012-01','2012-08-12 23:27:35','2012-08-12 23:28:06'),
 ('2012-00103','U-2012-01','2012-08-13 12:38:53','2012-08-13 12:40:58'),
 ('2012-00104','U-2012-01','2012-08-13 12:41:05','2012-08-13 12:41:39'),
 ('2012-00105','U-2012-01','2012-08-13 12:41:42','2012-08-13 12:41:57'),
 ('2012-00106','U-2012-01','2012-08-13 12:43:01','2012-08-13 12:43:11'),
 ('2012-00107','U-2012-01','2012-08-13 14:20:51','2012-08-13 14:23:52'),
 ('2012-00108','U-2012-01','2012-08-13 14:23:54','2012-08-13 14:26:26'),
 ('2012-00109','U-2012-01','2012-08-13 14:26:29','2012-08-13 14:26:46'),
 ('2012-00110','U-2012-01','2012-08-13 14:27:49','2012-08-13 14:29:51'),
 ('2012-00111','U-2012-01','2012-08-13 14:32:31','2012-08-13 14:57:42'),
 ('2012-00112','U-2012-01','2012-08-13 14:57:44','2012-08-13 14:58:14');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00113','U-2012-01','2012-08-13 14:59:12','2012-08-13 14:59:22'),
 ('2012-00114','U-2012-01','2012-08-13 15:14:45','2012-08-13 15:29:45'),
 ('2012-00115','U-2012-01','2012-08-13 15:29:47','2012-08-13 18:22:47'),
 ('2012-00116','U-2012-01','2012-08-13 18:23:18','2012-08-13 18:24:17'),
 ('2012-00117','U-2012-01','2012-08-13 21:52:22','2012-08-13 21:52:47'),
 ('2012-00118','U-2012-01','2012-08-13 21:54:28','2012-08-13 21:55:36'),
 ('2012-00119','U-2012-01','2012-08-14 12:12:10','2012-08-14 12:14:09'),
 ('2012-00120','U-2012-01','2012-08-14 12:14:46','2012-08-14 12:15:57'),
 ('2012-00121','U-2012-01','2012-08-14 12:18:27','2012-08-14 12:22:11'),
 ('2012-00122','U-2012-01','2012-08-14 16:03:28','2012-08-14 16:03:48'),
 ('2012-00123','U-2012-01','2012-08-14 16:09:33','2012-08-14 17:56:54'),
 ('2012-00124','U-2012-01','2012-08-14 17:57:10','2012-08-14 23:30:52'),
 ('2012-00125','U-2012-01','2012-08-15 00:27:32','2012-08-15 00:28:55'),
 ('2012-00126','U-2012-01','2012-08-15 00:30:00','2012-08-15 00:31:07');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00127','U-2012-01','2012-08-15 01:01:17','2012-08-15 01:01:59'),
 ('2012-00128','U-2012-01','2012-08-15 08:04:50','2012-08-15 08:05:42'),
 ('2012-00129','U-2012-01','2012-08-15 08:09:39','2012-08-15 08:10:05'),
 ('2012-00130','U-2012-01','2012-08-15 08:26:20','2012-08-15 08:27:06'),
 ('2012-00131','U-2012-01','2012-08-15 08:27:24','2012-08-15 08:27:59'),
 ('2012-00132','U-2012-01','2012-08-15 13:58:56','2012-08-15 13:59:50'),
 ('2012-00133','U-2012-01','2012-08-15 14:01:38','2012-08-15 14:02:00'),
 ('2012-00134','U-2012-01','2012-08-15 14:39:42','2012-08-15 14:39:50'),
 ('2012-00135','U-2012-01','2012-08-15 15:39:29','2012-08-15 15:39:49'),
 ('2012-00136','U-2012-02','2012-08-15 16:16:58','2012-08-15 16:17:08'),
 ('2012-00137','U-2012-02','2012-08-15 16:17:44','2012-08-15 16:17:51'),
 ('2012-00138','U-2012-02','2012-08-15 16:19:50','2012-08-15 16:20:21'),
 ('2012-00139','U-2012-01','2012-08-15 16:20:45','2012-08-15 16:58:29'),
 ('2012-00140','U-2012-01','2012-08-15 17:59:37','2012-08-15 18:16:34');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00141','U-2012-01','2012-08-15 18:26:12','2012-08-15 18:36:06'),
 ('2012-00142','U-2012-01','2012-08-15 18:36:23','2012-08-15 18:46:32'),
 ('2012-00143','U-2012-01','2012-08-15 18:46:45','2012-08-15 19:10:56'),
 ('2012-00144','U-2012-01','2012-08-15 19:11:44','2012-08-15 19:19:50'),
 ('2012-00145','U-2012-01','2012-08-15 19:21:24','2012-08-15 19:22:09'),
 ('2012-00146','U-2012-01','2012-08-15 21:25:52','2012-08-15 21:26:55'),
 ('2012-00147','U-2012-01','2012-08-15 21:49:50','2012-08-15 22:09:25'),
 ('2012-00148','U-2012-01','2012-08-16 17:36:05','2012-08-16 17:36:20'),
 ('2012-00149','U-2012-01','2012-08-16 20:27:07','2012-08-16 20:45:10'),
 ('2012-00150','U-2012-01','2012-08-16 20:45:25','2012-08-16 20:46:07'),
 ('2012-00151','U-2012-01','2012-08-16 20:57:50','2012-08-16 20:59:18'),
 ('2012-00152','U-2012-01','2012-08-17 10:54:04','2012-08-17 10:58:28'),
 ('2012-00153','U-2012-01','2012-08-17 10:58:42','2012-08-17 10:59:54'),
 ('2012-00154','U-2012-01','2012-08-17 11:00:08','2012-08-17 11:02:47');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00155','U-2012-01','2012-08-17 11:03:10','2012-08-17 11:05:34'),
 ('2012-00156','U-2012-01','2012-08-17 11:05:47','2012-08-17 11:06:30'),
 ('2012-00157','U-2012-01','2012-08-17 11:06:45','2012-08-17 11:09:25'),
 ('2012-00158','U-2012-01','2012-08-17 11:09:40','2012-08-17 11:37:34'),
 ('2012-00159','U-2012-01','2012-08-17 11:37:58','2012-08-17 11:57:39'),
 ('2012-00160','U-2012-01','2012-08-17 14:11:11','2012-08-17 17:10:16'),
 ('2012-00161','U-2012-01','2012-08-17 17:11:17','2012-08-17 17:11:48'),
 ('2012-00162','U-2012-01','2012-08-17 17:12:38','2012-08-17 17:19:08'),
 ('2012-00163','U-2012-04','2012-08-17 17:19:29','2012-08-17 17:20:08'),
 ('2012-00164','U-2012-01','2012-08-17 17:20:26','2012-08-17 17:20:58'),
 ('2012-00165','U-2012-01','2012-08-17 17:21:36','2012-08-17 18:07:52'),
 ('2012-00166','U-2012-01','2012-09-15 08:58:47','2012-09-15 09:10:38'),
 ('2012-00167','U-2012-01','2012-09-15 09:11:17','2012-09-15 09:13:57'),
 ('2012-00168','U-2012-01','2012-09-15 09:13:58','2012-09-15 16:37:52');
INSERT INTO `loghis` (`logid`,`userid`,`login`,`logout`) VALUES 
 ('2012-00169','U-2012-01','2012-09-15 16:37:55','2012-09-15 16:39:22'),
 ('2012-00170','U-2012-01','2012-09-15 16:39:24','2012-09-15 16:43:15'),
 ('2012-00171','U-2012-01','2012-09-15 16:43:16','2012-09-15 16:44:16'),
 ('2012-00172','U-2012-01','2012-09-15 21:39:20','2012-09-27 21:43:54'),
 ('2012-00173','U-2012-01','2012-09-27 21:43:57','2012-10-09 21:45:25'),
 ('2012-00174','U-2012-01','2012-10-09 21:45:26','2012-10-09 21:46:51'),
 ('2012-00175','U-2012-01','2012-10-09 21:46:53','2012-10-09 21:47:49'),
 ('2012-00176','U-2012-01','2012-10-09 21:47:50','2012-10-09 21:48:21'),
 ('2012-00177','U-2012-01','2012-10-09 21:48:22','2012-10-09 21:50:11'),
 ('2012-00178','U-2012-01','2012-10-09 21:50:12','2012-10-09 21:50:40'),
 ('2012-00179','U-2012-01','2012-10-09 21:52:51','2012-10-09 21:53:36'),
 ('2012-00180','U-2012-01','2012-09-15 21:59:11',NULL);
/*!40000 ALTER TABLE `loghis` ENABLE KEYS */;


--
-- Definition of table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE `payment` (
  `paymentid` int(10) unsigned NOT NULL auto_increment,
  `borrowid` varchar(15) NOT NULL,
  `cash` int(10) unsigned NOT NULL,
  `amount` double NOT NULL,
  `balance` double NOT NULL,
  `change` double NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY  (`paymentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;


--
-- Definition of table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `userid` varchar(9) NOT NULL default '',
  `uname` varchar(20) default NULL,
  `pwd` varchar(32) default NULL,
  `fname` varchar(30) default NULL,
  `lname` varchar(20) default NULL,
  `ustatus` varchar(8) default NULL,
  `utype` varchar(5) default NULL,
  `sq` varchar(60) default NULL,
  `sa` varchar(20) default NULL,
  `regdate` date default NULL,
  PRIMARY KEY  (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`userid`,`uname`,`pwd`,`fname`,`lname`,`ustatus`,`utype`,`sq`,`sa`,`regdate`) VALUES 
 ('U-2012-01','SacredHeart','123456','Joy','Bayani','Active','Admin','When is your spiritual birth?','2003-05-26','2012-07-01'),
 ('U-2012-02','Irenete','Lanzarote','Irene','Lanzarote','Inactive','Staff','What is your favorite hobby?','Reading','2012-07-03'),
 ('U-2012-03','LeahRes','Delosyes','Leah','Delos Reyes','Active','Staff','What is your favorite food?','Ice Cream','2012-07-03'),
 ('U-2012-04','JoyJoy','123457','deer','flores','Inactive','Staff','What is the name of your first pet?','carabao','2012-08-17');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
