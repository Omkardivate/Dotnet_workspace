namespace partialnm;

public partial class Adi
{
    public int Prn
    {
        get; set;
    }

    public void Display()
    {
        Console.WriteLine(Prn + " " + Name);
    }
}