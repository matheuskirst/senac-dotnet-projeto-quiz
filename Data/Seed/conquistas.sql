-- ============================================================
-- CONQUISTAS
-- ============================================================

INSERT INTO "Conquistas"
    ("Id", "Nome", "Descricao", "Tipo", "Meta", "TemaId", "Secreta", "IconPath")
VALUES
(1, 'Primeiro Quiz Diário Concluído', 'Complete seu primeiro quiz diário', 1, 1, NULL, FALSE, 'Assets\Icons\primeiro-quiz-diario.png'),

(2, '10 Acertos Seguidos', 'Atinja 10 respostas corretas em consecução no quiz diário', 2, 10, NULL, FALSE, 'Assets\Icons\10-acertos-consecutivos.png'),

(3, 'Mestre em Hardware', 'Atinja 100 acertos no tema Hardware', 3, 100, 1, FALSE, 'Assets\Icons\100-acertos-hardware.png'),

(4, 'Mestre em Programação', 'Atinja 100 acertos no tema Programação', 3, 100, 2, FALSE, 'Assets\Icons\100-acertos-programacao.png'),

(5, 'Mestre em Redes', 'Atinja 100 acertos no tema Redes', 3, 100, 3, FALSE, 'Assets\Icons\100-acertos-redes.png'),

(6, 'Mestre em Segurança Digital', 'Atinja 100 acertos no tema Segurança Digital', 3, 100, 4, FALSE, 'Assets\Icons\100-acertos-seguranca-digital.png'),

(7, 'Mestre em Sistemas Operacionais', 'Atinja 100 acertos no tema Sistemas Operacionais',  3, 100, 5, FALSE, 'Assets\Icons\100-acertos-sistemas-operacionais.png'),

(8, 'Mestre em Ferramentas de Produtividade', 'Atinja 100 acertos no tema Ferramentas de Produtividade', 3, 100, 6, FALSE, 'Assets\Icons\100-acertos-ferramentas-de-produtividade.png'),

(9, 'Acessou por 3 Dias Seguidos', 'Realize um login todo dia por três dias consecutivos', 4, 3, NULL, FALSE, 'Assets\Icons\acessos-3.png'),

(10, 'Acessou por 7 Dias Seguidos', 'Realize um login todo dia por uma semana', 4, 7, NULL, FALSE, 'Assets\Icons\acessos-7.png');
