-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2021 at 11:00 AM
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
  `status` int(11) NOT NULL,
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`, `status`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Lẩu', 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(2, 'Cơm', 1, '2020-12-18 00:00:00', NULL, NULL, NULL),
(7, 'Đồ uống', 0, '2020-12-30 21:34:27', NULL, NULL, NULL),
(8, 'Bún', 0, '2020-12-30 21:34:44', NULL, NULL, NULL);

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
(3, 'Lẩu gà', 200000, 5, 1, 1, '2020-12-19 00:00:00', NULL, '2020-12-19 00:00:00', NULL),
(4, 'Lẩu bò', 300000, 5, 1, 1, '2020-12-30 22:19:52', NULL, NULL, NULL);

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

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `totalprice`, `saleid`, `tableid`, `status`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(7, 50000, 1, 1, 1, '2021-01-02 22:25:39', NULL, NULL, NULL),
(8, 50000, 1, 1, 1, '2021-01-02 22:25:52', NULL, NULL, NULL),
(10, 50000, 1, 1, 1, '2021-01-02 22:27:06', NULL, NULL, NULL),
(11, 50000, 1, 1, 1, '2021-01-02 22:27:14', NULL, NULL, NULL),
(12, 50000, 1, 1, 1, '2021-01-02 22:28:36', NULL, NULL, NULL),
(14, 25555, 3, 1, 0, '2021-01-02 22:30:20', NULL, '2021-01-02 22:43:50', NULL);

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
  `createddate` datetime DEFAULT NULL,
  `createdby` varchar(255) DEFAULT NULL,
  `modifieddate` datetime DEFAULT NULL,
  `modifiedby` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`id`, `name`, `discount`, `status`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(1, 'Không có', 0, 1, '2021-01-02 22:03:48', NULL, NULL, NULL),
(2, 'Noel', 20, 1, '2021-01-02 22:03:57', NULL, NULL, NULL),
(3, 'Valentine', 10, 1, '2021-01-02 22:04:07', NULL, NULL, NULL),
(4, 'Đi trên 5 người', 10, 1, '2021-01-02 22:04:17', NULL, NULL, NULL),
(5, 'Đi trên 10 người', 15, 1, '2021-01-02 22:04:35', NULL, NULL, NULL);

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
(1, 'Bàn 1', 2, 1, '2021-01-02 22:01:43', NULL, NULL, NULL),
(2, 'Bàn 2', 4, 1, '2021-01-02 22:01:51', NULL, NULL, NULL),
(3, 'Bàn 3', 4, 1, '2021-01-02 22:01:54', NULL, NULL, NULL),
(4, 'Bàn 4', 5, 1, '2021-01-02 22:01:57', NULL, NULL, NULL),
(5, 'Bàn 5', 16, 1, '2021-01-02 22:02:04', NULL, NULL, NULL),
(6, 'Bàn 6', 7, 1, '2021-01-02 22:02:09', NULL, NULL, NULL),
(7, 'Bàn 7', 4, 1, '2021-01-02 22:02:18', NULL, NULL, NULL),
(8, 'Bàn 8', 4, 1, '2021-01-02 22:02:21', NULL, NULL, NULL),
(9, 'Bàn 9', 4, 1, '2021-01-02 22:02:24', NULL, NULL, NULL),
(10, 'Bàn 10', 4, 1, '2021-01-02 22:02:26', NULL, NULL, NULL);

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
(1, 'Huy Phước', 'php', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'php@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, '2021-01-02 09:55:50', NULL),
(2, 'Thành Đoan', 'doan', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'doan@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(3, 'Thanh Tôn', 'ton', '900150983cd24fb0d6963f7d28e17f72', '0909090909', 'Biên Hòa', 'ton@gmail.com', '2000-03-17', 'Nữ', 1, 2, NULL, NULL, '2021-01-02 10:31:41', NULL),
(4, 'Bảo Trang', 'trang', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'trang@gmail.com', '2000-02-03', 'Nữ', 1, 1, NULL, NULL, NULL, NULL),
(5, 'Thiên Long', 'longg', '202cb962ac59075b964b07152d234b70', '0232323232', 'Đắk Lắk', 'sdsd@.', '2000-02-10', 'Nam', 1, 2, NULL, NULL, '2021-01-02 16:50:05', NULL);

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
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tables`
--
ALTER TABLE `tables`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

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
