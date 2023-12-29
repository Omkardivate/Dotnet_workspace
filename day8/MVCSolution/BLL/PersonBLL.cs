namespace BLL;
using BOL;// bcoz we're using 'Person' to create list
using DAL;
public class PersonBLL
{

    public List<Person> GetAllStudents()
    {
        List<Person> students = DBManager.GetAllPerson();
        return students;
    }
}