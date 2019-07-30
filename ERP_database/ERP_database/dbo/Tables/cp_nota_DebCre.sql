﻿CREATE TABLE [dbo].[cp_nota_DebCre] (
    [IdEmpresa]                INT           NOT NULL,
    [IdCbteCble_Nota]          NUMERIC (18)  NOT NULL,
    [IdTipoCbte_Nota]          INT           NOT NULL,
    [DebCre]                   VARCHAR (1)   NOT NULL,
    [IdTipoNota]               VARCHAR (25)  NOT NULL,
    [IdProveedor]              NUMERIC (18)  NOT NULL,
    [IdSucursal]               INT           NOT NULL,
    [cn_fecha]                 DATE          NOT NULL,
    [Fecha_contable]           DATE          NULL,
    [cn_Fecha_vcto]            DATE          NOT NULL,
    [cn_serie1]                VARCHAR (10)  NULL,
    [cn_serie2]                VARCHAR (10)  NULL,
    [cn_Nota]                  VARCHAR (15)  NULL,
    [cn_observacion]           VARCHAR (500) NOT NULL,
    [cn_subtotal_iva]          FLOAT (53)    NOT NULL,
    [cn_subtotal_siniva]       FLOAT (53)    NOT NULL,
    [cn_baseImponible]         FLOAT (53)    NOT NULL,
    [cn_Por_iva]               FLOAT (53)    NOT NULL,
    [cn_valoriva]              FLOAT (53)    NOT NULL,
    [cn_Ice_base]              FLOAT (53)    NOT NULL,
    [cn_Ice_por]               FLOAT (53)    NOT NULL,
    [cn_Ice_valor]             FLOAT (53)    NOT NULL,
    [cn_Serv_por]              FLOAT (53)    NOT NULL,
    [cn_Serv_valor]            FLOAT (53)    NOT NULL,
    [cn_BaseSeguro]            MONEY         NOT NULL,
    [cn_total]                 MONEY         NOT NULL,
    [cn_vaCoa]                 CHAR (1)      NOT NULL,
    [cn_Autorizacion]          VARCHAR (50)  NULL,
    [cn_num_doc_modificado]    VARCHAR (50)  NULL,
    [IdCod_ICE]                INT           NULL,
    [IdTipoServicio]           VARCHAR (5)   NULL,
    [IdIden_credito]           INT           NULL,
    [IdUsuario]                VARCHAR (20)  NULL,
    [Fecha_Transac]            DATETIME      NULL,
    [Estado]                   VARCHAR (2)   NOT NULL,
    [IdUsuarioUltMod]          VARCHAR (20)  NULL,
    [Fecha_UltMod]             DATETIME      NULL,
    [IdUsuarioUltAnu]          VARCHAR (20)  NULL,
    [MotivoAnu]                VARCHAR (150) NULL,
    [Fecha_UltAnu]             DATETIME      NULL,
    [cn_tipoLocacion]          VARCHAR (5)   NULL,
    [PagoLocExt]               VARCHAR (3)   NULL,
    [PaisPago]                 VARCHAR (5)   NULL,
    [ConvenioTributacion]      VARCHAR (2)   NULL,
    [PagoSujetoRetencion]      VARCHAR (2)   NULL,
    [fecha_autorizacion]       DATETIME      NULL,
    [cod_nota]                 VARCHAR (50)  NULL,
    CONSTRAINT [PK_cp_nota_credito] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCbteCble_Nota] ASC, [IdTipoCbte_Nota] ASC),
    CONSTRAINT [FK_cp_nota_DebCre_cp_catalogo] FOREIGN KEY ([IdTipoNota]) REFERENCES [dbo].[cp_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_cp_nota_DebCre_cp_codigo_SRI] FOREIGN KEY ([IdCod_ICE]) REFERENCES [dbo].[cp_codigo_SRI] ([IdCodigo_SRI]),
    CONSTRAINT [FK_cp_nota_DebCre_cp_codigo_SRI1] FOREIGN KEY ([IdIden_credito]) REFERENCES [dbo].[cp_codigo_SRI] ([IdCodigo_SRI]),
    CONSTRAINT [FK_cp_nota_DebCre_cp_proveedor] FOREIGN KEY ([IdEmpresa], [IdProveedor]) REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor]),
    CONSTRAINT [FK_cp_nota_DebCre_ct_cbtecble] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_Nota], [IdCbteCble_Nota]) REFERENCES [dbo].[ct_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble]),
    CONSTRAINT [FK_cp_nota_DebCre_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);


GO
CREATE NONCLUSTERED INDEX [IX_cp_nota_DebCre]
    ON [dbo].[cp_nota_DebCre]([IdEmpresa] ASC, [IdTipoCbte_Nota] ASC, [IdCbteCble_Nota] ASC, [IdProveedor] ASC);
