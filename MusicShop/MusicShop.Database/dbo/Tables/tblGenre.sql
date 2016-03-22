CREATE TABLE [dbo].[tblGenre] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblGenre_ID] PRIMARY KEY CLUSTERED ([Id] ASC)
);

