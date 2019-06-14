create database upaforms;

create table crianca(
cpf varchar(11) not null primary key,
nomeCrianca varchar(100) not null,
nomeMae varchar(100) not null,
idade int not null
);

create table vacinas(
idVacina int not null primary key identity(1,1),
nomeVacina varchar(100) not null,
cpf varchar(11) not null,
quando datetime
);

select * from crianca
select * from vacinas

truncate table crianca
truncate table vacinas




create procedure sp_createCrianca
(
	@cpf varchar(11),
	@nomeCrianca varchar(100),
	@nomeMae varchar(100),
	@idade int
)
as begin
	insert into crianca(cpf, nomeCrianca, nomeMae, idade) values(@cpf, @nomeCrianca, @nomeMae, @idade)
end



create procedure sp_updateCrianca
(
	@cpf varchar(11),
	@nomeCrianca varchar(100),
	@nomeMae varchar(100),
	@idade int
)
as begin
	update crianca set nomeCrianca=@nomeCrianca, nomeMae=@nomeMae, idade=@idade where cpf=@cpf
end



create procedure sp_readCrianca
as begin
	select * from crianca
end



create procedure sp_readCriancaByCPF
(
	@cpf varchar(11)
)
as begin
	select * from crianca where cpf=@cpf
end



create procedure sp_readCriancaByFiltro
(
	@filtro varchar(100)
)
as begin
	select * from crianca where nomeCrianca like '%' + @filtro + '%' or nomeMae like '%' + @filtro + '%'
end



create procedure sp_deleteCrianca
(
	@cpf varchar(11)
)
as begin
	delete from crianca where cpf=@cpf
end



create procedure sp_createVacina
(
	@nomeVacina varchar(100),
	@cpf varchar(11),
	@quando datetime
)
as begin
	insert into vacinas(nomeVacina, cpf, quando) values(@nomeVacina, @cpf, @quando)
end



create procedure sp_updateVacina
(
	@idVacina int,
	@nomeVacina varchar(100),
	@cpf varchar(11),
	@quando datetime
)
as begin
	update vacinas set nomeVacina=@nomeVacina, quando=@quando where cpf=@cpf and idVacina=@idVacina
end



create procedure sp_deleteVacina
(
	@idVacina int,
	@cpf varchar(11)
)
as begin
	delete from vacinas where idVacina=@idVacina and cpf=@cpf
end



create procedure sp_readVacinasByCPF
(
	@cpf varchar(11)
)
as begin
	select idVacina, nomeVacina, quando from vacinas where cpf=@cpf
end



create procedure sp_readVacinasById
(
	@id varchar(11)
)
as begin
	select nomeVacina from vacinas where idVacina=@id
end

exec sp_readVacinasById 1