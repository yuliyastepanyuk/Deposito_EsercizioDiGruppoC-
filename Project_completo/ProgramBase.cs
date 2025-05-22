using System;

public class Corso
{
    public string NomeCorso;
    protected int DurataOre;
    public string Docente;
    protected List<string> Studenti = new List<string>();

    public Corso(string nomeCorso, int durataOre, string docente, List<string> studenti) // costruttore
    {
        NomeCorso = nomeCorso;
        DurataOre = durataOre;
        Docente = docente;
        Studenti = studenti;
    }

    public void AggiungiStudente(string nomeStudente)
    {
        Studenti.Add(nomeStudente);
    }

    public virtual string ToString()
    {
        return $"Il nome del corso è {NomeCorso}, la durata è {DurataOre} ore, il docente è {Docente}.";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Questo è un metodo speciale della classe Corso.");
    }
}