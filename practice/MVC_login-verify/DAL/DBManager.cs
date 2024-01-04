namespace DAL;

using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static List<Student> GetStudentList(){
        List<Student> slist= new List<Student>();

        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome@om;database=practice";

        string query="select * from student";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);

            MySqlDataReader reader= command.ExecuteReader();
            while(reader.Read()){
                int id= int.Parse(reader["id"].ToString());
                string fname= reader["namefirst"].ToString();
                string lname= reader["namelast"].ToString();
                string date= reader["dob"].ToString();
                string email= reader["emailid"].ToString();

                slist.Add(new Student { Id=id, FName=fname, LName=lname, Date=date, Email=email});
                Console.WriteLine(id+" "+fname+" "+lname+" "+date+" "+email);
            }
            
        }
        catch (Exception ex)
        {
             Console.WriteLine(ex.Message);
        }
        return slist;
    }

    
}
