CREATE TABLE Usuarios (
UsuarioID INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Apellido NVARCHAR(100),
Email NVARCHAR(100),
Contraseña NVARCHAR(100),
AdicionadoPor NVARCHAR(100),
FechaAdicionado DATETIME,
ModificadoPor NVARCHAR(100),
FechaModificacion DATETIME 
);

CREATE TABLE Estudiantes (
EstudianteID INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Apellido NVARCHAR(100),
Carrera NVARCHAR(100),
AñoIngreso INTEGER,
AdicionadoPor NVARCHAR(100),
FechaAdicionado DATETIME,
ModificadoPor NVARCHAR(100),
FechaModificacion DATETIME 
);

CREATE TABLE Curso (
CursoID INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(100),
Creditos INTEGER,
Horas INTEGER,
AdicionadoPor NVARCHAR(100),
FechaAdicionado DATETIME,
ModificadoPor NVARCHAR(100),
FechaModificacion DATETIME 
);

CREATE TABLE Matricula (
MatriculaID INT PRIMARY KEY IDENTITY,
EstudianteID NVARCHAR(100),
CursoID NVARCHAR(100),
FechaMatricula DATETIME,
AdicionadoPor NVARCHAR(100),
FechaAdicionado DATETIME,
ModificadoPor NVARCHAR(100),
FechaModificacion DATETIME 
);