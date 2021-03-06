USE [GANADERA]
GO
/****** Object:  StoredProcedure [dbo].[FacturasGenerales]    Script Date: 09/24/2009 08:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[FacturasGenerales]
(
	@IdCliente as int,
	@FechaIni as datetime,
	@FechaFin as datetime,
	@Opcion as int
)
AS
--todos los clientes en un rango de fechas
If @Opcion = 1
	Select F.IdCliente,	   
		   Nombre,
		   NoFactura,
		   Total,
		   IdClienteCargo,
		   (Select Nombre From MFacCatClientes where IdCliente=F.IdClienteCargo) as NombreCargo,
		   FechaFactura,
           Case When F.Estatus = 'P' then 'PAGADA' 
                When F.Estatus = 'A' then 'ABONADA'
				When F.Estatus = 'V' then 'VIGENTE'
				--WHEN F.Estatus = 'X' THEN 'CANCELADA'
			End as Estatus 					
	from FacturasClientesCab F inner join MFacCatClientes C on C.IdCliente=F.IdCliente
	where  FechaFactura between @FechaIni and @FechaFin and F.estatus <> 'X'
--un cliente en un rango de fechas
If @Opcion = 2
	Select F.IdCliente,	   
		   Nombre,
		   NoFactura,
		   Total,
		   IdClienteCargo,
		   (Select Nombre From MFacCatClientes where IdCliente=F.IdClienteCargo) as NombreCargo,
		   FechaFactura,
           Case When F.Estatus = 'P' then 'PAGADA' 
                When F.Estatus = 'A' then 'ABONADA'
				When F.Estatus = 'V' then 'VIGENTE'
				--WHEN F.Estatus = 'X' THEN 'CANCELADA'
			End as Estatus 
	from FacturasClientesCab F inner join MFacCatClientes C on C.IdCliente=F.IdCliente
	where  FechaFactura between @FechaIni and @FechaFin and F.IdCliente=@IdCliente AND F.estatus <> 'X'
