CREATE TABLE [dbo].[Users] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (56) NOT NULL,
    [DisplayName] VARCHAR (100) NULL,
    [Country]     VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);

