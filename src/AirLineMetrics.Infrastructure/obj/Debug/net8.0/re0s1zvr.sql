IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [COUNTRIES] (
    [COUNTRY_ID] int NOT NULL IDENTITY,
    [COUNTRY_NAME] nvarchar(40) NOT NULL,
    CONSTRAINT [PK_COUNTRIES] PRIMARY KEY ([COUNTRY_ID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251219140157_InitialCreate', N'8.0.0');
GO

COMMIT;
GO

