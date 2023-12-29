namespace DAL.DisConnected;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;
public class DBManager{
    public static string conString=@"server=localhost;port=3306;user=root; password=password;database=ecommerce";       

    public static List<Product> GetAllProducts(){
        List<Product> products=new List<Product> ();
        MySqlConnection connection=new MySqlConnection();   //1. create 'MySqlConnection' object
        connection.ConnectionString=conString;  //2. create ConnectionString
        try{
            DataSet ds=new DataSet();  //3. create empty dataset object
            MySqlCommand cmd=new MySqlCommand();  //4. create MySqlCommand object
            cmd.Connection=connection;   //5. established Connection
            string query="SELECT * FROM products";
            cmd.CommandText=query;  //6. assign query to CommandText
            //disconnected Data Access logic
            MySqlDataAdapter da=new MySqlDataAdapter();  
            da.SelectCommand = cmd;
            da.Fill(ds);  // this method would fetch data from backend mysql and 
                          //fill results into dataset collection
                          //deal with data which has been fetched from back end
            
            DataTable dt=ds.Tables[0];
            DataRowCollection rows=dt.Rows;
            foreach( DataRow row in rows)
            {
                int id = int.Parse(row["product_id"].ToString());
                string title = row["product_title"].ToString();
                string description = row["description"].ToString();
                Product product=new Product{
                                                Id = id,
                                                Title = title,
                                                Description = description
                };
                products.Add(product);
            }
        }
        catch(Exception ee){
                Console.WriteLine(ee.Message);
        }

        return products;

    }

}