CREATE TABLE [dbo].[tblSeller] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [ShopId]     INT           NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Surname]    NVARCHAR (50) NOT NULL,
    [PassportID] NVARCHAR (50) NOT NULL,
    [Birthday]   DATETIME      NULL,
    [Rating]     INT           NULL,
    CONSTRAINT [PK_tblSeller_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblSeller_tblMusicShop] FOREIGN KEY ([ShopId]) REFERENCES [dbo].[tblMusicShop] ([Id])
);

