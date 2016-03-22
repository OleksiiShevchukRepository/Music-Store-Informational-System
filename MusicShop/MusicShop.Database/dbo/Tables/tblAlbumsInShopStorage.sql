CREATE TABLE [dbo].[tblAlbumsInShopStorage] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [AlbumID]          INT             NOT NULL,
    [MusicShopID]      INT             NOT NULL,
    [Amount]           INT             NOT NULL,
    [PriceBought]      INT             NOT NULL,
    [PriceRealisation] NUMERIC (19, 2) NOT NULL,
    CONSTRAINT [PK_tblAlbumsInShopStorage_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblAlbumsInShopStorage_tblAlbum] FOREIGN KEY ([AlbumID]) REFERENCES [dbo].[tblAlbum] ([Id]),
    CONSTRAINT [FK_tblAlbumsInShopStorage_tblMusicShop] FOREIGN KEY ([MusicShopID]) REFERENCES [dbo].[tblMusicShop] ([Id])
);

