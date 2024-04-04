set SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
start transaction;
set time_zone = "+07:00";
create database cafe_db;
use cafe_db;

-- -----------------------------------------------

-- Table Employees

create table `employees` (
    `EMPLOYEE_ID` int(10) not null,
    `FIRST_NAME` varchar(30) not null,
    `LAST_NAME` varchar(30) not null,
    `SEX` char(1) not null,
    `SALARY` double(8,2) not null
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Order

create table `order` (
    `ORDER_ID` int(5) not null,
    `ORDER_DATE` datetime not null,
    `EMPLOYEE_ID` int(10) not null
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Drink

create table `drink` (
    `DRINK_ID` int(5) not null,
    `DRINK_NAME` varchar(30) not null,
    `DRINK_PRICE` double(4,2) not null,
    `DRINK_STATUS` tinyint(1) not null

) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Order_Detail

create table `order_detail`(
    `ORDER_ID` int(5) not null,
    `DRINK_ID` int(5) not null,
    `TOPPING_ID` int(5) not null,
    `QUANTITY` int(6) not null
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Material

create table `material`(
    `MATERIAL_ID` int(5) not null,
    `MATERIAL_NAME` varchar(30) not null
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Topping

create table `topping`(
    `TOPPING_ID` int(5) not null,
    `TOPPING_NAME` varchar(30) not null,
    `TOPPING_PRICE` double(4,2) not null   
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Table Material_of_Drink

create table `material_of_drink`(
    `DRINK_ID` int(5) not null,
    `MATERIAL_ID` int(5) not null
) ENGINE=InnoDB default CHARSET=utf8mb4 collate=utf8mb4_general_ci;

-- -----------------------------------------------

-- Indexes for table `employees`
alter table `employees`
    add primary key (`EMPLOYEE_ID`);

-- Indexes for table `order`
alter table `order`
    add primary key (`ORDER_ID`);

-- Indexes for table `drink`
alter table `drink`
    add primary key (`DRINK_ID`);

-- Indexes for table `order_detail`
alter table `order_detail`
    add primary key (`ORDER_ID`, `DRINK_ID`);

-- Indexes for table `material`
alter table `material`
    add primary key (`MATERIAL_ID`);

-- Indexes for table `topping`
alter table `topping`
    add primary key (`TOPPING_ID`);

-- Indexes for table `material_of_drink`
alter table `material_of_drink`
    add primary key (`DRINK_ID`, `MATERIAL_ID`);


-- Constraints for `order` tables
alter table `order`
    add constraint `O_Employee_Id` foreign key (`EMPLOYEE_ID`) references `employees` (`EMPLOYEE_ID`);

-- Constraints for `order_detail` tables
alter table `order_detail`
    add constraint `OD_Order_Id` foreign key (`ORDER_ID`) references `order` (`ORDER_ID`),
    add constraint `OD_Drink_Id` foreign key (`DRINK_ID`) references `drink` (`DRINK_ID`),
    add constraint `OD_Topping_Id` foreign key (`TOPPING_ID`) references `topping` (`TOPPING_ID`);

-- Constraints for `material_of_drink` tables
alter table `material_of_drink`
    add constraint `MOD_Material_Id` foreign key (`MATERIAL_ID`) references `material` (`MATERIAL_ID`),
    add constraint `MOD_Drink_Id` foreign key (`DRINK_ID`) references `drink` (`DRINK_ID`);

-- commit
commit;