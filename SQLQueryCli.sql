CREATE DATABASE db_DPSP;

USE db_DPSP;

CREATE TABLE tb_cliente (
	ID_CLI int IDENTITY(1,1) PRIMARY KEY,
	Nome_CLI Varchar(80) NOT NULL,
	Endereco_CLI Varchar(80) NOT NULL,
	Numero_CLI Varchar(50) NOT NULL,
	Bairro_CLI Varchar(50) NOT NULL,
	Cidade_CLI Varchar(50) NOT NULL,
	UF_Cli Varchar(2) NOT NULL,
	CEP_Cli Varchar(50) NOT NULL);

CREATE TABLE tb_telefone (
	ID_TEL	int IDENTITY(1,1) PRIMARY KEY,
	ID_CLI int NOT NULL,
	Telefone_CLI Varchar(50) NOT NULL);
