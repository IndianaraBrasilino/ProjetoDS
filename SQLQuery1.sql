create database ProjetoDS;

use ProjetoDS;

drop table Pessoa;

create table Pessoa (

idPessoa int primary key identity(1,1),
cargo varchar(50) not null,
dtnascimento date,
sexo varchar(10) null,
ativo binary not null,
telfixo varchar(10) null,
telefoneCelular varchar(11) null,
email varchar(100) not null,
RG VARCHAR(30) NOT NULL,
CPF VARCHAR(11) NOT NULL,
nome varchar(250) not null,
userName varchar (50) not null,
senha varchar (50) not null);


select * from Pessoa;

