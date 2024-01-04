namespace DAL;

using BOL;

public class DBManager{
    public static List<Activity> GetAll(){
    List<Activity> items=new List<Activity>();

    items.Add(new Activity{Id=1,Name="omkar",IsComplete=true} );
    items.Add(new Activity{Id=2,Name="soham",IsComplete=true} );
    items.Add(new Activity{Id=3,Name="kunal",IsComplete=false} );
    items.Add(new Activity{Id=4,Name="neha",IsComplete=true} );
    items.Add(new Activity{Id=5,Name="parth",IsComplete=false} );

    //Connected Data Access using ADO.NET
    //OR 
    //Disconnected Data Accessing ADO.NET 
    //OR
    //Data Access using Entity Framework
    return items;
}

}