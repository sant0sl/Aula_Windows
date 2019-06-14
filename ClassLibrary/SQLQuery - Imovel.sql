create database imobiliaria

create table imovel(
id int primary key not null identity(1,1),
cpf varchar(11) not null,
cidade varchar(50) not null,
bairro varchar(50) not null,
situacao bit not null,
tipo_locacao bit not null,
valor decimal(10,2) not null
);

truncate table imovel


create procedure sp_createImovel(
	@cpf varchar(11),
	@cidade varchar(50),
	@bairro varchar(50),
	@situacao bit,
	@tipo bit,
	@valor decimal(10,2)
)
as begin
insert into imovel(cpf, cidade, bairro, situacao, tipo_locacao, valor) values(@cpf, @cidade, @bairro, @situacao, @tipo, @valor)
end
exec sp_createImovel '08354761975', 'Lapa', 'Wilson Montenegro', 1, 0, 50000
exec sp_createImovel '11111111111', 'Curitiba', 'Boqueirão', 0, 1, 100000
exec sp_createImovel '22222222222', 'Porto Amazonas', 'Centro', 1, 1, 15060
exec sp_createImovel '33333333333', 'Campo do Tenente', 'Alto', 0, 0, 78560




create procedure sp_updateImovel(
	@id int,
	@cpf varchar(11),
	@cidade varchar(50),
	@bairro varchar(50),
	@situacao bit,
	@tipo bit,
	@valor decimal(10,2)
)
as begin
update imovel set cpf=@cpf, cidade=@cidade, bairro=@bairro, situacao=@situacao, tipo_locacao=@tipo, valor=@valor where id=@id
end




create procedure sp_buscaImoveis
as begin
select * from imovel
end




create procedure sp_deleteImovel(
	@id int
)
as begin
delete from imovel where id=@id
end




create procedure sp_buscarImovelPorID(
	@id varchar(3)
)
as begin
select * from imovel where id=@id
end




create procedure sp_buscarImovelPorFiltro(
	@filtro varchar(50)
)
as begin
select * from imovel where cidade like '%' + @filtro + '%' or bairro like '%' + @filtro + '%'
end




create procedure sp_buscarImovelPorSituacao(
	@situacao bit
)
as begin
select * from imovel where situacao=@situacao
end




create procedure sp_buscarImovelPorTipo(
	@tipo bit
)
as begin
select * from imovel where tipo_locacao=@tipo
end