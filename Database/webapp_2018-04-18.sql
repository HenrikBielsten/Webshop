# ************************************************************
# Sequel Pro SQL dump
# Version 4541
#
# http://www.sequelpro.com/
# https://github.com/sequelpro/sequelpro
#
# Host: localhost (MySQL 5.6.38)
# Database: webapp
# Generation Time: 2018-04-18 12:14:09 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table carts
# ------------------------------------------------------------

DROP TABLE IF EXISTS `carts`;

CREATE TABLE `carts` (
  `cartId` text,
  `productId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `carts` WRITE;
/*!40000 ALTER TABLE `carts` DISABLE KEYS */;

INSERT INTO `carts` (`cartId`, `productId`)
VALUES
	('4da078f6-5c2a-51df-c77b-b329ea49b976',1),
	('4da078f6-5c2a-51df-c77b-b329ea49b976',2),
	('4da078f6-5c2a-51df-c77b-b329ea49b976',5),
	('4da078f6-5c2a-51df-c77b-b329ea49b976',4),
	('d599d531-91e9-88a3-8b2b-ac37e1cc2a42',1),
	('d599d531-91e9-88a3-8b2b-ac37e1cc2a42',3),
	('d599d531-91e9-88a3-8b2b-ac37e1cc2a42',5),
	('d599d531-91e9-88a3-8b2b-ac37e1cc2a42',4),
	('d599d531-91e9-88a3-8b2b-ac37e1cc2a42',3),
	('1714f890-05ee-8450-0f0d-0ef6eac58efe',1),
	('1714f890-05ee-8450-0f0d-0ef6eac58efe',2),
	('8df87f2c-39b6-b785-6d8f-cc923b798972',1),
	('8df87f2c-39b6-b785-6d8f-cc923b798972',1),
	('8df87f2c-39b6-b785-6d8f-cc923b798972',1),
	('762667c0-94a7-3114-b1d4-9cf94a40d625',1),
	('762667c0-94a7-3114-b1d4-9cf94a40d625',1),
	('762667c0-94a7-3114-b1d4-9cf94a40d625',1),
	('762667c0-94a7-3114-b1d4-9cf94a40d625',1),
	('762667c0-94a7-3114-b1d4-9cf94a40d625',1),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',1),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',1),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',1),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',2),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',2),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('ebf7e5d1-e981-39c0-3b49-b03ef7927474',4),
	('36a8813e-8828-236b-03eb-c691c031aaf7',2),
	('36a8813e-8828-236b-03eb-c691c031aaf7',2),
	('36a8813e-8828-236b-03eb-c691c031aaf7',2),
	('36a8813e-8828-236b-03eb-c691c031aaf7',2),
	('36a8813e-8828-236b-03eb-c691c031aaf7',2),
	('c3b8ca5e-d135-287d-b46f-54db22739f63',1),
	('c3b8ca5e-d135-287d-b46f-54db22739f63',1),
	('c3b8ca5e-d135-287d-b46f-54db22739f63',1),
	('86ab587a-98b6-d506-cff2-ea89848efacd',1),
	('aa5345cb-7f3e-f890-1be9-8ec4f659e13d',1),
	('f0c4e327-edfd-8a03-af89-7ff331481766',1),
	('85e98986-070f-6de4-615a-f2f725f0802b',1),
	('85e98986-070f-6de4-615a-f2f725f0802b',1),
	('85e98986-070f-6de4-615a-f2f725f0802b',1),
	('8f752074-9867-247a-18b8-c15fae02c3aa',1),
	('8f752074-9867-247a-18b8-c15fae02c3aa',1),
	('3c325271-5eb0-009a-fea8-74a082d01c87',1),
	('3c325271-5eb0-009a-fea8-74a082d01c87',1),
	('51a8691f-3700-762e-b5c8-053cf67ffadf',1),
	('51a8691f-3700-762e-b5c8-053cf67ffadf',1),
	('51a8691f-3700-762e-b5c8-053cf67ffadf',1),
	('b0c90a46-2452-b986-8f41-4821af08d6d1',1),
	('b0c90a46-2452-b986-8f41-4821af08d6d1',1),
	('b0c90a46-2452-b986-8f41-4821af08d6d1',1),
	('a1074cf7-821b-4bb5-5896-44d73f1f71e1',1),
	('f72e49ca-7895-d40c-8503-2c0f80fc96cd',1),
	('1b4708b4-5703-1b3f-1c59-dcf507ebf770',1),
	('03dae239-ffae-7e7f-bba0-3b477f5fa62d',1),
	('38a32dc9-430c-4f97-9028-25375aaf3633',1),
	('208498d6-e1d3-1591-0154-9a09847957d2',1),
	('f1cbdf86-bbd2-5626-c10e-d5274957076d',1),
	('c92ca33a-988f-2460-49f7-cb95803990ee',1),
	('b09fa6f7-898e-7ecb-4109-d946096910fc',1),
	('d143f273-de73-1c85-fffb-f907bd9081e9',1),
	('6426b53c-aa38-ffc5-22ab-c00022a2133e',1),
	('fcea5f2e-5263-7ad8-7322-8b7908556dbd',1),
	('33b371bc-1199-f35d-a0ed-22fb36c3222d',1),
	('fc172676-394e-2195-344b-3f6e015bccbe',1),
	('f2a33ce1-5aef-ebf4-36ee-202695394403',1),
	('5a191aef-2866-a65e-3642-6f5dad62772d',2);

/*!40000 ALTER TABLE `carts` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table orders
# ------------------------------------------------------------

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `price` int(11) DEFAULT NULL,
  `adress` text,
  `email` text,
  `name` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;

INSERT INTO `orders` (`id`, `price`, `adress`, `email`, `name`)
VALUES
	(1,5681,'  ','',''),
	(2,5500,'  ','',''),
	(3,5500,'  ','',''),
	(4,5500,'  ','',''),
	(5,5500,'tygo@mailinator.com tavid@mailinator.com xajopaj@mailinator.com','gymokupa@mailinator.net','honeguw@mailinator.net'),
	(6,5500,'dicegiz@mailinator.net qyqef@mailinator.net dabilyju@mailinator.net','hifibek@mailinator.com','vokef@mailinator.com'),
	(7,5592,'setudu@mailinator.com hisunobane@mailinator.net muxesury@mailinator.net','piwif@mailinator.com','vusad@mailinator.com'),
	(8,5620,'bavyza@mailinator.com zupixigy@mailinator.net jucoqun@mailinator.com','qadin@mailinator.com','saroryp@mailinator.net'),
	(9,5700,'Street 2b Gothenburg 123 34','henrik.bielsten@gmail.com','Henrik Bielsten'),
	(10,6507,'Street 4 City 124 43','vahuber@mailinator.com','Henrik Bielsten'),
	(11,5540,'sejyhe@mailinator.com, qudiq@mailinator.net, pegof@mailinator.com','podida@mailinator.net','xeki@mailinator.com'),
	(12,5580,'ladafyfe@mailinator.com, gitabaxuva@mailinator.com, wudejaw@mailinator.com','canugi@mailinator.com','neros@mailinator.com'),
	(13,5620,'gusavudi@mailinator.net, coqyryhyby@mailinator.net, hovucaloze@mailinator.com','danic@mailinator.com','hej'),
	(14,5540,'pyva@mailinator.com, zyfiw@mailinator.com, diha@mailinator.com','henrik.bielsten@gmail.com','dymokefany@mailinator.com'),
	(15,5540,'kepiki@mailinator.net, rapix@mailinator.com, wylu@mailinator.com','fuvify@mailinator.com','lipyzace@mailinator.net'),
	(16,5540,'Street 4, qotelyrase@mailinator.net, huvylez@mailinator.net','sahovowe@mailinator.net','wamybegu@mailinator.com'),
	(17,5540,'Scheelegatan 7b, riwabum@mailinator.net, kypinar@mailinator.com','gumyturu@mailinator.com','ruturuwy@mailinator.com'),
	(18,5540,'damobatube@mailinator.com, lujevuz@mailinator.net, fyzery@mailinator.net','logyj@mailinator.com','huzej@mailinator.com'),
	(19,5552,'bele@mailinator.net, vigyryk@mailinator.com, guqyf@mailinator.com','simi@mailinator.net','tadoqa@mailinator.com');

/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table products
# ------------------------------------------------------------

DROP TABLE IF EXISTS `products`;

CREATE TABLE `products` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `productImage` text,
  `name` text,
  `price` decimal(11,0) DEFAULT NULL,
  `description` text,
  `slug` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;

INSERT INTO `products` (`id`, `productImage`, `name`, `price`, `description`, `slug`)
VALUES
	(1,'https://cf.ltkcdn.net/small-pets/images/std/215635-672x450-Little-turtle.jpg','Turtle',40,'A turtle is a creature with a shell. Some of the most famous turtles are ninjas in their teens calles Donatello, Raphael, Leonardo and Michelangelo. ',NULL),
	(2,'http://souciant.com/wp-content/uploads/2017/03/camel.jpg','Camel',52,'Camels can carry a lot of water and fat in their great juicy humps. Great for riding through the dessert or racing.',NULL),
	(3,'https://3c1703fe8d.site.internapcdn.net/newman/csz/news/800/2015/kiwibirdgeno.jpg','Kiwi',90,'A very rare, flightless bird native to New Zealand. Super cute. And rare. Awesome!',NULL),
	(4,'http://i.dailymail.co.uk/i/pix/2017/07/11/17/423A970900000578-4686028-image-a-3_1499791105846.jpg','Lemur',87,'What\'s better than a cute monkey? A cute monkey with a super cozy tail of course! They are native to Madagascar and have starred in the epic movie of the same name.',NULL),
	(5,'https://www.zoo-berlin.de/fileadmin/_processed_/4/4/csm_Meng_Meng_Baby_1_88cad0f74f.jpg','Panda',2,'Pandas are probably the worst animal of all. It\'s a miracle that they have survived as a species for this long. They are super funny though and will make you laugh when ever they try to do any movement what so ever because they will fall over, garantued.',NULL);

/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;



/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
