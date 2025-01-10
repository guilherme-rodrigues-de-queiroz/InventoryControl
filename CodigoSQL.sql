CREATE DATABASE InventoryControl;

USE InventoryControl;

 CREATE TABLE Produto(
	IdProduto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(255) NOT NULL,
    QtdEstoque INT NOT NULL,
    Corredor VARCHAR(255),
    Prateleira VARCHAR(255),
    Estante VARCHAR(255),
    Posicao VARCHAR(255),
    DataAlteracao DATETIME NOT NULL
); 

 CREATE TABLE EntradaProduto(
	IdEntradaProduto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(255) NOT NULL,
    Quantidade INT NOT NULL,
    IdProduto INT NOT NULL,
    DataAlteracao DATETIME NOT NULL,
    FOREIGN KEY (IdProduto) REFERENCES Produto(IdProduto)
); 

 CREATE TABLE SaidaProduto(
	IdSaidaProduto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Nome VARCHAR(255) NOT NULL,
    Quantidade INT NOT NULL,
    IdProduto INT NOT NULL,
    DataAlteracao DATETIME NOT NULL,
    FOREIGN KEY (IdProduto) REFERENCES Produto(IdProduto)
); 

-- Trigger para subtrair a Quantidade na tabela Produto sempre que uma nova saida for adicionada
DELIMITER $$

CREATE TRIGGER AtualizarEstoqueS
AFTER INSERT ON SaidaProduto
FOR EACH ROW
BEGIN
    -- Verifica se a subtração resultará em estoque negativo
    IF (SELECT QtdEstoque FROM Produto WHERE IdProduto = NEW.IdProduto) < NEW.Quantidade THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Operação inválida: o estoque não pode ser negativo.';
    ELSE
        -- Atualiza o QtdEstoque do Produto
        UPDATE Produto
        SET QtdEstoque = QtdEstoque - NEW.Quantidade
        WHERE IdProduto = NEW.IdProduto;
    END IF;
END $$

DELIMITER ;
 
-- Trigger para somar a Quantidade na tabela Produto sempre que uma nova entrada for adicionada
DELIMITER $$

CREATE TRIGGER AtualizarEstoque
AFTER INSERT ON EntradaProduto
FOR EACH ROW
BEGIN
    -- Atualiza o QtdEstoque do Produto com a quantidade da EntradaProduto
    UPDATE Produto
    SET QtdEstoque = QtdEstoque + NEW.Quantidade
    WHERE IdProduto = NEW.IdProduto;
END $$

DELIMITER ; 