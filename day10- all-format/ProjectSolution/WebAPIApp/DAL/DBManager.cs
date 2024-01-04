namespace DAL;

using System;
using System.Collections.Generic;
using System.Net.Http;
using MySql.Data.MySqlClient;

using BOL;
using System.Text.Json;
using System.Threading.Tasks;

public class DBManager
{
    public static List<Product> GetAllProducts(){
            List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { Id = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", Balance = 7000 });
            allProducts.Add(new Product { Id = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", Balance = 3400 });
            allProducts.Add(new Product { Id = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", Balance = 27000 });
            allProducts.Add(new Product { Id = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", Balance = 1000 });
            allProducts.Add(new Product { Id = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", Balance = 2000 });
            allProducts.Add(new Product { Id = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", Balance = 159 });
            allProducts.Add(new Product { Id = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", Balance = 67 });
            allProducts.Add(new Product { Id = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { Id = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { Id = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { Id = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", Balance = 700 });
            allProducts.Add(new Product { Id = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", Balance = 1500 });
            allProducts.Add(new Product { Id = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", Balance = 2300 });
            allProducts.Add(new Product { Id = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Balance = 10000 });
            return allProducts;
    }
    public static List<Product> GetAllProductsFromFile(string path){       
            if(File.Exists(path)){
                string jsonString=File.ReadAllText(path);
            List<Product> allProducts=JsonSerializer.Deserialize<List<Product>>(jsonString);
            return allProducts ;
            }
            else
            {
                return GetAllProducts();
            }  
    }
    
    /*
    public static List<Product> GetAllProductsFromDatabase()
    {
            List<Product> allProducts = new List<Product>();
            
            //Using MYSQL 
            //database connectivity using  ADO.NET (RDBMS)
            //database connectiity using  ORM (Entity Framework)

            //database connectivity using MONGO db
            return allProducts;
    }

    public static List<Product> GetAllProductsFromExternalServices()
    {
        List<Product> allProducts = new List<Product>();
            
        // get all JSON data from REST API
         --------------------copied-------------------------

        try
        {
            // Example REST API endpoint URL
            string apiUrl = "https://api.example.com/products";

            using (HttpClient client = new HttpClient())
            {
                // Send a GET request to the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Read and parse the JSON data
                    string jsonResult = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON into a list of Product objects
                    // Example: Use Newtonsoft.Json.JsonConvert for deserialization
                    allProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(jsonResult);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    // Handle the error appropriately
                }
            }

            // Connect to MySQL database and perform database operations
            string connectionString = "Server=your_server;Database=your_database;User=your_user;Password=your_password;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Example: Insert all products into MySQL
                foreach (Product product in allProducts)
                {
                    string insertQuery = $"INSERT INTO your_table (column1, column2, ...) VALUES (@value1, @value2, ...)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

                    // Example: Assuming your Product class has properties like Name, Price, etc.
                    insertCommand.Parameters.AddWithValue("@value1", product.Name);
                    insertCommand.Parameters.AddWithValue("@value2", product.Price);
                    // Add parameters for other columns accordingly

                    await insertCommand.ExecuteNonQueryAsync();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception appropriately
        }


        ------------------end here-----------------------
        //database connectivity using MONGO db
        return allProducts;
    }

    public    static Product GetProductById(int id){
        List<Product> products = GetAllProducts();
        // var product = ( from prod in products
        //               where prod.Title == "Gerbera"
        //               select prod);
         


        Product product=new Product { Id = 1, Title = "Gerbera", 
                                Description = "Wedding Flower",
                                UnitPrice = 6, Category = "Flower",
                                Balance = 5000 };

        //  List<product> produts=new List<product>();
        //  List<product> foundproducts=null;
        //   foreach( Product p in product){
        //     if(p.Title=="Gerbera"){
        //         foundproducts.Add(p);
        //     }
        //   }
        

        return product; 
    }
    */
}

 