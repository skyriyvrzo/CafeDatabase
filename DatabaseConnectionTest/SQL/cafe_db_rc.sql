-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2024 at 08:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cafe_db_rc`
--

-- --------------------------------------------------------

--
-- Table structure for table `drinks`
--

CREATE TABLE `drinks` (
  `Drink_Id` int(5) NOT NULL,
  `Drink_Name` varchar(30) NOT NULL,
  `Drink_Price` double(4,2) NOT NULL,
  `Drink_Status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `Emp_Id` int(10) NOT NULL,
  `Emp_FirstName` varchar(30) NOT NULL,
  `Emp_LastName` varchar(30) NOT NULL,
  `Emp_Sex` char(1) NOT NULL,
  `Emp_Salary` double(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `meterials`
--

CREATE TABLE `materials` (
  `Material_Id` int(5) NOT NULL,
  `Material_Name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `meterial_of_drink`
--

CREATE TABLE `material_of_drink` (
  `Drink_Id` int(5) NOT NULL,
  `Material_Id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `Order_Id` int(5) NOT NULL,
  `Order_Date` datetime NOT NULL,
  `Emp_Id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `orders_detail`
--

CREATE TABLE `orders_detail` (
  `Order_Id` int(5) NOT NULL,
  `Drink_Id` int(5) NOT NULL,
  `Topping_Id` int(5) NOT NULL,
  `Quantity` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `toppings`
--

CREATE TABLE `toppings` (
  `Topping_Id` int(5) NOT NULL,
  `Topping_Name` varchar(30) NOT NULL,
  `Topping_Price` double(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `drinks`
--
ALTER TABLE `drinks`
  ADD PRIMARY KEY (`Drink_Id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`Emp_Id`);

--
-- Indexes for table `meterials`
--
ALTER TABLE `materials`
  ADD PRIMARY KEY (`Material_Id`);

--
-- Indexes for table `material_of_drink`
--
ALTER TABLE `material_of_drink`
  ADD PRIMARY KEY (`Drink_Id`,`Material_Id`);
--
-- Indexes for table `toppings`
--
ALTER TABLE `toppings`
  ADD PRIMARY KEY (`Topping_Id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`Order_Id`);

--
-- Indexes for table `orders_detail`
--
ALTER TABLE `orders_detail`
  ADD PRIMARY KEY (`Order_Id`,`Drink_Id`);

--
-- Constraints for `material_of_drink` tables
ALTER TABLE `material_of_drink`
  ADD CONSTRAINT `MOD_Material_Id_FK` FOREIGN KEY (`Material_Id`) REFERENCES `materials` (`Material_Id`),
  ADD CONSTRAINT `MOD_Drink_Id_FK` FOREIGN KEY (`Drink_Id`) REFERENCES `drinks` (`Drink_Id`);

-- Constraints for `orders` tables
ALTER TABLE `orders`
  ADD CONSTRAINT `O_Emp_Id_FK` FOREIGN KEY (`Emp_Id`) REFERENCES `employees` (`Emp_Id`);

-- Constraints for `orders_detail`
ALTER TABLE `orders_detail`
  ADD CONSTRAINT `OD_Topping_Id_FK` FOREIGN KEY (`Topping_Id`) REFERENCES `toppings` (`Topping_Id`),
  ADD CONSTRAINT `OD_Drink_Id_FK` FOREIGN KEY (`Drink_Id`) REFERENCES `drinks` (`Drink_Id`),
  ADD CONSTRAINT `OD_Order_Id_FK` FOREIGN KEY(`Order_Id`) REFERENCES `orders` (`Order_Id`);


--
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
