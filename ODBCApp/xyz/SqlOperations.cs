namespace SQLnm;
using MySql.Data.MySqlClient;

class SQL
{
    static MySqlConnection conn;
    static MySqlCommand command;

    static SQL()
    {
        conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac18;password=welcome;database=dac18";
        conn.Open();
    }

    public void GetAllProducts()
    {
        string query = "select * from productdemo";
        command = new MySqlCommand(query, conn);

        try
        {
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
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    public void InsertProduct()
    {
        string query = "insert into productdemo values(@pid,@pname,@qty,@unitprice)";
        int pid = int.Parse(Console.ReadLine());
        string pname = Console.ReadLine();
        int qty = int.Parse(Console.ReadLine());
        int unitprice = int.Parse(Console.ReadLine());

        command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@pid", pid);
        command.Parameters.AddWithValue("@pname", pname);
        command.Parameters.AddWithValue("@qty", qty);
        command.Parameters.AddWithValue("@unitprice", unitprice);

        try
        {
            int status = command.ExecuteNonQuery();
            if (status != 0)
            {
                Console.WriteLine("inseted successfully...");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Closed()
    {
        conn.Close();
    }

}