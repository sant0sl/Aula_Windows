create database bancoeletronico;


create table contabancaria(
cpf varchar(11) not null primary key,
nomecompleto varchar(100) not null,
email varchar(50),
senha varchar(50),
saldo decimal(10,2) not null
);


create table historicocontas(
id int not null primary key identity(1,1),
cpf varchar(11) not null,
mensagem varchar(255) not null,
quando datetime
);


select * from contabancaria;
select * from historicocontas;

truncate table contabancaria;
truncate table historicocontas;


create procedure sp_createConta
(
	@cpf varchar(11),
	@nomecompleto varchar(100),
	@email varchar(50),
	@senha varchar(50),
	@quando datetime
)
as begin
insert into contabancaria(cpf, nomecompleto, email, senha, saldo) values(@cpf, @nomecompleto, @email, @senha, 0);
insert into historicocontas values(@cpf, 'Conta foi aberta com sucesso!', @quando);
end




create procedure sp_updateConta
(
	@cpf varchar(11),
	@nomecompleto varchar(100),
	@email varchar(50),
	@senha varchar(50),
	@quando datetime
)
as begin
	update contabancaria set nomecompleto=@nomecompleto, email=@email, senha=@senha where cpf=@cpf
	insert into historicocontas values(@cpf, 'Informações da conta atual foram alterados!', @quando);
end




create procedure sp_deleteContaByCPF
(
	@cpf varchar(11),
	@senha varchar(50),
	@quando datetime
)
as begin
	delete from contabancaria where cpf=@cpf and senha=@senha
	insert into historicocontas values(@cpf, 'Conta foi fechada com sucesso!', @quando);
end




create procedure sp_readContaByCPF
(
	@cpf varchar(11)
)
as begin
	select * from contabancaria where cpf= @cpf
end




create procedure sp_readContaByCPFandPass
(
	@cpf varchar(11),
	@senha varchar(50)
)
as begin
	select * from contabancaria where cpf= @cpf and senha=@senha
end




create procedure sp_consultarSaldo
(
	@cpf varchar(11),
	@senha varchar(50)
)
as begin
	select saldo from contabancaria where cpf=@cpf and senha=@senha
end




create procedure sp_consultarHistorico
(
	@cpf varchar(11)
)
as begin
	select mensagem,quando from historicocontas where cpf=@cpf
end




create procedure sp_depositoBancario
(
	@cpf varchar(11),
	@valorDepositado decimal(10,2),
	@quando datetime
)
as begin
	update contabancaria set saldo=(saldo+@valorDepositado) where cpf=@cpf
	insert into historicocontas values(@cpf, 'Foi feito recentemente um depósito de R$'+convert(varchar, @valorDepositado)+' na sua conta!', @quando);
end




create procedure sp_saqueBancario
(
	@cpf varchar(11),
	@valorSacado decimal(10,2),
	@quando datetime
)
as begin
	if ((select saldo from contabancaria where cpf=@cpf) >= @valorSacado)
		begin
			update contabancaria set saldo=(saldo-@valorSacado) where cpf=@cpf;
			insert into historicocontas values(@cpf, 'Foi feito recentemente um saque de R$'+convert(varchar, @valorSacado)+' na sua conta!', @quando);
		end
end




create procedure sp_transferenciaBancaria
(
	@cpfEmissor varchar(11),
	@nomeEmissor varchar(50),
	@cpfRecebedor varchar(11),
	@nomeRecebedor varchar(50),
	@valorTransferencia decimal(10,2),
	@quando datetime
)
as begin
	if ((select saldo from contabancaria where cpf=@cpfEmissor) >= @valorTransferencia)
		begin
			update contabancaria set saldo=(saldo-@valorTransferencia) where cpf=@cpfEmissor;
			update contabancaria set saldo=(saldo+@valorTransferencia) where cpf=@cpfRecebedor;
			insert into historicocontas values(@cpfEmissor, 'Foi feito recentemente uma transferência de R$'+convert(varchar, @valorTransferencia)+' da sua conta para '+@nomeRecebedor+'!', @quando);
			insert into historicocontas values(@cpfRecebedor, 'Foi feito recentemente uma transferência de R$'+convert(varchar, @valorTransferencia)+' para sua conta de '+@nomeEmissor+'!', @quando);
		end
end