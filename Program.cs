// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Evento
{
    public string Titolo {
        get => Titolo;
        set
        {
            if (!string.IsNullOrEmpty(value))
                Titolo = value;
            else Console.WriteLine("String vuota");
        }
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
        get => CapienzaMassima;
        private set
        {
            if (value >= 0)
                CapienzaMassima = value;
            else Console.WriteLine("La capienza massima non può essere negativa");
        }
    }

    public int PostiPrenotati { 
        get => PostiPrenotati;
        private set 
        {
            PostiPrenotati = value;    
        }
    }

    public Evento(string titolo, DateOnly date, int capienzaMassima)
    {
        Titolo = titolo;
        Date = date;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = 0;
    }
}