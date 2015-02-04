/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:49:06
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `Channel`
-- ----------------------------
DROP TABLE IF EXISTS `Channel`;
CREATE TABLE `Channel` (
  `ChannelId` int(11) NOT NULL AUTO_INCREMENT,
  `ChannelName` varchar(255) NOT NULL,
  `InfoTotal` int(10) unsigned zerofill NOT NULL,
  `IsShowIndex` tinyint(3) unsigned zerofill NOT NULL,
  `SiteId` int(11) NOT NULL,
  `IndexShowSort` int(10) unsigned zerofill NOT NULL,
  `Enable` tinyint(3) unsigned zerofill NOT NULL,
  `CreateTime` datetime NOT NULL,
  `ModifyTime` datetime DEFAULT NULL,
  `CreateBy` int(11) NOT NULL,
  `ModifyBy` int(11) unsigned zerofill DEFAULT NULL,
  `IsDelete` tinyint(3) unsigned zerofill NOT NULL,
  PRIMARY KEY (`ChannelId`),
  KEY `ChannelIdIndex` (`ChannelId`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Channel
-- ----------------------------
INSERT INTO `Channel` VALUES ('1', '????', '0000000000', '001', '1', '0000000000', '001', '2014-11-25 14:40:06', '2014-11-25 14:46:06', '0', '00000000000', '000');
INSERT INTO `Channel` VALUES ('2', '????', '0000000000', '001', '1', '0000000000', '001', '2014-11-25 14:40:10', '2014-11-25 14:46:11', '0', '00000000000', '000');
INSERT INTO `Channel` VALUES ('3', '???', '0000000000', '001', '1', '0000000000', '001', '2015-01-30 14:20:05', '2015-01-30 14:20:11', '0', '00000000000', '000');
INSERT INTO `Channel` VALUES ('4', '????', '0000000000', '001', '1', '0000000000', '001', '2015-01-30 14:20:37', '2015-01-30 14:20:40', '0', '00000000000', '000');
INSERT INTO `Channel` VALUES ('5', 'ME', '0000000000', '001', '1', '0000000000', '001', '2015-01-30 14:21:35', '2015-01-30 14:21:38', '0', '00000000000', '000');
