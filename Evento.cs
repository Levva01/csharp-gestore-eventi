// See https://aka.ms/new-console-template for more information
public class Evento
{
    public string Titolo {
        get;
        set;
    }

    public DateOnly Date { 
        get => Date;
        set
        {
            if (value >= DateOnly.FromDateTime(DateTime.Now))
                Date = value;
            else Console.WriteLine("Data passata");

        }
    }

    public int CapienzaMassima {
        get;
        set;
    }

    public int PostiPrenotati { 
        get;
        set;
    }

    public Evento(string titolo, DateOnly date, int capienzaMassima)
    {
        Titolo = titolo;
        Date = date;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = 0;
    }

    public Evento()
    {
    }

    public int PrenotaPosti(Evento e, int postiDaAggiungere)
    {
        if(e.PostiPrenotati + postiDaAggiungere >= e.CapienzaMassima)
        {
            Console.WriteLine("Capienza Massima superata");
            return e.PostiPrenotati;
        } else
        {
            e.PostiPrenotati += postiDaAggiungere;
            return e.PostiPrenotati;
        }
    }

    public int DisdiciPosti(Evento e, int postiDaRimuovere)
    {
        if(postiDaRimuovere >= e.PostiPrenotati)
        {
            Console.WriteLine("Numeri di posti prenotati inferiori a quelli da rimuovere.");
            return e.PostiPrenotati;
        }


        if (e.PostiPrenotati - postiDaRimuovere >= e.CapienzaMassima)
        {
            Console.WriteLine("Capienza Massima superata");
            return e.PostiPrenotati;
        }
        else
        {
            e.PostiPrenotati -= postiDaRimuovere;
            return e.PostiPrenotati;
        }
    }

    public override string ToString()
    {
        string dateFormat = "dd/MM/yyyy";
        return dateFormat;
    }
}