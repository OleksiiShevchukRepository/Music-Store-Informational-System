CREATE TABLE [dbo].[tblMusicShop] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [ProfitTotal]  DECIMAL (19, 4) NOT NULL,
    [ExpenceTotal] DECIMAL (19, 4) NOT NULL,
    CONSTRAINT [PK_tblMusicShop_ID] PRIMARY KEY CLUSTERED ([Id] ASC)
);

