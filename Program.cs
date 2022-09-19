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

test.setProductName("Prodotto test");
test.setProductDescription("Dexrizione Test");
test.setProductPrice(100);
test.setProductVAT(22);

// SET INFORMAZIONI

// STAMPA A VIDEO LE INFORMAZIONI

Console.WriteLine("---------");
Console.WriteLine("Codice: " + test.getProductCode());
Console.WriteLine("Nome: " + test.getProductName());
Console.WriteLine("Nome Epspanso: " + test.getProductNameExpanded());
Console.WriteLine("Descrizione: " + test.getProductDescription());
Console.WriteLine("---------");

Console.WriteLine("Prezzo NO IVA: "+ test.getProductPriceNoVAT() + "Euro");
Console.WriteLine("IVA: " + test.getProductVAT() + " %");
Console.WriteLine("Prezzo CON IVA: " + test.getProductPriceVAT() + "Euro");

Console.WriteLine("---------");

Console.WriteLine("PADDED CODE: " + test.getPricePadded());

// STAMPA A VIDEO LE INFORMAZIONI

public class Product
{
    private int productCode;
    private string productName;
    private string productDescription;
    private double productPrice;
    private int productVAT;

    public Product()
    {
        Random rnd = new Random();
        this.productCode = rnd.Next(0,99999999);
    }

    //---- GETTER E SETTER ----
    public void setProductPrice(double price)
    {
        this.productPrice = price;
    }
    public void setProductVAT(int VAT)
    {
        this.productVAT = VAT;
    }
    public void setProductName(string name)
    {
        this.productName = name;
    }
    public void setProductDescription(string description)
    {
        this.productDescription = description;
    }
    public int getProductCode()
    {
        return this.productCode;
    }
    public string getProductName()
    {
        return this.productName;
    }
    public string getProductNameExpanded()
    {
        return this.productCode + " - " + this.productName;
    }
    public string getProductDescription()
    {
        return this.productDescription;
    }
    public double getProductPriceNoVAT()
    {
        return this.productPrice;
    }
    public double getProductPriceVAT()
    {
        return this.productPrice + (this.productPrice * this.productVAT / 100);
    }
    public int getProductVAT()
    {
        return this.productVAT;
    }

    //---- GETTER E SETTER ----


    //---- FUNZIONI BASE ----

    public string getPricePadded()
    {
        string productCode = this.productCode.ToString();

        if (this.productCode.ToString().Length < 8){

            for (int i = this.productCode.ToString().Length; i < 8; i++)
            {
                productCode = "0" + productCode;
            };


            return productCode;
        }
        else {
            return this.productCode.ToString();
        }
        
    }

    //---- FUNZIONI BASE ----

}

