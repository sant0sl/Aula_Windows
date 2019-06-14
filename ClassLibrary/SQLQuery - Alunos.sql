create database escola

create table aluno(
id int not null primary key identity(1,1),
nome varchar(50),
turma varchar(20)
);

create table notas(
id int not null primary key identity(1,1),
idAluno int not null,
idMateria int not null,
nota decimal(3,1) not null,
quando datetime not null
);




create procedure sp_createAluno(
	@nome varchar(50),
	@turma varchar(20)
)
as begin
	insert into aluno(nome, turma) values(@nome, @turma)
end




create procedure sp_updateAluno(
	@id int,
	@nome varchar(50),
	@turma varchar(20)
)
as begin
	update aluno set nome=@nome, turma=@turma where id=@id
end




create procedure sp_readAlunoByID(
	@id int
)
as begin
	select * from aluno where id=@id
end




create procedure sp_readAlunos
as begin
	select * from aluno
end




create procedure sp_deleteAluno(
	@id int
)
as begin
	delete from aluno where id=@id
end




create procedure sp_createNota(
	@idAluno int,
	@idMateria int,
	@nota decimal(3,1),
	@quando datetime
)
as begin
	insert into notas(idAluno, idMateria, nota, quando) values(@idAluno, @idMateria, @nota, @quando)
end




create procedure sp_updateNota(
	@id int,
	@nota decimal(3,1),
	@quando datetime
)
as begin
	update notas set nota=@nota, quando=@quando where id=@id
end




create procedure sp_readNotaByID(
	@id int
)
as begin
	select * from notas where id=@id
end




create procedure sp_readNotasByIDAluno(
	@idAluno int
)
as begin
	select * from notas where idAluno=@idAluno
end




create procedure sp_deleteNota(
	@id int
)
as begin
	delete from notas where id=@id
end