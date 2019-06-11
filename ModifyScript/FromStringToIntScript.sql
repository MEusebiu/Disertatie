USE UniversityDb
GO

ALTER TABLE [dbo].[Books]
ALTER COLUMN Release int

ALTER TABLE [dbo].[Books]
ALTER COLUMN Rating decimal(10,2)

ALTER TABLE [dbo].[Books]
ALTER COLUMN Pages int
