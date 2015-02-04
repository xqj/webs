/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:49:45
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `Channel_Info_Relation`
-- ----------------------------
DROP TABLE IF EXISTS `Channel_Info_Relation`;
CREATE TABLE `Channel_Info_Relation` (
  `CI_id` int(11) NOT NULL AUTO_INCREMENT,
  `ChannelId` int(11) NOT NULL,
  `InfoId` int(11) NOT NULL,
  `CreateTime` datetime NOT NULL,
  PRIMARY KEY (`CI_id`),
  KEY `ChannelIdIndex` (`ChannelId`) USING BTREE,
  KEY `InfoIdIndex` (`InfoId`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Channel_Info_Relation
-- ----------------------------
INSERT INTO `Channel_Info_Relation` VALUES ('1', '1', '1', '2014-11-25 16:15:18');
INSERT INTO `Channel_Info_Relation` VALUES ('2', '2', '2', '2014-11-25 16:15:25');
INSERT INTO `Channel_Info_Relation` VALUES ('3', '1', '3', '2014-11-25 16:56:52');
INSERT INTO `Channel_Info_Relation` VALUES ('4', '2', '4', '2014-11-25 16:57:02');
INSERT INTO `Channel_Info_Relation` VALUES ('5', '1', '10', '2015-02-04 16:02:24');
INSERT INTO `Channel_Info_Relation` VALUES ('6', '1', '11', '2015-02-04 16:06:14');
INSERT INTO `Channel_Info_Relation` VALUES ('7', '1', '12', '2015-02-04 16:19:57');
INSERT INTO `Channel_Info_Relation` VALUES ('8', '1', '13', '2015-02-04 16:21:30');
INSERT INTO `Channel_Info_Relation` VALUES ('9', '1', '14', '2015-02-04 16:22:14');
INSERT INTO `Channel_Info_Relation` VALUES ('10', '1', '15', '2015-02-04 16:22:34');
INSERT INTO `Channel_Info_Relation` VALUES ('11', '1', '16', '2015-02-04 16:23:20');
INSERT INTO `Channel_Info_Relation` VALUES ('12', '2', '17', '2015-02-04 16:26:13');
INSERT INTO `Channel_Info_Relation` VALUES ('13', '1', '18', '2015-02-04 16:49:35');
