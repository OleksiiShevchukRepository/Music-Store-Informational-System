CREATE TABLE [dbo].[tblCheck] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [SellerId]      INT             NOT NULL,
    [DateStatement] DATETIME        NOT NULL,
    [SumOverall]    DECIMAL (19, 2) NOT NULL,
    CONSTRAINT [PK_tblCheck_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblCheck_tblSeller] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[tblSeller] ([Id])
);

