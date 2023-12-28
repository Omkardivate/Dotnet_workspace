namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static List<Person> GetAllPerson()
    {
        List<Person> students = new List<Person>();
        // students.Add(new Person("Adi", 23069, "IET"));
        // students.Add(new Person("Omi", 72069, "Iet"));

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac18;password=welcome;database=dac18";

        string query = "select * from studentdemo";

        MySqlCommand command = new MySqlCommand(query, conn);
        Console.WriteLine("Welcome to ODBC");

        try
        {
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (reader["name"].ToString());
                int prn = int.Parse(reader["prn"].ToString());
                string college = (reader["college"].ToString());

                students.Add(new Person(name, prn, college));

                // Console.WriteLine(name + " " + prn + " " + college );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return students;
    }
}