# SistemaDeVentas
📎Backend 
    📌.NET Core 6.0
    📌Entity Framework 7.0.0
    
 Requisitos para correr correctamente el proyecto API web con ASP.NET Core 6.0 es tener instalados los siguientes paquetes NuGet
 ![image](https://user-images.githubusercontent.com/87341430/205806620-8b00665b-0e17-4e0b-9083-ade947385ef1.png)


1- Dentro de la solución "SistemaDeVentas" se definen cuatro Bibliotecas de clases.

![image](https://user-images.githubusercontent.com/87341430/205804785-f1bdfbf4-107a-48e3-83aa-33d6f22f3bc2.png)


  #SistemaDeVentas.Application
  Dentro de esta capa nos encontraremos con los respectivos servicios y sus contratos (Interface).
  
  ![image](https://user-images.githubusercontent.com/87341430/205805750-b000e5db-fe03-4b5f-8e70-1985eb7425ff.png)
  
  
  #SistemaDeVentas.DomainEntities
  Dentro de esta capa nos encontraremos con las entidades y sus respectivas relaciones para luego ser migradas a la DB.
  
  ![image](https://user-images.githubusercontent.com/87341430/205806954-9b42bc22-e480-4cf3-add4-cffaa5754017.png)

  
  #SistemaDeVentas.Infraestructure
  Dentro de esta capa nos encontramos con el contexto, migraciones, repositorios y sus contratos (Interface).
  
  ![image](https://user-images.githubusercontent.com/87341430/205807651-b1fd7502-5495-4402-ba39-c078e09fd03f.png)


  #SistemaDeVentas.WebApi
  Dentro de esta capa nos encontramos con los Controllers, appsettings.json (Configuración de la "ConnectionStrings") y la clase Program.cs.
  
  ![image](https://user-images.githubusercontent.com/87341430/205808089-9b37b41f-9dcf-4329-b9a9-cd25a0d17372.png)

  
