# Web api boilerplate

## Useage

1. Init database

```
CREATE DATABASE IF NOT EXISTS `MyProject`;
USE `MyProject`;

CREATE TABLE IF NOT EXISTS `Person` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
```

2. Change connection string password

```
<add name="Default" connectionString="server=localhost;port=3306;database=MyProject;uid=root;password=123456" providerName="MySql.Data.MySqlClient" />
```

3. Start Host Project, open brower with: http://localhost:9000/swagger
