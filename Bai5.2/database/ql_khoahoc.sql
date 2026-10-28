-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 28, 2026 at 08:38 AM
-- Server version: 10.11.16-MariaDB
-- PHP Version: 8.3.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ql_khoahoc`
--

-- --------------------------------------------------------

--
-- Table structure for table `dangkykhoahoc`
--

CREATE TABLE `dangkykhoahoc` (
  `Id` int(11) NOT NULL,
  `SoDienThoai` varchar(20) NOT NULL,
  `NgaySinh` date NOT NULL,
  `GioiTinh` varchar(10) DEFAULT NULL,
  `MaKhoaHoc` varchar(20) DEFAULT NULL,
  `TuyChonThem` varchar(100) DEFAULT NULL,
  `NgayDangKy` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `dangkykhoahoc`
--

INSERT INTO `dangkykhoahoc` (`Id`, `SoDienThoai`, `NgaySinh`, `GioiTinh`, `MaKhoaHoc`, `TuyChonThem`, `NgayDangKy`) VALUES
(1, '(123) 124-1241', '2026-10-28', 'Nam', 'CS101', 'Không chọn', '2026-10-28 14:38:31');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dangkykhoahoc`
--
ALTER TABLE `dangkykhoahoc`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dangkykhoahoc`
--
ALTER TABLE `dangkykhoahoc`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
