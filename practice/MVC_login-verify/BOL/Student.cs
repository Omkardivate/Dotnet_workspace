namespace BOL;

public class Student
{
    private int id;
    private string fname;
    private string lname;
    private string date;
    private string email;

    public int Id{
        get{
            return this.id;
        }
        set{
            this.id=value;
        }
    }

    public string FName{
        get{
            return this.fname;
        }
        set{
            this.fname=value;
        }
    }

    public string LName{
        get{
            return this.lname;
        }
        set{
            this.lname=value;
        }
    }

    public string Date{
        get{
            return this.date;
        }
        set{
            this.date=value;
        }
    }

    public string Email{
        get{
            return this.email;
        }
        set{
            this.email=value;
        }
    }

    public override string ToString(){
        return (id+" "+fname+" "+lname+" "+date+" "+email);
    } 
}
