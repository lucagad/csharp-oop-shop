#region
//Creare una classe Prodotto che gestisce i prodotti dello shop.

//Un prodotto è caratterizzato da:
//- codice(numero intero)
//- nome
//- descrizione
//- prezzo
//- iva

//Usate opportunamente i livelli di accesso (public, private):
//- i costruttori,
//- i metodi getter e setter

//eventuali altri metodi di “utilità” per fare in modo che:

//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random

//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.

//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
#endregion
//ESERCIZIO 22/09

//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop,
//vi chiedo di essere più specifichi e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.

//In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
//  - Acqua(massimo 1.5L)
//  - Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
//  - Elettrodomestico
//  - Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)

//Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere i loro attributi e metodi che eventualmente gli riguardano,
//ereditando i metodi e gli attributi generici dalla classe Prodotto creata nell’esercizio precedente.

//Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:
//  - attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua (OK)
//  - attributo ph: che indica il livello di acidità dell’acqua (sola lettura) (OK)
//  - attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura) (OK)

//  - metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti. (OK)
//  - metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo. (OK)
//  - metodo svuota() che rimuove tutta l’acqua dalla bottiglia. (OK)
//  - metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto. (OK)
//  - metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni. (OK)

//Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato dei vostri oggetti (ad esempio non posso bere più dei litri contenuti nella bottiglia, o non posso riempire più di tot una bottiglia!).

//E così via per tutti gli altri elementi qui sopra riportati, provate a pensare attributi e metodi che potrebbero servire ai vostri prodotti specializzati Acqua, sacchetto di frutta a pezzi, elettrodomestici e cibo in scatola.
//Al solito usate opportunamente i livelli di accesso (public, private, protected o altro se necessario), i costruttori, i metodi getter e setter (o le properties) ed eventuali altri metodi di “utilità“.
//Pensate anche se avete bisogno di eventuali metodi statici o attributi statici (ad esempio potrebbero essere i limiti dei vostri oggetti ), e ad eventuali override e overload di metodi come visto per Acqua.
//Una volta finite più o meno le vostre classi, nel Program.cs, provate a testare un pò i vostri prodotti specializzati, osservando come i metodi della classe generica prodotto e quelli più specifici vengono richiamati e siano disponibili.


Product prodotto = new Product();

// SET INFORMAZIONI

prodotto.Name = "Prodotto test";
prodotto.Description = "Descrizione Test";
prodotto.Price = 100;
prodotto.VAT = 22;

// SET INFORMAZIONI

// STAMPA A VIDEO LE INFORMAZIONI

prodotto.printInfo();

Water acqua = new Water(0 , "Dolomiti", 1.5);

acqua.Name = "Prodotto acqua";
acqua.Description = "Descrizione acqua";
acqua.Price = 1;
acqua.VAT = 10;

acqua.printInfo();

Console.WriteLine("I litri d'acqua disponibili convertiti in Galloni è: " + acqua.convertToGallons());

acqua.drinkWater(0.6);
//acqua.drinkWater(1);

Console.WriteLine("I litri d'acqua disponibili convertiti in Galloni è: " + acqua.convertToGallons());

acqua.printInfo();
