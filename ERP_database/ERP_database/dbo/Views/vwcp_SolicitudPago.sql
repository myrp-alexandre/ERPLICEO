﻿CREATE VIEW dbo.vwcp_SolicitudPago
AS
SELECT dbo.cp_SolicitudPago.IdEmpresa, dbo.cp_SolicitudPago.IdSolicitud, dbo.cp_SolicitudPago.IdSucursal, dbo.cp_SolicitudPago.Fecha, dbo.cp_SolicitudPago.IdProveedor, dbo.cp_SolicitudPago.Concepto, dbo.cp_SolicitudPago.Estado, 
                  dbo.cp_SolicitudPago.Valor, dbo.cp_SolicitudPago.Solicitante, dbo.cp_SolicitudPago.GiradoA, dbo.cp_proveedor.pr_codigo, dbo.tb_persona.pe_razonSocial, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, 
                  dbo.tb_persona.pe_nombreCompleto, dbo.cp_SolicitudPago.IdUsuarioCreacion
FROM     dbo.cp_SolicitudPago INNER JOIN
                  dbo.cp_proveedor ON dbo.cp_SolicitudPago.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_SolicitudPago.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_SolicitudPago';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[5] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "cp_SolicitudPago"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 419
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 293
               Right = 517
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 6
               Left = 555
               Bottom = 321
               Right = 787
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcp_SolicitudPago';



