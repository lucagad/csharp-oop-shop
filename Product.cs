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



// SET INFORMAZIONI


// SET INFORMAZIONI

// STAMPA A VIDEO LE INFORMAZIONI




// STAMPA A VIDEO LE INFORMAZIONI

public class Product
{
    private int code;
    private string name;
    private string description;
    private double price;
    private int VAT;

    public Product()
    {
        Random rnd = new Random();
        this.code = rnd.Next(0,99999999);
    }

    //---- GETTER E SETTER ----
    public void setPrice(double price)
    {
        this.price = price;
    }
    public void setVAT(int VAT)
    {
        this.VAT = VAT;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public void setDescription(string description)
    {
        this.description = description;
    }
    public int getCode()
    {
        return this.code;
    }
    public string getName()
    {
        return this.name;
    }
    public string getNameExpanded()
    {
        return this.code + " - " + this.name;
    }
    public string getDescription()
    {
        return this.description;
    }
    public double getPriceNoVAT()
    {
        return this.price;
    }
    public double getPriceVAT()
    {
        return this.price + (this.price * this.VAT / 100);
    }
    public int getVAT()
    {
        return this.VAT;
    }

    //---- GETTER E SETTER ----


    //---- FUNZIONI BASE ----
    public string getPricePadded()
    {
        string productCode = this.code.ToString();

        if (this.code.ToString().Length < 8){

            for (int i = this.code.ToString().Length; i < 8; i++)
            {
                productCode = "0" + productCode;
            };

            return productCode;
        }
        else {
            return this.code.ToString();
        }
        
    }

    //---- FUNZIONI BASE ----

}

