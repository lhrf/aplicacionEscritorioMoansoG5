USE CEIBIO_DB;
GO

CREATE OR ALTER VIEW vw_Usuario AS
SELECT u.IdUsuario, u.NombreCompleto, u.Dni, u.NombreUsuario, u.ClaveHash, u.Sal, u.IdRol, r.Nombre AS NombreRol,
       u.Habilitado, u.FechaRegistro
FROM Usuario u
INNER JOIN Rol r ON r.IdRol = u.IdRol;
GO

CREATE OR ALTER VIEW vw_Condicion AS
SELECT c.IdCondicion, c.IdExamen, e.Nombre AS NombreExamen, c.HorasAyuno, c.RestriccionMedicamentos,
       c.MuestraQueDebeTraer, c.Habilitado
FROM CondicionPreanalitica c
INNER JOIN Examen e ON e.IdExamen = c.IdExamen;
GO

CREATE OR ALTER VIEW vw_Parametro AS
SELECT p.IdParametro, p.IdExamen, e.Nombre AS NombreExamen, p.Nombre, p.Unidad, p.Habilitado
FROM Parametro p
INNER JOIN Examen e ON e.IdExamen = p.IdExamen;
GO

CREATE OR ALTER VIEW vw_Plantilla AS
SELECT p.IdPlantilla, p.Nombre, p.Formato, p.Habilitado,
       ISNULL((SELECT STRING_AGG(e.Nombre, ', ') WITHIN GROUP (ORDER BY e.Nombre)
               FROM PlantillaExamen pe INNER JOIN Examen e ON e.IdExamen = pe.IdExamen
               WHERE pe.IdPlantilla = p.IdPlantilla), '') AS Examenes
FROM Plantilla p;
GO

CREATE OR ALTER VIEW vw_Intervalo AS
SELECT i.IdIntervalo, i.IdParametro, p.Nombre AS NombreParametro, p.IdExamen, e.Nombre AS NombreExamen,
       i.ValorMinimo, i.ValorMaximo, i.Sexo, i.EdadMinima, i.EdadMaxima, i.ReferenciaTexto, i.Habilitado
FROM IntervaloReferencia i
INNER JOIN Parametro p ON p.IdParametro = i.IdParametro
INNER JOIN Examen e ON e.IdExamen = p.IdExamen;
GO

CREATE OR ALTER VIEW vw_Atencion AS
SELECT a.IdAtencion, a.NumeroAtencion, a.IdPaciente, p.Dni, p.Apellidos + ', ' + p.Nombres AS NombrePaciente,
       a.FechaRegistro, a.Modalidad, a.IdConvenio, ISNULL(c.Institucion, '') AS NombreConvenio,
       a.Subtotal, a.Descuento, a.CostoTotal, a.Estado, a.MotivoAnulacion, a.NumeroTurno, a.FechaDerivacion,
       a.IdBox, ISNULL(b.Numero, '') AS NumeroBox, a.IdUsuarioRegistro, u.NombreCompleto AS NombreUsuarioRegistro,
       ISNULL((SELECT STRING_AGG(ex.Nombre, ', ') FROM AtencionExamen aex INNER JOIN Examen ex ON ex.IdExamen = aex.IdExamen
               WHERE aex.IdAtencion = a.IdAtencion), '') AS Examenes,
       ISNULL((SELECT TOP 1 cp.NumeroComprobante FROM Comprobante cp
               WHERE cp.IdAtencion = a.IdAtencion AND cp.Estado = N'Emitido' ORDER BY cp.IdComprobante DESC), '') AS NumeroComprobante,
       ISNULL((SELECT TOP 1 mp.Descripcion FROM Pago pg INNER JOIN MedioPago mp ON mp.IdMedioPago = pg.IdMedioPago
               WHERE pg.IdAtencion = a.IdAtencion AND pg.Estado <> N'Rechazado' ORDER BY pg.IdPago DESC), '') AS MedioPago,
       ISNULL((SELECT rc.Estado FROM ReporteClinico rc WHERE rc.IdAtencion = a.IdAtencion), '') AS EstadoReporte
FROM Atencion a
INNER JOIN Paciente p ON p.IdPaciente = a.IdPaciente
INNER JOIN Usuario u ON u.IdUsuario = a.IdUsuarioRegistro
LEFT JOIN Convenio c ON c.IdConvenio = a.IdConvenio
LEFT JOIN Box b ON b.IdBox = a.IdBox;
GO

CREATE OR ALTER VIEW vw_Visita AS
SELECT v.IdVisita, v.IdAtencion, v.Direccion, v.Referencia, v.Telefono, v.FechaProgramada, v.Estado, v.Motivo, v.IdTecnico,
       a.NumeroAtencion, a.NombrePaciente, a.Examenes, ISNULL(t.NombreCompleto, '') AS NombreTecnico,
       a.Estado AS EstadoAtencion, a.NumeroComprobante
FROM VisitaDomiciliaria v
INNER JOIN vw_Atencion a ON a.IdAtencion = v.IdAtencion
LEFT JOIN Usuario t ON t.IdUsuario = v.IdTecnico;
GO

CREATE OR ALTER VIEW vw_Evaluacion AS
SELECT ev.IdEvaluacion, ev.IdAtencion, ev.HorasAyuno, ev.Medicamentos, ev.RotuladoCorrecto, ev.RecipienteHermetico,
       ev.VolumenSuficiente, ev.ConservacionAdecuada, ev.Observaciones, ev.FechaObservacion, ev.Resultado, ev.FechaResultado,
       a.NumeroAtencion, a.NombrePaciente, u.NombreCompleto AS NombreEnfermera
FROM EvaluacionPreanalitica ev
INNER JOIN vw_Atencion a ON a.IdAtencion = ev.IdAtencion
INNER JOIN Usuario u ON u.IdUsuario = ev.IdUsuarioObservacion;
GO

CREATE OR ALTER VIEW vw_Suspension AS
SELECT s.IdSuspension, s.IdAtencion, s.Motivo, s.NuevaFecha, s.FechaRegistro, s.Reactivada, s.FechaReactivacion,
       a.NumeroAtencion, a.NombrePaciente, u.NombreCompleto AS NombreEnfermera
FROM Suspension s
INNER JOIN vw_Atencion a ON a.IdAtencion = s.IdAtencion
INNER JOIN Usuario u ON u.IdUsuario = s.IdUsuario;
GO

CREATE OR ALTER VIEW vw_Pago AS
SELECT pg.IdPago, pg.IdAtencion, pg.IdMedioPago, pg.Importe, pg.MontoRecibido, pg.Vuelto, pg.Estado, pg.FechaRegistro,
       pg.FechaConformidad, a.NumeroAtencion, a.NombrePaciente, m.Descripcion AS MedioPago, m.RequiereAutorizacion,
       u.NombreCompleto AS NombreCajero
FROM Pago pg
INNER JOIN vw_Atencion a ON a.IdAtencion = pg.IdAtencion
INNER JOIN MedioPago m ON m.IdMedioPago = pg.IdMedioPago
INNER JOIN Usuario u ON u.IdUsuario = pg.IdCajero;
GO

CREATE OR ALTER VIEW vw_Transferencia AS
SELECT t.IdTransferencia, t.IdPago, t.NumeroOperacion, t.Importe, t.FechaOperacion, t.Estado, t.Observacion, t.FechaRegistro,
       a.NumeroAtencion, a.NombrePaciente, u.NombreCompleto AS NombreSupervisor
FROM Transferencia t
INNER JOIN Pago pg ON pg.IdPago = t.IdPago
INNER JOIN vw_Atencion a ON a.IdAtencion = pg.IdAtencion
INNER JOIN Usuario u ON u.IdUsuario = t.IdSupervisor;
GO

CREATE OR ALTER VIEW vw_Comprobante AS
SELECT cp.IdComprobante, cp.NumeroComprobante, cp.IdAtencion, cp.IdPago, cp.FechaEmision, cp.Subtotal, cp.Descuento, cp.Total,
       cp.Estado, cp.MotivoAnulacion, a.NumeroAtencion, a.Dni, a.NombrePaciente, m.Descripcion AS MedioPago,
       u.NombreCompleto AS NombreCajero
FROM Comprobante cp
INNER JOIN vw_Atencion a ON a.IdAtencion = cp.IdAtencion
INNER JOIN Pago pg ON pg.IdPago = cp.IdPago
INNER JOIN MedioPago m ON m.IdMedioPago = pg.IdMedioPago
INNER JOIN Usuario u ON u.IdUsuario = cp.IdCajero;
GO

CREATE OR ALTER VIEW vw_Recaudacion AS
SELECT rc.IdRecaudacion, rc.IdComprobante, rc.Fecha, rc.Importe, rc.IdMedioPago, rc.Tipo, rc.FechaRegistro,
       cp.NumeroComprobante, a.NombrePaciente, m.Descripcion AS MedioPago, u.NombreCompleto AS NombreCajero
FROM Recaudacion rc
INNER JOIN Comprobante cp ON cp.IdComprobante = rc.IdComprobante
INNER JOIN vw_Atencion a ON a.IdAtencion = cp.IdAtencion
INNER JOIN MedioPago m ON m.IdMedioPago = rc.IdMedioPago
INNER JOIN Usuario u ON u.IdUsuario = rc.IdCajero;
GO

CREATE OR ALTER VIEW vw_Muestra AS
SELECT mu.IdMuestra, mu.IdAtencion, mu.Codigo, mu.FechaGeneracion, mu.HoraExtraccion, mu.FechaValidacion,
       mu.CondicionesDeclaradas, mu.RechazosOcurridos, mu.FechaIngreso, mu.EstadoConservacion, mu.MinutosCentrifugacion,
       mu.FechaAcondicionamiento, mu.FechaRecepcion, mu.Estado,
       a.NumeroAtencion, a.IdPaciente, a.NombrePaciente, a.Modalidad, a.Examenes,
       ISNULL((SELECT STRING_AGG(tb.Tipo + ' (' + tb.ColorTapa + ')', ', ') FROM Tubo tb
               WHERE tb.IdTubo IN (SELECT te.IdTubo FROM TuboExamen te INNER JOIN AtencionExamen ae ON ae.IdExamen = te.IdExamen
                                   WHERE ae.IdAtencion = mu.IdAtencion)), '') AS TubosEsperados,
       ISNULL(ur.NombreCompleto, ISNULL(ua.NombreCompleto, ISNULL(ui.NombreCompleto, ISNULL(ut.NombreCompleto, '')))) AS NombreResponsable,
       ISNULL(ua.NombreCompleto, '') AS NombreAcondiciona
FROM Muestra mu
INNER JOIN vw_Atencion a ON a.IdAtencion = mu.IdAtencion
LEFT JOIN Usuario ut ON ut.IdUsuario = mu.IdUsuarioToma
LEFT JOIN Usuario ui ON ui.IdUsuario = mu.IdUsuarioIngreso
LEFT JOIN Usuario ua ON ua.IdUsuario = mu.IdUsuarioAcondiciona
LEFT JOIN Usuario ur ON ur.IdUsuario = mu.IdUsuarioRecepcion;
GO

CREATE OR ALTER VIEW vw_Rechazo AS
SELECT rm.IdRechazo, rm.IdMuestra, rm.IdExamen, rm.IdTubo, rm.Motivo, rm.Observacion, rm.Fecha,
       mu.Codigo AS CodigoMuestra, a.NombrePaciente, ISNULL(e.Nombre, '') AS NombreExamen, u.NombreCompleto AS NombreTecnico
FROM RechazoMuestra rm
INNER JOIN Muestra mu ON mu.IdMuestra = rm.IdMuestra
INNER JOIN vw_Atencion a ON a.IdAtencion = mu.IdAtencion
LEFT JOIN Examen e ON e.IdExamen = rm.IdExamen
INNER JOIN Usuario u ON u.IdUsuario = rm.IdUsuario;
GO

CREATE OR ALTER VIEW vw_Resultado AS
SELECT r.IdResultado, r.IdAtencion, r.IdParametro, r.Valor, r.Estado, r.FechaRegistro, r.FechaEnvio, r.ObservacionMedico,
       r.FechaValidacion, a.NumeroAtencion, a.IdPaciente, a.NombrePaciente, pa.IdExamen, e.Nombre AS NombreExamen,
       pa.Nombre AS NombreParametro, pa.Unidad, t.NombreCompleto AS NombreTecnico, ISNULL(md.NombreCompleto, '') AS NombreMedico,
       (SELECT TOP 1 ra.Valor FROM ResultadoAnterior ra WHERE ra.IdResultado = r.IdResultado ORDER BY ra.IdResultadoAnterior DESC) AS ValorAnterior
FROM ResultadoAnalitico r
INNER JOIN vw_Atencion a ON a.IdAtencion = r.IdAtencion
INNER JOIN Parametro pa ON pa.IdParametro = r.IdParametro
INNER JOIN Examen e ON e.IdExamen = pa.IdExamen
INNER JOIN Usuario t ON t.IdUsuario = r.IdTecnico
LEFT JOIN Usuario md ON md.IdUsuario = r.IdMedico;
GO

CREATE OR ALTER VIEW vw_UsoEquipo AS
SELECT ue.IdUso, ue.IdEquipo, ue.IdMuestra, ue.HoraInicio, ue.RequiereNuevaCorrida, eq.Nombre AS NombreEquipo,
       mu.Codigo AS CodigoMuestra, t.NombreCompleto AS NombreTecnico,
       ISNULL((SELECT STRING_AGG(f.Descripcion, ' | ') FROM FallaAnalitica f WHERE f.IdUso = ue.IdUso), '') AS FallaAnalitica
FROM UsoEquipo ue
INNER JOIN Equipo eq ON eq.IdEquipo = ue.IdEquipo
INNER JOIN Muestra mu ON mu.IdMuestra = ue.IdMuestra
INNER JOIN Usuario t ON t.IdUsuario = ue.IdTecnico;
GO

CREATE OR ALTER VIEW vw_Reporte AS
SELECT rc.IdReporte, rc.IdAtencion, rc.Version, rc.Contenido, rc.Estado, rc.Definitivo, rc.FechaGeneracion, rc.FechaAutorizacion,
       a.NumeroAtencion, a.Dni, a.NombrePaciente, a.Examenes, a.Estado AS EstadoAtencion,
       dg.NombreCompleto AS NombreDigitador, ISNULL(dr.NombreCompleto, '') AS NombreDirector
FROM ReporteClinico rc
INNER JOIN vw_Atencion a ON a.IdAtencion = rc.IdAtencion
INNER JOIN Usuario dg ON dg.IdUsuario = rc.IdDigitador
LEFT JOIN Usuario dr ON dr.IdUsuario = rc.IdDirector;
GO

CREATE OR ALTER VIEW vw_Entrega AS
SELECT en.IdEntrega, en.IdReporte, en.NombreRecibe, en.DniRecibe, en.Relacion, en.FechaEntrega,
       a.IdAtencion, a.NumeroAtencion, a.NombrePaciente, a.Estado AS EstadoAtencion, u.NombreCompleto AS NombreUsuario
FROM Entrega en
INNER JOIN ReporteClinico rc ON rc.IdReporte = en.IdReporte
INNER JOIN vw_Atencion a ON a.IdAtencion = rc.IdAtencion
INNER JOIN Usuario u ON u.IdUsuario = en.IdUsuario;
GO

CREATE OR ALTER VIEW vw_Auditoria AS
SELECT au.IdAuditoria, au.Tabla, au.IdRegistro, au.Accion, au.Detalle, au.IdUsuario, u.NombreCompleto AS NombreUsuario,
       au.FechaHora
FROM Auditoria au
INNER JOIN Usuario u ON u.IdUsuario = au.IdUsuario;
GO

CREATE OR ALTER VIEW vw_MovimientoMuestra AS
SELECT mm.IdMovimiento, mm.IdMuestra, mm.TipoMovimiento, mm.FechaHora, mm.IdUsuario, mm.Detalle,
       mu.Codigo AS CodigoMuestra, a.NumeroAtencion, a.NombrePaciente, u.NombreCompleto AS NombreUsuario
FROM MovimientoMuestra mm
INNER JOIN Muestra mu ON mu.IdMuestra = mm.IdMuestra
INNER JOIN vw_Atencion a ON a.IdAtencion = mu.IdAtencion
INNER JOIN Usuario u ON u.IdUsuario = mm.IdUsuario;
GO

CREATE OR ALTER PROCEDURE usp_Usuario_ObtenerPorNombreUsuario @NombreUsuario NVARCHAR(30) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Usuario WHERE NombreUsuario = @NombreUsuario;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_ObtenerPorId @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Usuario WHERE IdUsuario = @IdUsuario;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Usuario
    WHERE NombreCompleto LIKE '%' + @Filtro + '%' OR Dni LIKE '%' + @Filtro + '%'
       OR NombreUsuario LIKE '%' + @Filtro + '%' OR NombreRol LIKE '%' + @Filtro + '%'
    ORDER BY NombreCompleto;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_ListarPorRol @Rol NVARCHAR(60) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Usuario WHERE NombreRol = @Rol AND Habilitado = 1 ORDER BY NombreCompleto;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_ExisteNombreUsuario @NombreUsuario NVARCHAR(30), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @NombreUsuario AND IdUsuario <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_ExisteDni @Dni CHAR(8), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Usuario WHERE Dni = @Dni AND IdUsuario <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_Insertar
    @NombreCompleto NVARCHAR(120), @Dni CHAR(8), @NombreUsuario NVARCHAR(30), @ClaveHash CHAR(64),
    @IdRol INT, @IdUsuarioRegistro INT, @Sal CHAR(32)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Usuario (NombreCompleto, Dni, NombreUsuario, ClaveHash, Sal, IdRol, Habilitado, IdUsuarioRegistro)
        VALUES (@NombreCompleto, @Dni, @NombreUsuario, @ClaveHash, @Sal, @IdRol, 1, @IdUsuarioRegistro);
        DECLARE @Id INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Usuario', @Id, N'Registro', @NombreUsuario, @IdUsuarioRegistro);
        COMMIT;
        SELECT @Id;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_Actualizar
    @IdUsuario INT, @NombreCompleto NVARCHAR(120), @Dni CHAR(8), @NombreUsuario NVARCHAR(30), @IdRol INT,
    @IdUsuarioAccion INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Usuario SET NombreCompleto = @NombreCompleto, Dni = @Dni, NombreUsuario = @NombreUsuario, IdRol = @IdRol
        WHERE IdUsuario = @IdUsuario;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Usuario', @IdUsuario, N'Modificación', @NombreUsuario, @IdUsuarioAccion);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_CambiarEstado
    @IdUsuario INT, @Habilitado BIT, @IdUsuarioAccion INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Usuario SET Habilitado = @Habilitado WHERE IdUsuario = @IdUsuario;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Usuario', @IdUsuario, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuarioAccion);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Usuario_CambiarClave
    @IdUsuario INT, @ClaveHash CHAR(64), @Sal CHAR(32)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Usuario SET ClaveHash = @ClaveHash, Sal = @Sal WHERE IdUsuario = @IdUsuario;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Usuario', @IdUsuario, N'Cambio de clave', NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Sesion_Registrar @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO RegistroSesion (IdUsuario) VALUES (@IdUsuario);
END
GO
CREATE OR ALTER PROCEDURE usp_Rol_Listar AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdRol, Nombre FROM Rol ORDER BY Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Auditoria_Consultar @Tabla NVARCHAR(50) = NULL, @IdRegistro INT = NULL, @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Auditoria
    WHERE (@Tabla IS NULL OR Tabla = @Tabla) AND (@IdRegistro IS NULL OR IdRegistro = @IdRegistro)
      AND CAST(FechaHora AS DATE) BETWEEN @Desde AND @Hasta
    ORDER BY FechaHora DESC, IdAuditoria DESC;
END
GO

CREATE OR ALTER PROCEDURE usp_Examen_Listar @Filtro NVARCHAR(100) = '', @SoloHabilitados BIT = 0 AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdExamen, Codigo, Nombre, TipoMuestra, Procedimiento, Tarifa, Habilitado FROM Examen
    WHERE (Codigo LIKE '%' + @Filtro + '%' OR Nombre LIKE '%' + @Filtro + '%') AND (@SoloHabilitados = 0 OR Habilitado = 1)
    ORDER BY Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Examen_ObtenerPorId @IdExamen INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdExamen, Codigo, Nombre, TipoMuestra, Procedimiento, Tarifa, Habilitado FROM Examen WHERE IdExamen = @IdExamen;
END
GO
CREATE OR ALTER PROCEDURE usp_Examen_ExisteCodigo @Codigo VARCHAR(10), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Examen WHERE Codigo = @Codigo AND IdExamen <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Examen_Insertar
    @Codigo VARCHAR(10), @Nombre NVARCHAR(100), @TipoMuestra NVARCHAR(20), @Procedimiento NVARCHAR(20),
    @Tarifa DECIMAL(10,2), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Examen (Codigo, Nombre, TipoMuestra, Procedimiento, Tarifa, IdUsuarioRegistro)
        VALUES (@Codigo, @Nombre, @TipoMuestra, @Procedimiento, @Tarifa, @IdUsuario);
        DECLARE @IdExamen INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Examen', @IdExamen, N'Registro', @Codigo + N' - ' + @Nombre, @IdUsuario);
        COMMIT;
        SELECT @IdExamen;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Examen_Actualizar
    @IdExamen INT, @Codigo VARCHAR(10), @Nombre NVARCHAR(100), @TipoMuestra NVARCHAR(20), @Procedimiento NVARCHAR(20),
    @Tarifa DECIMAL(10,2), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Examen SET Codigo = @Codigo, Nombre = @Nombre, TipoMuestra = @TipoMuestra, Procedimiento = @Procedimiento, Tarifa = @Tarifa
        WHERE IdExamen = @IdExamen;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Examen', @IdExamen, N'Modificación', @Codigo + N' - ' + @Nombre, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Examen_CambiarEstado
    @IdExamen INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Examen SET Habilitado = @Habilitado WHERE IdExamen = @IdExamen;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Examen', @IdExamen, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Convenio_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdConvenio, Institucion, PorcentajeDescuento, FechaInicio, FechaFin, Habilitado FROM Convenio
    WHERE Institucion LIKE '%' + @Filtro + '%' ORDER BY Institucion;
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_ListarVigentes AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdConvenio, Institucion, PorcentajeDescuento, FechaInicio, FechaFin, Habilitado FROM Convenio
    WHERE Habilitado = 1 AND CAST(GETDATE() AS DATE) BETWEEN FechaInicio AND FechaFin ORDER BY Institucion;
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_ObtenerPorId @IdConvenio INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdConvenio, Institucion, PorcentajeDescuento, FechaInicio, FechaFin, Habilitado FROM Convenio WHERE IdConvenio = @IdConvenio;
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_ExisteInstitucion @Institucion NVARCHAR(120), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Convenio WHERE Institucion = @Institucion AND Habilitado = 1 AND IdConvenio <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_Insertar
    @Institucion NVARCHAR(120), @PorcentajeDescuento DECIMAL(5,2), @FechaInicio DATE, @FechaFin DATE, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Convenio (Institucion, PorcentajeDescuento, FechaInicio, FechaFin, IdUsuarioRegistro)
        VALUES (@Institucion, @PorcentajeDescuento, @FechaInicio, @FechaFin, @IdUsuario);
        DECLARE @IdConvenio INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Convenio', @IdConvenio, N'Registro', @Institucion, @IdUsuario);
        COMMIT;
        SELECT @IdConvenio;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_Actualizar
    @IdConvenio INT, @Institucion NVARCHAR(120), @PorcentajeDescuento DECIMAL(5,2), @FechaInicio DATE, @FechaFin DATE, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Convenio SET Institucion = @Institucion, PorcentajeDescuento = @PorcentajeDescuento, FechaInicio = @FechaInicio, FechaFin = @FechaFin
        WHERE IdConvenio = @IdConvenio;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Convenio', @IdConvenio, N'Modificación', @Institucion, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Convenio_CambiarEstado
    @IdConvenio INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Convenio SET Habilitado = @Habilitado WHERE IdConvenio = @IdConvenio;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Convenio', @IdConvenio, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Condicion_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Condicion WHERE NombreExamen LIKE '%' + @Filtro + '%' ORDER BY NombreExamen;
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_ListarPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT c.* FROM vw_Condicion c
    INNER JOIN AtencionExamen ae ON ae.IdExamen = c.IdExamen
    WHERE ae.IdAtencion = @IdAtencion AND c.Habilitado = 1
    ORDER BY c.NombreExamen;
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_ObtenerPorId @IdCondicion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Condicion WHERE IdCondicion = @IdCondicion;
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_ExisteParaExamen @IdExamen INT, @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM CondicionPreanalitica WHERE IdExamen = @IdExamen AND Habilitado = 1 AND IdCondicion <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_Insertar
    @IdExamen INT, @HorasAyuno INT, @RestriccionMedicamentos NVARCHAR(200) = NULL, @MuestraQueDebeTraer NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO CondicionPreanalitica (IdExamen, HorasAyuno, RestriccionMedicamentos, MuestraQueDebeTraer, IdUsuarioRegistro)
        VALUES (@IdExamen, @HorasAyuno, @RestriccionMedicamentos, @MuestraQueDebeTraer, @IdUsuario);
        DECLARE @IdCondicion INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'CondicionPreanalitica', @IdCondicion, N'Registro', N'Examen ' + CAST(@IdExamen AS NVARCHAR(10)), @IdUsuario);
        COMMIT;
        SELECT @IdCondicion;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_Actualizar
    @IdCondicion INT, @IdExamen INT, @HorasAyuno INT, @RestriccionMedicamentos NVARCHAR(200) = NULL, @MuestraQueDebeTraer NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE CondicionPreanalitica SET IdExamen = @IdExamen, HorasAyuno = @HorasAyuno, RestriccionMedicamentos = @RestriccionMedicamentos, MuestraQueDebeTraer = @MuestraQueDebeTraer
        WHERE IdCondicion = @IdCondicion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'CondicionPreanalitica', @IdCondicion, N'Modificación', N'Examen ' + CAST(@IdExamen AS NVARCHAR(10)), @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Condicion_CambiarEstado
    @IdCondicion INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE CondicionPreanalitica SET Habilitado = @Habilitado WHERE IdCondicion = @IdCondicion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'CondicionPreanalitica', @IdCondicion, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_MedioPago_Listar @Filtro NVARCHAR(100) = '', @SoloHabilitados BIT = 0 AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdMedioPago, Codigo, Descripcion, RequiereAutorizacion, Habilitado FROM MedioPago
    WHERE (Codigo LIKE '%' + @Filtro + '%' OR Descripcion LIKE '%' + @Filtro + '%') AND (@SoloHabilitados = 0 OR Habilitado = 1)
    ORDER BY Descripcion;
END
GO
CREATE OR ALTER PROCEDURE usp_MedioPago_ObtenerPorId @IdMedioPago INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdMedioPago, Codigo, Descripcion, RequiereAutorizacion, Habilitado FROM MedioPago WHERE IdMedioPago = @IdMedioPago;
END
GO
CREATE OR ALTER PROCEDURE usp_MedioPago_ExisteCodigo @Codigo VARCHAR(10), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM MedioPago WHERE Codigo = @Codigo AND IdMedioPago <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_MedioPago_Insertar
    @Codigo VARCHAR(10), @Descripcion NVARCHAR(60), @RequiereAutorizacion BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO MedioPago (Codigo, Descripcion, RequiereAutorizacion, IdUsuarioRegistro)
        VALUES (@Codigo, @Descripcion, @RequiereAutorizacion, @IdUsuario);
        DECLARE @IdMedioPago INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'MedioPago', @IdMedioPago, N'Registro', @Codigo + N' - ' + @Descripcion, @IdUsuario);
        COMMIT;
        SELECT @IdMedioPago;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_MedioPago_Actualizar
    @IdMedioPago INT, @Codigo VARCHAR(10), @Descripcion NVARCHAR(60), @RequiereAutorizacion BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE MedioPago SET Codigo = @Codigo, Descripcion = @Descripcion, RequiereAutorizacion = @RequiereAutorizacion
        WHERE IdMedioPago = @IdMedioPago;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'MedioPago', @IdMedioPago, N'Modificación', @Codigo + N' - ' + @Descripcion, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_MedioPago_CambiarEstado
    @IdMedioPago INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE MedioPago SET Habilitado = @Habilitado WHERE IdMedioPago = @IdMedioPago;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'MedioPago', @IdMedioPago, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Tubo_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdTubo, Tipo, ColorTapa, Aditivo, MinutosCentrifugacion, Habilitado FROM Tubo
    WHERE Tipo LIKE '%' + @Filtro + '%' OR ColorTapa LIKE '%' + @Filtro + '%' ORDER BY Tipo;
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_ObtenerPorId @IdTubo INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdTubo, Tipo, ColorTapa, Aditivo, MinutosCentrifugacion, Habilitado FROM Tubo WHERE IdTubo = @IdTubo;
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_ListarExamenes @IdTubo INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdExamen FROM TuboExamen WHERE IdTubo = @IdTubo;
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_ExisteTipo @Tipo NVARCHAR(60), @IdExcluir INT, @ColorTapa NVARCHAR(30) = NULL, @Aditivo NVARCHAR(60) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Tubo
    WHERE Tipo = @Tipo AND IdTubo <> @IdExcluir
      AND (@ColorTapa IS NULL OR ColorTapa = @ColorTapa)
      AND (@ColorTapa IS NULL OR ISNULL(Aditivo, '') = ISNULL(@Aditivo, ''));
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_Insertar
    @Tipo NVARCHAR(60), @ColorTapa NVARCHAR(30), @Aditivo NVARCHAR(60) = NULL, @MinutosCentrifugacion INT,
    @IdExamenes VARCHAR(MAX), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Tubo (Tipo, ColorTapa, Aditivo, MinutosCentrifugacion, IdUsuarioRegistro)
        VALUES (@Tipo, @ColorTapa, @Aditivo, @MinutosCentrifugacion, @IdUsuario);
        DECLARE @IdTubo INT = SCOPE_IDENTITY();
        INSERT INTO TuboExamen (IdTubo, IdExamen)
        SELECT DISTINCT @IdTubo, CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '';
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Tubo', @IdTubo, N'Registro', @Tipo + N' (' + @ColorTapa + N')', @IdUsuario);
        COMMIT;
        SELECT @IdTubo;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_Actualizar
    @IdTubo INT, @Tipo NVARCHAR(60), @ColorTapa NVARCHAR(30), @Aditivo NVARCHAR(60) = NULL, @MinutosCentrifugacion INT,
    @IdExamenes VARCHAR(MAX), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Tubo SET Tipo = @Tipo, ColorTapa = @ColorTapa, Aditivo = @Aditivo, MinutosCentrifugacion = @MinutosCentrifugacion
        WHERE IdTubo = @IdTubo;
        DELETE FROM TuboExamen WHERE IdTubo = @IdTubo;
        INSERT INTO TuboExamen (IdTubo, IdExamen)
        SELECT DISTINCT @IdTubo, CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '';
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Tubo', @IdTubo, N'Modificación', @Tipo + N' (' + @ColorTapa + N')', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_CambiarEstado
    @IdTubo INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Tubo SET Habilitado = @Habilitado WHERE IdTubo = @IdTubo;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Tubo', @IdTubo, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Tubo_ListarRequeridosPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT e.IdExamen, e.Nombre AS NombreExamen, t.IdTubo, t.Tipo, t.ColorTapa, t.MinutosCentrifugacion
    FROM AtencionExamen ae
    INNER JOIN Examen e ON e.IdExamen = ae.IdExamen
    INNER JOIN TuboExamen te ON te.IdExamen = ae.IdExamen
    INNER JOIN Tubo t ON t.IdTubo = te.IdTubo AND t.Habilitado = 1
    WHERE ae.IdAtencion = @IdAtencion
    ORDER BY e.Nombre, t.Tipo;
END
GO

CREATE OR ALTER PROCEDURE usp_Box_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdBox, Numero, Descripcion, Habilitado FROM Box
    WHERE Numero LIKE '%' + @Filtro + '%' OR Descripcion LIKE '%' + @Filtro + '%' ORDER BY Numero;
END
GO
CREATE OR ALTER PROCEDURE usp_Box_ListarLibres AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdBox, Numero, Descripcion, Habilitado FROM Box
    WHERE Habilitado = 1
      AND IdBox NOT IN (SELECT IdBox FROM Atencion WHERE IdBox IS NOT NULL AND Estado = N'En toma de muestra')
    ORDER BY Numero;
END
GO
CREATE OR ALTER PROCEDURE usp_Box_ObtenerPorId @IdBox INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdBox, Numero, Descripcion, Habilitado FROM Box WHERE IdBox = @IdBox;
END
GO
CREATE OR ALTER PROCEDURE usp_Box_ExisteNumero @Numero VARCHAR(10), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Box WHERE Numero = @Numero AND IdBox <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Box_EstaEnUso @IdBox INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Atencion WHERE IdBox = @IdBox AND Estado = N'En toma de muestra';
END
GO
CREATE OR ALTER PROCEDURE usp_Box_Insertar
    @Numero VARCHAR(10), @Descripcion NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Box (Numero, Descripcion, IdUsuarioRegistro)
        VALUES (@Numero, @Descripcion, @IdUsuario);
        DECLARE @IdBox INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Box', @IdBox, N'Registro', N'Box ' + @Numero, @IdUsuario);
        COMMIT;
        SELECT @IdBox;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Box_Actualizar
    @IdBox INT, @Numero VARCHAR(10), @Descripcion NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Box SET Numero = @Numero, Descripcion = @Descripcion
        WHERE IdBox = @IdBox;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Box', @IdBox, N'Modificación', N'Box ' + @Numero, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Box_CambiarEstado
    @IdBox INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        IF @Habilitado = 0 AND EXISTS (SELECT 1 FROM Atencion WHERE IdBox = @IdBox AND Estado = N'En toma de muestra')
            THROW 50001, N'El box está asignado a una atención en toma de muestra; no se puede inhabilitar.', 1;
        UPDATE Box SET Habilitado = @Habilitado WHERE IdBox = @IdBox;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Box', @IdBox, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Equipo_Listar @Filtro NVARCHAR(100) = '', @SoloHabilitados BIT = 0 AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdEquipo, Codigo, Nombre, Marca, Modelo, Tipo, Habilitado FROM Equipo
    WHERE (Codigo LIKE '%' + @Filtro + '%' OR Nombre LIKE '%' + @Filtro + '%' OR Marca LIKE '%' + @Filtro + '%')
      AND (@SoloHabilitados = 0 OR Habilitado = 1)
    ORDER BY Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Equipo_ObtenerPorId @IdEquipo INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdEquipo, Codigo, Nombre, Marca, Modelo, Tipo, Habilitado FROM Equipo WHERE IdEquipo = @IdEquipo;
END
GO
CREATE OR ALTER PROCEDURE usp_Equipo_ExisteCodigo @Codigo VARCHAR(10), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Equipo WHERE Codigo = @Codigo AND IdEquipo <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Equipo_Insertar
    @Codigo VARCHAR(10), @Nombre NVARCHAR(100), @Marca NVARCHAR(60) = NULL, @Modelo NVARCHAR(60) = NULL, @Tipo NVARCHAR(20), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Equipo (Codigo, Nombre, Marca, Modelo, Tipo, IdUsuarioRegistro)
        VALUES (@Codigo, @Nombre, @Marca, @Modelo, @Tipo, @IdUsuario);
        DECLARE @IdEquipo INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Equipo', @IdEquipo, N'Registro', @Codigo + N' - ' + @Nombre, @IdUsuario);
        COMMIT;
        SELECT @IdEquipo;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Equipo_Actualizar
    @IdEquipo INT, @Codigo VARCHAR(10), @Nombre NVARCHAR(100), @Marca NVARCHAR(60) = NULL, @Modelo NVARCHAR(60) = NULL, @Tipo NVARCHAR(20), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Equipo SET Codigo = @Codigo, Nombre = @Nombre, Marca = @Marca, Modelo = @Modelo, Tipo = @Tipo
        WHERE IdEquipo = @IdEquipo;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Equipo', @IdEquipo, N'Modificación', @Codigo + N' - ' + @Nombre, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Equipo_CambiarEstado
    @IdEquipo INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Equipo SET Habilitado = @Habilitado WHERE IdEquipo = @IdEquipo;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Equipo', @IdEquipo, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Parametro_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Parametro
    WHERE Nombre LIKE '%' + @Filtro + '%' OR NombreExamen LIKE '%' + @Filtro + '%'
    ORDER BY NombreExamen, Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_ListarPorExamen @IdExamen INT, @SoloHabilitados BIT = 1 AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Parametro WHERE IdExamen = @IdExamen AND (@SoloHabilitados = 0 OR Habilitado = 1) ORDER BY IdParametro;
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_ObtenerPorId @IdParametro INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Parametro WHERE IdParametro = @IdParametro;
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_ExisteNombre @IdExamen INT, @Nombre NVARCHAR(100), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Parametro WHERE IdExamen = @IdExamen AND Nombre = @Nombre AND IdParametro <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_Insertar
    @IdExamen INT, @Nombre NVARCHAR(100), @Unidad NVARCHAR(20) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Parametro (IdExamen, Nombre, Unidad, IdUsuarioRegistro)
        VALUES (@IdExamen, @Nombre, @Unidad, @IdUsuario);
        DECLARE @IdParametro INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Parametro', @IdParametro, N'Registro', @Nombre, @IdUsuario);
        COMMIT;
        SELECT @IdParametro;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_Actualizar
    @IdParametro INT, @IdExamen INT, @Nombre NVARCHAR(100), @Unidad NVARCHAR(20) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Parametro SET IdExamen = @IdExamen, Nombre = @Nombre, Unidad = @Unidad
        WHERE IdParametro = @IdParametro;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Parametro', @IdParametro, N'Modificación', @Nombre, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Parametro_CambiarEstado
    @IdParametro INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Parametro SET Habilitado = @Habilitado WHERE IdParametro = @IdParametro;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Parametro', @IdParametro, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Plantilla_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Plantilla WHERE Nombre LIKE '%' + @Filtro + '%' ORDER BY Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_ObtenerPorId @IdPlantilla INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Plantilla WHERE IdPlantilla = @IdPlantilla;
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_ListarExamenes @IdPlantilla INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdExamen FROM PlantillaExamen WHERE IdPlantilla = @IdPlantilla;
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_ObtenerPorExamen @IdExamen INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 * FROM vw_Plantilla
    WHERE Habilitado = 1 AND IdPlantilla IN (SELECT IdPlantilla FROM PlantillaExamen WHERE IdExamen = @IdExamen)
    ORDER BY IdPlantilla;
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_ExisteNombre @Nombre NVARCHAR(100), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Plantilla WHERE Nombre = @Nombre AND IdPlantilla <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_ExamenesEnOtraPlantilla @IdExamenes VARCHAR(MAX), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(STRING_AGG(e.Nombre + N' (' + p.Nombre + N')', N', '), N'')
    FROM PlantillaExamen pe
    INNER JOIN Plantilla p ON p.IdPlantilla = pe.IdPlantilla AND p.Habilitado = 1
    INNER JOIN Examen e ON e.IdExamen = pe.IdExamen
    WHERE pe.IdPlantilla <> @IdExcluir
      AND pe.IdExamen IN (SELECT CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '');
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_Insertar
    @Nombre NVARCHAR(100), @Formato NVARCHAR(260), @IdExamenes VARCHAR(MAX), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Plantilla (Nombre, Formato, IdUsuarioRegistro)
        VALUES (@Nombre, @Formato, @IdUsuario);
        DECLARE @IdPlantilla INT = SCOPE_IDENTITY();
        INSERT INTO PlantillaExamen (IdPlantilla, IdExamen)
        SELECT DISTINCT @IdPlantilla, CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '';
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Plantilla', @IdPlantilla, N'Registro', @Nombre, @IdUsuario);
        COMMIT;
        SELECT @IdPlantilla;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_Actualizar
    @IdPlantilla INT, @Nombre NVARCHAR(100), @Formato NVARCHAR(260), @IdExamenes VARCHAR(MAX), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Plantilla SET Nombre = @Nombre, Formato = @Formato
        WHERE IdPlantilla = @IdPlantilla;
        DELETE FROM PlantillaExamen WHERE IdPlantilla = @IdPlantilla;
        INSERT INTO PlantillaExamen (IdPlantilla, IdExamen)
        SELECT DISTINCT @IdPlantilla, CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '';
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Plantilla', @IdPlantilla, N'Modificación', @Nombre, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Plantilla_CambiarEstado
    @IdPlantilla INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        IF @Habilitado = 1 AND EXISTS (
            SELECT 1 FROM PlantillaExamen pe
            INNER JOIN PlantillaExamen otra ON otra.IdExamen = pe.IdExamen AND otra.IdPlantilla <> pe.IdPlantilla
            INNER JOIN Plantilla p ON p.IdPlantilla = otra.IdPlantilla AND p.Habilitado = 1
            WHERE pe.IdPlantilla = @IdPlantilla)
            THROW 50002, N'Uno de los exámenes de la plantilla ya está asociado a otra plantilla habilitada.', 1;
        UPDATE Plantilla SET Habilitado = @Habilitado WHERE IdPlantilla = @IdPlantilla;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Plantilla', @IdPlantilla, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Intervalo_Listar @Filtro NVARCHAR(100) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Intervalo
    WHERE NombreParametro LIKE '%' + @Filtro + '%' OR NombreExamen LIKE '%' + @Filtro + '%'
    ORDER BY NombreExamen, NombreParametro, Sexo, EdadMinima;
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_ListarPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Intervalo
    WHERE Habilitado = 1 AND IdParametro IN (SELECT IdParametro FROM ResultadoAnalitico WHERE IdAtencion = @IdAtencion);
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_ObtenerPorId @IdIntervalo INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Intervalo WHERE IdIntervalo = @IdIntervalo;
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_ExisteSuperposicion @IdParametro INT, @Sexo NVARCHAR(10), @EdadMinima INT, @EdadMaxima INT, @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM IntervaloReferencia
    WHERE IdParametro = @IdParametro AND IdIntervalo <> @IdExcluir AND Habilitado = 1
      AND (Sexo = @Sexo OR Sexo = N'Ambos' OR @Sexo = N'Ambos')
      AND EdadMinima <= @EdadMaxima AND EdadMaxima >= @EdadMinima;
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_Insertar
    @IdParametro INT, @ValorMinimo DECIMAL(12,3) = NULL, @ValorMaximo DECIMAL(12,3) = NULL, @Sexo NVARCHAR(10),
    @EdadMinima INT, @EdadMaxima INT, @ReferenciaTexto NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO IntervaloReferencia (IdParametro, ValorMinimo, ValorMaximo, Sexo, EdadMinima, EdadMaxima, ReferenciaTexto, IdUsuarioRegistro)
        VALUES (@IdParametro, @ValorMinimo, @ValorMaximo, @Sexo, @EdadMinima, @EdadMaxima, @ReferenciaTexto, @IdUsuario);
        DECLARE @IdIntervalo INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'IntervaloReferencia', @IdIntervalo, N'Registro', N'Parámetro ' + CAST(@IdParametro AS NVARCHAR(10)) + N', ' + @Sexo + N', ' + CAST(@EdadMinima AS NVARCHAR(3)) + N'-' + CAST(@EdadMaxima AS NVARCHAR(3)) + N' años', @IdUsuario);
        COMMIT;
        SELECT @IdIntervalo;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_Actualizar
    @IdIntervalo INT, @IdParametro INT, @ValorMinimo DECIMAL(12,3) = NULL, @ValorMaximo DECIMAL(12,3) = NULL, @Sexo NVARCHAR(10),
    @EdadMinima INT, @EdadMaxima INT, @ReferenciaTexto NVARCHAR(100) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE IntervaloReferencia SET IdParametro = @IdParametro, ValorMinimo = @ValorMinimo, ValorMaximo = @ValorMaximo, Sexo = @Sexo, EdadMinima = @EdadMinima, EdadMaxima = @EdadMaxima, ReferenciaTexto = @ReferenciaTexto
        WHERE IdIntervalo = @IdIntervalo;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'IntervaloReferencia', @IdIntervalo, N'Modificación', N'Parámetro ' + CAST(@IdParametro AS NVARCHAR(10)) + N', ' + @Sexo + N', ' + CAST(@EdadMinima AS NVARCHAR(3)) + N'-' + CAST(@EdadMaxima AS NVARCHAR(3)) + N' años', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Intervalo_CambiarEstado
    @IdIntervalo INT, @Habilitado BIT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        IF @Habilitado = 1 AND EXISTS (
            SELECT 1 FROM IntervaloReferencia i
            INNER JOIN IntervaloReferencia otro ON otro.IdParametro = i.IdParametro AND otro.IdIntervalo <> i.IdIntervalo AND otro.Habilitado = 1
               AND (otro.Sexo = i.Sexo OR otro.Sexo = N'Ambos' OR i.Sexo = N'Ambos')
               AND otro.EdadMinima <= i.EdadMaxima AND otro.EdadMaxima >= i.EdadMinima
            WHERE i.IdIntervalo = @IdIntervalo)
            THROW 50003, N'El intervalo se superpone con otro intervalo habilitado del mismo parámetro y sexo.', 1;
        UPDATE IntervaloReferencia SET Habilitado = @Habilitado WHERE IdIntervalo = @IdIntervalo;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'IntervaloReferencia', @IdIntervalo, CASE WHEN @Habilitado = 1 THEN N'Habilitación' ELSE N'Inhabilitación' END, NULL, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Paciente_ObtenerPorDni @Dni CHAR(8) AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdPaciente, Dni, Nombres, Apellidos, FechaNacimiento, Sexo, Direccion, Telefono FROM Paciente WHERE Dni = @Dni;
END
GO
CREATE OR ALTER PROCEDURE usp_Paciente_ObtenerPorId @IdPaciente INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdPaciente, Dni, Nombres, Apellidos, FechaNacimiento, Sexo, Direccion, Telefono FROM Paciente WHERE IdPaciente = @IdPaciente;
END
GO
CREATE OR ALTER PROCEDURE usp_Paciente_ExisteDni @Dni CHAR(8), @IdExcluir INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) FROM Paciente WHERE Dni = @Dni AND IdPaciente <> @IdExcluir;
END
GO
CREATE OR ALTER PROCEDURE usp_Paciente_Insertar
    @Dni CHAR(8), @Nombres NVARCHAR(80), @Apellidos NVARCHAR(80), @FechaNacimiento DATE, @Sexo NVARCHAR(10),
    @Direccion NVARCHAR(150) = NULL, @Telefono VARCHAR(9) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Paciente (Dni, Nombres, Apellidos, FechaNacimiento, Sexo, Direccion, Telefono, IdUsuarioRegistro)
        VALUES (@Dni, @Nombres, @Apellidos, @FechaNacimiento, @Sexo, @Direccion, @Telefono, @IdUsuario);
        DECLARE @IdPaciente INT = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Paciente', @IdPaciente, N'Registro', N'DNI ' + @Dni, @IdUsuario);
        COMMIT;
        SELECT @IdPaciente;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Paciente_Actualizar
    @IdPaciente INT, @Nombres NVARCHAR(80), @Apellidos NVARCHAR(80), @FechaNacimiento DATE, @Sexo NVARCHAR(10),
    @Direccion NVARCHAR(150) = NULL, @Telefono VARCHAR(9) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Paciente SET Nombres = @Nombres, Apellidos = @Apellidos, FechaNacimiento = @FechaNacimiento, Sexo = @Sexo,
               Direccion = @Direccion, Telefono = @Telefono, IdUsuarioModificacion = @IdUsuario, FechaModificacion = GETDATE()
        WHERE IdPaciente = @IdPaciente;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Paciente', @IdPaciente, N'Modificación', N'Datos de filiación', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Atencion_ObtenerPorId @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ObtenerPorNumero @NumeroAtencion VARCHAR(12) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion WHERE NumeroAtencion = @NumeroAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarPorEstado @Estado NVARCHAR(40) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion WHERE Estado = @Estado ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarEnEsperaPorTurno AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion WHERE Estado = N'En espera de toma de muestra' ORDER BY NumeroTurno;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarPorPaciente @IdPaciente INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion WHERE IdPaciente = @IdPaciente ORDER BY FechaRegistro DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_Consultar @Desde DATE, @Hasta DATE, @Estado NVARCHAR(40) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion
    WHERE CAST(FechaRegistro AS DATE) BETWEEN @Desde AND @Hasta AND (@Estado IS NULL OR Estado = @Estado)
    ORDER BY FechaRegistro DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarPagadas @ConComprobante BIT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion
    WHERE Estado = N'Pagada'
      AND ((@ConComprobante = 1 AND NumeroComprobante <> '') OR (@ConComprobante = 0 AND NumeroComprobante = ''))
    ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarPorEstadoReporte @Estado NVARCHAR(40), @EstadosReporte NVARCHAR(1000) = '' AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Atencion
    WHERE Estado = @Estado
      AND (@EstadosReporte = '' OR EstadoReporte = '' OR EstadoReporte IN (SELECT value FROM STRING_SPLIT(@EstadosReporte, '|')))
    ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_ListarDetalle @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT ae.IdAtencion, ae.IdExamen, e.Codigo, e.Nombre AS NombreExamen, e.TipoMuestra, e.Procedimiento,
           ae.Tarifa, ae.ObservacionesMicroscopicas
    FROM AtencionExamen ae
    INNER JOIN Examen e ON e.IdExamen = ae.IdExamen
    WHERE ae.IdAtencion = @IdAtencion
    ORDER BY e.Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_Insertar
    @IdPaciente INT, @Modalidad NVARCHAR(15), @IdConvenio INT = NULL, @Subtotal DECIMAL(10,2), @Descuento DECIMAL(10,2),
    @CostoTotal DECIMAL(10,2), @Estado NVARCHAR(40), @IdUsuario INT, @IdExamenes VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Atencion (IdPaciente, Modalidad, IdConvenio, Subtotal, Descuento, CostoTotal, Estado, IdUsuarioRegistro)
        VALUES (@IdPaciente, @Modalidad, @IdConvenio, @Subtotal, @Descuento, @CostoTotal, @Estado, @IdUsuario);
        DECLARE @IdAtencion INT = SCOPE_IDENTITY();

        INSERT INTO AtencionExamen (IdAtencion, IdExamen, Tarifa)
        SELECT @IdAtencion, e.IdExamen, e.Tarifa
        FROM Examen e
        WHERE e.IdExamen IN (SELECT CAST(value AS INT) FROM STRING_SPLIT(@IdExamenes, ',') WHERE LTRIM(value) <> '');

        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Registro', @Estado, @IdUsuario);
        COMMIT;
        SELECT @IdAtencion;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_CambiarEstado
    @IdAtencion INT, @Estado NVARCHAR(40), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Atencion SET Estado = @Estado WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', @Estado, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_Anular
    @IdAtencion INT, @Motivo NVARCHAR(200), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Atencion SET Estado = N'Anulada', MotivoAnulacion = @Motivo WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Anulación', @Motivo, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_AsignarTurno
    @IdAtencion INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @Turno INT;
        SELECT @Turno = ISNULL(MAX(NumeroTurno), 0) + 1 FROM Atencion WITH (UPDLOCK, HOLDLOCK)
        WHERE CAST(FechaDerivacion AS DATE) = CAST(GETDATE() AS DATE);

        UPDATE Atencion SET NumeroTurno = @Turno, FechaDerivacion = GETDATE(), Estado = N'En espera de toma de muestra'
        WHERE IdAtencion = @IdAtencion;
        DECLARE @Detalle NVARCHAR(500) = N'En espera de toma de muestra - turno ' + CAST(@Turno AS NVARCHAR(10));
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', @Detalle, @IdUsuario);
        COMMIT;
        SELECT @Turno;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_AsignarTecnico
    @IdAtencion INT, @IdTecnico INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE VisitaDomiciliaria SET IdTecnico = @IdTecnico WHERE IdAtencion = @IdAtencion;
        UPDATE Atencion SET FechaDerivacion = GETDATE(), Estado = N'Visita asignada' WHERE IdAtencion = @IdAtencion;
        DECLARE @Detalle NVARCHAR(500) = N'Visita asignada - técnico ' + CAST(@IdTecnico AS NVARCHAR(10));
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', @Detalle, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_AsignarBox
    @IdAtencion INT, @IdBox INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Atencion SET IdBox = @IdBox, Estado = N'En toma de muestra' WHERE IdAtencion = @IdAtencion;
        DECLARE @Detalle NVARCHAR(500) = N'En toma de muestra - box ' + (SELECT Numero FROM Box WHERE IdBox = @IdBox);
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', @Detalle, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Atencion_GuardarObservacionesMicroscopicas
    @IdAtencion INT, @IdExamen INT, @Observaciones NVARCHAR(500) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE AtencionExamen SET ObservacionesMicroscopicas = @Observaciones WHERE IdAtencion = @IdAtencion AND IdExamen = @IdExamen;
        DECLARE @Detalle NVARCHAR(500) = N'Observaciones microscópicas del examen ' + CAST(@IdExamen AS NVARCHAR(10));
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Modificación', @Detalle, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Visita_ObtenerPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Visita WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_ListarPorFecha @Fecha DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Visita WHERE FechaProgramada = @Fecha ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_ListarAsignadas @IdTecnico INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Visita
    WHERE IdTecnico = @IdTecnico AND EstadoAtencion = N'Visita asignada' AND Estado IN (N'Programada', N'Reprogramada')
    ORDER BY FechaProgramada;
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_ListarDelDia @IdTecnico INT, @Fecha DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Visita
    WHERE IdTecnico = @IdTecnico AND FechaProgramada = @Fecha AND EstadoAtencion = N'Visita asignada'
      AND Estado IN (N'Programada', N'Reprogramada')
    ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_Insertar
    @IdAtencion INT, @Direccion NVARCHAR(150), @Referencia NVARCHAR(150) = NULL, @Telefono VARCHAR(9), @FechaProgramada DATE,
    @Estado NVARCHAR(20), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO VisitaDomiciliaria (IdAtencion, Direccion, Referencia, Telefono, FechaProgramada, Estado, IdUsuarioRegistro)
        VALUES (@IdAtencion, @Direccion, @Referencia, @Telefono, @FechaProgramada, @Estado, @IdUsuario);
        DECLARE @IdVisita INT = SCOPE_IDENTITY();
        DECLARE @Detalle NVARCHAR(500) = @Estado + N' para el ' + CONVERT(NVARCHAR(10), @FechaProgramada, 103);
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'VisitaDomiciliaria', @IdVisita, N'Registro', @Detalle, @IdUsuario);
        COMMIT;
        SELECT @IdVisita;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_Actualizar
    @IdVisita INT, @Direccion NVARCHAR(150), @Referencia NVARCHAR(150) = NULL, @Telefono VARCHAR(9), @FechaProgramada DATE,
    @Estado NVARCHAR(20), @Motivo NVARCHAR(200) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE VisitaDomiciliaria SET Direccion = @Direccion, Referencia = @Referencia, Telefono = @Telefono,
               FechaProgramada = @FechaProgramada, Estado = @Estado, Motivo = @Motivo
        WHERE IdVisita = @IdVisita;
        DECLARE @Detalle NVARCHAR(500) = @Estado + N' para el ' + CONVERT(NVARCHAR(10), @FechaProgramada, 103) + ISNULL(N': ' + @Motivo, N'');
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'VisitaDomiciliaria', @IdVisita, N'Modificación', @Detalle, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Visita_CambiarEstado
    @IdVisita INT, @Estado NVARCHAR(20), @Motivo NVARCHAR(200) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE VisitaDomiciliaria SET Estado = @Estado, Motivo = @Motivo WHERE IdVisita = @IdVisita;
        DECLARE @Detalle NVARCHAR(500) = @Estado + ISNULL(N': ' + @Motivo, N'');
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'VisitaDomiciliaria', @IdVisita, N'Cambio de estado', @Detalle, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Evaluacion_ObtenerPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Evaluacion WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Evaluacion_GuardarObservaciones
    @IdAtencion INT, @HorasAyuno INT, @Medicamentos NVARCHAR(200) = NULL, @RotuladoCorrecto BIT = NULL,
    @RecipienteHermetico BIT = NULL, @VolumenSuficiente BIT = NULL, @ConservacionAdecuada BIT = NULL,
    @Observaciones NVARCHAR(500) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM EvaluacionPreanalitica WHERE IdAtencion = @IdAtencion)
        UPDATE EvaluacionPreanalitica SET HorasAyuno = @HorasAyuno, Medicamentos = @Medicamentos, RotuladoCorrecto = @RotuladoCorrecto,
               RecipienteHermetico = @RecipienteHermetico, VolumenSuficiente = @VolumenSuficiente,
               ConservacionAdecuada = @ConservacionAdecuada, Observaciones = @Observaciones, IdUsuarioObservacion = @IdUsuario,
               FechaObservacion = GETDATE(), Resultado = NULL, IdUsuarioResultado = NULL, FechaResultado = NULL
        WHERE IdAtencion = @IdAtencion;
    ELSE
        INSERT INTO EvaluacionPreanalitica (IdAtencion, HorasAyuno, Medicamentos, RotuladoCorrecto, RecipienteHermetico,
               VolumenSuficiente, ConservacionAdecuada, Observaciones, IdUsuarioObservacion)
        VALUES (@IdAtencion, @HorasAyuno, @Medicamentos, @RotuladoCorrecto, @RecipienteHermetico,
               @VolumenSuficiente, @ConservacionAdecuada, @Observaciones, @IdUsuario);
END
GO
CREATE OR ALTER PROCEDURE usp_Evaluacion_RegistrarApto
    @IdAtencion INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE EvaluacionPreanalitica SET Resultado = N'Apto', IdUsuarioResultado = @IdUsuario, FechaResultado = GETDATE()
        WHERE IdAtencion = @IdAtencion;
        UPDATE Atencion SET Estado = N'Pendiente de pago' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pendiente de pago', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Evaluacion_Suspender
    @IdAtencion INT, @Motivo NVARCHAR(300), @NuevaFecha DATE, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE EvaluacionPreanalitica SET Resultado = N'No apto', IdUsuarioResultado = @IdUsuario, FechaResultado = GETDATE()
        WHERE IdAtencion = @IdAtencion;
        INSERT INTO Suspension (IdAtencion, Motivo, NuevaFecha, IdUsuario) VALUES (@IdAtencion, @Motivo, @NuevaFecha, @IdUsuario);
        UPDATE Atencion SET Estado = N'Suspendida' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Suspendida: ' + @Motivo, @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Suspension_Consultar @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Suspension
    WHERE CAST(FechaRegistro AS DATE) BETWEEN @Desde AND @Hasta AND Reactivada = 0
    ORDER BY NuevaFecha;
END
GO
CREATE OR ALTER PROCEDURE usp_Suspension_ObtenerPorId @IdSuspension INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Suspension WHERE IdSuspension = @IdSuspension;
END
GO
CREATE OR ALTER PROCEDURE usp_Suspension_Reactivar
    @IdSuspension INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM Suspension WHERE IdSuspension = @IdSuspension);
        UPDATE Suspension SET Reactivada = 1, IdUsuarioReactiva = @IdUsuario, FechaReactivacion = GETDATE()
        WHERE IdSuspension = @IdSuspension;
        UPDATE Atencion SET Estado = N'Pendiente de evaluación' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pendiente de evaluación (reactivada)', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_Pago_ObtenerVigente @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 * FROM vw_Pago WHERE IdAtencion = @IdAtencion AND Estado <> N'Rechazado' ORDER BY IdPago DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Pago_ObtenerPorId @IdPago INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Pago WHERE IdPago = @IdPago;
END
GO
CREATE OR ALTER PROCEDURE usp_Pago_ListarPendientesAutorizacion AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Pago WHERE Estado = N'Pendiente de autorización' ORDER BY FechaRegistro;
END
GO
CREATE OR ALTER PROCEDURE usp_Pago_RegistrarConforme
    @IdAtencion INT, @IdMedioPago INT, @Importe DECIMAL(10,2), @MontoRecibido DECIMAL(10,2), @Vuelto DECIMAL(10,2), @IdCajero INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Pago (IdAtencion, IdMedioPago, Importe, MontoRecibido, Vuelto, Estado, IdCajero, FechaConformidad)
        VALUES (@IdAtencion, @IdMedioPago, @Importe, @MontoRecibido, @Vuelto, N'Conforme', @IdCajero, GETDATE());
        DECLARE @IdPago INT = SCOPE_IDENTITY();
        UPDATE Atencion SET Estado = N'Pagada' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pagada', @IdCajero);
        COMMIT;
        SELECT @IdPago;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Pago_RegistrarPendiente @IdAtencion INT, @IdMedioPago INT, @Importe DECIMAL(10,2), @IdCajero INT AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Pago (IdAtencion, IdMedioPago, Importe, Estado, IdCajero)
    VALUES (@IdAtencion, @IdMedioPago, @Importe, N'Pendiente de autorización', @IdCajero);
    SELECT CAST(SCOPE_IDENTITY() AS INT);
END
GO
CREATE OR ALTER PROCEDURE usp_Pago_RegistrarConformidad
    @IdPago INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM Pago WHERE IdPago = @IdPago);
        UPDATE Pago SET Estado = N'Conforme', FechaConformidad = GETDATE() WHERE IdPago = @IdPago;
        UPDATE Atencion SET Estado = N'Pagada' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pagada (transferencia autorizada)', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Transferencia_Registrar
    @IdPago INT, @NumeroOperacion VARCHAR(30) = NULL, @Importe DECIMAL(10,2) = NULL, @FechaOperacion DATE = NULL,
    @Estado NVARCHAR(15), @Observacion NVARCHAR(300) = NULL, @IdSupervisor INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Transferencia (IdPago, NumeroOperacion, Importe, FechaOperacion, Estado, Observacion, IdSupervisor)
        VALUES (@IdPago, @NumeroOperacion, @Importe, @FechaOperacion, @Estado, @Observacion, @IdSupervisor);
        UPDATE Pago SET Estado = CASE WHEN @Estado = N'Autorizada' THEN N'Autorizado' ELSE N'Rechazado' END
        WHERE IdPago = @IdPago;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Transferencia_ConsultarAutorizadas @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Transferencia
    WHERE Estado = N'Autorizada' AND CAST(FechaRegistro AS DATE) BETWEEN @Desde AND @Hasta
    ORDER BY FechaRegistro DESC;
END
GO

CREATE OR ALTER PROCEDURE usp_Comprobante_ObtenerPorId @IdComprobante INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Comprobante WHERE IdComprobante = @IdComprobante;
END
GO
CREATE OR ALTER PROCEDURE usp_Comprobante_ObtenerPorNumero @NumeroComprobante VARCHAR(15) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Comprobante WHERE NumeroComprobante = @NumeroComprobante;
END
GO
CREATE OR ALTER PROCEDURE usp_Comprobante_ObtenerEmitidoPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Comprobante WHERE IdAtencion = @IdAtencion AND Estado = N'Emitido';
END
GO
CREATE OR ALTER PROCEDURE usp_Comprobante_Consultar @Desde DATE, @Hasta DATE, @Dni CHAR(8) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Comprobante
    WHERE CAST(FechaEmision AS DATE) BETWEEN @Desde AND @Hasta AND (@Dni IS NULL OR Dni = @Dni)
    ORDER BY FechaEmision DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Comprobante_Emitir
    @IdAtencion INT, @IdPago INT, @Subtotal DECIMAL(10,2), @Descuento DECIMAL(10,2), @Total DECIMAL(10,2),
    @IdMedioPago INT, @IdCajero INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @c TABLE (Serie VARCHAR(10), Ultimo INT);
        UPDATE Correlativo SET Ultimo = Ultimo + 1 OUTPUT inserted.Serie, inserted.Ultimo INTO @c WHERE Tipo = 'COMPROBANTE';

        DECLARE @Numero VARCHAR(15);
        SELECT @Numero = Serie + '-' + RIGHT('000000' + CAST(Ultimo AS VARCHAR(10)), 6) FROM @c;

        INSERT INTO Comprobante (NumeroComprobante, IdAtencion, IdPago, Subtotal, Descuento, Total, IdCajero)
        VALUES (@Numero, @IdAtencion, @IdPago, @Subtotal, @Descuento, @Total, @IdCajero);
        DECLARE @IdComprobante INT = SCOPE_IDENTITY();

        INSERT INTO Recaudacion (IdComprobante, Fecha, Importe, IdMedioPago, IdCajero, Tipo)
        VALUES (@IdComprobante, CAST(GETDATE() AS DATE), @Total, @IdMedioPago, @IdCajero, N'Ingreso');

        COMMIT;
        SELECT @IdComprobante;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Comprobante_Anular @IdComprobante INT, @Motivo NVARCHAR(200), @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Comprobante SET Estado = N'Anulado', MotivoAnulacion = @Motivo, IdUsuarioAnula = @IdUsuario, FechaAnulacion = GETDATE()
        WHERE IdComprobante = @IdComprobante;

        INSERT INTO Recaudacion (IdComprobante, Fecha, Importe, IdMedioPago, IdCajero, Tipo)
        SELECT cp.IdComprobante, CAST(GETDATE() AS DATE), -cp.Total, pg.IdMedioPago, @IdUsuario, N'Anulación'
        FROM Comprobante cp
        INNER JOIN Pago pg ON pg.IdPago = cp.IdPago
        WHERE cp.IdComprobante = @IdComprobante;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Recaudacion_ListarPorFecha @Fecha DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Recaudacion WHERE Fecha = @Fecha ORDER BY FechaRegistro;
END
GO

CREATE OR ALTER PROCEDURE usp_Muestra_ObtenerPorCodigo @Codigo VARCHAR(12) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Muestra WHERE Codigo = @Codigo;
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_ObtenerPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Muestra WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_ObtenerPorId @IdMuestra INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Muestra WHERE IdMuestra = @IdMuestra;
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_ListarPorEstado @Estado NVARCHAR(30) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Muestra WHERE Estado = @Estado
    ORDER BY ISNULL(FechaAcondicionamiento, ISNULL(FechaIngreso, FechaGeneracion));
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_ConsultarTransito @Desde DATE, @Hasta DATE, @Estado NVARCHAR(30) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Muestra
    WHERE CAST(FechaGeneracion AS DATE) BETWEEN @Desde AND @Hasta AND (@Estado IS NULL OR Estado = @Estado)
    ORDER BY FechaGeneracion DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_Generar @IdAtencion INT, @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdMuestra INT = (SELECT IdMuestra FROM Muestra WITH (UPDLOCK, HOLDLOCK) WHERE IdAtencion = @IdAtencion);
        IF @IdMuestra IS NULL
        BEGIN
            DECLARE @c TABLE (Serie VARCHAR(10), Ultimo INT);
            UPDATE Correlativo SET Ultimo = Ultimo + 1 OUTPUT inserted.Serie, inserted.Ultimo INTO @c WHERE Tipo = 'MUESTRA';

            DECLARE @Codigo VARCHAR(12);
            SELECT @Codigo = Serie + '-' + RIGHT('000000' + CAST(Ultimo AS VARCHAR(10)), 6) FROM @c;

            INSERT INTO Muestra (IdAtencion, Codigo, IdUsuarioGenera, Estado) VALUES (@IdAtencion, @Codigo, @IdUsuario, N'Generada');
            SET @IdMuestra = SCOPE_IDENTITY();
        END
        COMMIT;
        SELECT @IdMuestra;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarRecoleccion
    @IdMuestra INT, @HoraExtraccion DATETIME, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM Muestra WHERE IdMuestra = @IdMuestra);
        UPDATE Muestra SET HoraExtraccion = @HoraExtraccion, IdUsuarioToma = @IdUsuario, FechaValidacion = GETDATE(),
               Estado = N'Muestra recolectada'
        WHERE IdMuestra = @IdMuestra;
        UPDATE Atencion SET Estado = N'Muestra recolectada' WHERE IdAtencion = @IdAtencion;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Muestra recolectada', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarRetorno
    @IdMuestra INT, @HoraExtraccion DATETIME, @CondicionesDeclaradas NVARCHAR(500) = NULL, @RechazosOcurridos NVARCHAR(500) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM Muestra WHERE IdMuestra = @IdMuestra);
        DECLARE @IdVisita INT = (SELECT IdVisita FROM VisitaDomiciliaria WHERE IdAtencion = @IdAtencion);
        UPDATE Muestra SET HoraExtraccion = @HoraExtraccion, IdUsuarioToma = @IdUsuario, FechaValidacion = GETDATE(),
               CondicionesDeclaradas = @CondicionesDeclaradas, RechazosOcurridos = @RechazosOcurridos, Estado = N'Muestra recolectada'
        WHERE IdMuestra = @IdMuestra;
        UPDATE VisitaDomiciliaria SET Estado = N'Realizada' WHERE IdVisita = @IdVisita;
        UPDATE Atencion SET Estado = N'Muestra recolectada' WHERE IdAtencion = @IdAtencion;
        IF @IdVisita IS NOT NULL
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'VisitaDomiciliaria', @IdVisita, N'Cambio de estado', N'Realizada', @IdUsuario);
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Muestra recolectada', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarRechazo
    @IdMuestra INT, @IdExamen INT = NULL, @IdTubo INT = NULL, @Motivo NVARCHAR(40), @Observacion NVARCHAR(300) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO RechazoMuestra (IdMuestra, IdExamen, IdTubo, Motivo, Observacion, IdUsuario)
    VALUES (@IdMuestra, @IdExamen, @IdTubo, @Motivo, @Observacion, @IdUsuario);
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_ConsultarRechazadas @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Rechazo WHERE CAST(Fecha AS DATE) BETWEEN @Desde AND @Hasta ORDER BY Fecha DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarIngreso
    @IdMuestra INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Muestra SET FechaIngreso = GETDATE(), IdUsuarioIngreso = @IdUsuario, Estado = N'Ingresada' WHERE IdMuestra = @IdMuestra;
        INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, IdUsuario, Detalle) VALUES (@IdMuestra, N'Ingreso', @IdUsuario, NULL);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarAcondicionamiento
    @IdMuestra INT, @EstadoConservacion NVARCHAR(20), @MinutosCentrifugacion INT = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE Muestra SET EstadoConservacion = @EstadoConservacion, MinutosCentrifugacion = @MinutosCentrifugacion,
               FechaAcondicionamiento = GETDATE(), IdUsuarioAcondiciona = @IdUsuario, Estado = N'Muestra Acondicionada'
        WHERE IdMuestra = @IdMuestra;
        DECLARE @Detalle NVARCHAR(500) = N'Conservación: ' + @EstadoConservacion
              + N'; centrifugación: ' + ISNULL(CAST(@MinutosCentrifugacion AS NVARCHAR(10)) + N' min', N'no aplica');
        INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, IdUsuario, Detalle) VALUES (@IdMuestra, N'Acondicionamiento', @IdUsuario, @Detalle);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_Corregir
    @IdMuestra INT, @EstadoConservacion NVARCHAR(20), @MinutosCentrifugacion INT = NULL, @DatoAnterior NVARCHAR(300),
    @Motivo NVARCHAR(300), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO CorreccionMuestra (IdMuestra, DatoAnterior, Motivo, IdUsuario) VALUES (@IdMuestra, @DatoAnterior, @Motivo, @IdUsuario);
        UPDATE Muestra SET EstadoConservacion = @EstadoConservacion, MinutosCentrifugacion = @MinutosCentrifugacion,
               FechaAcondicionamiento = GETDATE(), IdUsuarioAcondiciona = @IdUsuario, Estado = N'Muestra Acondicionada'
        WHERE IdMuestra = @IdMuestra;
        DECLARE @Detalle NVARCHAR(500) = N'Antes: ' + @DatoAnterior + N'. Ahora: conservación ' + @EstadoConservacion
              + N', centrifugación ' + ISNULL(CAST(@MinutosCentrifugacion AS NVARCHAR(10)) + N' min', N'no aplica') + N'. Motivo: ' + @Motivo;
        INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, IdUsuario, Detalle) VALUES (@IdMuestra, N'Corrección', @IdUsuario, LEFT(@Detalle, 500));
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_RegistrarRecepcion
    @IdMuestra INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM Muestra WHERE IdMuestra = @IdMuestra);
        UPDATE Muestra SET FechaRecepcion = GETDATE(), IdUsuarioRecepcion = @IdUsuario, Estado = N'Recibida para análisis'
        WHERE IdMuestra = @IdMuestra;
        UPDATE Atencion SET Estado = N'Recibida para análisis' WHERE IdAtencion = @IdAtencion;
        INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, IdUsuario, Detalle) VALUES (@IdMuestra, N'Recepción', @IdUsuario, NULL);
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Recibida para análisis', @IdUsuario);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Muestra_Devolver
    @IdMuestra INT, @Diferencia NVARCHAR(300), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO DevolucionMuestra (IdMuestra, Diferencia, IdUsuario) VALUES (@IdMuestra, @Diferencia, @IdUsuario);
        UPDATE Muestra SET Estado = N'Devuelta' WHERE IdMuestra = @IdMuestra;
        INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, IdUsuario, Detalle) VALUES (@IdMuestra, N'Devolución', @IdUsuario, @Diferencia);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_MovimientoMuestra_Listar @IdMuestra INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_MovimientoMuestra WHERE IdMuestra = @IdMuestra ORDER BY FechaHora, IdMovimiento;
END
GO
CREATE OR ALTER PROCEDURE usp_MovimientoMuestra_Consultar @Desde DATE, @Hasta DATE, @TipoMovimiento NVARCHAR(20) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_MovimientoMuestra
    WHERE CAST(FechaHora AS DATE) BETWEEN @Desde AND @Hasta AND (@TipoMovimiento IS NULL OR TipoMovimiento = @TipoMovimiento)
    ORDER BY FechaHora DESC, IdMovimiento DESC;
END
GO

CREATE OR ALTER PROCEDURE usp_Resultado_ObtenerPorId @IdResultado INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Resultado WHERE IdResultado = @IdResultado;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_ListarPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Resultado WHERE IdAtencion = @IdAtencion ORDER BY NombreExamen, IdParametro;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_ListarParametrosConValor @IdAtencion INT, @IdExamen INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(r.IdResultado, 0) AS IdResultado, @IdAtencion AS IdAtencion, pa.IdParametro, r.Valor,
           ISNULL(r.Estado, '') AS Estado, pa.IdExamen, e.Nombre AS NombreExamen, pa.Nombre AS NombreParametro, pa.Unidad,
           r.ObservacionMedico
    FROM Parametro pa
    INNER JOIN Examen e ON e.IdExamen = pa.IdExamen
    LEFT JOIN ResultadoAnalitico r ON r.IdParametro = pa.IdParametro AND r.IdAtencion = @IdAtencion
    WHERE pa.IdExamen = @IdExamen AND (pa.Habilitado = 1 OR r.IdResultado IS NOT NULL)
    ORDER BY pa.IdParametro;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_Guardar @IdAtencion INT, @IdParametro INT, @Valor NVARCHAR(100), @IdTecnico INT AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM ResultadoAnalitico WHERE IdAtencion = @IdAtencion AND IdParametro = @IdParametro)
        UPDATE ResultadoAnalitico SET Valor = @Valor, IdTecnico = @IdTecnico, FechaRegistro = GETDATE()
        WHERE IdAtencion = @IdAtencion AND IdParametro = @IdParametro AND Estado = N'Registrado';
    ELSE
        INSERT INTO ResultadoAnalitico (IdAtencion, IdParametro, Valor, Estado, IdTecnico)
        VALUES (@IdAtencion, @IdParametro, @Valor, N'Registrado', @IdTecnico);
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_EnviarAValidacion
    @IdAtencion INT, @IdExamen INT, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE r SET Estado = N'Pendiente de validación', FechaEnvio = GETDATE()
        FROM ResultadoAnalitico r
        INNER JOIN Parametro pa ON pa.IdParametro = r.IdParametro
        WHERE r.IdAtencion = @IdAtencion AND pa.IdExamen = @IdExamen AND r.Estado = N'Registrado';
        DECLARE @Enviados INT = @@ROWCOUNT;
        DECLARE @Detalle NVARCHAR(500) = CAST(@Enviados AS NVARCHAR(10)) + N' resultado(s) del examen ' + CAST(@IdExamen AS NVARCHAR(10)) + N' enviados a validación';
        IF @Enviados > 0
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Envío a validación', @Detalle, @IdUsuario);
        COMMIT;
        SELECT @Enviados;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_ListarAtencionesPendientes AS
BEGIN
    SET NOCOUNT ON;
    SELECT a.IdAtencion, a.NumeroAtencion, a.NombrePaciente,
           ISNULL((SELECT STRING_AGG(x.NombreExamen, ', ') FROM
                   (SELECT DISTINCT r2.NombreExamen FROM vw_Resultado r2
                    WHERE r2.IdAtencion = a.IdAtencion AND r2.Estado = N'Pendiente de validación') x), '') AS NombreExamen,
           (SELECT TOP 1 r3.NombreTecnico FROM vw_Resultado r3
            WHERE r3.IdAtencion = a.IdAtencion AND r3.Estado = N'Pendiente de validación' ORDER BY r3.FechaEnvio DESC) AS NombreTecnico,
           (SELECT MAX(r4.FechaEnvio) FROM ResultadoAnalitico r4
            WHERE r4.IdAtencion = a.IdAtencion AND r4.Estado = N'Pendiente de validación') AS FechaEnvio
    FROM vw_Atencion a
    WHERE EXISTS (SELECT 1 FROM ResultadoAnalitico r WHERE r.IdAtencion = a.IdAtencion AND r.Estado = N'Pendiente de validación')
    ORDER BY FechaEnvio;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_ListarAnterioresDelPaciente @IdPaciente INT, @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Resultado
    WHERE IdPaciente = @IdPaciente AND IdAtencion <> @IdAtencion AND Estado = N'Validado'
    ORDER BY FechaValidacion DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_Validar
    @IdResultado INT, @IdMedico INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM ResultadoAnalitico WHERE IdResultado = @IdResultado);

        UPDATE ResultadoAnalitico SET Estado = N'Validado', IdMedico = @IdMedico, FechaValidacion = GETDATE()
        WHERE IdResultado = @IdResultado AND Estado = N'Pendiente de validación';

        DECLARE @Faltantes INT =
              (SELECT COUNT(*) FROM ResultadoAnalitico WHERE IdAtencion = @IdAtencion AND Estado <> N'Validado')
            + (SELECT COUNT(*) FROM AtencionExamen ae
               INNER JOIN Parametro pa ON pa.IdExamen = ae.IdExamen AND pa.Habilitado = 1
               WHERE ae.IdAtencion = @IdAtencion
                 AND NOT EXISTS (SELECT 1 FROM ResultadoAnalitico r WHERE r.IdAtencion = @IdAtencion AND r.IdParametro = pa.IdParametro));

        IF @Faltantes = 0
        BEGIN
            UPDATE Atencion SET Estado = N'Lista para reporte' WHERE IdAtencion = @IdAtencion;
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Lista para reporte', @IdMedico);
        END
        COMMIT;
        SELECT CASE WHEN @Faltantes = 0 THEN 1 ELSE 0 END;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_Retener @IdResultado INT, @Observacion NVARCHAR(300), @IdMedico INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ResultadoAnalitico SET Estado = N'En repetición', ObservacionMedico = @Observacion, IdMedico = @IdMedico
        WHERE IdResultado = @IdResultado;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario)
        VALUES (N'ResultadoAnalitico', @IdResultado, N'Retener y repetir', @Observacion, @IdMedico);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_ListarEnRepeticion AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Resultado WHERE Estado = N'En repetición' ORDER BY IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Resultado_RegistrarRepeticion @IdResultado INT, @Valor NVARCHAR(100), @IdTecnico INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO ResultadoAnterior (IdResultado, Valor, ObservacionMedico, IdUsuario)
        SELECT IdResultado, Valor, ObservacionMedico, @IdTecnico FROM ResultadoAnalitico WHERE IdResultado = @IdResultado;

        UPDATE ResultadoAnalitico SET Valor = @Valor, Estado = N'Pendiente de validación', IdTecnico = @IdTecnico,
               FechaRegistro = GETDATE(), FechaEnvio = GETDATE(), IdMedico = NULL, FechaValidacion = NULL
        WHERE IdResultado = @IdResultado;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE usp_UsoEquipo_ObtenerPorId @IdUso INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_UsoEquipo WHERE IdUso = @IdUso;
END
GO
CREATE OR ALTER PROCEDURE usp_UsoEquipo_Registrar @IdEquipo INT, @IdMuestra INT, @IdTecnico INT AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO UsoEquipo (IdEquipo, IdMuestra, IdTecnico) VALUES (@IdEquipo, @IdMuestra, @IdTecnico);
    SELECT CAST(SCOPE_IDENTITY() AS INT);
END
GO
CREATE OR ALTER PROCEDURE usp_UsoEquipo_ListarDelDia @Fecha DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_UsoEquipo WHERE CAST(HoraInicio AS DATE) = @Fecha ORDER BY HoraInicio DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_UsoEquipo_RegistrarFalla @IdUso INT, @Descripcion NVARCHAR(500), @IdTecnico INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO FallaAnalitica (IdUso, Descripcion, IdTecnico) VALUES (@IdUso, @Descripcion, @IdTecnico);
        UPDATE UsoEquipo SET RequiereNuevaCorrida = 1 WHERE IdUso = @IdUso;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_UsoEquipo_ConsultarBitacora @IdEquipo INT, @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_UsoEquipo
    WHERE (@IdEquipo = 0 OR IdEquipo = @IdEquipo) AND CAST(HoraInicio AS DATE) BETWEEN @Desde AND @Hasta
    ORDER BY HoraInicio DESC;
END
GO

CREATE OR ALTER PROCEDURE usp_Reporte_ObtenerPorId @IdReporte INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Reporte WHERE IdReporte = @IdReporte;
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_ObtenerPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Reporte WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_ListarPorEstado @Estado NVARCHAR(40) AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Reporte WHERE Estado = @Estado ORDER BY ISNULL(FechaAutorizacion, FechaGeneracion);
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_Consultar @Dni CHAR(8) = NULL, @Desde DATE, @Hasta DATE, @Estado NVARCHAR(40) = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Reporte
    WHERE ((@Dni IS NOT NULL AND Dni = @Dni) OR (@Dni IS NULL AND CAST(FechaGeneracion AS DATE) BETWEEN @Desde AND @Hasta))
      AND (@Estado IS NULL OR Estado = @Estado)
    ORDER BY FechaGeneracion DESC;
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_Insertar
    @IdAtencion INT, @Contenido NVARCHAR(MAX), @IdDigitador INT, @Secciones NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO ReporteClinico (IdAtencion, Version, Contenido, Estado, IdDigitador)
        VALUES (@IdAtencion, 1, @Contenido, N'Borrador', @IdDigitador);
        DECLARE @IdReporte INT = SCOPE_IDENTITY();
        DECLARE @Version INT = 1;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Contenido, IdUsuario)
        VALUES (@IdReporte, 1, N'Generado', @Contenido, @IdDigitador);
        IF @Secciones IS NOT NULL
        BEGIN
            DELETE FROM ReporteSeccion WHERE IdReporte = @IdReporte AND Version = @Version;
            INSERT INTO ReporteSeccion (IdReporte, Version, IdExamen, IdPlantilla, Contenido)
            SELECT @IdReporte, @Version, s.IdExamen, s.IdPlantilla, s.Contenido
            FROM OPENJSON(@Secciones) WITH (IdExamen INT '$.IdExamen', IdPlantilla INT '$.IdPlantilla', Contenido NVARCHAR(MAX) '$.Contenido') s;
        END
        COMMIT;
        SELECT @IdReporte;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_Regenerar
    @IdReporte INT, @Contenido NVARCHAR(MAX), @NuevaVersion BIT, @IdDigitador INT, @Secciones NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ReporteClinico SET Contenido = @Contenido, Estado = N'Borrador', Definitivo = 0, IdDigitador = @IdDigitador,
               FechaGeneracion = GETDATE(), Version = Version + CASE WHEN @NuevaVersion = 1 THEN 1 ELSE 0 END,
               IdDirector = NULL, FechaAutorizacion = NULL
        WHERE IdReporte = @IdReporte;
        DECLARE @Version INT = (SELECT Version FROM ReporteClinico WHERE IdReporte = @IdReporte);
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Contenido, IdUsuario)
        VALUES (@IdReporte, @Version, CASE WHEN @NuevaVersion = 1 THEN N'Nueva versión generada' ELSE N'Regenerado' END, @Contenido, @IdDigitador);
        IF @Secciones IS NOT NULL
        BEGIN
            DELETE FROM ReporteSeccion WHERE IdReporte = @IdReporte AND Version = @Version;
            INSERT INTO ReporteSeccion (IdReporte, Version, IdExamen, IdPlantilla, Contenido)
            SELECT @IdReporte, @Version, s.IdExamen, s.IdPlantilla, s.Contenido
            FROM OPENJSON(@Secciones) WITH (IdExamen INT '$.IdExamen', IdPlantilla INT '$.IdPlantilla', Contenido NVARCHAR(MAX) '$.Contenido') s;
        END
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_ReporteSeccion_Listar @IdReporte INT, @Version INT = NULL AS
BEGIN
    SET NOCOUNT ON;
    SELECT s.IdSeccion, s.IdReporte, s.Version, s.IdExamen, e.Nombre AS NombreExamen, s.IdPlantilla, p.Nombre AS NombrePlantilla, s.Contenido
    FROM ReporteSeccion s
    INNER JOIN Examen e ON e.IdExamen = s.IdExamen
    INNER JOIN Plantilla p ON p.IdPlantilla = s.IdPlantilla
    WHERE s.IdReporte = @IdReporte
      AND s.Version = ISNULL(@Version, (SELECT Version FROM ReporteClinico WHERE IdReporte = @IdReporte))
    ORDER BY p.Nombre, e.Nombre;
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_CambiarEstado
    @IdReporte INT, @Estado NVARCHAR(40), @Accion NVARCHAR(60), @Observacion NVARCHAR(500) = NULL, @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ReporteClinico SET Estado = @Estado WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Observacion, IdUsuario)
        SELECT IdReporte, Version, @Accion, @Observacion, @IdUsuario FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_MarcarDefinitivo @IdReporte INT, @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ReporteClinico SET Definitivo = 1 WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, IdUsuario)
        SELECT IdReporte, Version, N'Guardado como definitivo', @IdUsuario FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_Autorizar @IdReporte INT, @IdDirector INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ReporteClinico SET Estado = N'Autorizado', IdDirector = @IdDirector, FechaAutorizacion = GETDATE()
        WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, IdUsuario)
        SELECT IdReporte, Version, N'Autorizado', @IdDirector FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_AnularAutorizacion @IdReporte INT, @Motivo NVARCHAR(500), @IdDirector INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE ReporteClinico SET Estado = N'Observado', Definitivo = 0, IdDirector = NULL, FechaAutorizacion = NULL
        WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Observacion, IdUsuario)
        SELECT IdReporte, Version, N'Autorización anulada', @Motivo, @IdDirector FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_DevolverAlMedico
    @IdReporte INT, @Observacion NVARCHAR(500), @IdDirector INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        DECLARE @IdAtencion INT = (SELECT IdAtencion FROM ReporteClinico WHERE IdReporte = @IdReporte);
        UPDATE ReporteClinico SET Estado = N'Devuelto al Médico Patólogo', Definitivo = 0 WHERE IdReporte = @IdReporte;
        UPDATE ResultadoAnalitico SET Estado = N'Pendiente de validación', IdMedico = NULL, FechaValidacion = NULL
        WHERE IdAtencion = @IdAtencion AND Estado = N'Validado';
        UPDATE Atencion SET Estado = N'Recibida para análisis' WHERE IdAtencion = @IdAtencion;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Observacion, IdUsuario)
        SELECT IdReporte, Version, N'Devuelto al Médico Patólogo', @Observacion, @IdDirector FROM ReporteClinico WHERE IdReporte = @IdReporte;
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario) VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Recibida para análisis (reporte devuelto al Médico Patólogo)', @IdDirector);
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Reporte_ListarHistorial @IdReporte INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT h.IdHistorial, h.IdReporte, h.Version, h.Accion, h.Observacion, h.Fecha, u.NombreCompleto AS NombreResponsable
    FROM ReporteHistorial h
    INNER JOIN Usuario u ON u.IdUsuario = h.IdUsuario
    WHERE h.IdReporte = @IdReporte
    ORDER BY h.Fecha, h.IdHistorial;
END
GO

CREATE OR ALTER PROCEDURE usp_Entrega_BuscarParaEntrega @Texto VARCHAR(15) AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 ISNULL(cp.IdComprobante, 0) AS IdComprobante, ISNULL(cp.NumeroComprobante, '') AS NumeroComprobante,
           ISNULL(cp.Estado, '') AS EstadoComprobante, r.NombrePaciente AS PacienteComprobante, r.Examenes AS ExamenesComprobante,
           r.IdReporte, r.IdAtencion, r.NumeroAtencion, r.NombrePaciente AS PacienteReporte, r.Estado AS EstadoReporte,
           r.Dni AS DniPaciente
    FROM vw_Reporte r
    LEFT JOIN Comprobante cp ON cp.IdAtencion = r.IdAtencion
    WHERE r.Estado IN (N'Disponible para entrega', N'Entrega retenida') AND (r.Dni = @Texto OR cp.NumeroComprobante = @Texto)
    ORDER BY CASE WHEN cp.Estado = N'Emitido' THEN 0 ELSE 1 END, r.FechaAutorizacion;
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_Registrar
    @IdReporte INT, @NombreRecibe NVARCHAR(120), @DniRecibe CHAR(8), @Relacion NVARCHAR(20), @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO Entrega (IdReporte, NombreRecibe, DniRecibe, Relacion, IdUsuario)
        VALUES (@IdReporte, @NombreRecibe, @DniRecibe, @Relacion, @IdUsuario);
        DECLARE @IdEntrega INT = SCOPE_IDENTITY();
        UPDATE ReporteClinico SET Estado = N'Entregado' WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, IdUsuario)
        SELECT IdReporte, Version, N'Entregado', @IdUsuario FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
        SELECT @IdEntrega;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_Retener @IdReporte INT, @Motivo NVARCHAR(300), @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO RetencionEntrega (IdReporte, Motivo, IdUsuario) VALUES (@IdReporte, @Motivo, @IdUsuario);
        UPDATE ReporteClinico SET Estado = N'Entrega retenida' WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Observacion, IdUsuario)
        SELECT IdReporte, Version, N'Entrega retenida', @Motivo, @IdUsuario FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_LevantarRetencion @IdReporte INT, @IdUsuario INT AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;
        UPDATE RetencionEntrega SET Levantada = 1, IdUsuarioLevanta = @IdUsuario, FechaLevantamiento = GETDATE()
        WHERE IdReporte = @IdReporte AND Levantada = 0;
        UPDATE ReporteClinico SET Estado = N'Disponible para entrega' WHERE IdReporte = @IdReporte;
        INSERT INTO ReporteHistorial (IdReporte, Version, Accion, IdUsuario)
        SELECT IdReporte, Version, N'Retención levantada', @IdUsuario FROM ReporteClinico WHERE IdReporte = @IdReporte;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_ListarSinCerrar AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Entrega WHERE EstadoAtencion <> N'Culminada' ORDER BY FechaEntrega;
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_ObtenerPorAtencion @IdAtencion INT AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Entrega WHERE IdAtencion = @IdAtencion;
END
GO
CREATE OR ALTER PROCEDURE usp_Entrega_Consultar @Desde DATE, @Hasta DATE AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Entrega WHERE CAST(FechaEntrega AS DATE) BETWEEN @Desde AND @Hasta ORDER BY FechaEntrega DESC;
END
GO
