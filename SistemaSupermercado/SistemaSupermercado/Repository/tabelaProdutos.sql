/*CREATE DATABASE supermercadoDB;

USE supermercadoDB;

CREATE TABLE Produtos (
	id INT PRIMARY KEY AUTO_INCREMENT,
    codigo VARCHAR(6),
    nome VARCHAR(255),
    categoria VARCHAR(50),
    quantidade INT(5),
    preco DECIMAL(9, 2),
    data_cadastro date
);

select * from Produtos