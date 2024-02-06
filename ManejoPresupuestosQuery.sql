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

