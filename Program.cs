using System.Xml.Linq;

Evento e = new Evento();
Console.WriteLine("Inserisci il nome dell'evento: ");
e.Titolo = Console.ReadLine();
/*
Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy): ");
e.Date = DateOnly.Parse(Console.ReadLine()); 
*/
Console.WriteLine("Inserisci il numero di posti totali: ");
e.CapienzaMassima = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Vuoi disdire dei posti: si/no");
string scelta = Console.ReadLine();

do
{
    if (scelta == "si")
    {
        Console.WriteLine("Inserisci il numero di posti da disdire: ");
        e.PostiPrenotati = e.DisdiciPosti(e, Convert.ToInt32(Console.ReadLine()));
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