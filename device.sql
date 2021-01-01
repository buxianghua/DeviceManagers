/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 80012
Source Host           : localhost:3306
Source Database       : device

Target Server Type    : MYSQL
Target Server Version : 80012
File Encoding         : 65001

Date: 2020-06-15 16:30:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `admin_user`
-- ----------------------------
DROP TABLE IF EXISTS `admin_user`;
CREATE TABLE `admin_user` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(30) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of admin_user
-- ----------------------------
INSERT INTO `admin_user` VALUES ('1', 'admin', '123');
INSERT INTO `admin_user` VALUES ('2', 'zhangsan', '123');
INSERT INTO `admin_user` VALUES ('3', 'user', '123');

-- ----------------------------
-- Table structure for `class`
-- ----------------------------
DROP TABLE IF EXISTS `class`;
CREATE TABLE `class` (
  `cid` int(10) NOT NULL AUTO_INCREMENT,
  `class` varchar(15) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`cid`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of class
-- ----------------------------
INSERT INTO `class` VALUES ('1', '一般');
INSERT INTO `class` VALUES ('2', '中等');
INSERT INTO `class` VALUES ('3', '重要');
INSERT INTO `class` VALUES ('4', '非常重要');

-- ----------------------------
-- Table structure for `c_client`
-- ----------------------------
DROP TABLE IF EXISTS `c_client`;
CREATE TABLE `c_client` (
  `cid` int(15) NOT NULL AUTO_INCREMENT,
  `ccard` varchar(20) COLLATE utf8_bin NOT NULL,
  `cclass` int(10) NOT NULL,
  `cname` varchar(20) COLLATE utf8_bin NOT NULL,
  `ctele` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `ccompany` varchar(30) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`cid`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of c_client
-- ----------------------------
INSERT INTO `c_client` VALUES ('1', '1000', '3', '马化腾', '12341234432', '腾讯科技');
INSERT INTO `c_client` VALUES ('3', '1002', '2', '马云', '12341412', '阿里巴巴');
INSERT INTO `c_client` VALUES ('4', '1003', '2', '李彦宏', '114123515', '百度公司');

-- ----------------------------
-- Table structure for `d_departments`
-- ----------------------------
DROP TABLE IF EXISTS `d_departments`;
CREATE TABLE `d_departments` (
  `did` int(10) NOT NULL AUTO_INCREMENT,
  `dname` varchar(20) COLLATE utf8_bin NOT NULL,
  `ddescription` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `ddevice` int(20) DEFAULT NULL,
  `ddevicenums` int(5) DEFAULT NULL,
  PRIMARY KEY (`did`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of d_departments
-- ----------------------------
INSERT INTO `d_departments` VALUES ('1', '财务部', '这是个有钱的部门', '1', '20');
INSERT INTO `d_departments` VALUES ('2', '人事部', '这是个用人的部门', '1', '10');
INSERT INTO `d_departments` VALUES ('3', '组织部', '这是个用组织的部门', '1', '12');
INSERT INTO `d_departments` VALUES ('4', '公共部', '请问', '1', '1');
INSERT INTO `d_departments` VALUES ('5', '事业部', '请问', '1', '1');
INSERT INTO `d_departments` VALUES ('6', '科研部', '这是一个搞事情的部门', '1', '20');
INSERT INTO `d_departments` VALUES ('10', '文娱部', '这是一个娱乐的部门', '1', '1');
INSERT INTO `d_departments` VALUES ('11', '设备部', '设备很多', '5', '10');

-- ----------------------------
-- Table structure for `d_departments_and_e_device`
-- ----------------------------
DROP TABLE IF EXISTS `d_departments_and_e_device`;
CREATE TABLE `d_departments_and_e_device` (
  `edid` int(20) NOT NULL AUTO_INCREMENT,
  `did` int(10) NOT NULL,
  `eid` int(10) NOT NULL,
  PRIMARY KEY (`edid`),
  KEY `eid` (`eid`),
  KEY `did` (`did`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of d_departments_and_e_device
-- ----------------------------
INSERT INTO `d_departments_and_e_device` VALUES ('1', '1', '1');
INSERT INTO `d_departments_and_e_device` VALUES ('2', '1', '2');
INSERT INTO `d_departments_and_e_device` VALUES ('3', '2', '1');
INSERT INTO `d_departments_and_e_device` VALUES ('4', '3', '1');
INSERT INTO `d_departments_and_e_device` VALUES ('5', '1', '1');
INSERT INTO `d_departments_and_e_device` VALUES ('6', '1', '2');
INSERT INTO `d_departments_and_e_device` VALUES ('8', '10', '1');
INSERT INTO `d_departments_and_e_device` VALUES ('9', '11', '5');

-- ----------------------------
-- Table structure for `e_device`
-- ----------------------------
DROP TABLE IF EXISTS `e_device`;
CREATE TABLE `e_device` (
  `eid` int(10) NOT NULL AUTO_INCREMENT,
  `ename` varchar(20) COLLATE utf8_bin NOT NULL,
  `enums` int(5) DEFAULT NULL,
  `estatus` varchar(10) COLLATE utf8_bin NOT NULL,
  `evalue` float(15,0) NOT NULL,
  PRIMARY KEY (`eid`),
  KEY `edepart` (`eid`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of e_device
-- ----------------------------
INSERT INTO `e_device` VALUES ('1', '笔记本', '20', '1', '100000');
INSERT INTO `e_device` VALUES ('2', '服务器', '10', '1', '50000');
INSERT INTO `e_device` VALUES ('3', '笔记本', '10', '1', '5000');
INSERT INTO `e_device` VALUES ('4', '电脑', '100', '1', '190978');
INSERT INTO `e_device` VALUES ('5', '一体机', '100', '1', '123456');

-- ----------------------------
-- Table structure for `e_device_and_s_staff`
-- ----------------------------
DROP TABLE IF EXISTS `e_device_and_s_staff`;
CREATE TABLE `e_device_and_s_staff` (
  `edid` int(20) NOT NULL AUTO_INCREMENT,
  `scard` varchar(15) COLLATE utf8_bin NOT NULL,
  `eid` int(10) NOT NULL,
  `eidnums` int(5) DEFAULT NULL,
  PRIMARY KEY (`edid`),
  KEY `eid` (`eid`),
  KEY `scard` (`scard`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of e_device_and_s_staff
-- ----------------------------
INSERT INTO `e_device_and_s_staff` VALUES ('1', '1', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('2', '1001', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('3', '12346111', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('4', '123455', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('5', '3121', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('6', 'bbb', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('7', 'faw', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('8', 'ace', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('9', 'mini', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('10', '12301', '1', '1');
INSERT INTO `e_device_and_s_staff` VALUES ('11', '1200', '3', '10');

-- ----------------------------
-- Table structure for `repair`
-- ----------------------------
DROP TABLE IF EXISTS `repair`;
CREATE TABLE `repair` (
  `rid` int(10) NOT NULL AUTO_INCREMENT,
  `sscard` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `sname` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `ename` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `rstatus` int(2) DEFAULT NULL,
  PRIMARY KEY (`rid`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of repair
-- ----------------------------
INSERT INTO `repair` VALUES ('1', '1001', '拉拉', '电脑', '1');

-- ----------------------------
-- Table structure for `s_staff`
-- ----------------------------
DROP TABLE IF EXISTS `s_staff`;
CREATE TABLE `s_staff` (
  `sid` int(20) NOT NULL AUTO_INCREMENT,
  `scard` varchar(15) COLLATE utf8_bin NOT NULL,
  `sname` varchar(15) COLLATE utf8_bin NOT NULL,
  `ssex` varchar(5) COLLATE utf8_bin NOT NULL,
  `sage` int(4) DEFAULT NULL,
  `saddress` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `money` float(6,0) DEFAULT NULL,
  `sdepartment` int(5) NOT NULL,
  `sdevice` int(5) DEFAULT NULL,
  `sdevicenums` int(5) DEFAULT NULL,
  PRIMARY KEY (`sid`,`scard`),
  KEY `d_department` (`sdepartment`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of s_staff
-- ----------------------------
INSERT INTO `s_staff` VALUES ('1', '123', '123', '男', '20', 'adgaga', '1452', '10', '3', '1');
INSERT INTO `s_staff` VALUES ('2', '12346', 'ha', '男', '20', 'adgaga', '1452', '6', '1', '1');
INSERT INTO `s_staff` VALUES ('3', '1261', 'safa1', '男', '20', 'adgaga', '1452', '2', '1', '1');
INSERT INTO `s_staff` VALUES ('4', '1001', 'safa1', '男', '20', 'adgaga', '1452', '2', '1', '1');
INSERT INTO `s_staff` VALUES ('5', '12306', '12345', '男', '20', 'adgaga', '1452', '4', '1', '1');
INSERT INTO `s_staff` VALUES ('6', '1002', 'safa1', '男', '20', 'adgaga', '1452', '2', '1', '2');
INSERT INTO `s_staff` VALUES ('7', '11234', 'safa1', '男', '20', 'adgaga', '1452', '2', '1', '1');
INSERT INTO `s_staff` VALUES ('8', '1003', 'safa1', '男', '20', 'adgaga', '1452', '2', '1', '1');
INSERT INTO `s_staff` VALUES ('18', '1200', '我是谁', '女', '20', '发大水士大夫', '12141', '4', '3', '10');
INSERT INTO `s_staff` VALUES ('11', 'nihao', '1234', '男', '20', 'dfadf', '1234', '1', '1', '1');
INSERT INTO `s_staff` VALUES ('12', 'aaa', 'aaaa', '男', '20', 'fadf', '14423', '1', '1', '1');
INSERT INTO `s_staff` VALUES ('13', 'bbb', 'bbb', '男', '20', 'afas', '1234', '1', '1', '1');
INSERT INTO `s_staff` VALUES ('14', 'faw', 'fwaf', '男', '20', 'dfafa', '3242', '1', '1', '1');
INSERT INTO `s_staff` VALUES ('15', 'aefad', 'fasdfa', '男', '20', 'fwaf', '13242', '3', '1', '1');
INSERT INTO `s_staff` VALUES ('16', 'mini', 'mini', '男', '20', 'fsdf', '12341', '2', '1', '1');
INSERT INTO `s_staff` VALUES ('17', '12301', 'aaf2', '男', '20', 'fad', '134', '2', '1', '1');
