CREATE TABLE IF NOT EXISTS `mydb`.`Project` (
  `projectID` INT NOT NULL,
  `project_name` VARCHAR(45) NOT NULL,
  `start_date` DATETIME NOT NULL,
  `to_date` DATETIME NOT NULL,
  `Department_DepID` INT NOT NULL,
  `Client_clientID` INT NOT NULL,
  `Project_Status_statusID` INT NOT NULL,
  PRIMARY KEY (`projectID`, `Department_DepID`, `Client_clientID`, `Project_Status_statusID`),
  UNIQUE INDEX `projectID_UNIQUE` (`projectID` ASC) VISIBLE,
  UNIQUE INDEX `project_name_UNIQUE` (`project_name` ASC) VISIBLE,
  INDEX `fk_Project_Department1_idx` (`Department_DepID` ASC) VISIBLE,
  INDEX `fk_Project_Client1_idx` (`Client_clientID` ASC) VISIBLE,
  INDEX `fk_Project_Project_Status1_idx` (`Project_Status_statusID` ASC) VISIBLE,
  CONSTRAINT `fk_Project_Department1`
    FOREIGN KEY (`Department_DepID`)
    REFERENCES `mydb`.`Department` (`DepID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Project_Client1`
    FOREIGN KEY (`Client_clientID`)
    REFERENCES `mydb`.`Client` (`clientID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Project_Project_Status1`
    FOREIGN KEY (`Project_Status_statusID`)
    REFERENCES `mydb`.`Project Status` (`statusID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
CREATE TABLE IF NOT EXISTS `mydb`.`works_on` (
  `idteam` INT NOT NULL,
  `projectID` INT NOT NULL,
  PRIMARY KEY (`idteam`, `projectID`),
  CONSTRAINT `fk_idteam`
    FOREIGN KEY (`idteam`)
    REFERENCES `mydb`.`team` (`idteam`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_projectID`
    FOREIGN KEY (`projectID`)
    REFERENCES `mydb`.`Project` (`projectID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;






