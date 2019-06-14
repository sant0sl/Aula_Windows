create database Prova2

create table Usuario(
id int primary key not null identity(1,1),
nome varchar(50) not null,
login_usuario varchar(50) not null,
senha varchar(50) not null
);
select * from Usuario
select * from UsuarioLog
truncate table Usuario
truncate table UsuarioLog
insert into Usuario values('Leonardo', 'leonardo', 'leo')
insert into Usuario values('Marcao', 'marcao', 'mar')
insert into Usuario values('Rodrigo', 'rodrigo', 'rod')
insert into Usuario values('Micael', 'micael', 'mic')

create table UsuarioLog(
id int primary key not null identity(1,1),
idUsuario int not null,
quando datetime
);


create procedure verificarLogin(
	@login_usuario varchar(50),
	@senha varchar(50)
)
as begin
	select * from Usuario where login_usuario=@login_usuario and senha=@senha
end

create procedure pegarUsuarioID(
	@idUsuario int
)
as begin
	select * from Usuario where id=@idUsuario
end

create procedure registrarLog(
	@idUsuario int,
	@quando datetime
)
as begin
	insert into UsuarioLog values(@idUsuario, @quando)
end

create procedure verificarLogUsuario(
	@idUsuario int
)
as begin
	select * from UsuarioLog where idUsuario=@idUsuario
end
exec verificarLogUsuario 1