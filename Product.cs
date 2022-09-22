

public class Product
{
    public int Code { get;}
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int VAT { get; set; }

    public Product()
    {
        Random rnd = new Random();
        this.Code = rnd.Next(0,99999999);
    }

    //---- FUNZIONI BASE ----

    public string getNameExpanded()
    {
        return this.Code + " - " + this.Name;
    }

    public double getPriceVAT()
    {
        return this.Price + (this.Price * this.VAT / 100);
    }

    public string getPricePadded()
    {
        string productCode = this.Code.ToString();

        if (this.Code.ToString().Length < 8){

            for (int i = this.Code.ToString().Length; i < 8; i++)
            {
                productCode = "0" + productCode;
            };

            return productCode;
        }
        else {
            return this.Code.ToString();
        }
        
    }

    //---- FUNZIONI BASE ----

}
