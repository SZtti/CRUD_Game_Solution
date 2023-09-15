CREATE TABLE Personagem
(
	[IdPersonagem] INT NOT NULL PRIMARY KEY identity, 
    [Data_Nasc] DATETIME NULL, 
    [Nivel] INT NOT NULL, 
    [Nome_Personagem] VARCHAR(100) NOT NULL, 
    [Sexo] VARCHAR(50) NOT NULL, 
    [AparenciaID] INT NOT NULL, 
    [AtributoID] INT NOT NULL, 
    [RacaID] INT NOT NULL, 
    [SubClasseID] INT NOT NULL, 
	[ClasseID] INT NOT NULL,
    CONSTRAINT [FK_Personagem_Raca] FOREIGN KEY (RacaID) REFERENCES Raca(IdRaca),
	CONSTRAINT [FK_Personagem_SubClasse] FOREIGN KEY (SubClasseID) REFERENCES SubClasse(IdSubclasse),
	CONSTRAINT [FK_Personagem_Aparencia] FOREIGN KEY (AparenciaID) REFERENCES Aparencia(IdAparencia),
	CONSTRAINT [FK_Personagem_Atributos] FOREIGN KEY (AtributoID) REFERENCES Atributo(IdAtributo),
	CONSTRAINT [FK_Personagem_Classe] FOREIGN KEY (ClasseID) REFERENCES Classe(IdClasse)
)

CREATE TABLE Personagem_Habilidade
(
	[PersonagemID] INT NOT NULL, 
    [HabilidadeID] INT NOT NULL, 
    CONSTRAINT [FK_Personagem_Habilidade_Personagem] FOREIGN KEY (PersonagemID) REFERENCES Personagem(IdPersonagem), 
    CONSTRAINT [FK_Personagem_Habilidade_Habilidade] FOREIGN KEY (HabilidadeID) REFERENCES Habilidade(IdHabilidade), 
    CONSTRAINT [PK_Personagem_Habilidade] PRIMARY KEY ([PersonagemID],[HabilidadeID])

)
