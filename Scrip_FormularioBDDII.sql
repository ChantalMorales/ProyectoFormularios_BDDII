USE [For_102A]
GO
/****** Object:  Table [dbo].[Contribuyente]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contribuyente](
	[id_contribuyente] [int] IDENTITY(1,1) NOT NULL,
	[RUC] [varchar](13) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Saldo_Tributario] [numeric](6, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_contribuyente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Form_106]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Form_106](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[cod_documento] [varchar](4) NOT NULL,
	[mes] [varchar](10) NULL,
	[año] [varchar](4) NULL,
	[total_pagado] [numeric](6, 2) NULL,
	[descripcion] [varchar](100) NULL,
	[id_contribuyente_FK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Datos_Almacenados]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Datos_Almacenados] as 
select Nombre, RUC, Saldo_Tributario,cod_documento,mes,año,total_pagado,descripcion From Contribuyente, Form_106 
GO
/****** Object:  View [dbo].[Datos_AlmacenadosF]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Datos_AlmacenadosF] as 
select Nombre, RUC, Saldo_Tributario,cod_documento,mes,año,total_pagado,descripcion From Contribuyente C, Form_106 F where C.id_contribuyente=F.id_contribuyente_FK
GO
/****** Object:  View [dbo].[Datos_Almacenados_User]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Datos_Almacenados_User] as 
select Nombre, RUC, Saldo_Tributario,cod_documento,mes,año,total_pagado,descripcion From Contribuyente C, Form_106 F where C.id_contribuyente=F.id_contribuyente_FK
GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoria](
	[cod_aud] [int] IDENTITY(1,1) NOT NULL,
	[nom_cont] [varchar](30) NOT NULL,
	[ruc] [varchar](13) NOT NULL,
	[saldo_tributario] [numeric](6, 2) NOT NULL,
	[accion] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_aud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[id_Gastos] [int] IDENTITY(1,1) NOT NULL,
	[valor_gastos] [numeric](6, 2) NULL,
	[id_contribuyente_FK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Gastos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos]    Script Date: 13/2/2020 14:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos](
	[id_Ingresos] [int] IDENTITY(1,1) NOT NULL,
	[valor_ingresos] [numeric](6, 2) NULL,
	[id_contribuyente_FK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Ingresos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Form_106]  WITH CHECK ADD FOREIGN KEY([id_contribuyente_FK])
REFERENCES [dbo].[Contribuyente] ([id_contribuyente])
GO
ALTER TABLE [dbo].[Gastos]  WITH CHECK ADD FOREIGN KEY([id_contribuyente_FK])
REFERENCES [dbo].[Contribuyente] ([id_contribuyente])
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD FOREIGN KEY([id_contribuyente_FK])
REFERENCES [dbo].[Contribuyente] ([id_contribuyente])
GO
