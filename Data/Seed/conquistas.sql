-- ============================================================
-- CONQUISTAS
-- ============================================================

INSERT INTO "Conquistas"
    ("Id", "Nome", "Descricao", "Tipo", "Meta", "TemaId")
VALUES
(1, 'Primeiro Quiz Diário Concluído',
    'Complete seu primeiro quiz diário',
    1, 1, NULL),

(2, '10 Acertos Seguidos',
    'Atinga 10 respostas corretas em consecução',
    2, 10, NULL),

(3, 'Mestre em Hardware',
    'Atinga 100 acertos no tema Hardware',
    3, 100, 1),

(4, 'Mestre em Programacao',
    'Atinga 100 acertos no tema Programacao',
    3, 100, 2),

(5, 'Mestre em Redes',
    'Atinga 100 acertos no tema Redes',
    3, 100, 3),

(6, 'Mestre em Segurança Digital',
    'Atinga 100 acertos no tema Segurança Digital',
    3, 100, 4),

(7, 'Mestre em Sistemas Operacionais',
    'Atinga 100 acertos no tema Sistemas Operacionais',
    3, 100, 5),

(8, 'Mestre em Ferramentas de Produtividade',
    'Atinga 100 acertos no tema Ferramentas de Produtividade',
    3, 100, 6),

(9, 'Acessou por 3 Dias Seguidos',
    'Faça login por três dias consecutivos',
    4, 3, NULL),

(10, 'Acessou por 7 Dias Seguidos',
    'Faça login a cada dia por uma semana',
    4, 7, NULL),

(11, 'Acessou por 30 Dias Seguidos',
    'Faça login a cada dia por um mês',
    4, 30, NULL),

(12, 'Acessou por 90 Dias Seguidos',
    'Faça login a cada dia por três meses consecutivos',
    4, 90, NULL),

(13, 'Acessou por 365 Dias Seguidos',
    'Faça login a cada dia por um ano',
    4, 365, NULL);
