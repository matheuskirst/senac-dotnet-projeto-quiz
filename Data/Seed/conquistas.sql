-- ============================================================
-- CONQUISTAS
-- ============================================================

INSERT INTO "Conquistas"
    ("Id", "Nome", "Descricao", "Tipo", "Meta", "TemaId")
VALUES
(1, 'Primeiro Quiz Diário Concluído', 'Complete seu primeiro quiz diário', 1, 1, NULL),

(2, '10 Acertos Seguidos', 'Atinja 10 respostas corretas em consecução no quiz diário', 2, 10, NULL),

(3, 'Mestre em Hardware', 'Atinja 100 acertos no tema Hardware', 3, 100, 1),

(4, 'Mestre em Programacao', 'Atinja 100 acertos no tema Programacao', 3, 100, 2),

(5, 'Mestre em Redes', 'Atinja 100 acertos no tema Redes', 3, 100, 3),

(6, 'Mestre em Segurança Digital', 'Atinja 100 acertos no tema Segurança Digital', 3, 100, 4),

(7, 'Mestre em Sistemas Operacionais', 'Atinja 100 acertos no tema Sistemas Operacionais',  3, 100, 5),

(8, 'Mestre em Ferramentas de Produtividade', 'Atinja 100 acertos no tema Ferramentas de Produtividade', 3, 100, 6),

(9, 'Acessou por 3 Dias Seguidos', 'Faça login por três dias consecutivos', 4, 3, NULL),

(10, 'Acessou por 7 Dias Seguidos', 'Faça login a cada dia por uma semana', 4, 7, NULL),

(11, 'Erre TODAS questões em um quiz diário', 'Burro!, Burro!, Burro!... Incompetente. Soneca...
Medíocre.. Medíocre... MEDÍOCRE!, MEDÍOCRE!!, MEDÍOCRE!!!
Um Troglodita.. Troglodita!, Troglodita!, Troglodita!
Psicologicamente destruído, moralmente abalado.. e tecnicamente não existe.
LIXO! LIXO!-
Me desculpe eu tô alterado, TÔ ALTERADO! TÔ ALTERADO!
POR QUE É BURRO!, BURRO!!, BURRO!!, BURRO!!, BURRO!!, BURRO!!, BURRO!!!', 5, 0, NULL);
