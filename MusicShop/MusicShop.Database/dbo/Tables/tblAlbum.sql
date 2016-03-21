CREATE TABLE [dbo].[tblAlbum] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [ArtistId]          INT           NULL,
    [Name]              NVARCHAR (50) NOT NULL,
    [Year]              INT           NULL,
    [RatingAllMusicCom] INT           NULL,
    [LiquidRate]        FLOAT (53)    NULL,
    CONSTRAINT [PK_tblAlbum_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblAlbum_tblArtist] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[tblArtist] ([Id])
);

