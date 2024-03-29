﻿CREATE TABLE [EntidadRegulatoria].[ATS_retenciones] (
    [IdEmpresa]         INT             NOT NULL,
    [IdPeriodo]         INT             NOT NULL,
    [Secuencia]         INT             NOT NULL,
    [co_serie]          VARCHAR (10)    NOT NULL,
    [co_factura]        VARCHAR (12)    NOT NULL,
    [Cedula_ruc]        VARCHAR (13)    NOT NULL,
    [valRetBien10]      NUMERIC (12, 2) NULL,
    [valRetServ20]      NUMERIC (12, 2) NULL,
    [valorRetBienes]    NUMERIC (12, 2) NULL,
    [valRetServ50]      NUMERIC (12, 2) NULL,
    [valorRetServicios] NUMERIC (12, 2) NULL,
    [valRetServ100]     NUMERIC (12, 2) NULL,
    [codRetAir]         VARCHAR (10)    NULL,
    [baseImpAir]        NUMERIC (12, 2) NULL,
    [porcentajeAir]     VARCHAR (5)     NULL,
    [valRetAir]         NUMERIC (12, 2) NULL,
    [estabRetencion1]   VARCHAR (3)     NULL,
    [ptoEmiRetencion1]  VARCHAR (3)     NULL,
    [secRetencion1]     VARCHAR (9)     NULL,
    [autRetencion1]     VARCHAR (49)    NULL,
    [fechaEmiRet1]      DATE            NULL,
    [docModificado]     VARCHAR (9)     NULL,
    [estabModificado]   VARCHAR (3)     NULL,
    [ptoEmiModificado]  VARCHAR (3)     NULL,
    [secModificado]     VARCHAR (9)     NULL,
    [autModificado]     VARCHAR (49)    NULL,
    [re_tipo_Ret]       VARCHAR (10)    NOT NULL,
    [denopr]            VARCHAR (500)   NULL,
    [IdSucursal]        INT             NULL,
    CONSTRAINT [PK_retenciones] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPeriodo] ASC, [Secuencia] ASC)
);



