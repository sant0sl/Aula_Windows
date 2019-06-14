create database facear_2019;

create table Professor(
Id_Professor int primary key not null identity(1,1),
Nome varchar(50) not null,
Idade int not null
);

truncate table Professor




create procedure sp_createProfessor(
	@nome varchar(50),
	@idade int
)
as begin
insert into Professor(Nome, Idade) values(@nome, @idade)
end
exec sp_createProfessor 'Rodrigo Jr', 35;
exec sp_createProfessor 'Marco Aurélio', 50;
exec sp_createProfessor 'Leonardo Sampaio', 20;
exec sp_createProfessor 'Rodrigo Marcondes', 40;




create procedure sp_updateProfessor(
	@id int,
	@nome varchar(50),
	@idade int
)
as begin
update Professor set Nome=@nome, Idade=@idade where Id_professor=@id
end




create procedure sp_buscaProfessor
as begin
select * from Professor
end
exec sp_buscaProfessor




create procedure sp_deleteProfessor(
	@id int
)
as begin
	delete from Professor where Id_professor=@id
end




create procedure sp_buscaProfessorByID(
	@id int
)
as begin
select * from Professor where Id_professor=@id
end




create procedure sp_buscaProfessorByName(
	@nome varchar(50)
)
as begin
select * from Professor where Nome like '%' + @nome + '%'
end




create procedure sp_buscaProfessorByFilter(
	@filtro varchar(50)
)
as begin
select * from Professor where Nome like '%' + @filtro + '%' or Idade like '%' + @filtro + '%'
end




create procedure sp_buscaQtdProfessores
as begin
select count(Id_Professor) as NumeroDeProfessores from Professor
end