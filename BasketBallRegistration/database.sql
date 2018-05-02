160BFQW-D2A-410A7C9C7N 


CREATE TABLE `users` (
  `username` varchar(20) NOT NULL,
  `pwd` char(32) DEFAULT NULL,
  `isAdmin` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `grp` (
  `group_ID` int(11) NOT NULL AUTO_INCREMENT,
  `grpName` varchar(32) NOT NULL,
  `saturday` tinyint(1) DEFAULT NULL,
  `sunday` tinyint(1) DEFAULT NULL,
  `monday` tinyint(1) DEFAULT NULL,
  `tuesday` tinyint(1) DEFAULT NULL,
  `wednesday` tinyint(1) DEFAULT NULL,
  `thursday` tinyint(1) DEFAULT NULL,
  `friday` tinyint(1) DEFAULT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  PRIMARY KEY (`group_ID`),
  UNIQUE KEY `grpName` (`grpName`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;


CREATE TABLE `player` (
  `player_id` int(11) NOT NULL AUTO_INCREMENT,
  `pcode` varchar(32) NOT NULL,
  `pname` varchar(32) NOT NULL,
  `birthyear` int(11) DEFAULT NULL,
  `group_ID` int(11) DEFAULT NULL,
  `birthmonth` int(11) DEFAULT NULL,
  `birthday` int(11) DEFAULT NULL,
  PRIMARY KEY (`player_id`),
  UNIQUE KEY `pcode` (`pcode`),
  KEY `group_ID` (`group_ID`),
  CONSTRAINT `player_ibfk_1` FOREIGN KEY (`group_ID`) REFERENCES `grp` (`group_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;


CREATE TABLE `payment` (
  `pID` int(11) NOT NULL AUTO_INCREMENT,
  `player_id` int(11) NOT NULL,
  `Amount_left` int(11) DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  PRIMARY KEY (`pID`),
  KEY `player_id` (`player_id`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`player_id`) REFERENCES `player` (`player_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;


CREATE TABLE `attendance` (
  `at_date` date NOT NULL,
  `player_id` int(11) NOT NULL,
  PRIMARY KEY (`at_date`,`player_id`),
  KEY `attendance_ibfk_1` (`player_id`),
  CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`player_id`) REFERENCES `player` (`player_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8