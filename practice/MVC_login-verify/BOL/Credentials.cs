namespace BOL;

public class Credentials
{
    private int id;
    private string username;
    private string password;

    public int Id{
        get{
            return this.id;
        }
        set{
            this.id=value;
        }
    }

    public string UserName{
        get{
            return this.username;
        }
        set{
            this.username=value;
        }
    }

    public string Password{
        get{
            return this.password;
        }
        set{
            this.password=value;
        }
    }


    public override string ToString(){
        return (id+" "+username+" "+password);
    } 
}
