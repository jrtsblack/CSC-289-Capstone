CREATE TABLE [dbo].[Customer] (
    [Customer_ID]          INT            IDENTITY (1, 1) NOT NULL,
    [First]                NVARCHAR (30)  NULL,
    [Last]                 NVARCHAR (30)  NULL,
    [Address]              NVARCHAR (40)  NULL,
    [Email]                NVARCHAR (320) NULL,
    [Phone#]             NVARCHAR (24)  NULL,
    PRIMARY KEY CLUSTERED ([Customer_ID] ASC),
    CONSTRAINT [FK_Customer_Community] FOREIGN KEY ([Community_Name]) REFERENCES [dbo].[Community] ([Community_Name]),
    CONSTRAINT [FK_Customer_UserAccounts] FOREIGN KEY ([Email]) REFERENCES [dbo].[UserAccounts] ([Email])
);

