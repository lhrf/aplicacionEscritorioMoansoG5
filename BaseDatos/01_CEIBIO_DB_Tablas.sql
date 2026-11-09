USE master;
GO
IF DB_ID('CEIBIO_DB') IS NOT NULL
BEGIN
    ALTER DATABASE CEIBIO_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CEIBIO_DB;
END
GO
CREATE DATABASE CEIBIO_DB;
GO
USE CEIBIO_DB;
GO

CREATE TABLE Rol (
    IdRol               INT IDENTITY(1,1) PRIMARY KEY,
    Nombre              NVARCHAR(60) NOT NULL UNIQUE
);

CREATE TABLE Usuario (
    IdUsuario           INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto      NVARCHAR(120) NOT NULL,
    Dni                 CHAR(8) NOT NULL UNIQUE CHECK (Dni NOT LIKE '%[^0-9]%' AND LEN(Dni) = 8),
    NombreUsuario       NVARCHAR(30) NOT NULL UNIQUE,
    ClaveHash           CHAR(64) NOT NULL,
    Sal                 CHAR(32) NOT NULL,
    IdRol               INT NOT NULL REFERENCES Rol(IdRol),
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE RegistroSesion (
    IdRegistro          INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaHora           DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Correlativo (
    Tipo                VARCHAR(20) PRIMARY KEY,
    Serie               VARCHAR(10) NOT NULL,
    Ultimo              INT NOT NULL DEFAULT 0
);

CREATE TABLE Examen (
    IdExamen            INT IDENTITY(1,1) PRIMARY KEY,
    Codigo              VARCHAR(10) NOT NULL UNIQUE,
    Nombre              NVARCHAR(100) NOT NULL,
    TipoMuestra         NVARCHAR(20) NOT NULL,
    Procedimiento       NVARCHAR(20) NOT NULL,
    Tarifa              DECIMAL(10,2) NOT NULL CHECK (Tarifa > 0),
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Convenio (
    IdConvenio          INT IDENTITY(1,1) PRIMARY KEY,
    Institucion         NVARCHAR(120) NOT NULL,
    PorcentajeDescuento DECIMAL(5,2) NOT NULL CHECK (PorcentajeDescuento > 0 AND PorcentajeDescuento <= 100),
    FechaInicio         DATE NOT NULL,
    FechaFin            DATE NOT NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_Convenio_Vigencia CHECK (FechaFin > FechaInicio)
);

CREATE TABLE CondicionPreanalitica (
    IdCondicion             INT IDENTITY(1,1) PRIMARY KEY,
    IdExamen                INT NOT NULL REFERENCES Examen(IdExamen),
    HorasAyuno              INT NOT NULL DEFAULT 0,
    RestriccionMedicamentos NVARCHAR(200) NULL,
    MuestraQueDebeTraer     NVARCHAR(100) NULL,
    Habilitado              BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro       INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro           DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE MedioPago (
    IdMedioPago          INT IDENTITY(1,1) PRIMARY KEY,
    Codigo               VARCHAR(10) NOT NULL UNIQUE,
    Descripcion          NVARCHAR(60) NOT NULL,
    RequiereAutorizacion BIT NOT NULL DEFAULT 0,
    Habilitado           BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro    INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro        DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Tubo (
    IdTubo                INT IDENTITY(1,1) PRIMARY KEY,
    Tipo                  NVARCHAR(60) NOT NULL,
    ColorTapa             NVARCHAR(30) NOT NULL,
    Aditivo               NVARCHAR(60) NULL,
    MinutosCentrifugacion INT NOT NULL DEFAULT 0,
    Habilitado            BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro     INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro         DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE TuboExamen (
    IdTubo              INT NOT NULL REFERENCES Tubo(IdTubo),
    IdExamen            INT NOT NULL REFERENCES Examen(IdExamen),
    PRIMARY KEY (IdTubo, IdExamen)
);

CREATE TABLE Box (
    IdBox               INT IDENTITY(1,1) PRIMARY KEY,
    Numero              VARCHAR(10) NOT NULL UNIQUE,
    Descripcion         NVARCHAR(100) NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Equipo (
    IdEquipo            INT IDENTITY(1,1) PRIMARY KEY,
    Codigo              VARCHAR(10) NOT NULL UNIQUE,
    Nombre              NVARCHAR(100) NOT NULL,
    Marca               NVARCHAR(60) NULL,
    Modelo              NVARCHAR(60) NULL,
    Tipo                NVARCHAR(20) NOT NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Parametro (
    IdParametro         INT IDENTITY(1,1) PRIMARY KEY,
    IdExamen            INT NOT NULL REFERENCES Examen(IdExamen),
    Nombre              NVARCHAR(100) NOT NULL,
    Unidad              NVARCHAR(20) NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT UQ_Parametro UNIQUE (IdExamen, Nombre)
);

CREATE TABLE Plantilla (
    IdPlantilla         INT IDENTITY(1,1) PRIMARY KEY,
    Nombre              NVARCHAR(100) NOT NULL UNIQUE,
    Formato             NVARCHAR(260) NOT NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE PlantillaExamen (
    IdPlantilla         INT NOT NULL REFERENCES Plantilla(IdPlantilla),
    IdExamen            INT NOT NULL REFERENCES Examen(IdExamen),
    PRIMARY KEY (IdPlantilla, IdExamen)
);

CREATE TABLE IntervaloReferencia (
    IdIntervalo         INT IDENTITY(1,1) PRIMARY KEY,
    IdParametro         INT NOT NULL REFERENCES Parametro(IdParametro),
    ValorMinimo         DECIMAL(12,3) NULL,
    ValorMaximo         DECIMAL(12,3) NULL,
    Sexo                NVARCHAR(10) NOT NULL DEFAULT N'Ambos',
    EdadMinima          INT NOT NULL DEFAULT 0,
    EdadMaxima          INT NOT NULL DEFAULT 120,
    ReferenciaTexto     NVARCHAR(100) NULL,
    Habilitado          BIT NOT NULL DEFAULT 1,
    IdUsuarioRegistro   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Paciente (
    IdPaciente            INT IDENTITY(1,1) PRIMARY KEY,
    Dni                   CHAR(8) NOT NULL UNIQUE CHECK (Dni NOT LIKE '%[^0-9]%' AND LEN(Dni) = 8),
    Nombres               NVARCHAR(80) NOT NULL,
    Apellidos             NVARCHAR(80) NOT NULL,
    FechaNacimiento       DATE NOT NULL,
    Sexo                  NVARCHAR(10) NOT NULL,
    Direccion             NVARCHAR(150) NULL,
    Telefono              VARCHAR(9) NULL CHECK (Telefono IS NULL OR (Telefono NOT LIKE '%[^0-9]%' AND LEN(Telefono) BETWEEN 7 AND 9)),
    IdUsuarioRegistro     INT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro         DATETIME NOT NULL DEFAULT GETDATE(),
    IdUsuarioModificacion INT NULL REFERENCES Usuario(IdUsuario),
    FechaModificacion     DATETIME NULL
);

CREATE TABLE Atencion (
    IdAtencion          INT IDENTITY(1,1) PRIMARY KEY,
    NumeroAtencion      AS ('AT-' + RIGHT('000000' + CAST(IdAtencion AS VARCHAR(10)), 6)) PERSISTED,
    IdPaciente          INT NOT NULL REFERENCES Paciente(IdPaciente),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    Modalidad           NVARCHAR(15) NOT NULL,
    IdConvenio          INT NULL REFERENCES Convenio(IdConvenio),
    Subtotal            DECIMAL(10,2) NOT NULL,
    Descuento           DECIMAL(10,2) NOT NULL DEFAULT 0,
    CostoTotal          DECIMAL(10,2) NOT NULL,
    Estado              NVARCHAR(40) NOT NULL,
    MotivoAnulacion     NVARCHAR(200) NULL,
    NumeroTurno         INT NULL,
    FechaDerivacion     DATETIME NULL,
    IdBox               INT NULL REFERENCES Box(IdBox),
    IdUsuarioRegistro   INT NOT NULL REFERENCES Usuario(IdUsuario)
);

CREATE TABLE AtencionExamen (
    IdAtencion                 INT NOT NULL REFERENCES Atencion(IdAtencion),
    IdExamen                   INT NOT NULL REFERENCES Examen(IdExamen),
    Tarifa                     DECIMAL(10,2) NOT NULL,
    ObservacionesMicroscopicas NVARCHAR(500) NULL,
    PRIMARY KEY (IdAtencion, IdExamen)
);

CREATE TABLE VisitaDomiciliaria (
    IdVisita            INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion          INT NOT NULL UNIQUE REFERENCES Atencion(IdAtencion),
    Direccion           NVARCHAR(150) NOT NULL,
    Referencia          NVARCHAR(150) NULL,
    Telefono            VARCHAR(9) NOT NULL CHECK (Telefono NOT LIKE '%[^0-9]%' AND LEN(Telefono) BETWEEN 7 AND 9),
    FechaProgramada     DATE NOT NULL,
    Estado              NVARCHAR(20) NOT NULL,
    Motivo              NVARCHAR(200) NULL,
    IdTecnico           INT NULL REFERENCES Usuario(IdUsuario),
    IdUsuarioRegistro   INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE EvaluacionPreanalitica (
    IdEvaluacion         INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion           INT NOT NULL UNIQUE REFERENCES Atencion(IdAtencion),
    HorasAyuno           INT NOT NULL DEFAULT 0,
    Medicamentos         NVARCHAR(200) NULL,
    RotuladoCorrecto     BIT NULL,
    RecipienteHermetico  BIT NULL,
    VolumenSuficiente    BIT NULL,
    ConservacionAdecuada BIT NULL,
    Observaciones        NVARCHAR(500) NULL,
    IdUsuarioObservacion INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaObservacion     DATETIME NOT NULL DEFAULT GETDATE(),
    Resultado            NVARCHAR(10) NULL,
    IdUsuarioResultado   INT NULL REFERENCES Usuario(IdUsuario),
    FechaResultado       DATETIME NULL
);

CREATE TABLE Suspension (
    IdSuspension        INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion          INT NOT NULL REFERENCES Atencion(IdAtencion),
    Motivo              NVARCHAR(300) NOT NULL,
    NuevaFecha          DATE NOT NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    Reactivada          BIT NOT NULL DEFAULT 0,
    IdUsuarioReactiva   INT NULL REFERENCES Usuario(IdUsuario),
    FechaReactivacion   DATETIME NULL
);

CREATE TABLE Pago (
    IdPago              INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion          INT NOT NULL REFERENCES Atencion(IdAtencion),
    IdMedioPago         INT NOT NULL REFERENCES MedioPago(IdMedioPago),
    Importe             DECIMAL(10,2) NOT NULL,
    MontoRecibido       DECIMAL(10,2) NULL,
    Vuelto              DECIMAL(10,2) NULL,
    Estado              NVARCHAR(30) NOT NULL,
    IdCajero            INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    FechaConformidad    DATETIME NULL
);

CREATE TABLE Transferencia (
    IdTransferencia     INT IDENTITY(1,1) PRIMARY KEY,
    IdPago              INT NOT NULL REFERENCES Pago(IdPago),
    NumeroOperacion     VARCHAR(30) NULL,
    Importe             DECIMAL(10,2) NULL,
    FechaOperacion      DATE NULL,
    Estado              NVARCHAR(15) NOT NULL,
    Observacion         NVARCHAR(300) NULL,
    IdSupervisor        INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Comprobante (
    IdComprobante       INT IDENTITY(1,1) PRIMARY KEY,
    NumeroComprobante   VARCHAR(15) NOT NULL UNIQUE,
    IdAtencion          INT NOT NULL REFERENCES Atencion(IdAtencion),
    IdPago              INT NOT NULL REFERENCES Pago(IdPago),
    FechaEmision        DATETIME NOT NULL DEFAULT GETDATE(),
    Subtotal            DECIMAL(10,2) NOT NULL,
    Descuento           DECIMAL(10,2) NOT NULL,
    Total               DECIMAL(10,2) NOT NULL,
    Estado              NVARCHAR(10) NOT NULL DEFAULT N'Emitido',
    IdCajero            INT NOT NULL REFERENCES Usuario(IdUsuario),
    MotivoAnulacion     NVARCHAR(200) NULL,
    IdUsuarioAnula      INT NULL REFERENCES Usuario(IdUsuario),
    FechaAnulacion      DATETIME NULL
);

CREATE TABLE Recaudacion (
    IdRecaudacion       INT IDENTITY(1,1) PRIMARY KEY,
    IdComprobante       INT NOT NULL REFERENCES Comprobante(IdComprobante),
    Fecha               DATE NOT NULL,
    Importe             DECIMAL(10,2) NOT NULL,
    IdMedioPago         INT NOT NULL REFERENCES MedioPago(IdMedioPago),
    IdCajero            INT NOT NULL REFERENCES Usuario(IdUsuario),
    Tipo                NVARCHAR(10) NOT NULL,
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Muestra (
    IdMuestra              INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion             INT NOT NULL UNIQUE REFERENCES Atencion(IdAtencion),
    Codigo                 VARCHAR(12) NOT NULL UNIQUE,
    FechaGeneracion        DATETIME NOT NULL DEFAULT GETDATE(),
    IdUsuarioGenera        INT NOT NULL REFERENCES Usuario(IdUsuario),
    HoraExtraccion         DATETIME NULL,
    IdUsuarioToma          INT NULL REFERENCES Usuario(IdUsuario),
    FechaValidacion        DATETIME NULL,
    CondicionesDeclaradas  NVARCHAR(500) NULL,
    RechazosOcurridos      NVARCHAR(500) NULL,
    FechaIngreso           DATETIME NULL,
    IdUsuarioIngreso       INT NULL REFERENCES Usuario(IdUsuario),
    EstadoConservacion     NVARCHAR(20) NULL,
    MinutosCentrifugacion  INT NULL,
    FechaAcondicionamiento DATETIME NULL,
    IdUsuarioAcondiciona   INT NULL REFERENCES Usuario(IdUsuario),
    FechaRecepcion         DATETIME NULL,
    IdUsuarioRecepcion     INT NULL REFERENCES Usuario(IdUsuario),
    Estado                 NVARCHAR(30) NOT NULL
);

CREATE TABLE RechazoMuestra (
    IdRechazo           INT IDENTITY(1,1) PRIMARY KEY,
    IdMuestra           INT NOT NULL REFERENCES Muestra(IdMuestra),
    IdExamen            INT NULL REFERENCES Examen(IdExamen),
    IdTubo              INT NULL REFERENCES Tubo(IdTubo),
    Motivo              NVARCHAR(40) NOT NULL,
    Observacion         NVARCHAR(300) NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Fecha               DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE DevolucionMuestra (
    IdDevolucion        INT IDENTITY(1,1) PRIMARY KEY,
    IdMuestra           INT NOT NULL REFERENCES Muestra(IdMuestra),
    Diferencia          NVARCHAR(300) NOT NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Fecha               DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE CorreccionMuestra (
    IdCorreccion        INT IDENTITY(1,1) PRIMARY KEY,
    IdMuestra           INT NOT NULL REFERENCES Muestra(IdMuestra),
    DatoAnterior        NVARCHAR(300) NOT NULL,
    Motivo              NVARCHAR(300) NOT NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Fecha               DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE ResultadoAnalitico (
    IdResultado         INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion          INT NOT NULL REFERENCES Atencion(IdAtencion),
    IdParametro         INT NOT NULL REFERENCES Parametro(IdParametro),
    Valor               NVARCHAR(100) NULL,
    Estado              NVARCHAR(30) NOT NULL,
    IdTecnico           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRegistro       DATETIME NOT NULL DEFAULT GETDATE(),
    FechaEnvio          DATETIME NULL,
    ObservacionMedico   NVARCHAR(300) NULL,
    IdMedico            INT NULL REFERENCES Usuario(IdUsuario),
    FechaValidacion     DATETIME NULL,
    CONSTRAINT UQ_Resultado UNIQUE (IdAtencion, IdParametro)
);

CREATE TABLE ResultadoAnterior (
    IdResultadoAnterior INT IDENTITY(1,1) PRIMARY KEY,
    IdResultado         INT NOT NULL REFERENCES ResultadoAnalitico(IdResultado),
    Valor               NVARCHAR(100) NULL,
    ObservacionMedico   NVARCHAR(300) NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Fecha               DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE UsoEquipo (
    IdUso                 INT IDENTITY(1,1) PRIMARY KEY,
    IdEquipo              INT NOT NULL REFERENCES Equipo(IdEquipo),
    IdMuestra             INT NOT NULL REFERENCES Muestra(IdMuestra),
    HoraInicio            DATETIME NOT NULL DEFAULT GETDATE(),
    IdTecnico             INT NOT NULL REFERENCES Usuario(IdUsuario),
    RequiereNuevaCorrida  BIT NOT NULL DEFAULT 0
);

CREATE TABLE FallaAnalitica (
    IdFalla             INT IDENTITY(1,1) PRIMARY KEY,
    IdUso               INT NOT NULL REFERENCES UsoEquipo(IdUso),
    Descripcion         NVARCHAR(500) NOT NULL,
    FechaHora           DATETIME NOT NULL DEFAULT GETDATE(),
    IdTecnico           INT NOT NULL REFERENCES Usuario(IdUsuario)
);

CREATE TABLE ReporteClinico (
    IdReporte           INT IDENTITY(1,1) PRIMARY KEY,
    IdAtencion          INT NOT NULL UNIQUE REFERENCES Atencion(IdAtencion),
    Version             INT NOT NULL DEFAULT 1,
    Contenido           NVARCHAR(MAX) NOT NULL,
    Estado              NVARCHAR(40) NOT NULL,
    Definitivo          BIT NOT NULL DEFAULT 0,
    IdDigitador         INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaGeneracion     DATETIME NOT NULL DEFAULT GETDATE(),
    IdDirector          INT NULL REFERENCES Usuario(IdUsuario),
    FechaAutorizacion   DATETIME NULL
);

CREATE TABLE ReporteHistorial (
    IdHistorial         INT IDENTITY(1,1) PRIMARY KEY,
    IdReporte           INT NOT NULL REFERENCES ReporteClinico(IdReporte),
    Version             INT NOT NULL,
    Accion              NVARCHAR(60) NOT NULL,
    Observacion         NVARCHAR(500) NULL,
    Contenido           NVARCHAR(MAX) NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Fecha               DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Entrega (
    IdEntrega           INT IDENTITY(1,1) PRIMARY KEY,
    IdReporte           INT NOT NULL UNIQUE REFERENCES ReporteClinico(IdReporte),
    NombreRecibe        NVARCHAR(120) NOT NULL,
    DniRecibe           CHAR(8) NOT NULL CHECK (DniRecibe NOT LIKE '%[^0-9]%' AND LEN(DniRecibe) = 8),
    Relacion            NVARCHAR(20) NOT NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaEntrega        DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE RetencionEntrega (
    IdRetencion         INT IDENTITY(1,1) PRIMARY KEY,
    IdReporte           INT NOT NULL REFERENCES ReporteClinico(IdReporte),
    Motivo              NVARCHAR(300) NOT NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaRetencion      DATETIME NOT NULL DEFAULT GETDATE(),
    Levantada           BIT NOT NULL DEFAULT 0,
    IdUsuarioLevanta    INT NULL REFERENCES Usuario(IdUsuario),
    FechaLevantamiento  DATETIME NULL
);

CREATE TABLE Auditoria (
    IdAuditoria         INT IDENTITY(1,1) PRIMARY KEY,
    Tabla               NVARCHAR(50) NOT NULL,
    IdRegistro          INT NOT NULL,
    Accion              NVARCHAR(40) NOT NULL,
    Detalle             NVARCHAR(500) NULL,
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    FechaHora           DATETIME NOT NULL DEFAULT GETDATE()
);
CREATE INDEX IX_Auditoria_Registro ON Auditoria (Tabla, IdRegistro);

CREATE TABLE MovimientoMuestra (
    IdMovimiento        INT IDENTITY(1,1) PRIMARY KEY,
    IdMuestra           INT NOT NULL REFERENCES Muestra(IdMuestra),
    TipoMovimiento      NVARCHAR(20) NOT NULL
        CHECK (TipoMovimiento IN (N'Ingreso', N'Acondicionamiento', N'Recepción', N'Devolución', N'Corrección')),
    FechaHora           DATETIME NOT NULL DEFAULT GETDATE(),
    IdUsuario           INT NOT NULL REFERENCES Usuario(IdUsuario),
    Detalle             NVARCHAR(500) NULL
);
CREATE INDEX IX_MovimientoMuestra_Muestra ON MovimientoMuestra (IdMuestra);

CREATE TABLE ReporteSeccion (
    IdSeccion           INT IDENTITY(1,1) PRIMARY KEY,
    IdReporte           INT NOT NULL REFERENCES ReporteClinico(IdReporte),
    Version             INT NOT NULL,
    IdExamen            INT NOT NULL REFERENCES Examen(IdExamen),
    IdPlantilla         INT NOT NULL REFERENCES Plantilla(IdPlantilla),
    Contenido           NVARCHAR(MAX) NOT NULL,
    CONSTRAINT UQ_ReporteSeccion UNIQUE (IdReporte, Version, IdExamen)
);
GO

INSERT INTO Rol (Nombre) VALUES
 (N'Administrador del Sistema'), (N'Director Médico'), (N'Asesor de Admisión'), (N'Auxiliar de Archivo'),
 (N'Enfermera Evaluadora'), (N'Cajero'), (N'Supervisor de Turno'), (N'Técnico Laboratorista Itinerante'),
 (N'Orientador de Sala'), (N'Técnico Flebotomista'), (N'Auxiliar de Laboratorio'), (N'Técnico Analista'),
 (N'Médico Patólogo'), (N'Digitador Clínico'), (N'Supervisor de Calidad'), (N'Encargado de Entregas');

INSERT INTO Usuario (NombreCompleto, Dni, NombreUsuario, ClaveHash, Sal, IdRol) VALUES
 (N'Administrador del sistema', '70000001', N'admin', '10222992842501A7D4E21D6A8947F45F0D921F0B5D58A10AC6DBB756C8FF5810', '7D61BCF7FD75E639B154978AA46AD758', 1),
 (N'Director médico', '70000002', N'director', 'EC44A2196718FE60CFB321EE174ADF4FD309C50BE6416A28B61DD3422260ACD1', '142BDD949B9C98290AE3602805411055', 2),
 (N'Asesor de admisión', '70000003', N'admision', '721546CA51D1ED8A801A5513EDE4406215A48236EF373D1A4FEB8B3DEF6D2192', '3E58D410524FBB92AF1FC527396AD59A', 3),
 (N'Auxiliar de archivo', '70000004', N'archivo', '0DC2FABABD6F03CD83F39F7D78E8CCE0B25B444C6CCAB7658D3C1A2DD038F052', '6187E44B8F62C8828D84D323536AAB09', 4),
 (N'Enfermera evaluadora', '70000005', N'enfermera', '4C29C599A8417B522696318A89CE6B8224E6F9EA76D5A0490B38E089C0C3390B', '8A6B45DE9602D93116152C624082DA9E', 5),
 (N'Cajero', '70000006', N'cajero', 'CE2441A7CECCD6677ABCCA2F903B569BCC504E43403D0B8A1C837AFEF60838F5', '9E3BDA56086D5F4374A90CBA50BC6DB7', 6),
 (N'Supervisor de turno', '70000007', N'supervisor', '458A46136EA59A71948F42AF6C75CD3128C259CE6EE7EF0E10E448397D89847B', '98358CE057A9C709C3A7648DD0C238ED', 7),
 (N'Técnico itinerante', '70000008', N'itinerante', '0A440EDCB688FCF2247077C59BBAA3D04BCB8C690D4DA86FABA6C9CDA951328F', 'A6BA7CEA298AFC7BDD6ABBF504D46115', 8),
 (N'Orientador de sala', '70000009', N'orientador', '598AB7DA10A51EEC0F18D090F0A5B75660C110B251E230B981DE1897DE764A08', 'F37B3B3F609A7A3F5ADE533DE920C8CB', 9),
 (N'Técnico flebotomista', '70000010', N'flebotomista', 'E25CC7F0E09B5D3010FF955B535A35E93B4E776AD31E7725C12DDDD6E4AD6BA1', 'A7F5EAA2071BF874D474281B80F325FD', 10),
 (N'Auxiliar de laboratorio', '70000011', N'auxlab', '246FECF06CE8F4080D78F5F32FA386C52E25C8217CC1E9B70AFCFA6DF000449B', '6B727E358058024C2A7518F0D98662CC', 11),
 (N'Técnico analista', '70000012', N'analista', 'D29A1949DC1AD04661598B8FFAA6BE8CC2FC3EBC86F56DEBC17727BE4AE96D4E', '51FBC14571D92EB6E9149DB0F5A12F31', 12),
 (N'Médico patólogo', '70000013', N'patologo', '5F813A565FE615E11FED88B593981F75CEF72770760932869789B77CA121291E', 'FF58864F9B73D20F7BB78042DB0BCFDF', 13),
 (N'Digitador clínico', '70000014', N'digitador', '56E12DF20610F463A3D28E66BE7C057F05CE8CED51F7B56BDDEF4C28980CAAD8', '6989236A279CA45F5F016DEC2CDF7717', 14),
 (N'Supervisor de calidad', '70000015', N'calidad', '8DAD1383742E2ACD61E03F1B3FA546D547AF3ABBF0EE3927A1E25513DBACA2C1', 'F242A1CD9FD4EDC93C4C9BC70301CAD5', 15),
 (N'Encargado de entregas', '70000016', N'entregas', '0118790C4BAF7BC5EEEC7561189876A32B09AD93A694127C56A0197BCB3CE11F', '67834118323FDE9CF85DED514CA560BC', 16);

INSERT INTO Correlativo (Tipo, Serie, Ultimo) VALUES ('COMPROBANTE', 'B001', 0), ('MUESTRA', 'M', 0);

INSERT INTO MedioPago (Codigo, Descripcion, RequiereAutorizacion, IdUsuarioRegistro) VALUES
 ('EFE', N'Efectivo', 0, 1), ('TAR', N'Tarjeta', 0, 1), ('TRA', N'Transferencia', 1, 1);

INSERT INTO Examen (Codigo, Nombre, TipoMuestra, Procedimiento, Tarifa, IdUsuarioRegistro) VALUES
 ('HEM01', N'Hemograma completo',      N'Sangre', N'Automatizado', 25.00, 1),
 ('GLU01', N'Glucosa basal',           N'Sangre', N'Automatizado', 10.00, 1),
 ('LIP01', N'Perfil lipídico',         N'Sangre', N'Automatizado', 45.00, 1),
 ('ORI01', N'Examen completo de orina', N'Orina', N'Microscópico', 15.00, 1),
 ('PAR01', N'Parasitológico seriado',  N'Heces',  N'Microscópico', 20.00, 1);

INSERT INTO Convenio (Institucion, PorcentajeDescuento, FechaInicio, FechaFin, IdUsuarioRegistro) VALUES
 (N'Colegio de Ingenieros del Perú', 10, '2026-01-01', '2026-12-31', 1),
 (N'Asociación de Docentes UPN',     15, '2026-01-01', '2027-06-30', 1);

INSERT INTO CondicionPreanalitica (IdExamen, HorasAyuno, RestriccionMedicamentos, MuestraQueDebeTraer, IdUsuarioRegistro) VALUES
 (2, 8,  N'No tomar hipoglucemiantes el día del examen', NULL, 1),
 (3, 12, N'Suspender hipolipemiantes 24 h antes', NULL, 1),
 (4, 0,  NULL, N'Primera orina de la mañana en frasco estéril', 1),
 (5, 0,  N'No tomar antiparasitarios', N'Tres muestras de heces en días distintos', 1);

INSERT INTO Tubo (Tipo, ColorTapa, Aditivo, MinutosCentrifugacion, IdUsuarioRegistro) VALUES
 (N'Tubo con EDTA',          N'Lila',     N'EDTA K2',         0,  1),
 (N'Tubo con gel separador', N'Amarillo', N'Activador de coágulo', 10, 1),
 (N'Frasco de orina',        N'Blanco',   NULL,               0,  1),
 (N'Frasco de heces',        N'Rojo',     NULL,               0,  1);
INSERT INTO TuboExamen (IdTubo, IdExamen) VALUES (1, 1), (2, 2), (2, 3), (3, 4), (4, 5);

INSERT INTO Box (Numero, Descripcion, IdUsuarioRegistro) VALUES
 ('1', N'Box de extracción 1', 1), ('2', N'Box de extracción 2', 1), ('3', N'Box pediátrico', 1);

INSERT INTO Equipo (Codigo, Nombre, Marca, Modelo, Tipo, IdUsuarioRegistro) VALUES
 ('EQ01', N'Analizador hematológico', N'Sysmex',  N'XN-550',   N'Automatizado', 1),
 ('EQ02', N'Analizador bioquímico',   N'Mindray', N'BS-240',   N'Automatizado', 1),
 ('EQ03', N'Microscopio binocular',   N'Olympus', N'CX23',     N'Microscopio',  1);

INSERT INTO Parametro (IdExamen, Nombre, Unidad, IdUsuarioRegistro) VALUES
 (1, N'Hemoglobina', N'g/dL', 1), (1, N'Leucocitos', N'x10³/µL', 1), (1, N'Plaquetas', N'x10³/µL', 1),
 (2, N'Glucosa', N'mg/dL', 1),
 (3, N'Colesterol total', N'mg/dL', 1), (3, N'Triglicéridos', N'mg/dL', 1),
 (4, N'Aspecto', NULL, 1), (4, N'Leucocitos por campo', NULL, 1),
 (5, N'Parásitos', NULL, 1);

INSERT INTO IntervaloReferencia (IdParametro, ValorMinimo, ValorMaximo, Sexo, EdadMinima, EdadMaxima, ReferenciaTexto, IdUsuarioRegistro) VALUES
 (1, 12.0, 16.0, N'Femenino',  18, 120, NULL, 1),
 (1, 13.5, 17.5, N'Masculino', 18, 120, NULL, 1),
 (1, 11.0, 15.5, N'Ambos',      0,  17, NULL, 1),
 (2, 4.5, 11.0,  N'Ambos',      0, 120, NULL, 1),
 (3, 150, 450,   N'Ambos',      0, 120, NULL, 1),
 (4, 70, 100,    N'Ambos',      0, 120, NULL, 1),
 (5, NULL, 200,  N'Ambos',      0, 120, NULL, 1),
 (6, NULL, 150,  N'Ambos',      0, 120, NULL, 1),
 (7, NULL, NULL, N'Ambos',      0, 120, N'Transparente', 1),
 (8, NULL, NULL, N'Ambos',      0, 120, N'0 a 5 por campo', 1),
 (9, NULL, NULL, N'Ambos',      0, 120, N'No se observan', 1);

INSERT INTO Plantilla (Nombre, Formato, IdUsuarioRegistro) VALUES
 (N'Hematología',   N'Plantillas\Hematologia.rtf', 1),
 (N'Bioquímica',    N'Plantillas\Bioquimica.rtf', 1),
 (N'Uroanálisis',   N'Plantillas\Uroanalisis.rtf', 1),
 (N'Parasitología', N'Plantillas\Parasitologia.rtf', 1);
INSERT INTO PlantillaExamen (IdPlantilla, IdExamen) VALUES (1, 1), (2, 2), (2, 3), (3, 4), (4, 5);
GO
