namespace BOL;

public class Person
{
    public string Name { get; set; }
    public int Prn { get; set; }
    public string College { get; set; }

    public Person() : this("NaN", 0, "NaN")
    {

    }
    public Person(string nm, int prn, string clg)
    {
        Name = nm;
        Prn = prn;
        College = clg;
    }

    public override string ToString()
    {
        return Name + " " + Prn + " " + College;
    }

}