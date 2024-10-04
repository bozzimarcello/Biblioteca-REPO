using BibliotecaConsole;

Console.WriteLine("Gestione Biblioteca");

Console.WriteLine("Inserimento libri");

Rivista[] biblioteca = new Rivista[500];
int indice = 0;

bool continua = true;
while (continua)
{
    // sintassi di creazione di un oggetto
    // da una classe
    Rivista oggettoRivista = new Rivista();

    Console.Write("Inserisci il titolo:");
    oggettoRivista.Titolo = Console.ReadLine();

    Console.Write("Inserisci il autore:");
    oggettoRivista.Autore = Console.ReadLine();
    
    Console.Write("Inserisci il numero di pagine:");
    oggettoRivista.Pagine = int.Parse(Console.ReadLine());
    
    Console.Write("Inserisci il prezzo:");
    oggettoRivista.Prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Il prezzo in dollari sarà: " 
                        + oggettoRivista.PrezzoInDollari());

    biblioteca[indice] = oggettoRivista;
    indice++;

    Console.WriteLine("Vuoi inserire un altro Rivista (S/N)?");
    string risposta = Console.ReadLine();
    if (risposta == "N") continua = false;
}

// creo un libro con parametri
Libro ilMilione = new Libro("Il Milione", "Marco Polo", 100, 15.50m);


