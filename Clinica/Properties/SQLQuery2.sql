--SELECT * FROM pacientes
--SELECT * FROM obrasSociales

SELECT p.id, dni, nombre, apellido, nombreOSocial FROM pacientes p inner join obrasSociales o on p.obraSocialId = o.id
