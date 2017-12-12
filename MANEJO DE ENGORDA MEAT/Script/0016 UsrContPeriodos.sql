USE [GANADERA]
GO
/****** Object:  Table [dbo].[UsrContPeriodos]    Script Date: 09/28/2009 16:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsrContPeriodos](
	[Ejercicio] [smallint] NOT NULL,
	[PolizaCierre] [varchar](10) NULL,
	[PolizaTraspaso] [varchar](10) NULL,
	[FechaCierre] [datetime] NULL,
	[Estatus] [smallint] NOT NULL CONSTRAINT [DF_UsrContPeriodos_Estatus]  DEFAULT ((0)),
 CONSTRAINT [PK_UsrContPeriodos] PRIMARY KEY CLUSTERED 
(
	[Ejercicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF