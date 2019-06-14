create database loginforms;

create table pessoa(
cpf varchar(11) not null primary key,
nome varchar(20) not null,
sobrenome varchar(150) not null,
email varchar(50),
idade int not null,
sexo bit not null,
senha varchar(50) not null
);

select * from pessoa;

truncate table pessoa;
drop table pessoa;