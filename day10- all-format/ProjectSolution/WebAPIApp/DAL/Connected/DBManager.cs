namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
//using inbuilt, external Object Models
public class DBManager{
    public static string conString=@"server=localhost;port=3306;user=root; password=password;database=transflower";       

    public static List<Product> GetAllProducts(){
       List<Product> list=new List<Product>();
        MySqlConnection connection = new MySqlConnection();  //1. create 'MySqlConnection' object
        connection.ConnectionString ="server=localhost;port=3306;user=root;password=password;database=ecommerce"; //2. create ConnectionString
        string query ="select * from products";  
        MySqlCommand command = new MySqlCommand(query, connection);   //3. create 'MySqlCommand' object
        try{
            connection.Open();  //4. open connection
            MySqlDataReader reader=command.ExecuteReader();  //5. Execute command- using ExecuteReader
            
            while(reader.Read()){
            Product product=new Product();
            int id=int.Parse(reader["product_id"].ToString());
            string title=reader["product_title"].ToString();
            string description=reader["description"].ToString();
            product.Id=id;
            product.Title=title;
            product.Description=description;
            list.Add(product);
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return list;
    }
    }