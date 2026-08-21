-- ============================================================
-- PERGUNTAS
-- ============================================================

INSERT INTO "Perguntas"
    ("Id", "Enunciado", "TemaId", "Tipo", "Nivel")
VALUES

-- ============================================================
-- HARDWARE
-- ============================================================

(1, 'Qual componente do computador é responsável por executar as instruções dos programas?', 1, 1, 1),

(2, 'Qual dos componentes abaixo é utilizado para armazenar dados permanentemente?', 1, 1, 1),

(3, 'A memória RAM é um tipo de memória volátil.', 1, 2, 2),

(4, 'Qual componente é responsável pelo processamento gráfico de um computador?', 1, 1, 2),


-- ============================================================
-- PROGRAMAÇÃO
-- ============================================================

(5, 'O que é uma variável em programação?', 2, 1, 1),

(6, 'Qual estrutura é normalmente utilizada para repetir um bloco de código enquanto uma condição for verdadeira?', 2, 1, 1),

(7, 'Uma função pode receber parâmetros e retornar um valor.', 2, 2, 2),

(8, 'O que significa o conceito de encapsulamento na programação orientada a objetos?', 2, 1, 3),


-- ============================================================
-- REDES
-- ============================================================

(9, 'O que significa a sigla IP?', 3, 1, 1),

(10, 'Qual dispositivo é normalmente utilizado para conectar diferentes redes?', 3, 1, 1),

(11, 'O protocolo HTTPS utiliza criptografia para proteger a comunicação entre cliente e servidor.', 3, 2, 2),

(12, 'Qual protocolo é utilizado para traduzir nomes de domínio em endereços IP?', 3, 1, 2),


-- ============================================================
-- SEGURANÇA DIGITAL
-- ============================================================

(13, 'O que é phishing?', 4, 1, 1),

(14, 'Qual é uma boa prática para proteger uma conta online?', 4, 1, 1),

(15, 'Uma senha forte deve ser utilizada em várias contas diferentes para facilitar o gerenciamento.', 4, 2, 2),

(16, 'O que caracteriza um ataque de ransomware?', 4, 1, 3),


-- ============================================================
-- SISTEMAS OPERACIONAIS
-- ============================================================

(17, 'Qual é a principal função de um sistema operacional?', 5, 1, 1),

(18, 'Qual dos sistemas abaixo é um sistema operacional?', 5, 1, 1),

(19, 'O sistema operacional é responsável por gerenciar recursos de hardware e software.', 5, 2, 2),

(20, 'O que é um processo em um sistema operacional?', 5, 1, 3),


-- ============================================================
-- FERRAMENTAS DE PRODUTIVIDADE
-- ============================================================

(21, 'Qual ferramenta é normalmente utilizada para criar e editar planilhas eletrônicas?', 6, 1, 1),

(22, 'Qual é a finalidade principal de um editor de texto?', 6, 1, 1),

(23, 'Ferramentas de armazenamento em nuvem permitem acessar arquivos a partir de diferentes dispositivos.', 6, 2, 2),

(24, 'Qual recurso de uma planilha eletrônica pode ser utilizado para resumir grandes conjuntos de dados?', 6, 1, 3);


-- ============================================================
-- ALTERNATIVAS
-- ============================================================

INSERT INTO "PerguntasAlternativas" 
    ("Id", "Texto", "IsCorreta", "PerguntaId")
VALUES

-- ============================================================
-- PERGUNTA 1
-- ============================================================

(1, 'Processador (CPU)', TRUE, 1),
(2, 'Placa de vídeo', FALSE, 1),
(3, 'Fonte de alimentação', FALSE, 1),
(4, 'Monitor', FALSE, 1),


-- ============================================================
-- PERGUNTA 2
-- ============================================================

(5, 'Memória RAM', FALSE, 2),
(6, 'SSD ou HD', TRUE, 2),
(7, 'Cache do processador', FALSE, 2),
(8, 'Registrador da CPU', FALSE, 2),


-- ============================================================
-- PERGUNTA 3
-- ============================================================

(9, 'Verdadeiro', TRUE, 3),
(10, 'Falso', FALSE, 3),


-- ============================================================
-- PERGUNTA 4
-- ============================================================

(11, 'GPU', TRUE, 4),
(12, 'CPU', FALSE, 4),
(13, 'Fonte de alimentação', FALSE, 4),
(14, 'Memória RAM', FALSE, 4),


-- ============================================================
-- PERGUNTA 5
-- ============================================================

(15, 'Um espaço de memória utilizado para armazenar um valor que pode ser alterado.', TRUE, 5),
(16, 'Um tipo de banco de dados.', FALSE, 5),
(17, 'Um dispositivo físico do computador.', FALSE, 5),
(18, 'Um protocolo de rede.', FALSE, 5),


-- ============================================================
-- PERGUNTA 6
-- ============================================================

(19, 'while', TRUE, 6),
(20, 'class', FALSE, 6),
(21, 'return', FALSE, 6),
(22, 'import', FALSE, 6),


-- ============================================================
-- PERGUNTA 7
-- ============================================================

(23, 'Verdadeiro', TRUE, 7),
(24, 'Falso', FALSE, 7),


-- ============================================================
-- PERGUNTA 8
-- ============================================================

(25, 'Esconder detalhes internos e controlar o acesso aos dados de um objeto.', TRUE, 8),
(26, 'Executar várias aplicações simultaneamente.', FALSE, 8),
(27, 'Criar automaticamente um banco de dados.', FALSE, 8),
(28, 'Converter código-fonte em código de máquina.', FALSE, 8),


-- ============================================================
-- PERGUNTA 9
-- ============================================================

(29, 'Internet Protocol', TRUE, 9),
(30, 'Internal Program', FALSE, 9),
(31, 'Internet Process', FALSE, 9),
(32, 'Integrated Protocol', FALSE, 9),


-- ============================================================
-- PERGUNTA 10
-- ============================================================

(33, 'Roteador', TRUE, 10),
(34, 'Teclado', FALSE, 10),
(35, 'Monitor', FALSE, 10),
(36, 'Impressora', FALSE, 10),


-- ============================================================
-- PERGUNTA 11
-- ============================================================

(37, 'Verdadeiro', TRUE, 11),
(38, 'Falso', FALSE, 11),


-- ============================================================
-- PERGUNTA 12
-- ============================================================

(39, 'DNS', TRUE, 12),
(40, 'FTP', FALSE, 12),
(41, 'SMTP', FALSE, 12),
(42, 'SSH', FALSE, 12),


-- ============================================================
-- PERGUNTA 13
-- ============================================================

(43, 'Uma tentativa de enganar alguém para obter informações confidenciais.', TRUE, 13),
(44, 'Um tipo de antivírus.', FALSE, 13),
(45, 'Um método de compactação de arquivos.', FALSE, 13),
(46, 'Um protocolo utilizado para transmissão de vídeos.', FALSE, 13),


-- ============================================================
-- PERGUNTA 14
-- ============================================================

(47, 'Utilizar autenticação multifator.', TRUE, 14),
(48, 'Usar a mesma senha em todos os serviços.', FALSE, 14),
(49, 'Compartilhar a senha com pessoas de confiança.', FALSE, 14),
(50, 'Desativar atualizações de segurança.', FALSE, 14),


-- ============================================================
-- PERGUNTA 15
-- ============================================================

(51, 'Verdadeiro', FALSE, 15),
(52, 'Falso', TRUE, 15),


-- ============================================================
-- PERGUNTA 16
-- ============================================================

(53, 'Um ataque que criptografa ou bloqueia arquivos e exige pagamento para restaurar o acesso.', TRUE, 16),
(54, 'Um ataque que aumenta a velocidade do computador.', FALSE, 16),
(55, 'Um método de backup automático.', FALSE, 16),
(56, 'Um protocolo de comunicação segura.', FALSE, 16),


-- ============================================================
-- PERGUNTA 17
-- ============================================================

(57, 'Gerenciar os recursos do computador e fornecer serviços para os programas.', TRUE, 17),
(58, 'Aumentar fisicamente a memória RAM.', FALSE, 17),
(59, 'Produzir energia elétrica para o computador.', FALSE, 17),
(60, 'Substituir o processador.', FALSE, 17),


-- ============================================================
-- PERGUNTA 18
-- ============================================================

(61, 'Linux', TRUE, 18),
(62, 'Google Chrome', FALSE, 18),
(63, 'Microsoft Word', FALSE, 18),
(64, 'MySQL', FALSE, 18),


-- ============================================================
-- PERGUNTA 19
-- ============================================================

(65, 'Verdadeiro', TRUE, 19),
(66, 'Falso', FALSE, 19),


-- ============================================================
-- PERGUNTA 20
-- ============================================================

(67, 'Um programa ou instância de programa em execução.', TRUE, 20),
(68, 'Um arquivo armazenado permanentemente no disco.', FALSE, 20),
(69, 'Um componente físico da placa-mãe.', FALSE, 20),
(70, 'Uma conexão de rede.', FALSE, 20),


-- ============================================================
-- PERGUNTA 21
-- ============================================================

(71, 'Microsoft Excel', TRUE, 21),
(72, 'Microsoft Word', FALSE, 21),
(73, 'Microsoft Paint', FALSE, 21),
(74, 'Bloco de Notas', FALSE, 21),


-- ============================================================
-- PERGUNTA 22
-- ============================================================

(75, 'Criar e editar documentos de texto.', TRUE, 22),
(76, 'Gerenciar componentes de hardware.', FALSE, 22),
(77, 'Configurar redes.', FALSE, 22),
(78, 'Monitorar temperatura do processador.', FALSE, 22),


-- ============================================================
-- PERGUNTA 23
-- ============================================================

(79, 'Verdadeiro', TRUE, 23),
(80, 'Falso', FALSE, 23),


-- ============================================================
-- PERGUNTA 24
-- ============================================================

(81, 'Tabela dinâmica', TRUE, 24),
(82, 'Cor de fundo da célula', FALSE, 24),
(83, 'Quebra de página', FALSE, 24),
(84, 'Cabeçalho do documento', FALSE, 24);
