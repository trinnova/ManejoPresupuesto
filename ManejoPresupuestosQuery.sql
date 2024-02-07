select * from Transacciones;

INSERT INTO Transacciones (FechaTransaccion, Monto, TipoTransaccionId, UsuarioId)
VALUES('2021-02-05', 100, 4 , 'carlos');

SELECT * FROM Transacciones ORDER BY Monto;

SELECT * FROM Transacciones ORDER BY Monto DESC;

-- Comentario un bloque de código seleccionado: Control + k + c

SELECT * FROM Transacciones WHERE TipoTransaccionId <> 2;

SELECT * FROM Transacciones WHERE Nota IS NOT NULL;

SELECT * FROM Transacciones WHERE Nota IS NULL;

UPDATE Transacciones SET Monto = 500 WHERE Id = 3;

DELETE Transacciones WHERE Id = 5;

SELECT * FROM Transacciones WHERE UsuarioId IN ('omar', 'heri');

SELECT * FROM Transacciones WHERE Monto NOT IN (500, 300);

SELECT * FROM Transacciones WHERE UsuarioId LIKE 'o%';
SELECT * FROM Transacciones WHERE UsuarioId LIKE '%o';
SELECT * FROM Transacciones WHERE UsuarioId LIKE '%o%';

SELECT * FROM Transacciones WHERE UsuarioId NOT LIKE '%o%';

SELECT * FROM Transacciones WHERE UsuarioId LIKE '%o%' AND NOTA IS NOT NULL;

SELECT * FROM Transacciones WHERE UsuarioId LIKE '%o%' OR NOTA IS NULL;

SELECT * FROM Transacciones WHERE FechaTransaccion >= '2021-02-06';

-- Filtrando por año
SELECT * FROM Transacciones WHERE YEAR(FechaTransaccion) = 2021;

-- Between
SELECT * FROM Transacciones WHERE FechaTransaccion BETWEEN '2020-01-01' AND '2022-01-01';

SELECT * FROM Transacciones WHERE FechaTransaccion NOT BETWEEN '2020-01-01' AND '2022-01-01';

-- TOP, Primero N elementos de un Query
SELECT TOP 3 * FROM Transacciones;
SELECT TOP 50 PERCENT * FROM Transacciones;

-- Para poder usar GROUP BY, el campo debe estar en la consulta, de lo contrario arrojará error..., se puede agrupar por más de 1 columna
SELECT SUM(Monto) AS SUMA, UsuarioId FROM Transacciones GROUP BY UsuarioId;

-- COUNT: Conteo
SELECT COUNT(*) AS REGISTROS FROM Transacciones;

-- AVG: Promedio
SELECT COUNT(*) AS REGISTROS, AVG(Monto) AS PROMEDIO FROM Transacciones;

select * from Transacciones;
SELECT * FROM TiposOperaciones;

-- INNER JOIN
SELECT t.Id, t.UsuarioId, t.FechaTransaccion, t.Monto, t.Nota, tiop.Descripcion, t.TipoOperacionId FROM Transacciones t
INNER JOIN TiposOperaciones tiop ON tiop.Id = t.TipoOperacionId;

-- Refrescar si un campo o algo de SQL no se actualizar: Control + Shift + R
EXEC Transacciones_SelectConTipoOperacion;

-- Con paràmetro
EXEC Transacciones_SelectConTipoOperacion_Parametro 2;

TRUNCATE TABLE TiposOperaciones;

