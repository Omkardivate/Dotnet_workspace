namespace BLL;

using BOL;
using DAL;
public class StudentManager
{
    public List<Student> GetAllStudents(){
        List<Student> slist= DBManager.GetStudentList();
        return slist;
    }

    public List<Credentials> GetCredentials(){
        List<Credentials> slist= DBManager.GetCredentials();
        return slist; 
    }

    public bool Edit(int id,string fn,string ln,string email){
        bool status=DBManager.Edit(id,fn,ln,email);
        return status; 
    }
}
