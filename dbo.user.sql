CREATE TABLE [dbo].[Iuser] (
    [Uid]    INT           IDENTITY (1, 1) NOT NULL,
    [Uemail] NVARCHAR (50) NOT NULL,
    [Upass]  VARCHAR (50)  NOT NULL,
    [Urole]  SMALLINT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Uid] ASC)
);
