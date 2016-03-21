CREATE TABLE [dbo].[tblDistributor] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (50) NOT NULL,
    [Rating] INT           NULL,
    CONSTRAINT [PK_tblDistributor_ID] PRIMARY KEY CLUSTERED ([Id] ASC)
);

