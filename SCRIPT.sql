create database bdBafometro;
go

use bdBafometro;
go

create table tbUsuario
(
	codUsuario int primary key identity(1, 1) not null,
	nome varchar(40),
	cpf varchar(11),
	cnh varchar(30),
	dataNascimento datetime
);
go

create table tbOcorrencia
(
	codOcorrencia int primary key identity(1, 1) not null,
	codUsuario int references tbUsuario,
	valorAlcool float,
	dataOcorrencia datetime
);
go