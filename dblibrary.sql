-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2021 at 03:44 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblibrary`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbooknumber`
--

CREATE TABLE `tblbooknumber` (
  `ID` int(11) NOT NULL,
  `BOOKTITLE` varchar(255) CHARACTER SET utf8 NOT NULL,
  `QTY` int(11) NOT NULL,
  `Desc` varchar(90) CHARACTER SET utf8 NOT NULL,
  `Author` varchar(90) CHARACTER SET utf8 NOT NULL,
  `PublishDate` date NOT NULL,
  `Publisher` varchar(90) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooknumber`
--

INSERT INTO `tblbooknumber` (`ID`, `BOOKTITLE`, `QTY`, `Desc`, `Author`, `PublishDate`, `Publisher`) VALUES
(20, 'AI', 1, 'Mô tả về AI', 'Aladin', '2019-02-05', 'Aladin'),
(21, 'Dòng điện', 1, 'Mô tả về dòng điện', 'BGD', '2000-06-14', 'NXB GD'),
(22, 'Công nghệ', 1, 'Bla bla', 'Unknown', '2021-12-07', 'unknown'),
(23, 'Công nghệ 2', 1, 'balaaa', 'Unknown', '2021-12-03', 'Unknown'),
(24, 'Người trở về từ lòng đất', 1, 'Những cái chết bí ẩn', 'Quo', '2021-12-03', 'KDEnter');

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `BookID` int(11) NOT NULL,
  `AccessionNo` varchar(90) CHARACTER SET utf8 NOT NULL,
  `BookTitle` varchar(125) CHARACTER SET utf8 NOT NULL,
  `BookDesc` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Author` varchar(125) CHARACTER SET utf8 NOT NULL,
  `PublishDate` date NOT NULL,
  `BookPublisher` varchar(125) CHARACTER SET utf8 NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `BookPrice` double NOT NULL,
  `BookQuantity` int(11) NOT NULL,
  `Status` varchar(30) CHARACTER SET utf8 NOT NULL,
  `BookType` varchar(90) CHARACTER SET utf8 NOT NULL,
  `DeweyDecimal` varchar(90) CHARACTER SET utf8 NOT NULL,
  `OverAllQty` int(11) NOT NULL,
  `Donate` tinyint(1) NOT NULL,
  `Remark` varchar(90) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`BookID`, `AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`, `Status`, `BookType`, `DeweyDecimal`, `OverAllQty`, `Donate`, `Remark`) VALUES
(25, 'KH_001', 'AI', 'Mô tả về AI', 'Aladin', '2019-02-05', 'Aladin', 1, 0, 1, 'Available', 'Unknown', '', 1, 0, 'Donate'),
(26, 'VL_001', 'Dòng điện', 'Mô tả về dòng điện', 'BGD', '2000-06-14', 'NXB GD', 1, 0, 1, 'Not Available', 'Unknown', '', 1, 0, 'Donate'),
(27, 'CN_001', 'Công nghệ', 'Bla bla', 'Unknown', '2021-12-07', 'unknown', 6, 0, 1, 'Not Available', 'Unknown', '', 1, 0, 'Donate'),
(28, 'CN_002', 'Công nghệ 2', 'balaaa', 'Unknown', '2021-12-03', 'Unknown', 6, 0, 1, 'Available', 'Unknown', '', 1, 0, 'Donate'),
(29, 'KD_001', 'Người trở về từ lòng đất', 'Những cái chết bí ẩn', 'Quo', '2021-12-03', 'KDEnter', 7, 0, 1, 'Available', 'Unknown', '', 1, 0, 'Donate');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrow`
--

CREATE TABLE `tblborrow` (
  `BorrowId` int(11) NOT NULL,
  `AccessionNo` varchar(90) CHARACTER SET utf8 NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateBorrowed` datetime NOT NULL,
  `Purpose` varchar(90) CHARACTER SET utf8 NOT NULL,
  `Status` varchar(30) CHARACTER SET utf8 NOT NULL,
  `DueDate` datetime NOT NULL,
  `BorrowerId` varchar(30) CHARACTER SET utf8 NOT NULL,
  `Due` tinyint(1) NOT NULL,
  `Remarks` varchar(90) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrow`
--

INSERT INTO `tblborrow` (`BorrowId`, `AccessionNo`, `NoCopies`, `DateBorrowed`, `Purpose`, `Status`, `DueDate`, `BorrowerId`, `Due`, `Remarks`) VALUES
(41, 'KD_001', 1, '2021-12-03 21:38:05', 'Overnight', 'Returned', '2021-12-04 21:38:05', 'HS01', 0, 'On Time'),
(42, 'VL_001', 1, '2021-12-03 21:38:27', 'Research', 'Borrowed', '2021-12-03 17:30:00', 'HS02', 0, ''),
(43, 'CN_002', 1, '2021-12-03 21:39:26', 'Photocopy', 'Returned', '2021-12-03 22:09:26', 'HS04', 0, 'On Time'),
(44, 'CN_001', 1, '2021-12-03 21:39:50', 'Photocopy', 'Borrowed', '2021-12-03 22:09:50', 'HS01', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrower`
--

CREATE TABLE `tblborrower` (
  `IDNO` int(11) NOT NULL,
  `BorrowerId` varchar(90) CHARACTER SET utf8 NOT NULL,
  `Firstname` varchar(125) CHARACTER SET utf8 NOT NULL,
  `Lastname` varchar(125) CHARACTER SET utf8 NOT NULL,
  `MiddleName` varchar(125) CHARACTER SET utf8 NOT NULL,
  `Address` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Sex` varchar(11) CHARACTER SET utf8 NOT NULL,
  `ContactNo` varchar(125) CHARACTER SET utf8 NOT NULL,
  `CourseYear` varchar(125) CHARACTER SET utf8 NOT NULL,
  `BorrowerPhoto` varchar(255) CHARACTER SET utf8 NOT NULL,
  `BorrowerType` varchar(35) CHARACTER SET utf8 NOT NULL,
  `Stats` varchar(36) CHARACTER SET utf8 NOT NULL,
  `IMGBLOB` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrower`
--

INSERT INTO `tblborrower` (`IDNO`, `BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`, `BorrowerPhoto`, `BorrowerType`, `Stats`, `IMGBLOB`) VALUES
(16, 'HS01', 'Quốc', 'Nguyễn Lê', 'Anh', 'Tây Ninh', 'Nam', '03937168xx', '2001', '', 'Student', 'Active', ''),
(17, 'HS02', 'Ý', 'Phạm', 'Như', 'Đồng Tháp', 'Nữ', '03333654654', '2001', '', 'Student', 'Active', ''),
(18, 'HS03', 'Thiện', 'Võ', 'Phúc', 'TPHCM', 'Nam', '4654987461', '2001', '', 'Student', 'Active', ''),
(19, 'HS04', 'Điểm', 'ĐInh', 'Hữu', 'TPHCM', 'Nam', '4684684', '2001', '', 'Student', 'Active', ''),
(20, 'HS05', 'Khoa', 'Trần Đoàn', 'Đăng', 'TPHCM', 'Nam', '8786431321', '2001', '', 'Student', 'Active', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `CategoryId` int(11) NOT NULL,
  `Category` varchar(125) CHARACTER SET utf8 NOT NULL,
  `DDecimal` varchar(90) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`CategoryId`, `Category`, `DDecimal`) VALUES
(1, 'Khoa học máy tính', '000'),
(2, 'Vật lý', '100'),
(3, 'Địa lý', '200'),
(4, 'Xã hội', '300'),
(5, 'Ngôn ngữ', '400'),
(6, 'Công nghệ', '500'),
(7, 'Kinh dị', '600'),
(8, 'ALL', 'ALL');

-- --------------------------------------------------------

--
-- Table structure for table `tbllogs`
--

CREATE TABLE `tbllogs` (
  `LogId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `LogDate` datetime NOT NULL,
  `LogMode` varchar(30) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `PaymentId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `Payment` double NOT NULL,
  `Change` double NOT NULL,
  `DatePayed` date NOT NULL,
  `BorrowerId` int(11) NOT NULL,
  `Remarks` varchar(125) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `ReturnId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateReturned` datetime NOT NULL,
  `Remarks` varchar(125) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`ReturnId`, `BorrowId`, `NoCopies`, `DateReturned`, `Remarks`) VALUES
(30, 41, 1, '2021-12-03 21:38:43', 'Returned'),
(31, 43, 1, '2021-12-03 21:40:30', 'Returned');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `UserId` int(11) NOT NULL,
  `Fullname` varchar(124) CHARACTER SET utf8 NOT NULL,
  `User_name` varchar(125) CHARACTER SET utf8 NOT NULL,
  `Pass` varchar(125) CHARACTER SET utf8 NOT NULL,
  `UserRole` varchar(125) CHARACTER SET utf8 NOT NULL,
  `Status` varchar(11) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`UserId`, `Fullname`, `User_name`, `Pass`, `UserRole`, `Status`) VALUES
(3, 'Admin', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Thủ thư', 'Active'),
(4, 'Quoc NLA', 'Q', '22ea1c649c82946aa6e479e1ffd321e4a318b1b0', 'Độc giả', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `tblborrow`
--
ALTER TABLE `tblborrow`
  ADD PRIMARY KEY (`BorrowId`);

--
-- Indexes for table `tblborrower`
--
ALTER TABLE `tblborrower`
  ADD PRIMARY KEY (`IDNO`),
  ADD UNIQUE KEY `BorrowerId` (`BorrowerId`);

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `tbllogs`
--
ALTER TABLE `tbllogs`
  ADD PRIMARY KEY (`LogId`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`PaymentId`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`ReturnId`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tblborrow`
--
ALTER TABLE `tblborrow`
  MODIFY `BorrowId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tblborrower`
--
ALTER TABLE `tblborrower`
  MODIFY `IDNO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbllogs`
--
ALTER TABLE `tbllogs`
  MODIFY `LogId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=483;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `PaymentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `ReturnId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
