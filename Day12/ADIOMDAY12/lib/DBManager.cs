using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using BOL;
namespace DAL;

public class DBManager
{
    public static List<Products> GetProducts(){
        List<Products> ls=new List<Products>();

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString ="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";

        string query ="select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader= command.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["ProductID"].ToString());
                string name=reader["ProductName"].ToString();

                Console.WriteLine(id+ " "+ name+ " ");
                Products p= new Products{Id=id,Name=name};

                ls.Add(p);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return ls;
    }
}
