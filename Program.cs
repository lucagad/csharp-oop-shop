// See https://aka.ms/new-console-template for more information


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


Product test = new Product();

// SET INFORMAZIONI

test.setName("Prodotto test");
test.setDescription("Dexrizione Test");
test.setPrice(100);
test.setVAT(22);

// SET INFORMAZIONI

// STAMPA A VIDEO LE INFORMAZIONI

Console.WriteLine("---------");
Console.WriteLine("Codice: " + test.getCode());
Console.WriteLine("Nome: " + test.getName());
Console.WriteLine("Nome Epspanso: " + test.getNameExpanded());
Console.WriteLine("Descrizione: " + test.getDescription());
Console.WriteLine("---------");

Console.WriteLine("Prezzo NO IVA: "+ test.getPriceNoVAT() + "Euro");
Console.WriteLine("IVA: " + test.getVAT() + " %");
Console.WriteLine("Prezzo CON IVA: " + test.getPriceVAT() + "Euro");

Console.WriteLine("---------");

Console.WriteLine("PADDED CODE: " + test.getPricePadded());

