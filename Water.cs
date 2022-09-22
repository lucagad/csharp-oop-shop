
public class Water : Product
{

    public double Liters { get; set; }
    public double Ph { get; }
    public string Fount { get; }


    public Water( double ph, string fount)
    {
        Ph = ph;
        Fount = fount;
    }

}