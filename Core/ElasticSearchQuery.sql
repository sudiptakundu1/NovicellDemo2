--CREATE DATABASE SCOPED CREDENTIAL productsCred -- credential name
--WITH IDENTITY = 'oursqlserveradmin',                    -- login or contained user name
--SECRET = 'OurPassword@123';                    -- login or contained user password
--GO

--CREATE DATABASE SCOPED CREDENTIAL productsCred -- credential name
--WITH IDENTITY = 'oursqlserveradmin',                    -- login or contained user name
--SECRET = 'OurPassword@123';                    -- login or contained user password
--GO

--CREATE EXTERNAL DATA SOURCE ProductType
--WITH
--(
--    TYPE=RDBMS,                             -- data source type
--    LOCATION='oursqlserver.database.windows.net', -- Azure SQL Database server name
--    DATABASE_NAME='NovicellCustomerDB001',           -- database name
--    CREDENTIAL=productTypeCred                  -- credential used to connect to server / database  
--);
--GO

--CREATE EXTERNAL DATA SOURCE Product
--WITH
--(
--    TYPE=RDBMS,                             -- data source type
--    LOCATION='oursqlserver.database.windows.net', -- Azure SQL Database server name
--    DATABASE_NAME='NovicellCustomerDB002',           -- database name
--    CREDENTIAL=productsCred                  -- credential used to connect to server / database  
--);
--GO

--CREATE EXTERNAL TABLE [dbo].[productTypes]
--(
--    [ProductTypeId] INT      NOT NULL,
--    [ProductType]   VARCHAR (100) NOT NULL,
--    [Created]       DATETIME      NOT NULL,
--    [Modified]      DATETIME       NOT NULL
--)
--WITH (DATA_SOURCE = [ProductType],  -- data source 
--      SCHEMA_NAME = 'dbo',           -- external table schema
--      OBJECT_NAME = 'ProductTypes'       -- name of table in external database
--     );
--GO

--CREATE EXTERNAL TABLE [dbo].[products]
--(
--   [ProductId]     INT         NOT NULL,
--    [ProductTypeId] INT           NOT NULL,
--    [Product]       VARCHAR (100) NOT NULL,
--    [Created]       DATETIME      NOT NULL,
--    [Modified]      DATETIME      NOT NULL,
--)
--WITH (DATA_SOURCE = [Product],  -- data source 
--      SCHEMA_NAME = 'dbo',           -- external table schema
--      OBJECT_NAME = 'Products'       -- name of table in external database
--     );
--GO

select p.ProductId, p.Product, pt.ProductTypeId, pt.ProductType, p.Created, p.Modified from products p
inner join productTypes pt on p.ProductTypeId = pt.ProductTypeId
order by p.Modified