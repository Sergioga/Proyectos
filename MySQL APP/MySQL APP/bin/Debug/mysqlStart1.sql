USE appmysql;
CREATE TABLE `appmysql`.`login` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` LONGTEXT NOT NULL,
  `surname` LONGTEXT NOT NULL,
  `loginName` VARCHAR(45) NOT NULL,
  `pass` VARCHAR(45) NOT NULL,
  `level` TINYINT NOT NULL,
  `active` BIT NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `loginName_UNIQUE` (`loginName` ASC));

INSERT INTO `appmysql`.`login` (`name`, `surname`, `loginName`, `pass`, `level`) values ('Q', 'Q', 'Q', 'q', 6);

CREATE TABLE `appmysql`.`license` (
  `id` INT NOT NULL DEFAULT 1,
  `serial` LONGTEXT NOT NULL,
  `license` LONGTEXT NULL);

