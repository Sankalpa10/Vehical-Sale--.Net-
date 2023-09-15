CREATE TABLE [dbo].[Maintance] (
    [Car id]      CHAR (10)    NOT NULL,
    [Garage name] VARCHAR (50) NOT NULL,
    [Problem]     VARCHAR (50) NOT NULL,
    [Finish date] DATE         NOT NULL,
    CONSTRAINT [PK_Mentance] PRIMARY KEY CLUSTERED ([Car id] ASC)
);

