﻿CREATE VIEW web.VWCXP_004
AS
SELECT     dbo.cp_orden_pago.IdEmpresa, dbo.cp_orden_pago.IdOrdenPago, dbo.ct_cbtecble_det.IdTipoCbte, dbo.ct_cbtecble_det.IdCbteCble, dbo.ct_cbtecble_det.secuencia, 
                      dbo.cp_orden_pago.Fecha, dbo.cp_orden_pago.Observacion, dbo.cp_orden_pago.Estado, dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_plancta.pc_Cuenta, 
                      dbo.ct_cbtecble_det.dc_Valor, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Debe, 
                      CASE WHEN ct_cbtecble_det.dc_Valor < 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber, dbo.ct_cbtecble_tipo.tc_TipoCbte, 
                      dbo.ct_cbtecble_det.dc_Observacion, dbo.tb_persona.pe_nombreCompleto, dbo.cp_orden_pago.IdTipo_op, dbo.cp_orden_pago_det.Valor_a_pagar, og.co_factura, 
                      ti.Descripcion, ti.GeneraDiario, ap.IdEstadoAprobacion, ap.Descripcion AS estado_apro, dbo.seg_usuario.Nombre AS NombreUsuario, 
                      dbo.tb_sucursal.Su_Descripcion, CASE WHEN cp_orden_pago.IdTipo_op = 'FACT_PROVEE' THEN ISNULL(cp_proveedor_detalle.num_cta_acreditacion, 
                      cp_proveedor.num_cta_acreditacion) WHEN cp_orden_pago.IdTipo_op <> 'FACT_PROVEE' AND 
                      cp_orden_pago.IdTipo_Persona = 'PROVEE' THEN isnull(opcuenta.num_cta_acreditacion, opprov.num_cta_acreditacion) END AS num_cta_acreditacion
FROM         dbo.ct_cbtecble INNER JOIN
                      dbo.ct_cbtecble_det ON dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_det.IdTipoCbte AND 
                      dbo.ct_cbtecble.IdCbteCble = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                      dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble INNER JOIN
                      dbo.ct_cbtecble_tipo ON dbo.ct_cbtecble.IdEmpresa = dbo.ct_cbtecble_tipo.IdEmpresa AND dbo.ct_cbtecble.IdTipoCbte = dbo.ct_cbtecble_tipo.IdTipoCbte INNER JOIN
                      dbo.cp_orden_pago_det ON dbo.ct_cbtecble.IdEmpresa = dbo.cp_orden_pago_det.IdEmpresa_cxp AND 
                      dbo.ct_cbtecble.IdTipoCbte = dbo.cp_orden_pago_det.IdTipoCbte_cxp AND dbo.ct_cbtecble.IdCbteCble = dbo.cp_orden_pago_det.IdCbteCble_cxp INNER JOIN
                      dbo.cp_orden_pago ON dbo.cp_orden_pago_det.IdEmpresa = dbo.cp_orden_pago.IdEmpresa AND 
                      dbo.cp_orden_pago_det.IdOrdenPago = dbo.cp_orden_pago.IdOrdenPago INNER JOIN
                      dbo.tb_persona ON dbo.cp_orden_pago.IdPersona = dbo.tb_persona.IdPersona LEFT OUTER JOIN
                      dbo.cp_orden_giro AS og ON dbo.ct_cbtecble_det.IdEmpresa = og.IdEmpresa AND dbo.ct_cbtecble_det.IdTipoCbte = og.IdTipoCbte_Ogiro AND 
                      dbo.ct_cbtecble_det.IdCbteCble = og.IdCbteCble_Ogiro INNER JOIN
                      dbo.cp_orden_pago_tipo AS ti ON ti.IdTipo_op = dbo.cp_orden_pago.IdTipo_op INNER JOIN
                      dbo.cp_orden_pago_estado_aprob AS ap ON ap.IdEstadoAprobacion = dbo.cp_orden_pago.IdEstadoAprobacion LEFT OUTER JOIN
                      dbo.cp_proveedor_detalle AS opcuenta ON dbo.cp_orden_pago.SecuenciaProveedor = opcuenta.Secuencia AND 
                      dbo.cp_orden_pago.IdEmpresa = opcuenta.IdEmpresa AND dbo.cp_orden_pago.IdEntidad = opcuenta.IdProveedor LEFT OUTER JOIN
                      dbo.cp_proveedor_detalle ON og.IdEmpresa = dbo.cp_proveedor_detalle.IdEmpresa AND og.IdProveedor = dbo.cp_proveedor_detalle.IdProveedor AND 
                      og.SecuenciaProveedor = dbo.cp_proveedor_detalle.Secuencia LEFT OUTER JOIN
                      dbo.tb_sucursal ON dbo.cp_orden_pago.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cp_orden_pago.IdSucursal = dbo.tb_sucursal.IdSucursal LEFT OUTER JOIN
                      dbo.seg_usuario ON dbo.cp_orden_pago.IdUsuario = dbo.seg_usuario.IdUsuario LEFT OUTER JOIN
                      dbo.cp_proveedor ON dbo.cp_proveedor.IdEmpresa = og.IdEmpresa AND dbo.cp_proveedor.IdProveedor = og.IdProveedor LEFT OUTER JOIN
                      dbo.cp_proveedor AS opprov ON opprov.IdEmpresa = dbo.cp_orden_pago.IdEmpresa AND opprov.IdProveedor = dbo.cp_orden_pago.IdEntidad

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_004';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "og"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ti"
            Begin Extent = 
               Top = 270
               Left = 282
               Bottom = 400
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ap"
            Begin Extent = 
               Top = 402
               Left = 277
               Bottom = 498
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "opcuenta"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 510
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor_detalle"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 906
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 3
               Left = 875
               Bottom = 166
               Right = 1147
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "seg_usuario"
            Begin Extent = 
               Top = 107
               Left = 119
               Bottom = 237
               Right = 367
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 906
               Left = 38
               Bottom = 1014
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "opprov"
            Begin Extent = 
               Top = 1014
               Left = 38
               Bottom = 1122
               Right = 250
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
      Begin ColumnWidths = 25
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_004';






GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "ct_cbtecble"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_cbtecble_det"
            Begin Extent = 
               Top = 6
               Left = 258
               Bottom = 136
               Right = 455
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_cbtecble_tipo"
            Begin Extent = 
               Top = 138
               Left = 259
               Bottom = 268
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_orden_pago_det"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "cp_orden_pago"
            Begin Extent = 
               Top = 10
               Left = 592
               Bottom = 251
               Right = 793
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 270
       ', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_004';





