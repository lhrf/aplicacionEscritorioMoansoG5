# CEIBIO – Sistema de Gestión del Laboratorio Clínico

Sistema de escritorio para el **Laboratorio Clínico CEIBIO S.A.C.** que gestiona la atención del paciente de principio a fin: admisión, evaluación pre-analítica, caja, toma y preparación de muestras, análisis, formalización del Reporte clínico y entrega de resultados.

Desarrollado en **C# (.NET 10, Windows Forms)** con base de datos **SQL Server**, siguiendo una arquitectura en capas.

---

## Funcionalidades

| Módulo | Qué permite hacer |
|---|---|
| **Admisión** | Registrar la atención del paciente (en sede o a domicilio), calcular el costo con convenios, buscar y registrar la Ficha clínica histórica, programar visitas domiciliarias. |
| **Evaluación** | Registrar las observaciones pre-analíticas, declarar apto al paciente o suspender la atención. |
| **Caja** | Registrar pagos (con autorización de transferencias), emitir Comprobantes de pago, registrar la recaudación y derivar la atención. |
| **Muestras** | Asignar box, registrar la toma de muestra en sede y a domicilio, imprimir etiquetas, rechazar tubos, acondicionar, recepcionar y devolver muestras (Libro de Tránsito). |
| **Análisis** | Registrar resultados por parámetro, registrar el uso de los equipos y sus fallas, validar resultados con intervalos de referencia, retener y repetir análisis. |
| **Reportes** | Elaborar el Reporte clínico por plantillas (una sección por examen y versión), revisión de calidad y autorización del Director Médico. |
| **Entregas** | Verificar el comprobante, registrar o retener la entrega y cerrar la atención. |
| **Mantenedores** | Exámenes, convenios, condiciones pre-analíticas, medios de pago, tubos y recipientes, boxes, equipos, parámetros, plantillas, intervalos de referencia y usuarios. |
| **Seguridad** | Inicio de sesión, menú según el rol del usuario, cambio de clave y auditoría de operaciones. |

Además incluye 14 consultas (atenciones, visitas, suspendidas, transferencias, recaudación, comprobantes, muestras rechazadas, tránsito, bitácora de equipos, reportes, historial de revisiones y entregas, entre otras).

---

## Arquitectura

```
CEIBIO.Presentacion  →  CEIBIO.Negocio  →  CEIBIO.Datos  →  SQL Server (CEIBIO_DB)
        └──────────────── CEIBIO.Entidades ────────────────┘
```

| Proyecto | Tipo | Responsabilidad |
|---|---|---|
| `CEIBIO.Entidades` | Biblioteca de clases | Clases que representan las tablas y constantes de los estados. |
| `CEIBIO.Datos` | Biblioteca de clases | Conexión y llamadas a los procedimientos almacenados (`Microsoft.Data.SqlClient`). |
| `CEIBIO.Negocio` | Biblioteca de clases | Reglas de negocio y validaciones de cada caso de uso; todas las operaciones devuelven un objeto `Respuesta`. |
| `CEIBIO.Presentacion` | Aplicación Windows Forms | Formularios del sistema, organizados por módulo. |
| `BaseDatos` | Scripts SQL | Creación de la base de datos, procedimientos almacenados y datos de prueba. |

Todo el acceso a datos se hace mediante **procedimientos almacenados** con el formato `usp_<Tabla>_<Acción>` (por ejemplo, `usp_Examen_Listar`, `usp_Examen_Insertar`, `usp_Examen_CambiarEstado`). Los registros no se eliminan físicamente: se inhabilitan.

---

## Requisitos

- Windows 10 u 11
- [SDK de .NET 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio con la carga de trabajo **Desarrollo de escritorio de .NET** y compatibilidad con .NET 10 y soluciones `.slnx`
- SQL Server 2017 o superior (Express sirve) y SQL Server Management Studio

---

## Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/lhrf/aplicacionEscritorioMoansoG5.git
cd aplicacionEscritorioMoansoG5
```

### 2. Crear la base de datos

En SQL Server Management Studio, abre y ejecuta (F5) los scripts de la carpeta `BaseDatos` **en este orden**:

| Orden | Script | Contenido |
|---|---|---|
| 1 | `01_CEIBIO_DB_Tablas.sql` | Crea la base de datos `CEIBIO_DB`, sus tablas, restricciones, roles, usuarios y catálogos base. |
| 2 | `02_CEIBIO_Procedimientos.sql` | Vistas y procedimientos almacenados. |
| 3 | `03_CEIBIO_Analisis.sql` | Catálogo de exámenes con sus tubos, parámetros, intervalos de referencia y plantillas. |
| 4 | `04_CEIBIO_Pacientes.sql` | Pacientes y atenciones de prueba en las distintas etapas del proceso. |

> ⚠️ El script `01` **borra y vuelve a crear** `CEIBIO_DB`. El script `02` usa `CREATE OR ALTER`, así que se puede volver a ejecutar sin perder datos cuando se modifica un procedimiento.

### 3. Configurar la conexión

La cadena de conexión está en `CEIBIO.Datos/Conexion.cs`:

```
Server=localhost;Database=CEIBIO_DB;Integrated Security=True;TrustServerCertificate=True;
```

Si usas SQL Server Express, cambia `localhost` por `localhost\SQLEXPRESS`.

### 4. Ejecutar

1. Abre `CEIBIO.slnx` en Visual Studio.
2. Establece `CEIBIO.Presentacion` como proyecto de inicio.
3. Compila y ejecuta (F5). El paquete NuGet `Microsoft.Data.SqlClient` se descarga automáticamente.

---

## Usuarios de prueba

Todos los usuarios tienen la clave **`Ceibio123`**.

| Usuario | Rol |
|---|---|
| `admin` | Administrador del Sistema |
| `director` | Director Médico |
| `admision` | Asesor de Admisión |
| `archivo` | Auxiliar de Archivo |
| `enfermera` | Enfermera Evaluadora |
| `cajero` | Cajero |
| `supervisor` | Supervisor de Turno |
| `itinerante` | Técnico Laboratorista Itinerante |
| `orientador` | Orientador de Sala |
| `flebotomista` | Técnico Flebotomista |
| `auxlab` | Auxiliar de Laboratorio |
| `analista` | Técnico Analista |
| `patologo` | Médico Patólogo |
| `digitador` | Digitador Clínico |
| `calidad` | Supervisor de Calidad |
| `entregas` | Encargado de Entregas |

Cada usuario solo ve en el menú principal las opciones de su rol.

---

## Seguridad y trazabilidad

- **Claves:** se guardan con PBKDF2-SHA256 (100 000 iteraciones) y una sal distinta por usuario.
- **Auditoría:** el registro, la modificación, la inhabilitación, la anulación y los cambios de estado quedan en la tabla `Auditoria`, con el usuario y la fecha y hora del servidor.
- **Libro de Tránsito:** cada ingreso, acondicionamiento, recepción, devolución y corrección de una muestra queda en `MovimientoMuestra`.
- **Transacciones:** las operaciones que afectan varias tablas (emitir comprobante, validar resultados, registrar entrega, etc.) se ejecutan dentro de una transacción en el procedimiento almacenado.

---

## Estructura del repositorio

```
aplicacionEscritorioMoansoG5/
├── BaseDatos/
│   ├── 01_CEIBIO_DB_Tablas.sql
│   ├── 02_CEIBIO_Procedimientos.sql
│   ├── 03_CEIBIO_Analisis.sql
│   └── 04_CEIBIO_Pacientes.sql
├── CEIBIO.Entidades/      # Clases de las tablas y estados
├── CEIBIO.Datos/          # Acceso a datos (procedimientos almacenados)
├── CEIBIO.Negocio/        # Reglas de negocio por módulo
├── CEIBIO.Presentacion/   # Formularios Windows Forms por módulo
│   ├── Admision/  Evaluacion/  Caja/  TomaMuestras/  Preparacion/
│   ├── Analisis/  Formalizacion/  Entregas/  Mantenedores/
│   └── Seguridad/  Sesion/  Impresion/
└── CEIBIO.slnx
```
