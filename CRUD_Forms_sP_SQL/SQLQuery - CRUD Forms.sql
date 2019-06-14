create database crudform;


create table pessoa(
uid_pessoa int not null primary key identity(1,1),
nome varchar(50) not null,
idade int not null,
email varchar(50)
);


select * from pessoa;
truncate table pessoa;



create procedure sp_createPessoa
(
	@nome varchar(50),
	@idade int,
	@email varchar(50)
)
as
begin
	insert into pessoa(nome, idade, email) values(@nome, @idade, @email)
end



create procedure sp_readPessoa
as
begin
select * from pessoa
end



create procedure sp_readPessoaByUID
(
	@uid_pessoa int
)
as
begin
select * from pessoa where uid_pessoa= @uid_pessoa
end



create procedure sp_readPessoaByFilter
(
	@filtro varchar(50)
)
as
begin
select * from pessoa where nome like '%' + @filtro + '%' or email like '%' + @filtro + '%'
end



create procedure sp_updatePessoa
(
	@uid_pessoa int,
	@nome varchar(50),
	@idade int,
	@email varchar(50)
)
as
begin
	update pessoa set nome= @nome, idade= @idade, email= @email where uid_pessoa= @uid_pessoa
end



create procedure sp_deletePessoa
(
	@uid_pessoa int
)
as
begin
delete from pessoa where uid_pessoa= @uid_pessoa
end

exec sp_deletePessoa 1



create procedure sp_countPessoa
as
begin
select count(uid_pessoa) from pessoa
end

exec sp_countPessoa