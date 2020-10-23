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
https://www.londonacademyofit.co.uk/blog/installing-sql-server-on-mac-using-docker

1. docker pull microsoft/mssql-server-linux
En Mac
2. docker run -d --name MySQLServer -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Exadmin7890' -p 1433:1433 microsoft/mssql-server-linux
En windows
docker run -d --name MySQLServer -e 'SA_PASSWORD=Exadmin7890' -p 1433:1433 microsoft/mssql-server-linux

Opcional
Remover instancia sql server docker:
sudo docker rm MySQLServer

#Cadena de conexion para MAC
"MyDBContext": "Server=tcp:localhost,1433;Database=testdb;User Id=sa;Password=Exadmin7890;"

Estado de avance de actividades:
https://docs.google.com/spreadsheets/d/1Qb9kgJCreiVbns8xR4A_Q0eaqCNiY_uk/edit#gid=253374465

Cadena de Conexion Windows
"MyDBContext": "Server=.\\SQLEXPRESS;Initial Catalog=testdb;Persist Security Info=False;User ID=sa;Password=$Exadmin;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;"

Datatables componente:
https://datatables.net/manual/installation
https://datatables.net/download/
ejemplos:
https://datatables.net/examples/index

Ejemplo de botones html para exportar
https://datatables.net/extensions/buttons/examples/html5/simple.html

Usuario adminitrador defaul
user: admin
pass: #MiPass123456