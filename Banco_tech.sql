CREATE DATABASE Banco_tech;
USE Banco_Tech;



CREATE TABLE Login_Func(
Matricula varchar(10) NOT NULL PRIMARY KEY, -- matricula para o login
senha varchar(20) NOT NULL, -- senha login usuario
tipo_usuario varchar(15) NOT NULL, -- Tipo usuaario (ADM ou Comum)
);



CREATE TABLE Funcionario(
id_Func int NOT NULL identity(1,1) Primary key, -- PK DA TABELA FUNCIONARIO
Matricula VARCHAR(10) NOT NULL, --PK DA TABELA Login
Nome TEXT NOT NULL, -- NOME DO FUNCIONARIO
Data_Nasc DATE, -- DATA DE NASCIMENTO DO FUNCIONARIO
Email VARCHAR(50) NOT NULL, -- EMAIL DO FUNCIONARIO
Telefone VARCHAR(11), -- TELEFONE FUNCIONARIO
Data_Admissao VARCHAR(11), -- DATA DE CONTRATO
Salario_base FLOAT(15), -- Salario bruto do funcionario
Turno VARCHAR(20), -- Turno do funcionario 
);

ALTER TABLE Funcionario
ADD CONSTRAINT FK_Matricula FOREIGN KEY(Matricula) REFERENCES Login_Func(Matricula);


CREATE TABLE Pagamentos(
id_Pag INT IDENTITY(1,1) PRIMARY KEY, -- PK pagamentos
INSS_Func FLOAT(15), -- INSS Pagamentos
IRRF_Func FLOAT(15), -- IRRF do Pagamento
FGTS_Func FLOAT(15), --FGTS Pagamentos
VT_Func FLOAT(15), -- Vale Transporte 
VR_Func FLOAT(15), -- Vale refeição
valor_ferias FLOAT(15), -- valor das ferias
Data_ferias VARCHAR(11), -- data das ferias
Salario_Liq FLOAT(15), -- Salario liquido 
Matricula VARCHAR (10) not null, -- pk Login Funcionario
foreign key (Matricula) references Login_func(Matricula) on update cascade -- Cria uma FK de Matricula
);


INSERT INTO Login_Func
VALUES('N123456', 'ADM123456', 'ADM')
select * from Login_Func
Insert into Login_Func VALUES ('n456789','12345678', 'Comum')

INSERT INTO Funcionario 
VALUES('n123456', 'Leonardo Amorim de Souza', '17/11/2000', 'Leo.amorim@6tech.com', '11939346364','01/01/2022','3.000','Integral');
INSERT INTO Funcionario 
VALUES('n456789', 'Isabelly Zanão', '28/03/2002', 'Isa.zanao@6tech.com', '1194756373','01/04/2022','2.000','Integral');

SELECT * FROM Funcionario
SELECT * FROM Login_Func