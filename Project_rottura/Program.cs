using System;
public class CorsoDanza : Corso
{
    protected string Stile;
    public CorsoDanza(string nomeCorso, int durataOre, string docente, List<string> studenti, string stile) : base(nomeCorso, durataOre, docente, studenti)
    {
        Stile = stile;
    }

    public override string ToString()
    {
        return $"Il nome del corso di danza è {NomeCorso}, lo stile è {Stile}, la durata è {DurataOre} ore, il docente è {Docente}.";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }

    public static CorsoDanza AggiungiCorsoDanza()
    {
        Console.WriteLine("Aggiungi un nuovo corso di musica.");
        string NomeCorso = Console.ReadLine();
        Console.WriteLine("Aggiungi la durata del corso in ore.");
        int DurataOre = int.Parse(Console.ReadLine());
        Console.WriteLine("Aggiungi il nome del docente.");
        string Docente = Console.ReadLine();
        Console.WriteLine("Aggiungi il nome dello strumento.");
        string Stile = Console.ReadLine();
        List<string> Studenti = new List<string>();
        Console.WriteLine("Quanti studenti vuoi aggiungere?");
        int numeroStudenti = int.Parse(Console.ReadLine());
        for (int i = 0; i < numeroStudenti; i++)
        {
            Console.WriteLine($"Inserisci il nome dello studente {i + 1}:");
            Studenti.Add(Console.ReadLine());
        }
        CorsoDanza corsoDanza = new CorsoDanza(NomeCorso, DurataOre, Docente, Studenti, Stile);
        return corsoDanza;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        List<Corso> corsi = new List<Corso>();

        while (!exit)
        {
            Console.WriteLine("\nBenvenuto, scegli cosa fare:\n[1] Aggiungi un corso di Musica\n[2] Aggiungi un corso di Pittura\n[3] Aggiungi un corso di Danza\n[4] Aggiungi uno studente a un corso");
            Console.WriteLine("[5] Visualizza tutti i corsi\n[6] Cerca corsi per nome docente\n[7] Esegui metodo speciale di un corso\n[0] Esci");
            int menuAction = Input.Int(0, 7);

            switch (menuAction)
            {
                case 0:
                    exit = true;
                    break;

                case 1:
                    corsi.Add(CorsoMusica.AggiungiCorsoMusica());
                    Console.WriteLine("corso aggiunto con successo");
                    break;

                case 2:
                    corsi.Add(CorsoPittura.AggiungiCorsoPittura());
                    Console.WriteLine("corso aggiunto con successo");
                    break;

                case 3:
                    corsi.Add(CorsoDanza.AggiungiCorsoDanza());
                    Console.WriteLine("corso aggiunto con successo");
                    break;

                case 4:
                    Console.WriteLine("");

                case 5:
                    Console.WriteLine("I corsi sono:");
                    foreach (Corso corso in corsi)
                    {
                        Console.WriteLine(corso.NomeCorso);
                    }
                    break;
            }
        }
    }
}