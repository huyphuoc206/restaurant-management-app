-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 15, 2021 at 08:50 AM
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
(9, 'Thịt cừu', 1, '2021-01-06 08:59:06', 'php', '2021-01-14 20:34:08', 'php'),
(11, 'Chim', 1, '2021-01-07 22:15:19', 'php', '2021-01-14 20:40:04', 'php'),
(12, 'Tôm', 1, '2021-01-14 20:35:01', 'php', '2021-01-14 20:35:50', 'php'),
(13, 'Cua', 1, '2021-01-14 20:36:51', 'php', NULL, NULL),
(14, 'Bào ngư', 1, '2021-01-14 20:38:38', 'php', NULL, NULL),
(15, 'Cá', 1, '2021-01-14 20:40:07', 'php', NULL, NULL),
(16, 'Đồ uống', 1, '2021-01-14 20:42:01', 'php', NULL, NULL),
(17, 'Món mặn', 1, '2021-01-14 20:48:06', 'php', NULL, NULL),
(18, 'Vịt', 1, '2021-01-14 20:52:20', 'php', NULL, NULL),
(19, 'Cơm & Canh', 1, '2021-01-14 20:55:15', 'php', NULL, NULL);

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
(12, 'Lẩu đuôi ', 780000, 0, 1, 5, '2021-01-05 21:05:12', 'php', '2021-01-15 08:18:43', 'php'),
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
(49, 'Chim câu nướng ngũ vị', 198000, 0, 1, 11, '2021-01-07 22:16:11', 'php', '2021-01-07 22:16:43', 'php'),
(51, 'Sườn cừu nướng sốt tỏi lá thơm', 580000, 5, 1, 9, '2021-01-14 20:34:33', 'php', NULL, NULL),
(52, 'Đùi cừu nướng sốt tỏi lá thơm', 580000, 5, 1, 9, '2021-01-14 20:34:48', 'php', NULL, NULL),
(53, 'Tôm sú ăn gỏi', 250000, 0, 1, 12, '2021-01-14 20:35:26', 'php', NULL, NULL),
(54, 'Tôm sú sốt phô mai', 350000, 0, 1, 12, '2021-01-14 20:35:38', 'php', NULL, NULL),
(55, 'Tôm hùm Alaska', 1500000, 0, 1, 12, '2021-01-14 20:36:35', 'php', '2021-01-14 20:37:17', 'php'),
(56, 'Cua rang muối / Chiên bơ tỏi', 125000, 0, 1, 13, '2021-01-14 20:37:07', 'php', '2021-01-14 20:37:24', 'php'),
(57, 'Ghẹ hấp bia', 250000, 0, 1, 13, '2021-01-14 20:37:38', 'php', NULL, NULL),
(58, 'Cua gạch rang me / rang muối', 350000, 0, 1, 13, '2021-01-14 20:37:57', 'php', NULL, NULL),
(59, 'Cua hoàng đế', 3699000, 0, 1, 13, '2021-01-14 20:38:16', 'php', '2021-01-14 20:38:25', 'php'),
(60, 'Bào ngư Úc sốt sò điệp', 520000, 5, 1, 14, '2021-01-14 20:39:01', 'php', '2021-01-14 20:39:19', 'php'),
(61, 'Bào ngư Nam Phi sốt nấm', 3260000, 0, 1, 14, '2021-01-14 20:39:14', 'php', '2021-01-14 20:39:25', 'php'),
(62, 'Cá tầm nướng riềng mẻ', 638000, 0, 1, 15, '2021-01-14 20:40:34', 'php', '2021-01-14 20:41:19', 'php'),
(63, 'Cá hồi Sapa ăn gỏi', 960000, 0, 1, 15, '2021-01-14 20:40:47', 'php', '2021-01-14 20:41:27', 'php'),
(64, 'Cá hồi Sapa nướng sốt bơ tỏi', 1000000, 0, 1, 15, '2021-01-14 20:41:11', 'php', '2021-01-14 20:41:32', 'php'),
(65, 'Nước lọc', 7000, 0, 1, 16, '2021-01-14 20:42:15', 'php', NULL, NULL),
(66, 'Sting', 12000, 0, 1, 16, '2021-01-14 20:42:25', 'php', NULL, NULL),
(67, 'C2', 12000, 0, 1, 16, '2021-01-14 20:42:38', 'php', NULL, NULL),
(68, 'Bia Tiger', 17000, 0, 1, 16, '2021-01-14 20:43:19', 'php', '2021-01-14 20:43:46', 'php'),
(69, 'Bia Heniken', 20000, 0, 1, 16, '2021-01-14 20:43:41', 'php', '2021-01-14 20:43:51', 'php'),
(70, 'Coca', 12000, 0, 1, 16, '2021-01-14 20:44:03', 'php', NULL, NULL),
(71, 'Bia Sài Gòn', 20000, 0, 1, 16, '2021-01-14 20:44:31', 'php', NULL, NULL),
(72, 'Pepsi', 12000, 0, 1, 16, '2021-01-14 20:44:39', 'php', NULL, NULL),
(73, '7 Up', 12000, 0, 1, 16, '2021-01-14 20:44:49', 'php', NULL, NULL),
(74, 'Lẩu gà Đông Tảo', 980000, 10, 1, 5, '2021-01-14 20:47:02', 'php', NULL, NULL),
(75, 'Trứng đúc thịt', 72000, 10, 1, 17, '2021-01-14 20:48:19', 'php', NULL, NULL),
(76, 'Trứng đúc tôm tươi', 198000, 0, 1, 17, '2021-01-14 20:48:31', 'php', NULL, NULL),
(77, 'Ba chỉ rang cháy cạnh', 120000, 0, 1, 17, '2021-01-14 20:48:44', 'php', NULL, NULL),
(78, 'Ba chỉ luộc chấm mắm tép', 120000, 0, 1, 17, '2021-01-14 20:48:54', 'php', NULL, NULL),
(79, 'Thân lợn rim tôm', 238000, 0, 1, 17, '2021-01-14 20:49:04', 'php', NULL, NULL),
(80, 'Ba chỉ rang tôm', 238000, 0, 1, 17, '2021-01-14 20:49:12', 'php', NULL, NULL),
(81, 'Sườn rim mặn', 180000, 0, 1, 17, '2021-01-14 20:49:25', 'php', NULL, NULL),
(82, 'Sườn xào chua ngọt', 180000, 0, 1, 17, '2021-01-14 20:49:36', 'php', NULL, NULL),
(83, 'Cá kho tộ', 110000, 0, 1, 17, '2021-01-14 20:49:43', 'php', NULL, NULL),
(84, 'Cá chình trắng nướng riềng mẻ', 980000, 0, 1, 15, '2021-01-14 20:50:39', 'php', NULL, NULL),
(85, 'Cá tuyết nướng sốt đặc biệt', 480000, 0, 1, 15, '2021-01-14 20:51:07', 'php', NULL, NULL),
(86, 'Gà xào lăn', 680000, 0, 1, 8, '2021-01-14 20:51:55', 'php', NULL, NULL),
(87, 'Vịt trời hấp xôi', 680000, 0, 1, 18, '2021-01-14 20:52:32', 'php', '2021-01-14 20:55:48', 'php'),
(88, 'Vịt quay', 300000, 0, 1, 18, '2021-01-14 20:52:41', 'php', '2021-01-14 20:55:55', 'php'),
(89, 'Vịt tiềm củ sen + bánh mỳ', 350000, 0, 1, 18, '2021-01-14 20:52:55', 'php', '2021-01-14 20:55:42', 'php'),
(90, 'Cá Song thường ăn gỏi', 890000, 0, 1, 15, '2021-01-14 20:53:39', 'php', NULL, NULL),
(91, 'Rau (ăn thêm)', 45000, 0, 1, 5, '2021-01-14 20:54:15', 'php', NULL, NULL),
(92, 'Mì tôm (ăn thêm)', 10000, 0, 1, 5, '2021-01-14 20:54:26', 'php', NULL, NULL),
(93, 'Bún (ăn thêm)', 20000, 0, 1, 5, '2021-01-14 20:54:35', 'php', NULL, NULL),
(94, 'Lẩu bắp bò Kobe', 1560000, 0, 1, 5, '2021-01-14 20:54:57', 'php', NULL, NULL),
(95, 'Canh cua mồng tơi', 68000, 0, 1, 19, '2021-01-14 20:55:23', 'php', '2021-01-14 20:56:01', 'php'),
(96, 'Canh ngao chua', 68000, 0, 1, 19, '2021-01-14 20:55:29', 'php', '2021-01-14 20:56:05', 'php'),
(97, 'Canh thịt nấu chua', 68000, 0, 1, 19, '2021-01-14 20:56:15', 'php', NULL, NULL),
(98, 'Canh cải thịt', 68000, 0, 1, 19, '2021-01-14 20:56:22', 'php', NULL, NULL),
(99, 'Canh rau dền om trứng bách thảo', 98000, 0, 1, 19, '2021-01-14 20:56:43', 'php', NULL, NULL),
(100, 'Cơm trắng', 38000, 0, 1, 19, '2021-01-14 20:56:54', 'php', NULL, NULL),
(101, 'Cà pháo', 15000, 0, 1, 19, '2021-01-14 20:57:02', 'php', NULL, NULL);

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
(130, 66, 21, 210000, 13, '2021-01-08 23:05:28', NULL, NULL, NULL),
(131, 67, 49, 198000, 7, '2021-01-09 07:11:36', NULL, NULL, NULL),
(133, 67, 9, 95000, 6, '2021-01-09 07:11:44', NULL, NULL, NULL),
(134, 67, 11, 99000, 8, '2021-01-09 07:11:45', NULL, NULL, NULL),
(136, 69, 17, 58000, 6, '2021-01-09 07:17:33', NULL, NULL, NULL),
(139, 71, 49, 198000, 12, '2021-01-09 23:44:39', NULL, NULL, NULL),
(140, 72, 10, 95000, 7, '2021-01-09 23:44:45', NULL, NULL, NULL),
(141, 71, 48, 188100, 3, '2021-01-09 23:44:56', NULL, NULL, NULL),
(142, 71, 44, 318000, 6, '2021-01-09 23:45:00', NULL, NULL, NULL),
(146, 71, 10, 95000, 12, '2021-01-11 10:14:23', NULL, NULL, NULL),
(147, 75, 13, 990000, 6, '2021-01-14 10:33:28', NULL, NULL, NULL),
(148, 75, 15, 360000, 9, '2021-01-14 10:33:31', NULL, NULL, NULL),
(149, 76, 14, 450000, 5, '2021-01-14 10:43:04', NULL, NULL, NULL),
(150, 76, 13, 990000, 5, '2021-01-14 10:43:08', NULL, NULL, NULL),
(151, 76, 36, 198000, 6, '2021-01-14 10:43:16', NULL, NULL, NULL),
(153, 78, 9, 95000, 3, '2021-01-14 14:03:21', NULL, NULL, NULL),
(154, 79, 10, 95000, 7, '2021-01-14 14:04:06', NULL, NULL, NULL),
(156, 81, 15, 360000, 7, '2021-01-14 14:04:38', NULL, NULL, NULL),
(157, 82, 49, 198000, 6, '2021-01-14 14:06:07', NULL, NULL, NULL),
(158, 82, 14, 450000, 6, '2021-01-14 14:12:27', NULL, NULL, NULL),
(159, 82, 15, 360000, 6, '2021-01-14 14:12:29', NULL, NULL, NULL),
(160, 82, 16, 855000, 8, '2021-01-14 14:12:32', NULL, NULL, NULL),
(161, 83, 49, 198000, 3, '2021-01-14 14:16:57', NULL, NULL, NULL),
(162, 84, 15, 360000, 6, '2021-01-14 14:42:56', NULL, NULL, NULL),
(163, 84, 14, 450000, 5, '2021-01-14 14:43:00', NULL, NULL, NULL),
(176, 94, 61, 3260000, 8, '2021-01-15 07:49:15', NULL, NULL, NULL),
(177, 95, 60, 494000, 99, '2021-01-15 07:49:19', NULL, NULL, NULL),
(178, 94, 60, 494000, 2, '2021-01-15 07:49:27', NULL, NULL, NULL),
(179, 94, 55, 1500000, 4, '2021-01-15 07:50:15', NULL, NULL, NULL),
(180, 95, 61, 3260000, 3, '2021-01-15 08:15:55', NULL, NULL, NULL);

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
(53, 541500, 2, 1, 1, '2021-01-08 16:41:37', 'ton', '2021-02-05 16:53:46', NULL),
(56, 5312000, 1, 14, 1, '2021-01-08 16:55:05', 'ton', '2021-01-08 16:55:15', NULL),
(57, 5796000, 3, 9, 1, '2021-01-08 16:57:17', 'ton', '2021-01-08 16:58:00', NULL),
(58, 665000, 1, 8, 1, '2021-01-08 17:00:25', 'ton', '2021-01-08 17:00:42', NULL),
(60, 9277700, 2, 14, 1, '2021-01-08 17:24:23', 'ton', '2021-01-08 17:24:47', NULL),
(61, 7660000, 1, 2, 1, '2021-01-08 20:03:19', 'ton', '2021-01-08 20:04:45', NULL),
(63, 13136800, 4, 10, 1, '2021-01-08 20:12:09', 'ton', '2021-01-08 20:26:05', 'ton'),
(64, 10242000, 1, 1, 1, '2021-01-08 20:25:23', 'ton', '2021-01-08 22:58:28', 'ton'),
(65, 1108800, 4, 3, 1, '2021-01-08 22:58:37', 'ton', '2021-01-08 22:58:51', 'ton'),
(66, 3624000, 4, 4, 1, '2021-01-08 23:05:22', 'ton', '2021-01-08 23:06:11', 'ton'),
(67, 1923600, 3, 8, 1, '2021-01-09 07:11:36', 'ton', '2021-01-09 07:20:16', 'ton'),
(69, 348000, 1, 3, 1, '2021-01-09 07:17:33', 'ton', '2021-01-09 07:24:00', 'ton'),
(71, 5149938, 5, 2, 1, '2021-01-09 23:44:39', 'ton', '2021-01-13 22:51:47', 'ton'),
(72, 631750, 2, 5, 1, '2021-01-09 23:44:45', 'ton', '2021-01-10 08:59:24', 'ton'),
(75, 8721000, 2, 1, 1, '2021-01-14 10:33:28', 'ton', '2021-01-14 10:34:20', 'ton'),
(76, 7968600, 2, 2, 1, '2021-01-14 10:43:03', 'ton', '2021-01-14 10:44:14', 'ton'),
(78, 270750, 2, 2, 1, '2021-02-14 14:03:20', 'ton', '2021-02-14 14:03:40', 'ton'),
(79, 631750, 2, 2, 1, '2021-03-14 14:04:06', 'ton', '2021-03-14 14:04:45', 'ton'),
(81, 2394000, 2, 4, 1, '2021-02-14 14:04:38', 'ton', '2021-02-14 14:05:21', 'ton'),
(82, 9021600, 3, 1, 1, '2021-02-14 14:06:07', 'ton', '2021-02-14 14:14:11', 'ton'),
(83, 475200, 4, 19, 1, '2021-01-14 14:16:57', 'ton', '2021-01-14 14:18:00', 'ton'),
(84, 4410000, 1, 8, 1, '2021-01-14 14:42:56', 'ton', '2021-01-14 14:43:05', 'ton'),
(94, 0, 1, 7, 0, '2021-01-15 07:49:14', 'ton', '2021-01-15 07:49:46', 'ton'),
(95, 41080200, 3, 3, 1, '2021-01-15 07:49:18', 'ton', '2021-01-15 08:17:11', 'ton');

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
(6, 'Đi trên 10 người', 10, 0, '2021-01-07 22:19:04', 'php', '2021-01-15 08:20:12', 'php');

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
(1, 'Bàn 1', 4, 0, '2021-01-05 20:52:21', 'php', '2021-01-15 08:16:32', 'php'),
(2, 'Bàn 2', 4, 0, '2021-01-05 20:52:30', 'php', '2021-01-15 08:16:22', 'php'),
(3, 'Bàn 3', 6, 0, '2021-01-05 20:52:35', 'php', '2021-01-15 08:17:12', 'php'),
(4, 'Bàn 4', 2, 0, '2021-01-05 20:52:40', 'php', '2021-01-15 07:43:15', NULL),
(5, 'Bàn 5', 10, 0, '2021-01-05 20:52:47', 'php', '2021-01-14 10:44:06', 'php'),
(6, 'Bàn 6', 7, 0, '2021-01-05 20:52:55', 'php', '2021-01-08 15:06:00', NULL),
(7, 'Bàn 7', 16, 1, '2021-01-05 20:53:02', 'php', '2021-01-15 07:49:48', 'php'),
(8, 'Bàn 8', 7, 0, '2021-01-05 20:53:09', 'php', '2021-01-15 07:40:50', NULL),
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
(19, 'Bàn 19', 4, 0, '2021-01-05 20:53:53', 'php', '2021-01-14 14:18:00', NULL),
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
(1, 'Huy Phước', 'php', 'e10adc3949ba59abbe56e057f20f883e', '0909090909', 'HCM City', 'php@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, '2021-01-11 10:12:32', NULL),
(2, 'Thành Đoan', 'doan', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'doan@gmail.com', '2000-02-03', 'Nam', 1, 1, NULL, NULL, NULL, NULL),
(3, 'Thanh Tôn', 'ton', '900150983cd24fb0d6963f7d28e17f72', '0909090909', 'Biên Hòa', 'ton@gmail.com', '2000-03-17', 'Nam', 1, 2, NULL, NULL, '2021-01-14 20:59:13', NULL),
(4, 'Bảo Trang', 'trang', '202cb962ac59075b964b07152d234b70', '0909090909', 'HCM City', 'trang@gmail.com', '2000-02-03', 'Nữ', 0, 1, NULL, NULL, NULL, NULL),
(5, 'Thiên Long', 'long', '202cb962ac59075b964b07152d234b70', '0232323232', 'Đắk Lắk', 'sdsd@.', '2000-02-10', 'Nam', 1, 2, NULL, NULL, '2021-01-14 20:59:32', 'php'),
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
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;

--
-- AUTO_INCREMENT for table `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=182;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

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
