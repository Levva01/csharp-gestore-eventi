public class Evento
{
    public string Titolo { get; set; }
    private DateOnly date;
    public DateOnly Date { 
        get => date;
        set
        {
            if (value <= DateOnly.FromDateTime(DateTime.Now))
                throw new ArgumentException("La data non può essere passata");
            
            date = value;
        }
    }

    public int Capienza { get; private set; }
    public int PostiPrenotati { get; private set; }

    public Evento() { }

    public Evento(string titolo, DateOnly date, int capienza)
    {
        if(titolo == "")
        {
            throw new ArgumentException("Il titolo non può essere vuoto");
        }
        Titolo = titolo;
        if(date < DateOnly.FromDateTime(DateTime.Now))
        {
            throw new ArgumentException("La data deve essere futura");
        }
        Date = date;
        if(capienza < 1)
        {
            throw new ArgumentException("La capienza disponibile deve essere maggiore di 0");
        }
        Capienza = capienza;
        PostiPrenotati = 0;
    }


    public void PrenotaPosti(int postiDaAggiungere)
    {
        if(postiDaAggiungere < 1)
        {
            throw new ArgumentException("I posti da aggiungere devono essere più di 0.");
        }

        if(postiDaAggiungere > Capienza - PostiPrenotati)
        {
            throw new ArgumentException("Posti non disponibili");
        }

        PostiPrenotati += postiDaAggiungere;
        Capienza -= postiDaAggiungere;
    }

    public void DisdiciPosti(int postiDaRimuovere)
    {
        if(postiDaRimuovere < 1)
        {
            throw new ArgumentException("I posti da rimuovere devono essere più di 0");
        }

        if (postiDaRimuovere > PostiPrenotati)
        {
            throw new ArgumentException("Le sedie da rimuovere superano di numero le sedie prenotate");
        }
        
        if(DateOnly.FromDateTime(DateTime.Now) > Date)
        {
            throw new ArgumentException("L'evento è gia passato.");
        }

        PostiPrenotati -= postiDaRimuovere;
        Capienza += postiDaRimuovere;
    }

    public override string ToString()
    {
        return $"{Date.ToString("dd/MM/yyyy")} - {Titolo}";
    }
}