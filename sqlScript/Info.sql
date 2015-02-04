/*
Navicat MySQL Data Transfer

Source Server         : mono
Source Server Version : 50152
Source Host           : 192.168.87.64:3306
Source Database       : websites

Target Server Type    : MYSQL
Target Server Version : 50152
File Encoding         : 65001

Date: 2015-02-04 17:49:53
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `Info`
-- ----------------------------
DROP TABLE IF EXISTS `Info`;
CREATE TABLE `Info` (
  `InfoId` int(11) NOT NULL AUTO_INCREMENT,
  `ShowSort` int(10) unsigned zerofill NOT NULL,
  `InfoTitle` varchar(255) NOT NULL,
  `InfoContent` longtext NOT NULL,
  `TitleImg` varchar(500) DEFAULT NULL,
  `Enable` tinyint(3) unsigned zerofill NOT NULL,
  `CreateTime` datetime NOT NULL,
  `ModifyTime` datetime DEFAULT NULL,
  `CreateBy` int(11) NOT NULL,
  `ModifyBy` int(11) DEFAULT NULL,
  `IsDelete` tinyint(3) unsigned zerofill NOT NULL,
  `JumpUrl` varchar(1000) DEFAULT NULL,
  `IsJump` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`InfoId`),
  KEY `TileIndex` (`InfoTitle`) USING BTREE,
  KEY `IdIndex` (`InfoId`) USING BTREE,
  KEY `CreateTimeIndex` (`CreateTime`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Info
-- ----------------------------
INSERT INTO `Info` VALUES ('1', '0000000001', 't1', 't1', '', '001', '2014-11-25 16:14:18', '2015-02-03 16:45:23', '1', '1', '000', ' ', '0');
INSERT INTO `Info` VALUES ('2', '0000000002', 't2fffff', '<p>t2</p>', '', '001', '2014-11-25 16:14:47', '2015-02-04 16:26:28', '1', '1', '000', ' ', '0');
INSERT INTO `Info` VALUES ('3', '0000000003', 't11', '<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;t11\n &nbsp; &nbsp;</p>', '', '000', '2014-11-25 16:14:18', '2014-11-26 11:51:46', '1', '1', '000', ' ', '0');
INSERT INTO `Info` VALUES ('4', '0000000004', 't22', '<p>t22fdfdfdfd</p>', '', '000', '2014-11-25 16:14:47', '2015-01-30 17:26:00', '1', '1', '000', ' ', '0');
INSERT INTO `Info` VALUES ('11', '0000000001', 'mmmmmmm', '', '', '001', '2015-02-04 16:06:07', '2015-02-04 17:27:38', '1', '1', '001', ' ', '0');
INSERT INTO `Info` VALUES ('12', '0000000000', 'tttttttttttt', '<p>sdfssdfsd<br/></p>', '', '001', '2015-02-04 16:19:57', '2015-02-04 16:19:57', '1', '1', '001', '', '0');
INSERT INTO `Info` VALUES ('13', '0000000000', 't5', '', '', '001', '2015-02-04 16:21:30', '2015-02-04 16:21:30', '1', '1', '001', '', '0');
INSERT INTO `Info` VALUES ('14', '0000000000', 't6', '', '', '001', '2015-02-04 16:22:14', '2015-02-04 16:22:14', '1', '1', '001', '', '0');
INSERT INTO `Info` VALUES ('15', '0000000000', 't7', '<p>sdfsdfsdfsdf<br/></p>', '', '001', '2015-02-04 16:22:34', '2015-02-04 16:22:34', '1', '1', '001', '', '0');
INSERT INTO `Info` VALUES ('16', '0000000000', 't8888', '', '', '001', '2015-02-04 16:23:20', '2015-02-04 16:23:20', '1', '1', '001', '', '0');
INSERT INTO `Info` VALUES ('17', '0000000000', 'sdfsdfsd', '<p>dfgdfgdfg<br/></p>', '', '001', '2015-02-04 16:26:13', '2015-02-04 16:26:13', '1', '1', '000', '', '0');
INSERT INTO `Info` VALUES ('18', '0000000000', 'sdfsdf', '', '', '001', '2015-02-04 16:49:35', '2015-02-04 16:49:35', '1', '1', '001', '', '0');
