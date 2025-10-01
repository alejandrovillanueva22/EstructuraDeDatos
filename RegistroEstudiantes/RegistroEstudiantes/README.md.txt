# Registro de Estudiantes

## Descripción
Este mini-sistema en C# permite registrar estudiantes, calcular promedios de calificaciones y determinar su estado (Aprobado/Reprobado).  
El programa usa distintos tipos de datos abstractos (value, reference, especiales) y muestra su aplicación en un caso real.

## Diagrama de clase 
Estudiante (class)
├── Nombre : string
├── Edad : int
├── Direccion : Direccion (struct)
├── Estado : EstadoEstudiante (enum)
├── Promedio : double


## Tabla de Campos y Tipos
| Campo           | Tipo           | Justificación                                   |
|-----------------|----------------|---------------                                  |
| Nombre          | `string`       | Cadena de texto porque pueden ser disintos      |
| Edad            | `int`          | Número entero                                   |
| Direccion       | `struct`       | Dato pequeño y atómico (Calle, Número)          |
| Estado          | `enum`         | Para valores predefinidos (Aprobado/Reprobado)  |
| Promedio        | `double`       | Para cálculos con decimales                     |






