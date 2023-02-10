CREATE TABLE [dbo].[Item] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Iname]        NVARCHAR (50) NOT NULL,
    [Idescription] NVARCHAR (50) NULL,
    [Iprice]       INT           NOT NULL,
    [IaddDate]     DATE      NOT NULL,
    [IexpDate]     DATE          NULL,
    [Iavailable]   NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


