-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-02-2019 a las 23:34:28
-- Versión del servidor: 10.1.35-MariaDB
-- Versión de PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_sigma`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `InventarioHe` (IN `p1` INT)  begin 
DECLARE ph int;
DECLARE i int;

SELECT SUM(hhp.cantidad) into ph FROM herramientas_has_persona hhp 
INNER JOIN herramientas h
ON h.id = hhp.herramientas_id
WHERE h.id = p1 ;

SELECT SUM(cantidad) into i FROM inventario 
WHERE herramientas_id = p1;

IF(ph is null)THEN
set ph = 0;
end if;
IF(i is null)THEN
set i = 0;
end if;

set ph =  ph * -1;
SELECT (i + ph) CantidadStock;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InventarioIn` (`p1` INT)  begin 
DECLARE ph int;
DECLARE i int;

SELECT SUM(ihp.cantidad) into ph FROM insumos_has_persona ihp 
INNER JOIN insumos i
ON i.id = ihp.insumos_id
WHERE i.id = p1 ;

SELECT SUM(cantidad) into i FROM inventario 
WHERE insumos_id = p1;

IF(ph is null)THEN
set ph = 0;
end if;
IF(i is null)THEN
set i = 0;
end if;

set ph =  ph * -1;
SELECT (i + ph) CantidadStock;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actividad`
--

CREATE TABLE `actividad` (
  `cod` varchar(10) NOT NULL,
  `descripcion` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `actividad`
--

INSERT INTO `actividad` (`cod`, `descripcion`) VALUES
('S-01', 'CAMBIO DE PARTE'),
('S-02', 'AJUSTE'),
('S-03', 'REPARACION'),
('S-04', 'INSTALACION'),
('S-05', 'SINCRONIZACION'),
('S-06', 'TENSIONAR'),
('S-07', 'EMBOBINAR'),
('S-08', 'INSTALAR GUARDA'),
('S-09', 'CAMBIO DE ACEITE'),
('S-10', 'OTRO'),
('S-11', 'CAMBIO DE RODAMIENTO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actividad_mantenimiento`
--

CREATE TABLE `actividad_mantenimiento` (
  `actividad_cod` varchar(10) NOT NULL,
  `mantenimiento_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `actividad_mantenimiento`
--

INSERT INTO `actividad_mantenimiento` (`actividad_cod`, `mantenimiento_id`) VALUES
('S-02', 219),
('S-06', 221),
('S-07', 239),
('S-09', 220),
('S-09', 239);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `area`
--

CREATE TABLE `area` (
  `id` int(11) NOT NULL,
  `centrocosto` varchar(50) NOT NULL,
  `localizacion` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `area`
--

INSERT INTO `area` (`id`, `centrocosto`, `localizacion`) VALUES
(1, '10101', 'PRESIDENCIA'),
(2, '10102', 'PROYECTO DR ROMULO'),
(3, '10201', 'GERENCIA GENERAL'),
(4, '10202', 'GERENCIA ESTRATEGICA INACTIVO'),
(5, '10301', 'ASESORIA EXTERNA'),
(6, '10302', 'AUDITORIA INTERNA'),
(7, '10303', 'GESTION DE CALIDAD'),
(8, '10401', 'DIRECCION GESTION HUMANA'),
(9, '10402', 'SEGURIDAD Y SALUD EN EL TRABAJO'),
(10, '10403', 'JURIDICO'),
(11, '10405', 'APRENDICES SENA GESTION HUMANA'),
(12, '10404', 'NOMINA Y CONTRATACION'),
(13, '10501', 'DIRECCION FINANCIERA'),
(14, '10502', 'CONTABILIDAD'),
(15, '10503', 'CREDITO Y CARTERA'),
(16, '10504', 'PRESUPUESTO'),
(17, '10507', 'APRENDICES SENA DIRECCION FINANCIERA'),
(18, '10505', 'COSTOS'),
(19, '10506', 'TESORERIA'),
(20, '10601', 'COMPRAS'),
(21, '10602', 'MATERIA PRIMA'),
(22, '10603', 'APRENDICES SENA DIRECCION COMPRAS'),
(23, '10701', 'PLANEACION ADMINISTRATIVA'),
(24, '10702', 'ADECUACIONES Y REPARACIONES LOCATIVAS'),
(25, '10703', 'TECNOLOGIA E INFORMATICA'),
(26, '10707', 'APRENDICES SENA SERVICIOS APOYO'),
(27, '10705', 'BODEGA ACOPI ADECUACIONES'),
(28, '10706', 'ASEO Y CAFETERIA'),
(29, '10704', 'SERVICIOS GENERALES'),
(30, '10801', 'RESPONSABILIDAD SOCIAL Y AMBIENTAL'),
(31, '10802', 'APRENDICES SENA RESPONSABILIDAD EMP.'),
(32, '20101', 'GERENCIA COMERCIAL'),
(33, '20102', 'VENTAS NACIONALES'),
(34, '20103', 'VENTAS EXTERIOR'),
(35, '20104', 'SERVICIO AL CLIENTE'),
(36, '20105', 'PRODUCTO TERMINADO'),
(37, '20106', 'ALMACEN RIO CAUCA'),
(38, '20107', 'MERCADEO Y PUBLICIDAD'),
(39, '20108', 'DEVOLUCIONES'),
(40, '20109', 'VENTAS INTITUCIONALES'),
(41, '20110', 'APRENDICES SENA COMERCIAL PT.'),
(42, '20201', 'INNOVACION Y DESARROLLO'),
(43, '20202', 'LABORATORIO'),
(44, '20204', 'APRENDICES SENA INNOVACION Y DESARROLLO'),
(45, '30101', 'DIRECCION DE PRODUCCION'),
(46, '30102', 'COORDINACION TROQUELADO'),
(47, '30103', 'COORDINACION GUARNECIDA'),
(48, '30104', 'COORDINACION ENSAMBLE'),
(49, '30105', 'PLANEACION'),
(50, '30106', 'CALIDAD DE PRODUCTO'),
(51, '30107', 'APRENDICES SENA PLANEACION DE PRODUCCION'),
(52, '30201', 'CORTE'),
(53, '30202', 'DESBASTE'),
(54, '30203', 'PERFORADO REPUJADO'),
(55, '30204', 'REVISION Y DESPACHO PLANTAS'),
(56, '30205', 'RAYADO'),
(57, '30206', 'PERSONAL CDP DEL CUERO CORTE'),
(58, '30301', 'PREPARADO DE COSTURA MODULO 1'),
(59, '30302', 'ARMADO MODULO 1'),
(60, '30303', 'STROBELL MODULO 1'),
(61, '30304', 'TERMINADO MODULO 1'),
(62, '30305', 'COSTURA MODULO 1'),
(63, '30306', 'RAYADO MODULO 1'),
(64, '30311', 'PERSONAL CDP DEL CUERO MOD CASUAL'),
(65, '30401', 'PREPARADO DE COSTURA MODULO 2'),
(66, '30402', 'ARMADO MODULO 2'),
(67, '30403', 'COSTURA MODULO 2'),
(68, '30404', 'TERMINADO MODULO 2'),
(69, '30405', 'STROBEL MODULO 2'),
(70, '30406', 'RAYADO MODULO 2'),
(71, '30407', 'PERSONAL CDP DEL CUERO MOD SANDALIA'),
(72, '30501', 'PREPARADO DE COSTURA MODULO 3'),
(73, '30504', 'TERMINADO MODULO 3'),
(74, '30505', 'STROBEL MODULO 3'),
(75, '30502', 'ARMADO MODULO 3'),
(76, '30503', 'COSTURA MODULO 3'),
(77, '30506', 'RAYADO MODULO 3'),
(78, '30507', 'PERSONAL CDP CUERO MOD HOMBRE'),
(79, '30601', 'ALISTAMIENTO'),
(80, '30602', 'MONTAJE'),
(81, '30603', 'ENSAMBLE'),
(82, '30604', 'MAQUINAS ESPECIALES'),
(83, '30605', 'PERSONAL CDP DEL CUERO ENSAMBLE'),
(84, '30701', 'PLANTILLAS'),
(85, '30702', 'PREFABRICADOS'),
(86, '30703', 'PERSONAL CDP DEL CUERO PLANTILLAS'),
(87, '30810', 'APRENDICES SENA MOD'),
(88, '30901', 'MANTENIMIENTO MAQUINARIA'),
(89, '30902', 'CENTRO SERVICIOS ROMULO'),
(90, '30903', 'CENTRO DE SERVICIOS MAQUINAS ORISOL'),
(91, '30904', 'TROQUELES'),
(92, '30905', 'BONDEO'),
(93, '30906', 'MAQUILA BOOTS'),
(94, '30907', 'MAQUILAS'),
(95, '30908', 'CENTRO DE SERVICIOS MARROQUINERIA'),
(96, '30909', 'GARANTIAS'),
(97, '30910', 'APRENDICES SENA SERV. MOI'),
(98, '31001', 'RAYADO MODULO 4'),
(99, '31002', 'PREPARADO DE COSTURA MODULO 4'),
(100, '31003', 'ARMADO MODULO 4'),
(101, '31004', 'COSTURA MODULO 4'),
(102, '31005', 'TERMINADO MODULO 4'),
(103, '31006', 'STROBEL MODULO 4'),
(104, '31101', 'RAYADO MODULO 5'),
(105, '31102', 'PREPARADO DE COSTURA MODULO 5'),
(106, '31103', 'ARMADO MODULO 5'),
(107, '31104', 'COSTURA MODULO 5'),
(108, '31105', 'TERMINADO MODULO 5'),
(109, '31106', 'STROBEL MODULO 5'),
(110, '31201', 'RAYADO MODULO 6'),
(111, '31202', 'PREPARADO DE COSTURA MODULO 6'),
(112, '31203', 'ARMADO MODULO 6'),
(113, '31204', 'COSTURA MODULO 6'),
(114, '31205', 'TERMINADO MODULO 6'),
(115, '31206', 'STROBEL MODULO 6');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caracteristica`
--

CREATE TABLE `caracteristica` (
  `id` int(11) NOT NULL,
  `descripcion` text NOT NULL,
  `tipo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `caracteristica`
--

INSERT INTO `caracteristica` (`id`, `descripcion`, `tipo`) VALUES
(4, 'REVISAR ESTADO COFRE ELECTRICO', 'Instrucciones'),
(5, 'INSPECCIONES MECANICAS', 'Instrucciones'),
(6, 'REALIZAR MEDICIONES DE VOLTAJE', 'Instrucciones'),
(7, 'REALIZAR MEDICIONES DE AMPERAJE', 'Instrucciones'),
(8, 'REALIZAR MEDICIONES DE RESISTENCIA', 'Instrucciones'),
(9, 'REALIZAR MEDICIONES DE TEMPERATURA', 'Instrucciones'),
(10, 'VERIFICAR DIAGRAMA UNIFILAR', 'Instrucciones'),
(11, 'VOLTIAMPERIMETRO DE TENAZA Y MEGOHOMETRO', 'Equipo'),
(12, 'CAJA DE HERRAMIENTAS', 'Equipo'),
(13, 'LIJA', 'Equipo'),
(14, 'CINTA AISLANTE', 'Equipo'),
(15, 'PISTOLA CON SOLVENTE', 'Equipo'),
(16, 'ESTOPA LIMPIA', 'Equipo'),
(17, 'AIRE COMPRIMIDO', 'Equipo'),
(18, 'CANDADO DE SEGURIDAD Y SEÑAL DE MANTENIMIENTO', 'Equipo'),
(19, 'ORDEN DE MANTENIMIENTO', 'Equipo'),
(20, 'ANTES DE APAGAR BREAKERS COMPROBAR LA TENSIÓN DEL CIRCUITO, COLOQUE LA SEÑAL DE MANTENIMIENTO, COMIENCE A REALIZAR LAS INSPECCIONES MECANICAS: \n LA TENSIÓN ALTA PRODUCE RECALENTAMIENTOS, DEBIDO A DESGASTE EN BOBINAS Y ELECTROIMANES POR GOLPETEO DEL NUCLEO O MAGNETICO. LA TENSION DEMASIADO BAJA PRODUCE CIERRE DEMASIADO DEBIL DE CONTRACTORES. COMPROBACION DE CALENTAMIENTO EXESIVO EN ALGUNAS PARTES, SE EVIDENCIA POR DECOLORACION PARTES METALICAS, CARBONIZACION DE AISLAMIENTOS U OLOR, REVISAR CAUSAS Y REMEDIARLAS.\nCOMPROBACION DE CONEXIONES FLOJAS, ESPECIALMENTE SI EL EQUIPO ESTA SOMETIDO A VIBRACIONES', 'Procedimiento'),
(21, 'COMPROBACION LIBERTAD DE MOVIMIENTOS MECANICOS HACIENDO TRABAJAR A MANO DIVERSOS DISPOSITIVOS. SI SE COMPRUEBAN AGARROTAMIENTOS O DOBLADURAS ELIMINARLAS.', 'Procedimiento'),
(22, 'INSPECCION DE LOS CONTACTOS, ES DECIR SU PRESION ADECUADA Y SU DESGASTE PROPIO.  EN CONTACTORES MULTIPOLARES COMPROBAR SI TODOS LOS POLOS TIENEN LA MISMA PRESION DE CONTACTO. VERIFICAR QUE TODOS LOS TERMICOS SE ENCUENTREN Y/O INTERRUPTORES THERMOMAGNETICOS SE ENCUENTREN BIEN ENGANCHADOS A LAS BARRAS DE ALIMENTACION.    \nQUE LOS TORNILLOS  O PERNOS EN LOS INTERRUPTORES TERMOMAGNETICOS QUE SUJETAN LOS CABLES O ALAMBRES ALIMENTADORES SE ENCUENTREN BIEN APRETADOS, VERIFICAR FLOJOS O DAÑADOS,\nAJUSTE DE LOS PERNOS QUE SUJETAN LOS CABLES ALIMENTADORES DEL TABLERO', 'Procedimiento'),
(23, 'CON BROCHA HACER LIMPIEZA EN LA PARTE INTERNA DEL TABLERO REMOVIENDO POLVO, SOBRANTES DEL AISLANTE PROTECTOR, CINTA ADESIVA O ESCOMBROS DE REPARACIONES ANTERIORES, UNA VEZ LIMPIOS LOS DIFERENTES ELEMENTOS ELECTRICOS SOPLETEE CON AIRE SECO COMPRIMIDO EL POLVO EXISTENTE CON 15 PSIG', 'Procedimiento'),
(24, 'SI EXISTEN EMPALMES ENTRE CONDUCTORES VERIFICAR QUE SE ENCUENTREN EN BUEN ESTADO Y QUE LA CUBIERTA DE CINTA AHESIVA SE ENCUENTRE EN BUEN ESTADO', 'Procedimiento'),
(25, 'INSPECCION DE CONTACTORES TERMICOS, ARRANCADORES, BREAKERS, INSPECCION DE DIODOS, CONDENSADORES Y RESISTENCIAS. \nUNA VEZ HECHA LA INSPECCION GENERAL, ASIENTE LOS CONTACTORES CON LIJA SI ES NECESARIO, SI HAY DESGASTE NECESARIO CAMBIAR.', 'Procedimiento'),
(26, 'INSPECCIONES ELECTRICAS: CON LOS BREAKERS ENERGIZADOS PROCEDA A: REVISAR MEDICIONES DE VOLTAJE EN LOS CABLES ALIMENTADORES DEL TABLERO: ENTRE FASES (A-B, B-C, C-A), ENTRE FASE NEUTRO Y ENTRE NEUTRO Y TIERRA.\nREALIZAR MEDICIONES DE CORRIENTE: CABLES ALIMENTADORES DEL TABLERO:FASE, NEUTRO Y TIERRA CABLES O ALAMBRES PROVENIENTES DE CADA INTERRUPTOR TERMICO O THERMOMAGNETICO. VERIFICAR DESBALANCE DEL TABLERO.  SI ES POSIBLE REVISAR RESISTENCIA DE AISLAMIENTO DE DICHO CONDUCTOR RESPECTO A TIERRA DE LOS DIFERENTES CIRCUITOS, VOLTAJE, CORRIENTE Y TEMPERATURA, Y RESISTENCIA REALIZADA.', 'Procedimiento'),
(27, 'VERIFICAR QUE LAS CARACTERISTICAS Y PROTECCIONES DEL TABLERO CORRESPONDAN AL DIAGRAMA UNIFILAR ', 'Procedimiento'),
(28, 'UNA VEZ TERMINADO EL TRABAJO PROCEDA A LLENAR LA ORDEN DE TRABAJO CON TODAS LAS OBSERVACIONES REALIZADAS PARA PROGRAMAR SU RESPECTIVA REPARACION. RETIRE LA SEÑAL DE MANTENIMIENTO', 'Procedimiento');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carac_grupo`
--

CREATE TABLE `carac_grupo` (
  `grupo_id` int(11) NOT NULL,
  `carac_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `carac_grupo`
--

INSERT INTO `carac_grupo` (`grupo_id`, `carac_id`) VALUES
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(1, 16),
(1, 17),
(1, 18),
(1, 19),
(1, 21),
(1, 22),
(1, 23),
(1, 24),
(1, 25),
(1, 26),
(1, 27),
(1, 28);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consultarencargadosmantenimientos`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consultarencargadosmantenimientos` (
`id` int(11)
,`nombres` varchar(50)
,`mantenimiento_id` int(11)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consultarerramientasmantenimiento`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consultarerramientasmantenimiento` (
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consultarinsumosmantenimientos`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consultarinsumosmantenimientos` (
`id` int(11)
,`InsCan` varchar(64)
,`mantenimiento_id` int(11)
,`precio` int(11)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `equipo`
--

CREATE TABLE `equipo` (
  `codigo` varchar(50) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `fecha_ingr_plant` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fecha_ingr_sist` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `costo_equipo` int(11) DEFAULT NULL,
  `modelo_equipo` varchar(45) DEFAULT NULL,
  `serie_equipo` varchar(45) DEFAULT NULL,
  `peso` decimal(7,2) DEFAULT NULL,
  `altura` decimal(5,2) DEFAULT NULL,
  `ancho` decimal(5,2) DEFAULT NULL,
  `largo` decimal(5,2) DEFAULT NULL,
  `fabricante` varchar(45) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `realizado_por` varchar(50) DEFAULT NULL,
  `caract_tecni` varchar(45) DEFAULT NULL,
  `funcion` varchar(100) DEFAULT NULL,
  `imagen` varchar(100) DEFAULT NULL,
  `tipo` tinyint(1) NOT NULL,
  `area_id` int(11) DEFAULT NULL,
  `capacidad_produccion` varchar(50) DEFAULT NULL,
  `voltaje` varchar(50) DEFAULT NULL,
  `libra_presion` varchar(50) DEFAULT NULL,
  `manual` varchar(45) DEFAULT NULL,
  `tipo_aceite` varchar(45) DEFAULT NULL,
  `tipo_grasa` varchar(45) DEFAULT NULL,
  `direccion_fabricante` varchar(45) DEFAULT NULL,
  `telefono_fabricante` varchar(45) DEFAULT NULL,
  `email_fabricante` varchar(45) DEFAULT NULL,
  `ano_fabricante` timestamp NULL DEFAULT '0000-00-00 00:00:00',
  `Estado` varchar(10) NOT NULL,
  `grupo_id` int(11) NOT NULL,
  `frecuencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `equipo`
--

INSERT INTO `equipo` (`codigo`, `nombre`, `fecha_ingr_plant`, `fecha_ingr_sist`, `costo_equipo`, `modelo_equipo`, `serie_equipo`, `peso`, `altura`, `ancho`, `largo`, `fabricante`, `marca`, `realizado_por`, `caract_tecni`, `funcion`, `imagen`, `tipo`, `area_id`, `capacidad_produccion`, `voltaje`, `libra_presion`, `manual`, `tipo_aceite`, `tipo_grasa`, `direccion_fabricante`, `telefono_fabricante`, `email_fabricante`, `ano_fabricante`, `Estado`, `grupo_id`, `frecuencia`) VALUES
('123', 'TABLERO ELECTRICO - DESPACHOS', '2018-11-27 13:04:39', '2018-11-08 08:27:42', 300000, '2013', 'KILPKIJUI', '10.00', '20.00', '15.00', '60.00', 'ELECTRO', 'ELECTRO', 'ELECTRO', 'PRODUCE ELECTRICIDAD Y LA DISTRIBUYE', 'DISTRIBUIR LA ELECTRICIDAD', 'TableroElectricoTroquelado.jpg', 1, 36, '0', '50', '0', 'SI', 'PLEITO', 'OLIK', 'CRA 4N #78-09', '3145269685', 'electro@electro.com', '2013-06-11 13:04:39', 'Activo', 1, 60),
('1369', 'BAÑO DE TROQUELADO', '2018-11-27 14:35:55', '2018-11-08 08:28:40', 0, '', '', '0.00', '0.00', '0.00', '0.00', '', '', '', '', '', 'baños.jpg', 0, 91, '', '', '', '', '', '', '', '', '', '2018-11-08 08:31:39', 'Activo', 2, 365),
('4545', 'Test', '2019-02-07 13:34:02', '2019-02-07 13:12:05', 7, '7', '7', '7.00', '7.00', '7.00', '7.00', '7', '7', '7', '7', '7', 'DiskettJAM.jpg', 1, 1, '7', '7', '7', '7', '7', '7', '7', '7', '7', '2019-02-07 13:12:05', 'Activo', 17, 7),
('6767', 'Prueba', '2018-11-27 08:00:43', '2018-11-27 10:23:52', 0, '', '', '0.00', '0.00', '0.00', '0.00', '', '', '', '', '', 'inventario.jpg', 0, 1, '', '', '', '', '', '', '', '', '', '2018-11-28 08:00:43', 'Activo', 1, 60),
('7575', 'Jalikson', '2018-11-27 08:47:59', '2018-11-27 16:32:34', 0, '', '', '0.00', '0.00', '0.00', '0.00', '', '', '', '', '', 'foto_history.jpg', 0, 61, '', '', '', '', '', '', '', '', '', '2018-11-27 08:47:59', 'Activo', 42, 250),
('8659', 'TABLERO ELECTRICO - PRODUCCION', '2018-11-27 14:36:17', '2018-11-08 09:35:59', 260000, '205', '10N89UKK', '5.00', '90.00', '36.00', '60.00', 'ELECTROLITO', 'ELECTROLITO', 'ELECT', 'ESTE TABLERO ES POTENTE AL DISTRIBUIR', 'DISTRIBUIR', 'TableroElectricoProduccion.jpg', 1, 45, '0', '15', '0', 'SI', 'POI', 'PELI', 'CLL 80n #101-09', '5269636', 'electrolito@electrolito.com', '2015-07-31 09:35:59', 'Activo', 1, 60),
('9658', 'M13-COSTURA', '2018-11-27 14:36:35', '2018-11-21 16:00:49', 200000, '2005', 'LOP9908', '20.00', '80.00', '30.00', '1.50', 'Brother', 'Brother', 'Milton', 'COLOR BLANCO CON UNA AGUJA DE 3 PUL, ES MUY B', 'COSE A LA PERFECCIÓN', 'maquina-coser.jpg', 1, 62, '20', '50', '21', 'SI', 'N/A', 'N/A', 'Cra 5N #89-89', '3215698653', 'brother@brother.com', '2018-06-12 16:26:10', 'Activo', 3, 90);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fallo`
--

CREATE TABLE `fallo` (
  `cod` varchar(10) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `tipo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `fallo`
--

INSERT INTO `fallo` (`cod`, `descripcion`, `tipo`) VALUES
('C-01', 'DAÑO O PERDIDA DEL TIEMPO', 'COSTURA'),
('C-02', 'DAÑO EN EL PIÑON', 'COSTURA'),
('C-03', 'BARRA EN MAL ESTADO', 'COSTURA'),
('C-04', 'AJUSTE DE PIÑONERIA', 'COSTURA'),
('C-05', 'PLANCHUELA MAL ESTADO', 'COSTURA'),
('C-06', 'RODACHIN EN MAL ESTADO', 'COSTURA'),
('C-07', 'DAÑO EN CLUTH', 'COSTURA'),
('C-08', 'CORCHO EN MAL ESTADO', 'COSTURA'),
('C-09', 'PROBLEMAS DE TRANSPORTE', 'COSTURA'),
('C-10', 'CAJA BOBINA EN MAL ESTADO', 'COSTURA'),
('C-11', 'PEDAL EN MAL ESTADO', 'COSTURA'),
('C-12', 'DESGASTE DE BUJES', 'COSTURA'),
('C-13', 'DESGASTE DE BARRA DE AGUJA', 'COSTURA'),
('C-14', 'TRINQUETES EN MAL ESTADO', 'COSTURA'),
('C-15', 'TIRA EN MAL ESTADO', 'COSTURA'),
('C-16', 'PLATOS DE TENSION EN MAL ESTADO', 'COSTURA'),
('C-17', 'DAÑO EN ESPARRAGOS', 'COSTURA'),
('C-18', 'SUGETADOR DE AGUJA EN MAL ESTADO', 'COSTURA'),
('C-19', 'BIELAS EN MAL ESTADO', 'COSTURA'),
('C-20', 'DAÑO EN MUELLE', 'COSTURA'),
('C-21', 'DIENTE EN MAL ESTADO', 'COSTURA'),
('C-22', 'DEBANADOR EN MAL ESTADO', 'COSTURA'),
('C-23', 'CARRETELES TORCIDOS', 'COSTURA'),
('C-24', 'TUERCA DE TENSION EN MAL ESTADO', 'COSTURA'),
('E-01', 'CORTO CIRCUITO', 'ELECTRICO'),
('E-02', 'FLANCHE MAL ESTADO', 'ELECTRICO'),
('E-03', 'MICRO EN MAL ESTADO', 'ELECTRICO'),
('E-04', 'DAÑO EN PLC', 'ELECTRICO'),
('E-05', 'INTERRUPTOR EN MAL ESTADO', 'ELECTRICO'),
('E-06', 'RESISTENCIA EN MAL ESTADO', 'ELECTRICO'),
('E-07', 'TERMOCUPLA EN MAL ESTADO', 'ELECTRICO'),
('E-08', 'PIROMETRO MAL ESTADO', 'ELECTRICO'),
('E-09', 'CABLES SULFATADOS', 'ELECTRICO'),
('E-10', 'MOTOR QUEMADO', 'ELECTRICO'),
('E-11', 'DAÑO EN LA LAMPARA', 'ELECTRICO'),
('E-12', 'ELECTROVALVULA EN FALLA', 'ELECTRICO'),
('E-13', 'PEDAL EN FALLA', 'ELECTRICO'),
('E-14', 'RELAY EN MAL ESTADO', 'ELECTRICO'),
('E-15', 'PROBLEMAS DE VOLTAJE', 'ELECTRICO'),
('G-01', 'CONDICION INSEGURA DE OPERACION', 'GENERAL'),
('G-02', 'REVISION PREVENTIVA', 'GENERAL'),
('G-03', 'X PERIODO PARA LUBRICACION Y/O ENGRASE', 'GENERAL'),
('G-04', 'OTRO', 'GENERAL'),
('G-05', 'MALA OPERACION-OPERARIO', 'GENERAL'),
('M-01', 'RODAMIENTO EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-02', 'FALLA EN BOMBA', 'MECANICO - NEUMATICO'),
('M-03', 'DAÑO DE CORREA', 'MECANICO - NEUMATICO'),
('M-04', 'DAÑO EN POELA', 'MECANICO - NEUMATICO'),
('M-05', 'DAÑO EN DIAFRAGMA - BOLSA', 'MECANICO - NEUMATICO'),
('M-06', 'CADENA REVENTADA', 'MECANICO - NEUMATICO'),
('M-07', 'CADENA SIN TENSION', 'MECANICO - NEUMATICO'),
('M-08', 'RESORTE EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-09', 'TORNILLO REVENTADO O RODADO', 'MECANICO - NEUMATICO'),
('M-10', 'MANGUERA REVENTADA O EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-11', 'VALVULA EN FALLA', 'MECANICO - NEUMATICO'),
('M-12', 'ACOPLE EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-13', 'EMPAQUETADURA EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-14', 'RACOR MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-15', 'REGULADOR MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-16', 'MANOMETRO EN MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-17', 'LUBRICADOR UND MTTO MAL ESTADO', 'MECANICO - NEUMATICO'),
('M-18', 'PLACA PARA RECTIFICACION', 'MECANICO - NEUMATICO'),
('M-19', 'POLEA CON DESGASTE', 'MECANICO - NEUMATICO'),
('M-20', 'RUIDO A NORMAL', 'MECANICO - NEUMATICO'),
('M-21', 'VIBRACION A NORMAL', 'MECANICO - NEUMATICO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fallo_mantenimiento`
--

CREATE TABLE `fallo_mantenimiento` (
  `fallo_cod` varchar(10) NOT NULL,
  `mantenimiento_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `fallo_mantenimiento`
--

INSERT INTO `fallo_mantenimiento` (`fallo_cod`, `mantenimiento_id`) VALUES
('C-03', 239),
('E-02', 219),
('M-05', 220),
('M-06', 239),
('M-07', 221);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupo`
--

CREATE TABLE `grupo` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `grupo`
--

INSERT INTO `grupo` (`id`, `nombre`) VALUES
(1, 'TABLEROS ELECTRICOS'),
(2, 'BAÑOS'),
(3, 'MAQUINAS DE COSER'),
(4, 'GrupoPrueba'),
(5, 'TROQUELADORAS DE BANDERA'),
(6, 'TROQUELADORAS DE PUENTE'),
(7, 'CHIRIPIADORAS'),
(8, 'DESBASTADORAS'),
(9, 'POLICHADORAS'),
(10, 'CARDADORAS'),
(11, 'FRESADORAS'),
(12, 'CAMBRIADORAS'),
(13, 'NIVELADORAS'),
(14, 'REFILADORAS'),
(15, 'CONFORMADORAS'),
(16, 'PREMOLDEADORAS'),
(17, 'CLICHADORAS'),
(18, 'UNTADORAS'),
(19, 'REFERENCIADORAS'),
(20, 'FORMADORAS'),
(21, 'MAQUINAS BORDADORAS'),
(22, 'MAQUINAS ORISOL'),
(23, 'MAQUINAS LASER'),
(24, 'PRENSAS'),
(25, 'HORNOS RECTIVADORES '),
(26, 'CHILLER'),
(27, 'CHORROS'),
(28, 'HORNOS ENVEJECEDORES'),
(29, 'CABINAS DE PINTURA'),
(30, 'ESTROBEL'),
(31, 'MAQUEADORAS'),
(32, 'MAQUINAS DE POSTE DOS AGUJAS'),
(33, 'MAQUINAS DE POSTE UNA AGUJA'),
(34, 'RIBETEADORAS'),
(35, 'MAQUINAS PLANAS'),
(36, 'MAQUINAS SIGZADORAS'),
(37, 'MAQUINAS ESPECIALES'),
(38, 'MAQUINAS CHUCCANI'),
(39, 'FILETEADORAS'),
(40, 'DOBLADORAS'),
(41, 'HOJALETEADORAS'),
(42, 'MARTILLOS'),
(43, 'VAPORIZADORES'),
(44, 'DESCALZADORES'),
(45, 'MAQUINA LOCA'),
(46, 'SUBESTACIONES'),
(47, 'TRANSFORMADORES'),
(48, 'CELDAS'),
(49, 'PLANTAS ELECTRICAS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `herramientas`
--

CREATE TABLE `herramientas` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `pos` varchar(50) NOT NULL,
  `minimo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `herramientas`
--

INSERT INTO `herramientas` (`id`, `nombre`, `pos`, `minimo`) VALUES
(456, 'Alicate', 'B98', 1),
(505, 'Martillo', 'A90', 3),
(789, 'Destornillador', 'B08', 1),
(5698, 'Corta frío', 'N76', 1),
(8564, 'Pinzas', 'G87', 1),
(8565, 'Testing', 'Testing', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `herramientas_has_persona`
--

CREATE TABLE `herramientas_has_persona` (
  `id` int(11) NOT NULL,
  `herramientas_id` int(11) NOT NULL,
  `persona_id` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `herramientas_has_persona`
--

INSERT INTO `herramientas_has_persona` (`id`, `herramientas_id`, `persona_id`, `cantidad`, `fecha`) VALUES
(1, 789, 4, 0, '2018-11-26 14:29:32'),
(2, 456, 5, 1, '2018-11-20 18:54:01'),
(3, 505, 3, 1, '2018-11-20 06:24:55'),
(4, 505, 5, 1, '2018-11-20 18:53:45'),
(5, 5698, 5, 0, '2018-11-29 15:22:32'),
(6, 505, 3, 0, '2018-11-23 15:11:03'),
(7, 5698, 5, 1, '2018-11-26 14:33:25'),
(8, 8564, 4, 0, '2018-11-29 15:24:11'),
(9, 505, 9, 2, '2018-12-03 09:10:55');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos`
--

CREATE TABLE `insumos` (
  `id` int(11) NOT NULL,
  `ref` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `pos` varchar(50) NOT NULL,
  `precio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `insumos`
--

INSERT INTO `insumos` (`id`, `ref`, `nombre`, `marca`, `pos`, `precio`) VALUES
(2, '6598', 'PL285', 'PEGATEX', 'F09', 25000),
(3, '47113-5', 'Pintura de pizarrón', 'Ceresita', 'H78', 80000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos_has_mantenimiento`
--

CREATE TABLE `insumos_has_mantenimiento` (
  `id` int(11) NOT NULL,
  `insumos_id` int(11) NOT NULL,
  `mantenimiento_id` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `insumos_has_mantenimiento`
--

INSERT INTO `insumos_has_mantenimiento` (`id`, `insumos_id`, `mantenimiento_id`, `cantidad`) VALUES
(1, 2, 219, 1),
(2, 2, 220, 2),
(3, 3, 221, 2),
(4, 2, 197, 3),
(5, 3, 239, 2),
(6, 2, 239, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos_has_persona`
--

CREATE TABLE `insumos_has_persona` (
  `id` int(11) NOT NULL,
  `insumos_id` int(11) NOT NULL,
  `persona_id` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `insumos_has_persona`
--

INSERT INTO `insumos_has_persona` (`id`, `insumos_id`, `persona_id`, `cantidad`, `fecha`) VALUES
(1, 2, 3, 0, '2018-11-26 15:15:29'),
(2, 2, 3, 1, '2018-11-19 16:23:33'),
(3, 3, 5, 0, '2018-11-26 15:18:12'),
(4, 3, 3, 0, '2018-11-26 15:22:21'),
(5, 3, 13, 1, '2018-12-03 09:22:02');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `id` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `cantidad` int(11) NOT NULL,
  `descripcion` text,
  `herramientas_id` int(11) DEFAULT NULL,
  `equipo_codigo` varchar(50) DEFAULT NULL,
  `insumos_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`id`, `fecha`, `cantidad`, `descripcion`, `herramientas_id`, `equipo_codigo`, `insumos_id`) VALUES
(4, '2018-11-02 21:09:32', 20, 'Hay nuevos martillos', 505, NULL, NULL),
(5, '2018-11-08 21:04:40', 1, 'Pegante de madera de alta exigencia', NULL, NULL, 2),
(6, '2018-11-08 09:04:51', 4, 'Pegante de madera de alta exigencia', NULL, NULL, 2),
(7, '2018-11-19 13:41:44', 10, 'Entraron 10 alicates', 456, NULL, NULL),
(8, '2018-11-19 13:45:12', 8, 'Entraron 8 destornilladores\n', 789, NULL, NULL),
(9, '2018-11-19 13:53:25', 1, 'Pintura negro mate 1/4 galones', NULL, NULL, 3),
(10, '2018-11-19 16:23:13', 1, 'Pintura negro mate 1/4 galones', NULL, NULL, 3),
(11, '2018-11-23 14:13:44', 20, '20 corta fríos marca Brother', 5698, NULL, NULL),
(12, '2018-11-26 07:27:52', 15, 'Entraron 15 pinzas', 8564, NULL, NULL),
(13, '2019-02-07 09:49:12', 10, 'Testing', 8565, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mantenimiento`
--

CREATE TABLE `mantenimiento` (
  `id` int(11) NOT NULL,
  `tipo_mantenimiento` varchar(45) NOT NULL,
  `fecha_dano` timestamp NULL DEFAULT NULL,
  `fecha_hora_inicio` timestamp NULL DEFAULT NULL,
  `fecha_hora_fin` timestamp NULL DEFAULT NULL,
  `observacion` text,
  `equipo_codigo` varchar(50) NOT NULL,
  `numero_orden` int(11) NOT NULL,
  `fecha_ultimo_mantenimiento` timestamp NULL DEFAULT '0000-00-00 00:00:00',
  `fecha_prevista` timestamp NULL DEFAULT '0000-00-00 00:00:00',
  `solicita` varchar(50) NOT NULL,
  `fecha_solicitada` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `estado` tinyint(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `mantenimiento`
--

INSERT INTO `mantenimiento` (`id`, `tipo_mantenimiento`, `fecha_dano`, `fecha_hora_inicio`, `fecha_hora_fin`, `observacion`, `equipo_codigo`, `numero_orden`, `fecha_ultimo_mantenimiento`, `fecha_prevista`, `solicita`, `fecha_solicitada`, `estado`) VALUES
(177, 'Preventivo', NULL, '2018-11-13 14:48:12', '2018-11-13 15:48:12', 'Se le limpió el conector que estaba empolvado, se le cambió el artefacto y ya', '123', 8, '2018-11-13 14:48:47', '2018-11-13 23:00:00', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(178, 'Preventivo', NULL, '2018-11-14 05:00:00', '2018-11-15 05:00:00', 'ASd', '123', 9, '2018-11-15 05:00:00', '2019-01-09 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(179, 'Preventivo', NULL, NULL, NULL, NULL, '123', 10, NULL, '2019-03-10 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(180, 'Preventivo', NULL, NULL, NULL, NULL, '123', 11, NULL, '2019-05-09 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(181, 'Preventivo', NULL, NULL, NULL, NULL, '123', 12, NULL, '2019-07-08 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(182, 'Preventivo', NULL, NULL, NULL, NULL, '123', 13, NULL, '2019-09-06 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(183, 'Preventivo', NULL, NULL, NULL, NULL, '123', 14, NULL, '2019-11-05 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(184, 'Preventivo', NULL, NULL, NULL, NULL, '123', 15, NULL, '2020-01-04 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(185, 'Preventivo', NULL, NULL, NULL, NULL, '123', 16, NULL, '2020-03-04 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(186, 'Preventivo', NULL, NULL, NULL, NULL, '123', 17, NULL, '2020-05-03 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(187, 'Preventivo', NULL, NULL, NULL, NULL, '123', 18, NULL, '2020-07-02 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(188, 'Preventivo', NULL, NULL, NULL, NULL, '123', 19, NULL, '2020-08-31 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(189, 'Preventivo', NULL, NULL, NULL, NULL, '123', 20, NULL, '2020-10-30 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(190, 'Preventivo', NULL, NULL, NULL, NULL, '123', 21, NULL, '2020-12-29 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(191, 'Preventivo', NULL, NULL, NULL, NULL, '123', 22, NULL, '2021-02-27 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:10', 1),
(192, 'Preventivo', NULL, NULL, NULL, NULL, '123', 23, NULL, '2021-04-28 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:11', 1),
(193, 'Preventivo', NULL, NULL, NULL, NULL, '123', 24, NULL, '2021-06-27 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:11', 1),
(194, 'Preventivo', NULL, NULL, NULL, NULL, '123', 25, NULL, '2021-08-26 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:11', 1),
(195, 'Preventivo', NULL, NULL, NULL, NULL, '123', 26, NULL, '2021-10-25 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:11', 1),
(196, 'Preventivo', NULL, NULL, NULL, NULL, '123', 27, NULL, '2021-12-24 04:59:59', 'HENRY VENEGAS', '2018-11-08 20:35:11', 1),
(197, 'Preventivo', NULL, '2018-11-22 16:32:18', '2018-11-22 17:32:18', 'Se le pegó una tubería safada. Se le cambiaron unos empaques. El procedimiento fue exitoso.', '1369', 28, '2018-11-22 16:33:33', '2018-11-22 23:00:00', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(198, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 29, NULL, '2019-11-11 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(199, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 30, NULL, '2020-11-10 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(200, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 31, NULL, '2021-11-10 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(201, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 32, NULL, '2022-11-10 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(202, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 33, NULL, '2023-11-10 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(203, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 34, NULL, '2024-11-09 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(204, 'Preventivo', NULL, NULL, NULL, NULL, '1369', 35, NULL, '2025-11-09 04:59:59', 'MILTON ALVAREZ', '2018-11-08 20:35:26', 1),
(205, 'Preventivo', NULL, '2018-11-23 21:41:55', '2018-11-23 22:41:55', 'Se le realizó todo el proceso de limpieza.', '8659', 36, '2018-11-23 21:43:03', '2018-11-22 23:00:00', 'HENRY VENEGAS', '2018-11-08 21:36:53', 1),
(206, 'Preventivo', NULL, '2018-11-20 14:35:13', '2018-11-20 17:35:13', 'Probando ando', '8659', 37, '2018-11-20 14:35:38', '2019-01-10 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:53', 1),
(207, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 38, NULL, '2019-03-11 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:53', 1),
(208, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 39, NULL, '2019-05-10 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:53', 1),
(209, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 40, NULL, '2019-07-09 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(210, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 41, NULL, '2019-09-07 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(211, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 42, NULL, '2019-11-06 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(212, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 43, NULL, '2020-01-05 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(213, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 44, NULL, '2020-03-05 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(214, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 45, NULL, '2020-05-04 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(215, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 46, NULL, '2020-07-03 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(216, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 47, NULL, '2020-09-01 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(217, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 48, NULL, '2020-10-31 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:54', 1),
(218, 'Preventivo', NULL, NULL, NULL, NULL, '8659', 49, NULL, '2020-12-30 04:59:59', 'HENRY VENEGAS', '2018-11-08 21:36:55', 1),
(219, 'Correctivo', '2018-11-13 05:00:00', '2018-11-13 14:48:52', '2018-11-13 22:48:52', 'Se le partió el conector izquierdo', '123', 50, '2018-11-13 14:50:05', NULL, 'HENRY', '2018-11-13 05:00:00', 1),
(220, 'Correctivo', '2018-09-03 05:00:00', '2018-11-14 20:24:48', '2018-11-14 23:24:48', 'Hubo una falla en tal lado y tenemos que corregirlo', '123', 51, '2018-11-14 20:25:59', NULL, 'Marco', '2018-11-14 05:00:00', 1),
(221, 'Correctivo', '2018-11-19 05:00:00', '2018-11-19 16:49:35', '2018-11-19 22:49:35', 'Se le dañó tal cosa a tal máquina, quedo pendiente', '8659', 52, '2018-11-19 16:50:39', NULL, 'Milton', '2018-11-19 05:00:00', 1),
(222, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 53, NULL, '2019-01-02 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(223, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 54, NULL, '2019-04-02 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(224, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 55, NULL, '2019-07-01 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(225, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 56, NULL, '2019-09-29 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(226, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 57, NULL, '2019-12-28 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(227, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 58, NULL, '2020-03-27 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(228, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 59, NULL, '2020-06-25 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(229, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 60, NULL, '2020-09-23 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(230, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 61, NULL, '2020-12-22 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:03', 1),
(231, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 62, NULL, '2021-03-22 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(232, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 63, NULL, '2021-06-20 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(233, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 64, NULL, '2021-09-18 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(234, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 65, NULL, '2021-12-17 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(235, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 66, NULL, '2022-03-17 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(236, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 67, NULL, '2022-06-15 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(237, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 68, NULL, '2022-09-13 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(238, 'Preventivo', NULL, NULL, NULL, NULL, '9658', 69, NULL, '2022-12-12 04:59:59', 'HENRY VENEGAS', '2018-11-23 13:41:04', 1),
(239, 'Correctivo', '2018-11-24 05:00:00', '2018-11-24 17:57:48', '2018-11-24 20:57:48', 'SE LE PINTÓ LA TAPA DE ARRIBA. SE LE PEGÓ UNA PESTAÑA QUE TENÍA SAFADA, EL DAÑO FUE LEVE Y LA MAQUINA QUEDÓ FUNCIONANDO CORRECTAMENTE', '9658', 70, '2018-11-23 22:01:51', NULL, 'HENRY VENEGAS', '2018-11-24 05:00:00', 1),
(246, 'Preventivo', NULL, NULL, NULL, NULL, '7575', 71, NULL, '2018-11-29 04:59:59', 'HENRY VENEGAS', '2018-11-27 20:48:39', 0),
(247, 'Preventivo', NULL, NULL, NULL, NULL, '7575', 72, NULL, '2019-08-06 04:59:59', 'HENRY VENEGAS', '2018-11-27 20:48:39', 1),
(248, 'Preventivo', NULL, NULL, NULL, NULL, '7575', 73, NULL, '2020-04-12 04:59:59', 'HENRY VENEGAS', '2018-11-27 20:48:39', 1),
(249, 'Preventivo', NULL, NULL, NULL, NULL, '7575', 74, NULL, '2020-12-18 04:59:59', 'HENRY VENEGAS', '2018-11-27 20:48:39', 1),
(250, 'Preventivo', NULL, NULL, NULL, NULL, '7575', 75, NULL, '2021-08-25 04:59:59', 'HENRY VENEGAS', '2018-11-27 20:48:39', 1);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `mantenimientosejecutados`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `mantenimientosejecutados` (
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mantenimiento_has_persona`
--

CREATE TABLE `mantenimiento_has_persona` (
  `id` int(11) NOT NULL,
  `mantenimiento_id` int(11) NOT NULL,
  `persona_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `mantenimiento_has_persona`
--

INSERT INTO `mantenimiento_has_persona` (`id`, `mantenimiento_id`, `persona_id`) VALUES
(1, 177, 4),
(2, 219, 4),
(3, 220, 4),
(4, 221, 3),
(5, 178, 5),
(6, 206, 5),
(7, 197, 5),
(8, 205, 4),
(9, 239, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `id` int(11) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `cc` varchar(11) DEFAULT NULL,
  `puesto` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id`, `nombres`, `cc`, `puesto`) VALUES
(3, 'HENRY VENEGAS', '', 'JEFE DE MANTENIMIENTO'),
(4, 'MILTON ALVAREZ HERNANDEZ', '', 'COORDINADOR DE ADECUACIONES'),
(5, 'PEPITO PEREZ', '', 'ELECTRICISTA'),
(6, 'EDGAR VELASCO', NULL, 'MECANICO'),
(7, 'OSCAR ARENAS', NULL, 'MECANICO'),
(8, 'JEFERSON PATIÑO', NULL, 'MECANICO'),
(9, 'RAMIRO DE  LA CRUZ', NULL, 'MECANICO'),
(10, 'LEIMAN FIGUEROA', NULL, 'MECANICO'),
(11, 'ENRIQUE QUIÑONEZ', NULL, 'MECANICO'),
(12, 'ANDRES ZEA', NULL, 'MECANICO'),
(13, 'JHON FREDDY VELASCO', NULL, 'MECANICO'),
(14, 'ROBINSON MERCHAN', NULL, 'MECANICO'),
(15, 'DAGOBERTO BRAVO', NULL, 'MECANICO'),
(16, 'RONALD PAVI DAGUA', NULL, 'MECANICO'),
(17, 'HAROLD COKE', NULL, 'MECANICO'),
(18, 'JUAN CARLOS PEREZ', NULL, 'MECANICO'),
(19, 'JHON ALFARO TUIZ', NULL, 'MECANICO'),
(21, 'WILBER VELAZCO AGUILAR  ', NULL, 'MECANICO'),
(22, 'CARLOS ALZATE', '', 'ELECTRICISTA'),
(23, 'KEN ANDERSON AMARILES', '', 'ELECTRICISTA'),
(24, 'CARLOS MAURICIO AMAYA LOAIZA', '', 'ELECTRICISTA'),
(25, 'JONATHAN AMOR SOTO', '', 'ELECTRICISTA'),
(26, 'CARLOS ARELLANO', '', 'ELECTRICISTA'),
(27, 'ANGULO JOSE', '', 'ELECTRICISTA'),
(28, 'NOHEMI BEDOYA', '', 'ELECTRICISTA'),
(29, 'JOSE DUQUE', '', 'ELECTRICISTA'),
(30, 'LIBARDO ESCOBAR', '', 'ELECTRICISTA'),
(31, 'YILMER GOMEZ SAMBONI', '', 'ELECTRICISTA'),
(32, 'CRISTIAN GONZALES', '', 'ELECTRICISTA'),
(33, 'GILSON LEANDRO LASSO MEDINA', '', 'ELECTRICISTA'),
(34, 'MALLA', '', 'ELECTRICISTA'),
(35, 'JOHN JAIRO MELO VARGAS', '', 'ELECTRICISTA'),
(36, 'JEFFERSON PAVI', '', 'ELECTRICISTA'),
(37, 'ROMEL QUIÑONES', '', 'ELECTRICISTA'),
(38, 'JHON ALEJANDRO RIASCOS', '', 'ELECTRICISTA'),
(39, 'RUBEN SALDARRIAGA LOAIZA', '', 'ELECTRICISTA'),
(40, 'RAFAEL URIBE', '', 'ELECTRICISTA'),
(41, 'VICTOR VILLAVICENCIO RAMIREZ', '', 'ELECTRICISTA');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `seleccionarmantenimiento`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `seleccionarmantenimiento` (
`id` int(11)
,`tipo_mantenimiento` varchar(45)
,`fecha_dano` timestamp
,`fecha_hora_inicio` timestamp
,`fecha_hora_fin` timestamp
,`observacion` text
,`equipo_codigo` varchar(50)
,`numero_orden` int(11)
,`fecha_ultimo_mantenimiento` timestamp
,`fecha_prevista` timestamp
,`solicita` varchar(50)
,`fecha_solicitada` timestamp
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL,
  `tipo` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `usuario`, `contrasena`, `tipo`) VALUES
(1, 'adecuaciones', '1234', 'Adecuaciones'),
(2, 'almacen', '4321', 'Almacen'),
(3, 'admin', 'fcrs1st3m4s', 'Admin');

-- --------------------------------------------------------

--
-- Estructura para la vista `consultarencargadosmantenimientos`
--
DROP TABLE IF EXISTS `consultarencargadosmantenimientos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consultarencargadosmantenimientos`  AS  select `p`.`id` AS `id`,`p`.`nombres` AS `nombres`,`mhp`.`mantenimiento_id` AS `mantenimiento_id` from (`persona` `p` join `mantenimiento_has_persona` `mhp` on((`p`.`id` = `mhp`.`persona_id`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consultarerramientasmantenimiento`
--
DROP TABLE IF EXISTS `consultarerramientasmantenimiento`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consultarerramientasmantenimiento`  AS  select `h`.`id` AS `id`,concat(`h`.`nombre`,' - ',`hhm`.`cantidad`) AS `HerCan`,`hhm`.`mantenimiento_id` AS `mantenimiento_id` from (`herramientas` `h` join `herramientas_has_mantenimiento` `hhm` on((`h`.`id` = `hhm`.`herramientas_id`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consultarinsumosmantenimientos`
--
DROP TABLE IF EXISTS `consultarinsumosmantenimientos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consultarinsumosmantenimientos`  AS  select `i`.`id` AS `id`,concat(`i`.`nombre`,' - ',`ihm`.`cantidad`) AS `InsCan`,`ihm`.`mantenimiento_id` AS `mantenimiento_id`,`i`.`precio` AS `precio` from (`insumos` `i` join `insumos_has_mantenimiento` `ihm` on((`i`.`id` = `ihm`.`insumos_id`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `mantenimientosejecutados`
--
DROP TABLE IF EXISTS `mantenimientosejecutados`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `mantenimientosejecutados`  AS  select `m`.`id` AS `id`,`m`.`tipo_mantenimiento` AS `tipo_mantenimiento`,`m`.`fecha_dano` AS `fecha_dano`,`m`.`fecha_hora_inicio` AS `fecha_hora_inicio`,`m`.`fecha_hora_fin` AS `fecha_hora_fin`,`m`.`observacion` AS `observacion`,`m`.`equipo_codigo` AS `equipo_codigo`,`m`.`numero_orden` AS `numero_orden`,`m`.`fecha_ultimo_mantenimiento` AS `fecha_ultimo_mantenimiento`,`m`.`fecha_prevista` AS `fecha_prevista`,`m`.`solicita` AS `solicita`,`m`.`fecha_solicitada` AS `fecha_solicitada`,`e`.`codigo` AS `codigo`,`e`.`nombre` AS `NombreEquipo`,`hhm`.`cantidad` AS `cantidad_herramientas`,`h`.`nombre` AS `NombreHerramienta`,`ihm`.`cantidad` AS `cantidad_insumos`,`i`.`nombre` AS `nombre`,`p`.`nombres` AS `nombres`,`i`.`precio` AS `Precio` from (((((((`mantenimiento` `m` join `herramientas_has_mantenimiento` `hhm` on((`m`.`id` = `hhm`.`mantenimiento_id`))) join `herramientas` `h` on((`hhm`.`herramientas_id` = `h`.`id`))) join `mantenimiento_has_persona` `mhp` on((`m`.`id` = `mhp`.`mantenimiento_id`))) join `persona` `p` on((`mhp`.`persona_id` = `p`.`id`))) join `equipo` `e` on((`m`.`equipo_codigo` = `e`.`codigo`))) left join `insumos_has_mantenimiento` `ihm` on((`m`.`id` = `ihm`.`mantenimiento_id`))) left join `insumos` `i` on((`ihm`.`insumos_id` = `i`.`id`))) order by `m`.`id` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `seleccionarmantenimiento`
--
DROP TABLE IF EXISTS `seleccionarmantenimiento`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `seleccionarmantenimiento`  AS  select `mantenimiento`.`id` AS `id`,`mantenimiento`.`tipo_mantenimiento` AS `tipo_mantenimiento`,`mantenimiento`.`fecha_dano` AS `fecha_dano`,`mantenimiento`.`fecha_hora_inicio` AS `fecha_hora_inicio`,`mantenimiento`.`fecha_hora_fin` AS `fecha_hora_fin`,`mantenimiento`.`observacion` AS `observacion`,`mantenimiento`.`equipo_codigo` AS `equipo_codigo`,`mantenimiento`.`numero_orden` AS `numero_orden`,`mantenimiento`.`fecha_ultimo_mantenimiento` AS `fecha_ultimo_mantenimiento`,`mantenimiento`.`fecha_prevista` AS `fecha_prevista`,`mantenimiento`.`solicita` AS `solicita`,`mantenimiento`.`fecha_solicitada` AS `fecha_solicitada` from `mantenimiento` ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `actividad`
--
ALTER TABLE `actividad`
  ADD PRIMARY KEY (`cod`);

--
-- Indices de la tabla `actividad_mantenimiento`
--
ALTER TABLE `actividad_mantenimiento`
  ADD PRIMARY KEY (`actividad_cod`,`mantenimiento_id`),
  ADD KEY `fk_mantenimiento_id_actividad_mantenimiento` (`mantenimiento_id`);

--
-- Indices de la tabla `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `caracteristica`
--
ALTER TABLE `caracteristica`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `carac_grupo`
--
ALTER TABLE `carac_grupo`
  ADD PRIMARY KEY (`grupo_id`,`carac_id`),
  ADD KEY `fk_carac_carac_id` (`carac_id`);

--
-- Indices de la tabla `equipo`
--
ALTER TABLE `equipo`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fk_equipo_area` (`area_id`),
  ADD KEY `fk_grupo_id` (`grupo_id`);

--
-- Indices de la tabla `fallo`
--
ALTER TABLE `fallo`
  ADD PRIMARY KEY (`cod`);

--
-- Indices de la tabla `fallo_mantenimiento`
--
ALTER TABLE `fallo_mantenimiento`
  ADD PRIMARY KEY (`fallo_cod`,`mantenimiento_id`),
  ADD KEY `fk_mantenimiento_id_fallo_mantenimiento` (`mantenimiento_id`);

--
-- Indices de la tabla `grupo`
--
ALTER TABLE `grupo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `herramientas`
--
ALTER TABLE `herramientas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `herramientas_has_persona`
--
ALTER TABLE `herramientas_has_persona`
  ADD PRIMARY KEY (`id`,`herramientas_id`,`persona_id`),
  ADD KEY `fk_herramientas_has_persona_persona1_idx` (`persona_id`),
  ADD KEY `fk_herramientas_has_persona_herramientas1_idx` (`herramientas_id`);

--
-- Indices de la tabla `insumos`
--
ALTER TABLE `insumos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `insumos_has_mantenimiento`
--
ALTER TABLE `insumos_has_mantenimiento`
  ADD PRIMARY KEY (`id`,`insumos_id`,`mantenimiento_id`),
  ADD KEY `fk_insumos_has_mantenimiento_mantenimiento1_idx` (`mantenimiento_id`),
  ADD KEY `fk_insumos_has_mantenimiento_insumos1_idx` (`insumos_id`);

--
-- Indices de la tabla `insumos_has_persona`
--
ALTER TABLE `insumos_has_persona`
  ADD PRIMARY KEY (`id`,`insumos_id`,`persona_id`),
  ADD KEY `fk_insumos_has_persona_persona1_idx` (`persona_id`),
  ADD KEY `fk_insumos_has_persona_insumos1_idx` (`insumos_id`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_inventario_herramientas1` (`herramientas_id`),
  ADD KEY `fk_inventario_equipo1` (`equipo_codigo`),
  ADD KEY `fk_insumos_id` (`insumos_id`);

--
-- Indices de la tabla `mantenimiento`
--
ALTER TABLE `mantenimiento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_mantenimiento_equipo1_idx` (`equipo_codigo`);

--
-- Indices de la tabla `mantenimiento_has_persona`
--
ALTER TABLE `mantenimiento_has_persona`
  ADD PRIMARY KEY (`id`,`mantenimiento_id`,`persona_id`),
  ADD KEY `fk_mantenimiento_has_persona_persona1_idx` (`persona_id`),
  ADD KEY `fk_mantenimiento_has_persona_mantenimiento1_idx` (`mantenimiento_id`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `area`
--
ALTER TABLE `area`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- AUTO_INCREMENT de la tabla `caracteristica`
--
ALTER TABLE `caracteristica`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de la tabla `grupo`
--
ALTER TABLE `grupo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT de la tabla `herramientas`
--
ALTER TABLE `herramientas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8566;

--
-- AUTO_INCREMENT de la tabla `herramientas_has_persona`
--
ALTER TABLE `herramientas_has_persona`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `insumos`
--
ALTER TABLE `insumos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `insumos_has_mantenimiento`
--
ALTER TABLE `insumos_has_mantenimiento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `insumos_has_persona`
--
ALTER TABLE `insumos_has_persona`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `mantenimiento`
--
ALTER TABLE `mantenimiento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=251;

--
-- AUTO_INCREMENT de la tabla `mantenimiento_has_persona`
--
ALTER TABLE `mantenimiento_has_persona`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `actividad_mantenimiento`
--
ALTER TABLE `actividad_mantenimiento`
  ADD CONSTRAINT `fk_actividad_id_actividad_mantenimiento` FOREIGN KEY (`actividad_cod`) REFERENCES `actividad` (`cod`),
  ADD CONSTRAINT `fk_mantenimiento_id_actividad_mantenimiento` FOREIGN KEY (`mantenimiento_id`) REFERENCES `mantenimiento` (`id`);

--
-- Filtros para la tabla `carac_grupo`
--
ALTER TABLE `carac_grupo`
  ADD CONSTRAINT `fk_carac_carac_id` FOREIGN KEY (`carac_id`) REFERENCES `caracteristica` (`id`),
  ADD CONSTRAINT `fk_carac_grupo_id` FOREIGN KEY (`grupo_id`) REFERENCES `grupo` (`id`);

--
-- Filtros para la tabla `equipo`
--
ALTER TABLE `equipo`
  ADD CONSTRAINT `fk_equipo_area` FOREIGN KEY (`area_id`) REFERENCES `area` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_grupo_id` FOREIGN KEY (`grupo_id`) REFERENCES `grupo` (`id`);

--
-- Filtros para la tabla `fallo_mantenimiento`
--
ALTER TABLE `fallo_mantenimiento`
  ADD CONSTRAINT `fk_cod_fallo_fallo_mantenimiento` FOREIGN KEY (`fallo_cod`) REFERENCES `fallo` (`cod`),
  ADD CONSTRAINT `fk_mantenimiento_id_fallo_mantenimiento` FOREIGN KEY (`mantenimiento_id`) REFERENCES `mantenimiento` (`id`);

--
-- Filtros para la tabla `herramientas_has_persona`
--
ALTER TABLE `herramientas_has_persona`
  ADD CONSTRAINT `fk_herramientas_has_persona_herramientas1` FOREIGN KEY (`herramientas_id`) REFERENCES `herramientas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_herramientas_has_persona_persona1` FOREIGN KEY (`persona_id`) REFERENCES `persona` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `insumos_has_mantenimiento`
--
ALTER TABLE `insumos_has_mantenimiento`
  ADD CONSTRAINT `fk_insumos_has_mantenimiento_insumos1` FOREIGN KEY (`insumos_id`) REFERENCES `insumos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_insumos_has_mantenimiento_mantenimiento1` FOREIGN KEY (`mantenimiento_id`) REFERENCES `mantenimiento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `insumos_has_persona`
--
ALTER TABLE `insumos_has_persona`
  ADD CONSTRAINT `fk_insumos_has_persona_insumos1` FOREIGN KEY (`insumos_id`) REFERENCES `insumos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_insumos_has_persona_persona1` FOREIGN KEY (`persona_id`) REFERENCES `persona` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `fk_insumos_id` FOREIGN KEY (`insumos_id`) REFERENCES `insumos` (`id`),
  ADD CONSTRAINT `fk_inventario_equipo1` FOREIGN KEY (`equipo_codigo`) REFERENCES `equipo` (`codigo`),
  ADD CONSTRAINT `fk_inventario_herramientas1` FOREIGN KEY (`herramientas_id`) REFERENCES `herramientas` (`id`);

--
-- Filtros para la tabla `mantenimiento`
--
ALTER TABLE `mantenimiento`
  ADD CONSTRAINT `fk_mantenimiento_equipo1` FOREIGN KEY (`equipo_codigo`) REFERENCES `equipo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `mantenimiento_has_persona`
--
ALTER TABLE `mantenimiento_has_persona`
  ADD CONSTRAINT `fk_mantenimiento_has_persona_mantenimiento1` FOREIGN KEY (`mantenimiento_id`) REFERENCES `mantenimiento` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_mantenimiento_has_persona_persona1` FOREIGN KEY (`persona_id`) REFERENCES `persona` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
