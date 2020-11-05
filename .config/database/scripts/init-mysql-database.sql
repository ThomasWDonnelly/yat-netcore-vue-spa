-- -----------------------------------------
-- Create yat-netcore-vue-spa Database
-- -----------------------------------------
CREATE DATABASE `yat-netcore-vue-spa`;

-- ---------------------------------------
-- Create yat-netcore-vue-spa User
-- ---------------------------------------
CREATE USER 'yat-spa-user'@'localhost'
  IDENTIFIED WITH caching_sha2_password BY 'Y@tL0g1nP@$$w0rd!'
  PASSWORD EXPIRE
  FAILED_LOGIN_ATTEMPTS 3 PASSWORD_LOCK_TIME 2;

-- ---------------------------------------
-- Grant Permissions for USer Login	
-- ---------------------------------------
GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, RELOAD, PROCESS, REFERENCES, INDEX, ALTER, SHOW DATABASES, CREATE TEMPORARY TABLES, LOCK TABLES, EXECUTE, REPLICATION SLAVE, REPLICATION CLIENT, CREATE VIEW, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, CREATE USER, EVENT, TRIGGER ON *.* TO 'yat-spa-user'@'localhost' WITH GRANT OPTION;


SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Create product Table
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `description` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `price` decimal(10, 0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Seed product Records
-- ----------------------------
INSERT INTO `product` VALUES (1, 'ITEM 1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 100);
INSERT INTO `product` VALUES (2, 'ITEM 2', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 200);
INSERT INTO `product` VALUES (3, 'ITEM 1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 250);
INSERT INTO `product` VALUES (4, 'ITEM 3', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 300);
INSERT INTO `product` VALUES (5, 'ITEM 4', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',  50);
INSERT INTO `product` VALUES (6, 'ITEM 4', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',  40);
INSERT INTO `product` VALUES (7, 'ITEM 2', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 200);

SET FOREIGN_KEY_CHECKS = 1;
