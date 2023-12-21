namespace HR;

public class Person{
    private int id;
    private string firstName;

    public Person(): this(0)
    {}

    public Person(int id)
    {
        this.id=id;
    }

    // ~Person(){}

    //formal setter-getter
    public void SetId(int id){   
        this.id=id;
    }

    public int GetId(){
        return this.id;
    }

    //property setter-getter syntax
    public string FirstName{
        get{
            return this.FirstName;
        }
        set{
            this.FirstName=value;
        }
    }

    // Auto-property setter-getter syntax
    public string LastName{ get; set;} //also creates variable LastName

    // toString()
     public override string ToString()
    {
        return this.id+" "+this.FirstName +" "+ this.LastName;
        //return base.ToString();
    }

}