namespace BLL;
using BOL;
using DAL;

public class UserManager
{
    public List<User> GetUsers(){
        List<User> ulist= DBManager.GetAllUsers() ;
        return ulist;
    }
}
