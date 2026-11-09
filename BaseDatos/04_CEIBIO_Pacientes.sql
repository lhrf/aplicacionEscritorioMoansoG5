USE CEIBIO_DB;
GO
SET NOCOUNT ON;
GO
DROP TABLE IF EXISTS #Caso, #CasoEx, #CasoRes, #CasoSec;
CREATE TABLE #Caso (K INT PRIMARY KEY, Etapa VARCHAR(3), Dni CHAR(8), Nombres NVARCHAR(80) COLLATE DATABASE_DEFAULT, Apellidos NVARCHAR(80) COLLATE DATABASE_DEFAULT, FechaNacimiento DATE, Sexo NVARCHAR(10) COLLATE DATABASE_DEFAULT, Direccion NVARCHAR(150) COLLATE DATABASE_DEFAULT, Telefono VARCHAR(9), Domicilio BIT, Convenio NVARCHAR(120) COLLATE DATABASE_DEFAULT, Medio VARCHAR(10) COLLATE DATABASE_DEFAULT, Box VARCHAR(10) COLLATE DATABASE_DEFAULT, T0 DATETIME, TGen DATETIME, TEnt DATETIME, Contenido NVARCHAR(MAX) COLLATE DATABASE_DEFAULT);
CREATE TABLE #CasoEx (K INT, Examen NVARCHAR(100) COLLATE DATABASE_DEFAULT, Equipo NVARCHAR(100) COLLATE DATABASE_DEFAULT);
CREATE TABLE #CasoRes (K INT, Examen NVARCHAR(100) COLLATE DATABASE_DEFAULT, Parametro NVARCHAR(100) COLLATE DATABASE_DEFAULT, Valor NVARCHAR(100) COLLATE DATABASE_DEFAULT);
CREATE TABLE #CasoSec (K INT, Examen NVARCHAR(100) COLLATE DATABASE_DEFAULT, Plantilla NVARCHAR(100) COLLATE DATABASE_DEFAULT, Contenido NVARCHAR(MAX) COLLATE DATABASE_DEFAULT);
INSERT INTO #Caso VALUES
 (1, 'CUL', '45003014', N'José', N'Tafur Torres', '1980-10-10', N'Masculino', N'Jr. Dos de Mayo N° 1056, Rioja', '921048396', 0, NULL, 'EFE', '2', '2026-09-25T08:43:00', '2026-09-26T09:07:00', '2026-09-30T10:11:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tafur Torres, José
DNI: 45003014    Sexo: Masculino    Edad: 45 años
Fecha de atención: 25/09/2026
Fecha de emisión: 26/09/2026 09:07

==== INMUNOLOGÍA ====
Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      7.4 *         mg/dL       8.6 - 10.3

==== HEMATOLOGÍA ====
Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.2          g/dL        13.5 - 17.5
  Leucocitos                  7.4           x10³/µL     4.5 - 11
  Plaquetas                   384           x10³/µL     150 - 450

(*) Valor fuera del intervalo de referencia.
'),
 (2, 'CUL', '43389755', N'Julio', N'Gonzales García', '1966-07-20', N'Masculino', N'Jr. Juan Pablo II N° 1563, Rioja', '976632793', 0, NULL, 'EFE', '2', '2026-09-28T08:57:00', '2026-09-29T09:14:00', '2026-09-30T10:22:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Gonzales García, Julio
DNI: 43389755    Sexo: Masculino    Edad: 60 años
Fecha de atención: 28/09/2026
Fecha de emisión: 29/09/2026 09:14

==== OTROS ANÁLISIS ====
Insulina
  Parámetro                   Resultado     Unidad      Referencia
  Insulina                    11.0          µUI/mL      2.6 - 24.9

==== PARASITOLOGÍA ====
Reacción inflamatoria
  Parámetro                   Resultado     Unidad      Referencia
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo
  Moco                        Ausente                   Ausente

==== HORMONAS ====
Testosterona total
  Parámetro                   Resultado     Unidad      Referencia
  Testosterona total          970 *         ng/dL       249 - 836

(*) Valor fuera del intervalo de referencia.
'),
 (3, 'CUL', '40854102', N'Renzo', N'García Huamán', '1963-09-12', N'Masculino', N'Jr. Santo Toribio N° 1150, Rioja', '983811129', 0, NULL, 'EFE', '1', '2026-09-18T07:10:00', '2026-09-19T09:21:00', '2026-09-21T10:33:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: García Huamán, Renzo
DNI: 40854102    Sexo: Masculino    Edad: 63 años
Fecha de atención: 18/09/2026
Fecha de emisión: 19/09/2026 09:21

==== BIOQUÍMICA ====
Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       36            mg/dL       ≤ 140

==== HEMATOLOGÍA ====
Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 17.3          g/dL        13.5 - 17.5
Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.4          g/dL        13.5 - 17.5
  Leucocitos                  12.0 *        x10³/µL     4.5 - 11
  Plaquetas                   197           x10³/µL     150 - 450

(*) Valor fuera del intervalo de referencia.
'),
 (4, 'CUL', '48859922', N'Juan', N'García Lozano', '1992-07-07', N'Masculino', N'Jr. Cajamarca N° 1790, Rioja', '952903651', 1, NULL, 'TAR', '2', '2026-09-30T09:53:00', '2026-10-01T09:28:00', '2026-10-02T10:44:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: García Lozano, Juan
DNI: 48859922    Sexo: Masculino    Edad: 34 años
Fecha de atención: 30/09/2026
Fecha de emisión: 01/10/2026 09:28

==== HORMONAS ====
FSH
  Parámetro                   Resultado     Unidad      Referencia
  FSH                         5.2           mUI/mL      1.5 - 12.4

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            77            ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (5, 'CUL', '45454619', N'Wilmer Pedro', N'Shapiama Mendoza', '2010-08-26', N'Masculino', N'Jr. Ramírez Hurtado N° 138, Rioja', '998683741', 0, NULL, 'TAR', '1', '2026-10-16T07:59:00', '2026-10-17T09:35:00', '2026-10-21T10:55:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Shapiama Mendoza, Wilmer Pedro
DNI: 45454619    Sexo: Masculino    Edad: 16 años
Fecha de atención: 16/10/2026
Fecha de emisión: 17/10/2026 09:35

==== HEMATOLOGÍA ====
Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 11.3          g/dL        11 - 15.5

(*) Valor fuera del intervalo de referencia.
'),
 (6, 'CUL', '40394627', N'Lucía', N'Vargas Pizarro', '2026-06-30', N'Femenino', N'Jr. Simón Bolívar N° 1752, Rioja', '941656833', 0, NULL, 'TAR', '3', '2026-09-16T07:52:00', '2026-09-17T09:42:00', '2026-09-19T11:06:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vargas Pizarro, Lucía
DNI: 40394627    Sexo: Femenino    Edad: 0 años
Fecha de atención: 16/09/2026
Fecha de emisión: 17/09/2026 09:42

==== PERFILES ====
Perfil recién nacido
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 21.5          g/dL        14 - 24
  Hematocrito                 51            %           44 - 64
  Glucosa                     90            mg/dL       40 - 100
  Grupo sanguíneo             B                         
  Factor Rh                   Positivo                  
  Proteína C reactiva         3.8           mg/L        ≤ 5

(*) Valor fuera del intervalo de referencia.
'),
 (7, 'CUL', '40615700', N'Teresa', N'Tapia Pinedo', '1974-11-08', N'Femenino', N'Jr. Cajamarca N° 138, Rioja', '983340648', 0, N'Asociación de Docentes UPN', 'EFE', '1', '2026-09-05T08:29:00', '2026-09-06T09:49:00', '2026-09-09T11:17:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tapia Pinedo, Teresa
DNI: 40615700    Sexo: Femenino    Edad: 51 años
Fecha de atención: 05/09/2026
Fecha de emisión: 06/09/2026 09:49

==== CULTIVOS ====
Cultivo de secreción vaginal
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            

==== HORMONAS ====
Prolactina
  Parámetro                   Resultado     Unidad      Referencia
  Prolactina                  7.4           ng/mL       4.8 - 23.3

==== HEMATOLOGÍA ====
Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       12.5          s           11 - 13.5
  INR                         0.98          índice      0.8 - 1.2

(*) Valor fuera del intervalo de referencia.
'),
 (8, 'CUL', '48775130', N'Alberto', N'Reátegui Bardales', '2001-06-29', N'Masculino', N'Jr. Santo Toribio N° 1029, Rioja', '934357206', 0, NULL, 'EFE', '2', '2026-09-02T08:16:00', '2026-09-03T09:56:00', '2026-09-06T11:28:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Reátegui Bardales, Alberto
DNI: 48775130    Sexo: Masculino    Edad: 25 años
Fecha de atención: 02/09/2026
Fecha de emisión: 03/09/2026 09:56

==== PERFILES ====
Perfil de coagulación
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.1          s           11 - 13.5
  Tiempo parcial de tromboplastina30            s           25 - 35
  Plaquetas                   255           x10³/µL     150 - 450
  Tiempo de coagulación       7.2           min         5 - 10
  Tiempo de sangría           2.8           min         1 - 3

(*) Valor fuera del intervalo de referencia.
'),
 (9, 'CUL', '42956928', N'Diego Fernando', N'Reátegui Pinedo', '1973-12-21', N'Masculino', N'Jr. Faustino Maldonado N° 1455, Rioja', '958026593', 0, NULL, 'EFE', '2', '2026-09-04T07:00:00', '2026-09-05T10:03:00', '2026-09-09T11:39:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Reátegui Pinedo, Diego Fernando
DNI: 42956928    Sexo: Masculino    Edad: 52 años
Fecha de atención: 04/09/2026
Fecha de emisión: 05/09/2026 10:03

==== BIOQUÍMICA ====
Fosfatasa alcalina
  Parámetro                   Resultado     Unidad      Referencia
  Fosfatasa alcalina          93            U/L         40 - 129

(*) Valor fuera del intervalo de referencia.
'),
 (10, 'CUL', '42654046', N'Luis', N'Gonzales Vásquez', '1961-07-28', N'Masculino', N'Jr. Juan Pablo II N° 1486, Rioja', '917820271', 0, NULL, 'TAR', '1', '2026-09-09T07:22:00', '2026-09-10T10:10:00', '2026-09-11T11:50:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Gonzales Vásquez, Luis
DNI: 42654046    Sexo: Masculino    Edad: 65 años
Fecha de atención: 09/09/2026
Fecha de emisión: 10/09/2026 10:10

==== INMUNOLOGÍA ====
Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)

(*) Valor fuera del intervalo de referencia.
'),
 (11, 'CUL', '48614441', N'María', N'Guerrero Díaz', '1953-07-13', N'Femenino', N'Jr. Simón Bolívar N° 1562, Rioja', '974290249', 1, N'Asociación de Docentes UPN', 'TAR', '2', '2026-09-05T07:57:00', '2026-09-06T10:17:00', '2026-09-10T12:01:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Guerrero Díaz, María
DNI: 48614441    Sexo: Femenino    Edad: 73 años
Fecha de atención: 05/09/2026
Fecha de emisión: 06/09/2026 10:17

==== OTROS ANÁLISIS ====
ANCA
  Parámetro                   Resultado     Unidad      Referencia
  p-ANCA                      Negativo                  Negativo
  c-ANCA                      Positivo                  Negativo

==== HEMATOLOGÍA ====
Tiempo de coagulación y sangría
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de coagulación       11.5 *        min         5 - 10
  Tiempo de sangría           1.7           min         1 - 3

(*) Valor fuera del intervalo de referencia.
'),
 (12, 'CUL', '41050190', N'Carmen', N'Vásquez Guerrero', '1989-03-17', N'Femenino', N'Av. Atahualpa N° 146, Rioja', '961635369', 0, NULL, 'EFE', '2', '2026-09-23T09:16:00', '2026-09-24T10:24:00', '2026-09-26T12:12:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vásquez Guerrero, Carmen
DNI: 41050190    Sexo: Femenino    Edad: 37 años
Fecha de atención: 23/09/2026
Fecha de emisión: 24/09/2026 10:24

==== PARASITOLOGÍA ====
Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  Se observan               No se observan

==== HORMONAS ====
Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                13.8          ng/mL       Varía según fase del ciclo

==== INMUNOLOGÍA ====
Proteína C reactiva cuantitativa
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         7.7 *         mg/L        ≤ 5

(*) Valor fuera del intervalo de referencia.
'),
 (13, 'CUL', '42637405', N'Valeria Teresa', N'Castillo Díaz', '2006-01-15', N'Femenino', N'Jr. Ramírez Hurtado N° 1605, Rioja', '955823242', 0, NULL, 'EFE', '2', '2026-10-05T09:53:00', '2026-10-06T10:31:00', '2026-10-10T12:23:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Castillo Díaz, Valeria Teresa
DNI: 42637405    Sexo: Femenino    Edad: 20 años
Fecha de atención: 05/10/2026
Fecha de emisión: 06/10/2026 10:31

==== MARCADORES TUMORALES ====
CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     9.8           U/mL        ≤ 30

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      8.8           mg/dL       8.6 - 10.3

==== UROANÁLISIS ====
Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo

(*) Valor fuera del intervalo de referencia.
'),
 (14, 'CUL', '44919246', N'Julio', N'Ramírez Pezo', '2008-01-20', N'Masculino', N'Jr. Cajamarca N° 306, Rioja', '982415228', 0, NULL, 'EFE', '2', '2026-10-08T09:00:00', '2026-10-09T10:38:00', '2026-10-10T12:34:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ramírez Pezo, Julio
DNI: 44919246    Sexo: Masculino    Edad: 18 años
Fecha de atención: 08/10/2026
Fecha de emisión: 09/10/2026 10:38

==== INMUNOLOGÍA ====
Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  

==== HORMONAS ====
LH
  Parámetro                   Resultado     Unidad      Referencia
  LH                          6.4           mUI/mL      1.7 - 8.6

(*) Valor fuera del intervalo de referencia.
'),
 (15, 'CUL', '44531514', N'Luz', N'Del Águila Tafur', '1962-05-26', N'Femenino', N'Jr. Juan Pablo II N° 1067, Rioja', '954934734', 0, N'Asociación de Docentes UPN', 'EFE', '1', '2026-09-30T09:53:00', '2026-10-01T10:45:00', '2026-10-05T12:45:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Del Águila Tafur, Luz
DNI: 44531514    Sexo: Femenino    Edad: 64 años
Fecha de atención: 30/09/2026
Fecha de emisión: 01/10/2026 10:45

==== BIOQUÍMICA ====
Colesterol
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            51            mg/dL       ≤ 200

==== HEMATOLOGÍA ====
Recuento de reticulocitos
  Parámetro                   Resultado     Unidad      Referencia
  Reticulocitos               1.68          %           0.5 - 2.5

(*) Valor fuera del intervalo de referencia.
'),
 (16, 'CUL', '45920311', N'Luz María', N'Tapia Ríos', '1944-06-22', N'Femenino', N'Jr. Dos de Mayo N° 329, Rioja', '999737695', 0, NULL, 'EFE', '1', '2026-10-02T08:09:00', '2026-10-03T10:52:00', '2026-10-04T12:56:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tapia Ríos, Luz María
DNI: 45920311    Sexo: Femenino    Edad: 82 años
Fecha de atención: 02/10/2026
Fecha de emisión: 03/10/2026 10:52

==== MARCADORES TUMORALES ====
CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     23.7          U/mL        ≤ 30

==== HORMONAS ====
Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                15.5          ng/mL       Varía según fase del ciclo

(*) Valor fuera del intervalo de referencia.
'),
 (17, 'CUL', '46703329', N'Juan Renzo', N'Mori Ushiñahua', '2007-03-01', N'Masculino', N'Av. Atahualpa N° 784, Rioja', '921994445', 0, NULL, 'EFE', '1', '2026-10-17T08:40:00', '2026-10-18T10:59:00', '2026-10-22T13:07:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Mori Ushiñahua, Juan Renzo
DNI: 46703329    Sexo: Masculino    Edad: 19 años
Fecha de atención: 17/10/2026
Fecha de emisión: 18/10/2026 10:59

==== BIOQUÍMICA ====
Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               75            mg/dL       ≤ 150

(*) Valor fuera del intervalo de referencia.
'),
 (18, 'CUL', '48618827', N'Camila', N'Rojas García', '1954-05-14', N'Femenino', N'Jr. Juan Pablo II N° 1826, Rioja', '956645095', 1, NULL, 'EFE', '1', '2026-09-05T07:00:00', '2026-09-06T09:06:00', '2026-09-10T13:18:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Rojas García, Camila
DNI: 48618827    Sexo: Femenino    Edad: 72 años
Fecha de atención: 05/09/2026
Fecha de emisión: 06/09/2026 09:06

==== BIOQUÍMICA ====
Bilirrubina total y fraccionada
  Parámetro                   Resultado     Unidad      Referencia
  Bilirrubina total           0.40          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.11          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.85          mg/dL       0.1 - 1

(*) Valor fuera del intervalo de referencia.
'),
 (19, 'CUL', '41072588', N'Miguel', N'Bardales Pinedo', '2003-11-25', N'Masculino', N'Jr. Simón Bolívar N° 1928, Rioja', '923796892', 0, NULL, 'EFE', '1', '2026-10-03T09:13:00', '2026-10-04T09:13:00', '2026-10-07T13:29:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Bardales Pinedo, Miguel
DNI: 41072588    Sexo: Masculino    Edad: 22 años
Fecha de atención: 03/10/2026
Fecha de emisión: 04/10/2026 09:13

==== BIOQUÍMICA ====
Fosfatasa alcalina
  Parámetro                   Resultado     Unidad      Referencia
  Fosfatasa alcalina          84            U/L         40 - 129

(*) Valor fuera del intervalo de referencia.
'),
 (20, 'CUL', '44456620', N'Silvia', N'Ríos Shapiama', '1995-07-07', N'Femenino', N'Jr. Cajamarca N° 524, Rioja', '917298219', 0, NULL, 'EFE', '2', '2026-09-08T07:52:00', '2026-09-09T09:20:00', '2026-09-13T13:40:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ríos Shapiama, Silvia
DNI: 44456620    Sexo: Femenino    Edad: 31 años
Fecha de atención: 08/09/2026
Fecha de emisión: 09/09/2026 09:20

==== OTROS ANÁLISIS ====
Ácido fólico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido fólico                19.9          ng/mL       3.9 - 26.8

==== HORMONAS ====
Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         5.4 *         µUI/mL      0.27 - 4.2

(*) Valor fuera del intervalo de referencia.
'),
 (21, 'CUL', '41655907', N'Kevin', N'Arévalo Flores', '1992-05-10', N'Masculino', N'Jr. Juan Pablo II N° 416, Rioja', '935285223', 0, NULL, 'EFE', '1', '2026-10-31T07:49:00', '2026-11-01T09:27:00', '2026-11-02T13:51:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Arévalo Flores, Kevin
DNI: 41655907    Sexo: Masculino    Edad: 34 años
Fecha de atención: 31/10/2026
Fecha de emisión: 01/11/2026 09:27

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      8.7           mg/dL       8.6 - 10.3

==== PERFILES ====
Perfil lipídico
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            76            mg/dL       ≤ 200
  Triglicéridos               105           mg/dL       ≤ 150
  Colesterol HDL              52            mg/dL       ≥ 40
  Colesterol LDL              155 *         mg/dL       ≤ 130

(*) Valor fuera del intervalo de referencia.
'),
 (22, 'CUL', '42750297', N'Alberto', N'Reátegui Mendoza', '1987-11-25', N'Masculino', N'Jr. Grau N° 1047, Rioja', '980205580', 0, NULL, 'EFE', '1', '2026-10-03T09:04:00', '2026-10-04T09:34:00', '2026-10-07T14:02:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Reátegui Mendoza, Alberto
DNI: 42750297    Sexo: Masculino    Edad: 38 años
Fecha de atención: 03/10/2026
Fecha de emisión: 04/10/2026 09:34

==== INMUNOLOGÍA ====
Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)

==== BIOQUÍMICA ====
Colesterol HDL
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol HDL              63            mg/dL       ≥ 40

==== CULTIVOS ====
Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        0             UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            

(*) Valor fuera del intervalo de referencia.
'),
 (23, 'CUL', '42076369', N'Elena', N'Vargas Fasabi', '1957-02-07', N'Femenino', N'Jr. Santo Toribio N° 419, Rioja', '914824309', 0, NULL, 'EFE', '2', '2026-10-08T08:45:00', '2026-10-09T09:41:00', '2026-10-11T14:13:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vargas Fasabi, Elena
DNI: 42076369    Sexo: Femenino    Edad: 69 años
Fecha de atención: 08/10/2026
Fecha de emisión: 09/10/2026 09:41

==== INMUNOLOGÍA ====
Hepatitis A
  Parámetro                   Resultado     Unidad      Referencia
  Anti-HAV IgM                No reactivo               No reactivo
VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo

==== HORMONAS ====
T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    1.65          ng/dL       0.93 - 1.7

(*) Valor fuera del intervalo de referencia.
'),
 (24, 'CUL', '45947093', N'Silvia', N'Tafur Del Águila', '2000-05-20', N'Femenino', N'Jr. Grau N° 333, Rioja', '966421605', 0, NULL, 'EFE', '1', '2026-10-05T08:35:00', '2026-10-06T09:48:00', '2026-10-08T14:24:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tafur Del Águila, Silvia
DNI: 45947093    Sexo: Femenino    Edad: 26 años
Fecha de atención: 05/10/2026
Fecha de emisión: 06/10/2026 09:48

==== HEMATOLOGÍA ====
VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  14.9          mm/h        0 - 20

(*) Valor fuera del intervalo de referencia.
'),
 (25, 'CUL', '46816530', N'Renzo', N'Ríos Flores', '1961-07-02', N'Masculino', N'Jr. Dos de Mayo N° 688, Rioja', '985759583', 1, NULL, 'EFE', '2', '2026-10-27T09:56:00', '2026-10-28T09:55:00', '2026-10-31T14:35:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ríos Flores, Renzo
DNI: 46816530    Sexo: Masculino    Edad: 65 años
Fecha de atención: 27/10/2026
Fecha de emisión: 28/10/2026 09:55

==== BIOQUÍMICA ====
Ácido úrico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido úrico                 6.6           mg/dL       3.4 - 7

==== MARCADORES TUMORALES ====
CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     33            U/mL        ≤ 37

==== PERFILES ====
Perfil hepático
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   4 *           U/L         5 - 40
  TGP (ALT)                   31            U/L         5 - 41
  Bilirrubina total           0.46          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.23          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.59          mg/dL       0.1 - 1
  Fosfatasa alcalina          120           U/L         40 - 129
  Proteínas totales           6.9           g/dL        6.4 - 8.3
  Albúmina                    4.5           g/dL        3.5 - 5.2
  Globulina                   1.4 *         g/dL        2 - 3.5
  GGT                         13            U/L         8 - 61

==== HORMONAS ====
Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         3.6           µUI/mL      0.27 - 4.2

(*) Valor fuera del intervalo de referencia.
'),
 (26, 'CUL', '43777964', N'Gabriel César', N'Ushiñahua Salazar', '1991-05-11', N'Masculino', N'Av. Atahualpa N° 1824, Rioja', '991768060', 0, NULL, 'EFE', '1', '2026-09-03T09:25:00', '2026-09-04T10:02:00', '2026-09-05T14:46:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ushiñahua Salazar, Gabriel César
DNI: 43777964    Sexo: Masculino    Edad: 35 años
Fecha de atención: 03/09/2026
Fecha de emisión: 04/09/2026 10:02

==== BIOQUÍMICA ====
Glucosa basal
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa                     83            mg/dL       70 - 100

==== PARASITOLOGÍA ====
Parasitológico simple
  Parámetro                   Resultado     Unidad      Referencia
  Consistencia                Formada                   
  Parásitos                   No se observan            No se observan

==== PERFILES ====
Perfil lipídico
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            172           mg/dL       ≤ 200
  Triglicéridos               76            mg/dL       ≤ 150
  Colesterol HDL              29 *          mg/dL       ≥ 40
  Colesterol LDL              120           mg/dL       ≤ 130

(*) Valor fuera del intervalo de referencia.
'),
 (27, 'CUL', '47643386', N'Gabriel', N'Díaz Vásquez', '2021-10-07', N'Masculino', N'Jr. Ramírez Hurtado N° 1895, Rioja', '942099509', 0, NULL, 'EFE', '3', '2026-10-30T07:24:00', '2026-10-31T10:09:00', '2026-11-04T14:57:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Díaz Vásquez, Gabriel
DNI: 47643386    Sexo: Masculino    Edad: 5 años
Fecha de atención: 30/10/2026
Fecha de emisión: 31/10/2026 10:09

==== MARCADORES TUMORALES ====
CEA (antígeno carcinoembrionario)
  Parámetro                   Resultado     Unidad      Referencia
  CEA                         2.5           ng/mL       ≤ 5

==== HORMONAS ====
DHEA-S
  Parámetro                   Resultado     Unidad      Referencia
  DHEA-S                      209           µg/dL       80 - 560

==== OTROS ANÁLISIS ====
Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   266           ng/mL       30 - 400

(*) Valor fuera del intervalo de referencia.
'),
 (28, 'CUL', '43602007', N'Joel', N'Castillo Pizarro', '1997-12-06', N'Masculino', N'Jr. Juan Pablo II N° 1266, Rioja', '943037253', 0, NULL, 'EFE', '1', '2026-09-08T10:39:00', '2026-09-09T10:16:00', '2026-09-12T10:08:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Castillo Pizarro, Joel
DNI: 43602007    Sexo: Masculino    Edad: 28 años
Fecha de atención: 08/09/2026
Fecha de emisión: 09/09/2026 10:16

==== HEMATOLOGÍA ====
Hematocrito
  Parámetro                   Resultado     Unidad      Referencia
  Hematocrito                 47            %           41 - 53

==== MARCADORES CARDÍACOS ====
Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  54            ng/mL       ≤ 70

(*) Valor fuera del intervalo de referencia.
'),
 (29, 'CUL', '45833446', N'Pilar', N'Sánchez Reátegui', '1952-03-13', N'Femenino', N'Jr. Ramírez Hurtado N° 944, Rioja', '999530743', 0, NULL, 'TAR', '1', '2026-10-24T08:51:00', '2026-10-25T10:23:00', '2026-10-28T10:19:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Sánchez Reátegui, Pilar
DNI: 45833446    Sexo: Femenino    Edad: 74 años
Fecha de atención: 24/10/2026
Fecha de emisión: 25/10/2026 10:23

==== HORMONAS ====
Antimulleriana (AMH)
  Parámetro                   Resultado     Unidad      Referencia
  Hormona antimulleriana      0.8           ng/mL       Varía según la edad

==== OTROS ANÁLISIS ====
Vitamina B12
  Parámetro                   Resultado     Unidad      Referencia
  Vitamina B12                428           pg/mL       200 - 900

(*) Valor fuera del intervalo de referencia.
'),
 (30, 'CUL', '47470132', N'Mateo Diego', N'Gonzales Chávez', '2021-10-22', N'Masculino', N'Jr. Bolognesi N° 820, Rioja', '929261381', 0, NULL, 'EFE', '3', '2026-09-24T07:49:00', '2026-09-25T10:30:00', '2026-09-27T10:30:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Gonzales Chávez, Mateo Diego
DNI: 47470132    Sexo: Masculino    Edad: 4 años
Fecha de atención: 24/09/2026
Fecha de emisión: 25/09/2026 10:30

==== HORMONAS ====
DHEA-S
  Parámetro                   Resultado     Unidad      Referencia
  DHEA-S                      368           µg/dL       80 - 560

==== UROANÁLISIS ====
Proteína en orina de 24 horas
  Parámetro                   Resultado     Unidad      Referencia
  Volumen urinario de 24 h    1312          mL          800 - 2000
  Proteínas en orina de 24 h  43            mg/24 h     ≤ 150

==== BIOQUÍMICA ====
TGP (ALT)
  Parámetro                   Resultado     Unidad      Referencia
  TGP (ALT)                   16            U/L         5 - 41

(*) Valor fuera del intervalo de referencia.
'),
 (31, 'CUL', '45049107', N'Alexis', N'Huamán Vásquez', '1984-11-27', N'Masculino', N'Jr. Libertad N° 1533, Rioja', '925168150', 0, N'Asociación de Docentes UPN', 'TAR', '1', '2026-09-19T10:36:00', '2026-09-20T10:37:00', '2026-09-23T10:41:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Huamán Vásquez, Alexis
DNI: 45049107    Sexo: Masculino    Edad: 41 años
Fecha de atención: 19/09/2026
Fecha de emisión: 20/09/2026 10:37

==== BIOQUÍMICA ====
Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     3.0 *         %           4 - 5.7

==== PERFILES ====
Perfil hepático
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   8             U/L         5 - 40
  TGP (ALT)                   13            U/L         5 - 41
  Bilirrubina total           0.57          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.27          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.53          mg/dL       0.1 - 1
  Fosfatasa alcalina          112           U/L         40 - 129
  Proteínas totales           7.6           g/dL        6.4 - 8.3
  Albúmina                    5.0           g/dL        3.5 - 5.2
  Globulina                   2.4           g/dL        2 - 3.5
  GGT                         34            U/L         8 - 61

(*) Valor fuera del intervalo de referencia.
'),
 (32, 'CUL', '42320019', N'Rosa Flor', N'Tafur Vargas', '1944-12-27', N'Femenino', N'Jr. Dos de Mayo N° 1744, Rioja', '944652220', 1, NULL, 'EFE', '1', '2026-09-18T10:51:00', '2026-09-19T10:44:00', '2026-09-21T10:52:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tafur Vargas, Rosa Flor
DNI: 42320019    Sexo: Femenino    Edad: 81 años
Fecha de atención: 18/09/2026
Fecha de emisión: 19/09/2026 10:44

==== MARCADORES TUMORALES ====
CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     19            U/mL        ≤ 37

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            82            ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (33, 'CUL', '45275991', N'Patricia', N'Tuanama Tafur', '2003-05-12', N'Femenino', N'Jr. Libertad N° 477, Rioja', '939116967', 0, NULL, 'EFE', '2', '2026-09-22T10:58:00', '2026-09-23T10:51:00', '2026-09-27T11:03:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tuanama Tafur, Patricia
DNI: 45275991    Sexo: Femenino    Edad: 23 años
Fecha de atención: 22/09/2026
Fecha de emisión: 23/09/2026 10:51

==== BIOQUÍMICA ====
Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               142           mg/dL       ≤ 150

(*) Valor fuera del intervalo de referencia.
'),
 (34, 'CUL', '46392716', N'Joel', N'Ríos Del Águila', '1974-06-15', N'Masculino', N'Jr. Dos de Mayo N° 1432, Rioja', '914741892', 0, NULL, 'TAR', '1', '2026-09-07T07:07:00', '2026-09-08T10:58:00', '2026-09-12T11:14:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ríos Del Águila, Joel
DNI: 46392716    Sexo: Masculino    Edad: 52 años
Fecha de atención: 07/09/2026
Fecha de emisión: 08/09/2026 10:58

==== MARCADORES CARDÍACOS ====
Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  36            ng/mL       ≤ 70

==== CULTIVOS ====
Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Escherichia coli            Sin crecimiento bacteriano
  Recuento de colonias        100000 *      UFC/mL      ≤ 10000
  Antibiograma                Sensible a nitrofurantoína y ciprofloxacino; resistente a ampicilina            

(*) Valor fuera del intervalo de referencia.
'),
 (35, 'CUL', '48382388', N'Sebastián', N'Ushiñahua Pinedo', '2007-09-13', N'Masculino', N'Jr. Huallaga N° 125, Rioja', '951696546', 0, NULL, 'TAR', '2', '2026-10-03T09:11:00', '2026-10-04T09:05:00', '2026-10-08T11:25:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ushiñahua Pinedo, Sebastián
DNI: 48382388    Sexo: Masculino    Edad: 19 años
Fecha de atención: 03/10/2026
Fecha de emisión: 04/10/2026 09:05

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.0          mg/dL       8.6 - 10.3

==== UROANÁLISIS ====
Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo

(*) Valor fuera del intervalo de referencia.
'),
 (36, 'CUL', '45735312', N'Mateo', N'Pérez Ramos', '2010-11-22', N'Masculino', N'Jr. Cajamarca N° 1972, Rioja', '942635886', 0, NULL, 'EFE', '1', '2026-11-02T09:26:00', '2026-11-03T09:12:00', '2026-11-06T11:36:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pérez Ramos, Mateo
DNI: 45735312    Sexo: Masculino    Edad: 15 años
Fecha de atención: 02/11/2026
Fecha de emisión: 03/11/2026 09:12

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      9.7           mg/dL       8.6 - 10.3
Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               127           mg/dL       ≤ 150

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            27 *          ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (37, 'CUL', '45274997', N'Óscar Carlos', N'Saavedra Del Águila', '1967-08-01', N'Masculino', N'Jr. Santo Toribio N° 1282, Rioja', '970786366', 0, N'Colegio de Ingenieros del Perú', 'TAR', '2', '2026-09-24T10:17:00', '2026-09-25T09:19:00', '2026-09-26T11:47:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Saavedra Del Águila, Óscar Carlos
DNI: 45274997    Sexo: Masculino    Edad: 59 años
Fecha de atención: 24/09/2026
Fecha de emisión: 25/09/2026 09:19

==== INMUNOLOGÍA ====
Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo

(*) Valor fuera del intervalo de referencia.
'),
 (38, 'CUL', '43551052', N'Luis', N'Rojas Castillo', '2023-05-17', N'Masculino', N'Jr. Grau N° 208, Rioja', '963003900', 0, NULL, 'EFE', '3', '2026-10-17T09:41:00', '2026-10-18T09:26:00', '2026-10-22T11:58:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Rojas Castillo, Luis
DNI: 43551052    Sexo: Masculino    Edad: 3 años
Fecha de atención: 17/10/2026
Fecha de emisión: 18/10/2026 09:26

==== PARASITOLOGÍA ====
Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan

==== BIOQUÍMICA ====
Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     3.7 *         %           4 - 5.7

(*) Valor fuera del intervalo de referencia.
'),
 (39, 'CUL', '43256783', N'Rocío Jimena', N'Huamán Castillo', '2010-03-07', N'Femenino', N'Jr. Cajamarca N° 1063, Rioja', '951083443', 1, NULL, 'EFE', '1', '2026-09-07T08:39:00', '2026-09-08T09:33:00', '2026-09-12T12:09:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Huamán Castillo, Rocío Jimena
DNI: 43256783    Sexo: Femenino    Edad: 16 años
Fecha de atención: 07/09/2026
Fecha de emisión: 08/09/2026 09:33

==== BIOQUÍMICA ====
Colesterol
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            104           mg/dL       ≤ 200

==== OTROS ANÁLISIS ====
Herpes I, II (IgG/IgM)
  Parámetro                   Resultado     Unidad      Referencia
  Herpes I, II IgG            No reactivo               No reactivo
  Herpes I, II IgM            No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (40, 'CUL', '40512593', N'Wilmer Juan', N'Vásquez Pinedo', '1983-08-08', N'Masculino', N'Jr. Grau N° 1363, Rioja', '938759903', 0, NULL, 'EFE', '2', '2026-10-30T08:51:00', '2026-10-31T09:40:00', '2026-11-01T12:20:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vásquez Pinedo, Wilmer Juan
DNI: 40512593    Sexo: Masculino    Edad: 43 años
Fecha de atención: 30/10/2026
Fecha de emisión: 31/10/2026 09:40

==== CULTIVOS ====
Cultivo de secreción uretral
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            38            ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (41, 'CUL', '48596971', N'Carmen', N'Bardales Pérez', '2026-04-29', N'Femenino', N'Jr. Faustino Maldonado N° 1400, Rioja', '942165914', 0, NULL, 'EFE', '3', '2026-10-24T08:25:00', '2026-10-25T09:47:00', '2026-10-27T12:31:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Bardales Pérez, Carmen
DNI: 48596971    Sexo: Femenino    Edad: 0 años
Fecha de atención: 24/10/2026
Fecha de emisión: 25/10/2026 09:47

==== PERFILES ====
Perfil recién nacido
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 20.5          g/dL        14 - 24
  Hematocrito                 54            %           44 - 64
  Glucosa                     78            mg/dL       40 - 100
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Proteína C reactiva         3.9           mg/L        ≤ 5

(*) Valor fuera del intervalo de referencia.
'),
 (42, 'CUL', '44644806', N'Diego Manuel', N'Vásquez Tuanama', '1973-02-04', N'Masculino', N'Jr. Huallaga N° 1151, Rioja', '935807771', 0, NULL, 'EFE', '1', '2026-09-12T08:34:00', '2026-09-13T09:54:00', '2026-09-17T12:42:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vásquez Tuanama, Diego Manuel
DNI: 44644806    Sexo: Masculino    Edad: 53 años
Fecha de atención: 12/09/2026
Fecha de emisión: 13/09/2026 09:54

==== BIOQUÍMICA ====
GGT
  Parámetro                   Resultado     Unidad      Referencia
  GGT                         47            U/L         8 - 61

(*) Valor fuera del intervalo de referencia.
'),
 (43, 'CUL', '41482358', N'Segundo', N'Fasabi Bardales', '1951-04-26', N'Masculino', N'Jr. Bolognesi N° 656, Rioja', '940697449', 0, NULL, 'TAR', '1', '2026-10-31T10:22:00', '2026-11-01T10:01:00', '2026-11-02T12:53:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Fasabi Bardales, Segundo
DNI: 41482358    Sexo: Masculino    Edad: 75 años
Fecha de atención: 31/10/2026
Fecha de emisión: 01/11/2026 10:01

==== BIOQUÍMICA ====
TGP (ALT)
  Parámetro                   Resultado     Unidad      Referencia
  TGP (ALT)                   12            U/L         5 - 41

==== HEMATOLOGÍA ====
Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.1          s           11 - 13.5
  INR                         1.04          índice      0.8 - 1.2

(*) Valor fuera del intervalo de referencia.
'),
 (44, 'CUL', '43718717', N'Camila Ana', N'Díaz Vásquez', '1974-04-03', N'Femenino', N'Jr. San Martín N° 1683, Rioja', '999125283', 0, NULL, 'EFE', '1', '2026-10-13T09:22:00', '2026-10-14T10:08:00', '2026-10-18T13:04:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Díaz Vásquez, Camila Ana
DNI: 43718717    Sexo: Femenino    Edad: 52 años
Fecha de atención: 13/10/2026
Fecha de emisión: 14/10/2026 10:08

==== INMUNOLOGÍA ====
Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo

==== MARCADORES CARDÍACOS ====
Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  83 *          ng/mL       ≤ 70

==== HEMATOLOGÍA ====
VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  15.7          mm/h        0 - 20

(*) Valor fuera del intervalo de referencia.
'),
 (45, 'CUL', '41984528', N'Ana', N'Shapiama García', '1955-08-25', N'Femenino', N'Jr. Bolognesi N° 1787, Rioja', '966114988', 0, NULL, 'EFE', '1', '2026-09-10T08:19:00', '2026-09-11T10:15:00', '2026-09-12T13:15:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Shapiama García, Ana
DNI: 41984528    Sexo: Femenino    Edad: 71 años
Fecha de atención: 10/09/2026
Fecha de emisión: 11/09/2026 10:15

==== INMUNOLOGÍA ====
Proteína C reactiva cualitativa
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         Negativo                  Negativo

==== HORMONAS ====
T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    1.45          ng/dL       0.93 - 1.7

(*) Valor fuera del intervalo de referencia.
'),
 (46, 'CUL', '48102509', N'Segundo Juan', N'Ramírez Panduro', '1972-04-09', N'Masculino', N'Jr. San Martín N° 207, Rioja', '956129959', 1, NULL, 'EFE', '1', '2026-09-21T08:17:00', '2026-09-22T10:22:00', '2026-09-25T13:26:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ramírez Panduro, Segundo Juan
DNI: 48102509    Sexo: Masculino    Edad: 54 años
Fecha de atención: 21/09/2026
Fecha de emisión: 22/09/2026 10:22

==== MARCADORES TUMORALES ====
CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     30            U/mL        ≤ 37

==== PARASITOLOGÍA ====
Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan

(*) Valor fuera del intervalo de referencia.
'),
 (47, 'CUL', '44528152', N'Óscar Jorge', N'Lozano Pezo', '1946-04-29', N'Masculino', N'Jr. Grau N° 883, Rioja', '920124499', 0, NULL, 'EFE', '2', '2026-10-08T07:38:00', '2026-10-09T10:29:00', '2026-10-13T13:37:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Lozano Pezo, Óscar Jorge
DNI: 44528152    Sexo: Masculino    Edad: 80 años
Fecha de atención: 08/10/2026
Fecha de emisión: 09/10/2026 10:29

==== PARASITOLOGÍA ====
Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan

==== INMUNOLOGÍA ====
VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (48, 'CUL', '46198859', N'Mateo Víctor', N'Shapiama Guerrero', '1985-12-16', N'Masculino', N'Jr. Ramírez Hurtado N° 642, Rioja', '956003590', 0, NULL, 'EFE', '2', '2026-10-19T07:32:00', '2026-10-20T10:36:00', '2026-10-23T13:48:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Shapiama Guerrero, Mateo Víctor
DNI: 46198859    Sexo: Masculino    Edad: 40 años
Fecha de atención: 19/10/2026
Fecha de emisión: 20/10/2026 10:36

==== PARASITOLOGÍA ====
Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan

==== INMUNOLOGÍA ====
Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  

(*) Valor fuera del intervalo de referencia.
'),
 (49, 'CUL', '42996336', N'Edwin', N'Gonzales Rojas', '2018-04-25', N'Masculino', N'Jr. Juan Pablo II N° 564, Rioja', '938798026', 0, NULL, 'EFE', '3', '2026-09-19T10:39:00', '2026-09-20T10:43:00', '2026-09-21T13:59:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Gonzales Rojas, Edwin
DNI: 42996336    Sexo: Masculino    Edad: 8 años
Fecha de atención: 19/09/2026
Fecha de emisión: 20/09/2026 10:43

==== BIOQUÍMICA ====
Creatinina
  Parámetro                   Resultado     Unidad      Referencia
  Creatinina                  0.53 *        mg/dL       0.7 - 1.3
Tolerancia a la glucosa
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa basal               74            mg/dL       70 - 100
  Glucosa a la 1 hora         48            mg/dL       ≤ 180
  Glucosa a las 2 horas       85            mg/dL       ≤ 140

(*) Valor fuera del intervalo de referencia.
'),
 (50, 'CUL', '41781842', N'Rocío', N'Fernández Salazar', '1968-09-18', N'Femenino', N'Av. Atahualpa N° 1189, Rioja', '971445490', 0, NULL, 'TAR', '2', '2026-09-18T08:05:00', '2026-09-19T10:50:00', '2026-09-22T14:10:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Fernández Salazar, Rocío
DNI: 41781842    Sexo: Femenino    Edad: 58 años
Fecha de atención: 18/09/2026
Fecha de emisión: 19/09/2026 10:50

==== PERFILES ====
Perfil pre operatorio
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 19.3 *        g/dL        12 - 16
  Hematocrito                 39            %           36 - 46
  Leucocitos                  10.5          x10³/µL     4.5 - 11
  Plaquetas                   303           x10³/µL     150 - 450
  Glucosa                     81            mg/dL       70 - 100
  Urea                        49 *          mg/dL       15 - 45
  Creatinina                  0.61          mg/dL       0.5 - 1.1
  VIH                         No reactivo               No reactivo
  Sífilis                     No reactivo               No reactivo
  HBsAg                       No reactivo               No reactivo
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Tiempo de coagulación       7.9           min         5 - 10
  Tiempo de sangría           2.5           min         1 - 3
  Examen completo de orina    Sin alteraciones            Sin alteraciones

(*) Valor fuera del intervalo de referencia.
');
INSERT INTO #Caso VALUES
 (51, 'CUL', '44625441', N'Silvia Juana', N'Pinedo Sánchez', '1983-04-22', N'Femenino', N'Jr. Coronel Portillo N° 793, Rioja', '968263452', 0, NULL, 'EFE', '2', '2026-09-03T09:14:00', '2026-09-04T10:57:00', '2026-09-08T14:21:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pinedo Sánchez, Silvia Juana
DNI: 44625441    Sexo: Femenino    Edad: 43 años
Fecha de atención: 03/09/2026
Fecha de emisión: 04/09/2026 10:57

==== OTROS ANÁLISIS ====
ANCA
  Parámetro                   Resultado     Unidad      Referencia
  p-ANCA                      Negativo                  Negativo
  c-ANCA                      Negativo                  Negativo

(*) Valor fuera del intervalo de referencia.
'),
 (52, 'CUL', '48166954', N'Elena Daniela', N'Flores Ushiñahua', '2011-02-28', N'Femenino', N'Jr. Simón Bolívar N° 1381, Rioja', '943531083', 0, NULL, 'EFE', '2', '2026-10-01T07:22:00', '2026-10-02T09:04:00', '2026-10-03T14:32:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Flores Ushiñahua, Elena Daniela
DNI: 48166954    Sexo: Femenino    Edad: 15 años
Fecha de atención: 01/10/2026
Fecha de emisión: 02/10/2026 09:04

==== HEMATOLOGÍA ====
Tiempo de coagulación y sangría
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de coagulación       5.5           min         5 - 10
  Tiempo de sangría           2.3           min         1 - 3

(*) Valor fuera del intervalo de referencia.
'),
 (53, 'CUL', '48712364', N'Víctor', N'Torres Mori', '1979-02-12', N'Masculino', N'Jr. Huallaga N° 1808, Rioja', '999581782', 1, NULL, 'EFE', '2', '2026-09-26T07:13:00', '2026-09-27T09:11:00', '2026-09-30T14:43:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Torres Mori, Víctor
DNI: 48712364    Sexo: Masculino    Edad: 47 años
Fecha de atención: 26/09/2026
Fecha de emisión: 27/09/2026 09:11

==== INMUNOLOGÍA ====
Factor reumatoide cualitativo
  Parámetro                   Resultado     Unidad      Referencia
  Factor reumatoide           Negativo                  Negativo

==== PARASITOLOGÍA ====
Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan

==== MARCADORES TUMORALES ====
PSA libre
  Parámetro                   Resultado     Unidad      Referencia
  PSA libre                   0.87          ng/mL       
  Relación PSA libre / total  90            %           25 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (54, 'CUL', '41278608', N'Karina', N'Tuanama Vásquez', '1966-04-28', N'Femenino', N'Jr. Juan Pablo II N° 577, Rioja', '912382525', 0, NULL, 'EFE', '1', '2026-10-10T07:21:00', '2026-10-11T09:18:00', '2026-10-12T14:54:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tuanama Vásquez, Karina
DNI: 41278608    Sexo: Femenino    Edad: 60 años
Fecha de atención: 10/10/2026
Fecha de emisión: 11/10/2026 09:18

==== BIOQUÍMICA ====
Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       84            mg/dL       ≤ 140

==== OTROS ANÁLISIS ====
Helicobacter pylori antígeno en heces
  Parámetro                   Resultado     Unidad      Referencia
  Helicobacter pylori (antígeno)Negativo                  Negativo

==== HORMONAS ====
Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                19.2          ng/mL       Varía según fase del ciclo

(*) Valor fuera del intervalo de referencia.
'),
 (55, 'CUL', '41992932', N'Sofía', N'Gonzales Tapia', '1964-10-15', N'Femenino', N'Jr. Juan Pablo II N° 1584, Rioja', '910527017', 0, NULL, 'TAR', '1', '2026-09-08T09:08:00', '2026-09-09T09:25:00', '2026-09-12T10:05:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Gonzales Tapia, Sofía
DNI: 41992932    Sexo: Femenino    Edad: 61 años
Fecha de atención: 08/09/2026
Fecha de emisión: 09/09/2026 09:25

==== BIOQUÍMICA ====
Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     4.2           %           4 - 5.7

==== PARASITOLOGÍA ====
Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   Se observan               No se observan

(*) Valor fuera del intervalo de referencia.
'),
 (56, 'CUL', '47049222', N'Gladys', N'Reátegui Rodríguez', '1962-08-09', N'Femenino', N'Jr. Santo Toribio N° 1550, Rioja', '956433335', 0, NULL, 'EFE', '2', '2026-10-10T07:44:00', '2026-10-11T09:32:00', '2026-10-15T10:16:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Reátegui Rodríguez, Gladys
DNI: 47049222    Sexo: Femenino    Edad: 64 años
Fecha de atención: 10/10/2026
Fecha de emisión: 11/10/2026 09:32

==== HEMATOLOGÍA ====
Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       12.4          s           11 - 13.5
  INR                         1.17          índice      0.8 - 1.2

(*) Valor fuera del intervalo de referencia.
'),
 (57, 'CUL', '45884019', N'Gabriel', N'Fasabi Torres', '1961-12-28', N'Masculino', N'Jr. Faustino Maldonado N° 270, Rioja', '997146726', 0, NULL, 'TAR', '2', '2026-10-10T08:50:00', '2026-10-11T09:39:00', '2026-10-14T10:27:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Fasabi Torres, Gabriel
DNI: 45884019    Sexo: Masculino    Edad: 64 años
Fecha de atención: 10/10/2026
Fecha de emisión: 11/10/2026 09:39

==== HEMATOLOGÍA ====
Hematocrito
  Parámetro                   Resultado     Unidad      Referencia
  Hematocrito                 42            %           41 - 53

(*) Valor fuera del intervalo de referencia.
'),
 (58, 'CUL', '47954989', N'Karina', N'Pezo Salazar', '1951-12-21', N'Femenino', N'Jr. Grau N° 414, Rioja', '910694782', 0, NULL, 'TAR', '2', '2026-10-01T10:37:00', '2026-10-02T09:46:00', '2026-10-04T10:38:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pezo Salazar, Karina
DNI: 47954989    Sexo: Femenino    Edad: 74 años
Fecha de atención: 01/10/2026
Fecha de emisión: 02/10/2026 09:46

==== MARCADORES TUMORALES ====
CA-125
  Parámetro                   Resultado     Unidad      Referencia
  CA-125                      30            U/mL        ≤ 35

==== HEMATOLOGÍA ====
Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.3          s           11 - 13.5
  INR                         1.12          índice      0.8 - 1.2

==== CULTIVOS ====
Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        100000 *      UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            

(*) Valor fuera del intervalo de referencia.
'),
 (59, 'CUL', '45700075', N'Roxana María', N'Rojas Fasabi', '1956-04-10', N'Femenino', N'Jr. Faustino Maldonado N° 726, Rioja', '952007676', 0, NULL, 'EFE', '2', '2026-10-05T08:52:00', '2026-10-06T09:53:00', '2026-10-08T10:49:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Rojas Fasabi, Roxana María
DNI: 45700075    Sexo: Femenino    Edad: 70 años
Fecha de atención: 05/10/2026
Fecha de emisión: 06/10/2026 09:53

==== BIOQUÍMICA ====
GGT
  Parámetro                   Resultado     Unidad      Referencia
  GGT                         17            U/L         8 - 61

==== HEMATOLOGÍA ====
Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 8.9 *         g/dL        12 - 16

(*) Valor fuera del intervalo de referencia.
'),
 (60, 'CUL', '40327914', N'Milagros', N'Tuanama Sánchez', '1969-07-29', N'Femenino', N'Jr. Simón Bolívar N° 231, Rioja', '915682026', 1, N'Colegio de Ingenieros del Perú', 'EFE', '1', '2026-10-03T08:29:00', '2026-10-04T10:00:00', '2026-10-07T11:00:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tuanama Sánchez, Milagros
DNI: 40327914    Sexo: Femenino    Edad: 57 años
Fecha de atención: 03/10/2026
Fecha de emisión: 04/10/2026 10:00

==== MARCADORES TUMORALES ====
CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     19.4          U/mL        ≤ 30

==== HEMATOLOGÍA ====
Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.6          g/dL        12 - 16
  Leucocitos                  5.3           x10³/µL     4.5 - 11
  Plaquetas                   358           x10³/µL     150 - 450

(*) Valor fuera del intervalo de referencia.
'),
 (61, 'CUL', '40149876', N'Rocío Lucía', N'Sánchez Flores', '1974-05-06', N'Femenino', N'Jr. Libertad N° 1723, Rioja', '942631705', 0, NULL, 'EFE', '1', '2026-10-06T10:59:00', '2026-10-07T10:07:00', '2026-10-10T11:11:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Sánchez Flores, Rocío Lucía
DNI: 40149876    Sexo: Femenino    Edad: 52 años
Fecha de atención: 06/10/2026
Fecha de emisión: 07/10/2026 10:07

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            86            ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (62, 'CUL', '46707171', N'Pilar', N'Bardales Lozano', '1966-05-26', N'Femenino', N'Jr. Libertad N° 1102, Rioja', '983635550', 0, NULL, 'EFE', '1', '2026-10-06T09:44:00', '2026-10-07T10:14:00', '2026-10-08T11:22:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Bardales Lozano, Pilar
DNI: 46707171    Sexo: Femenino    Edad: 60 años
Fecha de atención: 06/10/2026
Fecha de emisión: 07/10/2026 10:14

==== BIOQUÍMICA ====
TGO (AST)
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   10            U/L         5 - 40

(*) Valor fuera del intervalo de referencia.
'),
 (63, 'CUL', '42844302', N'Juana', N'Tuanama Saavedra', '1979-06-09', N'Femenino', N'Jr. Ramírez Hurtado N° 321, Rioja', '958698390', 0, NULL, 'EFE', '2', '2026-10-16T10:35:00', '2026-10-17T10:21:00', '2026-10-20T11:33:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tuanama Saavedra, Juana
DNI: 42844302    Sexo: Femenino    Edad: 47 años
Fecha de atención: 16/10/2026
Fecha de emisión: 17/10/2026 10:21

==== BIOQUÍMICA ====
Creatinina
  Parámetro                   Resultado     Unidad      Referencia
  Creatinina                  0.56          mg/dL       0.5 - 1.1
Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               142           mg/dL       ≤ 150

(*) Valor fuera del intervalo de referencia.
'),
 (64, 'CUL', '46679504', N'Rosa', N'Ramírez Castillo', '2003-12-14', N'Femenino', N'Jr. San Martín N° 482, Rioja', '978465269', 0, NULL, 'EFE', '2', '2026-09-17T08:45:00', '2026-09-18T10:28:00', '2026-09-22T11:44:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ramírez Castillo, Rosa
DNI: 46679504    Sexo: Femenino    Edad: 22 años
Fecha de atención: 17/09/2026
Fecha de emisión: 18/09/2026 10:28

==== BIOQUÍMICA ====
TGO (AST)
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   28            U/L         5 - 40

==== HEMATOLOGÍA ====
Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       8.2 *         s           11 - 13.5
  INR                         0.89          índice      0.8 - 1.2

==== OTROS ANÁLISIS ====
Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            40            ng/mL       30 - 100

(*) Valor fuera del intervalo de referencia.
'),
 (65, 'CUL', '46924862', N'Sebastián', N'Lozano Ramos', '1953-08-28', N'Masculino', N'Jr. San Martín N° 947, Rioja', '937038026', 0, NULL, 'EFE', '2', '2026-10-05T07:51:00', '2026-10-06T10:35:00', '2026-10-10T11:55:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Lozano Ramos, Sebastián
DNI: 46924862    Sexo: Masculino    Edad: 73 años
Fecha de atención: 05/10/2026
Fecha de emisión: 06/10/2026 10:35

==== OTROS ANÁLISIS ====
Ácido fólico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido fólico                22.3          ng/mL       3.9 - 26.8

==== BIOQUÍMICA ====
Colesterol LDL
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol LDL              160 *         mg/dL       ≤ 130

==== INMUNOLOGÍA ====
Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo

(*) Valor fuera del intervalo de referencia.
'),
 (66, 'CUL', '40513464', N'Pedro', N'Pizarro Panduro', '1995-10-23', N'Masculino', N'Jr. Coronel Portillo N° 722, Rioja', '949539382', 0, NULL, 'EFE', '1', '2026-10-23T09:08:00', '2026-10-24T10:42:00', '2026-10-28T12:06:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pizarro Panduro, Pedro
DNI: 40513464    Sexo: Masculino    Edad: 31 años
Fecha de atención: 23/10/2026
Fecha de emisión: 24/10/2026 10:42

==== OTROS ANÁLISIS ====
Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   312           ng/mL       30 - 400

==== PARASITOLOGÍA ====
Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  Se observan               No se observan

==== MARCADORES CARDÍACOS ====
PCR cuantitativo (cardíaco)
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         6.3 *         mg/L        ≤ 5

(*) Valor fuera del intervalo de referencia.
'),
 (67, 'CUL', '43873684', N'Ricardo Wilmer', N'Shapiama Flores', '1945-08-22', N'Masculino', N'Jr. Simón Bolívar N° 1202, Rioja', '924085366', 1, NULL, 'EFE', '1', '2026-10-20T08:23:00', '2026-10-21T10:49:00', '2026-10-22T12:17:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Shapiama Flores, Ricardo Wilmer
DNI: 43873684    Sexo: Masculino    Edad: 81 años
Fecha de atención: 20/10/2026
Fecha de emisión: 21/10/2026 10:49

==== UROANÁLISIS ====
Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo

(*) Valor fuera del intervalo de referencia.
'),
 (68, 'CUL', '46268953', N'Manuel Raúl', N'Saavedra Vargas', '2004-08-06', N'Masculino', N'Jr. Coronel Portillo N° 438, Rioja', '930621025', 0, NULL, 'EFE', '1', '2026-10-02T10:55:00', '2026-10-03T10:56:00', '2026-10-05T12:28:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Saavedra Vargas, Manuel Raúl
DNI: 46268953    Sexo: Masculino    Edad: 22 años
Fecha de atención: 02/10/2026
Fecha de emisión: 03/10/2026 10:56

==== CULTIVOS ====
Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        0             UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            

(*) Valor fuera del intervalo de referencia.
'),
 (69, 'CUL', '41595260', N'Patricia', N'Vásquez Lozano', '1973-01-31', N'Femenino', N'Jr. Juan Pablo II N° 555, Rioja', '927568520', 0, NULL, 'EFE', '2', '2026-10-31T08:41:00', '2026-11-01T09:03:00', '2026-11-03T12:39:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Vásquez Lozano, Patricia
DNI: 41595260    Sexo: Femenino    Edad: 53 años
Fecha de atención: 31/10/2026
Fecha de emisión: 01/11/2026 09:03

==== HORMONAS ====
Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         3.1           µUI/mL      0.27 - 4.2

(*) Valor fuera del intervalo de referencia.
'),
 (70, 'CUL', '48602416', N'Yesenia', N'Pérez Guerrero', '2004-04-06', N'Femenino', N'Jr. Grau N° 1233, Rioja', '918126743', 0, N'Asociación de Docentes UPN', 'EFE', '1', '2026-09-03T07:09:00', '2026-09-04T09:10:00', '2026-09-08T12:50:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pérez Guerrero, Yesenia
DNI: 48602416    Sexo: Femenino    Edad: 22 años
Fecha de atención: 03/09/2026
Fecha de emisión: 04/09/2026 09:10

==== HORMONAS ====
T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    0.69 *        ng/dL       0.93 - 1.7

(*) Valor fuera del intervalo de referencia.
'),
 (71, 'ENT', '48114015', N'Milagros', N'Cárdenas Bardales', '1957-09-21', N'Femenino', N'Jr. Simón Bolívar N° 1378, Rioja', '991790752', 0, NULL, 'TAR', '1', '2026-11-04T10:56:00', '2026-11-05T09:17:00', '2026-11-06T13:01:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Cárdenas Bardales, Milagros
DNI: 48114015    Sexo: Femenino    Edad: 69 años
Fecha de atención: 04/11/2026
Fecha de emisión: 05/11/2026 09:17

==== OTROS ANÁLISIS ====
Helicobacter pylori antígeno en heces
  Parámetro                   Resultado     Unidad      Referencia
  Helicobacter pylori (antígeno)Negativo                  Negativo

==== PARASITOLOGÍA ====
Rotavirus y adenovirus
  Parámetro                   Resultado     Unidad      Referencia
  Rotavirus                   Negativo                  Negativo
  Adenovirus                  Positivo                  Negativo

==== INMUNOLOGÍA ====
Sífilis (prueba rápida)
  Parámetro                   Resultado     Unidad      Referencia
  Sífilis                     No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (72, 'ENT', '48498493', N'Pilar Valeria', N'Del Águila Mori', '1983-02-06', N'Femenino', N'Jr. Faustino Maldonado N° 724, Rioja', '995272407', 0, N'Asociación de Docentes UPN', 'EFE', '1', '2026-11-02T07:31:00', '2026-11-03T09:24:00', '2026-11-04T13:12:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Del Águila Mori, Pilar Valeria
DNI: 48498493    Sexo: Femenino    Edad: 43 años
Fecha de atención: 02/11/2026
Fecha de emisión: 03/11/2026 09:24

==== INMUNOLOGÍA ====
B-HCG cualitativa
  Parámetro                   Resultado     Unidad      Referencia
  B-HCG                       Negativo                  Negativo

==== HEMATOLOGÍA ====
Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 15.1          g/dL        12 - 16
  Leucocitos                  9.9           x10³/µL     4.5 - 11
  Plaquetas                   221           x10³/µL     150 - 450

(*) Valor fuera del intervalo de referencia.
'),
 (73, 'ENT', '40901663', N'Diego Eduardo', N'García Ramírez', '1966-06-16', N'Masculino', N'Jr. Simón Bolívar N° 1190, Rioja', '939122530', 0, NULL, 'EFE', '1', '2026-11-03T07:05:00', '2026-11-04T09:31:00', '2026-11-05T13:23:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: García Ramírez, Diego Eduardo
DNI: 40901663    Sexo: Masculino    Edad: 60 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 09:31

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.1          mg/dL       8.6 - 10.3

==== INMUNOLOGÍA ====
Sífilis (prueba rápida)
  Parámetro                   Resultado     Unidad      Referencia
  Sífilis                     No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (74, 'ENT', '42899183', N'Edwin', N'Ushiñahua Pérez', '1959-04-03', N'Masculino', N'Av. Atahualpa N° 586, Rioja', '912557888', 0, NULL, 'EFE', '1', '2026-11-03T08:28:00', '2026-11-04T09:38:00', '2026-11-05T13:34:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ushiñahua Pérez, Edwin
DNI: 42899183    Sexo: Masculino    Edad: 67 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 09:38

==== BIOQUÍMICA ====
Ácido úrico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido úrico                 5.3           mg/dL       3.4 - 7

==== OTROS ANÁLISIS ====
Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   80            ng/mL       30 - 400

(*) Valor fuera del intervalo de referencia.
'),
 (75, 'ENT', '46991302', N'Milagros', N'Díaz Pezo', '1992-09-12', N'Femenino', N'Jr. Dos de Mayo N° 242, Rioja', '944152501', 0, NULL, 'EFE', '2', '2026-11-04T09:20:00', '2026-11-05T09:45:00', '2026-11-06T13:45:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Díaz Pezo, Milagros
DNI: 46991302    Sexo: Femenino    Edad: 34 años
Fecha de atención: 04/11/2026
Fecha de emisión: 05/11/2026 09:45

==== HORMONAS ====
Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         2.6           µUI/mL      0.27 - 4.2

(*) Valor fuera del intervalo de referencia.
'),
 (76, 'DIS', '41711091', N'Pedro Fernando', N'Tapia Reátegui', '1985-04-02', N'Masculino', N'Jr. Coronel Portillo N° 535, Rioja', '951681689', 0, NULL, 'TAR', '1', '2026-11-02T08:00:00', '2026-11-03T09:52:00', '2026-11-05T13:56:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Tapia Reátegui, Pedro Fernando
DNI: 41711091    Sexo: Masculino    Edad: 41 años
Fecha de atención: 02/11/2026
Fecha de emisión: 03/11/2026 09:52

==== OTROS ANÁLISIS ====
Cortisol
  Parámetro                   Resultado     Unidad      Referencia
  Cortisol (mañana)           5.8 *         µg/dL       6.2 - 19.4

==== CULTIVOS ====
Cultivo de semen (espermocultivo)
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            

(*) Valor fuera del intervalo de referencia.
'),
 (77, 'DIS', '48324933', N'Flor Diana', N'García Fernández', '1973-10-03', N'Femenino', N'Jr. Coronel Portillo N° 1725, Rioja', '980463047', 0, NULL, 'EFE', '2', '2026-11-03T10:02:00', '2026-11-04T09:59:00', '2026-11-07T14:07:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: García Fernández, Flor Diana
DNI: 48324933    Sexo: Femenino    Edad: 53 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 09:59

==== MARCADORES CARDÍACOS ====
Troponina I
  Parámetro                   Resultado     Unidad      Referencia
  Troponina I                 0.028         ng/mL       ≤ 0.04

==== HEMATOLOGÍA ====
VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  13.9          mm/h        0 - 20

(*) Valor fuera del intervalo de referencia.
'),
 (78, 'DIS', '42031621', N'Yesenia Norma', N'Torres Bardales', '1955-11-10', N'Femenino', N'Jr. Grau N° 496, Rioja', '991978353', 0, NULL, 'EFE', '2', '2026-11-03T10:43:00', '2026-11-04T10:06:00', '2026-11-08T14:18:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Torres Bardales, Yesenia Norma
DNI: 42031621    Sexo: Femenino    Edad: 70 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 10:06

==== MARCADORES TUMORALES ====
CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     21.7          U/mL        ≤ 30

==== HORMONAS ====
Estradiol
  Parámetro                   Resultado     Unidad      Referencia
  Estradiol                   285           pg/mL       Varía según fase del ciclo

==== INMUNOLOGÍA ====
Factor reumatoide cualitativo
  Parámetro                   Resultado     Unidad      Referencia
  Factor reumatoide           Negativo                  Negativo

(*) Valor fuera del intervalo de referencia.
'),
 (79, 'DIS', '47776573', N'Patricia', N'Lozano Salazar', '1948-05-23', N'Femenino', N'Av. Atahualpa N° 503, Rioja', '956391662', 0, NULL, 'EFE', '1', '2026-11-03T10:59:00', '2026-11-04T10:13:00', '2026-11-07T14:29:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Lozano Salazar, Patricia
DNI: 47776573    Sexo: Femenino    Edad: 78 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 10:13

==== HORMONAS ====
Prolactina
  Parámetro                   Resultado     Unidad      Referencia
  Prolactina                  30.0 *        ng/mL       4.8 - 23.3

(*) Valor fuera del intervalo de referencia.
'),
 (80, 'DIS', '41100376', N'Pilar', N'Chávez Tuanama', '2024-10-16', N'Femenino', N'Jr. San Martín N° 143, Rioja', '985703813', 0, NULL, 'EFE', '3', '2026-11-04T09:20:00', '2026-11-05T10:20:00', '2026-11-06T14:40:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Chávez Tuanama, Pilar
DNI: 41100376    Sexo: Femenino    Edad: 2 años
Fecha de atención: 04/11/2026
Fecha de emisión: 05/11/2026 10:20

==== BIOQUÍMICA ====
Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       107           mg/dL       ≤ 140

==== PARASITOLOGÍA ====
Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan

(*) Valor fuera del intervalo de referencia.
'),
 (81, 'PAU', '44612185', N'Eduardo', N'Bardales Sánchez', '1975-02-12', N'Masculino', N'Jr. Huallaga N° 1255, Rioja', '912552573', 0, NULL, 'EFE', '2', '2026-11-04T07:36:00', '2026-11-05T10:27:00', '2026-11-07T14:51:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Bardales Sánchez, Eduardo
DNI: 44612185    Sexo: Masculino    Edad: 51 años
Fecha de atención: 04/11/2026
Fecha de emisión: 05/11/2026 10:27

==== PERFILES ====
Perfil pre operatorio
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 15.9          g/dL        13.5 - 17.5
  Hematocrito                 48            %           41 - 53
  Leucocitos                  9.2           x10³/µL     4.5 - 11
  Plaquetas                   584 *         x10³/µL     150 - 450
  Glucosa                     79            mg/dL       70 - 100
  Urea                        33            mg/dL       15 - 45
  Creatinina                  1.43 *        mg/dL       0.7 - 1.3
  VIH                         Reactivo                  No reactivo
  Sífilis                     No reactivo               No reactivo
  HBsAg                       No reactivo               No reactivo
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Tiempo de coagulación       9.2           min         5 - 10
  Tiempo de sangría           2.1           min         1 - 3
  Examen completo de orina    Sin alteraciones            Sin alteraciones

==== MARCADORES TUMORALES ====
PSA total
  Parámetro                   Resultado     Unidad      Referencia
  PSA total                   1.3           ng/mL       ≤ 4

(*) Valor fuera del intervalo de referencia.
'),
 (82, 'PAU', '40621003', N'Gladys', N'Flores Gonzales', '1997-09-24', N'Femenino', N'Jr. Simón Bolívar N° 100, Rioja', '994235078', 0, NULL, 'EFE', '1', '2026-11-04T07:41:00', '2026-11-05T10:34:00', '2026-11-09T10:02:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Flores Gonzales, Gladys
DNI: 40621003    Sexo: Femenino    Edad: 29 años
Fecha de atención: 04/11/2026
Fecha de emisión: 05/11/2026 10:34

==== INMUNOLOGÍA ====
Hepatitis A
  Parámetro                   Resultado     Unidad      Referencia
  Anti-HAV IgM                No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (83, 'PAU', '44617451', N'Yesenia María', N'Ushiñahua Chávez', '1992-09-22', N'Femenino', N'Jr. Grau N° 1503, Rioja', '959967578', 0, N'Asociación de Docentes UPN', 'EFE', '2', '2026-11-03T08:08:00', '2026-11-04T10:41:00', '2026-11-06T10:13:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Ushiñahua Chávez, Yesenia María
DNI: 44617451    Sexo: Femenino    Edad: 34 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 10:41

==== BIOQUÍMICA ====
Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.1          mg/dL       8.6 - 10.3

==== MARCADORES CARDÍACOS ====
Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  41            ng/mL       ≤ 70

==== PARASITOLOGÍA ====
Parasitológico simple
  Parámetro                   Resultado     Unidad      Referencia
  Consistencia                Blanda                    
  Parásitos                   No se observan            No se observan

(*) Valor fuera del intervalo de referencia.
'),
 (84, 'REV', '41019376', N'César Carlos', N'Pinedo Reátegui', '2003-10-01', N'Masculino', N'Jr. Dos de Mayo N° 1762, Rioja', '997967144', 0, NULL, 'EFE', '2', '2026-11-03T10:41:00', '2026-11-04T10:48:00', '2026-11-06T10:24:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Pinedo Reátegui, César Carlos
DNI: 41019376    Sexo: Masculino    Edad: 23 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 10:48

==== INMUNOLOGÍA ====
VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo

(*) Valor fuera del intervalo de referencia.
'),
 (85, 'REV', '40587885', N'Lucía Pilar', N'Bardales Castillo', '2011-12-06', N'Femenino', N'Jr. Santo Toribio N° 1941, Rioja', '957061132', 0, NULL, 'TAR', '1', '2026-11-03T10:50:00', '2026-11-04T10:55:00', '2026-11-08T10:35:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Bardales Castillo, Lucía Pilar
DNI: 40587885    Sexo: Femenino    Edad: 14 años
Fecha de atención: 03/11/2026
Fecha de emisión: 04/11/2026 10:55

==== HORMONAS ====
FSH
  Parámetro                   Resultado     Unidad      Referencia
  FSH                         3.6           mUI/mL      Varía según fase del ciclo

==== PARASITOLOGÍA ====
Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan
Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan

(*) Valor fuera del intervalo de referencia.
'),
 (86, 'REV', '44580055', N'Alexis', N'Reátegui Sánchez', '1952-06-25', N'Masculino', N'Jr. Huallaga N° 599, Rioja', '921578091', 0, NULL, 'TAR', '2', '2026-11-02T09:47:00', '2026-11-03T09:02:00', '2026-11-06T10:46:00', N'LABORATORIO CLÍNICO CEIBIO S.A.C.
REPORTE CLÍNICO - Atención {AT} - Versión 1

Paciente: Reátegui Sánchez, Alexis
DNI: 44580055    Sexo: Masculino    Edad: 74 años
Fecha de atención: 02/11/2026
Fecha de emisión: 03/11/2026 09:02

==== MARCADORES TUMORALES ====
CEA (antígeno carcinoembrionario)
  Parámetro                   Resultado     Unidad      Referencia
  CEA                         1.7           ng/mL       ≤ 5

==== BIOQUÍMICA ====
Urea
  Parámetro                   Resultado     Unidad      Referencia
  Urea                        28            mg/dL       15 - 45

(*) Valor fuera del intervalo de referencia.
'),
 (87, 'LIS', '43022142', N'Alberto', N'Pezo Pinedo', '1958-08-05', N'Masculino', N'Jr. Santo Toribio N° 1362, Rioja', '959355565', 0, N'Asociación de Docentes UPN', 'EFE', '1', '2026-11-07T08:48:00', NULL, NULL, NULL),
 (88, 'LIS', '43813283', N'Milagros Gladys', N'Pinedo García', '1960-09-27', N'Femenino', N'Jr. Simón Bolívar N° 489, Rioja', '929907408', 0, NULL, 'EFE', '2', '2026-11-06T07:17:00', NULL, NULL, NULL),
 (89, 'LIS', '48880678', N'Sofía', N'Arévalo Mori', '1947-12-21', N'Femenino', N'Jr. Faustino Maldonado N° 467, Rioja', '936279360', 0, NULL, 'EFE', '2', '2026-11-06T09:32:00', NULL, NULL, NULL),
 (90, 'LIS', '42678955', N'Hugo', N'Huamán Pizarro', '1971-03-17', N'Masculino', N'Jr. San Martín N° 1669, Rioja', '917066245', 0, NULL, 'TAR', '1', '2026-11-07T10:07:00', NULL, NULL, NULL),
 (91, 'PVA', '41200847', N'Jorge', N'Ramírez Ruiz', '1949-08-13', N'Masculino', N'Jr. Cajamarca N° 668, Rioja', '981570564', 0, NULL, 'EFE', '2', '2026-11-05T09:59:00', NULL, NULL, NULL),
 (92, 'PVA', '41712731', N'Norma', N'Ushiñahua Castillo', '1963-06-09', N'Femenino', N'Jr. Juan Pablo II N° 316, Rioja', '927366962', 0, NULL, 'TAR', '2', '2026-11-06T08:47:00', NULL, NULL, NULL),
 (93, 'PVA', '48097222', N'Alberto', N'Castillo Rojas', '1951-05-30', N'Masculino', N'Jr. Libertad N° 570, Rioja', '943998433', 0, NULL, 'EFE', '1', '2026-11-06T09:24:00', NULL, NULL, NULL),
 (94, 'PVA', '48994719', N'Flor', N'Castillo Sánchez', '2000-01-29', N'Femenino', N'Jr. Juan Pablo II N° 970, Rioja', '923790489', 0, N'Colegio de Ingenieros del Perú', 'EFE', '1', '2026-11-06T08:25:00', NULL, NULL, NULL),
 (95, 'RRA', '41394590', N'Kevin', N'Ushiñahua Lozano', '1952-09-08', N'Masculino', N'Jr. Coronel Portillo N° 1738, Rioja', '991248204', 0, NULL, 'EFE', '1', '2026-11-06T09:33:00', NULL, NULL, NULL),
 (96, 'RRA', '48832499', N'Daniela', N'Flores Pizarro', '2005-02-02', N'Femenino', N'Jr. Coronel Portillo N° 370, Rioja', '932871379', 0, NULL, 'EFE', '2', '2026-11-07T07:51:00', NULL, NULL, NULL),
 (97, 'RRA', '40667945', N'Lucía', N'Ruiz Tuanama', '1961-06-25', N'Femenino', N'Jr. Huallaga N° 1366, Rioja', '949142144', 0, NULL, 'EFE', '1', '2026-11-05T07:48:00', NULL, NULL, NULL),
 (98, 'REC', '48320490', N'Teresa Gladys', N'Rodríguez García', '2001-02-26', N'Femenino', N'Jr. Coronel Portillo N° 161, Rioja', '948089196', 0, NULL, 'EFE', '1', '2026-11-06T10:35:00', NULL, NULL, NULL),
 (99, 'REC', '43478348', N'Karina', N'Fasabi Del Águila', '1984-01-18', N'Femenino', N'Jr. Santo Toribio N° 1953, Rioja', '943373024', 0, NULL, 'TAR', '1', '2026-11-07T08:46:00', NULL, NULL, NULL),
 (100, 'REC', '47723750', N'Joel', N'Lozano Fernández', '1994-01-25', N'Masculino', N'Jr. Coronel Portillo N° 1678, Rioja', '952743157', 0, NULL, 'EFE', '2', '2026-11-05T07:50:00', NULL, NULL, NULL);
INSERT INTO #CasoEx VALUES
 (1, N'Aglutinaciones', N'Microscopio binocular'),
 (1, N'Calcio sérico', N'Analizador bioquímico'),
 (1, N'Hemograma completo', N'Analizador hematológico'),
 (2, N'Insulina', N'Analizador de inmunoensayo'),
 (2, N'Reacción inflamatoria', N'Microscopio binocular'),
 (2, N'Testosterona total', N'Microscopio binocular'),
 (3, N'Glucosa post prandial', N'Analizador bioquímico'),
 (3, N'Hemoglobina', N'Analizador hematológico'),
 (3, N'Hemograma completo', N'Analizador hematológico'),
 (4, N'FSH', N'Analizador de inmunoensayo'),
 (4, N'Vitamina D', N'Analizador de inmunoensayo'),
 (5, N'Hemoglobina', N'Analizador hematológico'),
 (6, N'Perfil recién nacido', N'Analizador bioquímico'),
 (7, N'Cultivo de secreción vaginal', N'Microscopio binocular'),
 (7, N'Prolactina', N'Analizador de inmunoensayo'),
 (7, N'Tiempo de protrombina', N'Analizador hematológico'),
 (8, N'Perfil de coagulación', N'Analizador bioquímico'),
 (9, N'Fosfatasa alcalina', N'Analizador bioquímico'),
 (10, N'Aglutinaciones', N'Microscopio binocular'),
 (11, N'ANCA', N'Analizador de inmunoensayo'),
 (11, N'Tiempo de coagulación y sangría', N'Microscopio binocular'),
 (12, N'Gota gruesa', N'Microscopio binocular'),
 (12, N'Progesterona', N'Analizador de inmunoensayo'),
 (12, N'Proteína C reactiva cuantitativa', N'Analizador de inmunoensayo'),
 (13, N'CA-15.3', N'Analizador de inmunoensayo'),
 (13, N'Calcio sérico', N'Analizador bioquímico'),
 (13, N'Examen completo de orina', N'Microscopio binocular'),
 (14, N'Grupo sanguíneo y factor Rh', N'Microscopio binocular'),
 (14, N'LH', N'Analizador de inmunoensayo'),
 (15, N'Colesterol', N'Analizador bioquímico'),
 (15, N'Recuento de reticulocitos', N'Microscopio binocular'),
 (16, N'CA-15.3', N'Analizador de inmunoensayo'),
 (16, N'Progesterona', N'Analizador de inmunoensayo'),
 (17, N'Triglicéridos', N'Analizador bioquímico'),
 (18, N'Bilirrubina total y fraccionada', N'Analizador bioquímico'),
 (19, N'Fosfatasa alcalina', N'Analizador bioquímico'),
 (20, N'Ácido fólico', N'Analizador de inmunoensayo'),
 (20, N'Ultra TSH', N'Analizador de inmunoensayo'),
 (21, N'Calcio sérico', N'Analizador bioquímico'),
 (21, N'Perfil lipídico', N'Analizador bioquímico'),
 (22, N'Aglutinaciones', N'Microscopio binocular'),
 (22, N'Colesterol HDL', N'Analizador bioquímico'),
 (22, N'Urocultivo + antibiograma', N'Analizador bioquímico'),
 (23, N'Hepatitis A', N'Analizador de inmunoensayo'),
 (23, N'T4 libre', N'Analizador de inmunoensayo'),
 (23, N'VIH I, II y P24', N'Analizador de inmunoensayo'),
 (24, N'VSG', N'Microscopio binocular'),
 (25, N'Ácido úrico', N'Analizador bioquímico'),
 (25, N'CA-19.9', N'Analizador de inmunoensayo'),
 (25, N'Perfil hepático', N'Analizador de inmunoensayo'),
 (25, N'Ultra TSH', N'Analizador de inmunoensayo'),
 (26, N'Glucosa basal', N'Analizador bioquímico'),
 (26, N'Parasitológico simple', N'Microscopio binocular'),
 (26, N'Perfil lipídico', N'Microscopio binocular'),
 (27, N'CEA (antígeno carcinoembrionario)', N'Analizador de inmunoensayo'),
 (27, N'DHEA-S', N'Analizador de inmunoensayo'),
 (27, N'Ferritina', N'Analizador de inmunoensayo'),
 (28, N'Hematocrito', N'Analizador hematológico'),
 (28, N'Mioglobina', N'Analizador de inmunoensayo'),
 (29, N'Antimulleriana (AMH)', N'Analizador de inmunoensayo'),
 (29, N'Vitamina B12', N'Analizador de inmunoensayo'),
 (30, N'DHEA-S', N'Analizador de inmunoensayo'),
 (30, N'Proteína en orina de 24 horas', N'Microscopio binocular'),
 (30, N'TGP (ALT)', N'Analizador bioquímico'),
 (31, N'Hemoglobina glicosilada (HbA1c)', N'Analizador bioquímico'),
 (31, N'Perfil hepático', N'Analizador bioquímico'),
 (32, N'CA-19.9', N'Analizador de inmunoensayo'),
 (32, N'Vitamina D', N'Analizador de inmunoensayo'),
 (33, N'Triglicéridos', N'Analizador bioquímico'),
 (34, N'Mioglobina', N'Analizador de inmunoensayo'),
 (34, N'Urocultivo + antibiograma', N'Microscopio binocular'),
 (35, N'Calcio sérico', N'Analizador bioquímico'),
 (35, N'Examen completo de orina', N'Microscopio binocular'),
 (36, N'Calcio sérico', N'Analizador bioquímico'),
 (36, N'Triglicéridos', N'Analizador de inmunoensayo'),
 (36, N'Vitamina D', N'Analizador de inmunoensayo'),
 (37, N'Dengue (NS1, IgM - IgG)', N'Microscopio binocular'),
 (38, N'Descarte de leishmaniasis', N'Microscopio binocular'),
 (38, N'Hemoglobina glicosilada (HbA1c)', N'Analizador bioquímico'),
 (39, N'Colesterol', N'Analizador bioquímico'),
 (39, N'Herpes I, II (IgG/IgM)', N'Analizador de inmunoensayo'),
 (40, N'Cultivo de secreción uretral', N'Microscopio binocular'),
 (40, N'Vitamina D', N'Analizador de inmunoensayo'),
 (41, N'Perfil recién nacido', N'Analizador bioquímico'),
 (42, N'GGT', N'Analizador bioquímico'),
 (43, N'TGP (ALT)', N'Analizador bioquímico'),
 (43, N'Tiempo de protrombina', N'Analizador hematológico'),
 (44, N'Dengue (NS1, IgM - IgG)', N'Microscopio binocular'),
 (44, N'Mioglobina', N'Analizador de inmunoensayo'),
 (44, N'VSG', N'Analizador de inmunoensayo'),
 (45, N'Proteína C reactiva cualitativa', N'Microscopio binocular'),
 (45, N'T4 libre', N'Analizador de inmunoensayo'),
 (46, N'CA-19.9', N'Analizador de inmunoensayo'),
 (46, N'Descarte de leishmaniasis', N'Microscopio binocular'),
 (47, N'Descarte de leishmaniasis', N'Microscopio binocular'),
 (47, N'VIH I, II y P24', N'Analizador de inmunoensayo'),
 (48, N'Gota gruesa', N'Microscopio binocular'),
 (48, N'Grupo sanguíneo y factor Rh', N'Microscopio binocular'),
 (49, N'Creatinina', N'Analizador bioquímico'),
 (49, N'Tolerancia a la glucosa', N'Analizador bioquímico'),
 (50, N'Perfil pre operatorio', N'Analizador bioquímico'),
 (51, N'ANCA', N'Analizador de inmunoensayo'),
 (52, N'Tiempo de coagulación y sangría', N'Microscopio binocular'),
 (53, N'Factor reumatoide cualitativo', N'Microscopio binocular'),
 (53, N'Parasitológico seriado', N'Analizador de inmunoensayo'),
 (53, N'PSA libre', N'Analizador de inmunoensayo'),
 (54, N'Glucosa post prandial', N'Analizador bioquímico'),
 (54, N'Helicobacter pylori antígeno en heces', N'Microscopio binocular'),
 (54, N'Progesterona', N'Analizador de inmunoensayo'),
 (55, N'Hemoglobina glicosilada (HbA1c)', N'Analizador bioquímico'),
 (55, N'Parasitológico seriado', N'Microscopio binocular'),
 (56, N'Tiempo de protrombina', N'Analizador hematológico'),
 (57, N'Hematocrito', N'Analizador hematológico'),
 (58, N'CA-125', N'Analizador de inmunoensayo'),
 (58, N'Tiempo de protrombina', N'Analizador hematológico'),
 (58, N'Urocultivo + antibiograma', N'Microscopio binocular'),
 (59, N'GGT', N'Analizador bioquímico'),
 (59, N'Hemoglobina', N'Analizador hematológico'),
 (60, N'CA-15.3', N'Analizador de inmunoensayo'),
 (60, N'Hemograma completo', N'Analizador hematológico'),
 (61, N'Vitamina D', N'Analizador de inmunoensayo'),
 (62, N'TGO (AST)', N'Analizador bioquímico'),
 (63, N'Creatinina', N'Analizador bioquímico'),
 (63, N'Triglicéridos', N'Analizador bioquímico'),
 (64, N'TGO (AST)', N'Analizador bioquímico'),
 (64, N'Tiempo de protrombina', N'Analizador hematológico'),
 (64, N'Vitamina D', N'Analizador de inmunoensayo'),
 (65, N'Ácido fólico', N'Analizador de inmunoensayo'),
 (65, N'Colesterol LDL', N'Analizador bioquímico'),
 (65, N'Dengue (NS1, IgM - IgG)', N'Microscopio binocular'),
 (66, N'Ferritina', N'Analizador de inmunoensayo'),
 (66, N'Gota gruesa', N'Microscopio binocular'),
 (66, N'PCR cuantitativo (cardíaco)', N'Microscopio binocular'),
 (67, N'Examen completo de orina', N'Microscopio binocular'),
 (68, N'Urocultivo + antibiograma', N'Microscopio binocular'),
 (69, N'Ultra TSH', N'Analizador de inmunoensayo'),
 (70, N'T4 libre', N'Analizador de inmunoensayo'),
 (71, N'Helicobacter pylori antígeno en heces', N'Microscopio binocular'),
 (71, N'Rotavirus y adenovirus', N'Microscopio binocular'),
 (71, N'Sífilis (prueba rápida)', N'Microscopio binocular'),
 (72, N'B-HCG cualitativa', N'Microscopio binocular'),
 (72, N'Hemograma completo', N'Analizador hematológico'),
 (73, N'Calcio sérico', N'Analizador bioquímico'),
 (73, N'Sífilis (prueba rápida)', N'Microscopio binocular'),
 (74, N'Ácido úrico', N'Analizador bioquímico'),
 (74, N'Ferritina', N'Analizador de inmunoensayo'),
 (75, N'Ultra TSH', N'Analizador de inmunoensayo'),
 (76, N'Cortisol', N'Analizador de inmunoensayo'),
 (76, N'Cultivo de semen (espermocultivo)', N'Microscopio binocular'),
 (77, N'Troponina I', N'Analizador de inmunoensayo'),
 (77, N'VSG', N'Microscopio binocular'),
 (78, N'CA-15.3', N'Analizador de inmunoensayo'),
 (78, N'Estradiol', N'Microscopio binocular'),
 (78, N'Factor reumatoide cualitativo', N'Microscopio binocular'),
 (79, N'Prolactina', N'Analizador de inmunoensayo'),
 (80, N'Glucosa post prandial', N'Analizador bioquímico'),
 (80, N'Parasitológico seriado', N'Microscopio binocular'),
 (81, N'Perfil pre operatorio', N'Analizador bioquímico'),
 (81, N'PSA total', N'Analizador de inmunoensayo'),
 (82, N'Hepatitis A', N'Analizador de inmunoensayo'),
 (83, N'Calcio sérico', N'Analizador bioquímico'),
 (83, N'Mioglobina', N'Analizador de inmunoensayo'),
 (83, N'Parasitológico simple', N'Microscopio binocular'),
 (84, N'VIH I, II y P24', N'Analizador de inmunoensayo'),
 (85, N'FSH', N'Analizador de inmunoensayo'),
 (85, N'Gota gruesa', N'Microscopio binocular'),
 (85, N'Parasitológico seriado', N'Microscopio binocular'),
 (86, N'CEA (antígeno carcinoembrionario)', N'Analizador de inmunoensayo'),
 (86, N'Urea', N'Analizador bioquímico'),
 (87, N'Hemograma completo', N'Analizador hematológico'),
 (87, N'Vitamina B12', N'Analizador de inmunoensayo'),
 (88, N'Grupo sanguíneo y factor Rh', N'Microscopio binocular'),
 (88, N'TGO (AST)', N'Analizador bioquímico'),
 (89, N'DHEA-S', N'Analizador de inmunoensayo'),
 (90, N'Ferritina', N'Analizador de inmunoensayo'),
 (90, N'PSA libre', N'Analizador de inmunoensayo'),
 (91, N'Factor reumatoide cualitativo', N'Microscopio binocular'),
 (91, N'Perfil lipídico', N'Analizador bioquímico'),
 (92, N'Calcio sérico', N'Analizador bioquímico'),
 (92, N'Gota gruesa', N'Microscopio binocular'),
 (93, N'CK-MB', N'Analizador de inmunoensayo'),
 (94, N'Dengue (NS1, IgM - IgG)', N'Microscopio binocular'),
 (94, N'Grupo sanguíneo y factor Rh', N'Analizador hematológico'),
 (94, N'Hemograma completo', N'Analizador de inmunoensayo'),
 (94, N'VIH I, II y P24', N'Analizador de inmunoensayo'),
 (95, N'Vitamina D', N'Analizador de inmunoensayo'),
 (96, N'AFP (alfa feto proteína)', N'Analizador de inmunoensayo'),
 (97, N'Ferritina', N'Analizador de inmunoensayo'),
 (97, N'Grupo sanguíneo y factor Rh', N'Microscopio binocular'),
 (97, N'T4 total', N'Microscopio binocular'),
 (98, N'Cultivo de secreción vaginal', N'Microscopio binocular'),
 (99, N'Albúmina', N'Analizador bioquímico'),
 (99, N'Grupo sanguíneo y factor Rh', N'Microscopio binocular'),
 (99, N'Parasitológico seriado', N'Microscopio binocular'),
 (100, N'Gota gruesa', N'Microscopio binocular'),
 (100, N'T4 libre', N'Analizador de inmunoensayo');
INSERT INTO #CasoRes VALUES
 (1, N'Aglutinaciones', N'Tífico O', N'Negativo (menor a 1/80)'),
 (1, N'Aglutinaciones', N'Tífico H', N'Negativo (menor a 1/80)'),
 (1, N'Aglutinaciones', N'Paratífico A', N'Negativo (menor a 1/80)'),
 (1, N'Aglutinaciones', N'Paratífico B', N'Negativo (menor a 1/80)'),
 (1, N'Aglutinaciones', N'Brucella', N'Negativo (menor a 1/80)'),
 (1, N'Calcio sérico', N'Calcio', N'7.4'),
 (1, N'Hemograma completo', N'Hemoglobina', N'14.2'),
 (1, N'Hemograma completo', N'Leucocitos', N'7.4'),
 (1, N'Hemograma completo', N'Plaquetas', N'384'),
 (2, N'Insulina', N'Insulina', N'11.0'),
 (2, N'Reacción inflamatoria', N'Leucocitos por campo', N'0 a 5 por campo'),
 (2, N'Reacción inflamatoria', N'Moco', N'Ausente'),
 (2, N'Testosterona total', N'Testosterona total', N'970'),
 (3, N'Glucosa post prandial', N'Glucosa post prandial', N'36'),
 (3, N'Hemoglobina', N'Hemoglobina', N'17.3'),
 (3, N'Hemograma completo', N'Hemoglobina', N'14.4'),
 (3, N'Hemograma completo', N'Leucocitos', N'12.0'),
 (3, N'Hemograma completo', N'Plaquetas', N'197'),
 (4, N'FSH', N'FSH', N'5.2'),
 (4, N'Vitamina D', N'25-OH vitamina D', N'77'),
 (5, N'Hemoglobina', N'Hemoglobina', N'11.3'),
 (6, N'Perfil recién nacido', N'Hemoglobina', N'21.5'),
 (6, N'Perfil recién nacido', N'Hematocrito', N'51'),
 (6, N'Perfil recién nacido', N'Glucosa', N'90'),
 (6, N'Perfil recién nacido', N'Grupo sanguíneo', N'B'),
 (6, N'Perfil recién nacido', N'Factor Rh', N'Positivo'),
 (6, N'Perfil recién nacido', N'Proteína C reactiva', N'3.8'),
 (7, N'Cultivo de secreción vaginal', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (7, N'Cultivo de secreción vaginal', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (7, N'Prolactina', N'Prolactina', N'7.4'),
 (7, N'Tiempo de protrombina', N'Tiempo de protrombina', N'12.5'),
 (7, N'Tiempo de protrombina', N'INR', N'0.98'),
 (8, N'Perfil de coagulación', N'Tiempo de protrombina', N'13.1'),
 (8, N'Perfil de coagulación', N'Tiempo parcial de tromboplastina', N'30'),
 (8, N'Perfil de coagulación', N'Plaquetas', N'255'),
 (8, N'Perfil de coagulación', N'Tiempo de coagulación', N'7.2'),
 (8, N'Perfil de coagulación', N'Tiempo de sangría', N'2.8'),
 (9, N'Fosfatasa alcalina', N'Fosfatasa alcalina', N'93'),
 (10, N'Aglutinaciones', N'Tífico O', N'Negativo (menor a 1/80)'),
 (10, N'Aglutinaciones', N'Tífico H', N'Negativo (menor a 1/80)'),
 (10, N'Aglutinaciones', N'Paratífico A', N'Negativo (menor a 1/80)'),
 (10, N'Aglutinaciones', N'Paratífico B', N'Negativo (menor a 1/80)'),
 (10, N'Aglutinaciones', N'Brucella', N'Negativo (menor a 1/80)'),
 (11, N'ANCA', N'p-ANCA', N'Negativo'),
 (11, N'ANCA', N'c-ANCA', N'Positivo'),
 (11, N'Tiempo de coagulación y sangría', N'Tiempo de coagulación', N'11.5'),
 (11, N'Tiempo de coagulación y sangría', N'Tiempo de sangría', N'1.7'),
 (12, N'Gota gruesa', N'Plasmodium', N'Se observan'),
 (12, N'Progesterona', N'Progesterona', N'13.8'),
 (12, N'Proteína C reactiva cuantitativa', N'Proteína C reactiva', N'7.7'),
 (13, N'CA-15.3', N'CA-15.3', N'9.8'),
 (13, N'Calcio sérico', N'Calcio', N'8.8'),
 (13, N'Examen completo de orina', N'Aspecto', N'Transparente'),
 (13, N'Examen completo de orina', N'Leucocitos por campo', N'0 a 5 por campo'),
 (14, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'O'),
 (14, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (14, N'LH', N'LH', N'6.4'),
 (15, N'Colesterol', N'Colesterol total', N'51'),
 (15, N'Recuento de reticulocitos', N'Reticulocitos', N'1.68'),
 (16, N'CA-15.3', N'CA-15.3', N'23.7'),
 (16, N'Progesterona', N'Progesterona', N'15.5'),
 (17, N'Triglicéridos', N'Triglicéridos', N'75'),
 (18, N'Bilirrubina total y fraccionada', N'Bilirrubina total', N'0.40'),
 (18, N'Bilirrubina total y fraccionada', N'Bilirrubina directa', N'0.11'),
 (18, N'Bilirrubina total y fraccionada', N'Bilirrubina indirecta', N'0.85'),
 (19, N'Fosfatasa alcalina', N'Fosfatasa alcalina', N'84'),
 (20, N'Ácido fólico', N'Ácido fólico', N'19.9'),
 (20, N'Ultra TSH', N'TSH', N'5.4'),
 (21, N'Calcio sérico', N'Calcio', N'8.7'),
 (21, N'Perfil lipídico', N'Colesterol total', N'76'),
 (21, N'Perfil lipídico', N'Triglicéridos', N'105'),
 (21, N'Perfil lipídico', N'Colesterol HDL', N'52'),
 (21, N'Perfil lipídico', N'Colesterol LDL', N'155'),
 (22, N'Aglutinaciones', N'Tífico O', N'Negativo (menor a 1/80)'),
 (22, N'Aglutinaciones', N'Tífico H', N'Negativo (menor a 1/80)'),
 (22, N'Aglutinaciones', N'Paratífico A', N'Negativo (menor a 1/80)'),
 (22, N'Aglutinaciones', N'Paratífico B', N'Negativo (menor a 1/80)'),
 (22, N'Aglutinaciones', N'Brucella', N'Negativo (menor a 1/80)'),
 (22, N'Colesterol HDL', N'Colesterol HDL', N'63'),
 (22, N'Urocultivo + antibiograma', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (22, N'Urocultivo + antibiograma', N'Recuento de colonias', N'0'),
 (22, N'Urocultivo + antibiograma', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (23, N'Hepatitis A', N'Anti-HAV IgM', N'No reactivo'),
 (23, N'T4 libre', N'T4 libre', N'1.65'),
 (23, N'VIH I, II y P24', N'VIH I, II y antígeno P24', N'No reactivo'),
 (24, N'VSG', N'Velocidad de sedimentación', N'14.9'),
 (25, N'Ácido úrico', N'Ácido úrico', N'6.6'),
 (25, N'CA-19.9', N'CA-19.9', N'33'),
 (25, N'Perfil hepático', N'TGO (AST)', N'4'),
 (25, N'Perfil hepático', N'TGP (ALT)', N'31'),
 (25, N'Perfil hepático', N'Bilirrubina total', N'0.46'),
 (25, N'Perfil hepático', N'Bilirrubina directa', N'0.23'),
 (25, N'Perfil hepático', N'Bilirrubina indirecta', N'0.59'),
 (25, N'Perfil hepático', N'Fosfatasa alcalina', N'120'),
 (25, N'Perfil hepático', N'Proteínas totales', N'6.9'),
 (25, N'Perfil hepático', N'Albúmina', N'4.5'),
 (25, N'Perfil hepático', N'Globulina', N'1.4'),
 (25, N'Perfil hepático', N'GGT', N'13'),
 (25, N'Ultra TSH', N'TSH', N'3.6'),
 (26, N'Glucosa basal', N'Glucosa', N'83'),
 (26, N'Parasitológico simple', N'Consistencia', N'Formada'),
 (26, N'Parasitológico simple', N'Parásitos', N'No se observan'),
 (26, N'Perfil lipídico', N'Colesterol total', N'172'),
 (26, N'Perfil lipídico', N'Triglicéridos', N'76'),
 (26, N'Perfil lipídico', N'Colesterol HDL', N'29'),
 (26, N'Perfil lipídico', N'Colesterol LDL', N'120'),
 (27, N'CEA (antígeno carcinoembrionario)', N'CEA', N'2.5'),
 (27, N'DHEA-S', N'DHEA-S', N'209'),
 (27, N'Ferritina', N'Ferritina', N'266'),
 (28, N'Hematocrito', N'Hematocrito', N'47'),
 (28, N'Mioglobina', N'Mioglobina', N'54'),
 (29, N'Antimulleriana (AMH)', N'Hormona antimulleriana', N'0.8'),
 (29, N'Vitamina B12', N'Vitamina B12', N'428'),
 (30, N'DHEA-S', N'DHEA-S', N'368'),
 (30, N'Proteína en orina de 24 horas', N'Volumen urinario de 24 h', N'1312'),
 (30, N'Proteína en orina de 24 horas', N'Proteínas en orina de 24 h', N'43'),
 (30, N'TGP (ALT)', N'TGP (ALT)', N'16'),
 (31, N'Hemoglobina glicosilada (HbA1c)', N'Hemoglobina glicosilada', N'3.0'),
 (31, N'Perfil hepático', N'TGO (AST)', N'8'),
 (31, N'Perfil hepático', N'TGP (ALT)', N'13'),
 (31, N'Perfil hepático', N'Bilirrubina total', N'0.57'),
 (31, N'Perfil hepático', N'Bilirrubina directa', N'0.27'),
 (31, N'Perfil hepático', N'Bilirrubina indirecta', N'0.53'),
 (31, N'Perfil hepático', N'Fosfatasa alcalina', N'112'),
 (31, N'Perfil hepático', N'Proteínas totales', N'7.6'),
 (31, N'Perfil hepático', N'Albúmina', N'5.0'),
 (31, N'Perfil hepático', N'Globulina', N'2.4'),
 (31, N'Perfil hepático', N'GGT', N'34'),
 (32, N'CA-19.9', N'CA-19.9', N'19'),
 (32, N'Vitamina D', N'25-OH vitamina D', N'82'),
 (33, N'Triglicéridos', N'Triglicéridos', N'142'),
 (34, N'Mioglobina', N'Mioglobina', N'36'),
 (34, N'Urocultivo + antibiograma', N'Germen aislado', N'Escherichia coli'),
 (34, N'Urocultivo + antibiograma', N'Recuento de colonias', N'100000'),
 (34, N'Urocultivo + antibiograma', N'Antibiograma', N'Sensible a nitrofurantoína y ciprofloxacino; resistente a ampicilina'),
 (35, N'Calcio sérico', N'Calcio', N'10.0'),
 (35, N'Examen completo de orina', N'Aspecto', N'Transparente'),
 (35, N'Examen completo de orina', N'Leucocitos por campo', N'0 a 5 por campo'),
 (36, N'Calcio sérico', N'Calcio', N'9.7'),
 (36, N'Triglicéridos', N'Triglicéridos', N'127'),
 (36, N'Vitamina D', N'25-OH vitamina D', N'27'),
 (37, N'Dengue (NS1, IgM - IgG)', N'Dengue NS1', N'Negativo'),
 (37, N'Dengue (NS1, IgM - IgG)', N'Dengue IgM', N'Negativo'),
 (37, N'Dengue (NS1, IgM - IgG)', N'Dengue IgG', N'Negativo'),
 (38, N'Descarte de leishmaniasis', N'Amastigotes de Leishmania', N'No se observan'),
 (38, N'Hemoglobina glicosilada (HbA1c)', N'Hemoglobina glicosilada', N'3.7'),
 (39, N'Colesterol', N'Colesterol total', N'104'),
 (39, N'Herpes I, II (IgG/IgM)', N'Herpes I, II IgG', N'No reactivo'),
 (39, N'Herpes I, II (IgG/IgM)', N'Herpes I, II IgM', N'No reactivo'),
 (40, N'Cultivo de secreción uretral', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (40, N'Cultivo de secreción uretral', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (40, N'Vitamina D', N'25-OH vitamina D', N'38'),
 (41, N'Perfil recién nacido', N'Hemoglobina', N'20.5'),
 (41, N'Perfil recién nacido', N'Hematocrito', N'54'),
 (41, N'Perfil recién nacido', N'Glucosa', N'78'),
 (41, N'Perfil recién nacido', N'Grupo sanguíneo', N'O'),
 (41, N'Perfil recién nacido', N'Factor Rh', N'Positivo'),
 (41, N'Perfil recién nacido', N'Proteína C reactiva', N'3.9'),
 (42, N'GGT', N'GGT', N'47'),
 (43, N'TGP (ALT)', N'TGP (ALT)', N'12'),
 (43, N'Tiempo de protrombina', N'Tiempo de protrombina', N'13.1'),
 (43, N'Tiempo de protrombina', N'INR', N'1.04'),
 (44, N'Dengue (NS1, IgM - IgG)', N'Dengue NS1', N'Negativo'),
 (44, N'Dengue (NS1, IgM - IgG)', N'Dengue IgM', N'Negativo'),
 (44, N'Dengue (NS1, IgM - IgG)', N'Dengue IgG', N'Negativo'),
 (44, N'Mioglobina', N'Mioglobina', N'83'),
 (44, N'VSG', N'Velocidad de sedimentación', N'15.7'),
 (45, N'Proteína C reactiva cualitativa', N'Proteína C reactiva', N'Negativo'),
 (45, N'T4 libre', N'T4 libre', N'1.45'),
 (46, N'CA-19.9', N'CA-19.9', N'30'),
 (46, N'Descarte de leishmaniasis', N'Amastigotes de Leishmania', N'No se observan'),
 (47, N'Descarte de leishmaniasis', N'Amastigotes de Leishmania', N'No se observan'),
 (47, N'VIH I, II y P24', N'VIH I, II y antígeno P24', N'No reactivo'),
 (48, N'Gota gruesa', N'Plasmodium', N'No se observan'),
 (48, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'O'),
 (48, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (49, N'Creatinina', N'Creatinina', N'0.53'),
 (49, N'Tolerancia a la glucosa', N'Glucosa basal', N'74'),
 (49, N'Tolerancia a la glucosa', N'Glucosa a la 1 hora', N'48'),
 (49, N'Tolerancia a la glucosa', N'Glucosa a las 2 horas', N'85'),
 (50, N'Perfil pre operatorio', N'Hemoglobina', N'19.3'),
 (50, N'Perfil pre operatorio', N'Hematocrito', N'39'),
 (50, N'Perfil pre operatorio', N'Leucocitos', N'10.5'),
 (50, N'Perfil pre operatorio', N'Plaquetas', N'303'),
 (50, N'Perfil pre operatorio', N'Glucosa', N'81'),
 (50, N'Perfil pre operatorio', N'Urea', N'49'),
 (50, N'Perfil pre operatorio', N'Creatinina', N'0.61'),
 (50, N'Perfil pre operatorio', N'VIH', N'No reactivo'),
 (50, N'Perfil pre operatorio', N'Sífilis', N'No reactivo'),
 (50, N'Perfil pre operatorio', N'HBsAg', N'No reactivo'),
 (50, N'Perfil pre operatorio', N'Grupo sanguíneo', N'O'),
 (50, N'Perfil pre operatorio', N'Factor Rh', N'Positivo'),
 (50, N'Perfil pre operatorio', N'Tiempo de coagulación', N'7.9'),
 (50, N'Perfil pre operatorio', N'Tiempo de sangría', N'2.5'),
 (50, N'Perfil pre operatorio', N'Examen completo de orina', N'Sin alteraciones'),
 (51, N'ANCA', N'p-ANCA', N'Negativo'),
 (51, N'ANCA', N'c-ANCA', N'Negativo'),
 (52, N'Tiempo de coagulación y sangría', N'Tiempo de coagulación', N'5.5'),
 (52, N'Tiempo de coagulación y sangría', N'Tiempo de sangría', N'2.3'),
 (53, N'Factor reumatoide cualitativo', N'Factor reumatoide', N'Negativo');
INSERT INTO #CasoRes VALUES
 (53, N'Parasitológico seriado', N'Parásitos', N'No se observan'),
 (53, N'PSA libre', N'PSA libre', N'0.87'),
 (53, N'PSA libre', N'Relación PSA libre / total', N'90'),
 (54, N'Glucosa post prandial', N'Glucosa post prandial', N'84'),
 (54, N'Helicobacter pylori antígeno en heces', N'Helicobacter pylori (antígeno)', N'Negativo'),
 (54, N'Progesterona', N'Progesterona', N'19.2'),
 (55, N'Hemoglobina glicosilada (HbA1c)', N'Hemoglobina glicosilada', N'4.2'),
 (55, N'Parasitológico seriado', N'Parásitos', N'Se observan'),
 (56, N'Tiempo de protrombina', N'Tiempo de protrombina', N'12.4'),
 (56, N'Tiempo de protrombina', N'INR', N'1.17'),
 (57, N'Hematocrito', N'Hematocrito', N'42'),
 (58, N'CA-125', N'CA-125', N'30'),
 (58, N'Tiempo de protrombina', N'Tiempo de protrombina', N'13.3'),
 (58, N'Tiempo de protrombina', N'INR', N'1.12'),
 (58, N'Urocultivo + antibiograma', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (58, N'Urocultivo + antibiograma', N'Recuento de colonias', N'100000'),
 (58, N'Urocultivo + antibiograma', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (59, N'GGT', N'GGT', N'17'),
 (59, N'Hemoglobina', N'Hemoglobina', N'8.9'),
 (60, N'CA-15.3', N'CA-15.3', N'19.4'),
 (60, N'Hemograma completo', N'Hemoglobina', N'14.6'),
 (60, N'Hemograma completo', N'Leucocitos', N'5.3'),
 (60, N'Hemograma completo', N'Plaquetas', N'358'),
 (61, N'Vitamina D', N'25-OH vitamina D', N'86'),
 (62, N'TGO (AST)', N'TGO (AST)', N'10'),
 (63, N'Creatinina', N'Creatinina', N'0.56'),
 (63, N'Triglicéridos', N'Triglicéridos', N'142'),
 (64, N'TGO (AST)', N'TGO (AST)', N'28'),
 (64, N'Tiempo de protrombina', N'Tiempo de protrombina', N'8.2'),
 (64, N'Tiempo de protrombina', N'INR', N'0.89'),
 (64, N'Vitamina D', N'25-OH vitamina D', N'40'),
 (65, N'Ácido fólico', N'Ácido fólico', N'22.3'),
 (65, N'Colesterol LDL', N'Colesterol LDL', N'160'),
 (65, N'Dengue (NS1, IgM - IgG)', N'Dengue NS1', N'Negativo'),
 (65, N'Dengue (NS1, IgM - IgG)', N'Dengue IgM', N'Negativo'),
 (65, N'Dengue (NS1, IgM - IgG)', N'Dengue IgG', N'Negativo'),
 (66, N'Ferritina', N'Ferritina', N'312'),
 (66, N'Gota gruesa', N'Plasmodium', N'Se observan'),
 (66, N'PCR cuantitativo (cardíaco)', N'Proteína C reactiva', N'6.3'),
 (67, N'Examen completo de orina', N'Aspecto', N'Transparente'),
 (67, N'Examen completo de orina', N'Leucocitos por campo', N'0 a 5 por campo'),
 (68, N'Urocultivo + antibiograma', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (68, N'Urocultivo + antibiograma', N'Recuento de colonias', N'0'),
 (68, N'Urocultivo + antibiograma', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (69, N'Ultra TSH', N'TSH', N'3.1'),
 (70, N'T4 libre', N'T4 libre', N'0.69'),
 (71, N'Helicobacter pylori antígeno en heces', N'Helicobacter pylori (antígeno)', N'Negativo'),
 (71, N'Rotavirus y adenovirus', N'Rotavirus', N'Negativo'),
 (71, N'Rotavirus y adenovirus', N'Adenovirus', N'Positivo'),
 (71, N'Sífilis (prueba rápida)', N'Sífilis', N'No reactivo'),
 (72, N'B-HCG cualitativa', N'B-HCG', N'Negativo'),
 (72, N'Hemograma completo', N'Hemoglobina', N'15.1'),
 (72, N'Hemograma completo', N'Leucocitos', N'9.9'),
 (72, N'Hemograma completo', N'Plaquetas', N'221'),
 (73, N'Calcio sérico', N'Calcio', N'10.1'),
 (73, N'Sífilis (prueba rápida)', N'Sífilis', N'No reactivo'),
 (74, N'Ácido úrico', N'Ácido úrico', N'5.3'),
 (74, N'Ferritina', N'Ferritina', N'80'),
 (75, N'Ultra TSH', N'TSH', N'2.6'),
 (76, N'Cortisol', N'Cortisol (mañana)', N'5.8'),
 (76, N'Cultivo de semen (espermocultivo)', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (76, N'Cultivo de semen (espermocultivo)', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (77, N'Troponina I', N'Troponina I', N'0.028'),
 (77, N'VSG', N'Velocidad de sedimentación', N'13.9'),
 (78, N'CA-15.3', N'CA-15.3', N'21.7'),
 (78, N'Estradiol', N'Estradiol', N'285'),
 (78, N'Factor reumatoide cualitativo', N'Factor reumatoide', N'Negativo'),
 (79, N'Prolactina', N'Prolactina', N'30.0'),
 (80, N'Glucosa post prandial', N'Glucosa post prandial', N'107'),
 (80, N'Parasitológico seriado', N'Parásitos', N'No se observan'),
 (81, N'Perfil pre operatorio', N'Hemoglobina', N'15.9'),
 (81, N'Perfil pre operatorio', N'Hematocrito', N'48'),
 (81, N'Perfil pre operatorio', N'Leucocitos', N'9.2'),
 (81, N'Perfil pre operatorio', N'Plaquetas', N'584'),
 (81, N'Perfil pre operatorio', N'Glucosa', N'79'),
 (81, N'Perfil pre operatorio', N'Urea', N'33'),
 (81, N'Perfil pre operatorio', N'Creatinina', N'1.43'),
 (81, N'Perfil pre operatorio', N'VIH', N'Reactivo'),
 (81, N'Perfil pre operatorio', N'Sífilis', N'No reactivo'),
 (81, N'Perfil pre operatorio', N'HBsAg', N'No reactivo'),
 (81, N'Perfil pre operatorio', N'Grupo sanguíneo', N'O'),
 (81, N'Perfil pre operatorio', N'Factor Rh', N'Positivo'),
 (81, N'Perfil pre operatorio', N'Tiempo de coagulación', N'9.2'),
 (81, N'Perfil pre operatorio', N'Tiempo de sangría', N'2.1'),
 (81, N'Perfil pre operatorio', N'Examen completo de orina', N'Sin alteraciones'),
 (81, N'PSA total', N'PSA total', N'1.3'),
 (82, N'Hepatitis A', N'Anti-HAV IgM', N'No reactivo'),
 (83, N'Calcio sérico', N'Calcio', N'10.1'),
 (83, N'Mioglobina', N'Mioglobina', N'41'),
 (83, N'Parasitológico simple', N'Consistencia', N'Blanda'),
 (83, N'Parasitológico simple', N'Parásitos', N'No se observan'),
 (84, N'VIH I, II y P24', N'VIH I, II y antígeno P24', N'No reactivo'),
 (85, N'FSH', N'FSH', N'3.6'),
 (85, N'Gota gruesa', N'Plasmodium', N'No se observan'),
 (85, N'Parasitológico seriado', N'Parásitos', N'No se observan'),
 (86, N'CEA (antígeno carcinoembrionario)', N'CEA', N'1.7'),
 (86, N'Urea', N'Urea', N'28'),
 (87, N'Hemograma completo', N'Hemoglobina', N'14.0'),
 (87, N'Hemograma completo', N'Leucocitos', N'10.0'),
 (87, N'Hemograma completo', N'Plaquetas', N'263'),
 (87, N'Vitamina B12', N'Vitamina B12', N'248'),
 (88, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'O'),
 (88, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (88, N'TGO (AST)', N'TGO (AST)', N'18'),
 (89, N'DHEA-S', N'DHEA-S', N'333'),
 (90, N'Ferritina', N'Ferritina', N'144'),
 (90, N'PSA libre', N'PSA libre', N'0.62'),
 (90, N'PSA libre', N'Relación PSA libre / total', N'36'),
 (91, N'Factor reumatoide cualitativo', N'Factor reumatoide', N'Negativo'),
 (91, N'Perfil lipídico', N'Colesterol total', N'176'),
 (91, N'Perfil lipídico', N'Triglicéridos', N'123'),
 (91, N'Perfil lipídico', N'Colesterol HDL', N'45'),
 (91, N'Perfil lipídico', N'Colesterol LDL', N'94'),
 (92, N'Calcio sérico', N'Calcio', N'9.1'),
 (92, N'Gota gruesa', N'Plasmodium', N'No se observan'),
 (93, N'CK-MB', N'CK-MB', N'11.6'),
 (94, N'Dengue (NS1, IgM - IgG)', N'Dengue NS1', N'Negativo'),
 (94, N'Dengue (NS1, IgM - IgG)', N'Dengue IgM', N'Negativo'),
 (94, N'Dengue (NS1, IgM - IgG)', N'Dengue IgG', N'Negativo'),
 (94, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'B'),
 (94, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (94, N'Hemograma completo', N'Hemoglobina', N'13.8'),
 (94, N'Hemograma completo', N'Leucocitos', N'6.7'),
 (94, N'Hemograma completo', N'Plaquetas', N'251'),
 (94, N'VIH I, II y P24', N'VIH I, II y antígeno P24', N'No reactivo'),
 (95, N'Vitamina D', N'25-OH vitamina D', N'69'),
 (96, N'AFP (alfa feto proteína)', N'AFP', N'2.7'),
 (97, N'Ferritina', N'Ferritina', N'35'),
 (97, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'O'),
 (97, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (97, N'T4 total', N'T4 total', N'12.1'),
 (98, N'Cultivo de secreción vaginal', N'Germen aislado', N'Sin crecimiento bacteriano'),
 (98, N'Cultivo de secreción vaginal', N'Antibiograma', N'No se realizó (cultivo negativo)'),
 (99, N'Albúmina', N'Albúmina', N'4.0'),
 (99, N'Grupo sanguíneo y factor Rh', N'Grupo sanguíneo', N'O'),
 (99, N'Grupo sanguíneo y factor Rh', N'Factor Rh', N'Positivo'),
 (99, N'Parasitológico seriado', N'Parásitos', N'No se observan'),
 (100, N'Gota gruesa', N'Plasmodium', N'No se observan'),
 (100, N'T4 libre', N'T4 libre', N'1.40');
INSERT INTO #CasoSec VALUES
 (1, N'Aglutinaciones', N'Inmunología', N'Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
'),
 (1, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      7.4 *         mg/dL       8.6 - 10.3
'),
 (1, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.2          g/dL        13.5 - 17.5
  Leucocitos                  7.4           x10³/µL     4.5 - 11
  Plaquetas                   384           x10³/µL     150 - 450
'),
 (2, N'Insulina', N'Otros análisis', N'Insulina
  Parámetro                   Resultado     Unidad      Referencia
  Insulina                    11.0          µUI/mL      2.6 - 24.9
'),
 (2, N'Reacción inflamatoria', N'Parasitología', N'Reacción inflamatoria
  Parámetro                   Resultado     Unidad      Referencia
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo
  Moco                        Ausente                   Ausente
'),
 (2, N'Testosterona total', N'Hormonas', N'Testosterona total
  Parámetro                   Resultado     Unidad      Referencia
  Testosterona total          970 *         ng/dL       249 - 836
'),
 (3, N'Glucosa post prandial', N'Bioquímica', N'Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       36            mg/dL       ≤ 140
'),
 (3, N'Hemoglobina', N'Hematología', N'Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 17.3          g/dL        13.5 - 17.5
'),
 (3, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.4          g/dL        13.5 - 17.5
  Leucocitos                  12.0 *        x10³/µL     4.5 - 11
  Plaquetas                   197           x10³/µL     150 - 450
'),
 (4, N'FSH', N'Hormonas', N'FSH
  Parámetro                   Resultado     Unidad      Referencia
  FSH                         5.2           mUI/mL      1.5 - 12.4
'),
 (4, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            77            ng/mL       30 - 100
'),
 (5, N'Hemoglobina', N'Hematología', N'Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 11.3          g/dL        11 - 15.5
'),
 (6, N'Perfil recién nacido', N'Perfiles', N'Perfil recién nacido
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 21.5          g/dL        14 - 24
  Hematocrito                 51            %           44 - 64
  Glucosa                     90            mg/dL       40 - 100
  Grupo sanguíneo             B                         
  Factor Rh                   Positivo                  
  Proteína C reactiva         3.8           mg/L        ≤ 5
'),
 (7, N'Cultivo de secreción vaginal', N'Cultivos', N'Cultivo de secreción vaginal
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (7, N'Prolactina', N'Hormonas', N'Prolactina
  Parámetro                   Resultado     Unidad      Referencia
  Prolactina                  7.4           ng/mL       4.8 - 23.3
'),
 (7, N'Tiempo de protrombina', N'Hematología', N'Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       12.5          s           11 - 13.5
  INR                         0.98          índice      0.8 - 1.2
'),
 (8, N'Perfil de coagulación', N'Perfiles', N'Perfil de coagulación
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.1          s           11 - 13.5
  Tiempo parcial de tromboplastina30            s           25 - 35
  Plaquetas                   255           x10³/µL     150 - 450
  Tiempo de coagulación       7.2           min         5 - 10
  Tiempo de sangría           2.8           min         1 - 3
'),
 (9, N'Fosfatasa alcalina', N'Bioquímica', N'Fosfatasa alcalina
  Parámetro                   Resultado     Unidad      Referencia
  Fosfatasa alcalina          93            U/L         40 - 129
'),
 (10, N'Aglutinaciones', N'Inmunología', N'Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
'),
 (11, N'ANCA', N'Otros análisis', N'ANCA
  Parámetro                   Resultado     Unidad      Referencia
  p-ANCA                      Negativo                  Negativo
  c-ANCA                      Positivo                  Negativo
'),
 (11, N'Tiempo de coagulación y sangría', N'Hematología', N'Tiempo de coagulación y sangría
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de coagulación       11.5 *        min         5 - 10
  Tiempo de sangría           1.7           min         1 - 3
'),
 (12, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  Se observan               No se observan
'),
 (12, N'Progesterona', N'Hormonas', N'Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                13.8          ng/mL       Varía según fase del ciclo
'),
 (12, N'Proteína C reactiva cuantitativa', N'Inmunología', N'Proteína C reactiva cuantitativa
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         7.7 *         mg/L        ≤ 5
'),
 (13, N'CA-15.3', N'Marcadores tumorales', N'CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     9.8           U/mL        ≤ 30
'),
 (13, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      8.8           mg/dL       8.6 - 10.3
'),
 (13, N'Examen completo de orina', N'Uroanálisis', N'Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo
'),
 (14, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
'),
 (14, N'LH', N'Hormonas', N'LH
  Parámetro                   Resultado     Unidad      Referencia
  LH                          6.4           mUI/mL      1.7 - 8.6
'),
 (15, N'Colesterol', N'Bioquímica', N'Colesterol
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            51            mg/dL       ≤ 200
'),
 (15, N'Recuento de reticulocitos', N'Hematología', N'Recuento de reticulocitos
  Parámetro                   Resultado     Unidad      Referencia
  Reticulocitos               1.68          %           0.5 - 2.5
'),
 (16, N'CA-15.3', N'Marcadores tumorales', N'CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     23.7          U/mL        ≤ 30
'),
 (16, N'Progesterona', N'Hormonas', N'Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                15.5          ng/mL       Varía según fase del ciclo
'),
 (17, N'Triglicéridos', N'Bioquímica', N'Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               75            mg/dL       ≤ 150
'),
 (18, N'Bilirrubina total y fraccionada', N'Bioquímica', N'Bilirrubina total y fraccionada
  Parámetro                   Resultado     Unidad      Referencia
  Bilirrubina total           0.40          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.11          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.85          mg/dL       0.1 - 1
'),
 (19, N'Fosfatasa alcalina', N'Bioquímica', N'Fosfatasa alcalina
  Parámetro                   Resultado     Unidad      Referencia
  Fosfatasa alcalina          84            U/L         40 - 129
'),
 (20, N'Ácido fólico', N'Otros análisis', N'Ácido fólico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido fólico                19.9          ng/mL       3.9 - 26.8
'),
 (20, N'Ultra TSH', N'Hormonas', N'Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         5.4 *         µUI/mL      0.27 - 4.2
'),
 (21, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      8.7           mg/dL       8.6 - 10.3
'),
 (21, N'Perfil lipídico', N'Perfiles', N'Perfil lipídico
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            76            mg/dL       ≤ 200
  Triglicéridos               105           mg/dL       ≤ 150
  Colesterol HDL              52            mg/dL       ≥ 40
  Colesterol LDL              155 *         mg/dL       ≤ 130
'),
 (22, N'Aglutinaciones', N'Inmunología', N'Aglutinaciones
  Parámetro                   Resultado     Unidad      Referencia
  Tífico O                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Tífico H                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico A                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Paratífico B                Negativo (menor a 1/80)            Negativo (menor a 1/80)
  Brucella                    Negativo (menor a 1/80)            Negativo (menor a 1/80)
'),
 (22, N'Colesterol HDL', N'Bioquímica', N'Colesterol HDL
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol HDL              63            mg/dL       ≥ 40
'),
 (22, N'Urocultivo + antibiograma', N'Cultivos', N'Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        0             UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (23, N'Hepatitis A', N'Inmunología', N'Hepatitis A
  Parámetro                   Resultado     Unidad      Referencia
  Anti-HAV IgM                No reactivo               No reactivo
'),
 (23, N'T4 libre', N'Hormonas', N'T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    1.65          ng/dL       0.93 - 1.7
'),
 (23, N'VIH I, II y P24', N'Inmunología', N'VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo
'),
 (24, N'VSG', N'Hematología', N'VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  14.9          mm/h        0 - 20
'),
 (25, N'Ácido úrico', N'Bioquímica', N'Ácido úrico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido úrico                 6.6           mg/dL       3.4 - 7
'),
 (25, N'CA-19.9', N'Marcadores tumorales', N'CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     33            U/mL        ≤ 37
'),
 (25, N'Perfil hepático', N'Perfiles', N'Perfil hepático
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   4 *           U/L         5 - 40
  TGP (ALT)                   31            U/L         5 - 41
  Bilirrubina total           0.46          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.23          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.59          mg/dL       0.1 - 1
  Fosfatasa alcalina          120           U/L         40 - 129
  Proteínas totales           6.9           g/dL        6.4 - 8.3
  Albúmina                    4.5           g/dL        3.5 - 5.2
  Globulina                   1.4 *         g/dL        2 - 3.5
  GGT                         13            U/L         8 - 61
'),
 (25, N'Ultra TSH', N'Hormonas', N'Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         3.6           µUI/mL      0.27 - 4.2
'),
 (26, N'Glucosa basal', N'Bioquímica', N'Glucosa basal
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa                     83            mg/dL       70 - 100
'),
 (26, N'Parasitológico simple', N'Parasitología', N'Parasitológico simple
  Parámetro                   Resultado     Unidad      Referencia
  Consistencia                Formada                   
  Parásitos                   No se observan            No se observan
'),
 (26, N'Perfil lipídico', N'Perfiles', N'Perfil lipídico
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            172           mg/dL       ≤ 200
  Triglicéridos               76            mg/dL       ≤ 150
  Colesterol HDL              29 *          mg/dL       ≥ 40
  Colesterol LDL              120           mg/dL       ≤ 130
'),
 (27, N'CEA (antígeno carcinoembrionario)', N'Marcadores tumorales', N'CEA (antígeno carcinoembrionario)
  Parámetro                   Resultado     Unidad      Referencia
  CEA                         2.5           ng/mL       ≤ 5
'),
 (27, N'DHEA-S', N'Hormonas', N'DHEA-S
  Parámetro                   Resultado     Unidad      Referencia
  DHEA-S                      209           µg/dL       80 - 560
'),
 (27, N'Ferritina', N'Otros análisis', N'Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   266           ng/mL       30 - 400
'),
 (28, N'Hematocrito', N'Hematología', N'Hematocrito
  Parámetro                   Resultado     Unidad      Referencia
  Hematocrito                 47            %           41 - 53
'),
 (28, N'Mioglobina', N'Marcadores cardíacos', N'Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  54            ng/mL       ≤ 70
'),
 (29, N'Antimulleriana (AMH)', N'Hormonas', N'Antimulleriana (AMH)
  Parámetro                   Resultado     Unidad      Referencia
  Hormona antimulleriana      0.8           ng/mL       Varía según la edad
'),
 (29, N'Vitamina B12', N'Otros análisis', N'Vitamina B12
  Parámetro                   Resultado     Unidad      Referencia
  Vitamina B12                428           pg/mL       200 - 900
'),
 (30, N'DHEA-S', N'Hormonas', N'DHEA-S
  Parámetro                   Resultado     Unidad      Referencia
  DHEA-S                      368           µg/dL       80 - 560
'),
 (30, N'Proteína en orina de 24 horas', N'Uroanálisis', N'Proteína en orina de 24 horas
  Parámetro                   Resultado     Unidad      Referencia
  Volumen urinario de 24 h    1312          mL          800 - 2000
  Proteínas en orina de 24 h  43            mg/24 h     ≤ 150
'),
 (30, N'TGP (ALT)', N'Bioquímica', N'TGP (ALT)
  Parámetro                   Resultado     Unidad      Referencia
  TGP (ALT)                   16            U/L         5 - 41
'),
 (31, N'Hemoglobina glicosilada (HbA1c)', N'Bioquímica', N'Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     3.0 *         %           4 - 5.7
'),
 (31, N'Perfil hepático', N'Perfiles', N'Perfil hepático
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   8             U/L         5 - 40
  TGP (ALT)                   13            U/L         5 - 41
  Bilirrubina total           0.57          mg/dL       0.2 - 1.2
  Bilirrubina directa         0.27          mg/dL       ≤ 0.3
  Bilirrubina indirecta       0.53          mg/dL       0.1 - 1
  Fosfatasa alcalina          112           U/L         40 - 129
  Proteínas totales           7.6           g/dL        6.4 - 8.3
  Albúmina                    5.0           g/dL        3.5 - 5.2
  Globulina                   2.4           g/dL        2 - 3.5
  GGT                         34            U/L         8 - 61
'),
 (32, N'CA-19.9', N'Marcadores tumorales', N'CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     19            U/mL        ≤ 37
'),
 (32, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            82            ng/mL       30 - 100
'),
 (33, N'Triglicéridos', N'Bioquímica', N'Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               142           mg/dL       ≤ 150
'),
 (34, N'Mioglobina', N'Marcadores cardíacos', N'Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  36            ng/mL       ≤ 70
'),
 (34, N'Urocultivo + antibiograma', N'Cultivos', N'Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Escherichia coli            Sin crecimiento bacteriano
  Recuento de colonias        100000 *      UFC/mL      ≤ 10000
  Antibiograma                Sensible a nitrofurantoína y ciprofloxacino; resistente a ampicilina            
'),
 (35, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.0          mg/dL       8.6 - 10.3
'),
 (35, N'Examen completo de orina', N'Uroanálisis', N'Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo
'),
 (36, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      9.7           mg/dL       8.6 - 10.3
'),
 (36, N'Triglicéridos', N'Bioquímica', N'Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               127           mg/dL       ≤ 150
'),
 (36, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            27 *          ng/mL       30 - 100
'),
 (37, N'Dengue (NS1, IgM - IgG)', N'Inmunología', N'Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo
'),
 (38, N'Descarte de leishmaniasis', N'Parasitología', N'Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan
'),
 (38, N'Hemoglobina glicosilada (HbA1c)', N'Bioquímica', N'Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     3.7 *         %           4 - 5.7
'),
 (39, N'Colesterol', N'Bioquímica', N'Colesterol
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            104           mg/dL       ≤ 200
'),
 (39, N'Herpes I, II (IgG/IgM)', N'Otros análisis', N'Herpes I, II (IgG/IgM)
  Parámetro                   Resultado     Unidad      Referencia
  Herpes I, II IgG            No reactivo               No reactivo
  Herpes I, II IgM            No reactivo               No reactivo
'),
 (40, N'Cultivo de secreción uretral', N'Cultivos', N'Cultivo de secreción uretral
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (40, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            38            ng/mL       30 - 100
'),
 (41, N'Perfil recién nacido', N'Perfiles', N'Perfil recién nacido
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 20.5          g/dL        14 - 24
  Hematocrito                 54            %           44 - 64
  Glucosa                     78            mg/dL       40 - 100
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Proteína C reactiva         3.9           mg/L        ≤ 5
'),
 (42, N'GGT', N'Bioquímica', N'GGT
  Parámetro                   Resultado     Unidad      Referencia
  GGT                         47            U/L         8 - 61
'),
 (43, N'TGP (ALT)', N'Bioquímica', N'TGP (ALT)
  Parámetro                   Resultado     Unidad      Referencia
  TGP (ALT)                   12            U/L         5 - 41
'),
 (43, N'Tiempo de protrombina', N'Hematología', N'Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.1          s           11 - 13.5
  INR                         1.04          índice      0.8 - 1.2
'),
 (44, N'Dengue (NS1, IgM - IgG)', N'Inmunología', N'Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo
'),
 (44, N'Mioglobina', N'Marcadores cardíacos', N'Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  83 *          ng/mL       ≤ 70
'),
 (44, N'VSG', N'Hematología', N'VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  15.7          mm/h        0 - 20
'),
 (45, N'Proteína C reactiva cualitativa', N'Inmunología', N'Proteína C reactiva cualitativa
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         Negativo                  Negativo
'),
 (45, N'T4 libre', N'Hormonas', N'T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    1.45          ng/dL       0.93 - 1.7
'),
 (46, N'CA-19.9', N'Marcadores tumorales', N'CA-19.9
  Parámetro                   Resultado     Unidad      Referencia
  CA-19.9                     30            U/mL        ≤ 37
'),
 (46, N'Descarte de leishmaniasis', N'Parasitología', N'Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan
'),
 (47, N'Descarte de leishmaniasis', N'Parasitología', N'Descarte de leishmaniasis
  Parámetro                   Resultado     Unidad      Referencia
  Amastigotes de Leishmania   No se observan            No se observan
'),
 (47, N'VIH I, II y P24', N'Inmunología', N'VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo
'),
 (48, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan
'),
 (48, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
'),
 (49, N'Creatinina', N'Bioquímica', N'Creatinina
  Parámetro                   Resultado     Unidad      Referencia
  Creatinina                  0.53 *        mg/dL       0.7 - 1.3
'),
 (49, N'Tolerancia a la glucosa', N'Bioquímica', N'Tolerancia a la glucosa
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa basal               74            mg/dL       70 - 100
  Glucosa a la 1 hora         48            mg/dL       ≤ 180
  Glucosa a las 2 horas       85            mg/dL       ≤ 140
');
INSERT INTO #CasoSec VALUES
 (50, N'Perfil pre operatorio', N'Perfiles', N'Perfil pre operatorio
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 19.3 *        g/dL        12 - 16
  Hematocrito                 39            %           36 - 46
  Leucocitos                  10.5          x10³/µL     4.5 - 11
  Plaquetas                   303           x10³/µL     150 - 450
  Glucosa                     81            mg/dL       70 - 100
  Urea                        49 *          mg/dL       15 - 45
  Creatinina                  0.61          mg/dL       0.5 - 1.1
  VIH                         No reactivo               No reactivo
  Sífilis                     No reactivo               No reactivo
  HBsAg                       No reactivo               No reactivo
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Tiempo de coagulación       7.9           min         5 - 10
  Tiempo de sangría           2.5           min         1 - 3
  Examen completo de orina    Sin alteraciones            Sin alteraciones
'),
 (51, N'ANCA', N'Otros análisis', N'ANCA
  Parámetro                   Resultado     Unidad      Referencia
  p-ANCA                      Negativo                  Negativo
  c-ANCA                      Negativo                  Negativo
'),
 (52, N'Tiempo de coagulación y sangría', N'Hematología', N'Tiempo de coagulación y sangría
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de coagulación       5.5           min         5 - 10
  Tiempo de sangría           2.3           min         1 - 3
'),
 (53, N'Factor reumatoide cualitativo', N'Inmunología', N'Factor reumatoide cualitativo
  Parámetro                   Resultado     Unidad      Referencia
  Factor reumatoide           Negativo                  Negativo
'),
 (53, N'Parasitológico seriado', N'Parasitología', N'Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan
'),
 (53, N'PSA libre', N'Marcadores tumorales', N'PSA libre
  Parámetro                   Resultado     Unidad      Referencia
  PSA libre                   0.87          ng/mL       
  Relación PSA libre / total  90            %           25 - 100
'),
 (54, N'Glucosa post prandial', N'Bioquímica', N'Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       84            mg/dL       ≤ 140
'),
 (54, N'Helicobacter pylori antígeno en heces', N'Otros análisis', N'Helicobacter pylori antígeno en heces
  Parámetro                   Resultado     Unidad      Referencia
  Helicobacter pylori (antígeno)Negativo                  Negativo
'),
 (54, N'Progesterona', N'Hormonas', N'Progesterona
  Parámetro                   Resultado     Unidad      Referencia
  Progesterona                19.2          ng/mL       Varía según fase del ciclo
'),
 (55, N'Hemoglobina glicosilada (HbA1c)', N'Bioquímica', N'Hemoglobina glicosilada (HbA1c)
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina glicosilada     4.2           %           4 - 5.7
'),
 (55, N'Parasitológico seriado', N'Parasitología', N'Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   Se observan               No se observan
'),
 (56, N'Tiempo de protrombina', N'Hematología', N'Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       12.4          s           11 - 13.5
  INR                         1.17          índice      0.8 - 1.2
'),
 (57, N'Hematocrito', N'Hematología', N'Hematocrito
  Parámetro                   Resultado     Unidad      Referencia
  Hematocrito                 42            %           41 - 53
'),
 (58, N'CA-125', N'Marcadores tumorales', N'CA-125
  Parámetro                   Resultado     Unidad      Referencia
  CA-125                      30            U/mL        ≤ 35
'),
 (58, N'Tiempo de protrombina', N'Hematología', N'Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       13.3          s           11 - 13.5
  INR                         1.12          índice      0.8 - 1.2
'),
 (58, N'Urocultivo + antibiograma', N'Cultivos', N'Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        100000 *      UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (59, N'GGT', N'Bioquímica', N'GGT
  Parámetro                   Resultado     Unidad      Referencia
  GGT                         17            U/L         8 - 61
'),
 (59, N'Hemoglobina', N'Hematología', N'Hemoglobina
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 8.9 *         g/dL        12 - 16
'),
 (60, N'CA-15.3', N'Marcadores tumorales', N'CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     19.4          U/mL        ≤ 30
'),
 (60, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.6          g/dL        12 - 16
  Leucocitos                  5.3           x10³/µL     4.5 - 11
  Plaquetas                   358           x10³/µL     150 - 450
'),
 (61, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            86            ng/mL       30 - 100
'),
 (62, N'TGO (AST)', N'Bioquímica', N'TGO (AST)
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   10            U/L         5 - 40
'),
 (63, N'Creatinina', N'Bioquímica', N'Creatinina
  Parámetro                   Resultado     Unidad      Referencia
  Creatinina                  0.56          mg/dL       0.5 - 1.1
'),
 (63, N'Triglicéridos', N'Bioquímica', N'Triglicéridos
  Parámetro                   Resultado     Unidad      Referencia
  Triglicéridos               142           mg/dL       ≤ 150
'),
 (64, N'TGO (AST)', N'Bioquímica', N'TGO (AST)
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   28            U/L         5 - 40
'),
 (64, N'Tiempo de protrombina', N'Hematología', N'Tiempo de protrombina
  Parámetro                   Resultado     Unidad      Referencia
  Tiempo de protrombina       8.2 *         s           11 - 13.5
  INR                         0.89          índice      0.8 - 1.2
'),
 (64, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            40            ng/mL       30 - 100
'),
 (65, N'Ácido fólico', N'Otros análisis', N'Ácido fólico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido fólico                22.3          ng/mL       3.9 - 26.8
'),
 (65, N'Colesterol LDL', N'Bioquímica', N'Colesterol LDL
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol LDL              160 *         mg/dL       ≤ 130
'),
 (65, N'Dengue (NS1, IgM - IgG)', N'Inmunología', N'Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo
'),
 (66, N'Ferritina', N'Otros análisis', N'Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   312           ng/mL       30 - 400
'),
 (66, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  Se observan               No se observan
'),
 (66, N'PCR cuantitativo (cardíaco)', N'Marcadores cardíacos', N'PCR cuantitativo (cardíaco)
  Parámetro                   Resultado     Unidad      Referencia
  Proteína C reactiva         6.3 *         mg/L        ≤ 5
'),
 (67, N'Examen completo de orina', N'Uroanálisis', N'Examen completo de orina
  Parámetro                   Resultado     Unidad      Referencia
  Aspecto                     Transparente              Transparente
  Leucocitos por campo        0 a 5 por campo            0 a 5 por campo
'),
 (68, N'Urocultivo + antibiograma', N'Cultivos', N'Urocultivo + antibiograma
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Recuento de colonias        0             UFC/mL      ≤ 10000
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (69, N'Ultra TSH', N'Hormonas', N'Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         3.1           µUI/mL      0.27 - 4.2
'),
 (70, N'T4 libre', N'Hormonas', N'T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    0.69 *        ng/dL       0.93 - 1.7
'),
 (71, N'Helicobacter pylori antígeno en heces', N'Otros análisis', N'Helicobacter pylori antígeno en heces
  Parámetro                   Resultado     Unidad      Referencia
  Helicobacter pylori (antígeno)Negativo                  Negativo
'),
 (71, N'Rotavirus y adenovirus', N'Parasitología', N'Rotavirus y adenovirus
  Parámetro                   Resultado     Unidad      Referencia
  Rotavirus                   Negativo                  Negativo
  Adenovirus                  Positivo                  Negativo
'),
 (71, N'Sífilis (prueba rápida)', N'Inmunología', N'Sífilis (prueba rápida)
  Parámetro                   Resultado     Unidad      Referencia
  Sífilis                     No reactivo               No reactivo
'),
 (72, N'B-HCG cualitativa', N'Inmunología', N'B-HCG cualitativa
  Parámetro                   Resultado     Unidad      Referencia
  B-HCG                       Negativo                  Negativo
'),
 (72, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 15.1          g/dL        12 - 16
  Leucocitos                  9.9           x10³/µL     4.5 - 11
  Plaquetas                   221           x10³/µL     150 - 450
'),
 (73, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.1          mg/dL       8.6 - 10.3
'),
 (73, N'Sífilis (prueba rápida)', N'Inmunología', N'Sífilis (prueba rápida)
  Parámetro                   Resultado     Unidad      Referencia
  Sífilis                     No reactivo               No reactivo
'),
 (74, N'Ácido úrico', N'Bioquímica', N'Ácido úrico
  Parámetro                   Resultado     Unidad      Referencia
  Ácido úrico                 5.3           mg/dL       3.4 - 7
'),
 (74, N'Ferritina', N'Otros análisis', N'Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   80            ng/mL       30 - 400
'),
 (75, N'Ultra TSH', N'Hormonas', N'Ultra TSH
  Parámetro                   Resultado     Unidad      Referencia
  TSH                         2.6           µUI/mL      0.27 - 4.2
'),
 (76, N'Cortisol', N'Otros análisis', N'Cortisol
  Parámetro                   Resultado     Unidad      Referencia
  Cortisol (mañana)           5.8 *         µg/dL       6.2 - 19.4
'),
 (76, N'Cultivo de semen (espermocultivo)', N'Cultivos', N'Cultivo de semen (espermocultivo)
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (77, N'Troponina I', N'Marcadores cardíacos', N'Troponina I
  Parámetro                   Resultado     Unidad      Referencia
  Troponina I                 0.028         ng/mL       ≤ 0.04
'),
 (77, N'VSG', N'Hematología', N'VSG
  Parámetro                   Resultado     Unidad      Referencia
  Velocidad de sedimentación  13.9          mm/h        0 - 20
'),
 (78, N'CA-15.3', N'Marcadores tumorales', N'CA-15.3
  Parámetro                   Resultado     Unidad      Referencia
  CA-15.3                     21.7          U/mL        ≤ 30
'),
 (78, N'Estradiol', N'Hormonas', N'Estradiol
  Parámetro                   Resultado     Unidad      Referencia
  Estradiol                   285           pg/mL       Varía según fase del ciclo
'),
 (78, N'Factor reumatoide cualitativo', N'Inmunología', N'Factor reumatoide cualitativo
  Parámetro                   Resultado     Unidad      Referencia
  Factor reumatoide           Negativo                  Negativo
'),
 (79, N'Prolactina', N'Hormonas', N'Prolactina
  Parámetro                   Resultado     Unidad      Referencia
  Prolactina                  30.0 *        ng/mL       4.8 - 23.3
'),
 (80, N'Glucosa post prandial', N'Bioquímica', N'Glucosa post prandial
  Parámetro                   Resultado     Unidad      Referencia
  Glucosa post prandial       107           mg/dL       ≤ 140
'),
 (80, N'Parasitológico seriado', N'Parasitología', N'Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan
'),
 (81, N'Perfil pre operatorio', N'Perfiles', N'Perfil pre operatorio
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 15.9          g/dL        13.5 - 17.5
  Hematocrito                 48            %           41 - 53
  Leucocitos                  9.2           x10³/µL     4.5 - 11
  Plaquetas                   584 *         x10³/µL     150 - 450
  Glucosa                     79            mg/dL       70 - 100
  Urea                        33            mg/dL       15 - 45
  Creatinina                  1.43 *        mg/dL       0.7 - 1.3
  VIH                         Reactivo                  No reactivo
  Sífilis                     No reactivo               No reactivo
  HBsAg                       No reactivo               No reactivo
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
  Tiempo de coagulación       9.2           min         5 - 10
  Tiempo de sangría           2.1           min         1 - 3
  Examen completo de orina    Sin alteraciones            Sin alteraciones
'),
 (81, N'PSA total', N'Marcadores tumorales', N'PSA total
  Parámetro                   Resultado     Unidad      Referencia
  PSA total                   1.3           ng/mL       ≤ 4
'),
 (82, N'Hepatitis A', N'Inmunología', N'Hepatitis A
  Parámetro                   Resultado     Unidad      Referencia
  Anti-HAV IgM                No reactivo               No reactivo
'),
 (83, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      10.1          mg/dL       8.6 - 10.3
'),
 (83, N'Mioglobina', N'Marcadores cardíacos', N'Mioglobina
  Parámetro                   Resultado     Unidad      Referencia
  Mioglobina                  41            ng/mL       ≤ 70
'),
 (83, N'Parasitológico simple', N'Parasitología', N'Parasitológico simple
  Parámetro                   Resultado     Unidad      Referencia
  Consistencia                Blanda                    
  Parásitos                   No se observan            No se observan
'),
 (84, N'VIH I, II y P24', N'Inmunología', N'VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo
'),
 (85, N'FSH', N'Hormonas', N'FSH
  Parámetro                   Resultado     Unidad      Referencia
  FSH                         3.6           mUI/mL      Varía según fase del ciclo
'),
 (85, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan
'),
 (85, N'Parasitológico seriado', N'Parasitología', N'Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan
'),
 (86, N'CEA (antígeno carcinoembrionario)', N'Marcadores tumorales', N'CEA (antígeno carcinoembrionario)
  Parámetro                   Resultado     Unidad      Referencia
  CEA                         1.7           ng/mL       ≤ 5
'),
 (86, N'Urea', N'Bioquímica', N'Urea
  Parámetro                   Resultado     Unidad      Referencia
  Urea                        28            mg/dL       15 - 45
'),
 (87, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 14.0          g/dL        13.5 - 17.5
  Leucocitos                  10.0          x10³/µL     4.5 - 11
  Plaquetas                   263           x10³/µL     150 - 450
'),
 (87, N'Vitamina B12', N'Otros análisis', N'Vitamina B12
  Parámetro                   Resultado     Unidad      Referencia
  Vitamina B12                248           pg/mL       200 - 900
'),
 (88, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
'),
 (88, N'TGO (AST)', N'Bioquímica', N'TGO (AST)
  Parámetro                   Resultado     Unidad      Referencia
  TGO (AST)                   18            U/L         5 - 40
'),
 (89, N'DHEA-S', N'Hormonas', N'DHEA-S
  Parámetro                   Resultado     Unidad      Referencia
  DHEA-S                      333           µg/dL       35 - 430
'),
 (90, N'Ferritina', N'Otros análisis', N'Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   144           ng/mL       30 - 400
'),
 (90, N'PSA libre', N'Marcadores tumorales', N'PSA libre
  Parámetro                   Resultado     Unidad      Referencia
  PSA libre                   0.62          ng/mL       
  Relación PSA libre / total  36            %           25 - 100
'),
 (91, N'Factor reumatoide cualitativo', N'Inmunología', N'Factor reumatoide cualitativo
  Parámetro                   Resultado     Unidad      Referencia
  Factor reumatoide           Negativo                  Negativo
'),
 (91, N'Perfil lipídico', N'Perfiles', N'Perfil lipídico
  Parámetro                   Resultado     Unidad      Referencia
  Colesterol total            176           mg/dL       ≤ 200
  Triglicéridos               123           mg/dL       ≤ 150
  Colesterol HDL              45            mg/dL       ≥ 40
  Colesterol LDL              94            mg/dL       ≤ 130
'),
 (92, N'Calcio sérico', N'Bioquímica', N'Calcio sérico
  Parámetro                   Resultado     Unidad      Referencia
  Calcio                      9.1           mg/dL       8.6 - 10.3
'),
 (92, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan
'),
 (93, N'CK-MB', N'Marcadores cardíacos', N'CK-MB
  Parámetro                   Resultado     Unidad      Referencia
  CK-MB                       11.6          U/L         ≤ 24
'),
 (94, N'Dengue (NS1, IgM - IgG)', N'Inmunología', N'Dengue (NS1, IgM - IgG)
  Parámetro                   Resultado     Unidad      Referencia
  Dengue NS1                  Negativo                  Negativo
  Dengue IgM                  Negativo                  Negativo
  Dengue IgG                  Negativo                  Negativo
'),
 (94, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             B                         
  Factor Rh                   Positivo                  
'),
 (94, N'Hemograma completo', N'Hematología', N'Hemograma completo
  Parámetro                   Resultado     Unidad      Referencia
  Hemoglobina                 13.8          g/dL        12 - 16
  Leucocitos                  6.7           x10³/µL     4.5 - 11
  Plaquetas                   251           x10³/µL     150 - 450
'),
 (94, N'VIH I, II y P24', N'Inmunología', N'VIH I, II y P24
  Parámetro                   Resultado     Unidad      Referencia
  VIH I, II y antígeno P24    No reactivo               No reactivo
'),
 (95, N'Vitamina D', N'Otros análisis', N'Vitamina D
  Parámetro                   Resultado     Unidad      Referencia
  25-OH vitamina D            69            ng/mL       30 - 100
'),
 (96, N'AFP (alfa feto proteína)', N'Marcadores tumorales', N'AFP (alfa feto proteína)
  Parámetro                   Resultado     Unidad      Referencia
  AFP                         2.7           ng/mL       ≤ 7
'),
 (97, N'Ferritina', N'Otros análisis', N'Ferritina
  Parámetro                   Resultado     Unidad      Referencia
  Ferritina                   35            ng/mL       13 - 150
'),
 (97, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
'),
 (97, N'T4 total', N'Hormonas', N'T4 total
  Parámetro                   Resultado     Unidad      Referencia
  T4 total                    12.1          µg/dL       5.1 - 14.1
'),
 (98, N'Cultivo de secreción vaginal', N'Cultivos', N'Cultivo de secreción vaginal
  Parámetro                   Resultado     Unidad      Referencia
  Germen aislado              Sin crecimiento bacteriano            Sin crecimiento bacteriano
  Antibiograma                No se realizó (cultivo negativo)            
'),
 (99, N'Albúmina', N'Bioquímica', N'Albúmina
  Parámetro                   Resultado     Unidad      Referencia
  Albúmina                    4.0           g/dL        3.5 - 5.2
'),
 (99, N'Grupo sanguíneo y factor Rh', N'Inmunología', N'Grupo sanguíneo y factor Rh
  Parámetro                   Resultado     Unidad      Referencia
  Grupo sanguíneo             O                         
  Factor Rh                   Positivo                  
'),
 (99, N'Parasitológico seriado', N'Parasitología', N'Parasitológico seriado
  Parámetro                   Resultado     Unidad      Referencia
  Parásitos                   No se observan            No se observan
'),
 (100, N'Gota gruesa', N'Parasitología', N'Gota gruesa
  Parámetro                   Resultado     Unidad      Referencia
  Plasmodium                  No se observan            No se observan
'),
 (100, N'T4 libre', N'Hormonas', N'T4 libre
  Parámetro                   Resultado     Unidad      Referencia
  T4 libre                    1.40          ng/dL       0.93 - 1.7
');
IF NOT EXISTS (SELECT 1 FROM Plantilla WHERE Nombre = N'Otros análisis') OR (SELECT COUNT(*) FROM Examen) < 119
    THROW 50001, N'Primero ejecute 03_CEIBIO_Analisis.sql.', 1;

DECLARE @uAdm INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'admision'),
        @uEnf INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'enfermera'),
        @uCaj INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'cajero'),
        @uOri INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'orientador'),
        @uFle INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'flebotomista'),
        @uIti INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'itinerante'),
        @uAux INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'auxlab'),
        @uAna INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'analista'),
        @uPat INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'patologo'),
        @uDig INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'digitador'),
        @uCal INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'calidad'),
        @uDir INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'director'),
        @uEnt INT = (SELECT IdUsuario FROM Usuario WHERE NombreUsuario = N'entregas');

IF @uAdm IS NULL OR @uEnf IS NULL OR @uCaj IS NULL OR @uOri IS NULL OR @uFle IS NULL OR @uIti IS NULL OR @uAux IS NULL
   OR @uAna IS NULL OR @uPat IS NULL OR @uDig IS NULL OR @uCal IS NULL OR @uDir IS NULL OR @uEnt IS NULL
    THROW 50002, N'Faltan usuarios de prueba (admision, enfermera, cajero, etc.). Ejecute primero 01_CEIBIO_DB_Tablas.sql.', 1;

DECLARE @Creados INT = 0, @Omitidos INT = 0;
DECLARE @K INT, @Etapa VARCHAR(3), @Dni CHAR(8), @Nombres NVARCHAR(80), @Apellidos NVARCHAR(80), @Nac DATE, @Sexo NVARCHAR(10),
        @Direccion NVARCHAR(150), @Telefono VARCHAR(9), @Dom BIT, @Convenio NVARCHAR(120), @Medio VARCHAR(10), @BoxNum VARCHAR(10),
        @T0 DATETIME, @TGen DATETIME, @TEnt DATETIME, @Contenido NVARCHAR(MAX);
DECLARE @IdPaciente INT, @IdAtencion INT, @IdConvenio INT, @Pct DECIMAL(5,2), @Sub DECIMAL(10,2), @Desc DECIMAL(10,2), @Total DECIMAL(10,2),
        @Estado NVARCHAR(40), @Off INT, @IdMedio INT, @IdPago INT, @IdComp INT, @NumComp VARCHAR(15), @Turno INT, @IdBox INT,
        @IdVisita INT, @IdMuestra INT, @CodMuestra VARCHAR(12), @EstMuestra NVARCHAR(30), @Minutos INT, @IdReporte INT,
        @EstRep NVARCHAR(40), @NumAt VARCHAR(12), @Ayuno INT, @Req BIT;
DECLARE @c TABLE (Serie VARCHAR(10), Ultimo INT);

DECLARE cur CURSOR LOCAL FAST_FORWARD FOR
    SELECT K, Etapa, Dni, Nombres, Apellidos, FechaNacimiento, Sexo, Direccion, Telefono, Domicilio, Convenio, Medio, Box, T0, TGen, TEnt, Contenido
    FROM #Caso ORDER BY T0, K;
OPEN cur;
FETCH NEXT FROM cur INTO @K, @Etapa, @Dni, @Nombres, @Apellidos, @Nac, @Sexo, @Direccion, @Telefono, @Dom, @Convenio, @Medio, @BoxNum, @T0, @TGen, @TEnt, @Contenido;
WHILE @@FETCH_STATUS = 0
BEGIN
    IF EXISTS (SELECT 1 FROM Paciente WHERE Dni = @Dni)
       OR EXISTS (SELECT 1 FROM #CasoEx x WHERE x.K = @K AND NOT EXISTS (SELECT 1 FROM Examen e WHERE e.Nombre = x.Examen AND e.Habilitado = 1))
    BEGIN
        SET @Omitidos += 1;
    END
    ELSE
    BEGIN
    BEGIN TRY
        BEGIN TRAN;

        SET @Off = CASE WHEN @Dom = 1 THEN 60 ELSE 0 END;
        SET @Estado = CASE @Etapa WHEN 'CUL' THEN N'Culminada' WHEN 'REC' THEN N'Muestra recolectada'
                                  WHEN 'RRA' THEN N'Recibida para análisis' WHEN 'PVA' THEN N'Recibida para análisis'
                                  ELSE N'Lista para reporte' END;

        INSERT INTO Paciente (Dni, Nombres, Apellidos, FechaNacimiento, Sexo, Direccion, Telefono, IdUsuarioRegistro, FechaRegistro)
        VALUES (@Dni, @Nombres, @Apellidos, @Nac, @Sexo, @Direccion, @Telefono, @uAdm, DATEADD(MINUTE, -5, @T0));
        SET @IdPaciente = SCOPE_IDENTITY();

        SELECT @IdConvenio = NULL, @Pct = 0;
        SELECT TOP 1 @IdConvenio = IdConvenio, @Pct = PorcentajeDescuento FROM Convenio
        WHERE Institucion = @Convenio AND Habilitado = 1 AND CAST(@T0 AS DATE) BETWEEN FechaInicio AND FechaFin;

        SELECT @Sub = SUM(e.Tarifa) FROM #CasoEx x INNER JOIN Examen e ON e.Nombre = x.Examen WHERE x.K = @K;
        SET @Desc = ROUND(@Sub * @Pct / 100, 2);
        SET @Total = @Sub - @Desc;

        INSERT INTO Atencion (IdPaciente, FechaRegistro, Modalidad, IdConvenio, Subtotal, Descuento, CostoTotal, Estado, IdUsuarioRegistro)
        VALUES (@IdPaciente, @T0, CASE WHEN @Dom = 1 THEN N'A domicilio' ELSE N'En sede' END, @IdConvenio, @Sub, @Desc, @Total, @Estado, @uAdm);
        SET @IdAtencion = SCOPE_IDENTITY();
        SELECT @NumAt = NumeroAtencion FROM Atencion WHERE IdAtencion = @IdAtencion;

        INSERT INTO AtencionExamen (IdAtencion, IdExamen, Tarifa)
        SELECT DISTINCT @IdAtencion, e.IdExamen, e.Tarifa FROM #CasoEx x INNER JOIN Examen e ON e.Nombre = x.Examen WHERE x.K = @K;

        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
        VALUES (N'Paciente', @IdPaciente, N'Registro', @Dni, @uAdm, DATEADD(MINUTE, -5, @T0)),
               (N'Atencion', @IdAtencion, N'Registro', N'Pendiente de evaluación', @uAdm, @T0);

        IF @Dom = 1
        BEGIN
            INSERT INTO VisitaDomiciliaria (IdAtencion, Direccion, Referencia, Telefono, FechaProgramada, Estado, IdTecnico, IdUsuarioRegistro, FechaRegistro)
            VALUES (@IdAtencion, @Direccion, N'Frente a la plaza', @Telefono, CAST(@T0 AS DATE), N'Realizada', @uIti, @uAdm, DATEADD(MINUTE, 2, @T0));
            SET @IdVisita = SCOPE_IDENTITY();
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
            VALUES (N'VisitaDomiciliaria', @IdVisita, N'Registro', N'Programada', @uAdm, DATEADD(MINUTE, 2, @T0));
        END

        SET @Ayuno = 8 + (@K % 5);
        SET @Req = CASE WHEN EXISTS (SELECT 1 FROM #CasoEx x INNER JOIN Examen e ON e.Nombre = x.Examen
                                     WHERE x.K = @K AND e.TipoMuestra IN (N'Orina', N'Heces')) THEN 1 ELSE 0 END;
        INSERT INTO EvaluacionPreanalitica (IdAtencion, HorasAyuno, Medicamentos, RotuladoCorrecto, RecipienteHermetico, VolumenSuficiente,
                    ConservacionAdecuada, Observaciones, IdUsuarioObservacion, FechaObservacion, Resultado, IdUsuarioResultado, FechaResultado)
        VALUES (@IdAtencion, @Ayuno, CASE WHEN @K % 6 = 0 THEN N'Losartán 50 mg' END,
                CASE WHEN @Req = 1 THEN 1 END, CASE WHEN @Req = 1 THEN 1 END, CASE WHEN @Req = 1 THEN 1 END, CASE WHEN @Req = 1 THEN 1 END,
                NULL, @uEnf, DATEADD(MINUTE, 8, @T0), N'Apto', @uEnf, DATEADD(MINUTE, 12, @T0));
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
        VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pendiente de pago', @uEnf, DATEADD(MINUTE, 12, @T0));

        SET @IdMedio = (SELECT IdMedioPago FROM MedioPago WHERE Codigo = @Medio);
        INSERT INTO Pago (IdAtencion, IdMedioPago, Importe, MontoRecibido, Vuelto, Estado, IdCajero, FechaRegistro, FechaConformidad)
        VALUES (@IdAtencion, @IdMedio, @Total,
                CASE WHEN @Medio = 'EFE' THEN CEILING(@Total / 10) * 10 ELSE @Total END,
                CASE WHEN @Medio = 'EFE' THEN CEILING(@Total / 10) * 10 - @Total ELSE 0 END,
                N'Conforme', @uCaj, DATEADD(MINUTE, 20, @T0), DATEADD(MINUTE, 20, @T0));
        SET @IdPago = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
        VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Pagada', @uCaj, DATEADD(MINUTE, 20, @T0));

        DELETE FROM @c;
        UPDATE Correlativo SET Ultimo = Ultimo + 1 OUTPUT inserted.Serie, inserted.Ultimo INTO @c WHERE Tipo = 'COMPROBANTE';
        SELECT @NumComp = Serie + '-' + RIGHT('000000' + CAST(Ultimo AS VARCHAR(10)), 6) FROM @c;
        INSERT INTO Comprobante (NumeroComprobante, IdAtencion, IdPago, FechaEmision, Subtotal, Descuento, Total, IdCajero)
        VALUES (@NumComp, @IdAtencion, @IdPago, DATEADD(MINUTE, 21, @T0), @Sub, @Desc, @Total, @uCaj);
        SET @IdComp = SCOPE_IDENTITY();
        INSERT INTO Recaudacion (IdComprobante, Fecha, Importe, IdMedioPago, IdCajero, Tipo, FechaRegistro)
        VALUES (@IdComp, CAST(@T0 AS DATE), @Total, @IdMedio, @uCaj, N'Ingreso', DATEADD(MINUTE, 21, @T0));

        IF @Dom = 0
        BEGIN
            SELECT @Turno = ISNULL(MAX(NumeroTurno), 0) + 1 FROM Atencion WHERE CAST(FechaDerivacion AS DATE) = CAST(@T0 AS DATE);
            SET @IdBox = (SELECT MIN(IdBox) FROM Box WHERE Numero = @BoxNum);
            IF @IdBox IS NULL SET @IdBox = (SELECT MIN(IdBox) FROM Box WHERE Habilitado = 1);
            UPDATE Atencion SET NumeroTurno = @Turno, FechaDerivacion = DATEADD(MINUTE, 25, @T0), IdBox = @IdBox WHERE IdAtencion = @IdAtencion;
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
            VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'En espera de toma de muestra - turno ' + CAST(@Turno AS NVARCHAR(10)), @uCaj, DATEADD(MINUTE, 25, @T0)),
                   (N'Atencion', @IdAtencion, N'Cambio de estado', N'En toma de muestra - box ' + ISNULL((SELECT Numero FROM Box WHERE IdBox = @IdBox), N''), @uOri, DATEADD(MINUTE, 40, @T0));
        END
        ELSE
        BEGIN
            UPDATE Atencion SET FechaDerivacion = DATEADD(MINUTE, 25, @T0) WHERE IdAtencion = @IdAtencion;
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
            VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Visita asignada - técnico ' + CAST(@uIti AS NVARCHAR(10)), @uCaj, DATEADD(MINUTE, 25, @T0)),
                   (N'VisitaDomiciliaria', @IdVisita, N'Cambio de estado', N'Realizada', @uIti, DATEADD(MINUTE, 50 + @Off, @T0));
        END

        DELETE FROM @c;
        UPDATE Correlativo SET Ultimo = Ultimo + 1 OUTPUT inserted.Serie, inserted.Ultimo INTO @c WHERE Tipo = 'MUESTRA';
        SELECT @CodMuestra = Serie + '-' + RIGHT('000000' + CAST(Ultimo AS VARCHAR(10)), 6) FROM @c;
        SET @EstMuestra = CASE WHEN @Etapa = 'REC' THEN N'Muestra recolectada' ELSE N'Recibida para análisis' END;
        SELECT @Minutos = NULLIF(MAX(t.MinutosCentrifugacion), 0)
        FROM #CasoEx x INNER JOIN Examen e ON e.Nombre = x.Examen
        INNER JOIN TuboExamen te ON te.IdExamen = e.IdExamen INNER JOIN Tubo t ON t.IdTubo = te.IdTubo
        WHERE x.K = @K;

        INSERT INTO Muestra (IdAtencion, Codigo, FechaGeneracion, IdUsuarioGenera, HoraExtraccion, IdUsuarioToma, FechaValidacion,
                             CondicionesDeclaradas, FechaIngreso, IdUsuarioIngreso, EstadoConservacion, MinutosCentrifugacion,
                             FechaAcondicionamiento, IdUsuarioAcondiciona, FechaRecepcion, IdUsuarioRecepcion, Estado)
        VALUES (@IdAtencion, @CodMuestra, DATEADD(MINUTE, 41 + @Off, @T0), CASE WHEN @Dom = 1 THEN @uIti ELSE @uFle END,
                DATEADD(MINUTE, 48 + @Off, @T0), CASE WHEN @Dom = 1 THEN @uIti ELSE @uFle END, DATEADD(MINUTE, 50 + @Off, @T0),
                CASE WHEN @Dom = 1 THEN N'Paciente en ayunas de ' + CAST(@Ayuno AS NVARCHAR(10)) + N' horas' END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE DATEADD(MINUTE, 120 + @Off, @T0) END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE @uAux END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE N'Adecuado' END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE @Minutos END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE DATEADD(MINUTE, 135 + @Off, @T0) END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE @uAux END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE DATEADD(MINUTE, 150 + @Off, @T0) END,
                CASE WHEN @Etapa = 'REC' THEN NULL ELSE @uAna END,
                @EstMuestra);
        SET @IdMuestra = SCOPE_IDENTITY();
        INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
        VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Muestra recolectada', CASE WHEN @Dom = 1 THEN @uIti ELSE @uFle END, DATEADD(MINUTE, 50 + @Off, @T0));

        IF @Etapa <> 'REC'
        BEGIN
            INSERT INTO MovimientoMuestra (IdMuestra, TipoMovimiento, FechaHora, IdUsuario, Detalle)
            VALUES (@IdMuestra, N'Ingreso', DATEADD(MINUTE, 120 + @Off, @T0), @uAux, NULL),
                   (@IdMuestra, N'Acondicionamiento', DATEADD(MINUTE, 135 + @Off, @T0), @uAux,
                    N'Conservación: Adecuado; centrifugación: ' + ISNULL(CAST(@Minutos AS NVARCHAR(10)) + N' min', N'no aplica')),
                   (@IdMuestra, N'Recepción', DATEADD(MINUTE, 150 + @Off, @T0), @uAna, NULL);
            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
            VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Recibida para análisis', @uAna, DATEADD(MINUTE, 150 + @Off, @T0));

            INSERT INTO UsoEquipo (IdEquipo, IdMuestra, HoraInicio, IdTecnico, RequiereNuevaCorrida)
            SELECT q.IdEquipo, @IdMuestra, DATEADD(MINUTE, 170 + @Off, @T0), @uAna, 0
            FROM (SELECT DISTINCT (SELECT MIN(IdEquipo) FROM Equipo eq WHERE eq.Nombre = x.Equipo) AS IdEquipo FROM #CasoEx x WHERE x.K = @K) q
            WHERE q.IdEquipo IS NOT NULL;
        END

        IF @Etapa NOT IN ('REC', 'RRA')
        BEGIN
            INSERT INTO ResultadoAnalitico (IdAtencion, IdParametro, Valor, Estado, IdTecnico, FechaRegistro, FechaEnvio, IdMedico, FechaValidacion)
            SELECT @IdAtencion, pa.IdParametro, r.Valor,
                   CASE WHEN @Etapa = 'PVA' THEN N'Pendiente de validación' ELSE N'Validado' END,
                   @uAna, DATEADD(MINUTE, 240 + @Off, @T0), DATEADD(MINUTE, 250 + @Off, @T0),
                   CASE WHEN @Etapa = 'PVA' THEN NULL ELSE @uPat END,
                   CASE WHEN @Etapa = 'PVA' THEN NULL ELSE DATEADD(MINUTE, 400 + @Off, @T0) END
            FROM #CasoRes r
            INNER JOIN Examen e ON e.Nombre = r.Examen
            INNER JOIN AtencionExamen ae ON ae.IdAtencion = @IdAtencion AND ae.IdExamen = e.IdExamen
            CROSS APPLY (SELECT MIN(IdParametro) AS IdParametro FROM Parametro p WHERE p.IdExamen = e.IdExamen AND p.Nombre = r.Parametro AND p.Habilitado = 1) pa
            WHERE r.K = @K AND pa.IdParametro IS NOT NULL;

            INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
            SELECT N'Atencion', @IdAtencion, N'Envío a validación',
                   CAST(COUNT(*) AS NVARCHAR(10)) + N' resultado(s) del examen ' + CAST(pa.IdExamen AS NVARCHAR(10)) + N' enviados a validación',
                   @uAna, DATEADD(MINUTE, 250 + @Off, @T0)
            FROM ResultadoAnalitico ra INNER JOIN Parametro pa ON pa.IdParametro = ra.IdParametro
            WHERE ra.IdAtencion = @IdAtencion
            GROUP BY pa.IdExamen;

            IF @Etapa <> 'PVA'
                INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
                VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Lista para reporte', @uPat, DATEADD(MINUTE, 400 + @Off, @T0));
        END

        IF @Contenido IS NOT NULL
        BEGIN
            SET @Contenido = REPLACE(@Contenido, N'{AT}', @NumAt);
            SET @EstRep = CASE @Etapa WHEN 'REV' THEN N'En revisión de calidad' WHEN 'PAU' THEN N'Pendiente de autorización'
                                      WHEN 'DIS' THEN N'Disponible para entrega' ELSE N'Entregado' END;
            INSERT INTO ReporteClinico (IdAtencion, Version, Contenido, Estado, Definitivo, IdDigitador, FechaGeneracion, IdDirector, FechaAutorizacion)
            VALUES (@IdAtencion, 1, @Contenido, @EstRep, CASE WHEN @Etapa = 'REV' THEN 0 ELSE 1 END, @uDig, @TGen,
                    CASE WHEN @Etapa IN ('REV', 'PAU') THEN NULL ELSE @uDir END,
                    CASE WHEN @Etapa IN ('REV', 'PAU') THEN NULL ELSE DATEADD(MINUTE, 180, @TGen) END);
            SET @IdReporte = SCOPE_IDENTITY();

            INSERT INTO ReporteSeccion (IdReporte, Version, IdExamen, IdPlantilla, Contenido)
            SELECT @IdReporte, 1, e.IdExamen, pl.IdPlantilla, s.Contenido
            FROM #CasoSec s
            INNER JOIN Examen e ON e.Nombre = s.Examen
            CROSS APPLY (SELECT MIN(IdPlantilla) AS IdPlantilla FROM Plantilla WHERE Nombre = s.Plantilla) pl
            WHERE s.K = @K AND pl.IdPlantilla IS NOT NULL;

            INSERT INTO ReporteHistorial (IdReporte, Version, Accion, Observacion, Contenido, IdUsuario, Fecha)
            SELECT @IdReporte, 1, h.Accion, NULL, CASE WHEN h.Orden = 1 THEN @Contenido END, h.IdUsuario, DATEADD(MINUTE, h.Minuto, @TGen)
            FROM (VALUES (1, N'Generado', @uDig, 0), (2, N'Enviado a revisión', @uDig, 10), (3, N'Conformidad de calidad', @uCal, 90),
                         (4, N'Guardado como definitivo', @uDig, 100), (5, N'Enviado a autorización', @uDig, 105),
                         (6, N'Autorizado', @uDir, 180), (7, N'Enviado a entrega', @uDir, 185)) h (Orden, Accion, IdUsuario, Minuto)
            WHERE h.Orden <= CASE @Etapa WHEN 'REV' THEN 2 WHEN 'PAU' THEN 5 ELSE 7 END;

            IF @Etapa IN ('CUL', 'ENT')
            BEGIN
                INSERT INTO Entrega (IdReporte, NombreRecibe, DniRecibe, Relacion, IdUsuario, FechaEntrega)
                VALUES (@IdReporte, @Nombres + N' ' + @Apellidos, @Dni, N'Paciente', @uEnt, @TEnt);
                INSERT INTO ReporteHistorial (IdReporte, Version, Accion, IdUsuario, Fecha)
                VALUES (@IdReporte, 1, N'Entregado', @uEnt, @TEnt);
                IF @Etapa = 'CUL'
                    INSERT INTO Auditoria (Tabla, IdRegistro, Accion, Detalle, IdUsuario, FechaHora)
                    VALUES (N'Atencion', @IdAtencion, N'Cambio de estado', N'Culminada', @uEnt, DATEADD(MINUTE, 5, @TEnt));
            END
        END

        COMMIT;
        SET @Creados += 1;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        CLOSE cur;
        DEALLOCATE cur;
        THROW;
    END CATCH
    END

    FETCH NEXT FROM cur INTO @K, @Etapa, @Dni, @Nombres, @Apellidos, @Nac, @Sexo, @Direccion, @Telefono, @Dom, @Convenio, @Medio, @BoxNum, @T0, @TGen, @TEnt, @Contenido;
END
CLOSE cur;
DEALLOCATE cur;

PRINT N'Pacientes con atención registrados: ' + CAST(@Creados AS NVARCHAR(10));
IF @Omitidos > 0 PRINT N'Omitidos porque ya existían (o falta algún examen): ' + CAST(@Omitidos AS NVARCHAR(10));
GO
DROP TABLE IF EXISTS #Caso, #CasoEx, #CasoRes, #CasoSec;
GO

