// See https://aka.ms/new-console-template for more information


using Csharp_OOP_Agenzia_Immobiliare;

Immobile immobile1 = new Immobile("via fasulla123", "0014", "colbacco", 20);
Abitazione immobile2 = new Abitazione("via fasulla123", "0014", "colbacco", 40, 5, 2);
Villa immobile3 = new Villa("via fasulla123", "0014", "colbacco", 60, 8, 2, 30);
Box immobile4 = new Box(2, "via fasulla456", "0020", "Roma", 100);
Villa immobile5 = new Villa("piazza Outer Wilds", "1900", "Roma", 300, 30, 5, 2000);


foreach (Immobile immobile in immobile1.GetListaImmobili())
{
    Console.WriteLine(immobile.ToString());
}






void RicercaImmobileLista(List<Immobile> immobileLista, string codiceImmobile)
{
    foreach (Immobile immobile in immobileLista)
    {
        if (immobile.VerificaImmobile(codiceImmobile))
        {
            Console.WriteLine("Immobile Presente, stampa in corso...");
            Console.WriteLine(immobile.ToString());
            return;
        }
    }
    Console.WriteLine("ERRORE: L'immobile con codice " + codiceImmobile + " non è presente nella lista");
}

