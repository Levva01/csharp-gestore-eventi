using System.Xml.Linq;

Evento e = new Evento("Concerto", new DateOnly(2022, 10, 10), 15000);

Console.WriteLine("Vuoi disdire dei posti: si/no");
string scelta = "no";
scelta = Console.ReadLine();

do
{
    if (scelta == "si")
    {
        Console.WriteLine("Inserisci il numero di posti da disdire: ");
        e.DisdiciPosti(Convert.ToInt32(Console.ReadLine()));
    }
    else if (scelta == "no")
    {
        Console.WriteLine("Hai scelto di non modificare i posti prenotati");
    }
    else
    {
        Console.WriteLine("Scelta in formato non corretto!");
    }
} while (scelta != "no");

Console.Write($"Evento: {e.Titolo}:" +
    $"Data: {e.Date.ToString()}" +
    $"Capienza: {e.Capienza}" +
    $"Posti Prenotati: {e.PostiPrenotati}");