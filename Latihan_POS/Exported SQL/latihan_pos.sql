-- phpMyAdmin SQL Dump
-- version 4.6.5.2deb1+deb.cihar.com~trusty.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 29 Des 2016 pada 22.54
-- Versi Server: 5.6.33-0ubuntu0.14.04.1
-- PHP Version: 7.0.14-2+deb.sury.org~trusty+1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latihan_pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `zip_code` varchar(45) DEFAULT NULL,
  `phone_number` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`id`, `name`, `address`, `zip_code`, `phone_number`, `email`, `created_at`, `updated_at`) VALUES
(5, 'Picky Customer', 'Jl. Custom', '200110', '012345678890', 'a@customer.com', '2016-12-26 03:42:44', '2016-12-29 22:21:29'),
(6, 'Holy Customer', 'Jl. Unknown', '200119', '000011112222', 'b@customer.com', '2016-12-29 22:11:34', '2016-12-29 22:22:08');

-- --------------------------------------------------------

--
-- Struktur dari tabel `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `code` varchar(20) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `initial_amount` int(10) DEFAULT NULL,
  `hpp_price` decimal(16,2) DEFAULT NULL,
  `selling_price` decimal(16,2) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `product`
--

INSERT INTO `product` (`id`, `code`, `name`, `initial_amount`, `hpp_price`, `selling_price`, `created_at`, `updated_at`) VALUES
(10, 'product-1', 'ASUS', 190, '100000.00', '10000000.00', '2016-12-26 14:58:38', '2016-12-29 22:27:19'),
(12, 'product-2', 'Macbook Pro', 42, '20000000.00', '20000000.00', '2016-12-26 23:07:46', '2016-12-29 22:47:12'),
(13, 'product-3', 'Mi Notebook Air', 238, '8000000.00', '8000000.00', '2016-12-26 23:08:08', '2016-12-29 22:43:11'),
(14, 'product-4', 'ASUS ROG', 1000, '15000000.00', '15000000.00', '2016-12-29 22:09:43', '2016-12-29 22:46:44');

-- --------------------------------------------------------

--
-- Struktur dari tabel `purchase`
--

CREATE TABLE `purchase` (
  `id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `code` varchar(20) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `purchase`
--

INSERT INTO `purchase` (`id`, `supplier_id`, `code`, `created_at`, `updated_at`) VALUES
(4, 3, '123', '2016-12-27 01:39:44', '2016-12-27 01:39:44'),
(5, 3, '321', '2016-12-27 01:40:28', '2016-12-27 01:40:28');

-- --------------------------------------------------------

--
-- Struktur dari tabel `purchase_detail`
--

CREATE TABLE `purchase_detail` (
  `id` int(11) NOT NULL,
  `purchase_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `product_price` decimal(16,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `purchase_detail`
--

INSERT INTO `purchase_detail` (`id`, `purchase_id`, `product_id`, `product_price`, `quantity`, `created_at`, `updated_at`) VALUES
(7, 4, 12, '20000000.00', 200, '2016-12-27 01:39:44', '2016-12-29 22:47:12'),
(8, 4, 13, '8000000.00', 270, '2016-12-27 01:40:17', '2016-12-29 22:43:10'),
(9, 4, 10, '123123.00', 220, '2016-12-27 01:40:23', '2016-12-29 21:58:00'),
(10, 5, 10, '123123.00', 1, '2016-12-27 01:40:28', '2016-12-27 01:40:28'),
(11, 5, 12, '111111.00', 12, '2016-12-27 01:40:37', '2016-12-27 01:40:37'),
(12, 4, 14, '15000000.00', 2, '2016-12-29 22:46:44', '2016-12-29 22:46:44');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sale`
--

CREATE TABLE `sale` (
  `id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `code` varchar(20) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `sale`
--

INSERT INTO `sale` (`id`, `customer_id`, `code`, `created_at`, `updated_at`) VALUES
(2, 5, '00001', '2016-12-26 22:46:48', '2016-12-26 22:46:48'),
(3, 5, 'abcdee', '2016-12-29 21:31:05', '2016-12-29 21:31:05'),
(4, 5, '11111', '2016-12-29 22:05:12', '2016-12-29 22:05:12'),
(5, 5, '12', '2016-12-29 22:06:12', '2016-12-29 22:06:12');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sale_detail`
--

CREATE TABLE `sale_detail` (
  `id` int(11) NOT NULL,
  `sale_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `product_price` decimal(16,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `sale_detail`
--

INSERT INTO `sale_detail` (`id`, `sale_id`, `product_id`, `product_price`, `quantity`, `created_at`, `updated_at`) VALUES
(1, 2, 10, '123123.00', 123, '2016-12-26 22:47:54', '2016-12-29 15:04:42'),
(2, 2, 12, '111111.00', 150, '2016-12-26 23:08:45', '2016-12-26 16:10:12'),
(3, 2, 13, '123333.00', 123, '2016-12-26 23:20:58', '2016-12-26 16:21:35'),
(4, 3, 10, '123123.00', 12231, '2016-12-29 21:31:05', '2016-12-29 14:58:35'),
(5, 3, 12, '111111.00', 3, '2016-12-29 21:39:12', '2016-12-29 14:39:18'),
(6, 4, 14, '15000000.00', 2, '2016-12-29 22:26:44', '2016-12-29 15:26:44'),
(7, 4, 13, '8000000.00', 2, '2016-12-29 22:26:52', '2016-12-29 15:26:52'),
(8, 4, 10, '10000000.00', 10, '2016-12-29 22:27:08', '2016-12-29 15:27:18'),
(9, 5, 12, '20000000.00', 3, '2016-12-29 22:27:57', '2016-12-29 15:45:35'),
(10, 5, 13, '8000000.00', 8, '2016-12-29 22:28:05', '2016-12-29 15:28:05');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `zip_code` varchar(45) DEFAULT NULL,
  `phone_number` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`id`, `name`, `address`, `zip_code`, `phone_number`, `email`, `created_at`, `updated_at`) VALUES
(1, 'Supplier', 'Jl. Supplier Pertama', '20200', '085200012345', 'a@abcde.com', '2016-12-26 14:31:39', '2016-12-29 22:15:17'),
(3, 'Supplier Moderate', 'Jl. Supplier Tinggi', '20201', '085211134445', 'supp@supply.com', '2016-12-26 14:40:39', '2016-12-29 22:16:16'),
(4, 'Supplier More Moderate', 'Jl. Tinggi Supplier', '20202', '0896221451111', 'supplied@supply.com', '2016-12-29 22:11:20', '2016-12-29 22:18:53'),
(6, 'The Best Supplier', 'Jl. Puncak Supplier', '20210', '001897543210', 'supplies@supply.com', '2016-12-29 22:13:29', '2016-12-29 22:19:54');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `supplier_id` (`supplier_id`);

--
-- Indexes for table `purchase_detail`
--
ALTER TABLE `purchase_detail`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`),
  ADD KEY `purchase_id` (`purchase_id`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `sale_detail`
--
ALTER TABLE `sale_detail`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sale_id_2` (`sale_id`),
  ADD KEY `product_id_2` (`product_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `purchase_detail`
--
ALTER TABLE `purchase_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `sale`
--
ALTER TABLE `sale`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `sale_detail`
--
ALTER TABLE `sale_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `purchase`
--
ALTER TABLE `purchase`
  ADD CONSTRAINT `purchase_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`id`);

--
-- Ketidakleluasaan untuk tabel `purchase_detail`
--
ALTER TABLE `purchase_detail`
  ADD CONSTRAINT `purchase_detail_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `purchase_detail_ibfk_2` FOREIGN KEY (`purchase_id`) REFERENCES `purchase` (`id`);

--
-- Ketidakleluasaan untuk tabel `sale`
--
ALTER TABLE `sale`
  ADD CONSTRAINT `sale_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`);

--
-- Ketidakleluasaan untuk tabel `sale_detail`
--
ALTER TABLE `sale_detail`
  ADD CONSTRAINT `sale_detail_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `sale_detail_ibfk_2` FOREIGN KEY (`sale_id`) REFERENCES `sale` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
