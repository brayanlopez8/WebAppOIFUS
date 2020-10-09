# WebAppOIFUS
Proyecto Sena ADSI

Johanna López 
Miguel López
Angelica López

SENA Centro La Granja
Codigo 1881613

Proposito:
Sistema de información educativo para la administración y gestión de vendedores informales, para el analisis de la condición socioeconomica, permitiendo la identificacion por grupos poblacionales y sus caracteristicas, a su vez permite a los vendedores verificar si se encuentran registrados en la plataforma.

* Cuenta con un modulo de administración y gestion de noticias relevantes para los vendedores ambulantes.

Comandos para crear la base de datos: (Mac)
dotnet ef migrations add initial ---  Primera vez
dotnet ef database update
Windows
Add-Migration InitialMigration


Levantar docker image sql server

Guia 
https://database.guide/install-sql-server-2019-on-a-mac/

sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Exadmin7890" -p 1400:1433 --name Bart -d mcr.microsoft.com/mssql/server:2019-CTP3.2-ubuntu

#Cadena de conexion para MAC
Server=tcp:localhost,1433;Database=testdb;User Id=sa;Password=Exadmin7890;

Estado de avance de actividades:
https://docs.google.com/spreadsheets/d/1Qb9kgJCreiVbns8xR4A_Q0eaqCNiY_uk/edit#gid=253374465


Datatables componente:
https://datatables.net/manual/installation
https://datatables.net/download/
ejemplos:
https://datatables.net/examples/index

Ejemplo de botones html para exportar
https://datatables.net/extensions/buttons/examples/html5/simple.html