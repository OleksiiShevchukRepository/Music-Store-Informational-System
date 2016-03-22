CREATE TABLE [dbo].[tblArtist] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblArtist_ID] PRIMARY KEY CLUSTERED ([Id] ASC)
);

