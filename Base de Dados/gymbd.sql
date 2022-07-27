-- phpMyAdmin SQL Dump
-- version 5.3.0-dev+20220727.b0c4426a43
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 28-Jul-2022 às 00:38
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gymbd`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluno`
--

CREATE TABLE `aluno` (
  `idAluno` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `aluno`
--

INSERT INTO `aluno` (`idAluno`, `idPessoa`) VALUES
(20, 105),
(22, 107),
(23, 112);

-- --------------------------------------------------------

--
-- Estrutura da tabela `aula`
--

CREATE TABLE `aula` (
  `idAula` int(11) NOT NULL,
  `horaInicio` varchar(10) NOT NULL,
  `horaDuracao` varchar(10) NOT NULL,
  `dataAula` varchar(10) NOT NULL,
  `limiteAluno` int(10) UNSIGNED NOT NULL,
  `idModalidade` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `idEspaco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `aula`
--

INSERT INTO `aula` (`idAula`, `horaInicio`, `horaDuracao`, `dataAula`, `limiteAluno`, `idModalidade`, `idProf`, `idEspaco`) VALUES
(1, '00:00:00', '00:00:07', '0000-00-00', 7, 3, 29, 9);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cancha`
--

CREATE TABLE `cancha` (
  `idCancha` int(11) NOT NULL,
  `idEspaco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cancha`
--

INSERT INTO `cancha` (`idCancha`, `idEspaco`) VALUES
(2, 11);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`idCliente`, `idPessoa`) VALUES
(3, 105),
(5, 107),
(6, 112);

-- --------------------------------------------------------

--
-- Estrutura da tabela `contrato`
--

CREATE TABLE `contrato` (
  `codContrato` int(11) NOT NULL,
  `idAluno` int(11) NOT NULL,
  `dataInicio` date NOT NULL,
  `dataFim` date NOT NULL,
  `formaPagemnto` varchar(200) NOT NULL,
  `mensalidade` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `contrato`
--

INSERT INTO `contrato` (`codContrato`, `idAluno`, `dataInicio`, `dataFim`, `formaPagemnto`, `mensalidade`) VALUES
(17, 20, '2022-05-15', '2022-05-19', 'À vista', 17000),
(19, 22, '2022-05-15', '2022-05-23', 'Anualmente', 17000),
(20, 23, '2022-05-15', '2022-05-25', 'À vista', 17000);

-- --------------------------------------------------------

--
-- Estrutura da tabela `espaco`
--

CREATE TABLE `espaco` (
  `idEspaco` int(11) NOT NULL,
  `andar` varchar(45) NOT NULL,
  `nSala` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `espaco`
--

INSERT INTO `espaco` (`idEspaco`, `andar`, `nSala`) VALUES
(1, '', ''),
(3, '', ''),
(4, 'jh', 'dsj'),
(5, '1hsn', 'kjdks'),
(6, 'uh', '123'),
(7, 'ij', 'js'),
(9, '1º Andar', '5678'),
(10, '2º andar', 'E1/07'),
(11, '2º andar', 'E1/0ds'),
(12, '3', '78');

-- --------------------------------------------------------

--
-- Estrutura da tabela `especializacao`
--

CREATE TABLE `especializacao` (
  `idEspecializacao` int(11) NOT NULL,
  `especializacao` varchar(200) DEFAULT NULL,
  `idProf` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `especializacao`
--

INSERT INTO `especializacao` (`idEspecializacao`, `especializacao`, `idProf`) VALUES
(25, 'OWFK', 29),
(26, 'WLFK', 29),
(27, 'WKEJF', 29),
(28, '5ghj m', 60),
(29, 'gdksj', 61),
(30, '4534', 64),
(31, 'ghj', 65),
(36, 'hgf', 68),
(37, 'yueri', 69);

-- --------------------------------------------------------

--
-- Estrutura da tabela `modalidade`
--

CREATE TABLE `modalidade` (
  `idModalidade` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `descricao` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `modalidade`
--

INSERT INTO `modalidade` (`idModalidade`, `nome`, `descricao`) VALUES
(1, 'Voleibol', NULL),
(2, 'Basquete', NULL),
(3, 'Futebol', NULL),
(4, 'Karatê', NULL),
(5, 'Judo', NULL),
(6, 'Xadez', 'skcksdcsck');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `idPessoa` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `BI` varchar(30) NOT NULL,
  `cidade` varchar(20) DEFAULT 'Luanda',
  `municipio` varchar(30) DEFAULT 'N/A',
  `bairro` varchar(20) DEFAULT 'N/A',
  `rua` varchar(20) DEFAULT 'N/A',
  `nCasa` varchar(20) DEFAULT 'N/A'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`idPessoa`, `nome`, `BI`, `cidade`, `municipio`, `bairro`, `rua`, `nCasa`) VALUES
(1, 'Atircio Matias', '45', 'Luanda', 'Belas', 'Kilamba', 'D', 'D27-APT04'),
(2, 'João Antonio', '000LA', 'Luanda', 'Maianga', 'Prenda', 'Amerela', '20304'),
(4, 'joao', '000LA34', 'Luanda', 'Viana', 'lupipa', 'rua 16', '132'),
(5, 'Carla Dias', '000043', 'Luanda', 'N/A', 'N/A', 'N/A', 'N/A'),
(10, 'wiltom joc', 'edwkrj', 'jsvh', 'kfsvsk', 'ksjg', 'ksv', 'ksajf'),
(16, 'hugo', 'ss', '', '', '', '', ''),
(18, 'Ivandro', '634', 'skjdf', 'skjfhd', 'sskdjfkj', 'ksbvj', 'hdfj'),
(33, 'hghg', '456789', '', '', '', '', ''),
(45, 'Poliano', '243', 'Luanda', 'Klkoklç', 'N/A', 'N/A', 'N/A'),
(49, 'BRUNO', '53232W', 'Malanje', '', '', '', ''),
(51, 'Ukana', '07', '', '', '', '', ''),
(68, 'Teresa', '12567', '', '', '', '', ''),
(75, 'tkyh', '45678', '', '', '', '', ''),
(76, 'Paulo', '56789', '', '', '', '', ''),
(80, 'LEidy', '5678965y6u78', '', '', '', '', ''),
(81, 'Keliane', '9090908875', '', '', '', '', ''),
(82, 'jhifdsj', '987678', '', '', '', '', ''),
(83, 'udjchsn', '8767867876785657879', '', '', '', '', ''),
(84, 'SIM', '23456', '', '', '', '', ''),
(89, 'dufh', '6789', '', '', '', '', ''),
(90, 'sudyvjk', '765456789', '', '', '', '', ''),
(92, 'juehd', '23', '', '', '', '', ''),
(93, 'Cli', '34', '', '', '', '', ''),
(94, 'CLICLI', '2', '', '', '', '', ''),
(96, '6KKKKK', '23442344243424', '', '', '', '', ''),
(97, 'oppopopo', 'popo34567', '', '', '', '', ''),
(98, 'novamente', 'niva8783', '', '', '', '', ''),
(100, 'ATKNMS', '3243', '', '', '', '', ''),
(105, 'sfjn', '1234redf', '', '', '', '', ''),
(107, 'ghthjk', '1123', '', '', '', '', ''),
(108, 'jhf', '367546879', 'Luanda', '', '', '', ''),
(111, 'Tatiana Nito', '0084849LA04', 'Luanda', 'Viana', 'Zango Três', 'Dira', '273'),
(112, 'Alvaro Carvalho', '006382la782', 'Luanda', 'Viana', '', '', ''),
(113, 'Guilherme Dala', '4647532LA042', 'Luanda', 'Sambizanga', 'ytdsc', '67', '568');

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

CREATE TABLE `professor` (
  `idProf` int(11) NOT NULL,
  `nCarteira` varchar(20) DEFAULT NULL,
  `salario` varchar(20) DEFAULT NULL,
  `idPessoa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`idProf`, `nCarteira`, `salario`, `idPessoa`) VALUES
(1, '07', '75000', 1),
(26, '4567', '5652', 45),
(29, '23243', '4243223', 49),
(42, '04', '45678', 51),
(56, '567', '678', 76),
(58, '34567', '345678', 76),
(60, '67567867854768787890', '5678', 80),
(61, '123321233212321', '656', 81),
(64, '56743T5GFR DX', '24', 100),
(65, '5468754io', '12', 108),
(68, '23', '100000', 111),
(69, '23456767', '150000', 113);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professormodalidade`
--

CREATE TABLE `professormodalidade` (
  `idModalidade` int(11) DEFAULT NULL,
  `idProf` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `professormodalidade`
--

INSERT INTO `professormodalidade` (`idModalidade`, `idProf`) VALUES
(1, 1),
(2, 1),
(2, 1),
(2, 26),
(2, 29),
(3, 29),
(5, 29),
(5, 58),
(2, 61),
(4, 61),
(3, 64),
(5, 64),
(2, 65),
(3, 65),
(5, 65),
(2, 68),
(4, 68),
(2, 69);

-- --------------------------------------------------------

--
-- Estrutura da tabela `qualificacao`
--

CREATE TABLE `qualificacao` (
  `idQualificacao` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `quali` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `qualificacao`
--

INSERT INTO `qualificacao` (`idQualificacao`, `idProf`, `quali`) VALUES
(1, 1, 'Mestrado em Voleibol Pela UAN'),
(2, 1, 'Defesa de Quadra no Basquete'),
(10, 1, 'siefuwied'),
(34, 29, 'QEIFJ'),
(35, 29, 'DFOWJ'),
(36, 29, 'WKEFJ'),
(37, 60, 'yghkjl'),
(38, 61, 'sshgjdh'),
(39, 64, '34546'),
(40, 65, 'dgfhj'),
(44, 68, 'sdkv'),
(45, 69, 'sdk');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sala`
--

CREATE TABLE `sala` (
  `idSala` int(11) NOT NULL,
  `idEspaco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `sala`
--

INSERT INTO `sala` (`idSala`, `idEspaco`) VALUES
(8, 9),
(9, 10),
(10, 12);

-- --------------------------------------------------------

--
-- Estrutura da tabela `telefone`
--

CREATE TABLE `telefone` (
  `idTelefone` int(11) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `idPessoa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `telefone`
--

INSERT INTO `telefone` (`idTelefone`, `telefone`, `idPessoa`) VALUES
(28, '(+244) 955 655 989', 49),
(29, '(+244) 985 956 565', 49),
(30, '(+244) 955 655 989', 49),
(31, '(+244) 985 956 565', 49),
(32, '(+244) 999 999 99', 84),
(33, '(+244) 985 862 822', 84),
(34, '(+244) 999 999 99', 84),
(35, '(+244) 985 862 822', 84),
(36, '(+244) 923 385 141', 90),
(37, '(+244) 923 358 22', 90),
(38, '(+244) 966 553 856', 92),
(39, '(+244)  83 856 ', 92),
(40, '(+244) 999 999 99', 94),
(41, '(+244) 999 999 99', 94),
(42, '(+244) 999 999 99', 96),
(43, '(+244) 896 549 656', 97),
(44, '(+244) 896 549 656', 97),
(45, '(+244) 896 549 656', 98),
(46, '(+244) 886 568 689', 98),
(49, '(+244) 998 877 665', 100),
(55, '(+244) 928 252 522', 111),
(56, '(+244) 952 656 656', 111);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `pass` varchar(25) NOT NULL,
  `login` varchar(50) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `CC` varchar(45) DEFAULT NULL,
  `EC` varchar(45) DEFAULT NULL,
  `AS` varchar(45) DEFAULT NULL,
  `C` varchar(45) DEFAULT NULL,
  `E` varchar(45) DEFAULT NULL,
  `A` varchar(45) DEFAULT NULL,
  `CO` varchar(45) DEFAULT NULL,
  `GR` varchar(45) DEFAULT NULL,
  `AA` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `pass`, `login`, `Nome`, `CC`, `EC`, `AS`, `C`, `E`, `A`, `CO`, `GR`, `AA`) VALUES
(1, '123', 'atircio', 'Atircio Matias', '1', '1', '1', '1', '1', '1', '1', '1', '1'),
(3, '123', 'b', 'b', '0', '0', '0', '0', '0', '0', '0', '0', '0'),
(6, '123', 'zanza', ' Cristiano Zanzala', '1', '0', '0', '0', '0', '0', '0', '0', '0');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`idAluno`),
  ADD KEY `aluno_ibfk_1` (`idPessoa`);

--
-- Índices para tabela `aula`
--
ALTER TABLE `aula`
  ADD PRIMARY KEY (`idAula`),
  ADD KEY `aula_ibfk_1` (`idModalidade`),
  ADD KEY `aula_ibfk_2` (`idProf`),
  ADD KEY `fk_idSala` (`idEspaco`);

--
-- Índices para tabela `cancha`
--
ALTER TABLE `cancha`
  ADD PRIMARY KEY (`idCancha`),
  ADD KEY `fk_idEspaco_tbCancha` (`idEspaco`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`),
  ADD KEY `cliente_ibfk_1` (`idPessoa`);

--
-- Índices para tabela `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`codContrato`),
  ADD KEY `fk_idAluno_tbAluno` (`idAluno`);

--
-- Índices para tabela `espaco`
--
ALTER TABLE `espaco`
  ADD PRIMARY KEY (`idEspaco`);

--
-- Índices para tabela `especializacao`
--
ALTER TABLE `especializacao`
  ADD PRIMARY KEY (`idEspecializacao`),
  ADD KEY `especializacao_ibfk_1` (`idProf`);

--
-- Índices para tabela `modalidade`
--
ALTER TABLE `modalidade`
  ADD PRIMARY KEY (`idModalidade`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`idPessoa`),
  ADD UNIQUE KEY `BI` (`BI`);

--
-- Índices para tabela `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`idProf`),
  ADD UNIQUE KEY `nCarteira` (`nCarteira`),
  ADD KEY `professor_ibfk_1` (`idPessoa`);

--
-- Índices para tabela `professormodalidade`
--
ALTER TABLE `professormodalidade`
  ADD KEY `professormodalidade_ibfk_1` (`idModalidade`),
  ADD KEY `professormodalidade_ibfk_2` (`idProf`);

--
-- Índices para tabela `qualificacao`
--
ALTER TABLE `qualificacao`
  ADD PRIMARY KEY (`idQualificacao`),
  ADD KEY `qualificacao_ibfk_1` (`idProf`);

--
-- Índices para tabela `sala`
--
ALTER TABLE `sala`
  ADD PRIMARY KEY (`idSala`),
  ADD KEY `fk_idEspaco_tbEspaco` (`idEspaco`);

--
-- Índices para tabela `telefone`
--
ALTER TABLE `telefone`
  ADD PRIMARY KEY (`idTelefone`),
  ADD KEY `fk_idPessoa` (`idPessoa`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aluno`
--
ALTER TABLE `aluno`
  MODIFY `idAluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `aula`
--
ALTER TABLE `aula`
  MODIFY `idAula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `cancha`
--
ALTER TABLE `cancha`
  MODIFY `idCancha` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `contrato`
--
ALTER TABLE `contrato`
  MODIFY `codContrato` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `espaco`
--
ALTER TABLE `espaco`
  MODIFY `idEspaco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `especializacao`
--
ALTER TABLE `especializacao`
  MODIFY `idEspecializacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de tabela `modalidade`
--
ALTER TABLE `modalidade`
  MODIFY `idModalidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `pessoa`
--
ALTER TABLE `pessoa`
  MODIFY `idPessoa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;

--
-- AUTO_INCREMENT de tabela `professor`
--
ALTER TABLE `professor`
  MODIFY `idProf` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

--
-- AUTO_INCREMENT de tabela `qualificacao`
--
ALTER TABLE `qualificacao`
  MODIFY `idQualificacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT de tabela `sala`
--
ALTER TABLE `sala`
  MODIFY `idSala` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `telefone`
--
ALTER TABLE `telefone`
  MODIFY `idTelefone` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `aluno`
--
ALTER TABLE `aluno`
  ADD CONSTRAINT `aluno_ibfk_1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `aula`
--
ALTER TABLE `aula`
  ADD CONSTRAINT `aula_ibfk_1` FOREIGN KEY (`idModalidade`) REFERENCES `modalidade` (`idModalidade`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `aula_ibfk_2` FOREIGN KEY (`idProf`) REFERENCES `professor` (`idProf`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `cancha`
--
ALTER TABLE `cancha`
  ADD CONSTRAINT `fk_idEspaco_tbCancha` FOREIGN KEY (`idEspaco`) REFERENCES `espaco` (`idEspaco`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `contrato`
--
ALTER TABLE `contrato`
  ADD CONSTRAINT `fk_idAluno_tbAluno` FOREIGN KEY (`idAluno`) REFERENCES `aluno` (`idAluno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `especializacao`
--
ALTER TABLE `especializacao`
  ADD CONSTRAINT `especializacao_ibfk_1` FOREIGN KEY (`idProf`) REFERENCES `professor` (`idProf`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `professor`
--
ALTER TABLE `professor`
  ADD CONSTRAINT `professor_ibfk_1` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `professormodalidade`
--
ALTER TABLE `professormodalidade`
  ADD CONSTRAINT `professormodalidade_ibfk_1` FOREIGN KEY (`idModalidade`) REFERENCES `modalidade` (`idModalidade`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `professormodalidade_ibfk_2` FOREIGN KEY (`idProf`) REFERENCES `professor` (`idProf`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `qualificacao`
--
ALTER TABLE `qualificacao`
  ADD CONSTRAINT `qualificacao_ibfk_1` FOREIGN KEY (`idProf`) REFERENCES `professor` (`idProf`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `sala`
--
ALTER TABLE `sala`
  ADD CONSTRAINT `fk_idEspaco_tbEspaco` FOREIGN KEY (`idEspaco`) REFERENCES `espaco` (`idEspaco`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `telefone`
--
ALTER TABLE `telefone`
  ADD CONSTRAINT `fk_idPessoa` FOREIGN KEY (`idPessoa`) REFERENCES `pessoa` (`idPessoa`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
