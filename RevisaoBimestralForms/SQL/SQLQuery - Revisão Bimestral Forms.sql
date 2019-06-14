create database revisaobimestralforms;

go

create table tipoServico(
uid_tipoServico int not null primary key identity(1,1),
nomeServico varchar(50) not null
);
go
insert into tipoServico(nomeServico) values('Novo');
go
insert into tipoServico(nomeServico) values('Reparo');
go
insert into tipoServico(nomeServico) values('Diferenciado');
go
insert into tipoServico(nomeServico) values('Finalizado');

go

create table usuario(
cpf varchar(11) not null primary key,
nomeCompleto varchar(100) not null,
email varchar(50),
senha varchar(50)
);

go

create table pcs(
uid_pc int not null primary key identity(1,1),
processador varchar(255) not null,
placaMae varchar(255) not null,
fonte varchar(255) not null,
coolerProcessador varchar(255) not null,
memoriaRam varchar(255) not null,
hd varchar(255),
ssd varchar(255),
placaDeVideo varchar(255),
gabinete varchar(255) not null,
cpfCliente varchar(11) not null,
fk_tipoServico int foreign key references tipoServico(uid_tipoServico) not null,
observacoes varchar(255),
statuspc bit not null
);

go

create procedure sp_createUsuario(
	@cpf varchar(11),
	@nomeCompleto varchar(100),
	@email varchar(50),
	@senha varchar(50)
)
as begin
	insert into usuario(cpf, nomeCompleto, email, senha) values(@cpf,@nomeCompleto,@email,@senha)
end

go

create procedure sp_updateUsuario(
	@cpf varchar(11),
	@nomeCompleto varchar(100),
	@email varchar(50),
	@senha varchar(50)
)
as begin
	update usuario set nomeCompleto=@nomeCompleto, email=@email, senha=@senha where cpf=@cpf
end

go

create procedure sp_readUsuario
as begin
	select cpf, nomeCompleto from usuario
end

go

create procedure sp_readUsuarioByCPF(
	@cpf varchar(11)
)
as begin
	select * from usuario where cpf=@cpf
end

go

create procedure sp_readUsuarioByCPFandPass(
	@cpf varchar(11),
	@senha varchar(50)
)
as begin
	select * from usuario where cpf=@cpf and senha=@senha
end

go

create procedure sp_readUsuarioByFilter(
	@filtro varchar(255)
)
as begin
	select cpf, nomeCompleto from usuario where cpf like '%' + @filtro + '%' or nomeCompleto like '%' + @filtro + '%'
end

go

create procedure sp_deleteUsuario(
	@cpf varchar(11)
)
as begin
	delete from usuario where cpf=@cpf
end

go

create procedure sp_createPC(
	@processador varchar(255),
	@placaMae varchar(255),
	@fonte varchar(255),
	@coolerProcessador varchar(255),
	@memoriaRam varchar(255),
	@hd varchar(255),
	@ssd varchar(255),
	@placaDeVideo varchar(255),
	@gabinete varchar(255),
	@cpfCliente varchar(11),
	@fk_tipoServico int,
	@observacoes varchar(255),
	@statuspc bit
)
as begin
	insert into pcs(processador,placaMae,fonte,coolerProcessador,memoriaRam,hd,ssd,placaDeVideo,gabinete,cpfCliente,fk_tipoServico,observacoes,statuspc) values(@processador,@placaMae,@fonte,@coolerProcessador,@memoriaRam,@hd,@ssd,@placaDeVideo,@gabinete,@cpfCliente,@fk_tipoServico,@observacoes,@statuspc);
end

go

create procedure sp_updatePC(
	@uid_pc int,
	@processador varchar(255),
	@placaMae varchar(255),
	@fonte varchar(255),
	@coolerProcessador varchar(255),
	@memoriaRam varchar(255),
	@hd varchar(255),
	@ssd varchar(255),
	@placaDeVideo varchar(255),
	@gabinete varchar(255),
	@cpfCliente varchar(11),
	@fk_tipoServico int,
	@observacoes varchar(255),
	@statuspc bit
)
as begin
	update pcs set processador=@processador, placaMae=@placaMae, fonte=@fonte, coolerProcessador=@coolerProcessador, memoriaRam=@memoriaRam, hd=@hd, ssd=@ssd, placaDeVideo=@placaDeVideo, gabinete=@gabinete, cpfCliente=@cpfCliente, fk_tipoServico=@fk_tipoServico, observacoes=@observacoes, statuspc=@statuspc where uid_pc=@uid_pc
end

go

create procedure sp_readPC
as begin
	select p.uid_pc, p.cpfCliente, p.processador, tipo.nomeServico, p.observacoes from pcs as p 
	inner join tipoServico as tipo on p.fk_tipoServico = tipo.uid_tipoServico
end

go

create procedure sp_readPCByUID(
	@uid_pc int
)
as begin
	select * from pcs where uid_pc=@uid_pc
end

go

create procedure sp_readPCByCPFCliente(
	@cpfCliente varchar(11)
)
as begin
	select p.uid_pc, p.cpfCliente, p.processador, tipo.nomeServico, p.observacoes from pcs as p 
	inner join tipoServico as tipo on p.fk_tipoServico = tipo.uid_tipoServico
	where cpfCliente like '%' + @cpfCliente + '%'
end

go

create procedure sp_finalizarServico(
	@uid_pc int,
	@cpfCliente varchar(11)
)
as begin
	update pcs set fk_tipoServico=4, observacoes='-', statuspc=1 where uid_pc=@uid_pc and cpfCliente=@cpfCliente
end

go

create procedure sp_readComboServicos
as begin
	select * from tipoServico
end
exec sp_readComboServicos