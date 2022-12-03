// See https://aka.ms/new-console-template for more information


using Csharp_OOP_Agenzia_Immobiliare;

Immobile immobile1 = new Immobile("00012ABC", "via fasulla123", "0014", "colbacco", 20);
Abitazione immobile2 = new Abitazione("00015ABC", "via fasulla123", "0014", "colbacco", 40, 5, 2);
Villa immobile3 = new Villa("00018ABC", "via fasulla123", "0014", "colbacco", 60, 8, 2, 30);
Box immobile4 = new Box("00020ABC", 2, "via fasulla456", "0020", "Roma", 100);

List<Immobile> listaImmobiliare = new List<Immobile>() { immobile1, immobile2, immobile3, immobile4 };

foreach (Immobile immobile in listaImmobiliare)
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

