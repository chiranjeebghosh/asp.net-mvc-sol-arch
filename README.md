# asp.net-mvc-sol-arch
Asp.Net MVC Solution Architecture project presents a flexible layered architecture approach inspired from some of the best approaches available.
It uses the following:-
1. ASP.Net MVC 5.2.3.0
2. .Net Framework 4.5.2
3. Unity.MVC (Nuget package)
4. Entity Framework 6.0 (Nuget package)
5. Repository Pattern with Async operation
6. SQL Server Express 
7. Entity Framework Power Tools Beta 4 (Visual Studios Extension)

The entire solution is divided into following project structure:-
CG.StarSystem
  -A.Infrastructure
    --CG.StarSystem.Data
  -B.Domain
    --CG.StarSystem.ApplicationServices
    --CG.StarSystem.Entity
    --CG.StarSystem.Repository
  -C.Presentation
    --CG.StarSystem.Web
    
 The project 'CG.StarSystem.Web' is ASP.Net MVC which uses the Model present in 'CG.StarSystem.Entity'. The Controller uses the 'CG.StarSystem.ApplicationServices' for business operations using async operations. The async CRUD operations are being done using Entity Framework from 'CG.StarSystem.Repository'. 
 
 Highligts
 ----------
 1.The connection string is mentioned in the Web.Cofig file of 'CG.StarSystem.Web'
 2.The 'CG.StarSystem.Web' doesn't have any direct connection with the Repository or the database. It only depends on Application Services    and Entity.
 3.All operations are Async from Controller --> ApplicationServices --> Repository --> Entity Framework
 4.Dependency Injection in ASP.NET MVC using Unity IoC Container. The Repository layer has been deliberately left out for flexibity of        replacing.
 5.Entity Models are resued across layers.
 
 Solution Structure
 ------------------
 
 UI(View) --> Controller --> ApplicationServices --> Repository --> Entity Framework --> Database(SQL Server)
 |------------------------------Model(Enity)-----------------------------------------|
                              Reused Across Layer
 ===================================================================================
 

 
