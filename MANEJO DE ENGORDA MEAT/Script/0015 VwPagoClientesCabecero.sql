USE [GANADERA]
GO
/****** Object:  View [dbo].[VwPagoClientesCabecero]    Script Date: 09/24/2009 17:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER VIEW [dbo].[VwPagoClientesCabecero]
AS
SELECT  P.Fol_Ingreso, 
        P.Cve_Cliente, 
        P.Fec_Ingreso, 
        C.Nombre, 
        SUM(P.ImpteIngreso + P.ImpteNotaCred) AS Importe
FROM PagoDeCtes P inner JOIN MFacCatClientes C ON C.IdCliente = P.Cve_Cliente 
GROUP BY P.Fol_Ingreso, 
         P.Cve_Cliente, 
         P.Fec_Ingreso, 
         C.Nombre
