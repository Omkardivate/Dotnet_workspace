namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static List<User> GetAllUsers(){
        List<User> ulist= new List<User>();
        MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome@om;database=practice";

        string query="select * from userdata";
        MySqlCommand command=new MySqlCommand(query,connection);

        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["username"].ToString();
                string pwd = reader["password"].ToString();
                User uobj= (new User {Id=id, Name=name, Pwd= pwd} );
                ulist.Add(uobj);
                //Console.WriteLine(id + " " + name + " " + pwd );
            }
            reader.Close();

        }
        catch (System.Exception ex)
        {
             Console.WriteLine("Exception occured...");
        }
        finally{
            connection.Close();
        }
        return ulist;

    }
}
