CREATE TABLE [dbo].[tblSoldItem] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [AlbumId]  INT             NOT NULL,
    [CheckId]  INT             NOT NULL,
    [SellDate] DATETIME        NOT NULL,
    [Amount]   INT             NOT NULL,
    [SumItems] DECIMAL (19, 4) NULL,
    CONSTRAINT [PK_tblSoldItem_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblSoldItem_tblAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [dbo].[tblAlbum] ([Id]),
    CONSTRAINT [FK_tblSoldItem_tblCheck] FOREIGN KEY ([CheckId]) REFERENCES [dbo].[tblCheck] ([Id])
);

