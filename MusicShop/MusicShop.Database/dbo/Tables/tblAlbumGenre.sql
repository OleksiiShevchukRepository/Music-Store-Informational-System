CREATE TABLE [dbo].[tblAlbumGenre] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [AlbumId] INT NOT NULL,
    [GenreID] INT NOT NULL,
    CONSTRAINT [PK_tblAlbumGenre_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblAlbumGenre_tblAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[tblAlbum] ([Id]),
    CONSTRAINT [FK_tblAlbumGerne_tblGerne] FOREIGN KEY ([GenreID]) REFERENCES [dbo].[tblGenre] ([Id])
);

