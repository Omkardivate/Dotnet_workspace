namespace BLL;

using BOL;
using DAL;
public class StudentManager
{
    public List<Student> GetAllStudents(){
        List<Student> slist= DBManager.GetStudentList();
        return slist;
    }

}
