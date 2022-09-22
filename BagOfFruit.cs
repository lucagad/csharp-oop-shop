

public class BagOfFruit : Product
{
    public int PiecesMax { get; }
    public int PiecesAvailable { get; set; }
    public DateOnly ExpirationDate { get; }
    public string TypeFruit { get; }

    public BagOfFruit(string type, DateOnly expiration, int pieces)
    {
        TypeFruit = type;
        ExpirationDate = expiration;
        PiecesMax = pieces;
        PiecesAvailable = PiecesMax;
    }

    public override void printInfo()
    {
        Console.WriteLine(" ");
        Console.WriteLine("---------");
        Console.WriteLine("Codice: " + this.Code);
        Console.WriteLine("Nome: " + this.Name);
        Console.WriteLine("Nome Epspanso: " + this.getNameExpanded());
        Console.WriteLine("Descrizione: " + this.Description);
        Console.WriteLine("TIPO: " + this.TypeFruit);
        Console.WriteLine("PEZZI: " + this.PiecesAvailable);
        Console.WriteLine("---------");
        Console.WriteLine("Prezzo NO IVA: " + this.Price + " €");
        Console.WriteLine("IVA: " + this.VAT + " %");
        Console.WriteLine("Prezzo CON IVA: " + this.getPriceVAT() + " €");
        Console.WriteLine("---------");
        Console.WriteLine("PADDED CODE: " + this.getPricePadded());
        Console.WriteLine(" ");

    }

}