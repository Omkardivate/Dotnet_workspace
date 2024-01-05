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
        finally{
            connection.Close();
        }
        return slist;
    }

    public static List<Credentials> GetCredentials(){
        List<Credentials> slist= new List<Credentials>();

        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome@om;database=practice";

        string query="select * from login";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);

            MySqlDataReader reader= command.ExecuteReader();
            while(reader.Read()){
                int id= int.Parse(reader["id"].ToString());
                string username= reader["username"].ToString();
                string password= reader["password"].ToString();
                

                slist.Add(new Credentials { Id=id, UserName=username, Password=password });
                Console.WriteLine(id+" "+username+" "+password);
            }
            
        }
        catch (Exception ex)
        {
             Console.WriteLine(ex.Message);
        }
        finally{
            connection.Close();
        }
        return slist;
    }

    public static bool Edit(int id,string fn,string ln,string email){
        bool status=false;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome@om;database=practice";

        string query="update student set  namefirst=@fn, namelast=@ln,emailid=@email where id=@ID";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@Id",id);
            command.Parameters.AddWithValue("@fn",fn);
            command.Parameters.AddWithValue("@ln",ln);
            command.Parameters.AddWithValue("@email",email);

            int flag= command.ExecuteNonQuery();

            if(flag!=0){
                status= true;
            }
            
        }
        catch (Exception ex)
        {
             Console.WriteLine(ex.Message);
        }
        finally{
            connection.Close();
        }
        return status;
    }
}
