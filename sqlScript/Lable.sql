/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:49:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `Lable`
-- ----------------------------
DROP TABLE IF EXISTS `Lable`;
CREATE TABLE `Lable` (
  `LableId` int(11) NOT NULL AUTO_INCREMENT,
  `LableName` varchar(255) NOT NULL,
  `IsShowIndex` tinyint(3) unsigned zerofill NOT NULL,
  `IndexShowSort` int(10) unsigned zerofill NOT NULL,
  `Enable` tinyint(3) unsigned zerofill NOT NULL,
  `CreateTime` datetime NOT NULL,
  `ModifyTime` datetime DEFAULT NULL,
  `CreateBy` int(10) unsigned zerofill NOT NULL,
  `ModifyBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`LableId`),
  KEY `LableNameIndex` (`LableName`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Lable
-- ----------------------------
