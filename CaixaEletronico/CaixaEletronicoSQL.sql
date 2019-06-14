create database caixaeletronicovs;

create table contas(
cpf varchar(11) not null primary key,
numConta int,
numAgencia int,
nome varchar(20),
sobrenome varchar(150),
email varchar(100),
saldo decimal
);

create table historicos(
id_historico int not null primary key identity(1,1),
cpf varchar(11),
texto varchar(255)
);

truncate table contas;
truncate table historicos;

select * from contas;
select * from historicos;