create database LoginCore;
use LoginCore;

create table Cliente(
Id int auto_increment primary key,
Nome VARCHAR(50) NOT NULL,
Nascimento DATETIME NOT NULL,
Sexo char(1),
CPF VARCHAR(11) NOT NULL,
Telefone VARCHAR(14) NOT NULL,
Email VARCHAR(50) NOT NULL,
Senha VARCHAR(8) NOT NULL,
ConfirmacaoSenha VARCHAR(8) NOT NULL,
Situacao CHAR(1) NOT NULL
);

create table Colaborador (
Id int auto_increment Primary key,
Nome VARCHAR(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
Senha VARCHAR(8) NOT NULL,
Tipo VARCHAR(8) NOT NULL);