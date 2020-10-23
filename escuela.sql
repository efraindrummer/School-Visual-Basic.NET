-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-07-2020 a las 08:48:25
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `escuela`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumno`
--

CREATE TABLE `alumno` (
  `id_alumno` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `correo` varchar(45) NOT NULL,
  `edad` int(11) NOT NULL,
  `nivel_educativo` varchar(45) NOT NULL,
  `id_escuela` int(11) NOT NULL,
  `id_grupo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `alumno`
--

INSERT INTO `alumno` (`id_alumno`, `nombre`, `apellido`, `correo`, `edad`, `nivel_educativo`, `id_escuela`, `id_grupo`) VALUES
(1, 'Jesus Alejandro', 'Jimenez Chan', 'jesus123@mail.unacar.mx', 40, 'Administrador', 1, 3),
(2, 'Efrain', 'May Mayo', 'wwifihack@gmail.com', 21, 'Universidad', 4, 1),
(3, 'luis', 'bentancur', 'luis@gmail.com', 22, 'Universidad', 4, 2),
(4, 'karla', 'ramirez', 'coronavirus@gmail.com', 30, 'Universidad', 4, 2),
(6, 'juan', 'notario', 'juan@gmail.com', 0, 'Preparatoria', 5, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `calificaciones`
--

CREATE TABLE `calificaciones` (
  `id_calificacion` int(11) NOT NULL,
  `calificacion` int(2) NOT NULL,
  `id_est_alum` int(2) NOT NULL,
  `id_alumno` int(11) NOT NULL,
  `id_profesor` int(11) NOT NULL,
  `id_materia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `calificaciones`
--

INSERT INTO `calificaciones` (`id_calificacion`, `calificacion`, `id_est_alum`, `id_alumno`, `id_profesor`, `id_materia`) VALUES
(1, 99, 1, 1, 1, 4),
(2, 99, 1, 3, 8, 3),
(3, 99, 1, 2, 5, 2),
(4, 78, 2, 2, 7, 1),
(5, 75, 2, 2, 4, 4),
(6, 50, 3, 2, 10, 7);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `calificaciones_media`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `calificaciones_media` (
`nombre` varchar(45)
,`apellido` varchar(45)
,`media` decimal(14,4)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `curso`
--

CREATE TABLE `curso` (
  `id_curso` int(11) NOT NULL,
  `periodo` varchar(45) NOT NULL,
  `id_num_salon` int(11) NOT NULL,
  `id_materia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `curso`
--

INSERT INTO `curso` (`id_curso`, `periodo`, `id_num_salon`, `id_materia`) VALUES
(1, 'Febrero - Junio 2020', 1, 1),
(2, 'Febrero - Junio 2019', 1, 3),
(3, 'Enero - Marzo 2019 ', 8, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `escuela`
--

CREATE TABLE `escuela` (
  `id_escuela` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `nivel_educativo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `escuela`
--

INSERT INTO `escuela` (`id_escuela`, `nombre`, `nivel_educativo`) VALUES
(1, 'Maestros Carmelitas', 'Primaria'),
(2, 'UNID', 'Universidad'),
(3, 'Juan de la cabada', 'Primaria'),
(4, 'Unacar', 'Universidad'),
(5, 'juan ', 'Primaria'),
(6, 'Utcam bis', 'Universidad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estatus_alumno`
--

CREATE TABLE `estatus_alumno` (
  `id_est_alum` int(2) NOT NULL,
  `status_alumno` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estatus_alumno`
--

INSERT INTO `estatus_alumno` (`id_est_alum`, `status_alumno`) VALUES
(1, 'alumno excelente'),
(2, 'alumno regular'),
(3, 'alumno irregular');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estatus_salon`
--

CREATE TABLE `estatus_salon` (
  `id_est_salon` int(2) NOT NULL,
  `status_salon` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estatus_salon`
--

INSERT INTO `estatus_salon` (`id_est_salon`, `status_salon`) VALUES
(1, 'cupo disponible'),
(2, 'cupo lleno');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupo`
--

CREATE TABLE `grupo` (
  `id_grupo` int(11) NOT NULL,
  `clasificacion_letra_mayuscula` char(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `grupo`
--

INSERT INTO `grupo` (`id_grupo`, `clasificacion_letra_mayuscula`) VALUES
(1, 'A'),
(2, 'B'),
(3, 'C'),
(4, 'D'),
(5, 'E'),
(6, 'F'),
(7, 'G'),
(8, 'H'),
(9, 'A');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `los_mas_altos`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `los_mas_altos` (
`nombre` varchar(45)
,`apellido` varchar(45)
,`id_alumno` int(11)
,`calificacion` int(2)
,`nombre_m` varchar(45)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia`
--

CREATE TABLE `materia` (
  `id_materia` int(11) NOT NULL,
  `nombre_m` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `materia`
--

INSERT INTO `materia` (`id_materia`, `nombre_m`) VALUES
(1, 'Español'),
(2, 'Ingles'),
(3, 'Matematicas'),
(4, 'Ciencias Naturales'),
(5, 'Artes'),
(6, 'Desarrollo.NET'),
(7, 'Javascript');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `media_cali`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `media_cali` (
`nombre` varchar(45)
,`apellido` varchar(45)
,`id_alumno` int(11)
,`media` decimal(14,4)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor`
--

CREATE TABLE `profesor` (
  `id_profesor` int(11) NOT NULL,
  `nombre_profesor` varchar(45) NOT NULL,
  `apellido_profesor` varchar(45) NOT NULL,
  `id_escuela` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `profesor`
--

INSERT INTO `profesor` (`id_profesor`, `nombre_profesor`, `apellido_profesor`, `id_escuela`) VALUES
(1, 'Agustin', 'Hernandez Casanova', 1),
(2, 'javier', 'hernandez', 3),
(3, 'emanuel', 'spbran', 4),
(4, 'geronimo', 'eben', 4),
(5, 'yair', 'maritinez', 3),
(6, 'alejandra', 'alcocer', 4),
(7, 'sirens', 'del carmen', 4),
(8, 'sicto', 'del carmen', 4),
(9, 'efrain ', 'may', 4),
(10, 'eladio', 'giovanny ', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE `salon` (
  `id_num_salon` int(11) NOT NULL,
  `capacidad` varchar(45) NOT NULL,
  `cupo_actual` varchar(45) NOT NULL,
  `fk_status_salon` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `salon`
--

INSERT INTO `salon` (`id_num_salon`, `capacidad`, `cupo_actual`, `fk_status_salon`) VALUES
(1, '40 alumnos', '30 alumnos', 1),
(2, '50 alumnos', '55 alumnos', 2),
(3, '30 alumnos', '25 alumnos', 1),
(4, '35 alumnos', '35 alumnos', 2),
(5, '60 alumnos', '35 alumnos', 2),
(6, '60 alumnos', '56 alumnos', 1),
(8, '60 alumnos', '56 alumnos', 1),
(9, '60 alumnos', '56 alumnos', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `acceso` varchar(15) NOT NULL,
  `login` varchar(15) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nombre_usuario`, `acceso`, `login`, `password`, `estado`) VALUES
(1, 'Administrador', 'Administrador', 'admin', 'admin', 'A');

-- --------------------------------------------------------

--
-- Estructura para la vista `calificaciones_media`
--
DROP TABLE IF EXISTS `calificaciones_media`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `calificaciones_media`  AS  select `a`.`nombre` AS `nombre`,`a`.`apellido` AS `apellido`,avg(`n`.`calificacion`) AS `media` from ((`alumno` `a` join `calificaciones` `n` on(`a`.`id_alumno` <> 0)) join `materia` `mat` on(`mat`.`id_materia` = `n`.`id_calificacion`)) group by `a`.`nombre`,`a`.`apellido` order by avg(`n`.`calificacion`) desc ;

-- --------------------------------------------------------

--
-- Estructura para la vista `los_mas_altos`
--
DROP TABLE IF EXISTS `los_mas_altos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `los_mas_altos`  AS  select `a`.`nombre` AS `nombre`,`a`.`apellido` AS `apellido`,`a`.`id_alumno` AS `id_alumno`,`c`.`calificacion` AS `calificacion`,`m`.`nombre_m` AS `nombre_m` from ((`alumno` `a` join `calificaciones` `c` on(`a`.`id_alumno` = `c`.`id_calificacion`)) join `materia` `m` on(`c`.`id_materia` = `m`.`id_materia`)) where `c`.`calificacion` = (select max(`calificaciones`.`calificacion`) from `calificaciones` where `calificaciones`.`calificacion` > 90) order by `a`.`nombre` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `media_cali`
--
DROP TABLE IF EXISTS `media_cali`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `media_cali`  AS  select `a`.`nombre` AS `nombre`,`a`.`apellido` AS `apellido`,`a`.`id_alumno` AS `id_alumno`,avg(`n`.`calificacion`) AS `media` from ((`alumno` `a` join `calificaciones` `n` on(`a`.`id_alumno` <> 0)) join `materia` `mat` on(`mat`.`id_materia` = `n`.`id_calificacion`)) group by `a`.`nombre`,`a`.`apellido` order by avg(`n`.`calificacion`) desc ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumno`
--
ALTER TABLE `alumno`
  ADD PRIMARY KEY (`id_alumno`),
  ADD KEY `id_escuela` (`id_escuela`),
  ADD KEY `id_grupo` (`id_grupo`);

--
-- Indices de la tabla `calificaciones`
--
ALTER TABLE `calificaciones`
  ADD PRIMARY KEY (`id_calificacion`),
  ADD KEY `id_est_alum` (`id_est_alum`),
  ADD KEY `id_alumno` (`id_alumno`),
  ADD KEY `id_profesor` (`id_profesor`),
  ADD KEY `id_materia` (`id_materia`);

--
-- Indices de la tabla `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`id_curso`),
  ADD KEY `id_num_salon` (`id_num_salon`),
  ADD KEY `id_materia` (`id_materia`);

--
-- Indices de la tabla `escuela`
--
ALTER TABLE `escuela`
  ADD PRIMARY KEY (`id_escuela`);

--
-- Indices de la tabla `estatus_alumno`
--
ALTER TABLE `estatus_alumno`
  ADD PRIMARY KEY (`id_est_alum`);

--
-- Indices de la tabla `estatus_salon`
--
ALTER TABLE `estatus_salon`
  ADD PRIMARY KEY (`id_est_salon`);

--
-- Indices de la tabla `grupo`
--
ALTER TABLE `grupo`
  ADD PRIMARY KEY (`id_grupo`);

--
-- Indices de la tabla `materia`
--
ALTER TABLE `materia`
  ADD PRIMARY KEY (`id_materia`);

--
-- Indices de la tabla `profesor`
--
ALTER TABLE `profesor`
  ADD PRIMARY KEY (`id_profesor`),
  ADD KEY `id_escuela` (`id_escuela`);

--
-- Indices de la tabla `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`id_num_salon`),
  ADD KEY `status_salon` (`fk_status_salon`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `login_UNIQUE` (`login`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alumno`
--
ALTER TABLE `alumno`
  MODIFY `id_alumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `calificaciones`
--
ALTER TABLE `calificaciones`
  MODIFY `id_calificacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `curso`
--
ALTER TABLE `curso`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `escuela`
--
ALTER TABLE `escuela`
  MODIFY `id_escuela` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `grupo`
--
ALTER TABLE `grupo`
  MODIFY `id_grupo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `materia`
--
ALTER TABLE `materia`
  MODIFY `id_materia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `profesor`
--
ALTER TABLE `profesor`
  MODIFY `id_profesor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;

--
-- AUTO_INCREMENT de la tabla `salon`
--
ALTER TABLE `salon`
  MODIFY `id_num_salon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `alumno`
--
ALTER TABLE `alumno`
  ADD CONSTRAINT `alumno_ibfk_1` FOREIGN KEY (`id_escuela`) REFERENCES `escuela` (`id_escuela`),
  ADD CONSTRAINT `alumno_ibfk_2` FOREIGN KEY (`id_grupo`) REFERENCES `grupo` (`id_grupo`);

--
-- Filtros para la tabla `calificaciones`
--
ALTER TABLE `calificaciones`
  ADD CONSTRAINT `calificaciones_ibfk_1` FOREIGN KEY (`id_est_alum`) REFERENCES `estatus_alumno` (`id_est_alum`),
  ADD CONSTRAINT `calificaciones_ibfk_2` FOREIGN KEY (`id_alumno`) REFERENCES `alumno` (`id_alumno`),
  ADD CONSTRAINT `calificaciones_ibfk_3` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id_profesor`),
  ADD CONSTRAINT `calificaciones_ibfk_4` FOREIGN KEY (`id_materia`) REFERENCES `materia` (`id_materia`);

--
-- Filtros para la tabla `curso`
--
ALTER TABLE `curso`
  ADD CONSTRAINT `curso_ibfk_1` FOREIGN KEY (`id_num_salon`) REFERENCES `salon` (`id_num_salon`),
  ADD CONSTRAINT `curso_ibfk_2` FOREIGN KEY (`id_materia`) REFERENCES `materia` (`id_materia`);

--
-- Filtros para la tabla `profesor`
--
ALTER TABLE `profesor`
  ADD CONSTRAINT `profesor_ibfk_1` FOREIGN KEY (`id_escuela`) REFERENCES `escuela` (`id_escuela`);

--
-- Filtros para la tabla `salon`
--
ALTER TABLE `salon`
  ADD CONSTRAINT `status_salon_ibfk_1` FOREIGN KEY (`fk_status_salon`) REFERENCES `estatus_salon` (`id_est_salon`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `fk_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `alumno` (`id_alumno`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
