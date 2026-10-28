# Övning 8 – Interface

Ett litet C#-konsolprojekt som visar hur interface kan användas för att beskriva gemensamma beteenden och låta olika klasser implementera dem.

## Innehåll

- `IStart` definierar metoden `Start()`, som implementeras av `Program1` och `Program2`.
- `IStop` definierar `Stop()`, som `Program1` implementerar.
- `Program` anropar objekten direkt och via en lista av typen `IStart`.
- Mappen `Extra` visar explicita interface-implementationer. Klassen `Extra` implementerar två interface med varsin `Run()`-metod: en som returnerar `void` och en som returnerar ett heltal.

## Köra projektet

Du behöver .NET 10 SDK. Kör följande från repositoryts rot:

```powershell
dotnet run --project .\Övning8_Interface\Övning8_Interface.csproj
```

Programmet skriver exempel på start- och stoppmetoder samt de två `Run()`-implementationerna till konsolen.
