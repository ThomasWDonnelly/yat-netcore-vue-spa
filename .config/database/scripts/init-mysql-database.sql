CREATE TABLE `yat-netcore-vue-spa-database`.`products`  (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    description VARCHAR(100) NOT NULL,
    price DECIMAL NOT NULL
  PRIMARY KEY ( id )
);

INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (1, 'ITEM 1', 'lorem ipsum', 100);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (2, 'ITEM 2', 'lorem ipsum', 200);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (3, 'ITEM 1', 'lorem ipsum', 250);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (4, 'ITEM 3', 'lorem ipsum', 300);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (5, 'ITEM 4', 'lorem ipsum', 50);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (6, 'ITEM 4', 'lorem ipsum', 40);
INSERT INTO `yat-netcore-vue-spa-database`.`products`(`id`, `name`, `description`, `price`) VALUES (7, 'ITEM 2', 'lorem ipsum', 200);