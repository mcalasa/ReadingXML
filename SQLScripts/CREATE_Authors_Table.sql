USE [ReadingXML]
GO

/****** Object:  Table [dbo].[Authors]    Script Date: 11/27/2016 16:05:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Authors](
	[au_id] [nvarchar](50) NULL,
	[au_lname] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[state] [nvarchar](2) NULL,
	[zip] [nvarchar](10) NULL,
	[contract] [bit] NULL
) ON [PRIMARY]

GO


