CREATE TABLE [dbo].[tblDistributorAlbums] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [DistributorId] INT             NOT NULL,
    [AlbumId]       INT             NOT NULL,
    [Price]         DECIMAL (19, 4) NOT NULL,
    CONSTRAINT [PK_tblDistributorAlbums_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblDistributorAlbums_tblAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[tblAlbum] ([Id]),
    CONSTRAINT [FK_tblDistributorAlbums_tblDistributor] FOREIGN KEY ([DistributorId]) REFERENCES [dbo].[tblDistributor] ([Id])
);

