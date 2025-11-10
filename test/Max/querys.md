SELECT 
    p.nombres,
    p.apellidos,
    p.documento,
    a.fecha_registro
FROM asistencia a
INNER JOIN persona p ON a.id_persona = p.id_persona
WHERE a.estado = 'Asistió';
