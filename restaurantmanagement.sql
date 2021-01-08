-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2021 at 05:07 PM
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
(1, 'Súp', 1, '2021-01-05 20:52:06', 'php', NULL, NULL),
(2, 'Rau', 1, '2021-01-05 20:59:12', 'php', NULL, NULL),
(3, 'Sa lát', 1, '2021-01-05 20:59:28', 'php', NULL, NULL),
(4, 'Cơm & Mì', 1, '2021-01-05 21:00:01', 'php', '2021-01-05 21:01:42', 'php'),
(5, 'Lẩu', 1, '2021-01-05 21:03:31', 'php', NULL, NULL),
(6, 'Thịt heo', 1, '2021-01-05 21:11:34', 'php', NULL, NULL),
(7, 'Thịt bò', 1, '2021-01-05 21:11:47', 'php', NULL, NULL),
(8, 'Gà', 1, '2021-01-05 21:11:56', 'php', NULL, NULL),
(9, 'Súp', 1, '2021-01-06 08:59:06', 'php', NULL, NULL),
(11, 'Chim', 1, '2021-01-07 22:15:19', 'php', NULL, NULL);

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
(1, 'Súp hải sản tuyết nhĩ', 68000, 0, 1, 1, '2021-01-05 20:56:52', 'php', '2021-01-08 20:03:54', 'php'),
(2, 'Súp gân bò', 125000, 0, 1, 1, '2021-01-05 20:57:17', 'php', '2021-01-05 20:57:38', 'php'),
(3, 'Súp bào ngư Nam Phi', 1320000, 5, 1, 1, '2021-01-05 20:58:02', 'php', NULL, NULL),
(4, 'Súp vi cá', 980000, 10, 1, 1, '2021-01-05 20:58:17', 'php', '2021-01-07 22:17:28', 'php'),
(5, 'Súp tổ yến', 1280000, 50, 1, 1, '2021-01-05 20:58:27', 'php', '2021-01-07 22:17:53', 'php'),
(6, 'Súp tôm chua cay Thái', 68000, 0, 1, 1, '2021-01-05 20:58:44', 'php', NULL, NULL),
(7, 'Mì xào bò', 95000, 5, 1, 4, '2021-01-05 21:03:49', 'php', '2021-01-08 10:11:35', 'php'),
(8, 'Mì xào hải sản', 110000, 5, 1, 4, '2021-01-05 21:04:08', 'php', NULL, NULL),
(9, 'Phở xào bò', 95000, 0, 1, 4, '2021-01-05 21:04:21', 'php', NULL, NULL),
(10, 'Cơm rang thập cẩm', 95000, 0, 1, 4, '2021-01-05 21:04:31', 'php', NULL, NULL),
(11, 'Cơm rang hải sản', 110000, 10, 1, 4, '2021-01-05 21:04:44', 'php', NULL, NULL),
(12, 'Lẩu đuôi bò', 780000, 0, 1, 5, '2021-01-05 21:05:12', 'php', NULL, NULL),
(13, 'Lẩu Thái hải sản', 1100000, 10, 1, 5, '2021-01-05 21:05:37', 'php', NULL, NULL),
(14, 'Lẩu gà', 500000, 10, 1, 5, '2021-01-05 21:05:47', 'php', NULL, NULL),
(15, 'Lẩu cá', 400000, 10, 1, 5, '2021-01-05 21:06:01', 'php', NULL, NULL),
(16, 'Lẩu riêu cua bò Úc', 950000, 10, 1, 5, '2021-01-05 21:06:15', 'php', NULL, NULL),
(17, 'Rau dền luộc', 58000, 0, 1, 2, '2021-01-05 21:06:48', 'php', NULL, NULL),
(18, 'Rau muống xào', 58000, 0, 1, 2, '2021-01-05 21:07:04', 'php', NULL, NULL),
(19, 'Rau mồng tơi xào tỏi', 58000, 0, 1, 2, '2021-01-05 21:07:28', 'php', NULL, NULL),
(20, 'Rau củ quả chấm mắm kho quẹt', 132000, 0, 1, 2, '2021-01-05 21:07:44', 'php', NULL, NULL),
(21, 'Măng tây tươi xào tôm', 210000, 0, 1, 2, '2021-01-05 21:07:58', 'php', NULL, NULL),
(22, 'Rau bí xào tỏi', 58000, 0, 1, 2, '2021-01-05 21:08:33', 'php', NULL, NULL),
(23, 'Salad rau trộn', 99000, 0, 1, 3, '2021-01-05 21:09:22', 'php', NULL, NULL),
(24, 'Salad cà chua dưa chuột', 68000, 0, 1, 3, '2021-01-05 21:09:31', 'php', NULL, NULL),
(25, 'Gỏi mướp đắng ruốc', 82000, 0, 1, 3, '2021-01-05 21:09:42', 'php', NULL, NULL),
(26, 'Salad Nga', 99000, 0, 1, 3, '2021-01-05 21:09:50', 'php', NULL, NULL),
(27, 'Salad rau quả', 128000, 0, 1, 3, '2021-01-05 21:09:57', 'php', NULL, NULL),
(28, 'Nộm bắp bò cần mỹ', 115000, 0, 1, 3, '2021-01-05 21:10:15', 'php', NULL, NULL),
(29, 'Nộm hoa chuối tôm thịt', 128000, 0, 1, 3, '2021-01-05 21:10:27', 'php', NULL, NULL),
(30, 'Ba chỉ quay', 168000, 0, 1, 6, '2021-01-05 21:12:14', 'php', NULL, NULL),
(31, 'Đùi heo phá lấu + bánh mì', 320000, 0, 1, 6, '2021-01-05 21:12:39', 'php', NULL, NULL),
(32, 'Sườn lợn nướng sốt BBQ', 320000, 0, 1, 6, '2021-01-05 21:12:54', 'php', NULL, NULL),
(33, 'Đùi heo hầm củ sen + bánh mì', 350000, 0, 1, 6, '2021-01-05 21:13:30', 'php', NULL, NULL),
(34, 'Đùi heo hầm kiểu Đức + bánh mì', 380000, 0, 1, 6, '2021-01-05 21:13:46', 'php', NULL, NULL),
(35, 'Bò xào rau', 198000, 0, 1, 7, '2021-01-05 21:13:58', 'php', NULL, NULL),
(36, 'Bò cuốn lá cải', 198000, 0, 1, 7, '2021-01-05 21:14:14', 'php', NULL, NULL),
(37, 'Bò nướng mật ong (Sa tế)', 228000, 0, 1, 7, '2021-01-05 21:14:32', 'php', NULL, NULL),
(38, 'Bò sốt tiêu đen + bánh bao', 252000, 0, 1, 7, '2021-01-05 21:14:44', 'php', NULL, NULL),
(39, 'Bò ta kho + bánh mì', 330000, 0, 1, 7, '2021-01-05 21:14:55', 'php', NULL, NULL),
(40, 'Đuôi bò hầm cà ri cốt dừa', 560000, 0, 1, 7, '2021-01-05 21:15:13', 'php', NULL, NULL),
(41, 'Gà hấp lá chanh', 318000, 0, 1, 8, '2021-01-05 21:15:38', 'php', NULL, NULL),
(42, 'Gà rang muống / rang gừng', 318000, 0, 1, 8, '2021-01-05 21:15:50', 'php', NULL, NULL),
(43, 'Gà rút xương sốt Nhật', 328000, 0, 1, 8, '2021-01-05 21:16:02', 'php', NULL, NULL),
(44, 'Gà quay mật ong', 318000, 0, 1, 8, '2021-01-05 21:16:10', 'php', NULL, NULL),
(45, 'Gà quay sốt nấm Đông Cô', 418000, 0, 1, 8, '2021-01-05 21:16:22', 'php', '2021-01-05 21:16:27', 'php'),
(46, 'Gà Đông Tảo rang muối', 880000, 0, 1, 8, '2021-01-05 21:16:49', 'php', '2021-01-05 21:17:08', 'php'),
(47, 'Gà Đông Tảo xào lăn', 880000, 0, 1, 8, '2021-01-05 21:17:01', 'php', '2021-01-05 21:17:14', 'php'),
(48, 'Chim câu rang tương', 198000, 5, 1, 11, '2021-01-07 22:15:49', 'php', NULL, NULL),
(49, 'Chim câu nướng ngũ vị', 198000, 0, 1, 11, '2021-01-07 22:16:11', 'php', '2021-01-07 22:16:43', 'php');

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

--
-- Dumping data for table `orderdetail`
--

INSERT INTO `orderdetail` (`id`, `orderid`, `foodid`, `unitprice`, `quantity`, `createddate`, `createdby`, `modifieddate`, `modifiedby`) VALUES
(105, 53, 9, 95000, 6, '2021-01-08 16:41:38', NULL, NULL, NULL),
(106, 56, 43, 328000, 6, '2021-01-08 16:55:05', NULL, NULL, NULL),
(107, 56, 45, 418000, 8, '2021-01-08 16:55:08', NULL, NULL, NULL),
(108, 57, 43, 328000, 7, '2021-01-08 16:57:18', NULL, NULL, NULL),
(109, 57, 45, 418000, 8, '2021-01-08 16:57:20', NULL, NULL, NULL),
(110, 57, 47, 880000, 3, '2021-01-08 16:57:24', NULL, NULL, NULL),
(111, 58, 10, 95000, 7, '2021-01-08 17:00:25', NULL, NULL, NULL),
(114, 60, 8, 104500, 88, '2021-01-08 17:24:23', NULL, NULL, NULL),
(115, 60, 9, 95000, 6, '2021-01-08 17:24:27', NULL, NULL, NULL),
(116, 61, 45, 418000, 13, '2021-01-08 20:03:19', NULL, NULL, NULL),
(117, 61, 44, 318000, 7, '2021-01-08 20:03:22', NULL, NULL, NULL),
(120, 63, 49, 198000, 7, '2021-01-08 20:12:10', NULL, NULL, NULL),
(121, 63, 44, 318000, 7, '2021-01-08 20:12:13', NULL, NULL, NULL),
(122, 63, 2, 125000, 7, '2021-01-08 20:24:52', NULL, NULL, NULL),
(123, 63, 3, 1254000, 6, '2021-01-08 20:24:55', NULL, NULL, NULL),
(124, 63, 4, 882000, 5, '2021-01-08 20:24:57', NULL, NULL, NULL),
(125, 64, 4, 882000, 7, '2021-01-08 20:25:23', NULL, NULL, NULL),
(126, 64, 44, 318000, 6, '2021-01-08 20:27:42', NULL, NULL, NULL),
(127, 64, 15, 360000, 6, '2021-01-08 20:38:42', NULL, NULL, NULL),
(128, 65, 49, 198000, 7, '2021-01-08 22:58:37', NULL, NULL, NULL),
(129, 66, 14, 450000, 4, '2021-01-08 23:05:23', NULL, NULL, NULL),
(130, 66, 21, 210000, 13, '2021-01-08 23:05:28', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` bigint(20) NOT NULL,
  `totalprice` bigint(20) NOT NULL,
  `saleid` bigint(20) NOT NULL DEFAULT 1,
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
(53, 541500, 2, 1, 1, '2021-01-08 16:41:37', 'ton', '2021-01-08 16:53:46', NULL),
(56, 5312000, 1, 14, 1, '2021-01-08 16:55:05', 'ton', '2021-01-08 16:55:15', NULL),
(57, 5796000, 3, 9, 1, '2021-01-08 16:57:17', 'ton', '2021-01-08 16:58:00', NULL),
(58, 665000, 1, 8, 1, '2021-01-08 17:00:25', 'ton', '2021-01-08 17:00:42', NULL),
(60, 9277700, 2, 14, 1, '2021-01-08 17:24:23', 'ton', '2021-01-08 17:24:47', NULL),
(61, 7660000, 1, 2, 1, '2021-01-08 20:03:19', 'ton', '2021-01-08 20:04:45', NULL),
(63, 13136800, 4, 10, 1, '2021-01-08 20:12:09', 'ton', '2021-01-08 20:26:05', 'ton'),
(64, 10242000, 1, 1, 1, '2021-01-08 20:25:23', 'ton', '2021-01-08 22:58:28', 'ton'),
(65, 1108800, 4, 3, 1, '2021-01-08 22:58:37', 'ton', '2021-01-08 22:58:51', 'ton'),
(66, 3624000, 4, 4, 1, '2021-01-08 23:05:22', 'ton', '2021-01-08 23:06:11', 'ton');

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
(1, 'Không có', 0, 1, '2021-01-05 21:17:36', 'php', NULL, NULL),
(2, 'Đi trên 5 người', 5, 1, '2021-01-05 21:17:43', 'php', NULL, NULL),
(3, 'Khai trương', 30, 1, '2021-01-05 21:17:48', 'php', NULL, NULL),
(4, 'Giáng sinh an lành', 20, 1, '2021-01-05 21:17:53', 'php', '2021-01-05 21:18:09', 'php'),
(5, 'Ngày lễ tình nhân', 14, 1, '2021-01-05 21:18:27', 'php', NULL, NULL),
(6, 'Đi trên 10 người', 10, 1, '2021-01-07 22:19:04', 'php', '2021-01-07 22:19:22', 'php');

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
(1, 'Bàn 1', 4, 0, '2021-01-05 20:52:21', 'php', '2021-01-08 23:05:41', 'php'),
(2, 'Bàn 2', 4, 0, '2021-01-05 20:52:30', 'php', '2021-01-08 20:25:46', 'php'),
(3, 'Bàn 3', 6, 0, '2021-01-05 20:52:35', 'php', '2021-01-08 22:58:53', 'php'),
(4, 'Bàn 4', 2, 0, '2021-01-05 20:52:40', 'php', '2021-01-08 23:06:12', NULL),
(5, 'Bàn 5', 10, 0, '2021-01-05 20:52:47', 'php', '2021-01-08 16:35:23', 'php'),
(6, 'Bàn 6', 7, 0, '2021-01-05 20:52:55', 'php', '2021-01-08 15:06:00', NULL),
(7, 'Bàn 7', 16, 0, '2021-01-05 20:53:02', 'php', '2021-01-08 11:41:48', 'php'),
(8, 'Bàn 8', 7, 0, '2021-01-05 20:53:09', 'php', '2021-01-08 17:00:43', NULL),
(9, 'Bàn 9', 4, 0, '2021-01-05 20:53:12', 'php', '2021-01-08 16:58:01', NULL),
(10, 'Bàn 10', 4, 0, '2021-01-05 20:53:14', 'php', '2021-01-08 20:26:06', NULL),
(11, 'Bàn 11', 4, 0, '2021-01-05 20:53:36', 'php', NULL, NULL),
(12, 'Bàn 12', 4, 0, '2021-01-05 20:53:39', 'php', NULL, NULL),
(13, 'Bàn 13', 4, 0, '2021-01-05 20:53:41', 'php', NULL, NULL),
(14, 'Bàn 14', 4, 0, '2021-01-05 20:53:42', 'php', '2021-01-08 17:24:47', NULL),
(15, 'Bàn 15', 4, 0, '2021-01-05 20:53:44', 'php', NULL, NULL),
(16, 'Bàn 16', 4, 0, '2021-01-05 20:53:45', 'php', NULL, NULL),
(17, 'Bàn 17', 4, 0, '2021-01-05 20:53:48', 'php', NULL, NULL),
(18, 'Bàn 18', 4, 0, '2021-01-05 20:53:50', 'php', NULL, NULL),
(19, 'Bàn 19', 4, 0, '2021-01-05 20:53:53', 'php', NULL, NULL),
(20, 'Bàn 20', 7, 0, '2021-01-05 20:53:58', 'php', NULL, NULL),
(21, 'Bàn 21', 4, 0, '2021-01-05 20:54:22', 'php', NULL, NULL),
(22, 'Bàn 22', 4, 0, '2021-01-05 20:54:27', 'php', NULL, NULL),
(23, 'Bàn 23', 7, 0, '2021-01-05 20:54:31', 'php', NULL, NULL),
(24, 'Bàn 24', 4, 0, '2021-01-05 20:54:42', 'php', NULL, NULL),
(25, 'Bàn 25', 4, 0, '2021-01-06 09:12:59', 'php', '2021-01-08 10:08:27', 'php'),
(26, 'Bàn 26', 6, 0, '2021-01-07 13:37:35', 'php', '2021-01-08 14:37:46', NULL),
(27, 'Bàn 27', 4, 0, '2021-01-07 13:37:42', 'php', '2021-01-08 14:37:50', NULL),
(28, 'Bàn 28', 4, 0, '2021-01-07 13:37:49', 'php', NULL, NULL),
(29, 'Bàn 29', 4, 0, '2021-01-07 13:37:56', 'php', '2021-01-08 14:37:36', NULL),
(30, 'Bàn 30', 7, 0, '2021-01-07 13:38:03', 'php', NULL, NULL),
(31, 'Bàn 31', 3, 0, '2021-01-07 22:18:17', 'php', '2021-01-07 22:18:22', 'php'),
(33, 'Bàn 32', 3, 0, '2021-01-07 22:18:41', 'php', NULL, NULL);

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
(3, 'Thanh Tôn', 'ton', '900150983cd24fb0d6963f7d28e17f72', '0909090909', 'Biên Hòa', 'ton@gmail.com', '2000-03-17', 'Nam', 1, 2, NULL, NULL, '2021-01-04 19:53:14', NULL),
(4, 'Bảo Trang', 'trang', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'trang@gmail.com', '2000-02-03', 'Nữ', 0, 1, NULL, NULL, NULL, NULL),
(5, 'Thiên Long', 'longg', '202cb962ac59075b964b07152d234b70', '0232323232', 'Đắk Lắk', 'sdsd@.', '2000-02-10', 'Nam', 1, 2, NULL, NULL, '2021-01-02 16:50:05', NULL),
(6, 'Nguyễn Văn A', 'vana', '202cb962ac59075b964b07152d234b70', '0916787834', 'Hà Nội ', 'nguyenvana@gmail.com', '2000-05-26', 'Nam', 1, 2, '2021-01-05 20:51:50', 'php', NULL, NULL);

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
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=131;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tables`
--
ALTER TABLE `tables`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

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
