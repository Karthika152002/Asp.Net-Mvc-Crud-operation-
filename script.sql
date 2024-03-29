USE [TaskDB]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 01-02-2024 22:22:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Address] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_Employee]    Script Date: 01-02-2024 22:22:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Employee]
@Id int=0,
@Name varchar(50)='',
@Age varchar(50)='',
@Address varchar(50)='',
@Gender varchar(50)='',
@flag int =0
AS
BEGIN
	if(@flag=1)
	BEGIN
	insert into Employee(Name,Age,Address,Gender)Values(@Name,@Age,@Address,@Gender)
	END
END
GO
