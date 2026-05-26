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

select * from Produtos;

INSERT INTO Produtos VALUES (4, "000004", "Feijão Carioca", "Alimentos", 100, 8.90, "2026-05-24");
INSERT INTO Produtos VALUES (5, "000005", "Macarrão Espaguete", "Alimentos", 150, 4.50, "2026-05-24");
INSERT INTO Produtos VALUES (6, "000006", "Óleo de Soja", "Alimentos", 80, 7.20, "2026-05-24");
INSERT INTO Produtos VALUES (7, "000007", "Açúcar Refinado", "Alimentos", 200, 5.30, "2026-05-24");
INSERT INTO Produtos VALUES (8, "000008", "Café Torrado", "Alimentos", 90, 18.90, "2026-05-24");
INSERT INTO Produtos VALUES (9, "000009", "Leite Integral", "Bebidas", 120, 5.80, "2026-05-24");
INSERT INTO Produtos VALUES (10, "000010", "Suco de Laranja", "Bebidas", 60, 12.50, "2026-05-24");
INSERT INTO Produtos VALUES (11, "000011", "Refrigerante Cola", "Bebidas", 180, 8.50, "2026-05-24");
INSERT INTO Produtos VALUES (12, "000012", "Água Mineral", "Bebidas", 300, 2.50, "2026-05-24");
INSERT INTO Produtos VALUES (13, "000013", "Detergente Líquido", "Limpeza", 150, 2.90, "2026-05-24");
INSERT INTO Produtos VALUES (14, "000014", "Sabão em Pó", "Limpeza", 70, 14.90, "2026-05-24");
INSERT INTO Produtos VALUES (15, "000015", "Amaciante", "Limpeza", 85, 11.20, "2026-05-24");
INSERT INTO Produtos VALUES (16, "000016", "Água Sanitária", "Limpeza", 110, 4.30, "2026-05-24");
INSERT INTO Produtos VALUES (17, "000017", "Desinfetante", "Limpeza", 90, 6.50, "2026-05-24");
INSERT INTO Produtos VALUES (18, "000018", "Papel Higiênico", "Higiene", 130, 16.50, "2026-05-24");
INSERT INTO Produtos VALUES (19, "000019", "Sabonete", "Higiene", 250, 2.20, "2026-05-24");
INSERT INTO Produtos VALUES (20, "000020", "Creme Dental", "Higiene", 140, 4.80, "2026-05-24");
INSERT INTO Produtos VALUES (21, "000021", "Shampoo", "Higiene", 60, 15.90, "2026-05-24");
INSERT INTO Produtos VALUES (22, "000022", "Biscoito Recheado", "Alimentos", 200, 3.50, "2026-05-24");
INSERT INTO Produtos VALUES (23, "000023", "Pão de Forma", "Alimentos", 55, 9.50, "2026-05-24");

CREATE TABLE Compras (
	id INT PRIMARY KEY AUTO_INCREMENT,
    codigo_compra varchar(6),
    subtotal DECIMAL(12, 2),
    desconto DECIMAL(12, 2),
    total DECIMAL(12, 2),
    data_compra date
);

CREATE TABLE Produtos_Compras(
	id INT PRIMARY KEY AUTO_INCREMENT,
    codigo_compra varchar(6),
    codigo_produto VARCHAR(6),
    quantidade INT(5),
    preco DECIMAL(9, 2)
)

*/


