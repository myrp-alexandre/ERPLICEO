﻿CREATE TABLE [dbo].[aca_Seccion] (
    [IdEmpresa]             INT           NOT NULL,
    [IdSeccion]             INT           NOT NULL,
    [NomSeccion]            VARCHAR (500) NOT NULL,
    [Estado]                BIT           NOT NULL,
    [IdUsuarioCreacion]     VARCHAR (200) NULL,
    [FechaCreacion]         DATETIME      NULL,
    [IdUsuarioModificacion] VARCHAR (200) NULL,
    [FechaModificacion]     DATETIME      NULL,
    [IdUsuarioAnulacion]    VARCHAR (200) NULL,
    [FechaAnulacion]        DATETIME      NULL,
    [MotivoAnulacion]       VARCHAR (MAX) NULL,
    CONSTRAINT [PK_aca_Seccion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSeccion] ASC)
);
