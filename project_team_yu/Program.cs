using System;
using System.ComponentModel;
public class CorsoMusica : Corso
{
    protected string Strumento;

    public CorsoMusica(string nomeCorso, int durataOre, string docente, List<string> studenti, string strumento) : base(nomeCorso, durataOre, docente, studenti)
    {
        Strumento = strumento;
    }

    public override string ToString()
    {
        return base.ToString() + $" Il corso è di {Strumento}.";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}.");
    }

    public static CorsoMusica AggiungiCorsoMusica(string nomeCorso, int durataOre, string docente, List<string> studenti, string strumento)
    {
        Console.WriteLine("Aggiungi un nuovo corso di musica.");
        string NomeCorso = Console.ReadLine();
        Console.WriteLine("Aggiungi la durata del corso in ore.");
        int DurataOre = int.Parse(Console.ReadLine());
        Console.WriteLine("Aggiungi il nome del docente.");
        string Docente = Console.ReadLine();
        Console.WriteLine("Aggiungi il nome dello strumento.");
        string Strumento = Console.ReadLine();
        CorsoMusica corsoMusica = new CorsoMusica(NomeCorso, DurataOre, Docente, studenti, Strumento);
        return corsoMusica;
    }

} //Questo non è corretto: List<string> studenti è la dichiarazione del tipo, non il nome della variabile. Quando chiami il costruttore base, devi passare la variabile che contiene la lista, cioè solo studenti.

public class CorsoPittura : Corso
{
    protected string Tecnica;

    public CorsoPittura(string nomeCorso, int durataOre, string docente, List<string> studenti, string tecnica) : base(nomeCorso, durataOre, docente, studenti)
    {
        Tecnica = tecnica;
    }

    public override string ToString()
    {
        return base.ToString() + $" Il corso è di {Tecnica}.";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
    }

    public static CorsoPittura AggiungiCorsoPittura(string nomeCorso, int durataOre, string docente, List<string> studenti, string tecnica)
    {
        Console.WriteLine("Aggiungi un nuovo corso di pittura.");
        string NomeCorso = Console.ReadLine();
        Console.WriteLine("Aggiungi la durata del corso in ore.");
        int DurataOre = int.Parse(Console.ReadLine());
        Console.WriteLine("Aggiungi il nome del docente.");
        string Docente = Console.ReadLine();
        Console.WriteLine("Aggiungi la tecnica di pittura.");
        string Tecnica = Console.ReadLine();
        CorsoPittura corsoPittura = new CorsoPittura(NomeCorso, DurataOre, Docente, studenti, Tecnica);
        return corsoPittura;
    }
}