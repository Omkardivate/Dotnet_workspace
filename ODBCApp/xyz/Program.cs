using MySql.Data.MySqlClient;
using SQLnm;


SQL obj = new SQL();

// obj.GetAllProducts();
obj.InsertProduct();
obj.Closed();









/*
MySqlConnection conn = new MySqlConnection();
conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac18;password=welcome;database=dac18";

string query = "select * from productdemo";

MySqlCommand command = new MySqlCommand(query, conn);
Console.WriteLine("Welcome to ODBC");

try{
    conn.Open();
    MySqlDataReader reader = command.ExecuteReader();

    while (reader.Read())
    {
        int pid = int.Parse(reader["pid"].ToString());
        string pname = reader["pname"].ToString();
        int qty = int.Parse(reader["qty"].ToString());
        int unitprice = int.Parse(reader["unitprice"].ToString());
        Console.WriteLine(pid + " " + pname + " " + qty + " " + unitprice);
    }
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    conn.Close();
} */




