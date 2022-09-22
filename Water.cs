﻿
public class Water : Product
{

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

}