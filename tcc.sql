create database tcc;
use tcc;
create table manutecao(
id int auto_increment primary key,
 tipo varchar(400),
 Nome_oficina varchar(400),
 quilometragen varchar(400),
 Data_entrada varchar(400),
 Hora_entrada varchar(400),
 Data_saida varchar(400),
 Hora_saida varchar(400),
 Nome_item varchar(400),
 valor varchar(400),
 quantidade varchar(400));
 create table Motorista(
 CODIGO INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 NOME VARCHAR(100),
 CPF VARCHAR(11),
 DATA_NASCIMENTO VARCHAR(16),
 RG VARCHAR(25),
 ENDERECO VARCHAR(125),
 CIDADE VARCHAR(50),
 CEP VARCHAR(100),
 TELEFONE VARCHAR(65));
 