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
<<<<<<< HEAD
  create table Carro(
=======
 
 create table Carro(
>>>>>>> origin/master
 CODIGO INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 RENAVAM varchar(400),
 MARCA varchar(400),
 MODELO varchar(400),
 PLACA varchar(400),
 COMBUSTIVEL varchar(400),
 COR varchar(400),
<<<<<<< HEAD
 QUILOMETRAGEM varchar(400))
 
=======
 QUILOMETRAGEM varchar(400));
 
 create table abastecimento(
 id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
palca varchar(10),
dia varchar(20),
motorista varchar(100),
combustivel varchar(60),
valor varchar(52),
litor varchar(60));
>>>>>>> origin/master
