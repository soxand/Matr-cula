Create table Alumno(
IdAlumno int check( IdAlumno > 9999 and IdAlumno < 999999 ) unique not null,
DNombre varchar(65) not null,
DApellido varchar(65) not null,
NDni int check(NDni > 9999999 and NDni < 99999999) primary key,
CContrase�a int check( CContrase�a > 9999 and CContrase�a < 999999 )
)

Select * from Alumno

Insert into Alumno values(12345, 'Axel', 'Yataco',72692474,12345)

Create table Administrador(
IdAministrador int check( IdAministrador > 9999 and IdAministrador < 999999 ) unique not null,
DNombreAdministrador varchar(65) not null,
DApellidoAdministrador varchar(65) not null,
NDniAdministrador int check(NDniAdministrador > 9999999 and NDniAdministrador < 99999999) primary key,
CContrase�aAdministrador int check( CContrase�aAdministrador > 9999 and CContrase�aAdministrador < 999999 )
)

Select * from Administrador
Insert into Administrador values(23456, 'Eduardo', 'Estela',72696574,23456)
Insert into Administrador values(23456, 'Eduardo', 'Estela',72696574,23456)
