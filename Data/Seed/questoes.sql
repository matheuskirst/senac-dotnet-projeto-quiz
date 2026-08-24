-- ============================================================
-- QUESTÃO NÍVEIS
-- ============================================================
INSERT INTO "QuestaoNiveis"
    ("Id", "Nome", "Pontos")
VALUES
(1, 'Iniciante', 10),
(2, 'Fácil', 20),
(3, 'Intermediário', 30),
(4, 'Avançado', 50);


-- ============================================================
-- QUESTÃO TEMAS
-- ============================================================
INSERT INTO "QuestaoTemas"
    ("Id", "Nome")
VALUES
(1, 'Hardware'),
(2, 'Programacao'),
(3, 'Redes'),
(4, 'Segurança Digital'),
(5, 'Sistemas Operacionais'),
(6, 'Ferramentas De Produtividade');


-- ============================================================
-- QUESTÃO TIPOS
-- ============================================================
INSERT INTO "QuestaoTipos"
    ("Id", "Nome")
VALUES
(1, 'Alternativas'),
(2, 'Verdadeiro ou Falso');


-- ============================================================
-- QUESTÕES
-- ============================================================

INSERT INTO "Questoes"
    ("Id", "Enunciado", "TemaId", "NivelId", "TipoId", "Verdadeira")
VALUES

-- ============================================================
-- HARDWARE
-- ============================================================

(1, 'Qual componente do computador é responsável por executar as instruções dos programas?', 1, 1, 1, NULL),
(2, 'Qual dos componentes abaixo é utilizado para armazenar dados permanentemente?', 1, 1, 1, NULL),
(3, 'A memória RAM é um tipo de memória volátil.', 1, 2, 2, TRUE),
(4, 'Qual componente é responsável pelo processamento gráfico de um computador?', 1, 2, 1, NULL),

-- ============================================================
-- PROGRAMAÇÃO
-- ============================================================

(5, 'O que é uma variável em programação?', 2, 1, 1, NULL),
(6, 'Qual estrutura é normalmente utilizada para repetir um bloco de código enquanto uma condição for verdadeira?', 2, 1, 1, NULL),
(7, 'Uma função pode receber parâmetros e retornar um valor.', 2, 2, 2, TRUE),
(8, 'O que significa o conceito de encapsulamento na programação orientada a objetos?', 2, 3, 1, NULL),

-- ============================================================
-- REDES
-- ============================================================

(9, 'O que significa a sigla IP?', 3, 1, 1, NULL),
(10, 'Qual dispositivo é normalmente utilizado para conectar diferentes redes?', 3, 1, 1, NULL),
(11, 'O protocolo HTTPS utiliza criptografia para proteger a comunicação entre cliente e servidor.', 3, 2, 2, TRUE),
(12, 'Qual protocolo é utilizado para traduzir nomes de domínio em endereços IP?', 3, 2, 1, NULL),

-- ============================================================
-- SEGURANÇA DIGITAL
-- ============================================================

(13, 'O que é phishing?', 4, 1, 1, NULL),
(14, 'Qual é uma boa prática para proteger uma conta online?', 4, 1, 1, NULL),
(15, 'Uma senha forte deve ser utilizada em várias contas diferentes para facilitar o gerenciamento.', 4, 2, 2, FALSE),
(16, 'O que caracteriza um ataque de ransomware?', 4, 3, 1, NULL),

-- ============================================================
-- SISTEMAS OPERACIONAIS
-- ============================================================

(17, 'Qual é a principal função de um sistema operacional?', 5, 1, 1, NULL),
(18, 'Qual dos sistemas abaixo é um sistema operacional?', 5, 1, 1, NULL),
(19, 'O sistema operacional é responsável por gerenciar recursos de hardware e software.', 5, 2, 2, TRUE),
(20, 'O que é um processo em um sistema operacional?', 5, 3, 1, NULL),

-- ============================================================
-- FERRAMENTAS DE PRODUTIVIDADE
-- ============================================================

(21, 'Qual ferramenta é normalmente utilizada para criar e editar planilhas eletrônicas?', 6, 1, 1, NULL),
(22, 'Qual é a finalidade principal de um editor de texto?', 6, 1, 1, NULL),
(23, 'Ferramentas de armazenamento em nuvem permitem acessar arquivos a partir de diferentes dispositivos.', 6, 2, 2, TRUE),
(24, 'Qual recurso de uma planilha eletrônica pode ser utilizado para resumir grandes conjuntos de dados?', 6, 3, 1, NULL),

-- ============================================================
-- HARDWARE - AVANÇADO
-- ============================================================

(25, 'Qual característica de uma CPU moderna permite executar múltiplas sequências de instruções simultaneamente dentro de um mesmo núcleo físico?', 1, 4, 1, NULL),
(26, 'O aumento da frequência do processador, mantendo a mesma arquitetura, tende principalmente a aumentar qual aspecto do desempenho?', 1, 4, 1, NULL),

-- ============================================================
-- PROGRAMAÇÃO - AVANÇADO
-- ============================================================

(27, 'Qual princípio de programação orientada a objetos permite que uma classe forneça uma implementação específica de um método definido em uma classe base?', 2, 4, 1, NULL),
(28, 'Em análise de algoritmos, qual é a complexidade de tempo típica da busca binária em uma coleção ordenada?', 2, 4, 1, NULL),

-- ============================================================
-- REDES - AVANÇADO
-- ============================================================

(29, 'Qual protocolo é utilizado para obter automaticamente configurações de rede, como endereço IP, máscara de sub-rede e gateway?', 3, 4, 1, NULL),
(30, 'Em uma rede TCP/IP, qual mecanismo permite que vários dispositivos de uma rede privada compartilhem um único endereço IP público?', 3, 4, 1, NULL),

-- ============================================================
-- SEGURANÇA DIGITAL - AVANÇADO
-- ============================================================

(31, 'Qual princípio de segurança determina que um usuário deve receber somente as permissões necessárias para executar suas funções?', 4, 4, 1, NULL),
(32, 'Em uma infraestrutura de chave pública (PKI), qual entidade é responsável por emitir e validar certificados digitais?', 4, 4, 1, NULL),

-- ============================================================
-- SISTEMAS OPERACIONAIS - AVANÇADO
-- ============================================================

(33, 'Qual mecanismo de um sistema operacional permite que processos utilizem mais memória virtual do que a quantidade de RAM fisicamente disponível?', 5, 4, 1, NULL),
(34, 'Qual problema ocorre quando dois ou mais processos ficam permanentemente esperando por recursos mantidos uns pelos outros?', 5, 4, 1, NULL),

-- ============================================================
-- FERRAMENTAS DE PRODUTIVIDADE - AVANÇADO
-- ============================================================

(35, 'Em uma planilha eletrônica, qual recurso permite combinar dados provenientes de diferentes intervalos ou tabelas e gerar análises interativas?', 6, 4, 1, NULL),
(36, 'Em uma planilha eletrônica, qual função é mais adequada para procurar um valor em uma tabela e retornar um dado correspondente de outra coluna?', 6, 4, 1, NULL);


-- ============================================================
-- ALTERNATIVAS
-- ============================================================

INSERT INTO "Alternativas"
    ("Id", "Texto", "IsCorreta", "QuestaoId")
VALUES

-- ============================================================
-- QUESTÃO 1
-- ============================================================

(1, 'Processador (CPU)', TRUE, 1),
(2, 'Placa de vídeo', FALSE, 1),
(3, 'Fonte de alimentação', FALSE, 1),
(4, 'Monitor', FALSE, 1),

-- ============================================================
-- QUESTÃO 2
-- ============================================================

(5, 'Memória RAM', FALSE, 2),
(6, 'SSD ou HD', TRUE, 2),
(7, 'Cache do processador', FALSE, 2),
(8, 'Registrador da CPU', FALSE, 2),

-- ============================================================
-- QUESTÃO 4
-- ============================================================

(11, 'GPU', TRUE, 4),
(12, 'CPU', FALSE, 4),
(13, 'Fonte de alimentação', FALSE, 4),
(14, 'Memória RAM', FALSE, 4),

-- ============================================================
-- QUESTÃO 5
-- ============================================================

(15, 'Um espaço de memória utilizado para armazenar um valor que pode ser alterado.', TRUE, 5),
(16, 'Um tipo de banco de dados.', FALSE, 5),
(17, 'Um dispositivo físico do computador.', FALSE, 5),
(18, 'Um protocolo de rede.', FALSE, 5),

-- ============================================================
-- QUESTÃO 6
-- ============================================================

(19, 'while', TRUE, 6),
(20, 'class', FALSE, 6),
(21, 'return', FALSE, 6),
(22, 'import', FALSE, 6),

-- ============================================================
-- QUESTÃO 8
-- ============================================================

(25, 'Esconder detalhes internos e controlar o acesso aos dados de um objeto.', TRUE, 8),
(26, 'Executar várias aplicações simultaneamente.', FALSE, 8),
(27, 'Criar automaticamente um banco de dados.', FALSE, 8),
(28, 'Converter código-fonte em código de máquina.', FALSE, 8),

-- ============================================================
-- QUESTÃO 9
-- ============================================================

(29, 'Internet Protocol', TRUE, 9),
(30, 'Internal Program', FALSE, 9),
(31, 'Internet Process', FALSE, 9),
(32, 'Integrated Protocol', FALSE, 9),

-- ============================================================
-- QUESTÃO 10
-- ============================================================

(33, 'Roteador', TRUE, 10),
(34, 'Teclado', FALSE, 10),
(35, 'Monitor', FALSE, 10),
(36, 'Impressora', FALSE, 10),

-- ============================================================
-- QUESTÃO 12
-- ============================================================

(39, 'DNS', TRUE, 12),
(40, 'FTP', FALSE, 12),
(41, 'SMTP', FALSE, 12),
(42, 'SSH', FALSE, 12),

-- ============================================================
-- QUESTÃO 13
-- ============================================================

(43, 'Uma tentativa de enganar alguém para obter informações confidenciais.', TRUE, 13),
(44, 'Um tipo de antivírus.', FALSE, 13),
(45, 'Um método de compactação de arquivos.', FALSE, 13),
(46, 'Um protocolo utilizado para transmissão de vídeos.', FALSE, 13),

-- ============================================================
-- QUESTÃO 14
-- ============================================================

(47, 'Utilizar autenticação multifator.', TRUE, 14),
(48, 'Usar a mesma senha em todos os serviços.', FALSE, 14),
(49, 'Compartilhar a senha com pessoas de confiança.', FALSE, 14),
(50, 'Desativar atualizações de segurança.', FALSE, 14),

-- ============================================================
-- QUESTÃO 16
-- ============================================================

(53, 'Um ataque que criptografa ou bloqueia arquivos e exige pagamento para restaurar o acesso.', TRUE, 16),
(54, 'Um ataque que aumenta a velocidade do computador.', FALSE, 16),
(55, 'Um método de backup automático.', FALSE, 16),
(56, 'Um protocolo de comunicação segura.', FALSE, 16),

-- ============================================================
-- QUESTÃO 17
-- ============================================================

(57, 'Gerenciar os recursos do computador e fornecer serviços para os programas.', TRUE, 17),
(58, 'Aumentar fisicamente a memória RAM.', FALSE, 17),
(59, 'Produzir energia elétrica para o computador.', FALSE, 17),
(60, 'Substituir o processador.', FALSE, 17),

-- ============================================================
-- QUESTÃO 18
-- ============================================================

(61, 'Linux', TRUE, 18),
(62, 'Google Chrome', FALSE, 18),
(63, 'Microsoft Word', FALSE, 18),
(64, 'MySQL', FALSE, 18),

-- ============================================================
-- QUESTÃO 20
-- ============================================================

(67, 'Um programa ou instância de programa em execução.', TRUE, 20),
(68, 'Um arquivo armazenado permanentemente no disco.', FALSE, 20),
(69, 'Um componente físico da placa-mãe.', FALSE, 20),
(70, 'Uma conexão de rede.', FALSE, 20),

-- ============================================================
-- QUESTÃO 21
-- ============================================================

(71, 'Microsoft Excel', TRUE, 21),
(72, 'Microsoft Word', FALSE, 21),
(73, 'Microsoft Paint', FALSE, 21),
(74, 'Bloco de Notas', FALSE, 21),

-- ============================================================
-- QUESTÃO 22
-- ============================================================

(75, 'Criar e editar documentos de texto.', TRUE, 22),
(76, 'Gerenciar componentes de hardware.', FALSE, 22),
(77, 'Configurar redes.', FALSE, 22),
(78, 'Monitorar temperatura do processador.', FALSE, 22),

-- ============================================================
-- QUESTÃO 24
-- ============================================================

(81, 'Tabela dinâmica', TRUE, 24),
(82, 'Cor de fundo da célula', FALSE, 24),
(83, 'Quebra de página', FALSE, 24),
(84, 'Cabeçalho do documento', FALSE, 24),

-- ============================================================
-- QUESTÃO 25 - HARDWARE AVANÇADO
-- ============================================================

(85, 'Hyper-threading ou SMT', TRUE, 25),
(86, 'Memória virtual', FALSE, 25),
(87, 'Barramento PCI', FALSE, 25),
(88, 'Cache L1', FALSE, 25),

-- ============================================================
-- QUESTÃO 26 - HARDWARE AVANÇADO
-- ============================================================

(89, 'A quantidade de ciclos de processamento por segundo', TRUE, 26),
(90, 'A capacidade de armazenamento do SSD', FALSE, 26),
(91, 'A quantidade de memória RAM instalada', FALSE, 26),
(92, 'A resolução máxima do monitor', FALSE, 26),

-- ============================================================
-- QUESTÃO 27 - PROGRAMAÇÃO AVANÇADO
-- ============================================================

(93, 'Sobrescrita de método (override)', TRUE, 27),
(94, 'Sobrecarga de memória', FALSE, 27),
(95, 'Encapsulamento de arquivo', FALSE, 27),
(96, 'Serialização de objeto', FALSE, 27),

-- ============================================================
-- QUESTÃO 28 - PROGRAMAÇÃO AVANÇADO
-- ============================================================

(97, 'O(log n)', TRUE, 28),
(98, 'O(n)', FALSE, 28),
(99, 'O(n²)', FALSE, 28),
(100, 'O(2ⁿ)', FALSE, 28),

-- ============================================================
-- QUESTÃO 29 - REDES AVANÇADO
-- ============================================================

(101, 'DHCP', TRUE, 29),
(102, 'DNS', FALSE, 29),
(103, 'HTTP', FALSE, 29),
(104, 'FTP', FALSE, 29),

-- ============================================================
-- QUESTÃO 30 - REDES AVANÇADO
-- ============================================================

(105, 'NAT', TRUE, 30),
(106, 'ARP', FALSE, 30),
(107, 'ICMP', FALSE, 30),
(108, 'SMTP', FALSE, 30),

-- ============================================================
-- QUESTÃO 31 - SEGURANÇA DIGITAL AVANÇADO
-- ============================================================

(109, 'Princípio do menor privilégio', TRUE, 31),
(110, 'Defesa em profundidade', FALSE, 31),
(111, 'Segurança por obscuridade', FALSE, 31),
(112, 'Negação de serviço', FALSE, 31),

-- ============================================================
-- QUESTÃO 32 - SEGURANÇA DIGITAL AVANÇADO
-- ============================================================

(113, 'Autoridade Certificadora (CA)', TRUE, 32),
(114, 'Servidor DNS', FALSE, 32),
(115, 'Firewall', FALSE, 32),
(116, 'Servidor DHCP', FALSE, 32),

-- ============================================================
-- QUESTÃO 33 - SISTEMAS OPERACIONAIS AVANÇADO
-- ============================================================

(117, 'Memória virtual', TRUE, 33),
(118, 'Spooling', FALSE, 33),
(119, 'Deadlock', FALSE, 33),
(120, 'Fragmentação externa', FALSE, 33),

-- ============================================================
-- QUESTÃO 34 - SISTEMAS OPERACIONAIS AVANÇADO
-- ============================================================

(121, 'Deadlock', TRUE, 34),
(122, 'Cache miss', FALSE, 34),
(123, 'Page fault', FALSE, 34),
(124, 'Context switch', FALSE, 34),

-- ============================================================
-- QUESTÃO 35 - FERRAMENTAS DE PRODUTIVIDADE AVANÇADO
-- ============================================================

(125, 'Tabela dinâmica', TRUE, 35),
(126, 'Formatação condicional', FALSE, 35),
(127, 'Quebra de página', FALSE, 35),
(128, 'Validação de dados', FALSE, 35),

-- ============================================================
-- QUESTÃO 36 - FERRAMENTAS DE PRODUTIVIDADE AVANÇADO
-- ============================================================

(129, 'PROCV ou PROCX', TRUE, 36),
(130, 'CONT.SE', FALSE, 36),
(131, 'SOMA', FALSE, 36),
(132, 'MÉDIA', FALSE, 36);
