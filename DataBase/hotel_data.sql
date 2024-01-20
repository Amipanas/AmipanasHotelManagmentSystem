-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2022 at 04:35 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `CategoryID` int(10) NOT NULL,
  `Label` varchar(20) NOT NULL,
  `Price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`CategoryID`, `Label`, `Price`) VALUES
(1, 'یک تخته', 1000),
(2, 'دو تخته', 1500),
(3, 'خانواده', 2000),
(4, 'سوئیت', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `guests`
--

CREATE TABLE `guests` (
  `ID` varchar(10) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Family` varchar(20) NOT NULL,
  `RoomID` int(5) NOT NULL,
  `Phone` varchar(11) NOT NULL,
  `City` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guests`
--

INSERT INTO `guests` (`ID`, `Name`, `Family`, `RoomID`, `Phone`, `City`) VALUES
('0123456789', 'سید امیر پارسا', 'نصیری', 0, '09362967921', 'تهران'),
('0123456790', 'محمد', 'رضایی', 0, '09121234566', 'همدان'),
('0123456791', 'امیر احمد', 'کریمی', 0, '09121234565', 'تبریز'),
('0123456793', 'ترانه', 'سروری', 0, '09382567894', 'ساری'),
('0123456794', 'اسماعیل', 'سعیدی', 0, '09397896461', 'اصفهان'),
('0123456795', 'شهرزاد', 'خدادوست', 0, '09127834215', 'یزد'),
('0123456796', 'هدی', 'حسینی', 0, '09361297692', 'تهران'),
('0123456797', 'سپهر', 'عطایی', 0, '09912257836', 'اصفهان'),
('0123456798', 'سپیده', 'اشرفی', 0, '09922247621', 'تهران'),
('0123456799', 'شیوا', 'رمضانی', 0, '09125876690', 'چالوس'),
('0123456800', 'اسحاق', 'اسفندیار', 0, '09128371213', 'تهران'),
('0123456801', 'محمدرضا', 'فرقانی', 0, '09148500769', 'سراب'),
('0123456802', 'سیاوش', 'ناصری', 0, '09217452601', 'مهران'),
('0123456803', 'فاطمه', 'اسدی', 40, '09037942827', 'اراک'),
('0123456804', 'مهران', 'محمدی نژاد', 90, '09121020365', 'کازرون');

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

CREATE TABLE `reservations` (
  `ReserveID` int(10) NOT NULL,
  `GuestID` int(10) NOT NULL,
  `RoomNo` varchar(10) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `RoomID` int(5) NOT NULL,
  `RoomType` int(5) NOT NULL,
  `RoomPhone` int(15) NOT NULL,
  `RoomStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`RoomID`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES
(10, 2, 42501, 'خالی'),
(20, 2, 42502, 'خالی'),
(30, 1, 42503, 'خالی'),
(40, 1, 42504, 'پر'),
(50, 3, 42505, 'پر'),
(60, 3, 42506, 'پر'),
(80, 3, 42508, 'خالی'),
(90, 4, 42509, 'پر'),
(100, 4, 42510, 'خالی'),
(110, 1, 42511, 'خالی');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'Admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryID`);

--
-- Indexes for table `guests`
--
ALTER TABLE `guests`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`ReserveID`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`RoomID`),
  ADD KEY `RoomType` (`RoomType`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reservations`
--
ALTER TABLE `reservations`
  MODIFY `ReserveID` int(10) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `room`
--
ALTER TABLE `room`
  ADD CONSTRAINT `room_ibfk_1` FOREIGN KEY (`RoomType`) REFERENCES `category` (`CategoryID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
