CREATE TABLE [dbo].[ContractorCompany] (
    [Company_ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Company_Name]    NVARCHAR (40)  NULL,
    [Company_Address] NVARCHAR (40)  NULL,
    [Phone#]          NVARCHAR (24)  NULL,
    [Email]           NVARCHAR (320) NULL,
    PRIMARY KEY CLUSTERED ([Company_ID] ASC)
);

