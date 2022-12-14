

public class Water : Product
{
    protected double Gallons = 3.785;
    public double LitersMax { get; }
    public double LitersAvailable { get; set; }
    public double Ph { get; }
    public string Fount { get; }


    public Water( double ph, string fount, double liters)
    {
        Ph = ph;
        Fount = fount;
        LitersMax = liters;
        LitersAvailable = LitersMax;
    }

    public override void printInfo()
    {
        Console.WriteLine(" ");
        Console.WriteLine("---------");
        Console.WriteLine("Codice: " + this.Code);
        Console.WriteLine("Nome: " + this.Name);
        Console.WriteLine("Nome Epspanso: " + this.getNameExpanded());
        Console.WriteLine("Descrizione: " + this.Description);
        Console.WriteLine("PH: " + this.Ph);
        Console.WriteLine("Sorgente: " + this.Fount);
        Console.WriteLine("---------");
        Console.WriteLine("Prezzo NO IVA: " + this.Price + " €");
        Console.WriteLine("IVA: " + this.VAT + " %");
        Console.WriteLine("Prezzo CON IVA: " + this.getPriceVAT() + " €");
        Console.WriteLine("---------");
        Console.WriteLine("PADDED CODE: " + this.getPricePadded());
        Console.WriteLine(" ");

    }

    public void emptyWater()
    {
        this.LitersAvailable = 0;
    }

    public void drinkWater( double water )
    {
        if (this.LitersAvailable > 0 && this.LitersAvailable >= water)
        {
            this.LitersAvailable = this.LitersAvailable - water;

        }
        else if (this.LitersAvailable == 0)
        {
            Console.WriteLine("La bottiglia d'acqua è vuota");

        }
        else
        {
            Console.WriteLine("La quantità richiesta è maggiore di quella disponibile, la bottiglia è stata svuotata");
            this.emptyWater();

        }
    }

    public double convertToGallons()
    {
        return this.LitersAvailable * Gallons;
    }

}