-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 14, 2023 at 10:31 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_gammis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_activity_logs`
--

CREATE TABLE `tbl_activity_logs` (
  `log_id` int(11) NOT NULL,
  `reference_id` varchar(50) NOT NULL,
  `activity` varchar(100) NOT NULL,
  `outcome` enum('PROCESS.SUCCESS','PROCESS.ERROR','PROCESS.FAILED') NOT NULL DEFAULT 'PROCESS.SUCCESS',
  `object` enum('USER.MEMBER','USER.GROUP','USER.PARTNER','USER.STAFF') NOT NULL COMMENT 'This is the type of system user who is associated with the reference_id.',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_branches`
--

CREATE TABLE `tbl_branches` (
  `id` int(11) NOT NULL,
  `branch_code` varchar(5) NOT NULL,
  `branch_name` varchar(255) NOT NULL,
  `address_line_1` varchar(100) NOT NULL,
  `address_line_2` varchar(100) NOT NULL,
  `city` int(11) NOT NULL,
  `contact_phone` varchar(15) NOT NULL,
  `contact_email` varchar(100) NOT NULL,
  `status` enum('BRANCH.ACTIVE','BRANCH.CLOSED','BRANCH.DELETED') NOT NULL DEFAULT 'BRANCH.ACTIVE',
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_branches`
--

INSERT INTO `tbl_branches` (`id`, `branch_code`, `branch_name`, `address_line_1`, `address_line_2`, `city`, `contact_phone`, `contact_email`, `status`, `updated_at`, `created_at`) VALUES
(7, '1001', 'eNOtech Internet Café 1', 'Area 24, Police Street', '', 3, '0991312995', '', 'BRANCH.ACTIVE', '2023-06-21 08:08:09', '2023-06-21 08:08:09');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_charges`
--

CREATE TABLE `tbl_charges` (
  `charge_id` int(11) NOT NULL,
  `charge_name` varchar(200) NOT NULL,
  `metric` enum('PERCENTAGE','FIXED_AMOUNT') NOT NULL,
  `value` decimal(18,2) NOT NULL,
  `status` enum('AWAITING.APPROVAL','AWAITING.AUTHORIZATION','ACTIVE','SUSPENDED') NOT NULL DEFAULT 'AWAITING.APPROVAL',
  `applied_to` enum('ITEM.ACCOUNT','ITEM.PRODUCT','ITEM.SERVICE','ITEM.UNDEFINED') NOT NULL,
  `point_in_time` enum('ON.CREATION','ON.APPROVAL','ON.AUTHORIZATION','ON.FIRST_USE','ON.TIME_DAILY','ON.TIME_WEEKLY','ON.TIME_MONTHLY','ON.TIME_ANNUALY','ON.TIME_FIXED_DATE') NOT NULL,
  `fixed_charge_date` date DEFAULT NULL,
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_chart_of_gaming_content_categories`
--

CREATE TABLE `tbl_chart_of_gaming_content_categories` (
  `id` int(11) NOT NULL,
  `ref_code` int(11) NOT NULL DEFAULT (floor(rand() * (99999 - 10000 + 1)) + 10000),
  `name` varchar(255) DEFAULT NULL,
  `status` enum('CATEGORY.ACTIVE','CATEGORY.CLOSED','CATEGORY.DELETED') NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_chart_of_gaming_types`
--

CREATE TABLE `tbl_chart_of_gaming_types` (
  `id` int(11) NOT NULL,
  `gl_code` int(11) NOT NULL,
  `gaming_type_name` varchar(100) NOT NULL,
  `gamers_group` enum('INTERNAL','EXTERNAL') NOT NULL,
  `description` varchar(255) DEFAULT 'No Description',
  `status` enum('ACTIVE','INACTIVE') NOT NULL DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci COMMENT='Gaming Types';

--
-- Dumping data for table `tbl_chart_of_gaming_types`
--

INSERT INTO `tbl_chart_of_gaming_types` (`id`, `gl_code`, `gaming_type_name`, `gamers_group`, `description`, `status`) VALUES
(9, 15179, 'CHANGU GAMING SHIFT', 'INTERNAL', 'This is the short time gaming mode where by it is used in sample and fair games rather than FIFA', 'ACTIVE'),
(10, 68892, 'KUPHUNZIRA GAMING SHIFT', 'INTERNAL', 'This is the normal time gaming mode where by it is used in sample and fair games such GOD OF WAR and FIFA', 'ACTIVE'),
(11, 18922, 'SPECIAL OFFER GAMING SHIFT', 'INTERNAL', 'This is the choose personal time gaming mode where by it is used in sample and fair games such GOD OF WAR and FIFA', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_cities`
--

CREATE TABLE `tbl_cities` (
  `id` int(11) NOT NULL,
  `city_name` varchar(20) NOT NULL,
  `code` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_cities`
--

INSERT INTO `tbl_cities` (`id`, `city_name`, `code`) VALUES
(3, 'Lilongwe', '1'),
(4, 'Blantyre', '2');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_contacts`
--

CREATE TABLE `tbl_contacts` (
  `contact_id` int(11) NOT NULL,
  `member_id` varchar(10) NOT NULL,
  `contact_type` enum('EMAIL_ADDRESS','PHONE_NUMBER','PHYSICAL_ADDRESS') NOT NULL,
  `contact` varchar(100) NOT NULL,
  `status` enum('AVAILABLE','DELETED') NOT NULL DEFAULT 'AVAILABLE',
  `stamp` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_countries`
--

CREATE TABLE `tbl_countries` (
  `id` int(11) NOT NULL,
  `country` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `is_default` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_countries`
--

INSERT INTO `tbl_countries` (`id`, `country`, `is_default`) VALUES
(265, 'Malawi', 0),
(266, 'South Africa', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_currencies`
--

CREATE TABLE `tbl_currencies` (
  `id` int(11) NOT NULL,
  `country` int(11) NOT NULL,
  `currency` varchar(255) DEFAULT NULL,
  `code` varchar(255) DEFAULT NULL,
  `symbol` varchar(255) DEFAULT NULL,
  `is_default` tinyint(1) DEFAULT NULL,
  `created_by` int(11) DEFAULT NULL,
  `updated_by` int(11) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_currencies`
--

INSERT INTO `tbl_currencies` (`id`, `country`, `currency`, `code`, `symbol`, `is_default`, `created_by`, `updated_by`, `created_at`, `updated_at`) VALUES
(5, 265, 'Malawi Kwacha', 'MK', 'MK', 1, 312167, 312167, '2023-06-21 08:10:20', '2023-06-21 08:10:20');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_gaming_content`
--

CREATE TABLE `tbl_gaming_content` (
  `id` int(11) NOT NULL,
  `ref_code` int(11) NOT NULL DEFAULT (floor(rand() * (99999 - 10000 + 1)) + 10000),
  `full_name` varchar(255) DEFAULT NULL,
  `licenses` int(11) NOT NULL,
  `available_at` int(11) NOT NULL,
  `categories` int(11) NOT NULL,
  `modified_on` timestamp NULL DEFAULT current_timestamp(),
  `status` enum('CONTENT.ACTIVE','CONTENT.CLOSED','CONTENT.DELETED') NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_gaming_types`
--

CREATE TABLE `tbl_gaming_types` (
  `id` int(11) NOT NULL,
  `gl_code` int(11) NOT NULL,
  `gaming_level_type` enum('ELITE','SEMI-PRO','AMATEUR','DEFAULT') DEFAULT 'DEFAULT',
  `annual_interest_rate` decimal(10,8) DEFAULT 0.00000000,
  `minimum_balance` decimal(18,2) DEFAULT NULL,
  `minutes_duration` int(11) DEFAULT NULL,
  `monthly_maintenance_fee` decimal(18,2) DEFAULT NULL,
  `status` enum('ON-OFFER','REVOKED') NOT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbl_gaming_types`
--

INSERT INTO `tbl_gaming_types` (`id`, `gl_code`, `gaming_level_type`, `annual_interest_rate`, `minimum_balance`, `minutes_duration`, `monthly_maintenance_fee`, `status`, `created_at`, `updated_at`) VALUES
(10, 15179, 'SEMI-PRO', '0.00000000', '200.00', 10, '18000.00', 'ON-OFFER', '2023-06-27 20:29:00', '2023-06-28 20:41:36'),
(11, 68892, 'ELITE', '0.00000000', '300.00', 10, '27000.00', 'ON-OFFER', '2023-06-27 20:32:43', '2023-06-28 20:41:43'),
(12, 18922, 'DEFAULT', '0.00000000', '2000.00', NULL, '30000.00', 'ON-OFFER', '2023-06-27 20:36:35', '2023-06-28 20:41:52');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_members`
--

CREATE TABLE `tbl_members` (
  `member_id` int(10) NOT NULL,
  `title` varchar(10) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `othernames` varchar(255) DEFAULT NULL,
  `gender` enum('MALE','FEMALE','OTHER') NOT NULL,
  `dob` varchar(20) DEFAULT NULL,
  `nationality` int(11) NOT NULL,
  `residency` enum('NON-RESIDENT','REFUGEE','PERMANENT') NOT NULL,
  `marital_status` enum('SINGLE','MARRIED','DIVORCED','SEPARATED') DEFAULT 'SINGLE',
  `branch` varchar(5) DEFAULT NULL,
  `employment_status` enum('EMPLOYED','SELF-EMPLOYED','NOT-EMPLOYED','STUDENT') NOT NULL,
  `employer_name` varchar(250) DEFAULT NULL,
  `employer_address` varchar(250) DEFAULT NULL,
  `employer_phone` varchar(50) DEFAULT NULL,
  `designation` varchar(200) DEFAULT NULL,
  `net_monthly_income` decimal(18,2) DEFAULT 0.00,
  `status` enum('ACTIVE','INACTIVE','SUSPENDED','DELETED','AWAITING.APPROVAL') NOT NULL DEFAULT 'AWAITING.APPROVAL',
  `image` varchar(255) DEFAULT NULL,
  `updated_at` datetime NOT NULL DEFAULT current_timestamp(),
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_roles`
--

CREATE TABLE `tbl_roles` (
  `role_id` int(11) NOT NULL,
  `role_name` varchar(200) NOT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_roles`
--

INSERT INTO `tbl_roles` (`role_id`, `role_name`, `description`) VALUES
(7, 'Owners', 'The owners and shareholders of the game zone'),
(8, 'Employers', 'The cashier and other staff members with specific duties at the game zone'),
(9, 'Gamers', 'The players and students who are register to be official game zone gamers.\r\n '),
(10, 'Developers', 'The eNOtech developers and software engineer that will be used to monitor and trace the system frequently ');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff`
--

CREATE TABLE `tbl_staff` (
  `staff_id` int(11) NOT NULL,
  `ref_code` varchar(15) NOT NULL,
  `gamertag` varchar(50) DEFAULT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `gender` enum('MALE','FEMALE','OTHER') NOT NULL,
  `dob` date NOT NULL,
  `address_line_1` varchar(200) NOT NULL,
  `address_line_2` varchar(200) NOT NULL,
  `city` int(11) NOT NULL,
  `email_address` varchar(50) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `status` enum('AWAITING.APPROVAL','AWAITING.AUTHORIZATION','ACTIVE','SUSPENDED','DELETED','LOCKED') NOT NULL DEFAULT 'AWAITING.APPROVAL',
  `posted_by` varchar(50) NOT NULL,
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `country_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_staff`
--

INSERT INTO `tbl_staff` (`staff_id`, `ref_code`, `gamertag`, `firstname`, `middlename`, `lastname`, `gender`, `dob`, `address_line_1`, `address_line_2`, `city`, `email_address`, `phone`, `status`, `posted_by`, `updated_at`, `created_at`, `country_id`) VALUES
(1, '312167', 'Iso Trapper', 'Innocent ', NULL, 'Misheck', 'MALE', '2004-08-09', 'National College Of Information Technology,\r\nPO Box 31164,Lilongwe,Malawi', '', 1, 'innocentmisheck03@gmail.com', '0881878737', 'ACTIVE', 'enotech.tech', '2023-06-21 07:32:33', '2023-06-20 23:07:49', 265);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff_access`
--

CREATE TABLE `tbl_staff_access` (
  `id` int(11) NOT NULL,
  `staff_id` int(11) NOT NULL,
  `password` varchar(255) NOT NULL,
  `attempts` int(11) NOT NULL DEFAULT 0,
  `verified_email` tinyint(1) DEFAULT 0,
  `status` enum('ACTIVE','SUSPENDED','BLOCKED') DEFAULT 'ACTIVE',
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `role_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbl_staff_access`
--

INSERT INTO `tbl_staff_access` (`id`, `staff_id`, `password`, `attempts`, `verified_email`, `status`, `updated_at`, `created_at`, `role_id`) VALUES
(11, 1, '11223', 0, 1, 'ACTIVE', '2023-06-21 07:43:05', '2023-06-20 23:17:03', 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff_branch_assignment`
--

CREATE TABLE `tbl_staff_branch_assignment` (
  `staff_id` int(11) NOT NULL,
  `branch_id` varchar(5) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbl_staff_branch_assignment`
--

INSERT INTO `tbl_staff_branch_assignment` (`staff_id`, `branch_id`, `role`) VALUES
(1, '1001', 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_activity_logs`
--
ALTER TABLE `tbl_activity_logs`
  ADD PRIMARY KEY (`log_id`);

--
-- Indexes for table `tbl_branches`
--
ALTER TABLE `tbl_branches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `branch_code` (`branch_code`),
  ADD KEY `city` (`city`),
  ADD KEY `city_2` (`city`);

--
-- Indexes for table `tbl_charges`
--
ALTER TABLE `tbl_charges`
  ADD PRIMARY KEY (`charge_id`);

--
-- Indexes for table `tbl_chart_of_gaming_content_categories`
--
ALTER TABLE `tbl_chart_of_gaming_content_categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_chart_of_gaming_types`
--
ALTER TABLE `tbl_chart_of_gaming_types`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `gaming_type_name` (`gaming_type_name`),
  ADD UNIQUE KEY `gaming_type` (`gl_code`),
  ADD UNIQUE KEY `gl_code` (`gl_code`);

--
-- Indexes for table `tbl_cities`
--
ALTER TABLE `tbl_cities`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_contacts`
--
ALTER TABLE `tbl_contacts`
  ADD PRIMARY KEY (`contact_id`),
  ADD KEY `member_id` (`member_id`);

--
-- Indexes for table `tbl_countries`
--
ALTER TABLE `tbl_countries`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_currencies`
--
ALTER TABLE `tbl_currencies`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_gaming_content`
--
ALTER TABLE `tbl_gaming_content`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_branch_content` (`available_at`),
  ADD KEY `fk_category_content` (`categories`);

--
-- Indexes for table `tbl_gaming_types`
--
ALTER TABLE `tbl_gaming_types`
  ADD PRIMARY KEY (`id`),
  ADD KEY `gl_code` (`gl_code`);

--
-- Indexes for table `tbl_members`
--
ALTER TABLE `tbl_members`
  ADD PRIMARY KEY (`member_id`),
  ADD KEY `branch` (`branch`);

--
-- Indexes for table `tbl_roles`
--
ALTER TABLE `tbl_roles`
  ADD PRIMARY KEY (`role_id`);

--
-- Indexes for table `tbl_staff`
--
ALTER TABLE `tbl_staff`
  ADD PRIMARY KEY (`staff_id`),
  ADD UNIQUE KEY `email_address` (`email_address`),
  ADD UNIQUE KEY `ref_code` (`ref_code`),
  ADD UNIQUE KEY `ref_code_2` (`ref_code`),
  ADD KEY `city` (`city`),
  ADD KEY `fk_country_id` (`country_id`);

--
-- Indexes for table `tbl_staff_access`
--
ALTER TABLE `tbl_staff_access`
  ADD PRIMARY KEY (`id`),
  ADD KEY `staff_id` (`staff_id`),
  ADD KEY `fk_role_id` (`role_id`);

--
-- Indexes for table `tbl_staff_branch_assignment`
--
ALTER TABLE `tbl_staff_branch_assignment`
  ADD PRIMARY KEY (`staff_id`,`branch_id`),
  ADD KEY `branch_id` (`branch_id`),
  ADD KEY `role` (`role`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_activity_logs`
--
ALTER TABLE `tbl_activity_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_branches`
--
ALTER TABLE `tbl_branches`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_charges`
--
ALTER TABLE `tbl_charges`
  MODIFY `charge_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_chart_of_gaming_content_categories`
--
ALTER TABLE `tbl_chart_of_gaming_content_categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_chart_of_gaming_types`
--
ALTER TABLE `tbl_chart_of_gaming_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_cities`
--
ALTER TABLE `tbl_cities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_contacts`
--
ALTER TABLE `tbl_contacts`
  MODIFY `contact_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_countries`
--
ALTER TABLE `tbl_countries`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=267;

--
-- AUTO_INCREMENT for table `tbl_currencies`
--
ALTER TABLE `tbl_currencies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_gaming_content`
--
ALTER TABLE `tbl_gaming_content`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_gaming_types`
--
ALTER TABLE `tbl_gaming_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_members`
--
ALTER TABLE `tbl_members`
  MODIFY `member_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_roles`
--
ALTER TABLE `tbl_roles`
  MODIFY `role_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_staff`
--
ALTER TABLE `tbl_staff`
  MODIFY `staff_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_staff_access`
--
ALTER TABLE `tbl_staff_access`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_branches`
--
ALTER TABLE `tbl_branches`
  ADD CONSTRAINT `tbl_branches_ibfk_1` FOREIGN KEY (`city`) REFERENCES `tbl_cities` (`id`);

--
-- Constraints for table `tbl_gaming_content`
--
ALTER TABLE `tbl_gaming_content`
  ADD CONSTRAINT `fk_branch_content` FOREIGN KEY (`available_at`) REFERENCES `tbl_branches` (`id`),
  ADD CONSTRAINT `fk_category_content` FOREIGN KEY (`categories`) REFERENCES `tbl_chart_of_gaming_content_categories` (`id`);

--
-- Constraints for table `tbl_gaming_types`
--
ALTER TABLE `tbl_gaming_types`
  ADD CONSTRAINT `fk_tbl_gaming_types_tbl_chart_of_gaming_types` FOREIGN KEY (`gl_code`) REFERENCES `tbl_chart_of_gaming_types` (`gl_code`);

--
-- Constraints for table `tbl_staff`
--
ALTER TABLE `tbl_staff`
  ADD CONSTRAINT `fk_country_id` FOREIGN KEY (`country_id`) REFERENCES `tbl_countries` (`id`);

--
-- Constraints for table `tbl_staff_access`
--
ALTER TABLE `tbl_staff_access`
  ADD CONSTRAINT `fk_role_id` FOREIGN KEY (`role_id`) REFERENCES `tbl_roles` (`role_id`),
  ADD CONSTRAINT `tbl_staff_access_ibfk_1` FOREIGN KEY (`staff_id`) REFERENCES `tbl_staff` (`staff_id`);

--
-- Constraints for table `tbl_staff_branch_assignment`
--
ALTER TABLE `tbl_staff_branch_assignment`
  ADD CONSTRAINT `tbl_staff_branch_assignment_ibfk_1` FOREIGN KEY (`branch_id`) REFERENCES `tbl_branches` (`branch_code`),
  ADD CONSTRAINT `tbl_staff_branch_assignment_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `tbl_staff` (`staff_id`),
  ADD CONSTRAINT `tbl_staff_branch_assignment_ibfk_3` FOREIGN KEY (`role`) REFERENCES `tbl_roles` (`role_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
