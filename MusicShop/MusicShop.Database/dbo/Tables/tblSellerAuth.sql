CREATE TABLE [dbo].[tblSellerAuth] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Password] NVARCHAR (16) NOT NULL,
    CONSTRAINT [PK_tblSellerAuth_ID] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblSellerAuth_tblSeller] FOREIGN KEY ([Id]) REFERENCES [dbo].[tblSeller] ([Id])
);

