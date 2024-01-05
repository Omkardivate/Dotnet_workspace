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

    public Student GetStudent(int id){
        Student s=DBManager.GetStudent(id);
        return s; 
    }
    
    public bool Update(int id,string fname,string lname,string email){
        bool status=DBManager.Update(id,fname,lname,email);
        return status; 
    }
    
    public bool DeleteStudent(int id){
        bool status=DBManager.DeleteStudent(id);
        return status; 
    }

    public bool Insert(int id,string fname,string lname,string date,string email){
        bool status=DBManager.Insert( id, fname, lname, date, email);
        return status; 
    }
}
