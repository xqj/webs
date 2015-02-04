/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:50:06
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `Lable_Info_Relation`
-- ----------------------------
DROP TABLE IF EXISTS `Lable_Info_Relation`;
CREATE TABLE `Lable_Info_Relation` (
  `LI_id` int(11) NOT NULL AUTO_INCREMENT,
  `LableId` int(11) NOT NULL,
  `InfoId` int(11) NOT NULL,
  `CreateTime` datetime NOT NULL,
  PRIMARY KEY (`LI_id`),
  KEY `LableIdIndex` (`LableId`) USING BTREE,
  KEY `InfoIdIndex` (`InfoId`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Lable_Info_Relation
-- ----------------------------
