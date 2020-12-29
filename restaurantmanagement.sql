-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 30, 2020 at 12:49 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restaurantmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(255) NOT NULL,
  `status` int(11) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`, `code`, `status`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Lẩu', 'lau', 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(2, 'Cơm', 'com', 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(4, 'Tráng miệng', 'trang-mieng', 1, '2020-12-18 00:00:00', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` bigint(20) NOT NULL,
  `discount` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `categoryid` bigint(20) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`id`, `name`, `price`, `discount`, `status`, `categoryid`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Cơm chiên', 30000, 10, 1, 2, NULL, NULL, NULL, NULL),
(3, 'Lẩu gà', 200000, 5, 1, 1, '2020-12-19 00:00:00', NULL, '2020-12-19 00:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `orderdetail`
--

CREATE TABLE `orderdetail` (
  `id` bigint(20) NOT NULL,
  `orderid` bigint(20) NOT NULL,
  `foodid` bigint(20) NOT NULL,
  `unitprice` bigint(20) NOT NULL,
  `quantity` int(11) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` bigint(20) NOT NULL,
  `totalprice` bigint(20) NOT NULL,
  `saleid` bigint(20) NOT NULL,
  `tableid` bigint(20) NOT NULL,
  `status` int(11) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(255) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `name`, `code`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Quản lý', 'MANAGER', NULL, NULL, NULL, NULL),
(2, 'Nhân viên', 'STAFF', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `discount` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `createddate` datetime NOT NULL,
  `createdby` varchar(255) NOT NULL,
  `modifieddate` datetime NOT NULL,
  `modifiedby` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tables`
--

CREATE TABLE `tables` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `seats` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tables`
--

INSERT INTO `tables` (`id`, `name`, `seats`, `status`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(2, 'Bàn 2', 5, 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(3, 'Bàn 3', 2, 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(4, 'Bàn 4', 7, 0, '2020-12-18 00:00:00', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` bigint(20) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone` varchar(11) NOT NULL,
  `address` text NOT NULL,
  `email` varchar(255) NOT NULL,
  `dob` date DEFAULT NULL,
  `gender` varchar(3) NOT NULL,
  `status` int(11) NOT NULL,
  `roleid` bigint(20) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `fullname`, `username`, `password`, `phone`, `address`, `email`, `dob`, `gender`, `status`, `roleid`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Huy Phước', 'php', '123', '0909090909', 'HCM City', 'php@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(2, 'Thành Đoan', 'doan', '123', '0909090909', 'HCM City', 'doan@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(3, 'Thanh Tôn', 'ton', '123', '0909090909', 'HCM City', 'ton@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(4, 'Bảo Trang', 'trang', '123', '0909090909', 'HCM City', 'trang@gmail.com', '2000-02-03', 'Nữ', 1, 1, NULL, NULL, NULL, NULL),
(5, 'Thiên Long', 'long', '123', '0909090909', 'HCM City', 'long@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(6, 'Nguyễn Thị Hoa Hồng', 'hong', '123', '0909090909', 'HCM City', 'hong@gmail.com', '2000-02-03', 'Nữ', 1, 2, NULL, NULL, NULL, NULL),
(25, 'Văn Long', 'vlong', '123456', '0909023123', 'TP. HCM', 'vlong@gmail.com', '2000-02-03', 'Nam', 1, 2, '2020-12-18 00:00:00', NULL, NULL, NULL),
(31, 'Messiii', 'abc', '123', '0909023123', 'TP. HCM', 'abc@gmail.com', '2000-03-02', 'Nam', 1, 1, '2020-12-30 06:38:01', NULL, '2020-12-30 06:48:35', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`id`),
  ADD KEY `categoryid` (`categoryid`);

--
-- Indexes for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD PRIMARY KEY (`id`),
  ADD KEY `orderid` (`orderid`),
  ADD KEY `foodid` (`foodid`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tableid` (`tableid`),
  ADD KEY `saleid` (`saleid`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tables`
--
ALTER TABLE `tables`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `roleid` (`roleid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tables`
--
ALTER TABLE `tables`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `food`
--
ALTER TABLE `food`
  ADD CONSTRAINT `food_ibfk_1` FOREIGN KEY (`categoryid`) REFERENCES `category` (`id`);

--
-- Constraints for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD CONSTRAINT `orderdetail_ibfk_1` FOREIGN KEY (`orderid`) REFERENCES `orders` (`id`),
  ADD CONSTRAINT `orderdetail_ibfk_2` FOREIGN KEY (`foodid`) REFERENCES `food` (`id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`tableid`) REFERENCES `tables` (`id`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`saleid`) REFERENCES `sales` (`id`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`roleid`) REFERENCES `role` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
