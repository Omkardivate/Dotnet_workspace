namespace RGB;

public struct Color{
    public int red;
    public int green;
    public int blue;

    public Color(int r,int g,int b){
        this.red=r;
        this.green=g;
        this.blue=b;
    }

    public void GetColors(){
        Console.WriteLine("red="+red+" green="+green+" blue="+blue);
    }
}