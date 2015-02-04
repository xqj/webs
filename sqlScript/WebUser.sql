/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:50:13
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `WebUser`
-- ----------------------------
DROP TABLE IF EXISTS `WebUser`;
CREATE TABLE `WebUser` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `LoginName` varchar(80) NOT NULL,
  `Pwd` varchar(255) NOT NULL,
  `UserName` varchar(20) NOT NULL,
  `Mobile` varchar(20) DEFAULT NULL,
  `QQ` varchar(40) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Enable` tinyint(255) unsigned zerofill NOT NULL,
  `CreateTime` datetime NOT NULL,
  `ModifyTime` datetime DEFAULT NULL,
  `CreateBy` int(11) NOT NULL,
  `ModifyBy` int(11) DEFAULT NULL,
  `IsDelete` tinyint(3) unsigned zerofill NOT NULL,
  PRIMARY KEY (`UserId`),
  KEY `LoginIndex` (`LoginName`) USING HASH,
  KEY `PwdIndex` (`Pwd`) USING BTREE,
  KEY `UserIdIndex` (`UserId`) USING HASH
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of WebUser
-- ----------------------------
INSERT INTO `WebUser` VALUES ('1', 'wind', '123456', 'wind', null, null, '', '000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001', '2014-11-24 09:57:00', '2014-11-26 12:29:07', '0', '0', '000');
