namespace BLL;

using BOL;
using DAL;

public class ProjectManager{
    public static List<Activity> GetAll(){
        List<Activity> items= DBManager.GetAll();
        return items;
    }

}