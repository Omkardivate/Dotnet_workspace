namespace DAL;
using System.Globalization;

using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    private static string constring="server=localhost;port=3306;user=root;password=welcome@om;database=practice";
    public static List<Student> GetStudentList(){
        List<Student> slist= new List<Student>();

        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=constring;

        string query="select * from studentdemo order by id";
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
                //Console.WriteLine(id+" "+fname+" "+lname+" "+date+" "+email);
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
        connection.ConnectionString=constring;

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

    public static Student GetStudent(int idd){
        Student s=null;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=constring;

        string query="select * from studentdemo where id=@id";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",idd);

            MySqlDataReader reader= command.ExecuteReader();
            reader.Read();
                int id= int.Parse(reader["id"].ToString());
                string fname= reader["namefirst"].ToString();
                string lname= reader["namelast"].ToString();
                string date= reader["dob"].ToString();
                string email= reader["emailid"].ToString();
            s= new Student{Id=id, FName=fname, LName=lname, Date=date, Email=email };
            
        }
        catch (Exception ex)
        {
             Console.WriteLine(ex.Message);
        }
        finally{
            connection.Close();
        }
        return s;
    }
    
    public static bool Update(int id,string fname,string lname,string email){
        bool status=false;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=constring;

        string query="update studentdemo set namefirst=@fname,namelast=@lname,emailid=@email where id=@id";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@fname",fname);
            command.Parameters.AddWithValue("@lname",lname);
            command.Parameters.AddWithValue("@email",email);
             Console.WriteLine("Update from DB"+lname);
            int flag= command.ExecuteNonQuery();
            if(flag!=0){
                status=true;
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

    public static bool DeleteStudent(int id){
        bool status=false;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=constring;

        string query="delete from studentdemo where id=@id";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",id);

            int flag= command.ExecuteNonQuery();
            if(flag!=0){
                status=true;
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

    public static bool Insert(int id,string fname,string lname,string date,string email){
        bool status=false;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=constring;

        string query="insert into studentdemo values(@id,@fname,@lname,@date,@email)";
        try
        {
            connection.Open();
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@fname",fname);
            command.Parameters.AddWithValue("@lname",lname);
            command.Parameters.AddWithValue("@date",date);
            command.Parameters.AddWithValue("@email",email);

            int flag= command.ExecuteNonQuery();
            if(flag!=0){
                status=true;
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
