# Boeken-website met Razor Pages
## Informatie
Dit is een project wat gemaakt is met ASP.NET core, het is een website waar de gebruiker een lijst van kan zien, op
deze lijst kunnen uiteindelijk volle CRUD operaties worden gedaan.

## Stappenplan
- Creeër een model Book, voeg AddDbContext service toe aan services, run "add-migration" en "update-database" commands
in NuGet console om een Book table te creëeren in de database mbv EF.
- Doordat AddDbContext wordt toegevoegd aan de services betekent het dat deze klasse over het hele programma beschikbaar
is voor gebruik (dit heet ook wel dependency injection), wanneer deze klasse nodig is hoeft deze dus niet elke keer opnieuw
geïnstantieerd te worden. (zie de constructor van de index page in de /BookList folder).
-

## NuGet Packages
- EntityFrameworkCore
- EntityFrameworkCore.SqlServer
- EntityFrameworkCore.Tools