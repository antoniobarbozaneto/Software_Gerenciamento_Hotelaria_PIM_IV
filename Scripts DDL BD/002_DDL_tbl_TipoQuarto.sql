--BD Postegrsql
CREATE TABLE tbl_TipoQuarto(
Tipo VARCHAR(255) NOT NULL,
Qtd_Hospede NUMERIC NOT NULL,
Valor_Diaria NUMERIC NOT NULL,
Refeicao VARCHAR(255),
Autor INT NOT NULL
);

ALTER TABLE tbl_TipoQuarto ADD CONSTRAINT PK_TipoQuarto PRIMARY KEY (Tipo);
ALTER TABLE tbl_TipoQuarto ADD CONSTRAINT FK_Usuario FOREIGN KEY (Autor) REFERENCES tbl_Usuario(id_usuario);