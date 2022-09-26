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
    $"Posti Prenotati: {e.PostiPrenotati}"
);

public class ProgrammaEventi
{
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public string Titolo { get; set; }
    public List<Evento> Eventi { get; set; }
    
    public void aggiungiEvento(Evento e)
    {
        this.Eventi.Add(e);
    }

    public List<Evento> getEventsFromDate(List<Evento> e)
    {
        string dateString = Console.ReadLine();
        DateOnly date = DateOnly.Parse(dateString);
        
        List<Evento> eventsDate = new List<Evento>();
        foreach (Evento evento in e)
        {
            if(evento.Date == date)
            {
                eventsDate.Add(evento);
            }
        }
        return eventsDate;
    }

    public static void StampaEventi(List<Evento> e)
    {
        foreach(Evento i in e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public void CancellaLista()
    {
        Eventi.Clear();
    }

    public int ContaEventi()
    {
        return Eventi.Count;
    }
}