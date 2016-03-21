CREATE TABLE [dbo].[tblCheck] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [SellerId]   INT             NOT NULL,
    [SumOverall] DECIMAL (19, 4) NULL,
    CONSTRAINT [PK_tblCheck_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblCheck_tblSeller] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[tblSeller] ([Id])
);

