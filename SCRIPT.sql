create database bdBafometro;
go

use bdBafometro;
go

create table tbUsuario
(
	codUsuario int primary key identity(1, 1) not null,
	nome varchar(40) not null,
	cpf varchar(11) not null,
	cnh varchar(30) not null,
	dataNascimento datetime not null
);
go

create table tbOcorrencia
(
	codOcorrencia int primary key identity(1, 1) not null,
	codUsuario int references tbUsuario not null,
	valorAlcool float not null,
	dataOcorrencia datetime not null
);
go