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
- Creeër een Index pagina voor alle boeken in de database, doordat we voorheen de database injected hebben in ons
programma is de db altijd makkelijk te verkrijgen door een private readonly ApplicationDbContext _db te maken.
Wanneer je deze _db called kan je makkelijk ermee verder werken in het programma, in dit geval vrijwel altijd bij de
CRUD pagina's voor het Book model._
Met bootstrap kan je makkelijk een form creeëren en met Grid is deze makkelijk in te delen. Met ASP helper tags
is binnen HTML markup makkelijk te verwijzen naar eigenschappen van het Book model (asp-for="Book.Name").
- Creeër een Create pagina, maak de back-end CS pagina met behulp van async calls, dit is nodig omdat
HTML calls asynchroon gaan. Wanneer een methode async wordt moet het ook een async Task zijn. Met de async
Task OnPost creeër je een nieuw Book. Met behulp van jquery validatie kan je makkelijk checken of benodigde velden
ingevuld zijn door boven de elementen die gechecked moeten worden deze div te creeëren: 
"div class="text-danger" asp-validation-summary="ModelOnly"", daarna onder elk element wat verified moet worden
is deze span nodig : "span asp-validation-for="Book.Name" class="text-danger"></span"
- Creeër een Edit pagina, dit lijkt heel erg op het maken van de Create pagina, de Edit pagina maakt ook gebruik van
de async Post Task. het enige verschil is dat je mbv deze methode "_db.Attach(Book).State = EntityState.Modified;"
de staat van het object uit de database met gelijke ID aan het object die op de pagina weergeven wordt gelijk maakt aan
elkaar. Zorg ook dat je bovenaan van de markup van de edit page deze hidden helper tag staat:         
input type="hidden" asp-for="Book.Id" /. Dit is nodig zodat de Id van het Book model ook gepassed wordt, anders zou
het Edit Book object niet gelijk zijn aan het Database Book object.
- Creeër een Delete pagina, deze zit hetzelfde in elkaar als de Edit page. De Delete page hoeft niet per sé gemaakt te worden,
het kan ook als alert weergeven worden en dan via asp-route-id kan je makkelijk de Book.Id meegeven en dan creëer je net als
op de Delete pagina die gecreëerd is een OnPostDelete methode. Met deze methode zoek je naar het Book.Id en dan verwijder
je het object uit de database en return je naar de Index.


## NuGet Packages
- EntityFrameworkCore
- EntityFrameworkCore.SqlServer
- EntityFrameworkCore.Tools


