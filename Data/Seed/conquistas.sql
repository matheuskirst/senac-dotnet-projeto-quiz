-- ============================================================
-- CONQUISTAS
-- ============================================================

INSERT INTO "Conquistas"
    ("Id", "Nome", "Descricao", "Tipo", "Meta", "TemaId", "Secreta")
VALUES
(1, 'Primeiro Quiz Diário Concluído', 'Complete seu primeiro quiz diário', 1, 1, NULL, FALSE),

(2, '10 Acertos Seguidos', 'Atinja 10 respostas corretas em consecução no quiz diário', 2, 10, NULL, FALSE),

(3, 'Mestre em Hardware', 'Atinja 100 acertos no tema Hardware', 3, 100, 1, FALSE),

(4, 'Mestre em Programacao', 'Atinja 100 acertos no tema Programacao', 3, 100, 2, FALSE),

(5, 'Mestre em Redes', 'Atinja 100 acertos no tema Redes', 3, 100, 3, FALSE),

(6, 'Mestre em Segurança Digital', 'Atinja 100 acertos no tema Segurança Digital', 3, 100, 4, FALSE),

(7, 'Mestre em Sistemas Operacionais', 'Atinja 100 acertos no tema Sistemas Operacionais',  3, 100, 5, FALSE),

(8, 'Mestre em Ferramentas de Produtividade', 'Atinja 100 acertos no tema Ferramentas de Produtividade', 3, 100, 6, FALSE),

(9, 'Acessou por 3 Dias Seguidos', 'Faça login por três dias consecutivos', 4, 3, NULL, FALSE),

(10, 'Acessou por 7 Dias Seguidos', 'Faça login a cada dia por uma semana', 4, 7, NULL, FALSE);
