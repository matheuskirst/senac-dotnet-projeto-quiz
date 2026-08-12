create table TipoPergunta(
	Id Serial primary key,
	Nome VARCHAR(255) not null
);


create table NivelPergunta(
	Id Serial primary key,
	Nome VARCHAR(255) not null,
	Pontos INT not null,
);

insert into NivelPergunta (Nome, Pontos)
values 
	("Iniciante", 10),
	("Fácil", 20),
	("Intermediário", 30),
	("Avançado", 50);


create table TemaPergunta(
	Id Serial primary key,
	Nome VARCHAR(255) not null
);

insert into TemaPergunta (Nome)
values 
	("Hardware"),
	("Programação"),
	("Redes"),
	("Segurança Digital"),
	("Sistemas Operacionais"),
	("Ferramentas de produtividade");


create table Pergunta(
	Id Serial primary key,
	Enunciado VARCHAR(255) not null,
	TipoPerguntaId INT not null,
	NivelPerguntaId INT not null,
	TemaPerguntaId INT not null,
	foreign key (TipoPerguntaId) references TipoPergunta(Id),
	foreign key (NivelPerguntaId) references NivelPergunta(Id),
	foreign key (TemaPerguntaId) references TemaPergunta(Id)
);

create table NivelUsuario(
	Id Serial primary key,
	Nome VARCHAR(50) not null,
	Pontos_Min INT not null,
	Pontos_Max INT
);

insert into NivelUsuario (Nome, Pontos_Min, Pontos_Max)
values 
	("Iniciante", 0, 500),
	("Aprendiz", 501, 2000),
	("Intermediário", 2001, 10000),
	("Avançado", 10001);

create table Usuario(
	Id Serial primary key,
	Nome VARCHAR(30) not null,
	Nickname VARCHAR(30) not null,
	DataDeNascimento TIMESTAMP not null,
	Senha VARCHAR(255) not null,
	NivelUsuarioId INT not null,
	PontuacaoTotal INT not null,
	TotalAcertos INT not null,
	TotalRespondidas INT not null,
	AcertosConsecutivos INT not null,
	foreign key (NivelUsuarioId) references NivelUsuario(Id)
);


create table RespostaUsuario(
	Id SERIAL primary key,
	UsuarioId INT not null,
	PerguntaId INT not null,
	Acertou BOOLEAN not null,
	DataDeResposta TIMESTAMP not null,
	foreign key (UsuarioId) references Usuario(Id),
	foreign key (PerguntaId) references Pergunta(Id)
);


create table Conquista(
	Id SERIAL primary key,
	Nome VARCHAR(50) not null,
	Descricao VARCHAR(255) not null,
	Icone TEXT
);

insert into Conquista (Nome, Descricao)
values 
	("Primeiro Quiz Concluído", "Complete seu primeiro quiz"),
	("10 Acertos Seguidos", "Atinga 10 respostas corretas em consecução"),
	("Mestre em Hardware", "Atinga 100 acertos no tema 'Hardware'"),
	("Mestre em Programação", "Atinga 100 acertos no tema 'Programação'"),
	("Mestre em Redes", "Atinga 100 acertos no tema 'Redes'"),
	("Mestre em Segurança Digital", "Atinga 100 acertos no tema 'Segurança Digital'"),
	("Mestre em Sistemas Operacionais", "Atinga 100 acertos no tema 'Sistemas Operacionais'"),
	("Mestre em Ferramentas de Produtividade", "Atinga 100 acertos no tema 'Ferramentas de Produtividade'"),
	("Acessou por 3 Dias Seguidos", "Faça login por três dias consecutivos"),
	("Acessou por 7 Dias Seguidos", "Faça login a cada dia por uma semana"),
	("Acessou por 30 Dias Seguidos", "Faça login a cada dia por um mês"),
	("Acessou por 90 Dias Seguidos", "Faça login a cada dia por três meses consecutivos"),
	("Acessou por 365 Dias Seguidos", "Faça login a cada dia por um ano");


create table ConquistaUsuario(
	Id SERIAL primary key,
	UsuarioId INT references Usuario(Id) on delete cascade,
	ConquistaId INT references Conquista(Id) on delete cascade
);
